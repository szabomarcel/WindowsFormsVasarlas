namespace WindowsFormsVasarlas
{
    partial class FormTermek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTermek));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown_crudid = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_cruddb = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_crudar = new System.Windows.Forms.NumericUpDown();
            this.textBox_crudnev = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crudid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cruddb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crudar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown_crudid
            // 
            this.numericUpDown_crudid.Location = new System.Drawing.Point(12, 52);
            this.numericUpDown_crudid.Name = "numericUpDown_crudid";
            this.numericUpDown_crudid.Size = new System.Drawing.Size(245, 20);
            this.numericUpDown_crudid.TabIndex = 1;
            // 
            // numericUpDown_cruddb
            // 
            this.numericUpDown_cruddb.Location = new System.Drawing.Point(12, 78);
            this.numericUpDown_cruddb.Name = "numericUpDown_cruddb";
            this.numericUpDown_cruddb.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_cruddb.TabIndex = 2;
            // 
            // numericUpDown_crudar
            // 
            this.numericUpDown_crudar.Location = new System.Drawing.Point(137, 78);
            this.numericUpDown_crudar.Name = "numericUpDown_crudar";
            this.numericUpDown_crudar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_crudar.TabIndex = 3;
            // 
            // textBox_crudnev
            // 
            this.textBox_crudnev.Location = new System.Drawing.Point(12, 26);
            this.textBox_crudnev.Name = "textBox_crudnev";
            this.textBox_crudnev.Size = new System.Drawing.Size(245, 20);
            this.textBox_crudnev.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rögzítés";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Egyéb módosítások";
            // 
            // FormTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(269, 166);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_crudnev);
            this.Controls.Add(this.numericUpDown_crudar);
            this.Controls.Add(this.numericUpDown_cruddb);
            this.Controls.Add(this.numericUpDown_crudid);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTermek";
            this.Text = "FormTermek";
            this.Load += new System.EventHandler(this.FormTermek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crudid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_cruddb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_crudar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_crudid;
        private System.Windows.Forms.NumericUpDown numericUpDown_cruddb;
        private System.Windows.Forms.NumericUpDown numericUpDown_crudar;
        private System.Windows.Forms.TextBox textBox_crudnev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}