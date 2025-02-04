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

        private void aeroportoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarAeroportoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraAeroporto>();
        }

        private void consultarAeroportosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aviãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarCompanhiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraCompanhia>();
        }

        private void consultarCompanhiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastraFuncionario>();
        }

        private void consultarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void consultarFuncionáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void consultarFuncõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarAviãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarTipoVôoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarHangaresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarEstacionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
