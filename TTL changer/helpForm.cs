using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTL_changer {
    public partial class helpForm : Form {
        public helpForm() {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
