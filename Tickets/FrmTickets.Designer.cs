namespace Tickets
{
    partial class FrmTickets
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
            this.BtnTickets = new System.Windows.Forms.Button();
            this.BtnElectricBill = new System.Windows.Forms.Button();
            this.BtnAverage = new System.Windows.Forms.Button();
            this.BtnGasBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTickets
            // 
            this.BtnTickets.Location = new System.Drawing.Point(73, 62);
            this.BtnTickets.Name = "BtnTickets";
            this.BtnTickets.Size = new System.Drawing.Size(227, 98);
            this.BtnTickets.TabIndex = 0;
            this.BtnTickets.Text = "Get Ticket Price";
            this.BtnTickets.UseVisualStyleBackColor = true;
            this.BtnTickets.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnElectricBill
            // 
            this.BtnElectricBill.Location = new System.Drawing.Point(404, 250);
            this.BtnElectricBill.Name = "BtnElectricBill";
            this.BtnElectricBill.Size = new System.Drawing.Size(237, 87);
            this.BtnElectricBill.TabIndex = 1;
            this.BtnElectricBill.Text = "Electric Bill";
            this.BtnElectricBill.UseVisualStyleBackColor = true;
            this.BtnElectricBill.Click += new System.EventHandler(this.BtnElectricBill_Click);
            // 
            // BtnAverage
            // 
            this.BtnAverage.Location = new System.Drawing.Point(404, 62);
            this.BtnAverage.Name = "BtnAverage";
            this.BtnAverage.Size = new System.Drawing.Size(237, 98);
            this.BtnAverage.TabIndex = 2;
            this.BtnAverage.Text = "Average";
            this.BtnAverage.UseVisualStyleBackColor = true;
            this.BtnAverage.Click += new System.EventHandler(this.BtnAverage_Click);
            // 
            // BtnGasBill
            // 
            this.BtnGasBill.Location = new System.Drawing.Point(73, 250);
            this.BtnGasBill.Name = "BtnGasBill";
            this.BtnGasBill.Size = new System.Drawing.Size(227, 87);
            this.BtnGasBill.TabIndex = 3;
            this.BtnGasBill.Text = "Gas Bill";
            this.BtnGasBill.UseVisualStyleBackColor = true;
            this.BtnGasBill.Click += new System.EventHandler(this.BtnGasBill_Click);
            // 
            // FrmTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGasBill);
            this.Controls.Add(this.BtnAverage);
            this.Controls.Add(this.BtnElectricBill);
            this.Controls.Add(this.BtnTickets);
            this.Name = "FrmTickets";
            this.Text = "Tickets";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTickets;
        private System.Windows.Forms.Button BtnElectricBill;
        private System.Windows.Forms.Button BtnAverage;
        private System.Windows.Forms.Button BtnGasBill;
    }
}

