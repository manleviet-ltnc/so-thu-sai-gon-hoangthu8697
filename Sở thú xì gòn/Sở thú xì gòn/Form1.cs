using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Sở_thú_xì_gòn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isItemChanged = false;
        bool isItemSaved = true;
        private void LB_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.X, e.Y);
            if (index != -1)
                lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Copy);
        }

        private void LB_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                 e.Effect = DragDropEffects.Move;
        }

        private void LB_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                if(!lstDanhSach.Items.Contains(lstThuMoi.SelectedItem))
            {
                    int NewIndex = lstDanhSach.IndexFromPoint(lstDanhSach.PointToClient(new Point(e.X, e.Y)));
                    object selectedItem = e.Data.GetData(DataFormats.Text);
                    if (NewIndex != -1)
                        lstDanhSach.Items.Insert(NewIndex, selectedItem);
                    else
                        lstDanhSach.Items.Insert(lstDanhSach.Items.Count, selectedItem);
                    isItemChanged = true;
            }
        }

        private void Luu(object sender, EventArgs e)
        {
            
            StreamWriter write = new StreamWriter("danhsachthu.txt");
                        if (write == null)
                               return;
                        foreach (var item in lstDanhSach.Items)
            write.WriteLine(item.ToString());
            write.Close();
            isItemSaved = false;
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("newthu.txt");
            if (reader == null)
                return;
            string input;
            while ((input = reader.ReadLine()) != null)

                lstThuMoi.Items.Add(input);

            reader.Close();
            using (StreamReader rs = new StreamReader("danhsachthu.txt"))
            {
                input = null;
                while ((input = rs.ReadLine()) != null)

                    lstDanhSach.Items.Add(input);
            }
        }
             
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("Bây giờ là {0}:{1}:{2} ngày {3} tháng{4} năm {5}",
                                         DateTime.Now.Hour,
                                         DateTime.Now.Minute,
                                         DateTime.Now.Second,
                                         DateTime.Now.Day,
                                         DateTime.Now.Month,
                                         DateTime.Now.Year);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void delete(object sender, EventArgs e)
        {
            while (lstDanhSach.SelectedIndex != -1)
                lstDanhSach.Items.RemoveAt(lstDanhSach.SelectedIndex);
            isItemChanged = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isItemChanged == true)
            {
                DialogResult result = MessageBox.Show("Ban co muon luu danh sach?",
                                                       "",
                                                       MessageBoxButtons.YesNoCancel,
                                                       MessageBoxIcon.None);
                if (result == DialogResult.Yes)
                {
                    Luu(sender, e);
                    e.Cancel = false;
                }
                else if (result == DialogResult.No)
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }
        }
    }   
}
