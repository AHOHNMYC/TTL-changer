namespace TTL_changer {
    partial class helpForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.helpText = new System.Windows.Forms.RichTextBox();
            this.exit = new System.Windows.Forms.Button();
            this.githubLink = new System.Windows.Forms.PictureBox();
            this.fourPdaLink = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.githubLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPdaLink)).BeginInit();
            this.SuspendLayout();
            // 
            // helpText
            // 
            this.helpText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpText.Location = new System.Drawing.Point(12, 12);
            this.helpText.Name = "helpText";
            this.helpText.ReadOnly = true;
            this.helpText.Size = new System.Drawing.Size(316, 114);
            this.helpText.TabIndex = 1;
            this.helpText.Text = "";
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(12, 170);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(316, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Спасибо";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // githubLink
            // 
            this.githubLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.githubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubLink.Image = global::TTL_changer.Properties.Resources.gitHub;
            this.githubLink.Location = new System.Drawing.Point(135, 132);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(32, 32);
            this.githubLink.TabIndex = 8;
            this.githubLink.TabStop = false;
            this.githubLink.Click += new System.EventHandler(this.githubLink_Click);
            // 
            // fourPdaLink
            // 
            this.fourPdaLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fourPdaLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fourPdaLink.Image = global::TTL_changer.Properties.Resources.fourPda;
            this.fourPdaLink.Location = new System.Drawing.Point(173, 132);
            this.fourPdaLink.Name = "fourPdaLink";
            this.fourPdaLink.Size = new System.Drawing.Size(32, 32);
            this.fourPdaLink.TabIndex = 9;
            this.fourPdaLink.TabStop = false;
            this.fourPdaLink.Click += new System.EventHandler(this.fourPdaLink_Click);
            // 
            // helpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(340, 205);
            this.Controls.Add(this.fourPdaLink);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.helpText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "helpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            this.Load += new System.EventHandler(this.helpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.githubLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourPdaLink)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox helpText;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox githubLink;
        private System.Windows.Forms.PictureBox fourPdaLink;
    }
}