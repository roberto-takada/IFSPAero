namespace IFSPAero.App.Forms
{
    partial class CadastraAeroporto
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
            txtBoxNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxPais = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(txtBoxPais);
            tabPageCadastro.Controls.Add(txtBoxCidade);
            tabPageCadastro.Controls.Add(txtBoxCodigo);
            tabPageCadastro.Controls.Add(txtBoxNome);
            tabPageCadastro.Controls.SetChildIndex(txtBoxNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxCodigo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxCidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxPais, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
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
            txtBoxNome.Hint = "Nome do Aeroporto";
            txtBoxNome.LeadingIcon = null;
            txtBoxNome.Location = new Point(32, 18);
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
            txtBoxNome.Size = new Size(509, 48);
            txtBoxNome.TabIndex = 1;
            txtBoxNome.TabStop = false;
            txtBoxNome.TextAlign = HorizontalAlignment.Left;
            txtBoxNome.TrailingIcon = null;
            txtBoxNome.UseSystemPasswordChar = false;
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.AnimateReadOnly = false;
            txtBoxCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxCodigo.BackgroundImageLayout = ImageLayout.None;
            txtBoxCodigo.CharacterCasing = CharacterCasing.Normal;
            txtBoxCodigo.Depth = 0;
            txtBoxCodigo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxCodigo.HideSelection = true;
            txtBoxCodigo.Hint = "Código do Aeroporto";
            txtBoxCodigo.LeadingIcon = null;
            txtBoxCodigo.Location = new Point(32, 85);
            txtBoxCodigo.MaxLength = 32767;
            txtBoxCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.PasswordChar = '\0';
            txtBoxCodigo.PrefixSuffixText = null;
            txtBoxCodigo.ReadOnly = false;
            txtBoxCodigo.RightToLeft = RightToLeft.No;
            txtBoxCodigo.SelectedText = "";
            txtBoxCodigo.SelectionLength = 0;
            txtBoxCodigo.SelectionStart = 0;
            txtBoxCodigo.ShortcutsEnabled = true;
            txtBoxCodigo.Size = new Size(234, 48);
            txtBoxCodigo.TabIndex = 2;
            txtBoxCodigo.TabStop = false;
            txtBoxCodigo.TextAlign = HorizontalAlignment.Left;
            txtBoxCodigo.TrailingIcon = null;
            txtBoxCodigo.UseSystemPasswordChar = false;
            // 
            // txtBoxCidade
            // 
            txtBoxCidade.AnimateReadOnly = false;
            txtBoxCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxCidade.BackgroundImageLayout = ImageLayout.None;
            txtBoxCidade.CharacterCasing = CharacterCasing.Normal;
            txtBoxCidade.Depth = 0;
            txtBoxCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxCidade.HideSelection = true;
            txtBoxCidade.Hint = "Cidade";
            txtBoxCidade.LeadingIcon = null;
            txtBoxCidade.Location = new Point(292, 85);
            txtBoxCidade.MaxLength = 32767;
            txtBoxCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxCidade.Name = "txtBoxCidade";
            txtBoxCidade.PasswordChar = '\0';
            txtBoxCidade.PrefixSuffixText = null;
            txtBoxCidade.ReadOnly = false;
            txtBoxCidade.RightToLeft = RightToLeft.No;
            txtBoxCidade.SelectedText = "";
            txtBoxCidade.SelectionLength = 0;
            txtBoxCidade.SelectionStart = 0;
            txtBoxCidade.ShortcutsEnabled = true;
            txtBoxCidade.Size = new Size(249, 48);
            txtBoxCidade.TabIndex = 3;
            txtBoxCidade.TabStop = false;
            txtBoxCidade.TextAlign = HorizontalAlignment.Left;
            txtBoxCidade.TrailingIcon = null;
            txtBoxCidade.UseSystemPasswordChar = false;
            // 
            // txtBoxPais
            // 
            txtBoxPais.AnimateReadOnly = false;
            txtBoxPais.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxPais.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxPais.BackgroundImageLayout = ImageLayout.None;
            txtBoxPais.CharacterCasing = CharacterCasing.Normal;
            txtBoxPais.Depth = 0;
            txtBoxPais.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxPais.HideSelection = true;
            txtBoxPais.Hint = "Pais";
            txtBoxPais.LeadingIcon = null;
            txtBoxPais.Location = new Point(558, 85);
            txtBoxPais.MaxLength = 32767;
            txtBoxPais.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxPais.Name = "txtBoxPais";
            txtBoxPais.PasswordChar = '\0';
            txtBoxPais.PrefixSuffixText = null;
            txtBoxPais.ReadOnly = false;
            txtBoxPais.RightToLeft = RightToLeft.No;
            txtBoxPais.SelectedText = "";
            txtBoxPais.SelectionLength = 0;
            txtBoxPais.SelectionStart = 0;
            txtBoxPais.ShortcutsEnabled = true;
            txtBoxPais.Size = new Size(221, 48);
            txtBoxPais.TabIndex = 4;
            txtBoxPais.TabStop = false;
            txtBoxPais.TextAlign = HorizontalAlignment.Left;
            txtBoxPais.TrailingIcon = null;
            txtBoxPais.UseSystemPasswordChar = false;
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
            txtBoxId.Location = new Point(558, 18);
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
            txtBoxId.Size = new Size(221, 48);
            txtBoxId.TabIndex = 5;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // CadastraAeroporto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastraAeroporto";
            Text = "IFSPAero - Aeroportos";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxPais;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
    }
}