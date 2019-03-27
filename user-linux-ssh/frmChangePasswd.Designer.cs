namespace user_linux_ssh {
    partial class frmChangePasswd {
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminPasswd = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmPasswd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(129, 90);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Senha:";
            // 
            // txtAdminPasswd
            // 
            this.txtAdminPasswd.Location = new System.Drawing.Point(104, 12);
            this.txtAdminPasswd.Name = "txtAdminPasswd";
            this.txtAdminPasswd.PasswordChar = '*';
            this.txtAdminPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtAdminPasswd.TabIndex = 2;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(104, 38);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nova Senha:";
            // 
            // txtConfirmPasswd
            // 
            this.txtConfirmPasswd.Location = new System.Drawing.Point(104, 64);
            this.txtConfirmPasswd.Name = "txtConfirmPasswd";
            this.txtConfirmPasswd.PasswordChar = '*';
            this.txtConfirmPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmPasswd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar Senha:";
            // 
            // frmChangePasswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 123);
            this.Controls.Add(this.txtConfirmPasswd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminPasswd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmChangePasswd";
            this.Text = "Alterar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminPasswd;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPasswd;
        private System.Windows.Forms.Label label3;
    }
}