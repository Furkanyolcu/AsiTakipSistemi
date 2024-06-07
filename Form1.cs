using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AsiTakip
{
    public partial class Form1 : Form
    {
        // Connection string is commented out for now.
        // private string connectionString = "Server=YOUR_SERVER_NAME;  FerhatOLCA Database=FerhatOLCA;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            LoadPersonelData();
            InitializeDataGridView();
        }

        private void LoadPersonelData()
        {
            List<string> personelListesi = new List<string>
            {
                "Emrah YILDIZ",
                "Ahmet KAYA",
                "Ayşe DEMİR",
                "Fatma YILMAZ",
                "Mehmet ÇELİK"
            };

            foreach (var personel in personelListesi)
            {
                comboBoxPersonel.Items.Add(personel);
            }

            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PersonelAdi, PersonelSoyadi FROM Personel";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string personelAdiSoyadi = reader["PersonelAdi"] + " " + reader["PersonelSoyadi"];
                            comboBoxPersonel.Items.Add(personelAdiSoyadi);
                        }
                    }
                }
            }
            */
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Add("AsiAdi", "Aşı Adı");
            dataGridView1.Columns.Add("RandevuTarihi", "Randevu Tarihi");
            dataGridView1.Columns.Add("AsiSaati", "Aşı Saati");
            dataGridView1.Columns.Add("HastaAdi", "Hasta Adı");
            dataGridView1.Columns.Add("HastaSoyadi", "Hasta Soyadı");
            dataGridView1.Columns.Add("PersonelAdiSoyadi", "Personel Adı Soyadı");
            dataGridView1.Columns.Add("Doz", "Doz");

            // Load initial data if any.
            /*
            LoadData();
            */
        }

        private void LoadData()
        {
            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AsiRandevulari";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            */
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            string asiAdi = txtAsiAdi.Text;
            string randevuTarihi = dtpRandevuTarihi.Value.ToString("yyyy-MM-dd");
            string asiSaati = dtpAsiSaati.Value.ToString("HH:mm");
            string hastaAdi = txtHastaAdi.Text;
            string hastaSoyadi = txtHastaSoyadi.Text;
            string personelAdiSoyadi = comboBoxPersonel.SelectedItem?.ToString();
            string doz = txtDoz.Text;

            if (string.IsNullOrWhiteSpace(asiAdi) || string.IsNullOrWhiteSpace(doz) || string.IsNullOrWhiteSpace(hastaAdi) || string.IsNullOrWhiteSpace(hastaSoyadi) || string.IsNullOrWhiteSpace(personelAdiSoyadi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the new entry to the DataGridView
            dataGridView1.Rows.Add(asiAdi, randevuTarihi, asiSaati, hastaAdi, hastaSoyadi, personelAdiSoyadi, doz);

            /*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO AsiRandevulari (AsiAdi, RandevuTarih, Asisaati, Doz, HastaAdi, HastaSoyadi, PersonelAdiSoyadi) " +
                               "VALUES (@asiAdi, @randevuTarihi, @asiSaati, @hastaAdi, @hastaSoyadi, @personelAdiSoyadi, @doz)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@asiAdi", asiAdi);
                    command.Parameters.AddWithValue("@randevuTarihi", randevuTarihi);
                    command.Parameters.AddWithValue("@asiSaati", asiSaati);
                    command.Parameters.AddWithValue("@hastaAdi", hastaAdi);
                    command.Parameters.AddWithValue("@hastaSoyadi", hastaSoyadi);
                    command.Parameters.AddWithValue("@personelAdiSoyadi", personelAdiSoyadi);
                    command.Parameters.AddWithValue("@doz", doz);

                    command.ExecuteNonQuery();
                }
            }
            */

            ClearFields();
        }

        private void ClearFields()
        {
            txtAsiAdi.Clear();
            txtDoz.Clear();
            txtHastaAdi.Clear();
            txtHastaSoyadi.Clear();
            comboBoxPersonel.SelectedIndex = -1;
        }
    }
}
