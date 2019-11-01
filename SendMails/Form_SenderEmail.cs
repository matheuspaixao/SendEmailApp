using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.IO;

namespace SendMails
{
    public partial class Form_SendEmail : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        Dictionary<string, string> attachments = new Dictionary<string, string>();

        public Form_SendEmail()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                btnSend.Enabled = false;

                SendMail();

                Cursor = Cursors.Default;
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                btnSend.Enabled = true;
                MessageBox.Show(ex.Message);
            }            
        }

        public void SendMail()
        {
            try
            {
                if (isValidFields())
                {
                    login = new NetworkCredential(txtSender.Text, txtPassword.Text);
                    client = new SmtpClient(txtSmtp.Text, Convert.ToInt32(txtPort.Text));
                    client.EnableSsl = chkSsl.Checked;
                    client.Credentials = login;

                    msg = new MailMessage { From = new MailAddress(txtSender.Text) };

                    string[] emails = txtTo.Text.Replace(" ", "").Split(',');
                    foreach (var item in emails)
                        msg.To.Add(new MailAddress(item));

                    foreach (var item in attachments)
                        msg.Attachments.Add(new Attachment(item.Key));

                    msg.Subject = txtSubject.Text.Trim().Equals("") ? "(sem assunto)" : txtSubject.Text;
                    msg.Body = txtSubject.Text;
                    msg.BodyEncoding = Encoding.UTF8;
                    msg.IsBodyHtml = true;
                    msg.Priority = MailPriority.Normal;
                    msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                    client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallBack);
                    client.SendAsync(msg, "Enviando...");
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Ocorreu uma exceção: " + ex.Message.ToString());
            }
        }

        private void SendCompletedCallBack(object sender, AsyncCompletedEventArgs e)
        {
            Cursor = Cursors.Default;
            btnSend.Enabled = true;

            if (e.Cancelled)
                MessageBox.Show(String.Format("{0} envio cancelado.", e.UserState), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (e.Error != null)
                MessageBox.Show(String.Format("{0} {1}", e.UserState, e.Error), "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(DateTime.Now.ToString() + " Sua mensagem foi enviada com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
                btnShowPassword.Image = global::SendMails.Properties.Resources.icon_eye_stroke;
            else
                btnShowPassword.Image = global::SendMails.Properties.Resources.icon_eye;

            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.ShowDialog();

            if (ofd.FileNames.Length > 0)
            {
                string str;

                foreach (var item in ofd.FileNames)
                {
                    if (!attachments.ContainsKey(item))
                    {
                        str = item.Replace(@"\", "/").Split('/').Last();
                        attachments.Add(item, str);
                    }
                }

                setAttachments();
            }
        }

        private void lstAttachments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstAttachments.SelectedIndex >= 0)
            {
                attachments.Remove(lstAttachments.SelectedValue.ToString());
                setAttachments();
            }
        }

        private void setAttachments()
        {
            lstAttachments.DataSource = null;
            lstAttachments.DataSource = attachments.ToList();
            lstAttachments.DisplayMember = "value";
            lstAttachments.ValueMember = "key";

            if (attachments.Count > 0)
                lblQtdAttachments.Text = "(" + attachments.Count.ToString() + " anex.)";
            else
                lblQtdAttachments.Text = "";
        }

        private bool isValidFields()
        {            
            if (String.IsNullOrWhiteSpace(txtTo.Text))
            {
                MessageBox.Show("O campo destinatários é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTo.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtSender.Text))
            {
                MessageBox.Show("O campo remetente é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSender.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("O campo senha é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtPort.Text))
            {
                MessageBox.Show("O campo porta é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPort.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtSmtp.Text))
            {
                MessageBox.Show("O campo smtp é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSmtp.Focus();
                return false;
            }

            txtTo.Text = txtTo.Text.Replace(" ", "").Replace(",", ", ");
            txtCC.Text = txtCC.Text.Replace(" ", "").Replace(",", ", ");
            txtSender.Text = txtSender.Text.Replace(" ", "");

            if (!validateEmails(txtTo.Text, "to") || !validateEmails(txtCC.Text, "cc") || !validateEmails(txtSender.Text, "sender"))
            {
                return false;
            }

            return true;
        }

        private bool validateEmails(string emails, string fieldName) {            
            string[] str = emails.Split(',');
            int pos = 0, i = 0;

            if (!String.IsNullOrWhiteSpace(emails))            
                foreach (var item in str)
                {
                    if (!isValidEmail(item.TrimStart()))
                    {
                        MessageBox.Show(String.Format("'{0}' não é um email válido!", item), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        switch (fieldName)
                        {
                            case "to":
                                txtTo.Focus();
                                txtTo.Select(pos + i, item.Length);
                                break;
                            case "cc":
                                txtCC.Focus();
                                txtCC.Select(pos + i, item.Length);
                                break;
                            case "sender":
                                txtSender.Focus();
                                txtSender.SelectAll();
                                break;
                        }

                        return false;
                    }

                    i++;
                    pos += item.Length;
                }

            return true;
        }

        public static bool isValidEmail(string emailAddress)
        {
            try
            {
                // define regular expression to validate email address
                Regex expressionRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                // test email address with expression
                return expressionRegex.IsMatch(emailAddress) ? true : false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
    }
}
