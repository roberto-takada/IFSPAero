using System.Configuration;
using IFSPAero.App.FormBase;
using IFSPAero.Domain.Base;
using IFSPAero.Domain.Entities;
using IFSPAero.Services.Validators;

namespace IFSPAero.App.Forms
{
    public partial class CadastraAeroporto : CadastroBase
    {
        private IBaseService<Aeroporto> _aeroportoService;
        private List<Aeroporto> aeroportos;
        public CadastraAeroporto(IBaseService<Aeroporto> aeroportoService)
        {
            _aeroportoService = aeroportoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Aeroporto aeroporto)
        {
            aeroporto.Nome = txtBoxNome.Text;
            aeroporto.Codigo = txtBoxCodigo.Text;
            aeroporto.Cidade = txtBoxCidade.Text;
            aeroporto.Pais = txtBoxPais.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if(int.TryParse(txtBoxId.Text, out var id))
                    {
                        var aeroporto = _aeroportoService.GetById<Aeroporto>(id);
                        PreencheObjeto(aeroporto);
                        _aeroportoService.Update<Aeroporto, Aeroporto, AeroportoValidator>(aeroporto);
                    }
                }
                else
                {
                    var aeroporto = new Aeroporto();
                    PreencheObjeto(aeroporto);
                    _aeroportoService.Add<Aeroporto, Aeroporto, AeroportoValidator>(aeroporto);
                }
                tabControlCadastro.SelectedIndex = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override void Deletar(int id)
        {
            try
            {
                _aeroportoService.Delete(id);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            aeroportos = _aeroportoService.Get<Aeroporto>().ToList();
            dataGridViewConsulta.DataSource = aeroportos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtBoxId.Text = linha?.Cells["Id"].Value.ToString();
            txtBoxNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtBoxCodigo.Text = linha?.Cells["Codigo"].Value.ToString();
            txtBoxCidade.Text = linha?.Cells["Cidade"].Value.ToString();
            txtBoxPais.Text = linha?.Cells["Pais"].Value.ToString();
        }

    }
}
