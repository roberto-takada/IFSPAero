namespace IFSPAero.App.Forms
{
    partial class CadastraTipoVoo
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
            txtBoxTipoVoo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(txtBoxTipoVoo);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(896, 505);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxTipoVoo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(811, 453);
            btnConfirmar.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            tabPageConsulta.Size = new Size(896, 505);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(684, 453);
            btnCancelar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(581, 452);
            btnExcluir.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(695, 452);
            btnAlterar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(816, 452);
            btnNovo.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 113);
            tabControlCadastro.Margin = new Padding(3, 5, 3, 5);
            tabControlCadastro.Size = new Size(904, 538);
            // 
            // txtBoxTipoVoo
            // 
            txtBoxTipoVoo.AnimateReadOnly = false;
            txtBoxTipoVoo.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxTipoVoo.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxTipoVoo.BackgroundImageLayout = ImageLayout.None;
            txtBoxTipoVoo.CharacterCasing = CharacterCasing.Normal;
            txtBoxTipoVoo.Depth = 0;
            txtBoxTipoVoo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxTipoVoo.HideSelection = true;
            txtBoxTipoVoo.Hint = "Tipo de Vôo";
            txtBoxTipoVoo.LeadingIcon = null;
            txtBoxTipoVoo.Location = new Point(248, 204);
            txtBoxTipoVoo.Margin = new Padding(3, 4, 3, 4);
            txtBoxTipoVoo.MaxLength = 32767;
            txtBoxTipoVoo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxTipoVoo.Name = "txtBoxTipoVoo";
            txtBoxTipoVoo.PasswordChar = '\0';
            txtBoxTipoVoo.PrefixSuffixText = null;
            txtBoxTipoVoo.ReadOnly = false;
            txtBoxTipoVoo.RightToLeft = RightToLeft.No;
            txtBoxTipoVoo.SelectedText = "";
            txtBoxTipoVoo.SelectionLength = 0;
            txtBoxTipoVoo.SelectionStart = 0;
            txtBoxTipoVoo.ShortcutsEnabled = true;
            txtBoxTipoVoo.Size = new Size(402, 48);
            txtBoxTipoVoo.TabIndex = 3;
            txtBoxTipoVoo.TabStop = false;
            txtBoxTipoVoo.TextAlign = HorizontalAlignment.Left;
            txtBoxTipoVoo.TrailingIcon = null;
            txtBoxTipoVoo.UseSystemPasswordChar = false;
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
            txtBoxId.Location = new Point(248, 132);
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
            txtBoxId.Size = new Size(402, 48);
            txtBoxId.TabIndex = 6;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // CadastraTipoVoo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(910, 656);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastraTipoVoo";
            Padding = new Padding(3, 113, 3, 5);
            Text = "IFSPAero - Tipos de Vôo";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxTipoVoo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
    }
}