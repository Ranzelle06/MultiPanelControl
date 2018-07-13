using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPanelSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRED_Click(object sender, EventArgs e)
        {
            //Call the MultiPanel SelectedPage Function 
            //MainPanelManager - Control Name 
            //SelectedPage() - Sets the current displayed page of the MultiPanel
            //page_Red - the name of the Page Control

            //When the user click the Button Red it will display the Page RED...

            MainPanelManager.SelectedPage = page_RED;
        }

        private void btnBLUE_Click(object sender, EventArgs e)
        {
            MainPanelManager.SelectedPage = page_BLUE;
        }

        private void btnGREEN_Click(object sender, EventArgs e)
        {
            MainPanelManager.SelectedPage = page_GREEN;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainPanelManager.SelectedPage = page_Home;
        }
    }
}
