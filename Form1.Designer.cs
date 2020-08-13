namespace Imposto
{
    partial class frmPrincipal
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
            this.lblRendimento = new System.Windows.Forms.Label();
            this.edtRendimento = new System.Windows.Forms.TextBox();
            this.btnConferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Location = new System.Drawing.Point(12, 43);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(114, 13);
            this.lblRendimento.TabIndex = 0;
            this.lblRendimento.Text = "Informe o Rendimento:";
            // 
            // edtRendimento
            // 
            this.edtRendimento.Location = new System.Drawing.Point(132, 43);
            this.edtRendimento.Name = "edtRendimento";
            this.edtRendimento.Size = new System.Drawing.Size(100, 20);
            this.edtRendimento.TabIndex = 1;
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(97, 69);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(75, 23);
            this.btnConferir.TabIndex = 2;
            this.btnConferir.Text = "Conferir!";
            this.btnConferir.UseVisualStyleBackColor = true;
            this.btnConferir.Click += new System.EventHandler(this.btnConferir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 103);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.edtRendimento);
            this.Controls.Add(this.lblRendimento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imposto de Renda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.TextBox edtRendimento;
        private System.Windows.Forms.Button btnConferir;
    }
}

