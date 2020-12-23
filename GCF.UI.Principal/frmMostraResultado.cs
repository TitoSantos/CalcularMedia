using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GCF.UI.Principal
{
    public partial class frmMostraResultado : Form
    {
        public frmMostraResultado()
        {
            InitializeComponent();
        }

        public frmMostraResultado(string v)
        {
            InitializeComponent();
            lblMedia.Text = v;

            decimal media = decimal.Parse(v);

            if (media >= 7)
            {
                lblSituacao.Text = "Aprovado";
            }
            else
            {
                lblSituacao.Text = "Reprovado";
            }
        }

        private void frmMostraResultado_Load(object sender, EventArgs e)
        {

        }
    }
}
