namespace MongoProject
{
    partial class RocisteUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label19 = new System.Windows.Forms.Label();
            this.BrPredmetaTxt = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.NaslovLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rocisteGB = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UplataGB = new System.Windows.Forms.GroupBox();
            this.PostojecUplataLbl = new System.Windows.Forms.Label();
            this.UplataDGV = new System.Windows.Forms.DataGridView();
            this.NovaUplataGB = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UplataBrPredmetaTxt = new System.Windows.Forms.TextBox();
            this.placenoCB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PlatilacTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iznosTxt = new System.Windows.Forms.TextBox();
            this.PostojecaRB = new System.Windows.Forms.RadioButton();
            this.NovaRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PostUplBrPrTxt = new System.Windows.Forms.TextBox();
            this.PostUplGB = new System.Windows.Forms.GroupBox();
            this.PrikaziUplBtn = new System.Windows.Forms.Button();
            this.rocisteGB.SuspendLayout();
            this.UplataGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UplataDGV)).BeginInit();
            this.NovaUplataGB.SuspendLayout();
            this.PostUplGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(23, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(242, 28);
            this.label19.TabIndex = 2;
            this.label19.Text = "Unesite broj predmeta\r\n";
            // 
            // BrPredmetaTxt
            // 
            this.BrPredmetaTxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BrPredmetaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrPredmetaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrPredmetaTxt.Location = new System.Drawing.Point(345, 137);
            this.BrPredmetaTxt.Multiline = true;
            this.BrPredmetaTxt.Name = "BrPredmetaTxt";
            this.BrPredmetaTxt.Size = new System.Drawing.Size(152, 37);
            this.BrPredmetaTxt.TabIndex = 12;
            this.BrPredmetaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.Tan;
            this.OkBtn.FlatAppearance.BorderSize = 0;
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkBtn.Location = new System.Drawing.Point(771, 546);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(108, 60);
            this.OkBtn.TabIndex = 13;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // NaslovLbl
            // 
            this.NaslovLbl.AutoSize = true;
            this.NaslovLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NaslovLbl.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NaslovLbl.Location = new System.Drawing.Point(322, 40);
            this.NaslovLbl.Name = "NaslovLbl";
            this.NaslovLbl.Size = new System.Drawing.Size(309, 33);
            this.NaslovLbl.TabIndex = 15;
            this.NaslovLbl.Text = "Dodavanje novog ročišta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Datum ročišta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(345, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // rocisteGB
            // 
            this.rocisteGB.Controls.Add(this.panel3);
            this.rocisteGB.Controls.Add(this.label19);
            this.rocisteGB.Controls.Add(this.label3);
            this.rocisteGB.Controls.Add(this.BrPredmetaTxt);
            this.rocisteGB.Controls.Add(this.dateTimePicker1);
            this.rocisteGB.Location = new System.Drawing.Point(61, 90);
            this.rocisteGB.Name = "rocisteGB";
            this.rocisteGB.Size = new System.Drawing.Size(818, 369);
            this.rocisteGB.TabIndex = 18;
            this.rocisteGB.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::MongoProject.Properties.Resources.clipart_lawyer_5;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(555, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 342);
            this.panel3.TabIndex = 20;
            // 
            // UplataGB
            // 
            this.UplataGB.Controls.Add(this.PostUplGB);
            this.UplataGB.Controls.Add(this.NovaUplataGB);
            this.UplataGB.Controls.Add(this.PostojecaRB);
            this.UplataGB.Controls.Add(this.NovaRB);
            this.UplataGB.Controls.Add(this.label1);
            this.UplataGB.Location = new System.Drawing.Point(26, 123);
            this.UplataGB.Name = "UplataGB";
            this.UplataGB.Size = new System.Drawing.Size(844, 404);
            this.UplataGB.TabIndex = 19;
            this.UplataGB.TabStop = false;
            // 
            // PostojecUplataLbl
            // 
            this.PostojecUplataLbl.AutoSize = true;
            this.PostojecUplataLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostojecUplataLbl.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostojecUplataLbl.Location = new System.Drawing.Point(119, 18);
            this.PostojecUplataLbl.Name = "PostojecUplataLbl";
            this.PostojecUplataLbl.Size = new System.Drawing.Size(260, 28);
            this.PostojecUplataLbl.TabIndex = 22;
            this.PostojecUplataLbl.Text = "Izaberite trazenu uplatu";
            // 
            // UplataDGV
            // 
            this.UplataDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UplataDGV.Location = new System.Drawing.Point(11, 114);
            this.UplataDGV.Name = "UplataDGV";
            this.UplataDGV.RowHeadersWidth = 51;
            this.UplataDGV.RowTemplate.Height = 24;
            this.UplataDGV.Size = new System.Drawing.Size(441, 257);
            this.UplataDGV.TabIndex = 23;
            // 
            // NovaUplataGB
            // 
            this.NovaUplataGB.Controls.Add(this.label5);
            this.NovaUplataGB.Controls.Add(this.UplataBrPredmetaTxt);
            this.NovaUplataGB.Controls.Add(this.placenoCB);
            this.NovaUplataGB.Controls.Add(this.label4);
            this.NovaUplataGB.Controls.Add(this.PlatilacTxt);
            this.NovaUplataGB.Controls.Add(this.label2);
            this.NovaUplataGB.Controls.Add(this.iznosTxt);
            this.NovaUplataGB.Location = new System.Drawing.Point(21, 106);
            this.NovaUplataGB.Name = "NovaUplataGB";
            this.NovaUplataGB.Size = new System.Drawing.Size(351, 242);
            this.NovaUplataGB.TabIndex = 21;
            this.NovaUplataGB.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Broj predmeta";
            // 
            // UplataBrPredmetaTxt
            // 
            this.UplataBrPredmetaTxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.UplataBrPredmetaTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UplataBrPredmetaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UplataBrPredmetaTxt.Location = new System.Drawing.Point(193, 25);
            this.UplataBrPredmetaTxt.Multiline = true;
            this.UplataBrPredmetaTxt.Name = "UplataBrPredmetaTxt";
            this.UplataBrPredmetaTxt.Size = new System.Drawing.Size(152, 37);
            this.UplataBrPredmetaTxt.TabIndex = 22;
            this.UplataBrPredmetaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // placenoCB
            // 
            this.placenoCB.AutoSize = true;
            this.placenoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placenoCB.Location = new System.Drawing.Point(14, 182);
            this.placenoCB.Name = "placenoCB";
            this.placenoCB.Size = new System.Drawing.Size(101, 28);
            this.placenoCB.TabIndex = 21;
            this.placenoCB.Text = "Plaćeno";
            this.placenoCB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Platilac";
            // 
            // PlatilacTxt
            // 
            this.PlatilacTxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PlatilacTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlatilacTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatilacTxt.Location = new System.Drawing.Point(193, 129);
            this.PlatilacTxt.Multiline = true;
            this.PlatilacTxt.Name = "PlatilacTxt";
            this.PlatilacTxt.Size = new System.Drawing.Size(152, 37);
            this.PlatilacTxt.TabIndex = 20;
            this.PlatilacTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Iznos";
            // 
            // iznosTxt
            // 
            this.iznosTxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.iznosTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iznosTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iznosTxt.Location = new System.Drawing.Point(193, 81);
            this.iznosTxt.Multiline = true;
            this.iznosTxt.Name = "iznosTxt";
            this.iznosTxt.Size = new System.Drawing.Size(152, 37);
            this.iznosTxt.TabIndex = 18;
            this.iznosTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iznosTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iznosTxt_KeyPress);
            // 
            // PostojecaRB
            // 
            this.PostojecaRB.AutoSize = true;
            this.PostojecaRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostojecaRB.Location = new System.Drawing.Point(21, 55);
            this.PostojecaRB.Name = "PostojecaRB";
            this.PostojecaRB.Size = new System.Drawing.Size(168, 28);
            this.PostojecaRB.TabIndex = 20;
            this.PostojecaRB.TabStop = true;
            this.PostojecaRB.Text = "Postojeća uplata";
            this.PostojecaRB.UseVisualStyleBackColor = true;
            this.PostojecaRB.CheckedChanged += new System.EventHandler(this.PostojecaRB_CheckedChanged);
            // 
            // NovaRB
            // 
            this.NovaRB.AutoSize = true;
            this.NovaRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovaRB.Location = new System.Drawing.Point(21, 21);
            this.NovaRB.Name = "NovaRB";
            this.NovaRB.Size = new System.Drawing.Size(130, 28);
            this.NovaRB.TabIndex = 19;
            this.NovaRB.TabStop = true;
            this.NovaRB.Text = "Nova uplata";
            this.NovaRB.UseVisualStyleBackColor = true;
            this.NovaRB.CheckedChanged += new System.EventHandler(this.NovaRB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Broj predmeta";
            // 
            // PostUplBrPrTxt
            // 
            this.PostUplBrPrTxt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PostUplBrPrTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PostUplBrPrTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostUplBrPrTxt.Location = new System.Drawing.Point(184, 64);
            this.PostUplBrPrTxt.Multiline = true;
            this.PostUplBrPrTxt.Name = "PostUplBrPrTxt";
            this.PostUplBrPrTxt.Size = new System.Drawing.Size(135, 37);
            this.PostUplBrPrTxt.TabIndex = 24;
            this.PostUplBrPrTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PostUplGB
            // 
            this.PostUplGB.Controls.Add(this.PrikaziUplBtn);
            this.PostUplGB.Controls.Add(this.PostUplBrPrTxt);
            this.PostUplGB.Controls.Add(this.PostojecUplataLbl);
            this.PostUplGB.Controls.Add(this.label6);
            this.PostUplGB.Controls.Add(this.UplataDGV);
            this.PostUplGB.Location = new System.Drawing.Point(380, 18);
            this.PostUplGB.Name = "PostUplGB";
            this.PostUplGB.Size = new System.Drawing.Size(458, 380);
            this.PostUplGB.TabIndex = 20;
            this.PostUplGB.TabStop = false;
            // 
            // PrikaziUplBtn
            // 
            this.PrikaziUplBtn.BackColor = System.Drawing.Color.Tan;
            this.PrikaziUplBtn.FlatAppearance.BorderSize = 0;
            this.PrikaziUplBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrikaziUplBtn.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrikaziUplBtn.Location = new System.Drawing.Point(343, 64);
            this.PrikaziUplBtn.Name = "PrikaziUplBtn";
            this.PrikaziUplBtn.Size = new System.Drawing.Size(87, 37);
            this.PrikaziUplBtn.TabIndex = 20;
            this.PrikaziUplBtn.Text = "Prikazi";
            this.PrikaziUplBtn.UseVisualStyleBackColor = false;
            this.PrikaziUplBtn.Click += new System.EventHandler(this.PrikaziUplBtn_Click);
            // 
            // RocisteUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.UplataGB);
            this.Controls.Add(this.rocisteGB);
            this.Controls.Add(this.NaslovLbl);
            this.Controls.Add(this.OkBtn);
            this.Name = "RocisteUserControl";
            this.Size = new System.Drawing.Size(922, 620);
            this.rocisteGB.ResumeLayout(false);
            this.rocisteGB.PerformLayout();
            this.UplataGB.ResumeLayout(false);
            this.UplataGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UplataDGV)).EndInit();
            this.NovaUplataGB.ResumeLayout(false);
            this.NovaUplataGB.PerformLayout();
            this.PostUplGB.ResumeLayout(false);
            this.PostUplGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox BrPredmetaTxt;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label NaslovLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox rocisteGB;
        private System.Windows.Forms.GroupBox UplataGB;
        private System.Windows.Forms.RadioButton PostojecaRB;
        private System.Windows.Forms.RadioButton NovaRB;
        private System.Windows.Forms.TextBox iznosTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox NovaUplataGB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PlatilacTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView UplataDGV;
        private System.Windows.Forms.CheckBox placenoCB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PostojecUplataLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UplataBrPredmetaTxt;
        private System.Windows.Forms.GroupBox PostUplGB;
        private System.Windows.Forms.TextBox PostUplBrPrTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PrikaziUplBtn;
    }
}
