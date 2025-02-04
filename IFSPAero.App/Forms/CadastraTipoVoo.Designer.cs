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
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxTipoVoo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
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
            txtBoxTipoVoo.Location = new Point(217, 153);
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
            txtBoxTipoVoo.Size = new Size(352, 48);
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
            txtBoxId.Location = new Point(217, 99);
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
            txtBoxId.Size = new Size(352, 48);
            txtBoxId.TabIndex = 6;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // CadastraTipoVoo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastraTipoVoo";
            Text = "CadastraTipoVoo";
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