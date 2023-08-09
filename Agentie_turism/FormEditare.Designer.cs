
namespace Agentie_turism
{
    partial class FormEditare
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
            this.tbPlata = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTranzactie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTransport = new System.Windows.Forms.CheckBox();
            this.cbReducere = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbAllinclusive = new System.Windows.Forms.CheckBox();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tbPlata
            // 
            this.tbPlata.Location = new System.Drawing.Point(182, 252);
            this.tbPlata.Name = "tbPlata";
            this.tbPlata.Size = new System.Drawing.Size(130, 22);
            this.tbPlata.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "De platit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(182, 216);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(130, 22);
            this.tbEmail.TabIndex = 26;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(182, 173);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(130, 22);
            this.tbTelefon.TabIndex = 25;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(182, 125);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(130, 22);
            this.tbPrenume.TabIndex = 24;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(182, 72);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(130, 22);
            this.tbNume.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(88, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nume:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "MODIFICARE TURIST EXISTENT";
            // 
            // cbTranzactie
            // 
            this.cbTranzactie.FormattingEnabled = true;
            this.cbTranzactie.Items.AddRange(new object[] {
            "Plata card",
            "Plata cash"});
            this.cbTranzactie.Location = new System.Drawing.Point(93, 313);
            this.cbTranzactie.Name = "cbTranzactie";
            this.cbTranzactie.Size = new System.Drawing.Size(247, 24);
            this.cbTranzactie.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Modalitate plata: ";
            // 
            // cbTransport
            // 
            this.cbTransport.AutoSize = true;
            this.cbTransport.Location = new System.Drawing.Point(93, 425);
            this.cbTransport.Name = "cbTransport";
            this.cbTransport.Size = new System.Drawing.Size(100, 21);
            this.cbTransport.TabIndex = 33;
            this.cbTransport.Text = "+Transport";
            this.cbTransport.UseVisualStyleBackColor = true;
            // 
            // cbReducere
            // 
            this.cbReducere.AutoSize = true;
            this.cbReducere.Location = new System.Drawing.Point(93, 353);
            this.cbReducere.Name = "cbReducere";
            this.cbReducere.Size = new System.Drawing.Size(92, 21);
            this.cbReducere.TabIndex = 30;
            this.cbReducere.Text = "Reducere";
            this.cbReducere.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(88, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 29);
            this.label13.TabIndex = 32;
            this.label13.Text = "SERVICII:";
            // 
            // cbAllinclusive
            // 
            this.cbAllinclusive.AutoSize = true;
            this.cbAllinclusive.Location = new System.Drawing.Point(229, 425);
            this.cbAllinclusive.Name = "cbAllinclusive";
            this.cbAllinclusive.Size = new System.Drawing.Size(111, 21);
            this.cbAllinclusive.TabIndex = 31;
            this.cbAllinclusive.Text = "+All Inclusive";
            this.cbAllinclusive.UseVisualStyleBackColor = true;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(112, 470);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(98, 41);
            this.btnSalvare.TabIndex = 37;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(265, 470);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 41);
            this.btnStergere.TabIndex = 36;
            this.btnStergere.Text = "Renunta";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FormEditare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(464, 523);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.cbTranzactie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTransport);
            this.Controls.Add(this.cbReducere);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbAllinclusive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPlata);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormEditare";
            this.Text = "FormEditare";
            this.Load += new System.EventHandler(this.FormEditare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTranzactie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbTransport;
        private System.Windows.Forms.CheckBox cbReducere;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbAllinclusive;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnStergere;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}