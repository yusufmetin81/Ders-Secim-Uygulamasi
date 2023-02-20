using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Proje.accdb");
        OleDbDataAdapter adptr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbCommand komut = new OleDbCommand();
        DataSet tercihDS = new DataSet();
        List<KeyValuePair<int, string>> ders1ListesiCombo;
        List<KeyValuePair<int, string>> ders2ListesiCombo;
        List<KeyValuePair<int, string>> ders3ListesiCombo;
        List<KeyValuePair<int, string>> ders4ListesiCombo;
        List<KeyValuePair<int, string>> ders5ListesiCombo;

        void listele()
        {
            ds.Clear();
            BaglantiAc();
            DersListele();
            adptr = new OleDbDataAdapter("select*from Ogrenciler", baglantı);
            adptr.Fill(ds, "Ogrenciler");
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Adı Soyadı");
            table.Columns.Add("Verilen Ders");
            table.Columns.Add("Ders1");
            table.Columns.Add("Ders2");
            table.Columns.Add("Ders3");
            table.Columns.Add("Ders4");
            table.Columns.Add("Ders5");
            foreach(DataRow row in ds.Tables["Ogrenciler"].Rows)
            {
                table.Rows.Add(row["ID"],row["Adi"]+ " "+ row["Soyadi"], ders1ListesiCombo.Find(d1 => d1.Key == Convert.ToInt32(row["VerilenDers"])).Value, ders1ListesiCombo.Find(d1 => d1.Key == Convert.ToInt32(row["ders1"])).Value, ders2ListesiCombo.Find(d1 => d1.Key == Convert.ToInt32(row["ders2"])).Value, ders3ListesiCombo.Find(d1 => d1.Key == Convert.ToInt32(row["ders3"])).Value, ders3ListesiCombo.Find(d1 => d1.Key == Convert.ToInt32(row["ders4"])).Value, ders3ListesiCombo.Find(d1 => d1.Key == Convert.ToInt32(row["ders5"])).Value);
            }
            dataGridView1.DataSource = table;
            BaglantiKapat();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DersListele();
        }

        private void DersListele()
        {
            ds.Clear();
            BaglantiAc();
            adptr = new OleDbDataAdapter("select * from Dersler", baglantı);
            adptr.Fill(ds, "Dersler");
            DataTable dt = ds.Tables["Dersler"];
            dersListesi.Items.Clear();
            ders1ListesiCombo = new List<KeyValuePair<int, string>>();
            ders2ListesiCombo = new List<KeyValuePair<int, string>>();
            ders3ListesiCombo = new List<KeyValuePair<int, string>>();
            ders4ListesiCombo = new List<KeyValuePair<int, string>>();
            ders5ListesiCombo = new List<KeyValuePair<int, string>>();

            foreach (DataRow dr in dt.Rows)
            {
                String dersAd = dr["ID"] + " - " + dr["dersAd"].ToString();
                dersListesi.Items.Add(dersAd);
                ders1ListesiCombo.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["ID"]), dr["dersAd"].ToString()));
                ders2ListesiCombo.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["ID"]), dr["dersAd"].ToString()));
                ders3ListesiCombo.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["ID"]), dr["dersAd"].ToString()));
                ders4ListesiCombo.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["ID"]), dr["dersAd"].ToString()));
                ders5ListesiCombo.Add(new KeyValuePair<int, string>(Convert.ToInt32(dr["ID"]), dr["dersAd"].ToString()));
            }
            ders1Listesi.DataSource = ders1ListesiCombo;
            ders1Listesi.ValueMember = "Key";
            ders1Listesi.DisplayMember = "Value";
            ders2Listesi.DataSource = ders2ListesiCombo;
            ders2Listesi.ValueMember = "Key";
            ders2Listesi.DisplayMember = "Value";
            ders3Listesi.DataSource = ders3ListesiCombo;
            ders3Listesi.ValueMember = "Key";
            ders3Listesi.DisplayMember = "Value";
            ders4Listesi.DataSource = ders4ListesiCombo;
            ders4Listesi.ValueMember = "Key";
            ders4Listesi.DisplayMember = "Value";
            ders5Listesi.DataSource = ders5ListesiCombo;
            ders5Listesi.ValueMember = "Key";
            ders5Listesi.DisplayMember = "Value";
            ders1Listesi.SelectedItem = null;
            ders2Listesi.SelectedItem = null;
            ders3Listesi.SelectedItem = null;
            ders4Listesi.SelectedItem = null;
            ders5Listesi.SelectedItem = null;
            BaglantiKapat();
        }

        private void dersAd_TextChanged(object sender, EventArgs e)
        {
            if(dersAd.Text.Length > 0)
            {
                dersKaydet.Enabled = true;
            }
            else
            {
                dersKaydet.Enabled = false;
            }
        }

        private void dersKaydet_Click(object sender, EventArgs e)
        {
            BaglantiAc();
            komut.Connection = baglantı;
            komut.CommandText = "Insert into Dersler(dersAd) values('" + dersAd.Text + "')";
            komut.ExecuteNonQuery();
            BaglantiKapat();
            DersListele();
        }

        private void BaglantiAc()
        {
            if(baglantı.State != ConnectionState.Open)
            {
                baglantı.Open();
            }
        }
        private void BaglantiKapat()
        {
            if (baglantı.State == ConnectionState.Open)
            {
                baglantı.Close();
            }
        }

        private void TercihKaydet_Click(object sender, EventArgs e)
        {
            BaglantiAc();
            komut.Connection = baglantı;
            DataTable dt = ds.Tables["Ogrenci"];
            if (dt != null && dt.Rows.Count > 0) {
                komut.CommandText = "Delete from DersKayit where ogrenciId=" + OgrenciID.Text;
                komut.ExecuteNonQuery();
                komut.CommandText = "Update Ogrenciler set Adi = '" + OgrenciAd.Text + "',Soyadi ='" + OgrenciSoyad.Text + "',Ders1 = '" + ders1Listesi.SelectedValue + "',Ders2='" + ders2Listesi.SelectedValue + "',Ders3='" + ders3Listesi.SelectedValue + "',Ders4='" + ders4Listesi.SelectedValue + "',Ders5='" + ders5Listesi.SelectedValue + "' Where ID=" + OgrenciID.Text;
            }
            else
            {
                komut.CommandText = "Insert into Ogrenciler(ID,Adi,Soyadi,Ders1,Ders2,Ders3,Ders4,Ders5) values('" + OgrenciID.Text + "','" + OgrenciAd.Text + "','" + OgrenciSoyad.Text + "','" + ders1Listesi.SelectedValue + "','" + ders2Listesi.SelectedValue + "','" + ders3Listesi.SelectedValue + "','" + ders4Listesi.SelectedValue + "','" + ders5Listesi.SelectedValue + "')";
            }
            komut.ExecuteNonQuery();
            DersKayıt(ders1Listesi.SelectedValue.ToString(), OgrenciID.Text, 1);
            DersKayıt(ders2Listesi.SelectedValue.ToString(), OgrenciID.Text, 2);
            DersKayıt(ders3Listesi.SelectedValue.ToString(), OgrenciID.Text, 3);
            DersKayıt(ders4Listesi.SelectedValue.ToString(), OgrenciID.Text, 4);
            DersKayıt(ders5Listesi.SelectedValue.ToString(), OgrenciID.Text, 5);
           
            BaglantiKapat();
            ds.Clear();
            listele();
        }

        private void DersKayıt(string dersId,string ogrenciId,int tercihSirasi)
        {
            komut.CommandText = "Insert into DersKayit(dersId,ogrenciId,tercihSirasi,pasifKayit) values(" + dersId + "," + ogrenciId + ","+tercihSirasi+",false)";
            komut.ExecuteNonQuery();
        }

        private void OgrenciID_TextChanged(object sender, EventArgs e)
        {
            if (OgrenciID.Text.Length > 0)
            {
                TercihGetir.Enabled = true;
            }
            else
            {
                TercihGetir.Enabled = false;
            }
        }

        private void TercihGetir_Click(object sender, EventArgs e)
        {
            OgrenciAd.Enabled = true;
            OgrenciSoyad.Enabled = true;
            ders1Listesi.SelectedItem = null;
            ders2Listesi.SelectedItem = null;
            ders3Listesi.SelectedItem = null;
            ders4Listesi.SelectedItem = null;
            ders5Listesi.SelectedItem = null;
            OgrenciAd.Text = "";
            OgrenciSoyad.Text = "";
            BaglantiAc();
            adptr = new OleDbDataAdapter("select * from Ogrenciler Where ID=" + OgrenciID.Text, baglantı);
            adptr.Fill(ds, "Ogrenci");
            DataTable dt = ds.Tables["Ogrenci"];
            foreach (DataRow dr in dt.Rows)
            {
                OgrenciAd.Text = dr["Adi"].ToString();
                OgrenciSoyad.Text = dr["Soyadi"].ToString();
                OgrenciAd.Enabled = false;
                OgrenciSoyad.Enabled = false;
                ders1Listesi.SelectedItem = ders1ListesiCombo.Find(s=> s.Key == Convert.ToInt32(dr["Ders1"]));
                ders2Listesi.SelectedItem = ders2ListesiCombo.Find(s=> s.Key == Convert.ToInt32(dr["Ders2"]));
                ders3Listesi.SelectedItem = ders3ListesiCombo.Find(s=> s.Key == Convert.ToInt32(dr["Ders3"]));
                ders4Listesi.SelectedItem = ders4ListesiCombo.Find(s=> s.Key == Convert.ToInt32(dr["Ders4"]));
                ders5Listesi.SelectedItem = ders5ListesiCombo.Find(s => s.Key == Convert.ToInt32(dr["Ders5"]));
            }
            BaglantiKapat();
        }

        private void Eslestir_Click(object sender, EventArgs e)
        {
            BaglantiAc();
            komut.Connection = baglantı;
            if(ds.Tables["Ogrenciler"] == null)
            {
                listele();
            }

            komut.CommandText = "Update DersKayit set pasifKayit=false";
            komut.ExecuteNonQuery();

            foreach (DataRow ogrenci in ds.Tables["Ogrenciler"].Rows)
            {
                if(DersAtamaları(ogrenci["ders1"].ToString(), ogrenci["ID"].ToString()))
                {
                    continue;
                }
                if (DersAtamaları(ogrenci["ders2"].ToString(), ogrenci["ID"].ToString()))
                {
                    continue;
                }
                if (DersAtamaları(ogrenci["ders3"].ToString(), ogrenci["ID"].ToString()))
                {
                    continue;
                }
                if (DersAtamaları(ogrenci["ders4"].ToString(), ogrenci["ID"].ToString()))
                {
                    continue;
                }
                if (DersAtamaları(ogrenci["ders5"].ToString(), ogrenci["ID"].ToString()))
                {
                    continue;
                }
            }
            listele();
            BaglantiKapat();
        }

        private bool DersAtamaları(string dersId,string ogrenciId)
        {
            tercihDS.Clear();
            adptr = new OleDbDataAdapter("select * from DersKayit Where dersId=" + dersId + " and pasifKayit=false order by tercihSirasi,Id asc", baglantı);
            adptr.Fill(tercihDS, "Tercihler");
            Int32 oncelikSayısı = 1;
            foreach (DataRow tercih in tercihDS.Tables["Tercihler"].Rows)
            {
                if (oncelikSayısı > 4)
                {
                    return false;
                }

                if (tercih["ogrenciId"].ToString() == ogrenciId)
                {
                    komut.CommandText = "Update Ogrenciler set VerilenDers='" + dersId + "' Where ID=" + ogrenciId;
                    komut.ExecuteNonQuery();
                    komut.CommandText = "Update DersKayit set pasifKayit=true Where ogrenciId=" + ogrenciId + "and dersId<>"+dersId;
                    komut.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    oncelikSayısı++;
                }
            }

            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
