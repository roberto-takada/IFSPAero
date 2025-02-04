using System.Windows.Forms;
using IFSPAero.App.FormBase;
using IFSPAero.App.Models;
using IFSPAero.Domain.Base;
using IFSPAero.Domain.Entities;
using IFSPAero.Services.Validators;

namespace IFSPAero.App.Forms
{
    public partial class CadastraAviao : CadastroBase
    {
        private IBaseService<Aviao> _aviaoService;
        private IBaseService<Companhia> _companhiaService;
        private List<AviaoModel> avioes;
        public CadastraAviao(IBaseService<Aviao> aviaoService, IBaseService<Companhia> companhiaService)
        {
            _aviaoService = aviaoService;
            _companhiaService = companhiaService;
            InitializeComponent();
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            cboCompanhia.ValueMember = "Id";
            cboCompanhia.DisplayMember = "Nome";
            cboCompanhia.DataSource = _companhiaService.Get<CompanhiaModel>().ToList();
        }

        private void PreencheObjeto(Aviao aviao)
        {
            aviao.Modelo = txtBoxModelo.Text;
            aviao.Codigo = txtBoxCodigo.Text;
            aviao.Situacao = int.Parse(txtSituacao.Text);
            using (MemoryStream ms = new MemoryStream())
            {
                imgAviao.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imagemBytes = ms.ToArray();
                aviao.Imagem = imagemBytes;
            }
            if (int.TryParse(cboCompanhia.SelectedValue.ToString(), out var idGrupo))
            {
                var companhia = _companhiaService.GetById<Companhia>(idGrupo);
                aviao.Companhia = companhia;
            }

        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtBoxId.Text, out var id))
                    {
                        var aviao = _aviaoService.GetById<Aviao>(id);
                        PreencheObjeto(aviao);
                        _aviaoService.Update<Aviao, Aviao, AviaoValidator>(aviao);
                    }
                }
                else
                {
                    var aviao = new Aviao();
                    PreencheObjeto(aviao);
                    _aviaoService.Add<Aviao, Aviao, AviaoValidator>(aviao);
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
                _aviaoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            avioes = _aviaoService.Get<AviaoModel>().ToList();
            dataGridViewConsulta.DataSource = avioes;
            dataGridViewConsulta.Columns["Modelo"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Imagem"]!.Visible = false;
            dataGridViewConsulta.Columns["IdCompanhia"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtBoxId.Text = linha?.Cells["Id"].Value.ToString();
            txtBoxModelo.Text = linha?.Cells["Modelo"].Value.ToString();
            txtBoxCodigo.Text = linha?.Cells["Codigo"].Value.ToString();
            txtSituacao.Text = linha?.Cells["Situacao"].Value.ToString();
            cboCompanhia.SelectedValue = linha?.Cells["IdCompanhia"].Value;
            byte[] imagemString = (byte[])(linha?.Cells["Imagem"].Value);
            using (MemoryStream ms = new MemoryStream(imagemString))
            {
                Image image = Image.FromStream(ms);
                imgAviao.Image = image;
            }
        }

        private void btnEnviaImagem_Click(object sender, EventArgs e)
        {
            string imageLocation;
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    imageLocation = ofd.FileName;
                    imgAviao.ImageLocation = imageLocation;
                    
                }
            }
            catch
            {
                MessageBox.Show("Alguma coisa deu Errado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}