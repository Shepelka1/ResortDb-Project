
namespace PresentationLayer
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.BarOrder_Btn = new System.Windows.Forms.Button();
            this.Client_Btn = new System.Windows.Forms.Button();
            this.RestaurantOrder_Btn = new System.Windows.Forms.Button();
            this.RoomReservation_Btn = new System.Windows.Forms.Button();
            this.SpaSession_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BarOrder_Btn
            // 
            this.BarOrder_Btn.BackColor = System.Drawing.SystemColors.WindowText;
            this.BarOrder_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarOrder_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BarOrder_Btn.Location = new System.Drawing.Point(99, 104);
            this.BarOrder_Btn.Name = "BarOrder_Btn";
            this.BarOrder_Btn.Size = new System.Drawing.Size(120, 254);
            this.BarOrder_Btn.TabIndex = 0;
            this.BarOrder_Btn.Text = "Bar orders";
            this.BarOrder_Btn.UseVisualStyleBackColor = false;
            this.BarOrder_Btn.Click += new System.EventHandler(this.BarOrder_Btn_Click);
            // 
            // Client_Btn
            // 
            this.Client_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_Btn.Location = new System.Drawing.Point(274, 104);
            this.Client_Btn.Name = "Client_Btn";
            this.Client_Btn.Size = new System.Drawing.Size(120, 254);
            this.Client_Btn.TabIndex = 1;
            this.Client_Btn.Text = "Clients";
            this.Client_Btn.UseVisualStyleBackColor = true;
            this.Client_Btn.Click += new System.EventHandler(this.Client_Btn_Click);
            // 
            // RestaurantOrder_Btn
            // 
            this.RestaurantOrder_Btn.BackColor = System.Drawing.SystemColors.MenuText;
            this.RestaurantOrder_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantOrder_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestaurantOrder_Btn.Location = new System.Drawing.Point(442, 104);
            this.RestaurantOrder_Btn.Name = "RestaurantOrder_Btn";
            this.RestaurantOrder_Btn.Size = new System.Drawing.Size(120, 254);
            this.RestaurantOrder_Btn.TabIndex = 2;
            this.RestaurantOrder_Btn.Text = "Restaurant\r\norders";
            this.RestaurantOrder_Btn.UseVisualStyleBackColor = false;
            this.RestaurantOrder_Btn.Click += new System.EventHandler(this.RestaurantOrder_Btn_Click);
            // 
            // RoomReservation_Btn
            // 
            this.RoomReservation_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomReservation_Btn.Location = new System.Drawing.Point(602, 104);
            this.RoomReservation_Btn.Name = "RoomReservation_Btn";
            this.RoomReservation_Btn.Size = new System.Drawing.Size(120, 254);
            this.RoomReservation_Btn.TabIndex = 3;
            this.RoomReservation_Btn.Text = "Room reservations";
            this.RoomReservation_Btn.UseVisualStyleBackColor = true;
            this.RoomReservation_Btn.Click += new System.EventHandler(this.RoomReservation_Btn_Click);
            // 
            // SpaSession_Btn
            // 
            this.SpaSession_Btn.BackColor = System.Drawing.SystemColors.MenuText;
            this.SpaSession_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaSession_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpaSession_Btn.Location = new System.Drawing.Point(777, 104);
            this.SpaSession_Btn.Name = "SpaSession_Btn";
            this.SpaSession_Btn.Size = new System.Drawing.Size(120, 254);
            this.SpaSession_Btn.TabIndex = 4;
            this.SpaSession_Btn.Text = "Spa sessions";
            this.SpaSession_Btn.UseVisualStyleBackColor = false;
            this.SpaSession_Btn.Click += new System.EventHandler(this.SpaSession_Btn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.unsplash_image_dkGWbAq0yAw;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.SpaSession_Btn);
            this.Controls.Add(this.RoomReservation_Btn);
            this.Controls.Add(this.RestaurantOrder_Btn);
            this.Controls.Add(this.Client_Btn);
            this.Controls.Add(this.BarOrder_Btn);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Resort Manager 2000";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BarOrder_Btn;
        private System.Windows.Forms.Button Client_Btn;
        private System.Windows.Forms.Button RestaurantOrder_Btn;
        private System.Windows.Forms.Button RoomReservation_Btn;
        private System.Windows.Forms.Button SpaSession_Btn;
    }
}

