namespace MongoProject
{
    partial class PronadjiPredmetForm
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
            this.PronadjiPredmetBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brojPtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nazad = new System.Windows.Forms.Button();
            this.PrikazTuzilacBtn = new System.Windows.Forms.Button();
            this.PrikaziTuzenogBtn = new System.Windows.Forms.Button();
            this.PrikazAdvTuziocaBtn = new System.Windows.Forms.Button();
            this.PrikazAdvTuzenogBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RocistePogledPredmetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PronadjiPredmetBtn
            // 
            this.PronadjiPredmetBtn.BackColor = System.Drawing.Color.Tan;
            this.PronadjiPredmetBtn.FlatAppearance.BorderSize = 0;
            this.PronadjiPredmetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PronadjiPredmetBtn.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PronadjiPredmetBtn.Location = new System.Drawing.Point(608, 66);
            this.PronadjiPredmetBtn.Name = "PronadjiPredmetBtn";
            this.PronadjiPredmetBtn.Size = new System.Drawing.Size(104, 48);
            this.PronadjiPredmetBtn.TabIndex = 6;
            this.PronadjiPredmetBtn.Text = "Pronadji";
            this.PronadjiPredmetBtn.UseVisualStyleBackColor = false;
            this.PronadjiPredmetBtn.Click += new System.EventHandler(this.PronadjiPredmetBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::MongoProject.Properties.Resources._8b71e0fbb599213d6147baaf53a0959b;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(30, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 143);
            this.panel2.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(313, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(327, 33);
            this.label19.TabIndex = 2;
            this.label19.Text = "Pronadji trazeni predmet ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Broj predmeta";
            // 
            // brojPtxt
            // 
            this.brojPtxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.brojPtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brojPtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojPtxt.Location = new System.Drawing.Point(391, 68);
            this.brojPtxt.Multiline = true;
            this.brojPtxt.Name = "brojPtxt";
            this.brojPtxt.Size = new System.Drawing.Size(152, 37);
            this.brojPtxt.TabIndex = 9;
            this.brojPtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(793, 329);
            this.dataGridView1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(199, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 124);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaz svih predmeta";
            // 
            // Nazad
            // 
            this.Nazad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Nazad.BackColor = System.Drawing.Color.Tan;
            this.Nazad.FlatAppearance.BorderSize = 0;
            this.Nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nazad.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nazad.Location = new System.Drawing.Point(604, 520);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(179, 60);
            this.Nazad.TabIndex = 12;
            this.Nazad.Text = "Vrati se nazad";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // PrikazTuzilacBtn
            // 
            this.PrikazTuzilacBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PrikazTuzilacBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PrikazTuzilacBtn.FlatAppearance.BorderSize = 0;
            this.PrikazTuzilacBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikazTuzilacBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrikazTuzilacBtn.Location = new System.Drawing.Point(18, 641);
            this.PrikazTuzilacBtn.Name = "PrikazTuzilacBtn";
            this.PrikazTuzilacBtn.Size = new System.Drawing.Size(160, 60);
            this.PrikazTuzilacBtn.TabIndex = 13;
            this.PrikazTuzilacBtn.Text = "Prikazi Tuzioca";
            this.PrikazTuzilacBtn.UseVisualStyleBackColor = false;
            this.PrikazTuzilacBtn.Click += new System.EventHandler(this.PrikazTuzilacBtn_Click);
            // 
            // PrikaziTuzenogBtn
            // 
            this.PrikaziTuzenogBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PrikaziTuzenogBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PrikaziTuzenogBtn.FlatAppearance.BorderSize = 0;
            this.PrikaziTuzenogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikaziTuzenogBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrikaziTuzenogBtn.Location = new System.Drawing.Point(199, 641);
            this.PrikaziTuzenogBtn.Name = "PrikaziTuzenogBtn";
            this.PrikaziTuzenogBtn.Size = new System.Drawing.Size(176, 60);
            this.PrikaziTuzenogBtn.TabIndex = 14;
            this.PrikaziTuzenogBtn.Text = "Prikazi Tuzenog";
            this.PrikaziTuzenogBtn.UseVisualStyleBackColor = false;
            this.PrikaziTuzenogBtn.Click += new System.EventHandler(this.PrikaziTuzenogBtn_Click);
            // 
            // PrikazAdvTuziocaBtn
            // 
            this.PrikazAdvTuziocaBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PrikazAdvTuziocaBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PrikazAdvTuziocaBtn.FlatAppearance.BorderSize = 0;
            this.PrikazAdvTuziocaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikazAdvTuziocaBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrikazAdvTuziocaBtn.Location = new System.Drawing.Point(397, 641);
            this.PrikazAdvTuziocaBtn.Name = "PrikazAdvTuziocaBtn";
            this.PrikazAdvTuziocaBtn.Size = new System.Drawing.Size(190, 60);
            this.PrikazAdvTuziocaBtn.TabIndex = 15;
            this.PrikazAdvTuziocaBtn.Text = "Prikazi Advokata Tuzioca";
            this.PrikazAdvTuziocaBtn.UseVisualStyleBackColor = false;
            this.PrikazAdvTuziocaBtn.Click += new System.EventHandler(this.PrikazAdvTuziocaBtn_Click);
            // 
            // PrikazAdvTuzenogBtn
            // 
            this.PrikazAdvTuzenogBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PrikazAdvTuzenogBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PrikazAdvTuzenogBtn.FlatAppearance.BorderSize = 0;
            this.PrikazAdvTuzenogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikazAdvTuzenogBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrikazAdvTuzenogBtn.Location = new System.Drawing.Point(608, 641);
            this.PrikazAdvTuzenogBtn.Name = "PrikazAdvTuzenogBtn";
            this.PrikazAdvTuzenogBtn.Size = new System.Drawing.Size(185, 60);
            this.PrikazAdvTuzenogBtn.TabIndex = 16;
            this.PrikazAdvTuzenogBtn.Text = "Prikazi Advokata Tuzenog";
            this.PrikazAdvTuzenogBtn.UseVisualStyleBackColor = false;
            this.PrikazAdvTuzenogBtn.Click += new System.EventHandler(this.PrikazAdvTuzenogBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "Izaberi trazeni red za dalji prikaz";
            // 
            // RocistePogledPredmetBtn
            // 
            this.RocistePogledPredmetBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RocistePogledPredmetBtn.BackColor = System.Drawing.Color.Tan;
            this.RocistePogledPredmetBtn.FlatAppearance.BorderSize = 0;
            this.RocistePogledPredmetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RocistePogledPredmetBtn.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RocistePogledPredmetBtn.Location = new System.Drawing.Point(469, 563);
            this.RocistePogledPredmetBtn.Name = "RocistePogledPredmetBtn";
            this.RocistePogledPredmetBtn.Size = new System.Drawing.Size(129, 60);
            this.RocistePogledPredmetBtn.TabIndex = 18;
            this.RocistePogledPredmetBtn.Text = "Pogledaj predmet";
            this.RocistePogledPredmetBtn.UseVisualStyleBackColor = false;
            this.RocistePogledPredmetBtn.Click += new System.EventHandler(this.RocistePogledPredmetBtn_Click);
            // 
            // PronadjiPredmetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(817, 737);
            this.Controls.Add(this.RocistePogledPredmetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrikazAdvTuzenogBtn);
            this.Controls.Add(this.PrikazAdvTuziocaBtn);
            this.Controls.Add(this.PrikaziTuzenogBtn);
            this.Controls.Add(this.PrikazTuzilacBtn);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.brojPtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PronadjiPredmetBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PronadjiPredmetForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PronadjiPredmetBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brojPtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button PrikazTuzilacBtn;
        private System.Windows.Forms.Button PrikaziTuzenogBtn;
        private System.Windows.Forms.Button PrikazAdvTuziocaBtn;
        private System.Windows.Forms.Button PrikazAdvTuzenogBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RocistePogledPredmetBtn;
    }
}