namespace user_linux_ssh
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.btnConect = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.gbxControls = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnChangePasswd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cblUsers = new System.Windows.Forms.CheckedListBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserPasswd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cblGroups = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxSmb = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnDesconect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.gbxControls.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxData
            // 
            this.gbxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxData.Controls.Add(this.btnConect);
            this.gbxData.Controls.Add(this.numPort);
            this.gbxData.Controls.Add(this.txtPasswd);
            this.gbxData.Controls.Add(this.txtUser);
            this.gbxData.Controls.Add(this.label5);
            this.gbxData.Controls.Add(this.label4);
            this.gbxData.Controls.Add(this.label3);
            this.gbxData.Controls.Add(this.label2);
            this.gbxData.Controls.Add(this.txtServer);
            this.gbxData.Location = new System.Drawing.Point(12, 12);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(461, 117);
            this.gbxData.TabIndex = 0;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "Dados de Acesso SSH";
            // 
            // btnConect
            // 
            this.btnConect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConect.Location = new System.Drawing.Point(375, 86);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(75, 23);
            this.btnConect.TabIndex = 9;
            this.btnConect.Text = "Conectar";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // numPort
            // 
            this.numPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPort.Location = new System.Drawing.Point(350, 34);
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(100, 20);
            this.numPort.TabIndex = 1;
            this.numPort.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // txtPasswd
            // 
            this.txtPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPasswd.Location = new System.Drawing.Point(350, 60);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(100, 20);
            this.txtPasswd.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(61, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(228, 20);
            this.txtUser.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servidor:";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.Location = new System.Drawing.Point(61, 34);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(228, 20);
            this.txtServer.TabIndex = 0;
            // 
            // gbxControls
            // 
            this.gbxControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxControls.Controls.Add(this.txtLog);
            this.gbxControls.Controls.Add(this.btnChangePasswd);
            this.gbxControls.Controls.Add(this.btnEdit);
            this.gbxControls.Controls.Add(this.btnDelete);
            this.gbxControls.Controls.Add(this.cblUsers);
            this.gbxControls.Controls.Add(this.gbxAdd);
            this.gbxControls.Controls.Add(this.btnDesconect);
            this.gbxControls.Enabled = false;
            this.gbxControls.Location = new System.Drawing.Point(12, 135);
            this.gbxControls.Name = "gbxControls";
            this.gbxControls.Size = new System.Drawing.Size(461, 339);
            this.gbxControls.TabIndex = 1;
            this.gbxControls.TabStop = false;
            this.gbxControls.Text = "Controles";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(244, 114);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(206, 184);
            this.txtLog.TabIndex = 7;
            // 
            // btnChangePasswd
            // 
            this.btnChangePasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePasswd.Location = new System.Drawing.Point(96, 310);
            this.btnChangePasswd.Name = "btnChangePasswd";
            this.btnChangePasswd.Size = new System.Drawing.Size(84, 23);
            this.btnChangePasswd.TabIndex = 3;
            this.btnChangePasswd.Text = "Alterar Senha";
            this.btnChangePasswd.UseVisualStyleBackColor = true;
            this.btnChangePasswd.Click += new System.EventHandler(this.btnChangePasswd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(186, 310);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 23);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(276, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cblUsers
            // 
            this.cblUsers.AccessibleDescription = "";
            this.cblUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblUsers.FormattingEnabled = true;
            this.cblUsers.Location = new System.Drawing.Point(13, 114);
            this.cblUsers.Name = "cblUsers";
            this.cblUsers.Size = new System.Drawing.Size(223, 184);
            this.cblUsers.TabIndex = 2;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAdd.Controls.Add(this.label6);
            this.gbxAdd.Controls.Add(this.txtUserPasswd);
            this.gbxAdd.Controls.Add(this.label1);
            this.gbxAdd.Controls.Add(this.cblGroups);
            this.gbxAdd.Controls.Add(this.btnSave);
            this.gbxAdd.Controls.Add(this.cbxSmb);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.txtUserName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 19);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(438, 89);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Dados do Usuário";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Senha:";
            // 
            // txtUserPasswd
            // 
            this.txtUserPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserPasswd.Location = new System.Drawing.Point(227, 19);
            this.txtUserPasswd.Name = "txtUserPasswd";
            this.txtUserPasswd.PasswordChar = '*';
            this.txtUserPasswd.Size = new System.Drawing.Size(105, 20);
            this.txtUserPasswd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grupos:";
            // 
            // cblGroups
            // 
            this.cblGroups.AccessibleDescription = "";
            this.cblGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cblGroups.FormattingEnabled = true;
            this.cblGroups.Location = new System.Drawing.Point(52, 45);
            this.cblGroups.Name = "cblGroups";
            this.cblGroups.Size = new System.Drawing.Size(280, 34);
            this.cblGroups.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(344, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 34);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxSmb
            // 
            this.cbxSmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSmb.AutoSize = true;
            this.cbxSmb.Checked = true;
            this.cbxSmb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSmb.Location = new System.Drawing.Point(344, 22);
            this.cbxSmb.Name = "cbxSmb";
            this.cbxSmb.Size = new System.Drawing.Size(88, 17);
            this.cbxSmb.TabIndex = 2;
            this.cbxSmb.Text = "Usuário SMB";
            this.cbxSmb.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome:";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(52, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // btnDesconect
            // 
            this.btnDesconect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesconect.Location = new System.Drawing.Point(366, 310);
            this.btnDesconect.Name = "btnDesconect";
            this.btnDesconect.Size = new System.Drawing.Size(84, 23);
            this.btnDesconect.TabIndex = 6;
            this.btnDesconect.Text = "Desconectar";
            this.btnDesconect.UseVisualStyleBackColor = true;
            this.btnDesconect.Click += new System.EventHandler(this.btnDesconect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblStatus.Location = new System.Drawing.Point(9, 479);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "[Desconectado]";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 501);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gbxControls);
            this.Controls.Add(this.gbxData);
            this.Name = "frmMain";
            this.Text = "Gerenciamento de Usuários - SSH";
            this.gbxData.ResumeLayout(false);
            this.gbxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.gbxControls.ResumeLayout(false);
            this.gbxControls.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox gbxControls;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cblGroups;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbxSmb;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnDesconect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckedListBox cblUsers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserPasswd;
        private System.Windows.Forms.Button btnChangePasswd;
        private System.Windows.Forms.TextBox txtLog;
    }
}

