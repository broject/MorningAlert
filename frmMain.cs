using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;

namespace MorningAlert
{
    public partial class frmMain : Form
    {
        Timer _Time;
        XmlDocument _Doc;
        string _DocFile;

        public frmMain()
        {
            InitializeComponent();

            _Time = new Timer();
            _Time.Interval = 1000;
            _Time.Tick += _Time_Tick;

            _Doc = new XmlDocument();
            _DocFile = Application.StartupPath + "\\Alert-Setting.xml";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                _Doc.Load(_DocFile);
            }
            catch { }
            if (_Doc.DocumentElement == null)
            {
                _Doc.AppendChild(_Doc.CreateElement("settings"));
            }
            else
            {
                XmlNodeList nodes = _Doc.GetElementsByTagName("AlertDays");
                if (nodes.Count > 0)
                {
                    XmlNode elem = (XmlNode)nodes.Item(0);
                    string[] ndxs = elem.InnerText.Split(new char[] { ',' });
                    foreach (string ndx in ndxs)
                    {
                        dayAlert.SetItemChecked(Convert.ToInt32(ndx), true);
                    }
                }
                nodes = _Doc.GetElementsByTagName("AlertTime");
                if (nodes.Count > 0)
                {
                    XmlNode elem = (XmlNode)nodes.Item(0);
                    tmeAlert.Value = Convert.ToDateTime(elem.InnerText);
                }
                nodes = _Doc.GetElementsByTagName("AlertMusic");
                if (nodes.Count > 0)
                {
                    XmlNode elem = (XmlNode)nodes.Item(0);
                    txtMusic.Text = elem.InnerText;
                }
                nodes = _Doc.GetElementsByTagName("AutoStart");
                if (nodes.Count > 0)
                {
                    XmlNode elem = (XmlNode)nodes.Item(0);
                    chkAutoStart.Checked = Convert.ToBoolean(elem.InnerText);
                }
            }
            if (chkAutoStart.Checked)
            {
                btnStart_Click(btnStart, EventArgs.Empty);
            }
            _Time.Start();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _Time.Stop();

            _Doc.Save(_DocFile);

            base.OnClosing(e);
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.mp3;*.wma)|*.mp3;*.wma";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtMusic.Text = ofd.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Tag == null)
            {
                btnStart.Tag = "";
            }
            else
            {
                btnStart.Tag = null;
            }
        }

        private void _Time_Tick(object sender, EventArgs e)
        {
            if (btnStart.Tag == null)
            {
                btnStart.Text = "Эхлүүлэх - " + DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                btnStart.Text = "Зогсоох - " + DateTime.Now.ToString("HH:mm:ss");
            }
            bool dayChecked = false;
            foreach (int ndx in dayAlert.CheckedIndices)
            {
                int checkedDow = (ndx + 1) == 7 ? 0 : (ndx + 1);
                DayOfWeek dow = DateTime.Now.DayOfWeek;
                if (checkedDow == (int)dow)
                {
                    dayChecked = true;
                }
            }
            if (btnStart.Tag != null &&
                tmeAlert.Value.ToString("HH:mm") == DateTime.Now.ToString("HH:mm") &&
                (dayAlert.CheckedItems.Count == 0 || dayChecked))
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "wmplayer.exe";
                psi.Arguments = "\"" + txtMusic.Text + "\"";
                Process.Start(psi);
                this.Close();
            }
        }

        private void tmeAlert_ValueChanged(object sender, EventArgs e)
        {
            XmlNode elem = null;
            XmlNodeList nodes = _Doc.GetElementsByTagName("AlertTime");
            if (nodes.Count > 0)
                elem = (XmlNode)nodes.Item(0);
            else
                elem = _Doc.CreateElement("AlertTime");
            elem.InnerText = tmeAlert.Value.ToString();
            if (nodes.Count == 0)
            {
                _Doc.DocumentElement.AppendChild(elem);
            }
            _Doc.Save(_DocFile);
        }

        private void txtMusic_TextChanged(object sender, EventArgs e)
        {
            XmlNode elem = null;
            XmlNodeList nodes = _Doc.GetElementsByTagName("AlertMusic");
            if (nodes.Count > 0)
                elem = (XmlNode)nodes.Item(0);
            else
                elem = _Doc.CreateElement("AlertMusic");
            elem.InnerText = txtMusic.Text;
            if (nodes.Count == 0)
            {
                _Doc.DocumentElement.AppendChild(elem);
            }
            _Doc.Save(_DocFile);
        }

        private void chkAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            XmlNode elem = null;
            XmlNodeList nodes = _Doc.GetElementsByTagName("AutoStart");
            if (nodes.Count > 0)
                elem = (XmlNode)nodes.Item(0);
            else
                elem = _Doc.CreateElement("AutoStart");
            elem.InnerText = chkAutoStart.Enabled.ToString();
            if (nodes.Count == 0)
            {
                _Doc.DocumentElement.AppendChild(elem);
            }
            _Doc.Save(_DocFile);
        }

        private void dayAlert_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            XmlNode elem = null;
            XmlNodeList nodes = _Doc.GetElementsByTagName("AlertDays");
            if (nodes.Count > 0)
                elem = (XmlNode)nodes.Item(0);
            else
                elem = _Doc.CreateElement("AlertDays");
            List<string> lst = new List<string>();
            foreach (int ndx in dayAlert.CheckedIndices)
            {
                lst.Add(ndx.ToString());
            }
            if (e.NewValue == CheckState.Checked)
            {
                lst.Add(e.Index.ToString());
            }
            else
            {
                lst.Add(e.Index.ToString());
            }
            elem.InnerText = string.Join(",", lst.ToArray());
            if (nodes.Count == 0)
            {
                _Doc.DocumentElement.AppendChild(elem);
            }
            _Doc.Save(_DocFile);
        }
    }
}
