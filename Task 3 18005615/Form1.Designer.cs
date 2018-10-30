namespace Task_3_18005615
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupDisplay = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnUnpause = new System.Windows.Forms.Button();
            this.rtbxOutput = new System.Windows.Forms.RichTextBox();
            this.rtbxOutput2 = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupDisplay
            // 
            this.groupDisplay.Location = new System.Drawing.Point(12, 12);
            this.groupDisplay.Name = "groupDisplay";
            this.groupDisplay.Size = new System.Drawing.Size(854, 556);
            this.groupDisplay.TabIndex = 0;
            this.groupDisplay.TabStop = false;
            this.groupDisplay.Text = "groupBox1";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(897, 182);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(140, 52);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnUnpause
            // 
            this.btnUnpause.Location = new System.Drawing.Point(1055, 182);
            this.btnUnpause.Name = "btnUnpause";
            this.btnUnpause.Size = new System.Drawing.Size(144, 52);
            this.btnUnpause.TabIndex = 2;
            this.btnUnpause.Text = "Unpause";
            this.btnUnpause.UseVisualStyleBackColor = true;
            this.btnUnpause.Click += new System.EventHandler(this.btnUnpause_Click);
            // 
            // rtbxOutput
            // 
            this.rtbxOutput.Location = new System.Drawing.Point(897, 106);
            this.rtbxOutput.Name = "rtbxOutput";
            this.rtbxOutput.Size = new System.Drawing.Size(100, 43);
            this.rtbxOutput.TabIndex = 3;
            this.rtbxOutput.Text = "";
            // 
            // rtbxOutput2
            // 
            this.rtbxOutput2.Location = new System.Drawing.Point(897, 259);
            this.rtbxOutput2.Name = "rtbxOutput2";
            this.rtbxOutput2.Size = new System.Drawing.Size(156, 271);
            this.rtbxOutput2.TabIndex = 4;
            this.rtbxOutput2.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1099, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 52);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1099, 385);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 52);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(897, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Turn:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbxOutput2);
            this.Controls.Add(this.rtbxOutput);
            this.Controls.Add(this.btnUnpause);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.groupDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupDisplay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnUnpause;
        private System.Windows.Forms.RichTextBox rtbxOutput;
        private System.Windows.Forms.RichTextBox rtbxOutput2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
    }
}

