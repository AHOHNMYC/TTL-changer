namespace TTL_changer {
    partial class mainTtlForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainTtlForm));
            this.setTtl = new System.Windows.Forms.Button();
            this.resetTtl = new System.Windows.Forms.Button();
            this.ttlUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentTtl = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ttlUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // setTtl
            // 
            this.setTtl.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.setTtl, "setTtl");
            this.setTtl.Name = "setTtl";
            this.setTtl.UseVisualStyleBackColor = true;
            this.setTtl.Click += new System.EventHandler(this.setTtl_Click);
            // 
            // resetTtl
            // 
            resources.ApplyResources(this.resetTtl, "resetTtl");
            this.resetTtl.Name = "resetTtl";
            this.resetTtl.UseVisualStyleBackColor = true;
            // 
            // ttlUpDown
            // 
            resources.ApplyResources(this.ttlUpDown, "ttlUpDown");
            this.ttlUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ttlUpDown.Name = "ttlUpDown";
            this.ttlUpDown.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // currentTtl
            // 
            resources.ApplyResources(this.currentTtl, "currentTtl");
            this.currentTtl.Name = "currentTtl";
            // 
            // help
            // 
            this.help.Cursor = System.Windows.Forms.Cursors.Help;
            resources.ApplyResources(this.help, "help");
            this.help.Name = "help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.exit, "exit");
            this.exit.Name = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // githubLink
            // 
            this.githubLink.Image = global::TTL_changer.Properties.Resources.fluidicon;
            resources.ApplyResources(this.githubLink, "githubLink");
            this.githubLink.Name = "githubLink";
            // 
            // mainTtlForm
            // 
            this.AcceptButton = this.setTtl;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.currentTtl);
            this.Controls.Add(this.ttlUpDown);
            this.Controls.Add(this.resetTtl);
            this.Controls.Add(this.setTtl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainTtlForm";
            this.Load += new System.EventHandler(this.mainTtlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ttlUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setTtl;
        private System.Windows.Forms.Button resetTtl;
        private System.Windows.Forms.NumericUpDown ttlUpDown;
        private System.Windows.Forms.Label currentTtl;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.LinkLabel githubLink;
    }
}

