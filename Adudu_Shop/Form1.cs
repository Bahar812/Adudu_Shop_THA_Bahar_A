using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adudu_Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dataTampilan = new DataTable();
        DataTable dataCategory = new DataTable();
        DataTable dataFilterr = new DataTable();
        public string categoryNow = "";
        public string idNow = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTampilan.Columns.Add("ID Product");
            dataTampilan.Columns.Add("Nama Product");
            dataTampilan.Columns.Add("Harga");
            dataTampilan.Columns.Add("Stock");
            dataTampilan.Columns.Add("ID Category");
            comboBoxFilter.Enabled = false;
            dataTampilan.Rows.Add("J001", "Jas Hitam", 100000, 10, "C1");
            dataTampilan.Rows.Add("T001", "T-Shirt Black Pink", 70000, 20, "C2");
            dataTampilan.Rows.Add("T002", "T-Shirt Obsessive", 75000, 16, "C2");
            dataTampilan.Rows.Add("R001", "Rok mini", 82000, 26, "C3");
            dataTampilan.Rows.Add("J002", "Jeans Biru ", 90000, 5, "C4");
            dataTampilan.Rows.Add("C001", "Celana Pendek Coklat", 60000, 11, "C4");
            dataTampilan.Rows.Add("C002", "Cawat Blink-blink", 1000000, 1, "C5");
            dataTampilan.Rows.Add("R002", "Rocca Shirt ", 50000, 8, "C2");


            dataCategory.Columns.Add("ID Category", typeof(string));
            dataCategory.Columns.Add("Nama Category", typeof(string));

            dataCategory.Rows.Add("C1", "Jas");
            dataCategory.Rows.Add("C2", "T-Shirt");
            dataCategory.Rows.Add("C3", "Rok");
            dataCategory.Rows.Add("C4", "Celana");
            dataCategory.Rows.Add("C5", "Cawat");

            comboBoxFilter.Text = "";


            dataFilterr = dataTampilan.Copy();
            
            dataGridViewCategory.DataSource = dataCategory;
            dataGridViewTampil.DataSource = dataFilterr;
            // Mengisi ComboBox dengan data category dari DataGridView kedua
            comboBoxCategory.DataSource = dataCategory.Copy();
            comboBoxCategory.DisplayMember = "Nama Category";
            comboBoxCategory.ValueMember = "ID Category";

            comboBoxFilter.DataSource = dataCategory.Copy();
            comboBoxFilter.DisplayMember = "Nama Category";
            comboBoxFilter.ValueMember = "ID Category";
            dataGridViewCategory.CurrentCell = null;
            dataGridViewTampil.ClearSelection();
            dataGridViewTampil.CurrentCell = null;
            comboBoxCategory.Text = "";
            comboBoxFilter.Text = "";
        }


        public void CaraFilter(string nilai)
        {
            if (nilai == "")
            {
                dataFilterr.Rows.Clear();
                for (int i = 0; i < dataTampilan.Rows.Count; i++)
                {
                    DataRow row = dataFilterr.NewRow();
                    row[0] = dataTampilan.Rows[i][0];
                    row[1] =dataTampilan.Rows[i][1];
                    row[2] = dataTampilan.Rows[i][2];
                    row[3] = dataTampilan.Rows[i][3];
                    row[4] = dataTampilan.Rows[i][4];
                    dataFilterr.Rows.Add(row);
                }
            }
            else
            {
                dataFilterr.Rows.Clear();
                for (int j = 0; j < dataTampilan.Rows.Count; j++)
                {
                    if (dataTampilan.Rows[j][4].ToString() == nilai)
                    {
                        DataRow row = dataFilterr.NewRow();
                        row[0] = dataTampilan.Rows[j][0];
                        row[1] = dataTampilan.Rows[j][1];
                        row[2] = dataTampilan.Rows[j][2];
                        row[3] = dataTampilan.Rows[j][3];
                        row[4] = dataTampilan.Rows[j][4];
                        dataFilterr.Rows.Add(row);
                    }
                }
            }

            dataGridViewTampil.CurrentCell = null;
            dataGridViewCategory.CurrentCell = null;
            textBoxNamaProduct.Clear();
            textBoxHarga.Clear();
            textBoxStock.Clear();
            idNow = "";
            categoryNow = "";
            comboBoxCategory.DataSource = dataCategory.Copy();
            comboBoxFilter.DataSource = dataCategory.Copy();
            comboBoxCategory.Text = "";
            comboBoxFilter.Text = "";
            textBoxNamaCategory.Text = "";
        }
      
        private void buttonAddDetails_Click(object sender, EventArgs e)
        {
            if (textBoxNamaProduct.Text == "" || textBoxHarga.Text == "" || textBoxStock.Text == "" || comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("Data Kurang Lengkap", "NINUNINU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var adaID = dataTampilan.AsEnumerable().Select(roww => roww.Field<string>("ID Product"));
            string hurufDepan = textBoxNamaProduct.Text.Substring(0, 1).ToUpper();
            int newId = 1;

            foreach (DataRow roww in dataTampilan.Rows)
            {
                if (roww[0].ToString()[0].ToString() == hurufDepan)
                {
                    newId++;
                }
               
            }

            string newIdTampilan = hurufDepan + newId;
            for (int i = newId.ToString().Length; i < 3; i++)
            {
                hurufDepan = string.Concat(hurufDepan, "0");
            }
            hurufDepan = string.Concat(hurufDepan, newId.ToString());
            DataRow row = dataTampilan.NewRow();
            row[0] = hurufDepan;
            row[1] = textBoxNamaProduct.Text;
            row[2] = textBoxHarga.Text;
            row[3] = textBoxStock.Text;
            row[4] = comboBoxCategory.SelectedValue;
            dataTampilan.Rows.Add(row);
            CaraFilter("");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
           
            if (idNow == "")
            {
                MessageBox.Show("Pilih Objek yang ingin diedit terlebih dahulu !","NINUNINU",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string newValueNama = textBoxNamaProduct.Text;
                string newValueCategory = comboBoxCategory.SelectedValue.ToString();
                float newValueHarga = Convert.ToInt64(textBoxHarga.Text);
                int newValueStock = Convert.ToInt32(textBoxStock.Text);
                foreach (DataRow row in dataTampilan.Rows)
                {
                    if(row[0].ToString() != idNow)
                    {
                        continue;
                    }
                    else
                    {
                        row[1] = newValueNama;
                        row[2] = newValueHarga;
                        row[3] = newValueStock;
                        row[4] = newValueCategory;
                    }
                   
                    if (row[3].ToString() != "0")
                    {
                        continue;
                    }
                    else
                    {
                        dataTampilan.Rows.Remove(row);
                    }
                    
                    CaraFilter("");
                    return;
                }
            }
            CaraFilter("");
        }

        private void dataGridViewTampil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ambil baris terpilih di DataGridView
            DataGridViewRow row = dataGridViewTampil.Rows[e.RowIndex];
            // Set nilai pada setiap TextBox dengan nilai dari masing-masing kolom pada baris terpilih
            idNow = row.Cells[0].Value.ToString();
            textBoxNamaProduct.Text = row.Cells[1].Value.ToString();
            textBoxHarga.Text = row.Cells[2].Value.ToString();
            textBoxStock.Text = row.Cells[3].Value.ToString();
            comboBoxCategory.SelectedValue = row.Cells[4].Value.ToString();
        }


      

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            // Memeriksa apakah ada baris yang dipilih
            if (textBoxNamaProduct.Text == "" || textBoxHarga.Text == "" || textBoxStock.Text == "" || comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("Pilih Objek yang ingin dihapus terlebih dahulu !", "NINUNINU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataRow row in dataTampilan.Rows)
            {
                if (row[0].ToString() != idNow)
                {
                    continue;
                }
                dataTampilan.Rows.Remove(row);
                CaraFilter("");
                return;
            }
            CaraFilter("");
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string namaCategoryy = textBoxNamaCategory.Text;
            var adaID = dataCategory.AsEnumerable().Select(row => row.Field<string>("ID Category"));
            bool cekAda = false;
            foreach (DataRow row in dataCategory.Rows)
            {
                if (textBoxNamaCategory.Text != row[1].ToString())
                {
                    continue;
                }
                cekAda = true;
            }
            if (cekAda == true)
            {
                MessageBox.Show("Awas Category sudah ada", "Ninuninu",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBoxNamaCategory.Text = "";
                return;
            }
            string hurufDepan = "C";
            int newId = 1;

            if(namaCategoryy == "")
            {
                MessageBox.Show("Masukkan Nama Kategori terlebih dahulu", "Ninuninu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return ;
            }

            while (adaID.Contains(hurufDepan + newId))
            {
                newId++;
            }

            string newIdCategory = hurufDepan + newId;

            DataRow roww = dataCategory.NewRow();
            roww[0] = newIdCategory;
            roww[1] = namaCategoryy;

            dataCategory.Rows.Add(roww);

            CaraFilter("");
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string namaCategoryy = textBoxNamaCategory.Text;
            if (namaCategoryy == "")
            {
                MessageBox.Show("Pilih Objek Kategori Yang Ingin dihapus terlebih dahulu", "Ninuninu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int i;
            foreach (DataRow row in dataCategory.Rows)
            {
                if (row[0].ToString() != categoryNow)
                {
                    continue;
                }
                dataCategory.Rows.Remove(row);
                for (i = dataTampilan.Rows.Count - 1; i >= 0; i--)
                {
                    if (dataTampilan.Rows[i]["ID Category"] == categoryNow)
                    {
                        dataTampilan.Rows.Remove(dataTampilan.Rows[i]);
                    }
                }
                CaraFilter("");
                return;
            }
            for (i = dataTampilan.Rows.Count - 1; i >= 0; i--)
            {
                if (dataTampilan.Rows[i]["ID Category"] == categoryNow)
                {
                    dataTampilan.Rows.Remove(dataTampilan.Rows[i]);
                }
            }
            CaraFilter("");
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Filter(comboBoxFilter.SelectedValue.ToString());
        }

        bool select = false;
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Enabled = true;
            select = true;
        }

        private void comboBoxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nama;
            nama = comboBoxFilter.SelectedValue.ToString();
            foreach (DataRow row in dataCategory.Rows)
            {
                if(row[0].ToString() == nama)
                {
                    nama = row[1].ToString();
                    break;
                }
            }
            CaraFilter(comboBoxFilter.SelectedValue.ToString());
            if(select == true)
            {
                comboBoxFilter.Text = nama;
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            CaraFilter("");
            select = false;
            comboBoxFilter.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            labelTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryNow = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNamaCategory.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void buttonWarna_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            // Buat nilai acak untuk komponen warna merah, hijau, dan biru
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            // Buat objek Color dari nilai acak
            Color randomColor = Color.FromArgb(red, green, blue);

            // Set background color form dengan warna acak
            this.BackColor = randomColor;
        }

        private void textBoxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Mencegah karakter selain angka dimasukkan ke dalam textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                
                e.Handled = true;
                MessageBox.Show("Harus Angka blok","NINUNINU",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void textBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Mencegah karakter selain angka dimasukkan ke dalam textbox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harus Angka blok", "NINUNINU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
