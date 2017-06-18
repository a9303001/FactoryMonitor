using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMonitor
{   /// <summary>
/// 
/// </summary>
    public partial class Form1 : Form
    {

        private cPLC[] PLC = new cPLC[1];
        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                if (cPLC.GetState.ToString() != "Connected")
                {

                    winsock1Connect();

                }
                if (winsock1.GetState.ToString() != "Connected")
                {
                    MessageBox.Show("Not Connected");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }

        }

        private void winsock1_HandleError(MelsecPLC.Winsock sender, string Description, string Method, string myEx)
        {

        }
    }
}
