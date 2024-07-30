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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            listView1.Columns.Add("MSNV", 100);
            listView1.Columns.Add("Ten", 100);
            listView1.Columns.Add("Luong co ban", 100);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            form2 f2 = new form2(this);  
            f2.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectItem = listView1.SelectedItems[0];
                form2 f2 = new form2(this);
                f2.HienThongTin(selectItem);
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui long chon du lieu muon sua");
            }
        }

        public void SuaItem(ListViewItem selectItem, string msnv, string ten, string luong)
        {
            selectItem.Text = msnv;
            selectItem.SubItems[1].Text = ten;
            selectItem.SubItems[1].Text = luong;
        }

        public void AddItemToListView(string msnv, string ten, string luong)
        {
            ListViewItem listViewItem = new ListViewItem(msnv);
            listViewItem.SubItems.Add(ten);
            listViewItem.SubItems.Add(luong);
            listView1.Items.Add(listViewItem);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items) 
            { 
                listView1.Items.Remove(item); 
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
