using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD5aAES256
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void btnmd5desencriptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                try
                {
                    txtmd5desencriptada.Text = string.Empty;
                    txtaes256encriptada.Text = string.Empty;

                    MD5 md5 = new MD5();
                    txtmd5desencriptada.Text = md5.DesencriptarMD5(txtmd5encriptada.Text);

                    Encrypt aes256 = new Encrypt();
                    txtaes256encriptada.Text = aes256.Encriptar(txtmd5desencriptada.Text);

                    md5 = null;
                    aes256 = null;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message.ToString());
                }

            }

        }

        private bool Validar()
        {
            if (string.IsNullOrEmpty(txtmd5encriptada.Text))
            {
                errorProvider1.SetError(txtmd5encriptada, "Campo obligatorio");
                txtmd5encriptada.BackColor = Color.Yellow;
                return false;
            }
            return true;
        }

        //privae void txtmd5encriptada_GotFocus
        private void txtmd5encriptada_GotFocus(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtmd5encriptada.BackColor = Color.White;
        }

        private void txtAES256aRevelar_GotFocus(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtAES256aRevelar.BackColor = Color.White;
        }
        private void btnRevelar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAES256aRevelar.Text))
            {
                errorProvider1.SetError(txtAES256aRevelar, "Campo obligatorio");
                txtAES256aRevelar.BackColor = Color.Yellow;

            }
            else
            {
                try
                {
                    txtAES256Revelada.Text = string.Empty;
                    Encrypt aes = new Encrypt();
                    txtAES256Revelada.Text = aes.Desencriptar(txtAES256aRevelar.Text);

                    aes = null;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message.ToString());
                }

            }
        }
    }
}
