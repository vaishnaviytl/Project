namespace Project3
{
    partial class Offers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtoid = new System.Windows.Forms.TextBox();
            this.txtpsource = new System.Windows.Forms.TextBox();
            this.txtoffer = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OFFER ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(65, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DISCOUNT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(65, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PROMO SOURCE";
            // 
            // txtoid
            // 
            this.txtoid.Location = new System.Drawing.Point(207, 33);
            this.txtoid.Name = "txtoid";
            this.txtoid.Size = new System.Drawing.Size(100, 22);
            this.txtoid.TabIndex = 3;
            this.txtoid.TextChanged += new System.EventHandler(this.txtoid_TextChanged);
            // 
            // txtpsource
            // 
            this.txtpsource.Location = new System.Drawing.Point(207, 161);
            this.txtpsource.Name = "txtpsource";
            this.txtpsource.Size = new System.Drawing.Size(100, 22);
            this.txtpsource.TabIndex = 4;
            // 
            // txtoffer
            // 
            this.txtoffer.Location = new System.Drawing.Point(207, 99);
            this.txtoffer.Name = "txtoffer";
            this.txtoffer.Size = new System.Drawing.Size(100, 22);
            this.txtoffer.TabIndex = 5;
            this.txtoffer.TextChanged += new System.EventHandler(this.txtoffer_TextChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsubmit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnsubmit.Location = new System.Drawing.Point(207, 231);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(86, 40);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 363);
            this.dataGridView1.TabIndex = 7;
            // 
            // Offers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtoffer);
            this.Controls.Add(this.txtpsource);
            this.Controls.Add(this.txtoid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Offers";
            this.Text = "Offers";
            this.Load += new System.EventHandler(this.Offers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtoid;
        private System.Windows.Forms.TextBox txtpsource;
        private System.Windows.Forms.TextBox txtoffer;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}