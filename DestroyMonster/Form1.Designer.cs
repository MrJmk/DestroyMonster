namespace DestroyMonster
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ennemis = new System.Windows.Forms.GroupBox();
            this.niveau = new System.Windows.Forms.GroupBox();
            this.labelNiveau = new System.Windows.Forms.Label();
            this.numero2 = new System.Windows.Forms.GroupBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.moi = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelVie = new System.Windows.Forms.Label();
            this.numero1 = new System.Windows.Forms.GroupBox();
            this.labelNum2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.GroupBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.jouer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.ennemis.SuspendLayout();
            this.niveau.SuspendLayout();
            this.numero2.SuspendLayout();
            this.moi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.numero1.SuspendLayout();
            this.score.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(541, 302);
            this.webBrowser1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ennemis, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.moi, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 278);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ennemis
            // 
            this.ennemis.BackColor = System.Drawing.Color.Brown;
            this.ennemis.Controls.Add(this.niveau);
            this.ennemis.Controls.Add(this.numero2);
            this.ennemis.Font = new System.Drawing.Font("Jokerman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ennemis.Location = new System.Drawing.Point(3, 3);
            this.ennemis.Name = "ennemis";
            this.ennemis.Size = new System.Drawing.Size(511, 133);
            this.ennemis.TabIndex = 0;
            this.ennemis.TabStop = false;
            this.ennemis.Text = "Ennemis";
            // 
            // niveau
            // 
            this.niveau.Controls.Add(this.labelNiveau);
            this.niveau.Font = new System.Drawing.Font("Jokerman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niveau.Location = new System.Drawing.Point(278, 28);
            this.niveau.Name = "niveau";
            this.niveau.Size = new System.Drawing.Size(98, 99);
            this.niveau.TabIndex = 2;
            this.niveau.TabStop = false;
            this.niveau.Text = "Niveau";
            // 
            // labelNiveau
            // 
            this.labelNiveau.AutoSize = true;
            this.labelNiveau.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNiveau.Location = new System.Drawing.Point(19, 43);
            this.labelNiveau.Name = "labelNiveau";
            this.labelNiveau.Size = new System.Drawing.Size(34, 20);
            this.labelNiveau.TabIndex = 0;
            this.labelNiveau.Text = ".....";
            // 
            // numero2
            // 
            this.numero2.Controls.Add(this.labelNum);
            this.numero2.Font = new System.Drawing.Font("Jokerman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2.Location = new System.Drawing.Point(382, 28);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(123, 99);
            this.numero2.TabIndex = 1;
            this.numero2.TabStop = false;
            this.numero2.Text = "numéro dé";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Jokerman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.Location = new System.Drawing.Point(31, 28);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(47, 51);
            this.labelNum.TabIndex = 0;
            this.labelNum.Text = "0";
            // 
            // moi
            // 
            this.moi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moi.Controls.Add(this.groupBox1);
            this.moi.Controls.Add(this.numero1);
            this.moi.Controls.Add(this.score);
            this.moi.Controls.Add(this.jouer);
            this.moi.Font = new System.Drawing.Font("Harlow Solid Italic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moi.Location = new System.Drawing.Point(3, 142);
            this.moi.Name = "moi";
            this.moi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.moi.Size = new System.Drawing.Size(511, 133);
            this.moi.TabIndex = 1;
            this.moi.TabStop = false;
            this.moi.Text = "Moi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelVie);
            this.groupBox1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(218, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "niveau vie";
            // 
            // labelVie
            // 
            this.labelVie.AutoSize = true;
            this.labelVie.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVie.Location = new System.Drawing.Point(27, 30);
            this.labelVie.Name = "labelVie";
            this.labelVie.Size = new System.Drawing.Size(49, 61);
            this.labelVie.TabIndex = 1;
            this.labelVie.Text = "0";
            // 
            // numero1
            // 
            this.numero1.Controls.Add(this.labelNum2);
            this.numero1.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.Location = new System.Drawing.Point(100, 28);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(112, 99);
            this.numero1.TabIndex = 3;
            this.numero1.TabStop = false;
            this.numero1.Text = "numéro dé";
            // 
            // labelNum2
            // 
            this.labelNum2.AutoSize = true;
            this.labelNum2.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum2.Location = new System.Drawing.Point(30, 30);
            this.labelNum2.Name = "labelNum2";
            this.labelNum2.Size = new System.Drawing.Size(49, 61);
            this.labelNum2.TabIndex = 1;
            this.labelNum2.Text = "0";
            // 
            // score
            // 
            this.score.Controls.Add(this.labelScore);
            this.score.Font = new System.Drawing.Font("Harlow Solid Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(6, 28);
            this.score.Name = "score";
            this.score.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.score.Size = new System.Drawing.Size(88, 99);
            this.score.TabIndex = 2;
            this.score.TabStop = false;
            this.score.Text = "score";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Harlow Solid Italic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(16, 30);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(49, 61);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "0";
            // 
            // jouer
            // 
            this.jouer.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jouer.Location = new System.Drawing.Point(382, 51);
            this.jouer.Name = "jouer";
            this.jouer.Size = new System.Drawing.Size(87, 42);
            this.jouer.TabIndex = 1;
            this.jouer.Text = "Jouer";
            this.jouer.UseVisualStyleBackColor = true;
            this.jouer.Click += new System.EventHandler(this.Jouer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 302);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ennemis.ResumeLayout(false);
            this.niveau.ResumeLayout(false);
            this.niveau.PerformLayout();
            this.numero2.ResumeLayout(false);
            this.numero2.PerformLayout();
            this.moi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.numero1.ResumeLayout(false);
            this.numero1.PerformLayout();
            this.score.ResumeLayout(false);
            this.score.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox ennemis;
        private System.Windows.Forms.GroupBox moi;
        private System.Windows.Forms.Button jouer;
        private System.Windows.Forms.GroupBox score;
        private System.Windows.Forms.GroupBox numero2;
        private System.Windows.Forms.GroupBox numero1;
        private System.Windows.Forms.GroupBox niveau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNiveau;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelVie;
        private System.Windows.Forms.Label labelNum2;
        private System.Windows.Forms.Label labelScore;
    }
}

