namespace Pro_Dictionay
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Italiano = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lb_Ita = new System.Windows.Forms.ListBox();
            this.Lb_Eng = new System.Windows.Forms.ListBox();
            this.Lb_Esp = new System.Windows.Forms.ListBox();
            this.Lb_Fra = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.Button();
            this.txtselected = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Italiano
            // 
            this.Italiano.AutoSize = true;
            this.Italiano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Italiano.Location = new System.Drawing.Point(160, 157);
            this.Italiano.Name = "Italiano";
            this.Italiano.Size = new System.Drawing.Size(61, 20);
            this.Italiano.TabIndex = 0;
            this.Italiano.Text = "Italiano";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inglese";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Spagnolo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Francese";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(289, 91);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(126, 20);
            this.textBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(214, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cerca:";
            // 
            // Lb_Ita
            // 
            this.Lb_Ita.FormattingEnabled = true;
            this.Lb_Ita.HorizontalScrollbar = true;
            this.Lb_Ita.Location = new System.Drawing.Point(30, 180);
            this.Lb_Ita.Name = "Lb_Ita";
            this.Lb_Ita.Size = new System.Drawing.Size(313, 173);
            this.Lb_Ita.TabIndex = 6;
            this.Lb_Ita.SelectedIndexChanged += new System.EventHandler(this.Lb_Ita_SelectedIndexChanged);
            this.Lb_Ita.DoubleClick += new System.EventHandler(this.Lb_Ita_DoubleClick);
            // 
            // Lb_Eng
            // 
            this.Lb_Eng.FormattingEnabled = true;
            this.Lb_Eng.HorizontalScrollbar = true;
            this.Lb_Eng.Location = new System.Drawing.Point(30, 384);
            this.Lb_Eng.Name = "Lb_Eng";
            this.Lb_Eng.Size = new System.Drawing.Size(313, 173);
            this.Lb_Eng.TabIndex = 7;
            this.Lb_Eng.SelectedIndexChanged += new System.EventHandler(this.Lb_Eng_SelectedIndexChanged);
            this.Lb_Eng.DoubleClick += new System.EventHandler(this.Lb_Eng_DoubleClick);
            // 
            // Lb_Esp
            // 
            this.Lb_Esp.FormattingEnabled = true;
            this.Lb_Esp.HorizontalScrollbar = true;
            this.Lb_Esp.Location = new System.Drawing.Point(349, 180);
            this.Lb_Esp.Name = "Lb_Esp";
            this.Lb_Esp.Size = new System.Drawing.Size(313, 173);
            this.Lb_Esp.TabIndex = 8;
            this.Lb_Esp.SelectedIndexChanged += new System.EventHandler(this.Lb_Esp_SelectedIndexChanged);
            this.Lb_Esp.DoubleClick += new System.EventHandler(this.Lb_Esp_DoubleClick);
            // 
            // Lb_Fra
            // 
            this.Lb_Fra.FormattingEnabled = true;
            this.Lb_Fra.HorizontalScrollbar = true;
            this.Lb_Fra.Location = new System.Drawing.Point(349, 384);
            this.Lb_Fra.Name = "Lb_Fra";
            this.Lb_Fra.Size = new System.Drawing.Size(313, 173);
            this.Lb_Fra.TabIndex = 9;
            this.Lb_Fra.SelectedIndexChanged += new System.EventHandler(this.Lb_Fra_SelectedIndexChanged);
            this.Lb_Fra.DoubleClick += new System.EventHandler(this.Lb_Fra_DoubleClick);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(452, 89);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 10;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // txtselected
            // 
            this.txtselected.Location = new System.Drawing.Point(30, 617);
            this.txtselected.Name = "txtselected";
            this.txtselected.Size = new System.Drawing.Size(632, 20);
            this.txtselected.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(581, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 658);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtselected);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Lb_Fra);
            this.Controls.Add(this.Lb_Esp);
            this.Controls.Add(this.Lb_Eng);
            this.Controls.Add(this.Lb_Ita);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Italiano);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pro-Dictionary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Italiano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Lb_Ita;
        private System.Windows.Forms.ListBox Lb_Eng;
        private System.Windows.Forms.ListBox Lb_Esp;
        private System.Windows.Forms.ListBox Lb_Fra;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox txtselected;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

