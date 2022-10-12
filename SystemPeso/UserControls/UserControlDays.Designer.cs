
namespace SystemPeso.UserControls
{
    partial class UserControlDays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DaysLbl = new System.Windows.Forms.Label();
            this.EventLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DaysLbl
            // 
            this.DaysLbl.AutoSize = true;
            this.DaysLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysLbl.Location = new System.Drawing.Point(12, 9);
            this.DaysLbl.Name = "DaysLbl";
            this.DaysLbl.Size = new System.Drawing.Size(27, 20);
            this.DaysLbl.TabIndex = 0;
            this.DaysLbl.Text = "00";
            // 
            // EventLbl
            // 
            this.EventLbl.Location = new System.Drawing.Point(0, 29);
            this.EventLbl.Name = "EventLbl";
            this.EventLbl.Size = new System.Drawing.Size(104, 39);
            this.EventLbl.TabIndex = 1;
            this.EventLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.EventLbl);
            this.Controls.Add(this.DaysLbl);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(104, 68);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DaysLbl;
        private System.Windows.Forms.Label EventLbl;
        private System.Windows.Forms.Timer timer1;
    }
}
