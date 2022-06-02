namespace torpedo
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bForgat = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(22, 30);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(203, 213);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b1.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.White;
            this.b1.Location = new System.Drawing.Point(382, 25);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(132, 27);
            this.b1.TabIndex = 1;
            this.b1.Text = "Destroyer";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b2.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.Color.White;
            this.b2.Location = new System.Drawing.Point(382, 58);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(132, 27);
            this.b2.TabIndex = 2;
            this.b2.Text = "Submarine";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b3.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.Color.White;
            this.b3.Location = new System.Drawing.Point(382, 91);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(132, 25);
            this.b3.TabIndex = 4;
            this.b3.Text = "Cruiser";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b4.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.b4.ForeColor = System.Drawing.Color.White;
            this.b4.Location = new System.Drawing.Point(382, 122);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(132, 25);
            this.b4.TabIndex = 3;
            this.b4.Text = "Battleship";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // bForgat
            // 
            this.bForgat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bForgat.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.bForgat.ForeColor = System.Drawing.Color.White;
            this.bForgat.Location = new System.Drawing.Point(382, 184);
            this.bForgat.Name = "bForgat";
            this.bForgat.Size = new System.Drawing.Size(132, 59);
            this.bForgat.TabIndex = 5;
            this.bForgat.Text = "Forgatás";
            this.bForgat.UseVisualStyleBackColor = false;
            this.bForgat.Click += new System.EventHandler(this.bForgat_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.b5.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.b5.ForeColor = System.Drawing.Color.White;
            this.b5.Location = new System.Drawing.Point(382, 153);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(132, 25);
            this.b5.TabIndex = 6;
            this.b5.Text = "Carrier";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 354);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.bForgat);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Torpedo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button bForgat;
        private System.Windows.Forms.Button b5;
    }
}

