﻿namespace FirstTry
{
    partial class Adminhuvudsida
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
            this.buttonTillHuvudsida = new System.Windows.Forms.Button();
            this.LabelOppen = new System.Windows.Forms.Label();
            this.buttonLoggaUt = new System.Windows.Forms.Button();
            this.listBoxForestallning = new System.Windows.Forms.ListBox();
            this.listBoxAkt = new System.Windows.Forms.ListBox();
            this.labelForestallning = new System.Windows.Forms.Label();
            this.labelForestallningsinfo = new System.Windows.Forms.Label();
            this.labelTillhorandeAkter = new System.Windows.Forms.Label();
            this.labelAktInfo = new System.Windows.Forms.Label();
            this.richTextBoxForestallning = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAkter = new System.Windows.Forms.RichTextBox();
            this.buttonNyForestallning = new System.Windows.Forms.Button();
            this.buttonUppdateraForest = new System.Windows.Forms.Button();
            this.buttonTaBortForest = new System.Windows.Forms.Button();
            this.buttonOppnaForsaljning = new System.Windows.Forms.Button();
            this.buttonSkapaNyAkt = new System.Windows.Forms.Button();
            this.buttonUppdateraAkt = new System.Windows.Forms.Button();
            this.buttonTaBortAkt = new System.Windows.Forms.Button();
            this.buttonRapporter = new System.Windows.Forms.Button();
            this.buttonAndraBehorighet = new System.Windows.Forms.Button();
            this.buttonAdminhuvudsida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTillHuvudsida
            // 
            this.buttonTillHuvudsida.Location = new System.Drawing.Point(37, 9);
            this.buttonTillHuvudsida.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTillHuvudsida.Name = "buttonTillHuvudsida";
            this.buttonTillHuvudsida.Size = new System.Drawing.Size(179, 37);
            this.buttonTillHuvudsida.TabIndex = 0;
            this.buttonTillHuvudsida.Text = "Till huvudsidan";
            this.buttonTillHuvudsida.UseVisualStyleBackColor = true;
            this.buttonTillHuvudsida.Click += new System.EventHandler(this.buttonTillHuvudsida_Click);
            // 
            // LabelOppen
            // 
            this.LabelOppen.AutoSize = true;
            this.LabelOppen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOppen.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelOppen.Location = new System.Drawing.Point(40, 67);
            this.LabelOppen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOppen.Name = "LabelOppen";
            this.LabelOppen.Size = new System.Drawing.Size(352, 25);
            this.LabelOppen.TabIndex = 1;
            this.LabelOppen.Text = "Föreställningen är öppen för försäljning.";
            // 
            // buttonLoggaUt
            // 
            this.buttonLoggaUt.Location = new System.Drawing.Point(1030, 14);
            this.buttonLoggaUt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoggaUt.Name = "buttonLoggaUt";
            this.buttonLoggaUt.Size = new System.Drawing.Size(137, 32);
            this.buttonLoggaUt.TabIndex = 2;
            this.buttonLoggaUt.Text = "Logga ut";
            this.buttonLoggaUt.UseVisualStyleBackColor = true;
            this.buttonLoggaUt.Click += new System.EventHandler(this.buttonLoggaUt_Click);
            // 
            // listBoxForestallning
            // 
            this.listBoxForestallning.FormattingEnabled = true;
            this.listBoxForestallning.ItemHeight = 16;
            this.listBoxForestallning.Location = new System.Drawing.Point(39, 130);
            this.listBoxForestallning.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxForestallning.Name = "listBoxForestallning";
            this.listBoxForestallning.Size = new System.Drawing.Size(333, 484);
            this.listBoxForestallning.TabIndex = 3;
            this.listBoxForestallning.SelectedIndexChanged += new System.EventHandler(this.listBoxForestallning_SelectedIndexChanged);
            // 
            // listBoxAkt
            // 
            this.listBoxAkt.FormattingEnabled = true;
            this.listBoxAkt.ItemHeight = 16;
            this.listBoxAkt.Location = new System.Drawing.Point(635, 132);
            this.listBoxAkt.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxAkt.Name = "listBoxAkt";
            this.listBoxAkt.Size = new System.Drawing.Size(348, 484);
            this.listBoxAkt.TabIndex = 4;
            this.listBoxAkt.SelectedIndexChanged += new System.EventHandler(this.listBoxAkt_SelectedIndexChanged);
            // 
            // labelForestallning
            // 
            this.labelForestallning.AutoSize = true;
            this.labelForestallning.Location = new System.Drawing.Point(35, 103);
            this.labelForestallning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForestallning.Name = "labelForestallning";
            this.labelForestallning.Size = new System.Drawing.Size(102, 17);
            this.labelForestallning.TabIndex = 5;
            this.labelForestallning.Text = "Föreställningar";
            this.labelForestallning.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelForestallningsinfo
            // 
            this.labelForestallningsinfo.AutoSize = true;
            this.labelForestallningsinfo.Location = new System.Drawing.Point(396, 103);
            this.labelForestallningsinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForestallningsinfo.Name = "labelForestallningsinfo";
            this.labelForestallningsinfo.Size = new System.Drawing.Size(166, 17);
            this.labelForestallningsinfo.TabIndex = 6;
            this.labelForestallningsinfo.Text = "Föreställningsinformation";
            // 
            // labelTillhorandeAkter
            // 
            this.labelTillhorandeAkter.AutoSize = true;
            this.labelTillhorandeAkter.Location = new System.Drawing.Point(631, 103);
            this.labelTillhorandeAkter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTillhorandeAkter.Name = "labelTillhorandeAkter";
            this.labelTillhorandeAkter.Size = new System.Drawing.Size(115, 17);
            this.labelTillhorandeAkter.TabIndex = 7;
            this.labelTillhorandeAkter.Text = "Tillhörande akter";
            // 
            // labelAktInfo
            // 
            this.labelAktInfo.AutoSize = true;
            this.labelAktInfo.Location = new System.Drawing.Point(1008, 103);
            this.labelAktInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAktInfo.Name = "labelAktInfo";
            this.labelAktInfo.Size = new System.Drawing.Size(51, 17);
            this.labelAktInfo.TabIndex = 8;
            this.labelAktInfo.Text = "Aktinfo";
            // 
            // richTextBoxForestallning
            // 
            this.richTextBoxForestallning.Location = new System.Drawing.Point(400, 130);
            this.richTextBoxForestallning.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxForestallning.Name = "richTextBoxForestallning";
            this.richTextBoxForestallning.Size = new System.Drawing.Size(167, 237);
            this.richTextBoxForestallning.TabIndex = 9;
            this.richTextBoxForestallning.Text = "";
            // 
            // richTextBoxAkter
            // 
            this.richTextBoxAkter.Location = new System.Drawing.Point(1012, 132);
            this.richTextBoxAkter.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxAkter.Name = "richTextBoxAkter";
            this.richTextBoxAkter.Size = new System.Drawing.Size(167, 286);
            this.richTextBoxAkter.TabIndex = 10;
            this.richTextBoxAkter.Text = "";
            // 
            // buttonNyForestallning
            // 
            this.buttonNyForestallning.Location = new System.Drawing.Point(401, 375);
            this.buttonNyForestallning.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNyForestallning.Name = "buttonNyForestallning";
            this.buttonNyForestallning.Size = new System.Drawing.Size(167, 54);
            this.buttonNyForestallning.TabIndex = 11;
            this.buttonNyForestallning.Text = "Skapa ny föreställning";
            this.buttonNyForestallning.UseVisualStyleBackColor = true;
            this.buttonNyForestallning.Click += new System.EventHandler(this.buttonNyForestallning_Click);
            // 
            // buttonUppdateraForest
            // 
            this.buttonUppdateraForest.Location = new System.Drawing.Point(401, 437);
            this.buttonUppdateraForest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUppdateraForest.Name = "buttonUppdateraForest";
            this.buttonUppdateraForest.Size = new System.Drawing.Size(167, 54);
            this.buttonUppdateraForest.TabIndex = 12;
            this.buttonUppdateraForest.Text = "Uppdatera Föreställning";
            this.buttonUppdateraForest.UseVisualStyleBackColor = true;
            this.buttonUppdateraForest.Click += new System.EventHandler(this.buttonUppdateraForest_Click);
            // 
            // buttonTaBortForest
            // 
            this.buttonTaBortForest.Location = new System.Drawing.Point(401, 498);
            this.buttonTaBortForest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTaBortForest.Name = "buttonTaBortForest";
            this.buttonTaBortForest.Size = new System.Drawing.Size(167, 54);
            this.buttonTaBortForest.TabIndex = 13;
            this.buttonTaBortForest.Text = "Ta bort föreställning";
            this.buttonTaBortForest.UseVisualStyleBackColor = true;
            this.buttonTaBortForest.Click += new System.EventHandler(this.buttonTaBortForest_Click);
            // 
            // buttonOppnaForsaljning
            // 
            this.buttonOppnaForsaljning.Location = new System.Drawing.Point(401, 562);
            this.buttonOppnaForsaljning.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOppnaForsaljning.Name = "buttonOppnaForsaljning";
            this.buttonOppnaForsaljning.Size = new System.Drawing.Size(167, 54);
            this.buttonOppnaForsaljning.TabIndex = 14;
            this.buttonOppnaForsaljning.Text = "Öppna försäljning";
            this.buttonOppnaForsaljning.UseVisualStyleBackColor = true;
            this.buttonOppnaForsaljning.Click += new System.EventHandler(this.buttonOppnaForsaljning_Click);
            // 
            // buttonSkapaNyAkt
            // 
            this.buttonSkapaNyAkt.Location = new System.Drawing.Point(1013, 437);
            this.buttonSkapaNyAkt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSkapaNyAkt.Name = "buttonSkapaNyAkt";
            this.buttonSkapaNyAkt.Size = new System.Drawing.Size(167, 54);
            this.buttonSkapaNyAkt.TabIndex = 15;
            this.buttonSkapaNyAkt.Text = "Skapa ny akt";
            this.buttonSkapaNyAkt.UseVisualStyleBackColor = true;
            this.buttonSkapaNyAkt.Click += new System.EventHandler(this.buttonSkapaNyAkt_Click);
            // 
            // buttonUppdateraAkt
            // 
            this.buttonUppdateraAkt.Location = new System.Drawing.Point(1013, 501);
            this.buttonUppdateraAkt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUppdateraAkt.Name = "buttonUppdateraAkt";
            this.buttonUppdateraAkt.Size = new System.Drawing.Size(167, 54);
            this.buttonUppdateraAkt.TabIndex = 16;
            this.buttonUppdateraAkt.Text = "Uppdatera akt";
            this.buttonUppdateraAkt.UseVisualStyleBackColor = true;
            this.buttonUppdateraAkt.Click += new System.EventHandler(this.buttonUppdateraAkt_Click);
            // 
            // buttonTaBortAkt
            // 
            this.buttonTaBortAkt.Location = new System.Drawing.Point(1013, 562);
            this.buttonTaBortAkt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTaBortAkt.Name = "buttonTaBortAkt";
            this.buttonTaBortAkt.Size = new System.Drawing.Size(167, 54);
            this.buttonTaBortAkt.TabIndex = 17;
            this.buttonTaBortAkt.Text = "Ta bort akt";
            this.buttonTaBortAkt.UseVisualStyleBackColor = true;
            this.buttonTaBortAkt.Click += new System.EventHandler(this.buttonTaBortAkt_Click);
            // 
            // buttonRapporter
            // 
            this.buttonRapporter.Location = new System.Drawing.Point(586, 9);
            this.buttonRapporter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRapporter.Name = "buttonRapporter";
            this.buttonRapporter.Size = new System.Drawing.Size(167, 37);
            this.buttonRapporter.TabIndex = 18;
            this.buttonRapporter.Text = "Rapporter";
            this.buttonRapporter.UseVisualStyleBackColor = true;
            this.buttonRapporter.Click += new System.EventHandler(this.buttonRapporter_Click);
            // 
            // buttonAndraBehorighet
            // 
            this.buttonAndraBehorighet.Location = new System.Drawing.Point(411, 9);
            this.buttonAndraBehorighet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAndraBehorighet.Name = "buttonAndraBehorighet";
            this.buttonAndraBehorighet.Size = new System.Drawing.Size(167, 37);
            this.buttonAndraBehorighet.TabIndex = 19;
            this.buttonAndraBehorighet.Text = "Ändra behörighet";
            this.buttonAndraBehorighet.UseVisualStyleBackColor = true;
            this.buttonAndraBehorighet.Click += new System.EventHandler(this.buttonAndraBehorighet_Click);
            // 
            // buttonAdminhuvudsida
            // 
            this.buttonAdminhuvudsida.Location = new System.Drawing.Point(224, 9);
            this.buttonAdminhuvudsida.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdminhuvudsida.Name = "buttonAdminhuvudsida";
            this.buttonAdminhuvudsida.Size = new System.Drawing.Size(179, 37);
            this.buttonAdminhuvudsida.TabIndex = 20;
            this.buttonAdminhuvudsida.Text = "Administration";
            this.buttonAdminhuvudsida.UseVisualStyleBackColor = true;
            this.buttonAdminhuvudsida.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adminhuvudsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 710);
            this.Controls.Add(this.buttonAdminhuvudsida);
            this.Controls.Add(this.buttonAndraBehorighet);
            this.Controls.Add(this.buttonRapporter);
            this.Controls.Add(this.buttonTaBortAkt);
            this.Controls.Add(this.buttonUppdateraAkt);
            this.Controls.Add(this.buttonSkapaNyAkt);
            this.Controls.Add(this.buttonOppnaForsaljning);
            this.Controls.Add(this.buttonTaBortForest);
            this.Controls.Add(this.buttonUppdateraForest);
            this.Controls.Add(this.buttonNyForestallning);
            this.Controls.Add(this.richTextBoxAkter);
            this.Controls.Add(this.richTextBoxForestallning);
            this.Controls.Add(this.labelAktInfo);
            this.Controls.Add(this.labelTillhorandeAkter);
            this.Controls.Add(this.labelForestallningsinfo);
            this.Controls.Add(this.labelForestallning);
            this.Controls.Add(this.listBoxAkt);
            this.Controls.Add(this.listBoxForestallning);
            this.Controls.Add(this.buttonLoggaUt);
            this.Controls.Add(this.LabelOppen);
            this.Controls.Add(this.buttonTillHuvudsida);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Adminhuvudsida";
            this.Text = "Adminhuvudsida";
            this.Load += new System.EventHandler(this.Adminhuvudsida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTillHuvudsida;
        private System.Windows.Forms.Label LabelOppen;
        private System.Windows.Forms.Button buttonLoggaUt;
        private System.Windows.Forms.ListBox listBoxForestallning;
        private System.Windows.Forms.ListBox listBoxAkt;
        private System.Windows.Forms.Label labelForestallning;
        private System.Windows.Forms.Label labelForestallningsinfo;
        private System.Windows.Forms.Label labelTillhorandeAkter;
        private System.Windows.Forms.Label labelAktInfo;
        private System.Windows.Forms.RichTextBox richTextBoxForestallning;
        private System.Windows.Forms.RichTextBox richTextBoxAkter;
        private System.Windows.Forms.Button buttonNyForestallning;
        private System.Windows.Forms.Button buttonUppdateraForest;
        private System.Windows.Forms.Button buttonTaBortForest;
        private System.Windows.Forms.Button buttonOppnaForsaljning;
        private System.Windows.Forms.Button buttonSkapaNyAkt;
        private System.Windows.Forms.Button buttonUppdateraAkt;
        private System.Windows.Forms.Button buttonTaBortAkt;
        private System.Windows.Forms.Button buttonRapporter;
        private System.Windows.Forms.Button buttonAndraBehorighet;
        private System.Windows.Forms.Button buttonAdminhuvudsida;
    }
}