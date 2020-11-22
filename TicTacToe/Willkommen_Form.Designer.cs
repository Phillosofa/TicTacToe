
namespace TicTacToe
{
    partial class Willkommen_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_1spieler = new System.Windows.Forms.Button();
            this.btn_2spieler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_1spieler
            // 
            this.btn_1spieler.Location = new System.Drawing.Point(60, 123);
            this.btn_1spieler.Name = "btn_1spieler";
            this.btn_1spieler.Size = new System.Drawing.Size(118, 23);
            this.btn_1spieler.TabIndex = 0;
            this.btn_1spieler.Text = "1 Spieler";
            this.btn_1spieler.UseVisualStyleBackColor = true;
            this.btn_1spieler.Click += new System.EventHandler(this.btn_1spieler_Click);
            // 
            // btn_2spieler
            // 
            this.btn_2spieler.Location = new System.Drawing.Point(214, 123);
            this.btn_2spieler.Name = "btn_2spieler";
            this.btn_2spieler.Size = new System.Drawing.Size(118, 23);
            this.btn_2spieler.TabIndex = 1;
            this.btn_2spieler.Text = "2 Spieler";
            this.btn_2spieler.UseVisualStyleBackColor = true;
            this.btn_2spieler.Click += new System.EventHandler(this.btn_2spieler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wähle einen Spielmodus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(83, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Willkommen zu TicTacToe";
            // 
            // Willkommen_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 184);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_2spieler);
            this.Controls.Add(this.btn_1spieler);
            this.Name = "Willkommen_Form";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1spieler;
        private System.Windows.Forms.Button btn_2spieler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

