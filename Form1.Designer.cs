namespace TP4_Formulaire
{
    partial class Form1
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
            this.pnlre = new System.Windows.Forms.Panel();
            this.pnlbu = new System.Windows.Forms.Panel();
            this.pnlco = new System.Windows.Forms.Panel();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnafficher = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlre.SuspendLayout();
            this.pnlbu.SuspendLayout();
            this.pnlco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlre
            // 
            this.pnlre.Controls.Add(this.lblId);
            this.pnlre.Controls.Add(this.lblprenom);
            this.pnlre.Controls.Add(this.lblnom);
            this.pnlre.Controls.Add(this.txtid);
            this.pnlre.Controls.Add(this.txtprenom);
            this.pnlre.Controls.Add(this.txtnom);
            this.pnlre.Location = new System.Drawing.Point(7, 9);
            this.pnlre.Name = "pnlre";
            this.pnlre.Size = new System.Drawing.Size(791, 105);
            this.pnlre.TabIndex = 0;
            // 
            // pnlbu
            // 
            this.pnlbu.Controls.Add(this.btnvalider);
            this.pnlbu.Controls.Add(this.btnannuler);
            this.pnlbu.Controls.Add(this.btnafficher);
            this.pnlbu.Controls.Add(this.btnsupprimer);
            this.pnlbu.Controls.Add(this.btnmodifier);
            this.pnlbu.Controls.Add(this.btnajouter);
            this.pnlbu.Location = new System.Drawing.Point(7, 419);
            this.pnlbu.Name = "pnlbu";
            this.pnlbu.Size = new System.Drawing.Size(791, 112);
            this.pnlbu.TabIndex = 1;
            // 
            // pnlco
            // 
            this.pnlco.Controls.Add(this.dgview);
            this.pnlco.Location = new System.Drawing.Point(5, 117);
            this.pnlco.Name = "pnlco";
            this.pnlco.Size = new System.Drawing.Size(791, 303);
            this.pnlco.TabIndex = 2;
            // 
            // dgview
            // 
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(2, 3);
            this.dgview.Name = "dgview";
            this.dgview.RowHeadersWidth = 51;
            this.dgview.RowTemplate.Height = 24;
            this.dgview.Size = new System.Drawing.Size(788, 299);
            this.dgview.TabIndex = 0;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(37, 35);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(96, 43);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(159, 35);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(96, 43);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(277, 35);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(96, 43);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(404, 35);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(96, 43);
            this.btnafficher.TabIndex = 3;
            this.btnafficher.Text = "afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click);
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(528, 35);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(96, 43);
            this.btnannuler.TabIndex = 4;
            this.btnannuler.Text = "annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(649, 35);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(96, 43);
            this.btnvalider.TabIndex = 5;
            this.btnvalider.Text = "valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(144, 12);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(196, 22);
            this.txtnom.TabIndex = 0;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(144, 40);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(196, 22);
            this.txtprenom.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(144, 68);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(196, 22);
            this.txtid.TabIndex = 2;
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(57, 24);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(42, 16);
            this.lblnom.TabIndex = 3;
            this.lblnom.Text = "Nom :";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(57, 46);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(60, 16);
            this.lblprenom.TabIndex = 4;
            this.lblprenom.Text = "Prénom :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(57, 74);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 16);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.pnlco);
            this.Controls.Add(this.pnlbu);
            this.Controls.Add(this.pnlre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlre.ResumeLayout(false);
            this.pnlre.PerformLayout();
            this.pnlbu.ResumeLayout(false);
            this.pnlco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlre;
        private System.Windows.Forms.Panel pnlbu;
        private System.Windows.Forms.Panel pnlco;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblprenom;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.DataGridView dgview;
    }
}

