namespace Button_Label_Ornek_1
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
            this.btnBesiktas = new System.Windows.Forms.Button();
            this.btnBayern = new System.Windows.Forms.Button();
            this.btnManchester = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.lblTakim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBesiktas
            // 
            this.btnBesiktas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBesiktas.Location = new System.Drawing.Point(26, 32);
            this.btnBesiktas.Name = "btnBesiktas";
            this.btnBesiktas.Size = new System.Drawing.Size(288, 59);
            this.btnBesiktas.TabIndex = 0;
            this.btnBesiktas.Text = "BEŞİKTAŞ";
            this.btnBesiktas.UseVisualStyleBackColor = true;
            this.btnBesiktas.Click += new System.EventHandler(this.btnBesiktas_Click);
            // 
            // btnBayern
            // 
            this.btnBayern.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBayern.Location = new System.Drawing.Point(26, 97);
            this.btnBayern.Name = "btnBayern";
            this.btnBayern.Size = new System.Drawing.Size(288, 59);
            this.btnBayern.TabIndex = 1;
            this.btnBayern.Text = "BAYERN MÜNİH";
            this.btnBayern.UseVisualStyleBackColor = true;
            this.btnBayern.Click += new System.EventHandler(this.btnBayern_Click);
            // 
            // btnManchester
            // 
            this.btnManchester.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnManchester.Location = new System.Drawing.Point(26, 162);
            this.btnManchester.Name = "btnManchester";
            this.btnManchester.Size = new System.Drawing.Size(288, 59);
            this.btnManchester.TabIndex = 2;
            this.btnManchester.Text = "M. UNİTED";
            this.btnManchester.UseVisualStyleBackColor = true;
            this.btnManchester.Click += new System.EventHandler(this.btnManchester_Click);
            // 
            // btnReal
            // 
            this.btnReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReal.Location = new System.Drawing.Point(26, 227);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(288, 59);
            this.btnReal.TabIndex = 3;
            this.btnReal.Text = "REAL MADRİD";
            this.btnReal.UseVisualStyleBackColor = true;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // lblTakim
            // 
            this.lblTakim.AutoSize = true;
            this.lblTakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTakim.Location = new System.Drawing.Point(338, 129);
            this.lblTakim.Name = "lblTakim";
            this.lblTakim.Size = new System.Drawing.Size(152, 55);
            this.lblTakim.TabIndex = 4;
            this.lblTakim.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 325);
            this.Controls.Add(this.lblTakim);
            this.Controls.Add(this.btnReal);
            this.Controls.Add(this.btnManchester);
            this.Controls.Add(this.btnBayern);
            this.Controls.Add(this.btnBesiktas);
            this.Name = "Form1";
            this.Text = "Takım Seçim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBesiktas;
        private System.Windows.Forms.Button btnBayern;
        private System.Windows.Forms.Button btnManchester;
        private System.Windows.Forms.Button btnReal;
        private System.Windows.Forms.Label lblTakim;
    }
}

