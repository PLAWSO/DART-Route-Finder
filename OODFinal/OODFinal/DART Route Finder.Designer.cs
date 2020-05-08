namespace OODFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentLocation = new System.Windows.Forms.ComboBox();
            this.destination = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.findRoute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentLocation
            // 
            this.currentLocation.FormattingEnabled = true;
            this.currentLocation.Items.AddRange(new object[] {
            "801 Grand",
            "Pappajohn Sculpture Park",
            "Central Library",
            "DMACC",
            "E 1st & S Ankeny",
            "SE Oralabor & SE Delaware",
            "Fairgrounds",
            "Capitol Hill",
            "Botanical Garden",
            "Des Moines International Airport",
            "Blank Park Zoo",
            "SE 14th & Army Post",
            "63rd & Grand",
            "Shops at Roosevelt",
            "Waveland"});
            this.currentLocation.Location = new System.Drawing.Point(12, 31);
            this.currentLocation.Name = "currentLocation";
            this.currentLocation.Size = new System.Drawing.Size(261, 21);
            this.currentLocation.TabIndex = 0;
            this.currentLocation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // destination
            // 
            this.destination.FormattingEnabled = true;
            this.destination.Items.AddRange(new object[] {
            "801 Grand",
            "Pappajohn Sculpture Park",
            "Central Library",
            "DMACC",
            "E 1st & S Ankeny",
            "SE Oralabor & SE Delaware",
            "Fairgrounds",
            "Capitol Hill",
            "Botanical Garden",
            "Des Moines International Airport",
            "Blank Park Zoo",
            "SE 14th & Army Post",
            "63rd & Grand",
            "Shops at Roosevelt",
            "Waveland"});
            this.destination.Location = new System.Drawing.Point(12, 77);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(261, 21);
            this.destination.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Current Location";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 13);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Destination";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // findRoute
            // 
            this.findRoute.Location = new System.Drawing.Point(198, 104);
            this.findRoute.Name = "findRoute";
            this.findRoute.Size = new System.Drawing.Size(75, 23);
            this.findRoute.TabIndex = 4;
            this.findRoute.Text = "Find Route";
            this.findRoute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 513);
            this.Controls.Add(this.findRoute);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.currentLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DART Route Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currentLocation;
        private System.Windows.Forms.ComboBox destination;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button findRoute;
    }
}

