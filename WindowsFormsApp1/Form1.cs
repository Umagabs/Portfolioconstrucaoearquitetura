using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmDecoração : Form
    {
        String[,] Ambientes;
        PictureBox[] PBs;

        public FrmDecoração()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDecoração_Load(object sender, EventArgs e)
        {
            Ambientes = new String[6, 2];
            Ambientes[0, 0] = "Externa";
            Ambientes[0, 1] = "Jardim";

            Ambientes[1, 0] = "Externa"; 
            Ambientes[1, 1] = "Lazer"; 

            Ambientes[2, 0] = "Externa";
            Ambientes[2, 1] = "Varanda"; 

            Ambientes[3, 0] = "Interna"; 
            Ambientes[3, 1] = "Cozinha";

            Ambientes[4, 0] = "Interna"; 
            Ambientes[4, 1] = "Quarto"; 

            Ambientes[5, 0] = "Interna"; 
            Ambientes[5, 1] = "Sala";

            PBs = new PictureBox[6] { pic1, pic2, pic3, pic4, pic5, pic6 };

            cmbAmbiente.Enabled = false;
            panel1.Visible = false;
            txtValor.Enabled = false;
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAmbiente.Items.Clear();

            for(int i = 0; i <= Ambientes.GetUpperBound(0); i ++)
            {
                if (cmbArea.Text == Ambientes[i, 0])
                    cmbAmbiente.Items.Add(Ambientes[i, 1]);
            }
            cmbAmbiente.ResetText();
            cmbAmbiente.Enabled = true;
            panel1.Visible = false;
        }

        private void cmbAmbiente_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i <= PBs.GetUpperBound(0); i++)
            {
                PBs[i].ImageLocation = "Imagens\\" + cmbAmbiente.Text + (i + 1) + ".jpg";
                panel1.Visible = true;
                txtValor.Text = " R$3.000";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbArea.ResetText();
            cmbAmbiente.ResetText();
            cmbAmbiente.Enabled = false;
            panel1.Visible = false;
            txtValor.Text = "0";
        }
    }
}
