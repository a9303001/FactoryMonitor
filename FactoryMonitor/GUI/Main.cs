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

        private MainOper MainGUIOper = new MainOper();
        private void Main_Load(object sender, EventArgs e)
        {
            MainGUIOper.Load(ref flowLayoutPanel1);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGUIOper.PLCConnect();

        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainGUIOper.PLCDisconnect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }


}
