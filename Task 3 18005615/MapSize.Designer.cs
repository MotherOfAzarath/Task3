namespace Task_3_18005615
{
    partial class MapSize
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
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(282, 161);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(159, 60);
            this.btn10.TabIndex = 0;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(282, 248);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(159, 60);
            this.btn20.TabIndex = 1;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(282, 342);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(159, 60);
            this.btn30.TabIndex = 2;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please choose a map size";
            // 
            // MapSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Name = "MapSize";
            this.Text = "MapSize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Label label2;
    }
}