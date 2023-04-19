namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            afisare = new TextBox();
            numar1 = new Button();
            numar2 = new Button();
            numar3 = new Button();
            numar4 = new Button();
            numar5 = new Button();
            numar6 = new Button();
            numar7 = new Button();
            numar8 = new Button();
            numar9 = new Button();
            numar0 = new Button();
            reset = new Button();
            undo = new Button();
            virgula = new Button();
            inmultire = new Button();
            egal = new Button();
            adunare = new Button();
            impartire = new Button();
            scadere = new Button();
            SuspendLayout();
            // 
            // afisare
            // 
            afisare.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            afisare.ForeColor = SystemColors.WindowFrame;
            afisare.Location = new Point(12, 12);
            afisare.Multiline = true;
            afisare.Name = "afisare";
            afisare.ReadOnly = true;
            afisare.ScrollBars = ScrollBars.Vertical;
            afisare.Size = new Size(392, 106);
            afisare.TabIndex = 0;
            afisare.Text = "0";
            afisare.TextChanged += afisare_TextChanged;
            // 
            // numar1
            // 
            numar1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar1.Location = new Point(12, 395);
            numar1.Name = "numar1";
            numar1.Size = new Size(94, 84);
            numar1.TabIndex = 1;
            numar1.Text = "1";
            numar1.UseVisualStyleBackColor = true;
            numar1.Click += numar1_Click;
            // 
            // numar2
            // 
            numar2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar2.Location = new Point(112, 395);
            numar2.Name = "numar2";
            numar2.Size = new Size(94, 84);
            numar2.TabIndex = 2;
            numar2.Text = "2";
            numar2.UseVisualStyleBackColor = true;
            numar2.Click += numar2_Click;
            // 
            // numar3
            // 
            numar3.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar3.Location = new Point(212, 395);
            numar3.Name = "numar3";
            numar3.Size = new Size(94, 84);
            numar3.TabIndex = 4;
            numar3.Text = "3";
            numar3.UseVisualStyleBackColor = true;
            numar3.Click += numar3_Click;
            // 
            // numar4
            // 
            numar4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar4.Location = new Point(12, 305);
            numar4.Name = "numar4";
            numar4.Size = new Size(94, 84);
            numar4.TabIndex = 5;
            numar4.Text = "4";
            numar4.UseVisualStyleBackColor = true;
            numar4.Click += numar4_Click;
            // 
            // numar5
            // 
            numar5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar5.Location = new Point(112, 305);
            numar5.Name = "numar5";
            numar5.Size = new Size(94, 84);
            numar5.TabIndex = 6;
            numar5.Text = "5";
            numar5.UseVisualStyleBackColor = true;
            numar5.Click += numar5_Click;
            // 
            // numar6
            // 
            numar6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar6.Location = new Point(212, 305);
            numar6.Name = "numar6";
            numar6.Size = new Size(94, 84);
            numar6.TabIndex = 7;
            numar6.Text = "6";
            numar6.UseVisualStyleBackColor = true;
            numar6.Click += numar6_Click;
            // 
            // numar7
            // 
            numar7.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar7.Location = new Point(12, 215);
            numar7.Name = "numar7";
            numar7.Size = new Size(94, 84);
            numar7.TabIndex = 8;
            numar7.Text = "7";
            numar7.UseVisualStyleBackColor = true;
            numar7.Click += numar7_Click;
            // 
            // numar8
            // 
            numar8.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar8.Location = new Point(112, 215);
            numar8.Name = "numar8";
            numar8.Size = new Size(94, 84);
            numar8.TabIndex = 9;
            numar8.Text = "8";
            numar8.UseVisualStyleBackColor = true;
            numar8.Click += numar8_Click;
            // 
            // numar9
            // 
            numar9.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar9.Location = new Point(212, 215);
            numar9.Name = "numar9";
            numar9.Size = new Size(94, 84);
            numar9.TabIndex = 10;
            numar9.Text = "9";
            numar9.UseVisualStyleBackColor = true;
            numar9.Click += numar9_Click;
            // 
            // numar0
            // 
            numar0.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            numar0.Location = new Point(112, 485);
            numar0.Name = "numar0";
            numar0.Size = new Size(94, 84);
            numar0.TabIndex = 11;
            numar0.Text = "0";
            numar0.UseVisualStyleBackColor = true;
            numar0.Click += numar0_Click;
            // 
            // reset
            // 
            reset.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            reset.Location = new Point(12, 124);
            reset.Name = "reset";
            reset.Size = new Size(140, 85);
            reset.TabIndex = 12;
            reset.Text = "reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // undo
            // 
            undo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            undo.Location = new Point(158, 124);
            undo.Name = "undo";
            undo.Size = new Size(148, 85);
            undo.TabIndex = 13;
            undo.Text = "undo";
            undo.UseVisualStyleBackColor = true;
            undo.Click += undo_Click;
            // 
            // virgula
            // 
            virgula.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            virgula.Location = new Point(12, 484);
            virgula.Name = "virgula";
            virgula.Size = new Size(94, 85);
            virgula.TabIndex = 15;
            virgula.Text = ",";
            virgula.UseVisualStyleBackColor = true;
            virgula.Click += virgula_Click;
            // 
            // inmultire
            // 
            inmultire.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            inmultire.Location = new Point(310, 124);
            inmultire.Name = "inmultire";
            inmultire.Size = new Size(94, 85);
            inmultire.TabIndex = 16;
            inmultire.Text = "X";
            inmultire.UseVisualStyleBackColor = true;
            inmultire.Click += inmultire_Click;
            // 
            // egal
            // 
            egal.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            egal.Location = new Point(212, 484);
            egal.Name = "egal";
            egal.Size = new Size(192, 85);
            egal.TabIndex = 17;
            egal.Text = "=";
            egal.UseVisualStyleBackColor = true;
            egal.Click += egal_Click;
            // 
            // adunare
            // 
            adunare.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            adunare.Location = new Point(312, 305);
            adunare.Name = "adunare";
            adunare.Size = new Size(94, 84);
            adunare.TabIndex = 19;
            adunare.Text = "+";
            adunare.UseVisualStyleBackColor = true;
            adunare.Click += adunare_Click;
            // 
            // impartire
            // 
            impartire.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            impartire.Location = new Point(310, 215);
            impartire.Name = "impartire";
            impartire.Size = new Size(94, 84);
            impartire.TabIndex = 20;
            impartire.Text = "/";
            impartire.UseVisualStyleBackColor = true;
            impartire.Click += impartire_Click;
            // 
            // scadere
            // 
            scadere.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            scadere.Location = new Point(312, 395);
            scadere.Name = "scadere";
            scadere.Size = new Size(94, 83);
            scadere.TabIndex = 21;
            scadere.Text = "-";
            scadere.UseVisualStyleBackColor = true;
            scadere.Click += scadere_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 581);
            Controls.Add(scadere);
            Controls.Add(impartire);
            Controls.Add(adunare);
            Controls.Add(egal);
            Controls.Add(inmultire);
            Controls.Add(virgula);
            Controls.Add(undo);
            Controls.Add(reset);
            Controls.Add(numar0);
            Controls.Add(numar9);
            Controls.Add(numar8);
            Controls.Add(numar7);
            Controls.Add(numar6);
            Controls.Add(numar5);
            Controls.Add(numar4);
            Controls.Add(numar3);
            Controls.Add(numar2);
            Controls.Add(numar1);
            Controls.Add(afisare);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox afisare;
        private Button numar1;
        private Button numar2;
        private Button numar3;
        private Button numar4;
        private Button numar5;
        private Button numar6;
        private Button numar7;
        private Button numar8;
        private Button numar9;
        private Button numar0;
        private Button reset;
        private Button undo;
        private Button virgula;
        private Button inmultire;
        private Button egal;
        private Button adunare;
        private Button impartire;
        private Button scadere;
    }
}