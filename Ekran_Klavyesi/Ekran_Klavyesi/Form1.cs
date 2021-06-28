using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Ekran_Klavyesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// CreateParams bir kontrol oluştururken gereken bilgileri kapsar
        /// 0x08000000 stille oluşturulan üst düzey bir pencere, kullanıcı tıklattığında ön plan penceresi haline gelmemesini sağlar. Kullanıcı ön plan penceresini küçülttüğünde veya kapattığında sistem bu pencereyi ön plana getirmez
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// bütün checkboxlar capslock_CheckedChanged eventine gönderilerek gerekli koşullarda yapacağı işleveler kodlanmıştır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void capslock_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if(shift.Checked||shift2.Checked)//shift tuşları aktifken ekranda gösterilecek
            {
                unlem.Text = "!";
                tektirnak.Text = "'";
                sharp.Text = "^";
                arti4.Text = "+";
                yuzde.Text = "%";
                and6.Text = "&&";
                slash7.Text = "/";
                parantez1.Text = "(";
                parantez2.Text = ")";
                button2.Text = "=";
                soruisareti.Text = "?";
                altcizgi.Text = "_";
                Q.Text = "Q\n    @";
                W.Text = "W";
                E.Text = "E\n    €";
                R.Text = "R";
                T.Text = "T";
                Y.Text = "Y";
                U.Text = "U";
                I.Text = "I";
                O.Text = "O";
                P.Text = "P";
                Ğ.Text = "Ğ\n    ¨";
                Ü.Text = "Ü\n    ~";
                A.Text = "A";
                S.Text = "S";
                D.Text = "D";
                F.Text = "F";
                G.Text = "G";
                h.Text = "H";
                j.Text = "J";
                K.Text = "K";
                L.Text = "L";
                Ş.Text = "Ş";
                İ.Text = "İ";
                Z.Text = "Z";
                X.Text = "X";
                C.Text = "C";
                V.Text = "V";
                B.Text = "B";
                N.Text = "N";
                M.Text = "M";
                Ö.Text = "Ö";
                Ç.Text = "Ç";
                virgul.Text = ";";
                nokta.Text = ":";
                buyukkucuk.Text = ">";
                denden.Text = "é";
            }
            else if(capslock.Checked)//capslock tuşu aktifken ekranda gösterilecek
            {
                Q.Text = "Q\n    @";
                W.Text = "W";
                E.Text = "E\n    €";
                R.Text = "R";
                T.Text = "T";
                Y.Text = "Y";
                U.Text = "U";
                I.Text = "I";
                O.Text = "O";
                P.Text = "P";
                Ğ.Text = "Ğ\n    ¨";
                Ü.Text = "Ü\n    ~";
                A.Text = "A";
                S.Text = "S";
                D.Text = "D";
                F.Text = "F";
                G.Text = "G";
                h.Text = "H";
                j.Text = "J";
                K.Text = "K";
                L.Text = "L";
                Ş.Text = "Ş";
                İ.Text = "İ";
                Z.Text = "Z";
                X.Text = "X";
                C.Text = "C";
                V.Text = "V";
                B.Text = "B";
                N.Text = "N";
                M.Text = "M";
                Ö.Text = "Ö";
                Ç.Text = "Ç";
            }
            else if (alt.Checked||alt2.Checked)//alt tuşları aktifken ekranda gösterilecek
            {
                unlem.Text = ">";
                tektirnak.Text = "£";
                sharp.Text = "#";
                arti4.Text = "$";
                yuzde.Text = "½";
                and6.Text = "";
                slash7.Text = "{";
                parantez1.Text = "[";
                parantez2.Text = "]";
                button2.Text = "}";
                soruisareti.Text = "\\";
                altcizgi.Text = "|";
                Q.Text = "@";
                W.Text = "";
                E.Text = "€";
                R.Text = "";
                T.Text = "";
                Y.Text = "";
                U.Text = "";
                I.Text = "";
                O.Text = "";
                P.Text = "";
                Ğ.Text = "¨¨";
                Ü.Text = "~~";
                A.Text = "";
                S.Text = "";
                D.Text = "";
                F.Text = "";
                G.Text = "";
                h.Text = "";
                j.Text = "";
                K.Text = "";
                L.Text = "";
                Ş.Text = "";
                İ.Text = "";
                Z.Text = "";
                X.Text = "";
                C.Text = "";
                V.Text = "";
                B.Text = "";
                N.Text = "";
                M.Text = "";
                Ö.Text = "";
                Ç.Text = "";
                buyukkucuk.Text = "|";
                denden.Text = "<";
                virgul.Text = "``";
                nokta.Text = "";
            }
            else//aktif tuş yokken ekranda gösterilecek
            {
                unlem.Text = "!\n1  >";
                tektirnak.Text = "'\n2  £";
                sharp.Text = "^\n3  #";
                arti4.Text = "+\n4  $";
                yuzde.Text = "%\n5  ½";
                and6.Text = "&&\n6";
                slash7.Text = "/\n7  {";
                parantez1.Text = "(\n8  [";
                parantez2.Text = ")\n9  ]";
                button2.Text = "=\n0  }";
                soruisareti.Text = "?\n*  \\";
                altcizgi.Text = "_\n-  |";
                denden.Text = "é\n''  <";
                buyukkucuk.Text = ">\n<  |";
                virgul.Text = ";\n,  ``";
                nokta.Text = ":\n.";
                Q.Text = "q\n    @";
                W.Text = "w";
                E.Text = "e\n    €";
                R.Text = "r";
                T.Text = "t";
                Y.Text = "y";
                U.Text = "u";
                I.Text = "ı";
                O.Text = "o";
                P.Text = "p";
                Ğ.Text = "ğ\n    ¨";
                Ü.Text = "ü\n    ~";
                A.Text = "a";
                S.Text = "s";
                D.Text = "d";
                F.Text = "f";
                G.Text = "g";
                h.Text = "h";
                j.Text = "j";
                K.Text = "k";
                L.Text = "l";
                Ş.Text = "ş";
                İ.Text = "i";
                Z.Text = "z";
                X.Text = "x";
                C.Text = "c";
                V.Text = "v";
                B.Text = "b";
                N.Text = "n";
                M.Text = "m";
                Ö.Text = "ö";
                Ç.Text = "ç";
            }
        }
        /// <summary>
        /// gerekli koşullar sağlandığında yapacağı farklı işlemler yazdırılmıştır. bu işlem diğer aynı tarz diğer butonlarlarda da yapılmıştır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Q_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked||capslock.Checked)
            {
                SendKeys.Send("Q");
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("@");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("q");
        }

        private void virgul_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send(";");
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("``");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send(",");

        }
        /// <summary>
        /// bütün butonlar esc butonunun MouseLeave eventine gönderilerek fare butonun üstünden ayrıldığında renginin rgb türünde 64,64,64 olmasını sağlıyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void esc_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(64, 64, 64);
        }
        /// <summary>
        /// bütün butonlar esc butonunun MouseMove eventine gönderilerek fare butonun üstüne geldiğinde renginin rgb türünde 238, 130, 83 olmasını sağlıyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void esc_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(238, 130, 83);
        }
        /// <summary>
        /// bütün checkboxları capslock checkboxına MouseLeave eventine gönderilerek fare butonun üstünden ayrıldığında renginin rgb türünde 64,64,64 olmasını sağlıyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void capslock_MouseLeave(object sender, EventArgs e)
        {
            CheckBox chbx = sender as CheckBox;
            chbx.BackColor = Color.FromArgb(64, 64, 64);
        }
        /// <summary>
        /// bütün checkboxları capslock checkboxına MouseMove eventine gönderilerek fare butonun üstüne geldiğinde renginin rgb türünde 238, 130, 83 olmasını sağlıyoruz.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void capslock_MouseMove(object sender, MouseEventArgs e)
        {
            CheckBox chbx = sender as CheckBox;
            chbx.BackColor = Color.FromArgb(238, 130, 83);
        }

        
        private void SIL_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{BACKSPACE}");// backspace butonu çalışmıştır
        }
        
        private void del_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if(shift.Checked||shift2.Checked)
            {
                SendKeys.Send("+{DEL}");//shift kısayolu oluşturuldu
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
                SendKeys.Send("{DEL}");// delete butonu çalışmıştır
        }
       
        private void f12_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F12}");// f12 butonu çalışmıştır
        }
      
        private void f11_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F11}");// f11 butonu çalışmıştır
        }

        private void f10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("+{F10}");//shift kısayolu oluşturuldu
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
                SendKeys.Send("{F10}");// f10 butonu çalışmıştır
        }
        private void f9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F9}");// f9 butonu çalışmıştır
        }
        private void f8_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F8}");// f8 butonu çalışmıştır
        }
        private void button3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F7}");// f7 butonu çalışmıştır
        }
        private void f6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F6}");// f6 butonu çalışmıştır
        }
        private void f5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F5}");// f5 butonu çalışmıştır
        }
        private void f4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F4}");// f4 butonu çalışmıştır
        }
        private void f3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F3}");// f3 butonu çalışmıştır
        }
        private void f2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F2}");// f2 butonu çalışmıştır
        }
        private void f1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{F1}");// f1 butonu çalışmıştır
        }
        private void esc_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{ESC}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else
            {
                this.Close();// esc butonu çalışmıştır
                Application.Exit();
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{ENTER}");// enter butonu çalışmıştır
        }

        private void yukari_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{UP}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("+{UP}");//shift kısayolu oluşturuldu
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
                SendKeys.Send("{UP}");//yukarı tuşu oluşturuldu
        }

        private void sag_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{RIGHT}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("+{RIGHT}");//shift kısayolu oluşturuldu
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
                SendKeys.Send("{RIGHT}");//sağ tuşu oluşturuldu
        }

        private void asagi_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{DOWN}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("+{DOWN}");//shift kısayolu oluşturuldu
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
                SendKeys.Send("{DOWN}");//aşağı oku işlevi
        }

        private void sol_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (ctrlsag.Checked || ctrlsol.Checked)//ctrl kısayolu oluşturuldu
            {
                SendKeys.Send("^{LEFT}");
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("+{LEFT}");//shift kısayolu oluşturuldu
                shift.Checked = false;
                shift2.Checked = false;
            }
            else
                SendKeys.Send("{LEFT}");//sol oku işlevi
        }
        
        private void denden_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("é");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("<");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("''");
                
        }

        private void unlem_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("!");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send(">");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("1");
        }

        private void tektirnak_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("'");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("£");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("2");
        }

        private void sharp_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("^^");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("#");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("3");
        }

        private void arti4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{+}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("$");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("4");
        }

        private void yuzde_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{%}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("{½}");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("5");
        }

        private void and6_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{&}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("6");
        }

        private void slash7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("/");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                
                SendKeys.Send("{{}");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("7");
        }

        private void parantez1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{(}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("[");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("8");
        }

        private void parantez2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("{)}");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("]");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("9");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("=");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("{}}");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("0");
        }

        private void soruisareti_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("?");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("\\");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("*");
        }

        private void altcizgi_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send("_");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("|");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("-");
        }

        private void slash_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("/");
        }

        private void carpi_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("*");
        }

        private void cizgi_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("-");
        }

        private void arti_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{+}");
        }

        private void sayi7_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("7");
        }

        private void sayi8_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("8");
        }

        private void sayi9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("9");
        }

        private void sayi4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("4");
        }

        private void sayi5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("5");
        }

        private void sayi6_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("6");
        }

        private void sayi1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("1");
        }

        private void sayi2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("2");
        }

        private void sayi3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("3");
        }

        private void sayi0_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("0");
        }

        

        private void SPACE_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send(" ");
        }

        private void virgul2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send(",");
        }

        private void tab_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            SendKeys.Send("{TAB}");
        }

        private void W_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("W");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("w");
        }

        private void E_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("E");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("€");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("e");
        }

        private void R_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("R");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("r");
        }

        private void T_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("T");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("t");
        }

        private void Y_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("Y");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{Y}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("y");
        }

        private void U_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("U");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("u");
        }

        private void I_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("I");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("ı");
        }

        private void O_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("O");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("o");
        }

        private void P_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("P");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{P}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("p");
        }

        private void Ğ_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("Ğ");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("¨¨");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
                SendKeys.Send("ğ");
        }

        private void Ü_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("Ü");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
    
              SendKeys.Send("~~");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
                SendKeys.Send("ü");
        }

        private void A_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("A");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{A}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("a");
        }

        private void S_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("S");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("s");
        }

        private void D_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("D");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{D}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("d");
        }

        private void F_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("F");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("f");
        }

        private void G_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("G");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("g");
        }

        private void h_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("H");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("h");
        }

        private void j_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("J");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{J}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("j");
        }

        private void K_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("K");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("k");
        }

        private void L_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("L");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{L}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("l");
        }

        private void Ş_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("Ş");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("ş");
        }

        private void İ_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("İ");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("i");
        }

        private void Z_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("Z");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{Z}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("z");
        }

        private void X_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("X");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{X}");//ctrl kısayolu oluşturuldu
                ctrlsag.Checked = false;
                ctrlsol.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("x");
        }

        private void C_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("C");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{C}");
                ctrlsol.Checked = false;
                ctrlsag.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("c");
        }

        private void V_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("V");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (ctrlsag.Checked || ctrlsol.Checked)
            {
                SendKeys.Send("^{V}");
                ctrlsol.Checked = false;
                ctrlsag.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("v");
        }

        private void B_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("B");
                shift.Checked = false;
                shift2.Checked = false; ;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("b");
        }

        private void N_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("N");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("n");
        }

        private void M_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("M");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("m");
        }

        private void Ö_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("Ö");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("ö");
        }

        private void Ç_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked || capslock.Checked)
            {
                SendKeys.Send("Ç");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send("ç");
        }

        private void nokta_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send(":");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if (alt.Checked || alt2.Checked)
            {
                SendKeys.Send("");
                alt2.Checked = false;
                alt.Checked = false;
            }
            else
                SendKeys.Send(".");
        }

        private void buyukkucuk_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();
            if (shift.Checked || shift2.Checked)
            {
                SendKeys.Send(">");
                shift.Checked = false;
                shift2.Checked = false;
            }
            else if(alt.Checked||alt2.Checked)
            {
                SendKeys.Send("|");
                alt.Checked = false;
                alt2.Checked = false;
            }
            else
                SendKeys.Send("<");
        }

        private void ctrlsol_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "button-49.wav";
            ses.Play();

        }

        
    }
}
