using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastTask
{
    public partial class AddMenuItemForm : Form
    {
        public AddMenuItemForm()
        {
            InitializeComponent();
        }

        private void AddMenuButton_Click(object sender, EventArgs e)
        {
            
            foreach(var item in menuStrip.Items)
            {

                if (!string.IsNullOrWhiteSpace(topLevelMenu.Text))
                    menuStrip.Items.Add(topLevelMenu.Text);
            }
        }

        private void AddSubItemButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(subItem.Text))
                toolStripMenuItem.DropDownItems.Add(subItem.Text);
        }
    }
}
