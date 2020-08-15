using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpRequestBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.txt"))
            {
                var st = JsonConvert.DeserializeObject<RequestHelper.RequestData>(File.ReadAllText("settings.txt"));

                txData.Text = st.Data;
                txHeaders.Lines = st.Headers;
                reqMethod.Text = ((Leaf.xNet.HttpMethod)st.Method).ToString();
                txUri.Text = st.Uri;
                chRedir.Checked = st.AllowRedirect;
                proxyType.Text = ((Leaf.xNet.ProxyType)st.ProxyType).ToString();
                txProxyAddr.Text = st.ProxyAddr;
            }
            else
            {
                reqMethod.SelectedIndex = 0;
                proxyType.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txData.Text = DataHelper.UrlEncode(txData.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sfd.FileName, txRes.Lines);
                }
            }
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            NotepadHelper.ShowMessage(txRes.Text);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var sendStruct = new RequestHelper.RequestData()
                {
                    Data = txData.Text,
                    Headers = txHeaders.Lines,
                    Method = (Leaf.xNet.HttpMethod)Enum.Parse(typeof(Leaf.xNet.HttpMethod), reqMethod.Text),
                    Uri = txUri.Text,
                    AllowRedirect = chRedir.Checked,
                    ProxyType = (Leaf.xNet.ProxyType)Enum.Parse(typeof(Leaf.xNet.ProxyType), proxyType.Text),
                    ProxyAddr = txProxyAddr.Text
                };

                var res = RequestHelper.Send(sendStruct);
                txRes.Text = res;
                File.WriteAllText("settings.txt", JsonConvert.SerializeObject(sendStruct));
            }
            catch (Exception ex) { txRes.Text = ex.Message; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reqMethod.Text != "POST")
            {
                txData.Enabled = false;
            }
            else txData.Enabled = true;
        }
    }
}
