using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNum.Text = "";
            lblPartido.Text = "";
            lblNome.Text = "";
            btnConfirma.Enabled = false;
            Cabecalho();
        }

        
        public string path = Directory.GetCurrentDirectory();

        StreamWriter x = File.CreateText(Directory.GetCurrentDirectory() + "\\votacao.txt");

        private void Cabecalho()
        {
            x.WriteLine("Candidato: ");
        }

        //-----------------
        //Desativar numeros
        private void DisableNum()
        {
            btnNum0.Enabled = false;
            btnNum1.Enabled = false;
            btnNum2.Enabled = false;
            btnNum3.Enabled = false;
            btnNum4.Enabled = false;
            btnNum5.Enabled = false;
            btnNum6.Enabled = false;
            btnNum7.Enabled = false;
            btnNum8.Enabled = false;
            btnNum9.Enabled = false;

            //Color
            btnNum0.ForeColor = Color.White;
            btnNum1.ForeColor = Color.White;
            btnNum2.ForeColor = Color.White;
            btnNum3.ForeColor = Color.White;
            btnNum4.ForeColor = Color.White;
            btnNum5.ForeColor = Color.White;
            btnNum6.ForeColor = Color.White;
            btnNum7.ForeColor = Color.White;
            btnNum8.ForeColor = Color.White;
            btnNum9.ForeColor = Color.White;
        }

        //-----------------
        //Habilitar numeros
        private void EnableNum()
        {
            btnNum0.Enabled = true;
            btnNum1.Enabled = true;
            btnNum2.Enabled = true;
            btnNum3.Enabled = true;
            btnNum4.Enabled = true;
            btnNum5.Enabled = true;
            btnNum6.Enabled = true;
            btnNum7.Enabled = true;
            btnNum8.Enabled = true;
            btnNum9.Enabled = true;
        }


        //-------------
        //Ação Numero 1
        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum1.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum1.Text; }
            
        }

        //-------------
        //Ação Numero 2
        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum2.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum2.Text; }
            
        }

        //-------------
        //Ação Numero 3
        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum3.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum3.Text; }
        }

        //-------------
        //Ação Numero 4
        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum4.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum4.Text; }
        }

        //-------------
        //Ação Numero 5
        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum5.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum5.Text; }
        }

        //-------------
        //Ação Numero 6
        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum6.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum6.Text; }
        }

        //-------------
        //Ação Numero 7
        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum7.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum7.Text; }
        }

        //-------------
        //Ação Numero 8
        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum8.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum8.Text; }
        }

        //-------------
        //Ação Numero 9
        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum9.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum9.Text; }
        }

        //-------------
        //Ação Numero 0
        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (lblNum.Text.Length < 2)
            {
                lblNum.Text = lblNum.Text + btnNum0.Text;
                actionLabel();
            }
            else { lblNum.Text = btnNum0.Text; }
        }

        //-------------------
        //Validação dos votos
        private void actionLabel()
        {
            if (lblNum.Text == "13")
            {
                DisableNum();
                lblNome.Text = "Haddad";
                lblPartido.Text = "PT";
                try 
                { 
                    pictureBox1.Image = Image.FromFile(path + "\\Imagem\\presidencia-fernando-haddad_13.jpg"); 
                }

                catch { MessageBox.Show("Image Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                
                btnConfirma.Enabled = true;
            }

            else if (lblNum.Text == "17")
            {
                DisableNum();
                lblNome.Text = "Bolsonaro";
                lblPartido.Text = "PSL";
                try
                {
                    pictureBox1.Image = Image.FromFile(path + "\\Imagem\\presidencia-jair-bolsonaro_17.jpg");
                }
                catch { MessageBox.Show("Image Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                btnConfirma.Enabled = true;
            }

            else if (lblNum.Text == "30")
            {
                DisableNum();
                lblNome.Text = "João Amoedo";
                lblPartido.Text = "NOVO";
                try
                {
                    pictureBox1.Image = Image.FromFile(path + "\\Imagem\\presidencia_joao_amoedo_30.jpg");
                }
                catch { MessageBox.Show("Image Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                btnConfirma.Enabled = true;
            }

            else if (lblNum.Text == "51")
            {
                DisableNum();
                lblNome.Text = "Cabo Daciolo";
                lblPartido.Text = "PATRI";
                try
                {
                    pictureBox1.Image = Image.FromFile(path + "\\Imagem\\presidencia_cabo_daciolo_51.jpg");
                }
                catch { MessageBox.Show("Image Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                btnConfirma.Enabled = true;
            }

            else if (lblNum.Text == "00")
            {
                DisableNum();
                lblNome.Text = "Nulo";
                lblPartido.Text = "";
                pictureBox1.Image = null;
                btnConfirma.Enabled = true;
            }

            else { 
                pictureBox1.Image = null; 
                lblNome.Text = "";
                lblPartido.Text = "";
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            x.WriteLine("\n"+lblNum.Text);

            //Geração de mensagem
            MessageBox.Show("Voto Computado", "Gravar Voto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBox1.Image = null;
            lblNome.Text = "";
            lblPartido.Text = "";
            lblNum.Text = "";
            btnConfirma.Enabled = false;
            EnableNum();
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            lblNome.Text = "";
            lblPartido.Text = "";
            lblNum.Text = "";
            btnConfirma.Enabled = false;
            EnableNum();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            lblNome.Text = "Branco";
            lblPartido.Text = "";
            lblNum.Text = "";
            btnConfirma.Enabled = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
            x.Close();
        }
    }
}
