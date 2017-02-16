namespace TextEncodeDecode
{
    partial class SimpleEncodeDecodeApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.EncodeLabel = new System.Windows.Forms.Label();
            this.DecodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Input";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(122, 25);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(385, 20);
            this.InputTextBox.TabIndex = 1;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(122, 82);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(75, 23);
            this.EncodeButton.TabIndex = 2;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.Encode_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(431, 82);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(75, 23);
            this.DecodeButton.TabIndex = 3;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.Decode_Click);
            // 
            // EncodeLabel
            // 
            this.EncodeLabel.AutoSize = true;
            this.EncodeLabel.Location = new System.Drawing.Point(53, 200);
            this.EncodeLabel.Name = "EncodeLabel";
            this.EncodeLabel.Size = new System.Drawing.Size(147, 13);
            this.EncodeLabel.TabIndex = 4;
            this.EncodeLabel.Text = "Encoded text will appear here";
            // 
            // DecodeLabel
            // 
            this.DecodeLabel.AutoSize = true;
            this.DecodeLabel.Location = new System.Drawing.Point(53, 234);
            this.DecodeLabel.Name = "DecodeLabel";
            this.DecodeLabel.Size = new System.Drawing.Size(148, 13);
            this.DecodeLabel.TabIndex = 5;
            this.DecodeLabel.Text = "Decoded text will appear here";
            // 
            // SimpleEncodeDecodeApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 376);
            this.Controls.Add(this.DecodeLabel);
            this.Controls.Add(this.EncodeLabel);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SimpleEncodeDecodeApp";
            this.Text = "SimpleEncodeDecodeApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Label EncodeLabel;
        private System.Windows.Forms.Label DecodeLabel;
    }
}

