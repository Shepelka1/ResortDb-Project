
namespace PresentationLayer
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Read_Btn = new System.Windows.Forms.Button();
            this.Create_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Phone_TxtBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name_TxtBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.Delete_Btn.Location = new System.Drawing.Point(527, 223);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(75, 28);
            this.Delete_Btn.TabIndex = 12;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Update_Btn
            // 
            this.Update_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.Update_Btn.Location = new System.Drawing.Point(440, 223);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(75, 28);
            this.Update_Btn.TabIndex = 11;
            this.Update_Btn.Text = "Update";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // Read_Btn
            // 
            this.Read_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.Read_Btn.Location = new System.Drawing.Point(352, 223);
            this.Read_Btn.Name = "Read_Btn";
            this.Read_Btn.Size = new System.Drawing.Size(75, 28);
            this.Read_Btn.TabIndex = 10;
            this.Read_Btn.Text = "Find";
            this.Read_Btn.UseVisualStyleBackColor = true;
            this.Read_Btn.Click += new System.EventHandler(this.Read_Btn_Click);
            // 
            // Create_Btn
            // 
            this.Create_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.Create_Btn.Location = new System.Drawing.Point(263, 223);
            this.Create_Btn.Name = "Create_Btn";
            this.Create_Btn.Size = new System.Drawing.Size(75, 28);
            this.Create_Btn.TabIndex = 9;
            this.Create_Btn.Text = "Create";
            this.Create_Btn.UseVisualStyleBackColor = true;
            this.Create_Btn.Click += new System.EventHandler(this.Create_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Phone Number:";
            // 
            // Phone_TxtBox
            // 
            this.Phone_TxtBox.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.Phone_TxtBox.Location = new System.Drawing.Point(46, 189);
            this.Phone_TxtBox.Name = "Phone_TxtBox";
            this.Phone_TxtBox.Size = new System.Drawing.Size(200, 29);
            this.Phone_TxtBox.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 194);
            this.dataGridView1.TabIndex = 15;
            // 
            // Name_TxtBox
            // 
            this.Name_TxtBox.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.Name_TxtBox.Location = new System.Drawing.Point(46, 102);
            this.Name_TxtBox.Name = "Name_TxtBox";
            this.Name_TxtBox.Size = new System.Drawing.Size(200, 29);
            this.Name_TxtBox.TabIndex = 17;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Black;
            this.labelName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(121, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Name:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.Black;
            this.ResultLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(392, 261);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(82, 53);
            this.ResultLabel.TabIndex = 18;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.Client;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 330);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Name_TxtBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Phone_TxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.Read_Btn);
            this.Controls.Add(this.Create_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Text = "Resort Manager 2000 - Clients";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Button Read_Btn;
        private System.Windows.Forms.Button Create_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Phone_TxtBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Name_TxtBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label ResultLabel;
    }
}