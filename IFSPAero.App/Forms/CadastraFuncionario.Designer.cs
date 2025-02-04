namespace IFSPAero.App.Forms
{
    partial class CadastraFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxDocumento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboFuncao = new ReaLTaiizor.Controls.MaterialComboBox();
            cboCompanhia = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboCompanhia);
            tabPageCadastro.Controls.Add(cboFuncao);
            tabPageCadastro.Controls.Add(txtBoxDocumento);
            tabPageCadastro.Controls.Add(txtBoxNome);
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(899, 478);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxDocumento, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFuncao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCompanhia, 0);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(805, 385);
            btnConfirmar.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            tabPageConsulta.Size = new Size(899, 478);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(684, 385);
            btnCancelar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(584, 425);
            btnExcluir.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(694, 425);
            btnAlterar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(815, 425);
            btnNovo.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 113);
            tabControlCadastro.Margin = new Padding(3, 5, 3, 5);
            tabControlCadastro.Size = new Size(907, 511);
            // 
            // txtBoxId
            // 
            txtBoxId.AnimateReadOnly = false;
            txtBoxId.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxId.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxId.BackgroundImageLayout = ImageLayout.None;
            txtBoxId.CharacterCasing = CharacterCasing.Normal;
            txtBoxId.Depth = 0;
            txtBoxId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxId.HideSelection = true;
            txtBoxId.Hint = "ID";
            txtBoxId.LeadingIcon = null;
            txtBoxId.Location = new Point(7, 8);
            txtBoxId.Margin = new Padding(3, 4, 3, 4);
            txtBoxId.MaxLength = 32767;
            txtBoxId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxId.Name = "txtBoxId";
            txtBoxId.PasswordChar = '\0';
            txtBoxId.PrefixSuffixText = null;
            txtBoxId.ReadOnly = false;
            txtBoxId.RightToLeft = RightToLeft.No;
            txtBoxId.SelectedText = "";
            txtBoxId.SelectionLength = 0;
            txtBoxId.SelectionStart = 0;
            txtBoxId.ShortcutsEnabled = true;
            txtBoxId.Size = new Size(253, 48);
            txtBoxId.TabIndex = 6;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // txtBoxNome
            // 
            txtBoxNome.AnimateReadOnly = false;
            txtBoxNome.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxNome.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxNome.BackgroundImageLayout = ImageLayout.None;
            txtBoxNome.CharacterCasing = CharacterCasing.Normal;
            txtBoxNome.Depth = 0;
            txtBoxNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxNome.HideSelection = true;
            txtBoxNome.Hint = "Nome";
            txtBoxNome.LeadingIcon = null;
            txtBoxNome.Location = new Point(266, 8);
            txtBoxNome.Margin = new Padding(3, 4, 3, 4);
            txtBoxNome.MaxLength = 32767;
            txtBoxNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.PasswordChar = '\0';
            txtBoxNome.PrefixSuffixText = null;
            txtBoxNome.ReadOnly = false;
            txtBoxNome.RightToLeft = RightToLeft.No;
            txtBoxNome.SelectedText = "";
            txtBoxNome.SelectionLength = 0;
            txtBoxNome.SelectionStart = 0;
            txtBoxNome.ShortcutsEnabled = true;
            txtBoxNome.Size = new Size(624, 48);
            txtBoxNome.TabIndex = 7;
            txtBoxNome.TabStop = false;
            txtBoxNome.TextAlign = HorizontalAlignment.Left;
            txtBoxNome.TrailingIcon = null;
            txtBoxNome.UseSystemPasswordChar = false;
            // 
            // txtBoxDocumento
            // 
            txtBoxDocumento.AnimateReadOnly = false;
            txtBoxDocumento.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxDocumento.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxDocumento.BackgroundImageLayout = ImageLayout.None;
            txtBoxDocumento.CharacterCasing = CharacterCasing.Normal;
            txtBoxDocumento.Depth = 0;
            txtBoxDocumento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxDocumento.HideSelection = true;
            txtBoxDocumento.Hint = "Documento";
            txtBoxDocumento.LeadingIcon = null;
            txtBoxDocumento.Location = new Point(521, 95);
            txtBoxDocumento.Margin = new Padding(3, 4, 3, 4);
            txtBoxDocumento.MaxLength = 32767;
            txtBoxDocumento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxDocumento.Name = "txtBoxDocumento";
            txtBoxDocumento.PasswordChar = '\0';
            txtBoxDocumento.PrefixSuffixText = null;
            txtBoxDocumento.ReadOnly = false;
            txtBoxDocumento.RightToLeft = RightToLeft.No;
            txtBoxDocumento.SelectedText = "";
            txtBoxDocumento.SelectionLength = 0;
            txtBoxDocumento.SelectionStart = 0;
            txtBoxDocumento.ShortcutsEnabled = true;
            txtBoxDocumento.Size = new Size(369, 48);
            txtBoxDocumento.TabIndex = 8;
            txtBoxDocumento.TabStop = false;
            txtBoxDocumento.TextAlign = HorizontalAlignment.Left;
            txtBoxDocumento.TrailingIcon = null;
            txtBoxDocumento.UseSystemPasswordChar = false;
            // 
            // cboFuncao
            // 
            cboFuncao.AutoResize = false;
            cboFuncao.BackColor = Color.FromArgb(255, 255, 255);
            cboFuncao.Depth = 0;
            cboFuncao.DrawMode = DrawMode.OwnerDrawVariable;
            cboFuncao.DropDownHeight = 174;
            cboFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuncao.DropDownWidth = 121;
            cboFuncao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFuncao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFuncao.FormattingEnabled = true;
            cboFuncao.Hint = "Função";
            cboFuncao.IntegralHeight = false;
            cboFuncao.ItemHeight = 43;
            cboFuncao.Location = new Point(266, 96);
            cboFuncao.Margin = new Padding(3, 4, 3, 4);
            cboFuncao.MaxDropDownItems = 4;
            cboFuncao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFuncao.Name = "cboFuncao";
            cboFuncao.Size = new Size(247, 49);
            cboFuncao.StartIndex = 0;
            cboFuncao.TabIndex = 10;
            // 
            // cboCompanhia
            // 
            cboCompanhia.AutoResize = false;
            cboCompanhia.BackColor = Color.FromArgb(255, 255, 255);
            cboCompanhia.Depth = 0;
            cboCompanhia.DrawMode = DrawMode.OwnerDrawVariable;
            cboCompanhia.DropDownHeight = 174;
            cboCompanhia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCompanhia.DropDownWidth = 121;
            cboCompanhia.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCompanhia.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCompanhia.FormattingEnabled = true;
            cboCompanhia.Hint = "Companhia";
            cboCompanhia.IntegralHeight = false;
            cboCompanhia.ItemHeight = 43;
            cboCompanhia.Location = new Point(7, 95);
            cboCompanhia.Margin = new Padding(3, 4, 3, 4);
            cboCompanhia.MaxDropDownItems = 4;
            cboCompanhia.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCompanhia.Name = "cboCompanhia";
            cboCompanhia.Size = new Size(252, 49);
            cboCompanhia.StartIndex = 0;
            cboCompanhia.TabIndex = 11;
            // 
            // CadastraFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 629);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastraFuncionario";
            Padding = new Padding(3, 113, 3, 5);
            Text = "IFSPAero - Funcionário";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxDocumento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboCompanhia;
        private ReaLTaiizor.Controls.MaterialComboBox cboFuncao;
    }
}