namespace DenisLoadTextBox
{
    partial class Form2
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
            this.labelForm2 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelForm2
            // 
            this.labelForm2.AutoSize = true;
            this.labelForm2.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm2.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelForm2.Location = new System.Drawing.Point(24, 9);
            this.labelForm2.Name = "labelForm2";
            this.labelForm2.Size = new System.Drawing.Size(112, 42);
            this.labelForm2.TabIndex = 0;
            this.labelForm2.Text = "Welcome";
            this.labelForm2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(31, 54);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(319, 112);
            this.textBoxMessage.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonCreate.Location = new System.Drawing.Point(31, 194);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(149, 49);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonExit.Location = new System.Drawing.Point(201, 194);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(149, 49);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(385, 286);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.labelForm2);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelForm2;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonExit;
    }
}