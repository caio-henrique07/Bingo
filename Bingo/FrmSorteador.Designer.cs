namespace Bingo
{
    partial class FrmSorteador
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
            this.btProximo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btHistorico = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btProximo
            // 
            this.btProximo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btProximo.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximo.Location = new System.Drawing.Point(237, 15);
            this.btProximo.Margin = new System.Windows.Forms.Padding(6);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(258, 50);
            this.btProximo.TabIndex = 1;
            this.btProximo.Text = "Próximo Número";
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(107, 387);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(162, 50);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btHistorico
            // 
            this.btHistorico.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorico.Location = new System.Drawing.Point(363, 387);
            this.btHistorico.Margin = new System.Windows.Forms.Padding(6);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(270, 50);
            this.btHistorico.TabIndex = 3;
            this.btHistorico.Text = "Histórico Sorteado";
            this.btHistorico.UseVisualStyleBackColor = true;
            this.btHistorico.Click += new System.EventHandler(this.btHistorico_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumero.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(2, 86);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(751, 269);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSorteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 452);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btProximo);
            this.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmSorteador";
            this.Text = "FrmSorteador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSorteador_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btHistorico;
        private System.Windows.Forms.Label lblNumero;
    }
}