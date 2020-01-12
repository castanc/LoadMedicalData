namespace LoadMedicalData
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txData = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCleanMiDinero = new System.Windows.Forms.Button();
            this.btnBROUCesar = new System.Windows.Forms.Button();
            this.btnRawData = new System.Windows.Forms.Button();
            this.btnCesarRegs = new System.Windows.Forms.Button();
            this.cbmiDinero = new System.Windows.Forms.ComboBox();
            this.btnMiDinero = new System.Windows.Forms.Button();
            this.btnAnda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(75, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "SEP OCT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "AUGUST";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txData
            // 
            this.txData.Location = new System.Drawing.Point(29, 162);
            this.txData.Multiline = true;
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(521, 218);
            this.txData.TabIndex = 2;
            this.txData.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCleanMiDinero);
            this.panel1.Controls.Add(this.btnBROUCesar);
            this.panel1.Controls.Add(this.btnRawData);
            this.panel1.Controls.Add(this.btnCesarRegs);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 3;
            // 
            // btnCleanMiDinero
            // 
            this.btnCleanMiDinero.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCleanMiDinero.Location = new System.Drawing.Point(412, 0);
            this.btnCleanMiDinero.Name = "btnCleanMiDinero";
            this.btnCleanMiDinero.Size = new System.Drawing.Size(75, 36);
            this.btnCleanMiDinero.TabIndex = 5;
            this.btnCleanMiDinero.Text = "CLEAN MIDINERO";
            this.btnCleanMiDinero.UseVisualStyleBackColor = true;
            this.btnCleanMiDinero.Click += new System.EventHandler(this.btnCleanMiDinero_Click);
            // 
            // btnBROUCesar
            // 
            this.btnBROUCesar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBROUCesar.Location = new System.Drawing.Point(337, 0);
            this.btnBROUCesar.Name = "btnBROUCesar";
            this.btnBROUCesar.Size = new System.Drawing.Size(75, 36);
            this.btnBROUCesar.TabIndex = 4;
            this.btnBROUCesar.Text = "BROU CESAR";
            this.btnBROUCesar.UseVisualStyleBackColor = true;
            this.btnBROUCesar.Click += new System.EventHandler(this.btnBROUCesar_Click);
            // 
            // btnRawData
            // 
            this.btnRawData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRawData.Location = new System.Drawing.Point(262, 0);
            this.btnRawData.Name = "btnRawData";
            this.btnRawData.Size = new System.Drawing.Size(75, 36);
            this.btnRawData.TabIndex = 3;
            this.btnRawData.Text = "RAW DATA";
            this.btnRawData.UseVisualStyleBackColor = true;
            this.btnRawData.Click += new System.EventHandler(this.btnRawData_Click);
            // 
            // btnCesarRegs
            // 
            this.btnCesarRegs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCesarRegs.Location = new System.Drawing.Point(150, 0);
            this.btnCesarRegs.Name = "btnCesarRegs";
            this.btnCesarRegs.Size = new System.Drawing.Size(112, 36);
            this.btnCesarRegs.TabIndex = 2;
            this.btnCesarRegs.Text = "Cesar Regs JSON";
            this.btnCesarRegs.UseVisualStyleBackColor = true;
            // 
            // cbmiDinero
            // 
            this.cbmiDinero.FormattingEnabled = true;
            this.cbmiDinero.Items.AddRange(new object[] {
            "MDLOCAL",
            "VARLIX",
            "GALES",
            "MDINT",
            "INDUMEX"});
            this.cbmiDinero.Location = new System.Drawing.Point(12, 53);
            this.cbmiDinero.Name = "cbmiDinero";
            this.cbmiDinero.Size = new System.Drawing.Size(121, 21);
            this.cbmiDinero.TabIndex = 4;
            // 
            // btnMiDinero
            // 
            this.btnMiDinero.Location = new System.Drawing.Point(139, 53);
            this.btnMiDinero.Name = "btnMiDinero";
            this.btnMiDinero.Size = new System.Drawing.Size(75, 23);
            this.btnMiDinero.TabIndex = 5;
            this.btnMiDinero.Text = "MiDinero";
            this.btnMiDinero.UseVisualStyleBackColor = true;
            this.btnMiDinero.Click += new System.EventHandler(this.btnMiDinero_Click);
            // 
            // btnAnda
            // 
            this.btnAnda.Location = new System.Drawing.Point(240, 51);
            this.btnAnda.Name = "btnAnda";
            this.btnAnda.Size = new System.Drawing.Size(75, 23);
            this.btnAnda.TabIndex = 6;
            this.btnAnda.Text = "ANDA";
            this.btnAnda.UseVisualStyleBackColor = true;
            this.btnAnda.Click += new System.EventHandler(this.btnAnda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnda);
            this.Controls.Add(this.btnMiDinero);
            this.Controls.Add(this.cbmiDinero);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCesarRegs;
        private System.Windows.Forms.Button btnRawData;
        private System.Windows.Forms.Button btnBROUCesar;
        private System.Windows.Forms.Button btnCleanMiDinero;
        private System.Windows.Forms.ComboBox cbmiDinero;
        private System.Windows.Forms.Button btnMiDinero;
        private System.Windows.Forms.Button btnAnda;
    }
}

