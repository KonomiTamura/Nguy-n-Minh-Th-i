using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVN4
{
    public partial class form2 : Form
    {
        private form1 _form1;
        private ListViewItem _suaItem;

        public form2()
        {
        }

        public form2(form1 f1)
        {
            InitializeComponent();
            _form1 = f1;
        }

        private void btnDY_Click(object sender, EventArgs e)
        {
            string msnv = txtMSNV.Text;
            string ten = txtTen.Text;
            string luong = txtLuong.Text;

            _form1.AddItemToListView(msnv, ten, luong);

            txtMSNV.Clear();
            txtTen.Clear();
            txtLuong.Clear();

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void HienThongTin(ListViewItem item)
        {
            _suaItem = item;

            txtMSNV.Text = item.Text;
            txtTen.Text = item.SubItems[1].Text;
            txtLuong.Text = item.SubItems[2].Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_suaItem != null)
            {

                string msnv = txtMSNV.Text;
                string ten = txtTen.Text;
                string luong = txtLuong.Text;

                _form1.SuaItem(_suaItem, msnv, ten, luong);

                this.Close();
            }
            else
            {
                MessageBox.Show("Khong co du lieu chon de sua.");
            }
        }

        private void btnBQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
