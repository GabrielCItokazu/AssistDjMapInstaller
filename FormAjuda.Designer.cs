namespace AssistDjMapInstaller
{
    partial class FormAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjuda));
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTituloMidi = new System.Windows.Forms.Label();
            this.lblTextoMidi = new System.Windows.Forms.Label();
            this.lblTextoDevo = new System.Windows.Forms.Label();
            this.lblTituloDevo = new System.Windows.Forms.Label();
            this.lblTextoRecebi = new System.Windows.Forms.Label();
            this.lblTituloRecebi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnInfos = new System.Windows.Forms.Panel();
            this.pnInfos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(12, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "←";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblTituloMidi
            // 
            this.lblTituloMidi.AutoSize = true;
            this.lblTituloMidi.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMidi.ForeColor = System.Drawing.Color.White;
            this.lblTituloMidi.Location = new System.Drawing.Point(12, 56);
            this.lblTituloMidi.Name = "lblTituloMidi";
            this.lblTituloMidi.Size = new System.Drawing.Size(460, 34);
            this.lblTituloMidi.TabIndex = 10;
            this.lblTituloMidi.Text = "Conecte o dispositivo como MIDI";
            // 
            // lblTextoMidi
            // 
            this.lblTextoMidi.AutoSize = true;
            this.lblTextoMidi.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoMidi.ForeColor = System.Drawing.Color.Gray;
            this.lblTextoMidi.Location = new System.Drawing.Point(14, 103);
            this.lblTextoMidi.Name = "lblTextoMidi";
            this.lblTextoMidi.Size = new System.Drawing.Size(63, 24);
            this.lblTextoMidi.TabIndex = 11;
            this.lblTextoMidi.Text = "Texto";
            // 
            // lblTextoDevo
            // 
            this.lblTextoDevo.AutoSize = true;
            this.lblTextoDevo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoDevo.ForeColor = System.Drawing.Color.Gray;
            this.lblTextoDevo.Location = new System.Drawing.Point(14, 201);
            this.lblTextoDevo.Name = "lblTextoDevo";
            this.lblTextoDevo.Size = new System.Drawing.Size(63, 24);
            this.lblTextoDevo.TabIndex = 13;
            this.lblTextoDevo.Text = "Texto";
            // 
            // lblTituloDevo
            // 
            this.lblTituloDevo.AutoSize = true;
            this.lblTituloDevo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDevo.ForeColor = System.Drawing.Color.White;
            this.lblTituloDevo.Location = new System.Drawing.Point(12, 154);
            this.lblTituloDevo.Name = "lblTituloDevo";
            this.lblTituloDevo.Size = new System.Drawing.Size(635, 34);
            this.lblTituloDevo.TabIndex = 12;
            this.lblTituloDevo.Text = "Devo mapear toda vez que abrir o aplicativo?";
            // 
            // lblTextoRecebi
            // 
            this.lblTextoRecebi.AutoSize = true;
            this.lblTextoRecebi.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoRecebi.ForeColor = System.Drawing.Color.Gray;
            this.lblTextoRecebi.Location = new System.Drawing.Point(14, 304);
            this.lblTextoRecebi.Name = "lblTextoRecebi";
            this.lblTextoRecebi.Size = new System.Drawing.Size(63, 24);
            this.lblTextoRecebi.TabIndex = 15;
            this.lblTextoRecebi.Text = "Texto";
            // 
            // lblTituloRecebi
            // 
            this.lblTituloRecebi.AutoSize = true;
            this.lblTituloRecebi.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRecebi.ForeColor = System.Drawing.Color.White;
            this.lblTituloRecebi.Location = new System.Drawing.Point(12, 257);
            this.lblTituloRecebi.Name = "lblTituloRecebi";
            this.lblTituloRecebi.Size = new System.Drawing.Size(629, 34);
            this.lblTituloRecebi.TabIndex = 14;
            this.lblTituloRecebi.Text = "Recebi uma mensagem de erro, o que fazer?";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(3, 6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(338, 24);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email: gabriel@gabrielraffa.works";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(353, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Site: www.gabrielraffa.works";
            // 
            // pnInfos
            // 
            this.pnInfos.Controls.Add(this.lblEmail);
            this.pnInfos.Controls.Add(this.label1);
            this.pnInfos.Location = new System.Drawing.Point(18, 442);
            this.pnInfos.Name = "pnInfos";
            this.pnInfos.Size = new System.Drawing.Size(648, 35);
            this.pnInfos.TabIndex = 18;
            // 
            // FormAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.pnInfos);
            this.Controls.Add(this.lblTextoRecebi);
            this.Controls.Add(this.lblTituloRecebi);
            this.Controls.Add(this.lblTextoDevo);
            this.Controls.Add(this.lblTituloDevo);
            this.Controls.Add(this.lblTextoMidi);
            this.Controls.Add(this.lblTituloMidi);
            this.Controls.Add(this.btnFechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAjuda";
            this.Load += new System.EventHandler(this.FormAjuda_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormAjuda_MouseDown);
            this.pnInfos.ResumeLayout(false);
            this.pnInfos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTituloMidi;
        private System.Windows.Forms.Label lblTextoMidi;
        private System.Windows.Forms.Label lblTextoDevo;
        private System.Windows.Forms.Label lblTituloDevo;
        private System.Windows.Forms.Label lblTextoRecebi;
        private System.Windows.Forms.Label lblTituloRecebi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnInfos;
    }
}