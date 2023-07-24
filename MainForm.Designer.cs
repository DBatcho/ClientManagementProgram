
namespace C969_Project
{
    partial class MainForm
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
            this.CustomerRecordsButton = new System.Windows.Forms.Button();
            this.AppointmentsButton = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerRecordsButton
            // 
            this.CustomerRecordsButton.Location = new System.Drawing.Point(19, 79);
            this.CustomerRecordsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomerRecordsButton.Name = "CustomerRecordsButton";
            this.CustomerRecordsButton.Size = new System.Drawing.Size(163, 28);
            this.CustomerRecordsButton.TabIndex = 0;
            this.CustomerRecordsButton.Text = "Customer Records";
            this.CustomerRecordsButton.UseVisualStyleBackColor = true;
            this.CustomerRecordsButton.Click += new System.EventHandler(this.CustomerRecordsButton_Click);
            // 
            // AppointmentsButton
            // 
            this.AppointmentsButton.Location = new System.Drawing.Point(249, 79);
            this.AppointmentsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppointmentsButton.Name = "AppointmentsButton";
            this.AppointmentsButton.Size = new System.Drawing.Size(163, 28);
            this.AppointmentsButton.TabIndex = 1;
            this.AppointmentsButton.Text = "Appointments";
            this.AppointmentsButton.UseVisualStyleBackColor = true;
            this.AppointmentsButton.Click += new System.EventHandler(this.AppointmentsButton_Click);
            // 
            // CalendarButton
            // 
            this.CalendarButton.Location = new System.Drawing.Point(480, 79);
            this.CalendarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(163, 28);
            this.CalendarButton.TabIndex = 2;
            this.CalendarButton.Text = "Calendar";
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(282, 150);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 185);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalendarButton);
            this.Controls.Add(this.AppointmentsButton);
            this.Controls.Add(this.CustomerRecordsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CustomerRecordsButton;
        private System.Windows.Forms.Button AppointmentsButton;
        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Button ExitButton;
    }
}