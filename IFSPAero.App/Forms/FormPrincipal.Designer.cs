namespace IFSPAero.App
{
    partial class FormPrincipal
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
            ReaLTaiizor.ControlRenderer controlRenderer1 = new ReaLTaiizor.ControlRenderer();
            ReaLTaiizor.MSColorTable msColorTable1 = new ReaLTaiizor.MSColorTable();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            formMenuStrip1 = new ReaLTaiizor.Controls.FormMenuStrip();
            aeroportoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarAeroportoToolStripMenuItem = new ToolStripMenuItem();
            consultarAeroportosToolStripMenuItem = new ToolStripMenuItem();
            aviãoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCompanhiasToolStripMenuItem = new ToolStripMenuItem();
            consultarCompanhiasToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            consultarFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncõesToolStripMenuItem = new ToolStripMenuItem();
            consultarFuncõesToolStripMenuItem = new ToolStripMenuItem();
            aviãoToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarAviãoToolStripMenuItem = new ToolStripMenuItem();
            consultarAviãoToolStripMenuItem = new ToolStripMenuItem();
            vôoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarVôoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarTipoVôoToolStripMenuItem = new ToolStripMenuItem();
            consultarTipoVôoToolStripMenuItem = new ToolStripMenuItem();
            hangarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarHangarToolStripMenuItem = new ToolStripMenuItem();
            consultarHangaresToolStripMenuItem = new ToolStripMenuItem();
            cadastrarEstacionamentoToolStripMenuItem = new ToolStripMenuItem();
            consultarEstacionamentoToolStripMenuItem = new ToolStripMenuItem();
            formMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formMenuStrip1
            // 
            formMenuStrip1.ImageScalingSize = new Size(20, 20);
            formMenuStrip1.Items.AddRange(new ToolStripItem[] { aeroportoToolStripMenuItem, aviãoToolStripMenuItem, funcionárioToolStripMenuItem, aviãoToolStripMenuItem1, vôoToolStripMenuItem, hangarToolStripMenuItem });
            formMenuStrip1.Location = new Point(3, 48);
            formMenuStrip1.Name = "formMenuStrip1";
            formMenuStrip1.Padding = new Padding(5, 2, 0, 2);
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            formMenuStrip1.Renderer = controlRenderer1;
            formMenuStrip1.Size = new Size(1055, 24);
            formMenuStrip1.TabIndex = 0;
            formMenuStrip1.Text = "formMenuStrip1";
            // 
            // aeroportoToolStripMenuItem
            // 
            aeroportoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarAeroportoToolStripMenuItem, consultarAeroportosToolStripMenuItem });
            aeroportoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            aeroportoToolStripMenuItem.Name = "aeroportoToolStripMenuItem";
            aeroportoToolStripMenuItem.Size = new Size(73, 20);
            aeroportoToolStripMenuItem.Text = "Aeroporto";
            aeroportoToolStripMenuItem.Click += aeroportoToolStripMenuItem_Click;
            // 
            // cadastrarAeroportoToolStripMenuItem
            // 
            cadastrarAeroportoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarAeroportoToolStripMenuItem.Name = "cadastrarAeroportoToolStripMenuItem";
            cadastrarAeroportoToolStripMenuItem.Size = new Size(187, 22);
            cadastrarAeroportoToolStripMenuItem.Text = "Cadastrar Aeroporto";
            cadastrarAeroportoToolStripMenuItem.Click += cadastrarAeroportoToolStripMenuItem_Click;
            // 
            // consultarAeroportosToolStripMenuItem
            // 
            consultarAeroportosToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarAeroportosToolStripMenuItem.Name = "consultarAeroportosToolStripMenuItem";
            consultarAeroportosToolStripMenuItem.Size = new Size(187, 22);
            consultarAeroportosToolStripMenuItem.Text = "Consultar Aeroportos";
            consultarAeroportosToolStripMenuItem.Click += consultarAeroportosToolStripMenuItem_Click;
            // 
            // aviãoToolStripMenuItem
            // 
            aviãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarCompanhiasToolStripMenuItem, consultarCompanhiasToolStripMenuItem });
            aviãoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            aviãoToolStripMenuItem.Name = "aviãoToolStripMenuItem";
            aviãoToolStripMenuItem.Size = new Size(81, 20);
            aviãoToolStripMenuItem.Text = "Companhia";
            aviãoToolStripMenuItem.Click += aviãoToolStripMenuItem_Click;
            // 
            // cadastrarCompanhiasToolStripMenuItem
            // 
            cadastrarCompanhiasToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarCompanhiasToolStripMenuItem.Name = "cadastrarCompanhiasToolStripMenuItem";
            cadastrarCompanhiasToolStripMenuItem.Size = new Size(195, 22);
            cadastrarCompanhiasToolStripMenuItem.Text = "Cadastrar Companhias";
            cadastrarCompanhiasToolStripMenuItem.Click += cadastrarCompanhiasToolStripMenuItem_Click;
            // 
            // consultarCompanhiasToolStripMenuItem
            // 
            consultarCompanhiasToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarCompanhiasToolStripMenuItem.Name = "consultarCompanhiasToolStripMenuItem";
            consultarCompanhiasToolStripMenuItem.Size = new Size(195, 22);
            consultarCompanhiasToolStripMenuItem.Text = "Consultar Companhias";
            consultarCompanhiasToolStripMenuItem.Click += consultarCompanhiasToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFuncionáriosToolStripMenuItem, consultarFuncionáriosToolStripMenuItem, cadastrarFuncõesToolStripMenuItem, consultarFuncõesToolStripMenuItem });
            funcionárioToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(82, 20);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // cadastrarFuncionáriosToolStripMenuItem
            // 
            cadastrarFuncionáriosToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarFuncionáriosToolStripMenuItem.Name = "cadastrarFuncionáriosToolStripMenuItem";
            cadastrarFuncionáriosToolStripMenuItem.Size = new Size(196, 22);
            cadastrarFuncionáriosToolStripMenuItem.Text = "Cadastrar Funcionários";
            cadastrarFuncionáriosToolStripMenuItem.Click += cadastrarFuncionáriosToolStripMenuItem_Click;
            // 
            // consultarFuncionáriosToolStripMenuItem
            // 
            consultarFuncionáriosToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarFuncionáriosToolStripMenuItem.Name = "consultarFuncionáriosToolStripMenuItem";
            consultarFuncionáriosToolStripMenuItem.Size = new Size(196, 22);
            consultarFuncionáriosToolStripMenuItem.Text = "Consultar Funcionários";
            consultarFuncionáriosToolStripMenuItem.Click += consultarFuncionáriosToolStripMenuItem_Click_1;
            // 
            // cadastrarFuncõesToolStripMenuItem
            // 
            cadastrarFuncõesToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarFuncõesToolStripMenuItem.Name = "cadastrarFuncõesToolStripMenuItem";
            cadastrarFuncõesToolStripMenuItem.Size = new Size(196, 22);
            cadastrarFuncõesToolStripMenuItem.Text = "Cadastrar Funcões";
            cadastrarFuncõesToolStripMenuItem.Click += cadastrarFuncõesToolStripMenuItem_Click;
            // 
            // consultarFuncõesToolStripMenuItem
            // 
            consultarFuncõesToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarFuncõesToolStripMenuItem.Name = "consultarFuncõesToolStripMenuItem";
            consultarFuncõesToolStripMenuItem.Size = new Size(196, 22);
            consultarFuncõesToolStripMenuItem.Text = "Consultar Funcões";
            consultarFuncõesToolStripMenuItem.Click += consultarFuncõesToolStripMenuItem_Click;
            // 
            // aviãoToolStripMenuItem1
            // 
            aviãoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cadastrarAviãoToolStripMenuItem, consultarAviãoToolStripMenuItem });
            aviãoToolStripMenuItem1.ForeColor = Color.FromArgb(80, 80, 80);
            aviãoToolStripMenuItem1.Name = "aviãoToolStripMenuItem1";
            aviãoToolStripMenuItem1.Size = new Size(49, 20);
            aviãoToolStripMenuItem1.Text = "Avião";
            // 
            // cadastrarAviãoToolStripMenuItem
            // 
            cadastrarAviãoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarAviãoToolStripMenuItem.Name = "cadastrarAviãoToolStripMenuItem";
            cadastrarAviãoToolStripMenuItem.Size = new Size(180, 22);
            cadastrarAviãoToolStripMenuItem.Text = "Cadastrar Avião";
            cadastrarAviãoToolStripMenuItem.Click += cadastrarAviãoToolStripMenuItem_Click;
            // 
            // consultarAviãoToolStripMenuItem
            // 
            consultarAviãoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarAviãoToolStripMenuItem.Name = "consultarAviãoToolStripMenuItem";
            consultarAviãoToolStripMenuItem.Size = new Size(180, 22);
            consultarAviãoToolStripMenuItem.Text = "Consultar Avião";
            consultarAviãoToolStripMenuItem.Click += consultarAviãoToolStripMenuItem_Click;
            // 
            // vôoToolStripMenuItem
            // 
            vôoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarVôoToolStripMenuItem, consultarToolStripMenuItem, cadastrarTipoVôoToolStripMenuItem, consultarTipoVôoToolStripMenuItem });
            vôoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            vôoToolStripMenuItem.Name = "vôoToolStripMenuItem";
            vôoToolStripMenuItem.Size = new Size(42, 20);
            vôoToolStripMenuItem.Text = " Vôo";
            // 
            // cadastrarVôoToolStripMenuItem
            // 
            cadastrarVôoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarVôoToolStripMenuItem.Name = "cadastrarVôoToolStripMenuItem";
            cadastrarVôoToolStripMenuItem.Size = new Size(180, 22);
            cadastrarVôoToolStripMenuItem.Text = "Cadastrar Vôo";
            cadastrarVôoToolStripMenuItem.Click += cadastrarVôoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(180, 22);
            consultarToolStripMenuItem.Text = "Consultar Vôos";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // cadastrarTipoVôoToolStripMenuItem
            // 
            cadastrarTipoVôoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarTipoVôoToolStripMenuItem.Name = "cadastrarTipoVôoToolStripMenuItem";
            cadastrarTipoVôoToolStripMenuItem.Size = new Size(180, 22);
            cadastrarTipoVôoToolStripMenuItem.Text = "Cadastrar Tipo Vôo";
            // 
            // consultarTipoVôoToolStripMenuItem
            // 
            consultarTipoVôoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarTipoVôoToolStripMenuItem.Name = "consultarTipoVôoToolStripMenuItem";
            consultarTipoVôoToolStripMenuItem.Size = new Size(180, 22);
            consultarTipoVôoToolStripMenuItem.Text = "Consultar Tipo Vôo";
            consultarTipoVôoToolStripMenuItem.Click += consultarTipoVôoToolStripMenuItem_Click;
            // 
            // hangarToolStripMenuItem
            // 
            hangarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarHangarToolStripMenuItem, consultarHangaresToolStripMenuItem, cadastrarEstacionamentoToolStripMenuItem, consultarEstacionamentoToolStripMenuItem });
            hangarToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            hangarToolStripMenuItem.Name = "hangarToolStripMenuItem";
            hangarToolStripMenuItem.Size = new Size(58, 20);
            hangarToolStripMenuItem.Text = "Hangar";
            // 
            // cadastrarHangarToolStripMenuItem
            // 
            cadastrarHangarToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarHangarToolStripMenuItem.Name = "cadastrarHangarToolStripMenuItem";
            cadastrarHangarToolStripMenuItem.Size = new Size(213, 22);
            cadastrarHangarToolStripMenuItem.Text = "Cadastrar Hangar";
            cadastrarHangarToolStripMenuItem.Click += cadastrarHangarToolStripMenuItem_Click;
            // 
            // consultarHangaresToolStripMenuItem
            // 
            consultarHangaresToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarHangaresToolStripMenuItem.Name = "consultarHangaresToolStripMenuItem";
            consultarHangaresToolStripMenuItem.Size = new Size(213, 22);
            consultarHangaresToolStripMenuItem.Text = "Consultar Hangares";
            consultarHangaresToolStripMenuItem.Click += consultarHangaresToolStripMenuItem_Click;
            // 
            // cadastrarEstacionamentoToolStripMenuItem
            // 
            cadastrarEstacionamentoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarEstacionamentoToolStripMenuItem.Name = "cadastrarEstacionamentoToolStripMenuItem";
            cadastrarEstacionamentoToolStripMenuItem.Size = new Size(213, 22);
            cadastrarEstacionamentoToolStripMenuItem.Text = "Cadastrar Estacionamento";
            cadastrarEstacionamentoToolStripMenuItem.Click += cadastrarEstacionamentoToolStripMenuItem_Click;
            // 
            // consultarEstacionamentoToolStripMenuItem
            // 
            consultarEstacionamentoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            consultarEstacionamentoToolStripMenuItem.Name = "consultarEstacionamentoToolStripMenuItem";
            consultarEstacionamentoToolStripMenuItem.Size = new Size(213, 22);
            consultarEstacionamentoToolStripMenuItem.Text = "Consultar Estacionamento";
            consultarEstacionamentoToolStripMenuItem.Click += consultarEstacionamentoToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1061, 558);
            Controls.Add(formMenuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = formMenuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPrincipal";
            Padding = new Padding(3, 48, 3, 2);
            Text = "IFSPAero - Gestão de Aeroportos";
            WindowState = FormWindowState.Maximized;
            formMenuStrip1.ResumeLayout(false);
            formMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip1;
        private ToolStripMenuItem aviãoToolStripMenuItem;
        private ToolStripMenuItem cadastrarCompanhiasToolStripMenuItem;
        private ToolStripMenuItem consultarCompanhiasToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncionáriosToolStripMenuItem;
        private ToolStripMenuItem aviãoToolStripMenuItem1;
        private ToolStripMenuItem cadastrarAviãoToolStripMenuItem;
        private ToolStripMenuItem consultarAviãoToolStripMenuItem;
        private ToolStripMenuItem vôoToolStripMenuItem;
        private ToolStripMenuItem cadastrarVôoToolStripMenuItem;
        private ToolStripMenuItem hangarToolStripMenuItem;
        private ToolStripMenuItem aeroportoToolStripMenuItem;
        private ToolStripMenuItem cadastrarAeroportoToolStripMenuItem;
        private ToolStripMenuItem consultarAeroportosToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem cadastrarHangarToolStripMenuItem;
        private ToolStripMenuItem consultarHangaresToolStripMenuItem;
        private ToolStripMenuItem cadastrarTipoVôoToolStripMenuItem;
        private ToolStripMenuItem consultarTipoVôoToolStripMenuItem;
        private ToolStripMenuItem cadastrarEstacionamentoToolStripMenuItem;
        private ToolStripMenuItem consultarEstacionamentoToolStripMenuItem;
        private ToolStripMenuItem consultarFuncionáriosToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncõesToolStripMenuItem;
        private ToolStripMenuItem consultarFuncõesToolStripMenuItem;
    }
}