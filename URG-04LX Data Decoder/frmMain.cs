using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URG_04LX_Data_Decoder
{
    public partial class frmMain : Form
    {
        SCIP20MsgDecoder msg = new SCIP20MsgDecoder();
        List<URG04LXLaserData> lstData = new List<URG04LXLaserData>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (btnConvert.Text == "&Convert to Hex")
            {
                btnConvert.Text = "&Convert to String";
                chkHex.Checked = true;
                txtInput.Text = SCIP20MsgDecoder.ByteArray2HexString(Encoding.ASCII.GetBytes(txtInput.Text));
            }
            else
            {
                btnConvert.Text = "&Convert to Hex";
                chkHex.Checked = false;
                txtInput.Text = Encoding.ASCII.GetString(SCIP20MsgDecoder.HexString2ByteArray(txtInput.Text));
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            msg.DecodeMD(txtInput.Text);
            txtOutput.Text = msg.LaserDataText;
            tsDataCount.Text = "Data Count: " + ((msg.HexData.Length + 1) / 9).ToString();
            if (msg.HexData == "")
            {
                tsStatus.Text = "Error when check sum";
            }
            else
            {
                tsStatus.Text = "Decoded succesfully";
                lstData.Add(new URG04LXLaserData(msg.LaserData, DateTime.Now));
                //lstData.Add(new URG04LXLaserData(msg.LaserData, DateTime.Now.AddSeconds(100))); 
                URG04LXLaserData.ExportUrgBenriDataFile(@"C:\Users\Kevin\test.ubh", lstData);
            }
        }

        private void chkHex_CheckedChanged(object sender, EventArgs e)
        {
            btnDecode.Enabled = chkHex.Checked;
            if (chkHex.Checked)
            {
                btnConvert.Text = "&Convert to String";
            }
            else
            {
                btnConvert.Text = "&Convert to Hex";
            }
        }
    }
}
