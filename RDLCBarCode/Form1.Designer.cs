namespace RDLCBarCode
{
    partial class Form1
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
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Barcode = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.NumericUpDown();
            this.pintureboxcode = new System.Windows.Forms.PictureBox();
            this.appDataRG1 = new RDLCBarCode.AppDataRG();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pintureboxcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataRG1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(275, 33);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.Text = "Generar";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero";
            // 
            // Txt_Barcode
            // 
            this.Txt_Barcode.Location = new System.Drawing.Point(109, 36);
            this.Txt_Barcode.Name = "Txt_Barcode";
            this.Txt_Barcode.Size = new System.Drawing.Size(145, 20);
            this.Txt_Barcode.TabIndex = 3;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(109, 73);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(145, 20);
            this.numero.TabIndex = 4;
            // 
            // pintureboxcode
            // 
            this.pintureboxcode.Location = new System.Drawing.Point(15, 119);
            this.pintureboxcode.Name = "pintureboxcode";
            this.pintureboxcode.Size = new System.Drawing.Size(150, 80);
            this.pintureboxcode.TabIndex = 6;
            this.pintureboxcode.TabStop = false;
            // 
            // appDataRG1
            // 
            this.appDataRG1.DataSetName = "AppDataRG";
            this.appDataRG1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 264);
            this.Controls.Add(this.pintureboxcode);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.Txt_Barcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_imprimir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RDLC Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.numero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pintureboxcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appDataRG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Barcode;
        private System.Windows.Forms.NumericUpDown numero;
        private System.Windows.Forms.PictureBox pintureboxcode;
        private AppDataRG appDataRG1;
    }
}

