namespace EwidencjaPojazdow
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRejestracja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numRok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPrzeglad = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWlasciciel = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.Rejestracja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Przeglad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wlasciciel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRaport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr rejestracyjny";
            // 
            // txtRejestracja
            // 
            this.txtRejestracja.Location = new System.Drawing.Point(212, 39);
            this.txtRejestracja.Name = "txtRejestracja";
            this.txtRejestracja.Size = new System.Drawing.Size(100, 22);
            this.txtRejestracja.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(212, 81);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(212, 121);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rok produkcji";
            // 
            // numRok
            // 
            this.numRok.Location = new System.Drawing.Point(212, 160);
            this.numRok.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numRok.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numRok.Name = "numRok";
            this.numRok.Size = new System.Drawing.Size(120, 22);
            this.numRok.TabIndex = 7;
            this.numRok.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data przeglądu";
            // 
            // dtPrzeglad
            // 
            this.dtPrzeglad.Location = new System.Drawing.Point(212, 197);
            this.dtPrzeglad.Name = "dtPrzeglad";
            this.dtPrzeglad.Size = new System.Drawing.Size(200, 22);
            this.dtPrzeglad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Właściciel";
            // 
            // txtWlasciciel
            // 
            this.txtWlasciciel.Location = new System.Drawing.Point(212, 233);
            this.txtWlasciciel.Name = "txtWlasciciel";
            this.txtWlasciciel.Size = new System.Drawing.Size(100, 22);
            this.txtWlasciciel.TabIndex = 11;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(449, 73);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(180, 23);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj pojazd";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dgvPojazdy
            // 
            this.dgvPojazdy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rejestracja,
            this.Marka,
            this.Model,
            this.Rok,
            this.Przeglad,
            this.Wlasciciel});
            this.dgvPojazdy.Location = new System.Drawing.Point(257, 288);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.RowHeadersWidth = 51;
            this.dgvPojazdy.RowTemplate.Height = 24;
            this.dgvPojazdy.Size = new System.Drawing.Size(240, 150);
            this.dgvPojazdy.TabIndex = 13;
            // 
            // Rejestracja
            // 
            this.Rejestracja.HeaderText = "Rejestracja";
            this.Rejestracja.MinimumWidth = 6;
            this.Rejestracja.Name = "Rejestracja";
            // 
            // Marka
            // 
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            // 
            // Rok
            // 
            this.Rok.HeaderText = "Rok";
            this.Rok.MinimumWidth = 6;
            this.Rok.Name = "Rok";
            // 
            // Przeglad
            // 
            this.Przeglad.HeaderText = "Przeglad";
            this.Przeglad.MinimumWidth = 6;
            this.Przeglad.Name = "Przeglad";
            // 
            // Wlasciciel
            // 
            this.Wlasciciel.HeaderText = "Wlasciciel";
            this.Wlasciciel.MinimumWidth = 6;
            this.Wlasciciel.Name = "Wlasciciel";
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(449, 135);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(168, 23);
            this.btnRaport.TabIndex = 14;
            this.btnRaport.Text = "Generuj raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRaport);
            this.Controls.Add(this.dgvPojazdy);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtWlasciciel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtPrzeglad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numRok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRejestracja);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRejestracja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPrzeglad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWlasciciel;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPojazdy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rejestracja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Przeglad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wlasciciel;
        private System.Windows.Forms.Button btnRaport;
    }
}

