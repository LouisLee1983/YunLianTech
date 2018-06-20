using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YunlianMinerManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加ip段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddIPRange_Click(object sender, EventArgs e)
        {
            checkedListBoxIPRanges.Items.Clear();
            
            string minIP = textBoxStartIP1.Text.Trim() + "." + textBoxStartIP2.Text.Trim() + "." + textBoxStartIP3.Text.Trim() + "." + textBoxStartIP4.Text.Trim();
            string maxIP = textBoxEndIP1.Text.Trim() + "." + textBoxEndIP2.Text.Trim() + "." + textBoxEndIP3.Text.Trim() + "." + textBoxEndIP4.Text.Trim();
            int startIP3 = int.Parse(textBoxStartIP3.Text.Trim());
            int endIP3 = int.Parse(textBoxEndIP3.Text.Trim());
            for(int i = startIP3; i <= endIP3; i++)
            {
                string startIP = textBoxStartIP1.Text.Trim() + "." + textBoxStartIP2.Text.Trim() + "." + i.ToString() + ".1";
                if (string.Compare(startIP, minIP) < 0)
                {
                    startIP = minIP;
                }
                string endIP = textBoxStartIP1.Text.Trim() + "." + textBoxStartIP2.Text.Trim() + "." + i.ToString() + ".255";
                if (string.Compare(endIP, maxIP) > 0)
                {
                    endIP = maxIP;
                }
                checkedListBoxIPRanges.Items.Add(startIP + "-" + endIP, true);
            }            
        }
    }
}
