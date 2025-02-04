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
    public partial class CadastraHangar : CadastroBase
    {
        private IBaseService<Hangar> _hangarService;
        private IBaseService<Aeroporto> _aeroportoService;
        private List<HangarModel>? _hangares;
        public CadastraHangar(IBaseService<Hangar> hangarService, IBaseService<Aeroporto> aeroportoService)
        {
            _hangarService = hangarService;
            _aeroportoService = aeroportoService;
            InitializeComponent();
            CarregaCombo();
        }

        private void CarregaCombo()
        {
            cboAeroporto.ValueMember = "Id";
            cboAeroporto.DisplayMember = "Nome";
            cboAeroporto.DataSource = _aeroportoService.Get<AeroportoModel>().ToList();
        }

        private void PreencheObjeto(Hangar hangar)
        {
            hangar.Codigo = txtBoxCodigo.Text;
            if (int.TryParse(cboAeroporto.SelectedValue.ToString(), out var idGrupo))
            {
                var aeroporto = _aeroportoService.GetById<Aeroporto>(idGrupo);
                hangar.Aeroporto = aeroporto;
            }
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if(int.TryParse(txtBoxId.Text, out var id))
                    {
                        var hangar = _hangarService.GetById<Hangar>(id);
                        PreencheObjeto(hangar);
                        _hangarService.Update<Hangar, Hangar, HangarValidator>(hangar);
                    }
                }
                else
                {
                    var hangar = new Hangar();
                    PreencheObjeto(hangar);
                    _hangarService.Add<Hangar, Hangar, HangarValidator>(hangar);
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
                _hangarService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSPAERO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _hangares = _hangarService.Get<HangarModel>(false, new[] {"Aeroporto"}).ToList();
            dataGridViewConsulta.DataSource = _hangares;
            dataGridViewConsulta.Columns["Codigo"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["IdAeroporto"]!.Visible = false;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtBoxCodigo.Text = linha?.Cells["Codigo"].Value.ToString();
            txtBoxId.Text = linha?.Cells["Id"].Value.ToString();
            cboAeroporto.SelectedValue = linha?.Cells["IdAeroporto"].Value;
        }
    }
}
