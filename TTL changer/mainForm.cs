using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TTL_changer {
    public partial class mainTtlForm : Form {
        public mainTtlForm() {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e) {
            new helpForm().ShowDialog();
        }

        string localizedTTLtext;

        private void mainTtlForm_Load(object sender, EventArgs e) {
            localizedTTLtext = currentTtl.Text;
            updateTTLlabel();
        }

        void updateTTLlabel() {
            currentTtl.Text = localizedTTLtext + currentTTL;
        }

        public int currentTTL {
            get {
                int currentTTLvalue = 0;

                Process netsh = new Process();
                netsh.StartInfo.FileName = "netsh";
                netsh.StartInfo.Arguments = "int ipv4 show global";
                netsh.StartInfo.CreateNoWindow = true;
                netsh.StartInfo.UseShellExecute = false;
                netsh.StartInfo.RedirectStandardOutput = true;
                netsh.OutputDataReceived += (sender, args) => {
                    if (currentTTLvalue == 0) {
                        int i = 0;
                        string tmp = "";
                        while (i < args.Data.Length && !(args.Data[i] >= '0' && args.Data[i] <= '9') ) i++;
                        while (i < args.Data.Length && args.Data[i] >= '0' && args.Data[i] <= '9') tmp += args.Data[i++];
                        int.TryParse(tmp, out currentTTLvalue);
                    }
                };
                netsh.Start();
                netsh.BeginOutputReadLine();
                netsh.WaitForExit();
                Activate();

                return currentTTLvalue;
            }
            set {
                Process netsh = new Process();
                netsh.StartInfo.CreateNoWindow = true;
                netsh.StartInfo.UseShellExecute = false;
                netsh.StartInfo.FileName = "netsh";
                netsh.StartInfo.Arguments = "int ipv4 set global " + value;
                netsh.Start();
                netsh.WaitForExit();
                netsh.StartInfo.Arguments = "int ipv6 set global " + value;
                netsh.Start();
                netsh.WaitForExit();
                Activate();
            }
        }

        private void setTtl_Click(object sender, EventArgs e) {
            int newTTL = decimal.ToByte(ttlUpDown.Value);
            currentTTL = newTTL;
            if (currentTTL != newTTL) {
                MessageBox.Show("TTL not changed!\nAre you an Administrator?", "ЕГГОГ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                updateTTLlabel();
            }
            ttlUpDown.Focus();
        }
    }
}
