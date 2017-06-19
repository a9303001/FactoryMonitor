using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryMonitor.PLC;


namespace FactoryMonitor.GUI
{/// <summary>
/// 
/// </summary>
    public partial class Main : Form
    {/// <summary>
     /// 
     /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        private FxPLC[] PLC = new FxPLC[1];
        private void Main_Load(object sender, EventArgs e)
        {


            for (int i = 0; i <= PLC.Length; i++)
            {
                PLC[0] = new FxPLC();
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (FxPLC elementPLC in PLC)
                {
                    elementPLC.Connect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }

        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (FxPLC elementPLC in PLC)
                {
                    elementPLC.Disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }

        }
    }
    

}
