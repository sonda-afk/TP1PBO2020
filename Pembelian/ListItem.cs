using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pembelian
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private string _judul;
        private string _harga;
        private Image _icon;
        private string _button;


        [Category("Custom Props")]
        public string Judul
        {
            get { return _judul; }
            set { _judul = value; lblJudul.Text = value; }
        }

        [Category("Custom Props")]
        public string Harga
        {
            get { return _harga; }
            set { _harga = value; lblHarga.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        [Category("Custom Props")]
        public string Button
        {
            get { return _button; }
            set { _button = value; btnBeli.Name = value; }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
        }
    }
}
