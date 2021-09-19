using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorHexPicker
{
    public partial class Form1 : Form
    {
        bool flag = false;
        public Form1()
        {
            InitializeComponent();

            tbA.Value = 255;
            pnColor.BackColor = Color.FromArgb(tbA.Value, tbRed.Value, tbG.Value, tbB.Value);
            tApha.Text = (Convert.ToDouble(tbA.Value)).ToString();
            tR.Text = tbRed.Value.ToString();
            tG.Text = tbG.Value.ToString();
            tB.Text = tbB.Value.ToString();
            flag = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scroll_activity(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(tbA.Value, tbRed.Value, tbG.Value, tbB.Value);
            pnColor.BackColor = color;
            
            tR.Text = tbRed.Value.ToString();
            tG.Text = tbG.Value.ToString();
            tB.Text = tbB.Value.ToString();
            tApha.Text = (Convert.ToDouble(tbA.Value)).ToString();
            txtHex.Text = HexConverter(color);
            
        }
        private static String HexConverter(System.Drawing.Color c)
        {
            String rtn = String.Empty;
            try
            {
                rtn = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
            catch (Exception ex)
            {
                //doing nothing
            }

            return rtn;
        }

        private void txtHex_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHex.Text);
        }

        private void tR_TextChanged(object sender, EventArgs e)
        {
            if(flag)
            {
                //if(tR.TextLength==0)
                //{
                //    tbRed.Value = 0;
                //}
                //if (tG.TextLength == 0)
                //{
                //    tbG.Value = 0;
                //}
                //if (tB.TextLength == 0)
                //{
                //    tbB.Value = 0;

                //}
                //if (tApha.TextLength == 0)
                //{
                //    tbA.Value = 0;
                //}
                try
                {
                    tbA.Value = Convert.ToInt32(tApha.Text);
                    tbRed.Value = Convert.ToInt32(tR.Text);
                    tbG.Value = Convert.ToInt32(tG.Text);
                    tbB.Value = Convert.ToInt32(tB.Text);
                    Color color = Color.FromArgb(tbA.Value, tbRed.Value, tbG.Value, tbB.Value);
                    pnColor.BackColor = color;
                    txtHex.Text = HexConverter(color);
                }catch(Exception ex)
                {
                    //
                }

            }

        }

        private void tApha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)||char.IsWhiteSpace(e.KeyChar)||char.IsPunctuation(e.KeyChar)||char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetText().StartsWith("#")&&Clipboard.GetText().Length==7)
            {
                txtHex.Text = Clipboard.GetText();
                Color color = System.Drawing.ColorTranslator.FromHtml(txtHex.Text);
                pnColor.BackColor = color;
            }
               
        }
    }
}
