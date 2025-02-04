using IFSPAero.App.FormBase;
using IFSPAero.Domain.Base;
using IFSPAero.Domain.Entities;
using IFSPAero.Services.Validators;

namespace IFSPAero.App.Forms
{
    public partial class CadastraTipoVoo : CadastroBase
    {
        private IBaseService<TipoVoo> _tipoVooService;
        private List<TipoVoo> tipoVoos;
        public CadastraTipoVoo(IBaseService<TipoVoo> tipoVoo)
        {
            _tipoVooService = tipoVoo;
            InitializeComponent();
        }

        private void PreencheObjeto(TipoVoo tipoVoo)
        {
            tipoVoo.Tipo = txtBoxTipoVoo.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtBoxId.Text, out var id))
                    {
                        var tipoVoo = _tipoVooService.GetById<TipoVoo>(id);
                        PreencheObjeto(tipoVoo);
                        _tipoVooService.Update<TipoVoo, TipoVoo, TipoVooValidator>(tipoVoo);
                    }
                }
                else
                {
                    var tipoVoo = new TipoVoo();
                    PreencheObjeto(tipoVoo);
                    _tipoVooService.Add<TipoVoo, TipoVoo, TipoVooValidator>(tipoVoo);
                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void Deletar(int id)
        {
            try
            {
                _tipoVooService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            tipoVoos = _tipoVooService.Get<TipoVoo>().ToList();
            dataGridViewConsulta.DataSource = tipoVoos;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtBoxId.Text = linha?.Cells["Id"].Value.ToString();
            txtBoxTipoVoo.Text = linha?.Cells["Tipo"].Value.ToString();
        }
    }
}
