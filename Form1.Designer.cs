
namespace Motorcycle_Gear
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
            this.helmet_Cost = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Helmet = new System.Windows.Forms.Label();
            this.Jacket = new System.Windows.Forms.Label();
            this.jacket_Cost = new System.Windows.Forms.TextBox();
            this.Gloves = new System.Windows.Forms.Label();
            this.gloves_Cost = new System.Windows.Forms.TextBox();
            this.Pants = new System.Windows.Forms.Label();
            this.pants_Cost = new System.Windows.Forms.TextBox();
            this.Boots = new System.Windows.Forms.Label();
            this.boots_Cost = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.f = new System.Windows.Forms.Label();
            this.final_Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // helmet_Cost
            // 
            this.helmet_Cost.Location = new System.Drawing.Point(504, 39);
            this.helmet_Cost.Name = "helmet_Cost";
            this.helmet_Cost.Size = new System.Drawing.Size(100, 20);
            this.helmet_Cost.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Motorcycle_Gear.Properties.Resources._2020_imc_challengerdrkhrs_7_4205504157;
            this.pictureBox2.Location = new System.Drawing.Point(0, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Motorcycle_Gear.Properties.Resources.maxresdefault_1885435132;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(413, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Helmet
            // 
            this.Helmet.AutoSize = true;
            this.Helmet.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helmet.Location = new System.Drawing.Point(427, 34);
            this.Helmet.Name = "Helmet";
            this.Helmet.Size = new System.Drawing.Size(71, 23);
            this.Helmet.TabIndex = 3;
            this.Helmet.Text = "Helmet:";
            this.Helmet.Click += new System.EventHandler(this.Helmet_Click);
            // 
            // Jacket
            // 
            this.Jacket.AutoSize = true;
            this.Jacket.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jacket.Location = new System.Drawing.Point(427, 80);
            this.Jacket.Name = "Jacket";
            this.Jacket.Size = new System.Drawing.Size(64, 23);
            this.Jacket.TabIndex = 5;
            this.Jacket.Text = "Jacket:";
            // 
            // jacket_Cost
            // 
            this.jacket_Cost.Location = new System.Drawing.Point(504, 83);
            this.jacket_Cost.Name = "jacket_Cost";
            this.jacket_Cost.Size = new System.Drawing.Size(100, 20);
            this.jacket_Cost.TabIndex = 4;
            // 
            // Gloves
            // 
            this.Gloves.AutoSize = true;
            this.Gloves.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gloves.Location = new System.Drawing.Point(427, 128);
            this.Gloves.Name = "Gloves";
            this.Gloves.Size = new System.Drawing.Size(65, 23);
            this.Gloves.TabIndex = 7;
            this.Gloves.Text = "Gloves:";
            // 
            // gloves_Cost
            // 
            this.gloves_Cost.Location = new System.Drawing.Point(504, 133);
            this.gloves_Cost.Name = "gloves_Cost";
            this.gloves_Cost.Size = new System.Drawing.Size(100, 20);
            this.gloves_Cost.TabIndex = 6;
            // 
            // Pants
            // 
            this.Pants.AutoSize = true;
            this.Pants.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pants.Location = new System.Drawing.Point(427, 179);
            this.Pants.Name = "Pants";
            this.Pants.Size = new System.Drawing.Size(59, 23);
            this.Pants.TabIndex = 9;
            this.Pants.Text = "Pants:";
            // 
            // pants_Cost
            // 
            this.pants_Cost.Location = new System.Drawing.Point(504, 179);
            this.pants_Cost.Name = "pants_Cost";
            this.pants_Cost.Size = new System.Drawing.Size(100, 20);
            this.pants_Cost.TabIndex = 8;
            // 
            // Boots
            // 
            this.Boots.AutoSize = true;
            this.Boots.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boots.Location = new System.Drawing.Point(427, 223);
            this.Boots.Name = "Boots";
            this.Boots.Size = new System.Drawing.Size(60, 23);
            this.Boots.TabIndex = 11;
            this.Boots.Text = "Boots:";
            // 
            // boots_Cost
            // 
            this.boots_Cost.Location = new System.Drawing.Point(504, 223);
            this.boots_Cost.Name = "boots_Cost";
            this.boots_Cost.Size = new System.Drawing.Size(100, 20);
            this.boots_Cost.TabIndex = 10;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(528, 346);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(99, 37);
            this.calculate.TabIndex = 14;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f.Location = new System.Drawing.Point(427, 268);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(95, 23);
            this.f.TabIndex = 16;
            this.f.Text = "Final Total:";
            // 
            // final_Total
            // 
            this.final_Total.Location = new System.Drawing.Point(528, 268);
            this.final_Total.Name = "final_Total";
            this.final_Total.Size = new System.Drawing.Size(100, 20);
            this.final_Total.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "*Taxes not Included";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(648, 100);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 17);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Link to my Tax Calculator";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f);
            this.Controls.Add(this.final_Total);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.Boots);
            this.Controls.Add(this.boots_Cost);
            this.Controls.Add(this.Pants);
            this.Controls.Add(this.pants_Cost);
            this.Controls.Add(this.Gloves);
            this.Controls.Add(this.gloves_Cost);
            this.Controls.Add(this.Jacket);
            this.Controls.Add(this.jacket_Cost);
            this.Controls.Add(this.Helmet);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.helmet_Cost);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox helmet_Cost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Helmet;
        private System.Windows.Forms.Label Jacket;
        private System.Windows.Forms.TextBox jacket_Cost;
        private System.Windows.Forms.Label Gloves;
        private System.Windows.Forms.TextBox gloves_Cost;
        private System.Windows.Forms.Label Pants;
        private System.Windows.Forms.TextBox pants_Cost;
        private System.Windows.Forms.Label Boots;
        private System.Windows.Forms.TextBox boots_Cost;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.TextBox final_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

