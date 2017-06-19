using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryMonitor.PLC;



namespace FactoryMonitor.GUI
{

    class MainOper
    {
       
        private FxPLC[] PLC = new FxPLC[1];

        ///
        public void Load(ref FlowLayoutPanel flowLayoutPanel1)
        {
            try
            {

                for (int PLC_i = 0; PLC_i <= PLC.Length; PLC_i++)
                {
                    PLC[PLC_i] = new FxPLC();

                    Button[] btnsYContact = new Button[8];

                    for (int btn_j = 0; btn_j < btnsYContact.Length; PLC_i++)
                    {
                        btnsYContact[btn_j] = new Button();
                        //1st 3digits:PLC Number, 2nd 3digits:Y Contact
                        //ex: 010003: 010:PLC Number, 003:Y Contact
                        btnsYContact[btn_j].Name= Convert.ToString((PLC_i+1) * 1000+ (btn_j + 1) );  
                        btnsYContact[btn_j].Text = Convert.ToString(btn_j + 1);
                        btnsYContact[btn_j].BackColor = System.Drawing.Color.Red;
                        btnsYContact[btn_j].Location = new System.Drawing.Point(3, 3);
                        btnsYContact[btn_j].Size = new System.Drawing.Size(37, 26);
                       
                        btnsYContact[btn_j].Click += new EventHandler(YContact_Click);

                        ++btn_j;

                    }
                    flowLayoutPanel1.Controls.AddRange(btnsYContact);

                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message + "\r\n";
                msg += ex.StackTrace;
                MessageBox.Show(msg);
                throw ex;
            }

        }

        private void YContact_Click(object sender, EventArgs e)
        {

        }

        public void Pool_AllYContact(object sender, EventArgs e)
        {
            foreach (FxPLC elementPLC in PLC)
            {
                elementPLC.ReadData();
            }
            
        }
        public void PLCConnect()
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

        public void PLCDisconnect()
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
