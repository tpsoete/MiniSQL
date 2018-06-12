namespace MiniSQL
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.buttonExec = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(67, 269);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(594, 25);
            this.textInput.TabIndex = 0;
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(67, 44);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutput.Size = new System.Drawing.Size(594, 201);
            this.textOutput.TabIndex = 1;
            this.textOutput.Text = "MiniSQL Test Version\r\nA+B Problem:\r\n";
            this.textOutput.TextChanged += new System.EventHandler(this.textOutput_TextChanged);
            // 
            // buttonExec
            // 
            this.buttonExec.Location = new System.Drawing.Point(500, 326);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(161, 64);
            this.buttonExec.TabIndex = 2;
            this.buttonExec.Text = "Execute";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(67, 326);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(161, 64);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonExec;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 489);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExec);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.Button buttonClear;
    }
}

