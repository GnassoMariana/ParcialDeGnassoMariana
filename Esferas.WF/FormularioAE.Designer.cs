
namespace Esferas.WF
{
    partial class FormularioAE
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
            this.components = new System.ComponentModel.Container();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.RadioLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.TrazoGroupBox = new System.Windows.Forms.GroupBox();
            this.PunteadoRadioButton = new System.Windows.Forms.RadioButton();
            this.RayadoRadioButton = new System.Windows.Forms.RadioButton();
            this.ContinuoRadioButton = new System.Windows.Forms.RadioButton();
            this.RadioTextBox = new System.Windows.Forms.TextBox();
            this.formAEerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TrazoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formAEerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(63, 197);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 32);
            this.AceptarButton.TabIndex = 0;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(212, 197);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 32);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(109, 80);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColorComboBox.TabIndex = 2;
            // 
            // RadioLabel
            // 
            this.RadioLabel.AutoSize = true;
            this.RadioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioLabel.Location = new System.Drawing.Point(28, 22);
            this.RadioLabel.Name = "RadioLabel";
            this.RadioLabel.Size = new System.Drawing.Size(40, 13);
            this.RadioLabel.TabIndex = 3;
            this.RadioLabel.Text = "Radio";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(28, 80);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(36, 13);
            this.ColorLabel.TabIndex = 4;
            this.ColorLabel.Text = "Color";
            // 
            // TrazoGroupBox
            // 
            this.TrazoGroupBox.Controls.Add(this.PunteadoRadioButton);
            this.TrazoGroupBox.Controls.Add(this.RayadoRadioButton);
            this.TrazoGroupBox.Controls.Add(this.ContinuoRadioButton);
            this.TrazoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrazoGroupBox.Location = new System.Drawing.Point(22, 122);
            this.TrazoGroupBox.Name = "TrazoGroupBox";
            this.TrazoGroupBox.Size = new System.Drawing.Size(422, 39);
            this.TrazoGroupBox.TabIndex = 5;
            this.TrazoGroupBox.TabStop = false;
            this.TrazoGroupBox.Text = "Trazo";
            // 
            // PunteadoRadioButton
            // 
            this.PunteadoRadioButton.AutoSize = true;
            this.PunteadoRadioButton.Location = new System.Drawing.Point(273, 16);
            this.PunteadoRadioButton.Name = "PunteadoRadioButton";
            this.PunteadoRadioButton.Size = new System.Drawing.Size(79, 17);
            this.PunteadoRadioButton.TabIndex = 2;
            this.PunteadoRadioButton.TabStop = true;
            this.PunteadoRadioButton.Text = "Punteado";
            this.PunteadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // RayadoRadioButton
            // 
            this.RayadoRadioButton.AutoSize = true;
            this.RayadoRadioButton.Location = new System.Drawing.Point(159, 16);
            this.RayadoRadioButton.Name = "RayadoRadioButton";
            this.RayadoRadioButton.Size = new System.Drawing.Size(68, 17);
            this.RayadoRadioButton.TabIndex = 1;
            this.RayadoRadioButton.TabStop = true;
            this.RayadoRadioButton.Text = "Rayado";
            this.RayadoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ContinuoRadioButton
            // 
            this.ContinuoRadioButton.AutoSize = true;
            this.ContinuoRadioButton.Location = new System.Drawing.Point(41, 16);
            this.ContinuoRadioButton.Name = "ContinuoRadioButton";
            this.ContinuoRadioButton.Size = new System.Drawing.Size(75, 17);
            this.ContinuoRadioButton.TabIndex = 0;
            this.ContinuoRadioButton.TabStop = true;
            this.ContinuoRadioButton.Text = "Continuo";
            this.ContinuoRadioButton.UseVisualStyleBackColor = true;
            // 
            // RadioTextBox
            // 
            this.RadioTextBox.Location = new System.Drawing.Point(109, 22);
            this.RadioTextBox.Name = "RadioTextBox";
            this.RadioTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadioTextBox.TabIndex = 6;
            // 
            // formAEerrorProvider
            // 
            this.formAEerrorProvider.ContainerControl = this;
            // 
            // FormularioAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 258);
            this.ControlBox = false;
            this.Controls.Add(this.RadioTextBox);
            this.Controls.Add(this.TrazoGroupBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.RadioLabel);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AceptarButton);
            this.MaximumSize = new System.Drawing.Size(481, 297);
            this.MinimumSize = new System.Drawing.Size(481, 297);
            this.Name = "FormularioAE";
            this.Text = "FormularioAE";
            this.Load += new System.EventHandler(this.FormularioAE_Load);
            this.TrazoGroupBox.ResumeLayout(false);
            this.TrazoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formAEerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label RadioLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.GroupBox TrazoGroupBox;
        private System.Windows.Forms.RadioButton PunteadoRadioButton;
        private System.Windows.Forms.RadioButton RayadoRadioButton;
        private System.Windows.Forms.RadioButton ContinuoRadioButton;
        private System.Windows.Forms.TextBox RadioTextBox;
        private System.Windows.Forms.ErrorProvider formAEerrorProvider;
    }
}