namespace Apollo
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
            this.checkbox_OverrideControl = new System.Windows.Forms.CheckBox();
            this.btn_ListeningControl = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbox_OverrideControl
            // 
            this.checkbox_OverrideControl.AutoSize = true;
            this.checkbox_OverrideControl.Location = new System.Drawing.Point(468, 29);
            this.checkbox_OverrideControl.Name = "checkbox_OverrideControl";
            this.checkbox_OverrideControl.Size = new System.Drawing.Size(285, 36);
            this.checkbox_OverrideControl.TabIndex = 0;
            this.checkbox_OverrideControl.Text = "Listening Override";
            this.checkbox_OverrideControl.UseVisualStyleBackColor = true;
            // 
            // btn_ListeningControl
            // 
            this.btn_ListeningControl.Location = new System.Drawing.Point(18, 118);
            this.btn_ListeningControl.Name = "btn_ListeningControl";
            this.btn_ListeningControl.Size = new System.Drawing.Size(163, 72);
            this.btn_ListeningControl.TabIndex = 1;
            this.btn_ListeningControl.Text = "Listening";
            this.btn_ListeningControl.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(12, 33);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(320, 32);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "Current Listening Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_ListeningControl);
            this.Controls.Add(this.checkbox_OverrideControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_OverrideControl;
        private System.Windows.Forms.Button btn_ListeningControl;
        private System.Windows.Forms.Label lbl_Status;
    }
}

