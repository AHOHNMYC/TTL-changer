using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TTL_changer {
    public partial class helpForm : Form {
        public helpForm() {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e) {
            Close();
        }

        private void githubLink_Click(object sender, EventArgs e) {
            Process.Start("https://github.com/AHOHNMYC");
        }

        private void fourPdaLink_Click(object sender, EventArgs e) {
            Process.Start("https://4pda.ru/forum/index.php?showtopic=689378#entry30785529");
        }
    }
}
