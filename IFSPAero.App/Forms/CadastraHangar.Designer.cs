namespace IFSPAero.App.Forms
{
    partial class CadastraHangar
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
            txtBoxCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboAeroporto = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(cboAeroporto);
            tabPageCadastro.Controls.Add(txtBoxCodigo);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(890, 469);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxCodigo, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAeroporto, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(789, 419);
            btnConfirmar.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            tabPageConsulta.Size = new Size(890, 487);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(654, 419);
            btnCancelar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(581, 440);
            btnExcluir.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(695, 440);
            btnAlterar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(816, 440);
            btnNovo.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 113);
            tabControlCadastro.Margin = new Padding(3, 5, 3, 5);
            tabControlCadastro.Size = new Size(898, 520);
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
            txtBoxCodigo.Hint = "Código";
            txtBoxCodigo.LeadingIcon = null;
            txtBoxCodigo.Location = new Point(357, 96);
            txtBoxCodigo.Margin = new Padding(3, 4, 3, 4);
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
            txtBoxCodigo.Size = new Size(518, 48);
            txtBoxCodigo.TabIndex = 2;
            txtBoxCodigo.TabStop = false;
            txtBoxCodigo.TextAlign = HorizontalAlignment.Left;
            txtBoxCodigo.TrailingIcon = null;
            txtBoxCodigo.UseSystemPasswordChar = false;
            // 
            // cboAeroporto
            // 
            cboAeroporto.AutoResize = false;
            cboAeroporto.BackColor = Color.FromArgb(255, 255, 255);
            cboAeroporto.Depth = 0;
            cboAeroporto.DrawMode = DrawMode.OwnerDrawVariable;
            cboAeroporto.DropDownHeight = 174;
            cboAeroporto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAeroporto.DropDownWidth = 121;
            cboAeroporto.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAeroporto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAeroporto.FormattingEnabled = true;
            cboAeroporto.IntegralHeight = false;
            cboAeroporto.ItemHeight = 43;
            cboAeroporto.Location = new Point(357, 23);
            cboAeroporto.Margin = new Padding(3, 4, 3, 4);
            cboAeroporto.MaxDropDownItems = 4;
            cboAeroporto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAeroporto.Name = "cboAeroporto";
            cboAeroporto.Size = new Size(517, 49);
            cboAeroporto.StartIndex = 0;
            cboAeroporto.TabIndex = 3;
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
            txtBoxId.Location = new Point(25, 24);
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
            txtBoxId.Size = new Size(325, 48);
            txtBoxId.TabIndex = 4;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // CadastraHangar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 638);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastraHangar";
            Padding = new Padding(3, 113, 3, 5);
            Text = "IFSPAero - Hangar";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboAeroporto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
    }
}