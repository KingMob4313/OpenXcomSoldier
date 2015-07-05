namespace SoldierGen
{
	partial class SoldierGen
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
            this.SelectXLSX = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.hoursArrivalLabel = new System.Windows.Forms.Label();
            this.hoursArrivalTextBox = new System.Windows.Forms.TextBox();
            this.inTransitCheckBox = new System.Windows.Forms.CheckBox();
            this.setArrivalTimeButton = new System.Windows.Forms.Button();
            this.Control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectXLSX
            // 
            this.SelectXLSX.Location = new System.Drawing.Point(11, 10);
            this.SelectXLSX.Name = "SelectXLSX";
            this.SelectXLSX.Size = new System.Drawing.Size(75, 23);
            this.SelectXLSX.TabIndex = 0;
            this.SelectXLSX.Text = "Select Excel File";
            this.SelectXLSX.UseVisualStyleBackColor = true;
            this.SelectXLSX.Click += new System.EventHandler(this.SelectXLSX_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(437, 20);
            this.textBox1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Control
            // 
            this.Control.Controls.Add(this.tabPage1);
            this.Control.Controls.Add(this.tabPage2);
            this.Control.Location = new System.Drawing.Point(0, 2);
            this.Control.Name = "Control";
            this.Control.SelectedIndex = 0;
            this.Control.Size = new System.Drawing.Size(545, 350);
            this.Control.TabIndex = 5;
            this.Control.Tag = "Test";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.setArrivalTimeButton);
            this.tabPage1.Controls.Add(this.inTransitCheckBox);
            this.tabPage1.Controls.Add(this.hoursArrivalLabel);
            this.tabPage1.Controls.Add(this.hoursArrivalTextBox);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.SelectXLSX);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Team1",
            "Team2",
            "Team3",
            "Team4"});
            this.listBox1.Location = new System.Drawing.Point(92, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teams";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SoldierCount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.copyButton);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(528, 283);
            this.textBox3.TabIndex = 0;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(406, 296);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(123, 23);
            this.copyButton.TabIndex = 1;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // hoursArrivalLabel
            // 
            this.hoursArrivalLabel.AutoSize = true;
            this.hoursArrivalLabel.Location = new System.Drawing.Point(19, 298);
            this.hoursArrivalLabel.Name = "hoursArrivalLabel";
            this.hoursArrivalLabel.Size = new System.Drawing.Size(62, 13);
            this.hoursArrivalLabel.TabIndex = 7;
            this.hoursArrivalLabel.Text = "Arrival Time";
            // 
            // hoursArrivalTextBox
            // 
            this.hoursArrivalTextBox.Location = new System.Drawing.Point(92, 295);
            this.hoursArrivalTextBox.MaxLength = 2;
            this.hoursArrivalTextBox.Name = "hoursArrivalTextBox";
            this.hoursArrivalTextBox.ReadOnly = true;
            this.hoursArrivalTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoursArrivalTextBox.TabIndex = 6;
            this.hoursArrivalTextBox.Text = "24";
            // 
            // inTransitCheckBox
            // 
            this.inTransitCheckBox.AutoSize = true;
            this.inTransitCheckBox.Location = new System.Drawing.Point(22, 272);
            this.inTransitCheckBox.Name = "inTransitCheckBox";
            this.inTransitCheckBox.Size = new System.Drawing.Size(70, 17);
            this.inTransitCheckBox.TabIndex = 8;
            this.inTransitCheckBox.Text = "In Transit";
            this.inTransitCheckBox.UseVisualStyleBackColor = true;
            this.inTransitCheckBox.CheckedChanged += new System.EventHandler(this.inTransitCheckBox_CheckedChanged);
            // 
            // setArrivalTimeButton
            // 
            this.setArrivalTimeButton.Enabled = false;
            this.setArrivalTimeButton.Location = new System.Drawing.Point(198, 293);
            this.setArrivalTimeButton.Name = "setArrivalTimeButton";
            this.setArrivalTimeButton.Size = new System.Drawing.Size(75, 23);
            this.setArrivalTimeButton.TabIndex = 9;
            this.setArrivalTimeButton.Text = "Set Time";
            this.setArrivalTimeButton.UseVisualStyleBackColor = true;
            this.setArrivalTimeButton.Click += new System.EventHandler(this.setArrivalTimeButton_Click);
            // 
            // SoldierGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 377);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.statusStrip1);
            this.Name = "SoldierGen";
            this.Text = "Form1";
            this.Control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SelectXLSX;
		private System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl Control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox inTransitCheckBox;
        private System.Windows.Forms.Label hoursArrivalLabel;
        private System.Windows.Forms.TextBox hoursArrivalTextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button setArrivalTimeButton;
	}
}

