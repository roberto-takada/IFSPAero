using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IFSPAero.App.FormBase;
using IFSPAero.App.Models;
using IFSPAero.Domain.Base;
using IFSPAero.Domain.Entities;
using IFSPAero.Services.Validators;

namespace IFSPAero.App.Forms
{
    public partial class CadastraVoo : CadastroBase
    {
        private IBaseService<Voo> _vooService;
        private IBaseService<TipoVoo> _tipoVooService;
        private IBaseService<Aeroporto> _aeroportoService;
        private IBaseService<Aviao> _aviaoService;
        private IBaseService<Funcionario> _funcionarioService;
        private List<VooModel>? voos;
        public CadastraVoo(IBaseService<Voo> vooService, IBaseService<TipoVoo> tipoVooService, IBaseService<Aeroporto> aeroportoService, IBaseService<Aviao> aviaoService, IBaseService<Funcionario> funcionarioService)
        {
            _vooService = vooService;
            _tipoVooService = tipoVooService;
            _aviaoService = aviaoService;
            _aeroportoService = aeroportoService;
            _funcionarioService = funcionarioService;
            InitializeComponent();
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            cboAviao.ValueMember = "Id";
            cboAviao.DisplayMember = "Codigo";
            cboAviao.DataSource = _aviaoService.Get<AviaoModel>().ToList();

            cboCapitao.ValueMember = "Id";
            cboCapitao.DisplayMember = "Nome";
            cboCapitao.DataSource = _funcionarioService.Get<FuncionarioModel>().ToList();

            cboVoo.ValueMember = "Id";
            cboVoo.DisplayMember = "Tipo";
            cboVoo.DataSource = _tipoVooService.Get<TipoVooModel>().ToList();

            cboAeroportoChegada.ValueMember = "Id";
            cboAeroportoChegada.DisplayMember = "Nome";
            cboAeroportoChegada.DataSource = _aeroportoService.Get<AeroportoModel>().ToList();

            cboAeroportoSaida.ValueMember = "Id";
            cboAeroportoSaida.DisplayMember = "Nome";
            cboAeroportoSaida.DataSource = _aeroportoService.Get<AeroportoModel>().ToList();

        }

        private void PreencheObjeto(Voo voo)
        {
            voo.DataChegada = dateTimeChegada.Value;
            voo.DataSaida = dateTimeSaida.Value;
            if (int.TryParse(cboAviao.SelectedValue.ToString(), out var idAviao))
            {
                var aviao = _aviaoService.GetById<Aviao>(idAviao);
                voo.Aviao = aviao;
            }
            if (int.TryParse(cboCapitao.SelectedValue.ToString(), out var idFuncionario))
            {
                var capitao = _funcionarioService.GetById<Funcionario>(idFuncionario);
                voo.Capitao = capitao;
            }
            if (int.TryParse(cboVoo.SelectedValue.ToString(), out var idTipoVoo))
            {
                var tipoVoo = _tipoVooService.GetById<TipoVoo>(idTipoVoo);
                voo.TipoVoo = tipoVoo;
            }
            if (int.TryParse(cboAeroportoChegada.SelectedValue.ToString(), out var idAeroportoChegada))
            {
                var aeroportoChegada = _aeroportoService.GetById<Aeroporto>(idAeroportoChegada);
                voo.AeroportoChegada = aeroportoChegada;
            }
            if (int.TryParse(cboAeroportoSaida.SelectedValue.ToString(), out var idAeroportoSaida))
            {
                var aeroportoSaida = _aeroportoService.GetById<Aeroporto>(idAeroportoSaida);
                voo.AeroportoSaida = aeroportoSaida;
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
                        var voo = _vooService.GetById<Voo>(id);
                        PreencheObjeto(voo);
                        _vooService.Update<Voo, Voo, VooValidator>(voo);
                    }
                }
                else
                {
                    var voo = new Voo();
                    PreencheObjeto(voo);
                    _vooService.Add<Voo, Voo, VooValidator>(voo);
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
                _vooService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            voos = _vooService.Get<VooModel>().ToList();
            dataGridViewConsulta.DataSource = voos;
            dataGridViewConsulta.Columns["IdAviao"]!.Visible = false;
            dataGridViewConsulta.Columns["IdAeroportoSaida"]!.Visible = false;
            dataGridViewConsulta.Columns["IdAeroportoChegada"]!.Visible = false;
            dataGridViewConsulta.Columns["IdTipoVoo"]!.Visible = false;
            dataGridViewConsulta.Columns["idCapitao"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            dateTimeChegada.Value = (DateTime)(linha?.Cells["DataSaida"].Value);
            dateTimeSaida.Value = (DateTime)(linha?.Cells["DataChegada"].Value);
            cboAviao.SelectedValue = linha?.Cells["IdAviao"].Value;
            cboCapitao.SelectedValue = linha?.Cells["IdCapitao"].Value;
            cboVoo.SelectedValue = linha?.Cells["IdTipoVoo"].Value;
            cboAeroportoChegada.SelectedValue = linha?.Cells["IdAeroportoChegada"].Value;
            cboAeroportoSaida.SelectedValue = linha?.Cells["IdAeroportoSaida"].Value;
        }
    }
}
