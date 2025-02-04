using IFSPAero.App.Forms;
using IFSPAero.App.Infra;
using IFSPAero.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPAero.App
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

        private void cadastrarAeroportoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraAeroporto>();
        }

        private void cadastrarCompanhiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraCompanhia>();
        }

        private void cadastrarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraFuncionario>();
        }

        private void cadastrarAviãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraAviao>();
        }

        private void cadastrarVôoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraVoo>();
        }

        private void cadastrarHangarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraHangar>();
        }

        private void cadastrarEstacionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraAviaoEstacionado>();
        }

        private void cadastrarFuncõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraFuncaoFuncionario>();
        }

        private void cadastrarTipoVôoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraTipoVoo>();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
