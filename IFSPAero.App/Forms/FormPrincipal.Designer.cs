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
            aviãoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarCompanhiasToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncionáriosToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncõesToolStripMenuItem = new ToolStripMenuItem();
            aviãoToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarAviãoToolStripMenuItem = new ToolStripMenuItem();
            vôoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarVôoToolStripMenuItem = new ToolStripMenuItem();
            cadastrarTipoVôoToolStripMenuItem = new ToolStripMenuItem();
            hangarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarHangarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarEstacionamentoToolStripMenuItem = new ToolStripMenuItem();
            formMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formMenuStrip1
            // 
            formMenuStrip1.ImageScalingSize = new Size(20, 20);
            formMenuStrip1.Items.AddRange(new ToolStripItem[] { aeroportoToolStripMenuItem, aviãoToolStripMenuItem, funcionárioToolStripMenuItem, aviãoToolStripMenuItem1, vôoToolStripMenuItem, hangarToolStripMenuItem });
            formMenuStrip1.Location = new Point(3, 64);
            formMenuStrip1.Name = "formMenuStrip1";
            formMenuStrip1.Padding = new Padding(6, 3, 0, 3);
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            formMenuStrip1.Renderer = controlRenderer1;
            formMenuStrip1.Size = new Size(1207, 30);
            formMenuStrip1.TabIndex = 0;
            formMenuStrip1.Text = "formMenuStrip1";
            // 
            // aeroportoToolStripMenuItem
            // 
            aeroportoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarAeroportoToolStripMenuItem });
            aeroportoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            aeroportoToolStripMenuItem.Name = "aeroportoToolStripMenuItem";
            aeroportoToolStripMenuItem.Size = new Size(92, 24);
            aeroportoToolStripMenuItem.Text = "Aeroporto";
            // 
            // cadastrarAeroportoToolStripMenuItem
            // 
            cadastrarAeroportoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarAeroportoToolStripMenuItem.Name = "cadastrarAeroportoToolStripMenuItem";
            cadastrarAeroportoToolStripMenuItem.Size = new Size(228, 26);
            cadastrarAeroportoToolStripMenuItem.Text = "Cadastrar Aeroporto";
            cadastrarAeroportoToolStripMenuItem.Click += cadastrarAeroportoToolStripMenuItem_Click;
            // 
            // aviãoToolStripMenuItem
            // 
            aviãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarCompanhiasToolStripMenuItem });
            aviãoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            aviãoToolStripMenuItem.Name = "aviãoToolStripMenuItem";
            aviãoToolStripMenuItem.Size = new Size(99, 24);
            aviãoToolStripMenuItem.Text = "Companhia";
            // 
            // cadastrarCompanhiasToolStripMenuItem
            // 
            cadastrarCompanhiasToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarCompanhiasToolStripMenuItem.Name = "cadastrarCompanhiasToolStripMenuItem";
            cadastrarCompanhiasToolStripMenuItem.Size = new Size(241, 26);
            cadastrarCompanhiasToolStripMenuItem.Text = "Cadastrar Companhias";
            cadastrarCompanhiasToolStripMenuItem.Click += cadastrarCompanhiasToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFuncionáriosToolStripMenuItem, cadastrarFuncõesToolStripMenuItem });
            funcionárioToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(100, 24);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // cadastrarFuncionáriosToolStripMenuItem
            // 
            cadastrarFuncionáriosToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarFuncionáriosToolStripMenuItem.Name = "cadastrarFuncionáriosToolStripMenuItem";
            cadastrarFuncionáriosToolStripMenuItem.Size = new Size(242, 26);
            cadastrarFuncionáriosToolStripMenuItem.Text = "Cadastrar Funcionários";
            cadastrarFuncionáriosToolStripMenuItem.Click += cadastrarFuncionáriosToolStripMenuItem_Click;
            // 
            // cadastrarFuncõesToolStripMenuItem
            // 
            cadastrarFuncõesToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarFuncõesToolStripMenuItem.Name = "cadastrarFuncõesToolStripMenuItem";
            cadastrarFuncõesToolStripMenuItem.Size = new Size(242, 26);
            cadastrarFuncõesToolStripMenuItem.Text = "Cadastrar Funcões";
            cadastrarFuncõesToolStripMenuItem.Click += cadastrarFuncõesToolStripMenuItem_Click;
            // 
            // aviãoToolStripMenuItem1
            // 
            aviãoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { cadastrarAviãoToolStripMenuItem });
            aviãoToolStripMenuItem1.ForeColor = Color.FromArgb(80, 80, 80);
            aviãoToolStripMenuItem1.Name = "aviãoToolStripMenuItem1";
            aviãoToolStripMenuItem1.Size = new Size(61, 24);
            aviãoToolStripMenuItem1.Text = "Avião";
            // 
            // cadastrarAviãoToolStripMenuItem
            // 
            cadastrarAviãoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarAviãoToolStripMenuItem.Name = "cadastrarAviãoToolStripMenuItem";
            cadastrarAviãoToolStripMenuItem.Size = new Size(197, 26);
            cadastrarAviãoToolStripMenuItem.Text = "Cadastrar Avião";
            cadastrarAviãoToolStripMenuItem.Click += cadastrarAviãoToolStripMenuItem_Click;
            // 
            // vôoToolStripMenuItem
            // 
            vôoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarVôoToolStripMenuItem, cadastrarTipoVôoToolStripMenuItem });
            vôoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            vôoToolStripMenuItem.Name = "vôoToolStripMenuItem";
            vôoToolStripMenuItem.Size = new Size(53, 24);
            vôoToolStripMenuItem.Text = " Vôo";
            // 
            // cadastrarVôoToolStripMenuItem
            // 
            cadastrarVôoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarVôoToolStripMenuItem.Name = "cadastrarVôoToolStripMenuItem";
            cadastrarVôoToolStripMenuItem.Size = new Size(219, 26);
            cadastrarVôoToolStripMenuItem.Text = "Cadastrar Vôo";
            cadastrarVôoToolStripMenuItem.Click += cadastrarVôoToolStripMenuItem_Click;
            // 
            // cadastrarTipoVôoToolStripMenuItem
            // 
            cadastrarTipoVôoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarTipoVôoToolStripMenuItem.Name = "cadastrarTipoVôoToolStripMenuItem";
            cadastrarTipoVôoToolStripMenuItem.Size = new Size(219, 26);
            cadastrarTipoVôoToolStripMenuItem.Text = "Cadastrar Tipo Vôo";
            cadastrarTipoVôoToolStripMenuItem.Click += cadastrarTipoVôoToolStripMenuItem_Click;
            // 
            // hangarToolStripMenuItem
            // 
            hangarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarHangarToolStripMenuItem, cadastrarEstacionamentoToolStripMenuItem });
            hangarToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            hangarToolStripMenuItem.Name = "hangarToolStripMenuItem";
            hangarToolStripMenuItem.Size = new Size(72, 24);
            hangarToolStripMenuItem.Text = "Hangar";
            // 
            // cadastrarHangarToolStripMenuItem
            // 
            cadastrarHangarToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarHangarToolStripMenuItem.Name = "cadastrarHangarToolStripMenuItem";
            cadastrarHangarToolStripMenuItem.Size = new Size(265, 26);
            cadastrarHangarToolStripMenuItem.Text = "Cadastrar Hangar";
            cadastrarHangarToolStripMenuItem.Click += cadastrarHangarToolStripMenuItem_Click;
            // 
            // cadastrarEstacionamentoToolStripMenuItem
            // 
            cadastrarEstacionamentoToolStripMenuItem.ForeColor = Color.FromArgb(80, 80, 80);
            cadastrarEstacionamentoToolStripMenuItem.Name = "cadastrarEstacionamentoToolStripMenuItem";
            cadastrarEstacionamentoToolStripMenuItem.Size = new Size(265, 26);
            cadastrarEstacionamentoToolStripMenuItem.Text = "Cadastrar Estacionamento";
            cadastrarEstacionamentoToolStripMenuItem.Click += cadastrarEstacionamentoToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1213, 744);
            Controls.Add(formMenuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = formMenuStrip1;
            Name = "FormPrincipal";
            Text = "IFSPAero - Gestão de Aeroportos";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            formMenuStrip1.ResumeLayout(false);
            formMenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.FormMenuStrip formMenuStrip1;
        private ToolStripMenuItem aviãoToolStripMenuItem;
        private ToolStripMenuItem cadastrarCompanhiasToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncionáriosToolStripMenuItem;
        private ToolStripMenuItem aviãoToolStripMenuItem1;
        private ToolStripMenuItem cadastrarAviãoToolStripMenuItem;
        private ToolStripMenuItem vôoToolStripMenuItem;
        private ToolStripMenuItem cadastrarVôoToolStripMenuItem;
        private ToolStripMenuItem hangarToolStripMenuItem;
        private ToolStripMenuItem aeroportoToolStripMenuItem;
        private ToolStripMenuItem cadastrarAeroportoToolStripMenuItem;
        private ToolStripMenuItem cadastrarHangarToolStripMenuItem;
        private ToolStripMenuItem cadastrarTipoVôoToolStripMenuItem;
        private ToolStripMenuItem cadastrarEstacionamentoToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncõesToolStripMenuItem;
    }
}