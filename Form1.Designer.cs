
namespace GestionClient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchTerm = new System.Windows.Forms.TextBox();
            this.SearchBTN = new System.Windows.Forms.Button();
            this.AddClientBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 635);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchTerm
            // 
            this.SearchTerm.Location = new System.Drawing.Point(18, 18);
            this.SearchTerm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTerm.Name = "SearchTerm";
            this.SearchTerm.Size = new System.Drawing.Size(736, 26);
            this.SearchTerm.TabIndex = 1;
            // 
            // SearchBTN
            // 
            this.SearchBTN.Location = new System.Drawing.Point(765, 15);
            this.SearchBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBTN.Name = "SearchBTN";
            this.SearchBTN.Size = new System.Drawing.Size(112, 35);
            this.SearchBTN.TabIndex = 2;
            this.SearchBTN.Text = "Rechercher";
            this.SearchBTN.UseVisualStyleBackColor = true;
            this.SearchBTN.Click += new System.EventHandler(this.SearchBTN_Click);
            // 
            // AddClientBTN
            // 
            this.AddClientBTN.Location = new System.Drawing.Point(1010, 14);
            this.AddClientBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddClientBTN.Name = "AddClientBTN";
            this.AddClientBTN.Size = new System.Drawing.Size(172, 35);
            this.AddClientBTN.TabIndex = 3;
            this.AddClientBTN.Text = "Nouveau";
            this.AddClientBTN.UseVisualStyleBackColor = true;
            this.AddClientBTN.Click += new System.EventHandler(this.AddClientBTN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(886, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddClientBTN);
            this.Controls.Add(this.SearchBTN);
            this.Controls.Add(this.SearchTerm);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Gestionnaire de client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchTerm;
        private System.Windows.Forms.Button SearchBTN;
        private System.Windows.Forms.Button AddClientBTN;
        private System.Windows.Forms.Button button1;
    }
}