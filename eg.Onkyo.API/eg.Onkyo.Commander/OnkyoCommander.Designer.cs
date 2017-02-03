namespace eg.Onkyo.Commander
{
    partial class OnkyoCommander
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
            this.btnOnkyoInitiate = new System.Windows.Forms.Button();
            this.tbCommandText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVolumeNumber = new System.Windows.Forms.TextBox();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnkyoInitiate
            // 
            this.btnOnkyoInitiate.Location = new System.Drawing.Point(219, 238);
            this.btnOnkyoInitiate.Name = "btnOnkyoInitiate";
            this.btnOnkyoInitiate.Size = new System.Drawing.Size(61, 23);
            this.btnOnkyoInitiate.TabIndex = 0;
            this.btnOnkyoInitiate.Text = "Send";
            this.btnOnkyoInitiate.UseVisualStyleBackColor = true;
            this.btnOnkyoInitiate.Click += new System.EventHandler(this.btnOnkyoInitiate_Click);
            // 
            // tbCommandText
            // 
            this.tbCommandText.Location = new System.Drawing.Point(136, 238);
            this.tbCommandText.Name = "tbCommandText";
            this.tbCommandText.Size = new System.Drawing.Size(77, 20);
            this.tbCommandText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter custom command:";
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Location = new System.Drawing.Point(90, 44);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(24, 23);
            this.btnVolumeUp.TabIndex = 3;
            this.btnVolumeUp.Text = "+";
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Location = new System.Drawing.Point(60, 44);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(24, 23);
            this.btnVolumeDown.TabIndex = 4;
            this.btnVolumeDown.Text = "-";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Volume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter volume:";
            // 
            // tbVolumeNumber
            // 
            this.tbVolumeNumber.Location = new System.Drawing.Point(198, 46);
            this.tbVolumeNumber.Name = "tbVolumeNumber";
            this.tbVolumeNumber.Size = new System.Drawing.Size(43, 20);
            this.tbVolumeNumber.TabIndex = 7;
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(247, 44);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(34, 23);
            this.btnVolume.TabIndex = 8;
            this.btnVolume.Text = "Vol";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(60, 12);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(42, 23);
            this.btnOff.TabIndex = 9;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(12, 12);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(42, 23);
            this.btnOn.TabIndex = 10;
            this.btnOn.Text = "On";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // OnkyoCommander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.tbVolumeNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolumeDown);
            this.Controls.Add(this.btnVolumeUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCommandText);
            this.Controls.Add(this.btnOnkyoInitiate);
            this.Name = "OnkyoCommander";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnkyoInitiate;
        private System.Windows.Forms.TextBox tbCommandText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVolumeNumber;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnOn;
    }
}

