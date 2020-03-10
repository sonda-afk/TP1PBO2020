using Pembelian.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembelian
{
    public partial class FrmBeli : Form
    {
        public ListItem[] listitems = new ListItem[6];
        public FrmBeli()
        {
            InitializeComponent();
        }

        private void FrmBeli_Load(object sender, EventArgs e)
        {
            PopulateItem();
            
        }

        private void PopulateItem()
        {
            label2.Visible = false;
            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new ListItem();
                if (i == 0)
                {
                    listitems[i].Judul  = "Baju Bedug";
                    listitems[i].Harga  = "Rp.150.000";
                    listitems[i].Icon   = Resources.icons8_t_shirt_64;
                    listitems[i].Button = "btnBeli1";
                }else if(i == 1)
                {
                    listitems[i].Judul = "Bikini";
                    listitems[i].Harga = "Rp.400.000";
                    listitems[i].Icon = Resources.icons8_bra_64;
                    listitems[i].Button = "btnBeli2";
                }
                else if (i == 2)
                {
                    listitems[i].Judul = "GoPro";
                    listitems[i].Harga = "Rp.1.000.000";
                    listitems[i].Icon = Resources.icons8_camera_64;
                    listitems[i].Button = "btnBeli3";
                }
                else if (i == 3)
                {
                    listitems[i].Judul = "Handphone";
                    listitems[i].Harga = "Rp.950.000";
                    listitems[i].Icon = Resources.icons8_phonelink_ring_64;
                    listitems[i].Button = "btnBeli4";
                }
                else if (i == 4)
                {
                    listitems[i].Judul = "Pizza";
                    listitems[i].Harga = "Rp.100.000";
                    listitems[i].Icon = Resources.icons8_italian_pizza_64;
                    listitems[i].Button = "btnBeli5";
                }
                else if (i == 5)
                {
                    listitems[i].Judul = "Ayam Geprek Emas";
                    listitems[i].Harga = "Rp.500.000";
                    listitems[i].Icon = Resources.icons8_chicken_box_64;
                    listitems[i].Button = "btnBeli6";
                }

                if(flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                flowLayoutPanel1.Controls.Add(listitems[i]);
                
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbHarga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (cbJenis.SelectedItem == null || cbHarga.SelectedItem == null)
            {
                MessageBox.Show("Harap Masukan Jenis Barang / Range Harga");
                PopulateItem();
            }
            else
            {
                if(cbJenis.SelectedItem == "Baju")
                {
                    if(cbHarga.SelectedItem == "100.000 - 200.000")
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(listitems[0]);
                    }else if(cbHarga.SelectedItem == "200.000 - 500.000")
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(listitems[1]);
                    }
                    else
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        PopulateItem();
                    }
                }
                else if(cbJenis.SelectedItem == "Elektronik")
                {
                    if (cbHarga.SelectedItem == "100.000 - 200.000")
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        PopulateItem();
                    }
                    else if (cbHarga.SelectedItem == "200.000 - 500.000")
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        PopulateItem();
                    }
                    else
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(listitems[2]);
                        flowLayoutPanel1.Controls.Add(listitems[3]);
                    }
                }
                else if (cbJenis.SelectedItem == "Makanan")
                {
                    if (cbHarga.SelectedItem == "100.000 - 200.000")
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(listitems[4]);
                    }
                    else if (cbHarga.SelectedItem == "200.000 - 500.000")
                    {
                        label2.Visible = true;
                        flowLayoutPanel1.Controls.Add(listitems[5]);
                    }
                    else
                    {
                        MessageBox.Show("Maaf Barang Tidak Ada");
                        PopulateItem();
                    }
                }
            }
            
        }
    }
}
