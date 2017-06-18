using MelsecPLC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMonitor
{
    class cPLC
    {
        private MelsecPLC.Winsock winsock1 = new Winsock();
        public Boolean Connect()
        {
            try
            {
                if (winsock1.GetState.ToString() != "Connected")
                {

                    winsock1.LocalPort = 1027;
                    winsock1.RemoteIP = "192.168.0.1";

                    winsock1.RemotePort = 8000;
                    winsock1.Connect();
                }
                if (winsock1.GetState.ToString() != "Connected")
                {
                    MessageBox.Show("PLC Not Connected");
                    return false;
                }
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        public void Disconnect()
        { 
            winsock1.Close();
        }
     

        public void ReadData()
        {
            if (winsock1.GetState.ToString() != "Connected")
            {
                Connect();
                if (winsock1.GetState.ToString() != "Connected")
                {
                    MessageBox.Show("Not Connected");
                    return;
                }
            }

            //String cmd = "500000FF03FF000018000A04010000D*0095000001";
            String cmd = "";
            String OutAddress = "0001";
            cmd = "";
            cmd = cmd + "5000";// sub HEAD (NOT)
            cmd = cmd + "00";//   network number (NOT)
            cmd = cmd + "FF";//PLC NUMBER
            cmd = cmd + "03FF";// DEMAND OBJECT MUDULE I/O NUMBER
            cmd = cmd + "00";//  DEMAND OBJECT MUDULE DEVICE NUMBER
            cmd = cmd + "001C";//  Length of demand data
            cmd = cmd + "000A";//  CPU inspector data
            cmd = cmd + "0401";//  Read command
            cmd = cmd + "0000";//  Sub command
            cmd = cmd + "D*";//   device code
            cmd = cmd + "009500"; //adBase 
            cmd = cmd + OutAddress;  //BASE ADDRESS           
            winsock1.Send(cmd);
        }

    }
}

namespace FactoryMonitor
{


    class cPLC1
    {
        private MelsecPLC.Winsock winsock1 = new Winsock();


        public void winsock1Connect()
        {
            try
            {
                if (winsock1.GetState.ToString() != "Connected")
                {

                    winsock1.LocalPort = 1027;

                    winsock1.RemoteIP = "192.168.0.2";

                    winsock1.RemotePort = 8000;

                    winsock1.Connect();
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
