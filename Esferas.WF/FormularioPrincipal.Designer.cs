
namespace Esferas.WF
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RestaurarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.esferasDataGridView = new System.Windows.Forms.DataGridView();
            this.radioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trazoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volumenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelarButtonPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cantidadLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.GuardarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.esferasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.EditarToolStripButton,
            this.BorrarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarToolStripButton,
            this.RestaurarToolStripButton,
            this.OrdenarToolStripButton,
            this.GuardarToolStripButton,
            this.toolStripSeparator2,
            this.SalirToolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoToolStripButton.Image")));
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 35);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("EditarToolStripButton.Image")));
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(41, 35);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BorrarToolStripButton.Image")));
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(43, 35);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarToolStripButton.Click += new System.EventHandler(this.BorrarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FiltrarToolStripButton.Image")));
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(41, 35);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltrarToolStripButton.Click += new System.EventHandler(this.FiltrarToolStripButton_Click);
            // 
            // RestaurarToolStripButton
            // 
            this.RestaurarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RestaurarToolStripButton.Image")));
            this.RestaurarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RestaurarToolStripButton.Name = "RestaurarToolStripButton";
            this.RestaurarToolStripButton.Size = new System.Drawing.Size(60, 35);
            this.RestaurarToolStripButton.Text = "Restaurar";
            this.RestaurarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RestaurarToolStripButton.Click += new System.EventHandler(this.RestaurarToolStripButton_Click);
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarToolStripButton.Image")));
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(54, 35);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // SalirToolStripButton6
            // 
            this.SalirToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("SalirToolStripButton6.Image")));
            this.SalirToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton6.Name = "SalirToolStripButton6";
            this.SalirToolStripButton6.Size = new System.Drawing.Size(33, 35);
            this.SalirToolStripButton6.Text = "Salir";
            this.SalirToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton6.Click += new System.EventHandler(this.SalirToolStripButton6_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 38);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.esferasDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cantidadLabel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.CancelarButtonPrincipal);
            this.splitContainer1.Size = new System.Drawing.Size(628, 298);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 5;
            // 
            // esferasDataGridView
            // 
            this.esferasDataGridView.AllowUserToAddRows = false;
            this.esferasDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.esferasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.esferasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.esferasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radioColumn,
            this.colorColumn,
            this.trazoColumn,
            this.areaColumn,
            this.volumenColumn});
            this.esferasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.esferasDataGridView.Location = new System.Drawing.Point(0, 0);
            this.esferasDataGridView.MultiSelect = false;
            this.esferasDataGridView.Name = "esferasDataGridView";
            this.esferasDataGridView.ReadOnly = true;
            this.esferasDataGridView.Size = new System.Drawing.Size(628, 227);
            this.esferasDataGridView.TabIndex = 0;
            // 
            // radioColumn
            // 
            this.radioColumn.HeaderText = "Radio";
            this.radioColumn.Name = "radioColumn";
            this.radioColumn.ReadOnly = true;
            // 
            // colorColumn
            // 
            this.colorColumn.HeaderText = "Color";
            this.colorColumn.Name = "colorColumn";
            this.colorColumn.ReadOnly = true;
            // 
            // trazoColumn
            // 
            this.trazoColumn.HeaderText = "Trazo";
            this.trazoColumn.Name = "trazoColumn";
            this.trazoColumn.ReadOnly = true;
            // 
            // areaColumn
            // 
            this.areaColumn.HeaderText = "Area";
            this.areaColumn.Name = "areaColumn";
            this.areaColumn.ReadOnly = true;
            // 
            // volumenColumn
            // 
            this.volumenColumn.HeaderText = "Volumen";
            this.volumenColumn.Name = "volumenColumn";
            this.volumenColumn.ReadOnly = true;
            // 
            // CancelarButtonPrincipal
            // 
            this.CancelarButtonPrincipal.Location = new System.Drawing.Point(505, 27);
            this.CancelarButtonPrincipal.Name = "CancelarButtonPrincipal";
            this.CancelarButtonPrincipal.Size = new System.Drawing.Size(75, 23);
            this.CancelarButtonPrincipal.TabIndex = 0;
            this.CancelarButtonPrincipal.Text = "Cancelar";
            this.CancelarButtonPrincipal.UseVisualStyleBackColor = true;
            this.CancelarButtonPrincipal.Click += new System.EventHandler(this.CancelarButtonPrincipal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad";
            // 
            // cantidadLabel
            // 
            this.cantidadLabel.AutoSize = true;
            this.cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadLabel.Location = new System.Drawing.Point(122, 27);
            this.cantidadLabel.Name = "cantidadLabel";
            this.cantidadLabel.Size = new System.Drawing.Size(14, 13);
            this.cantidadLabel.TabIndex = 2;
            this.cantidadLabel.Text = "0";
            // 
            // GuardarToolStripButton
            // 
            this.GuardarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarToolStripButton.Image")));
            this.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GuardarToolStripButton.Name = "GuardarToolStripButton";
            this.GuardarToolStripButton.Size = new System.Drawing.Size(53, 35);
            this.GuardarToolStripButton.Text = "Guardar";
            this.GuardarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GuardarToolStripButton.Click += new System.EventHandler(this.GuardarToolStripButton_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 336);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(644, 375);
            this.MinimumSize = new System.Drawing.Size(644, 375);
            this.Name = "FormularioPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.esferasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripButton RestaurarToolStripButton;
        private System.Windows.Forms.ToolStripButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView esferasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn radioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trazoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumenColumn;
        private System.Windows.Forms.Label cantidadLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelarButtonPrincipal;
        private System.Windows.Forms.ToolStripButton GuardarToolStripButton;
    }
}

