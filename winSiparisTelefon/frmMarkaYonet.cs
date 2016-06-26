using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winSiparisTelefon
{
    public partial class frmMarkaYonet : Form
    {
        public frmMarkaYonet()
        {
            InitializeComponent();
        }


        private string MarkalarDosyaKonumu = Application.StartupPath + "\\markalar.txt";
        public List<string> MarkaListesi { get; set; } // prop.. tab tab

        private void frmMarkaYonet_Load(object sender, EventArgs e)
        {
            // Form ilk açıldığında marka listesi oluşturulur.
            MarkaListesi = new List<string>();

            // Eğer önceden kaydedilmiş bir dosya varsa "markalar.txt" markalar okunur.
            MarkalariDosyadanOku();
            Listele();
        }

        private void Listele()
        {
            lstMarkalar.Items.Clear();

            foreach (string marka in MarkaListesi)
            {
                lstMarkalar.Items.Add(marka);
            }
        }

        private void MarkalariDosyadanOku()
        {
            if(System.IO.File.Exists(MarkalarDosyaKonumu))
            {
                string[] markalar = System.IO.File.ReadAllLines(MarkalarDosyaKonumu);

                // AddRange metodu dizi ve liste türünde değişkenleri topluca diğer listeye ekleme yapar. İki liste tipide aynı olmalı.
                MarkaListesi.AddRange(markalar);
            }
        }

        private void MarkalariDosyayaYaz()
        {
            System.IO.File.WriteAllLines(MarkalarDosyaKonumu, MarkaListesi.ToArray());
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MarkaListesi.Add(txtMarkaAdi.Text);
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(lstMarkalar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz");
                return;
            }

            int index = lstMarkalar.SelectedIndex;
            MarkaListesi[index] = txtMarkaAdi.Text;

            Listele();
        }

        private void lstMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMarkalar.SelectedIndex;
            txtMarkaAdi.Text = MarkaListesi[index];
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMarkalar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayıt seçiniz");
                return;
            }

            int index = lstMarkalar.SelectedIndex;
            MarkaListesi.RemoveAt(index);

            Listele();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            MarkalariDosyayaYaz();  // Markaları dosyaya yaz..
            this.Close();   // Formu kapat..
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
