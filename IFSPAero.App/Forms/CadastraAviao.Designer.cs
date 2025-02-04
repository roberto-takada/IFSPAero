namespace IFSPAero.App.Forms
{
    partial class CadastraAviao
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
            imgAviao = new PictureBox();
            btnEnviaImagem = new ReaLTaiizor.Controls.MaterialButton();
            txtBoxModelo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBoxCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCompanhia = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBoxId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSituacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgAviao).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtSituacao);
            tabPageCadastro.Controls.Add(txtBoxId);
            tabPageCadastro.Controls.Add(cboCompanhia);
            tabPageCadastro.Controls.Add(txtBoxCodigo);
            tabPageCadastro.Controls.Add(txtBoxModelo);
            tabPageCadastro.Controls.Add(btnEnviaImagem);
            tabPageCadastro.Controls.Add(imgAviao);
            tabPageCadastro.Margin = new Padding(3, 5, 3, 5);
            tabPageCadastro.Padding = new Padding(3, 5, 3, 5);
            tabPageCadastro.Size = new Size(904, 480);
            tabPageCadastro.Controls.SetChildIndex(btnConfirmar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(imgAviao, 0);
            tabPageCadastro.Controls.SetChildIndex(btnEnviaImagem, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxModelo, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxCodigo, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCompanhia, 0);
            tabPageCadastro.Controls.SetChildIndex(txtBoxId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSituacao, 0);
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(808, 432);
            btnConfirmar.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Margin = new Padding(3, 5, 3, 5);
            tabPageConsulta.Padding = new Padding(3, 5, 3, 5);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(673, 432);
            btnCancelar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(594, 428);
            btnExcluir.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(708, 428);
            btnAlterar.Margin = new Padding(6, 11, 6, 11);
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(829, 428);
            btnNovo.Margin = new Padding(6, 11, 6, 11);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Location = new Point(3, 113);
            tabControlCadastro.Margin = new Padding(3, 5, 3, 5);
            tabControlCadastro.Size = new Size(912, 513);
            // 
            // imgAviao
            // 
            imgAviao.Location = new Point(7, 8);
            imgAviao.Margin = new Padding(3, 4, 3, 4);
            imgAviao.Name = "imgAviao";
            imgAviao.Size = new Size(241, 273);
            imgAviao.SizeMode = PictureBoxSizeMode.StretchImage;
            imgAviao.TabIndex = 2;
            imgAviao.TabStop = false;
            // 
            // btnEnviaImagem
            // 
            btnEnviaImagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEnviaImagem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEnviaImagem.Depth = 0;
            btnEnviaImagem.HighEmphasis = true;
            btnEnviaImagem.Icon = null;
            btnEnviaImagem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEnviaImagem.Location = new Point(35, 293);
            btnEnviaImagem.Margin = new Padding(5, 8, 5, 8);
            btnEnviaImagem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEnviaImagem.Name = "btnEnviaImagem";
            btnEnviaImagem.NoAccentTextColor = Color.Empty;
            btnEnviaImagem.Size = new Size(135, 36);
            btnEnviaImagem.TabIndex = 3;
            btnEnviaImagem.Text = "Enviar Imagem";
            btnEnviaImagem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEnviaImagem.UseAccentColor = false;
            btnEnviaImagem.UseVisualStyleBackColor = true;
            btnEnviaImagem.Click += btnEnviaImagem_Click;
            // 
            // txtBoxModelo
            // 
            txtBoxModelo.AnimateReadOnly = false;
            txtBoxModelo.AutoCompleteMode = AutoCompleteMode.None;
            txtBoxModelo.AutoCompleteSource = AutoCompleteSource.None;
            txtBoxModelo.BackgroundImageLayout = ImageLayout.None;
            txtBoxModelo.CharacterCasing = CharacterCasing.Normal;
            txtBoxModelo.Depth = 0;
            txtBoxModelo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBoxModelo.HideSelection = true;
            txtBoxModelo.Hint = "Modelo do Avião";
            txtBoxModelo.LeadingIcon = null;
            txtBoxModelo.Location = new Point(267, 108);
            txtBoxModelo.Margin = new Padding(3, 4, 3, 4);
            txtBoxModelo.MaxLength = 32767;
            txtBoxModelo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBoxModelo.Name = "txtBoxModelo";
            txtBoxModelo.PasswordChar = '\0';
            txtBoxModelo.PrefixSuffixText = null;
            txtBoxModelo.ReadOnly = false;
            txtBoxModelo.RightToLeft = RightToLeft.No;
            txtBoxModelo.SelectedText = "";
            txtBoxModelo.SelectionLength = 0;
            txtBoxModelo.SelectionStart = 0;
            txtBoxModelo.ShortcutsEnabled = true;
            txtBoxModelo.Size = new Size(330, 48);
            txtBoxModelo.TabIndex = 4;
            txtBoxModelo.TabStop = false;
            txtBoxModelo.TextAlign = HorizontalAlignment.Left;
            txtBoxModelo.TrailingIcon = null;
            txtBoxModelo.UseSystemPasswordChar = false;
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
            txtBoxCodigo.Hint = "Código do Avião";
            txtBoxCodigo.LeadingIcon = null;
            txtBoxCodigo.Location = new Point(267, 24);
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
            txtBoxCodigo.Size = new Size(330, 48);
            txtBoxCodigo.TabIndex = 5;
            txtBoxCodigo.TabStop = false;
            txtBoxCodigo.TextAlign = HorizontalAlignment.Left;
            txtBoxCodigo.TrailingIcon = null;
            txtBoxCodigo.UseSystemPasswordChar = false;
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
            cboCompanhia.Location = new Point(605, 108);
            cboCompanhia.Margin = new Padding(3, 4, 3, 4);
            cboCompanhia.MaxDropDownItems = 4;
            cboCompanhia.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCompanhia.Name = "cboCompanhia";
            cboCompanhia.Size = new Size(285, 49);
            cboCompanhia.StartIndex = 0;
            cboCompanhia.TabIndex = 6;
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
            txtBoxId.Location = new Point(605, 24);
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
            txtBoxId.Size = new Size(286, 48);
            txtBoxId.TabIndex = 7;
            txtBoxId.TabStop = false;
            txtBoxId.TextAlign = HorizontalAlignment.Left;
            txtBoxId.TrailingIcon = null;
            txtBoxId.UseSystemPasswordChar = false;
            // 
            // txtSituacao
            // 
            txtSituacao.AnimateReadOnly = false;
            txtSituacao.AutoCompleteMode = AutoCompleteMode.None;
            txtSituacao.AutoCompleteSource = AutoCompleteSource.None;
            txtSituacao.BackgroundImageLayout = ImageLayout.None;
            txtSituacao.CharacterCasing = CharacterCasing.Normal;
            txtSituacao.Depth = 0;
            txtSituacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSituacao.HideSelection = true;
            txtSituacao.Hint = "Situação";
            txtSituacao.LeadingIcon = null;
            txtSituacao.Location = new Point(734, 181);
            txtSituacao.Margin = new Padding(3, 4, 3, 4);
            txtSituacao.MaxLength = 32767;
            txtSituacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSituacao.Name = "txtSituacao";
            txtSituacao.PasswordChar = '\0';
            txtSituacao.PrefixSuffixText = null;
            txtSituacao.ReadOnly = false;
            txtSituacao.RightToLeft = RightToLeft.No;
            txtSituacao.SelectedText = "";
            txtSituacao.SelectionLength = 0;
            txtSituacao.SelectionStart = 0;
            txtSituacao.ShortcutsEnabled = true;
            txtSituacao.Size = new Size(157, 48);
            txtSituacao.TabIndex = 8;
            txtSituacao.TabStop = false;
            txtSituacao.TextAlign = HorizontalAlignment.Left;
            txtSituacao.TrailingIcon = null;
            txtSituacao.UseSystemPasswordChar = false;
            // 
            // CadastraAviao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 631);
            Location = new Point(0, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CadastraAviao";
            Padding = new Padding(3, 113, 3, 5);
            Text = "IFSPAero - Avião";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgAviao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialButton btnEnviaImagem;
        private PictureBox imgAviao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxCodigo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxModelo;
        private ReaLTaiizor.Controls.MaterialComboBox cboCompanhia;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBoxId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSituacao;
    }
}