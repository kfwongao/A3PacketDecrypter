using System;
using System.IO;
using System.Windows.Forms;

namespace A3PacketDecrypter
{
    public partial class frmDecrypt : Form
    {
        public frmDecrypt()
        {
            InitializeComponent();
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                byte[] data = File.ReadAllBytes(openFile.FileName);
                Crypt crypt = new Crypt();
                if(rb562.Checked)
                    crypt.Decrypt(ref data, ClientVer.v562);
                else if(rbReturns.Checked)
                    crypt.Decrypt(ref data, ClientVer.v578);
                File.WriteAllBytes("Decrypted_" + openFile.SafeFileName + "_" + Environment.TickCount, data);
                MessageBox.Show("File Decrypted");
            }
        }
    }
}
