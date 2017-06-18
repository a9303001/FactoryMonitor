﻿using System;
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
            try
            {

                for (int PLC_i = 0; PLC_i <= PLC.Length; PLC_i++)
                {
                    PLC[PLC_i] = new FxPLC();

                    Button[] btns = new Button[8];

                    for (int btn_j = 0; btn_j < btns.Length; PLC_i++)
                    {
                        btns[btn_j] = new Button();
                        btns[btn_j].BackColor = System.Drawing.Color.Red;
                        btns[btn_j].Location = new System.Drawing.Point(3, 3);
                        btns[btn_j].Size = new System.Drawing.Size(37, 26);
                        btns[btn_j].TabIndex = 0;
                        btns[btn_j].Text = Convert.ToString(++btn_j);
                       // btns[btn_j].UseVisualStyleBackColor = false;

                    }
                    flowLayoutPanel1.Controls.AddRange(btns);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
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
