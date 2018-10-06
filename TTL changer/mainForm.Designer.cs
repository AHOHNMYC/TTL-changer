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
            this.setTtl = new System.Windows.Forms.Button();
            this.resetTtl = new System.Windows.Forms.Button();
            this.ttlUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentTtl = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ttlUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // setTtl
            // 
            this.setTtl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setTtl.Location = new System.Drawing.Point(12, 61);
            this.setTtl.Name = "setTtl";
            this.setTtl.Size = new System.Drawing.Size(100, 23);
            this.setTtl.TabIndex = 2;
            this.setTtl.Text = "Установка";
            this.setTtl.UseVisualStyleBackColor = true;
            this.setTtl.Click += new System.EventHandler(this.setTtl_Click);
            // 
            // resetTtl
            // 
            this.resetTtl.Location = new System.Drawing.Point(12, 90);
            this.resetTtl.Name = "resetTtl";
            this.resetTtl.Size = new System.Drawing.Size(100, 23);
            this.resetTtl.TabIndex = 3;
            this.resetTtl.Text = "Сброс";
            this.resetTtl.UseVisualStyleBackColor = true;
            // 
            // ttlUpDown
            // 
            this.ttlUpDown.Location = new System.Drawing.Point(12, 35);
            this.ttlUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ttlUpDown.Name = "ttlUpDown";
            this.ttlUpDown.Size = new System.Drawing.Size(100, 20);
            this.ttlUpDown.TabIndex = 1;
            this.ttlUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttlUpDown.Value = new decimal(new int[] {
            65,
            0,
            0,
            0});
            // 
            // currentTtl
            // 
            this.currentTtl.Location = new System.Drawing.Point(12, 9);
            this.currentTtl.Name = "currentTtl";
            this.currentTtl.Size = new System.Drawing.Size(100, 23);
            this.currentTtl.TabIndex = 4;
            this.currentTtl.Text = "Текущий TTL: ";
            this.currentTtl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // help
            // 
            this.help.Cursor = System.Windows.Forms.Cursors.Help;
            this.help.Location = new System.Drawing.Point(12, 129);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(100, 23);
            this.help.TabIndex = 4;
            this.help.Text = "Справка";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(12, 158);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mainTtlForm
            // 
            this.AcceptButton = this.setTtl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(124, 195);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.help);
            this.Controls.Add(this.currentTtl);
            this.Controls.Add(this.ttlUpDown);
            this.Controls.Add(this.resetTtl);
            this.Controls.Add(this.setTtl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainTtlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTL changer";
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
    }
}

