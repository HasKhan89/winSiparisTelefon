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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Markaların olduğu dosya konumu..
        string markalarDosyaKonumu = Application.StartupPath + "\\markalar.txt";

        // Modellerin olduğu dosya konumu..
        string modellerDosyaKonumu = Application.StartupPath + "\\modeller.txt";

        // Secilen markanın modellerinin tutulacağı liste..
        List<Model> MarkaninModelleri = new List<Model>();




        private void btnMarkaYonet_Click(object sender, EventArgs e)
        {
            frmMarkaYonet markaYonet = new frmMarkaYonet();

            markaYonet.FormClosed += MarkaYonet_FormClosed;
            markaYonet.ShowDialog();
        }

        private void MarkaYonet_FormClosed(object sender, FormClosedEventArgs e)
        {
            MarkalariDoldur();
        }

        private void MarkalariDoldur()
        {
            // Markalar dosyadan okunur.
            string[] markalar = System.IO.File.ReadAllLines(markalarDosyaKonumu);

            cmbMarkalar.Items.Clear();  // combobox temizlenir..
            cmbMarkalar.Items.AddRange(markalar);   // Dosyadan okunan veriler eklenir.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MarkalariDoldur();
        }

        private void cmbMarkalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenMarka = cmbMarkalar.Text;
            // Tüm modeller okunur.
            string[] modeller = System.IO.File.ReadAllLines(modellerDosyaKonumu);

            //MarkaninModelleri = new List<Model>();
            MarkaninModelleri.Clear();

            foreach (string modelIfade in modeller)
            {
                string[] modelOzellikleri = modelIfade.Split(';');
                string markasi = modelOzellikleri[0];

                if(secilenMarka == markasi)
                {
                    Model model = new Model()
                    {
                        Marka = markasi,
                        Modeli = modelOzellikleri[1],
                        Adet = int.Parse(modelOzellikleri[2]),
                        Fiyat = decimal.Parse(modelOzellikleri[3])
                    };

                    MarkaninModelleri.Add(model);
                }
            }

            ModelleriListele();
        }

        private void ModelleriListele()
        {
            lstModeller.Items.Clear();

            foreach (Model mod in MarkaninModelleri)
            {
                lstModeller.Items.Add(mod);
            }
        }
    }
}
