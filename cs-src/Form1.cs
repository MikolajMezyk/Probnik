// basic libs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// email libs
using MailKit;
using MimeKit;
// cryptography
using System.Security.Cryptography;
using MimeKit.Text;
using MailKit.Security;
using MailKit.Net.Smtp;
using System.IO;

namespace SMTP
{
    public partial class Form1 : Form
    {
        string server_adress, sender_mail, sender_pass, receiver_mail;
        int port;
        bool aesrsa = true;
        public Form1()
        {
            InitializeComponent();
            logBox.Text = string.Empty;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // create email message
            var email = new MimeMessage();
            try
            {
                email.From.Add(MailboxAddress.Parse(sender_mail));
                email.To.Add(MailboxAddress.Parse(receiver_mail));
            }
            catch
            {
                MessageBox.Show("Sender or receiver not specified. Go to settings first.");
            }
            if (keyBox.Text == "[key]" || keyBox.Text == "")
            {
                // AES with generated password
                string subject = subjectBox.Text;
                string[] subjects = AES.RandomKeyAES(subject);

                string body = messageBox.Text;
                string bodies = AES.EncryptAES(body, subjects[1]);

                email.Subject = subjects[0];
                keyBox.Invoke((MethodInvoker)delegate { keyBox.Text = subjects[1]; });
                subjectBox.Invoke((MethodInvoker)delegate { subjectBox.Text = subjects[0]; });
                messageBox.Invoke((MethodInvoker)delegate { messageBox.Text = bodies; });
                email.Body = new TextPart(TextFormat.Html) { Text = bodies };
            }
            else
            {
                // AES with own password
                string subject = subjectBox.Text;
                string subjects = AES.EncryptAES(subject, keyBox.Text);

                string body = messageBox.Text;
                string bodies = AES.EncryptAES(body, keyBox.Text);
                
                email.Subject = subjects;
                keyBox.Invoke((MethodInvoker)delegate { keyBox.Text = keyBox.Text; });
                subjectBox.Invoke((MethodInvoker)delegate { subjectBox.Text = subjects; });
                messageBox.Invoke((MethodInvoker)delegate { messageBox.Text = bodies; });
                email.Body = new TextPart(TextFormat.Html) { Text = bodies };
            }

            // mail send process
            
            var smtp = new SmtpClient();
            try
            {
                smtp.Connect(server_adress, port, SecureSocketOptions.StartTls);
            }
            catch
            {
                MessageBox.Show("Server does not exist. Check server url");
            }
            try
            {
                smtp.Authenticate(sender_mail, sender_pass);
            }
            catch
            {
                MessageBox.Show("Credentials not valid");
            }
            try
            {
                smtp.Send(email);
            }
            catch
            {
                MessageBox.Show("Type L error, mail not send");
            }
            smtp.Disconnect(true);        
            
        }
        //receive
        private void button3_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            subjectBox.Invoke((MethodInvoker)delegate { subjectBox.Text = AES.DecryptAES(subjectBox.Text, keyBox.Text); });
            messageBox.Invoke((MethodInvoker)delegate { messageBox.Text = AES.DecryptAES(messageBox.Text, keyBox.Text); }); 
        }

        //send
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }
        //settings
        private void button2_Click(object sender, EventArgs e)
        {
            settings s = new settings();
            s.form1 = this;
            s.ShowDialog();
        }
        public void ApplySettings(string server_adress, int port, string sender_mail, string sender_pass, string receiver_mail,bool aesrsa)
        {
            this.server_adress = server_adress;
            this.port = port;
            this.sender_mail = sender_mail;
            this.sender_pass = sender_pass;
            this.receiver_mail = receiver_mail;
            this.aesrsa = aesrsa;
            //logs
            logBox.Text += "svr-. " + this.server_adress + "\n";
            logBox.Text += "port " + this.port.ToString() + "\n";
            logBox.Text += "snd-@ " + this.sender_mail + "\n";
            logBox.Text += "snd-* " + this.sender_pass + "\n";
            logBox.Text += "rec-@ " + this.receiver_mail + "\n";
        }
    }
    public static class AES
    {
        private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 5, 11, 2, 16, 13, 10, 9, 6, 12, 15, 14, 3, 7, 8, 4 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }
        public static string EncryptAES(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }
        public static string[] RandomKeyAES(string input)
        {
            string aesKey = RandomString(256);
            return new string[2] { EncryptAES(input, aesKey), aesKey};
        }
        public static string RandomString(int size)
        {
            string baseGen = "#$%&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = baseGen[Convert.ToInt32(Math.Floor(92 * random.NextDouble()))];
                builder.Append(ch);
            }
            return builder.ToString();
        }
        private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            try
            {
                byte[] decryptedBytes = null;

                // Set your salt here, change it to meet your flavor:
                // The salt bytes must be at least 8 bytes.
                byte[] saltBytes = new byte[] { 1, 5, 11, 2, 16, 13, 10, 9, 6, 12, 15, 14, 3, 7, 8, 4 };

                using (MemoryStream ms = new MemoryStream())
                {
                    using (RijndaelManaged AES = new RijndaelManaged())
                    {
                        AES.KeySize = 256;
                        AES.BlockSize = 128;

                        var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                        AES.Key = key.GetBytes(AES.KeySize / 8);
                        AES.IV = key.GetBytes(AES.BlockSize / 8);

                        AES.Mode = CipherMode.CBC;

                        using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                            cs.Close();
                        }
                        decryptedBytes = ms.ToArray();
                    }
                }
                return decryptedBytes;
            }
            catch
            {
                //MessageBox.Show("key invalid or double deryption attempt")
            }
            return null;
        }
        public static string DecryptAES(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);
            string result = "";
            if (bytesDecrypted != null)
                result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
    }
}
