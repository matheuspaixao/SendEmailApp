namespace SendMails
{
    partial class Form_SendEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SendEmail));
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.chkSsl = new System.Windows.Forms.CheckBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSender = new System.Windows.Forms.Label();
            this.txtSmtp = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSmtp = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.lblQtdAttachments = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(9, 28);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(49, 19);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "Para:";
            // 
            // txtTo
            // 
            this.txtTo.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(108, 28);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(496, 27);
            this.txtTo.TabIndex = 0;
            // 
            // txtCC
            // 
            this.txtCC.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.Location = new System.Drawing.Point(108, 61);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(496, 27);
            this.txtCC.TabIndex = 1;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.Location = new System.Drawing.Point(9, 61);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(38, 19);
            this.lblCC.TabIndex = 2;
            this.lblCC.Text = "CC:";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(108, 94);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(496, 27);
            this.txtSubject.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(9, 94);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(72, 19);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Assunto:";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(108, 127);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(496, 236);
            this.txtMessage.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(9, 127);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(93, 19);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Mensagem:";
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpSettings.Controls.Add(this.btnShowPassword);
            this.grpSettings.Controls.Add(this.chkSsl);
            this.grpSettings.Controls.Add(this.txtSender);
            this.grpSettings.Controls.Add(this.btnSend);
            this.grpSettings.Controls.Add(this.lblSender);
            this.grpSettings.Controls.Add(this.txtSmtp);
            this.grpSettings.Controls.Add(this.lblPassword);
            this.grpSettings.Controls.Add(this.lblSmtp);
            this.grpSettings.Controls.Add(this.txtPassword);
            this.grpSettings.Controls.Add(this.txtPort);
            this.grpSettings.Controls.Add(this.lblPort);
            this.grpSettings.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSettings.Location = new System.Drawing.Point(108, 432);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(496, 140);
            this.grpSettings.TabIndex = 8;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Configuração";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Image")));
            this.btnShowPassword.Location = new System.Drawing.Point(420, 66);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(30, 26);
            this.btnShowPassword.TabIndex = 2;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // chkSsl
            // 
            this.chkSsl.AutoSize = true;
            this.chkSsl.Checked = true;
            this.chkSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSsl.Location = new System.Drawing.Point(420, 34);
            this.chkSsl.Name = "chkSsl";
            this.chkSsl.Size = new System.Drawing.Size(62, 23);
            this.chkSsl.TabIndex = 5;
            this.chkSsl.Text = "SSL";
            this.chkSsl.UseVisualStyleBackColor = true;
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(107, 34);
            this.txtSender.MinimumSize = new System.Drawing.Size(0, 30);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(307, 30);
            this.txtSender.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(420, 100);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 26);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(10, 34);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(91, 19);
            this.lblSender.TabIndex = 9;
            this.lblSender.Text = "Remetente:";
            // 
            // txtSmtp
            // 
            this.txtSmtp.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSmtp.Location = new System.Drawing.Point(236, 100);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(179, 27);
            this.txtSmtp.TabIndex = 4;
            this.txtSmtp.Text = "smtp.gmail.com";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 19);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Senha:";
            // 
            // lblSmtp
            // 
            this.lblSmtp.AutoSize = true;
            this.lblSmtp.Font = new System.Drawing.Font("SansSerif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmtp.Location = new System.Drawing.Point(192, 103);
            this.lblSmtp.Name = "lblSmtp";
            this.lblSmtp.Size = new System.Drawing.Size(44, 16);
            this.lblSmtp.TabIndex = 15;
            this.lblSmtp.Text = "Smtp:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(107, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(107, 100);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(70, 27);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "587";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(10, 100);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(53, 19);
            this.lblPort.TabIndex = 13;
            this.lblPort.Text = "Porta:";
            // 
            // lblAttachment
            // 
            this.lblAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachment.Location = new System.Drawing.Point(9, 369);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(67, 19);
            this.lblAttachment.TabIndex = 10;
            this.lblAttachment.Text = "Anexos:";
            // 
            // btnAttachment
            // 
            this.btnAttachment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAttachment.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachment.Location = new System.Drawing.Point(560, 369);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(44, 28);
            this.btnAttachment.TabIndex = 11;
            this.btnAttachment.Text = "...";
            this.btnAttachment.UseVisualStyleBackColor = true;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // lstAttachments
            // 
            this.lstAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAttachments.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.ItemHeight = 20;
            this.lstAttachments.Location = new System.Drawing.Point(108, 369);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(446, 44);
            this.lstAttachments.TabIndex = 12;
            this.lstAttachments.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstAttachments_KeyDown);
            // 
            // lblQtdAttachments
            // 
            this.lblQtdAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQtdAttachments.AutoSize = true;
            this.lblQtdAttachments.Font = new System.Drawing.Font("SansSerif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdAttachments.Location = new System.Drawing.Point(528, 420);
            this.lblQtdAttachments.Name = "lblQtdAttachments";
            this.lblQtdAttachments.Size = new System.Drawing.Size(0, 19);
            this.lblQtdAttachments.TabIndex = 13;
            // 
            // Form_SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 584);
            this.Controls.Add(this.lblQtdAttachments);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.btnAttachment);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lblTo);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(634, 631);
            this.Name = "Form_SendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar email";
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.CheckBox chkSsl;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox txtSmtp;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSmtp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Label lblQtdAttachments;
    }
}

