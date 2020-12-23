using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GCF.Classes.Media;

namespace GCF.UI.Principal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (txb_Valor1.Text==string.Empty || txb_Valor2.Text==string.Empty)
            {
                MessageBox.Show("Favor preencher as notas do aluno!");
                return;
            }

            decimal valor1 = decimal.Parse(txb_Valor1.Text);
            decimal valor2 = decimal.Parse(txb_Valor2.Text);

            Media media = new Media(valor1, valor2);
            ltbHistoricoMedias.Items.Add(media);
            decimal resultado = media.CalcularMedia();
          
            frmMostraResultado frmMostraResultado = new frmMostraResultado(resultado.ToString());
            
            frmMostraResultado.ShowDialog();

            /*if (resultado>=7)
            {
                MessageBox.Show("Nota " + media.CalcularMedia().ToString() + " Aprovado");
            }
            else
            {
                MessageBox.Show("Nota " + media.CalcularMedia().ToString() + " Reprovado");
            }
           */
            txb_Valor1.Focus();
            txb_Valor1.Clear();
            txb_Valor2.Clear();
            return;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = ((Media)ltbHistoricoMedias.Items[ltbHistoricoMedias.SelectedIndex]).Valor1.ToString();
        }
    }
}
