namespace GradeCalculator
{
	partial class GradeCalculator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeCalculator));
			this.currentGradeBox = new System.Windows.Forms.TextBox();
			this.currentGradeLabel = new System.Windows.Forms.Label();
			this.currentGradeHelper = new System.Windows.Forms.ToolTip(this.components);
			this.weightedSystemYES = new System.Windows.Forms.RadioButton();
			this.weightedSystemNO = new System.Windows.Forms.RadioButton();
			this.weightedSystemLabel = new System.Windows.Forms.Label();
			this.weightedSystemHelper = new System.Windows.Forms.ToolTip(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.assignmentCategoryPercentLabel = new System.Windows.Forms.Label();
			this.assignmentPercentWeightBox = new System.Windows.Forms.TextBox();
			this.totalCategoryPercentLabel = new System.Windows.Forms.Label();
			this.totalCategoryPercentBox = new System.Windows.Forms.TextBox();
			this.totalPointsLabel = new System.Windows.Forms.Label();
			this.totalPointsBox = new System.Windows.Forms.TextBox();
			this.valueOfAssignmentBox = new System.Windows.Forms.TextBox();
			this.valueOfAssignmentLabel = new System.Windows.Forms.Label();
			this.desiredGradeBox = new System.Windows.Forms.TextBox();
			this.desiredGradeLabel = new System.Windows.Forms.Label();
			this.categoryOverallGradeBox = new System.Windows.Forms.TextBox();
			this.categoryOverallGradeLabel = new System.Windows.Forms.Label();
			this.gradeButton = new System.Windows.Forms.Button();
			this.assignmentWeightHelper = new System.Windows.Forms.ToolTip(this.components);
			this.totalCategoryPercentHelper = new System.Windows.Forms.ToolTip(this.components);
			this.totalPointsHelper = new System.Windows.Forms.ToolTip(this.components);
			this.valueOfAssignmentHelper = new System.Windows.Forms.ToolTip(this.components);
			this.desiredGradeHelper = new System.Windows.Forms.ToolTip(this.components);
			this.categoryOverallGradeHelper = new System.Windows.Forms.ToolTip(this.components);
			this.assignmentInEmptyCategoryLabel = new System.Windows.Forms.Label();
			this.assignmentInNewCategoryCheckBox = new System.Windows.Forms.CheckBox();
			this.assignmentEmptyCategoryHelper = new System.Windows.Forms.ToolTip(this.components);
			this.applicationMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetBox = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.applicationMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// currentGradeBox
			// 
			this.currentGradeBox.Location = new System.Drawing.Point(142, 39);
			this.currentGradeBox.Name = "currentGradeBox";
			this.currentGradeBox.Size = new System.Drawing.Size(100, 20);
			this.currentGradeBox.TabIndex = 0;
			// 
			// currentGradeLabel
			// 
			this.currentGradeLabel.AutoSize = true;
			this.currentGradeLabel.Location = new System.Drawing.Point(13, 42);
			this.currentGradeLabel.Name = "currentGradeLabel";
			this.currentGradeLabel.Size = new System.Drawing.Size(100, 13);
			this.currentGradeLabel.TabIndex = 1;
			this.currentGradeLabel.Text = "Input Current Grade";
			// 
			// currentGradeHelper
			// 
			this.currentGradeHelper.ShowAlways = true;
			// 
			// weightedSystemYES
			// 
			this.weightedSystemYES.AutoSize = true;
			this.weightedSystemYES.Location = new System.Drawing.Point(8, 3);
			this.weightedSystemYES.Name = "weightedSystemYES";
			this.weightedSystemYES.Size = new System.Drawing.Size(43, 17);
			this.weightedSystemYES.TabIndex = 2;
			this.weightedSystemYES.TabStop = true;
			this.weightedSystemYES.Text = "Yes";
			this.weightedSystemYES.UseVisualStyleBackColor = true;
			this.weightedSystemYES.CheckedChanged += new System.EventHandler(this.WeightedSystemYES_CheckedChanged);
			// 
			// weightedSystemNO
			// 
			this.weightedSystemNO.AutoSize = true;
			this.weightedSystemNO.Location = new System.Drawing.Point(57, 3);
			this.weightedSystemNO.Name = "weightedSystemNO";
			this.weightedSystemNO.Size = new System.Drawing.Size(39, 17);
			this.weightedSystemNO.TabIndex = 3;
			this.weightedSystemNO.TabStop = true;
			this.weightedSystemNO.Text = "No";
			this.weightedSystemNO.UseVisualStyleBackColor = true;
			this.weightedSystemNO.CheckedChanged += new System.EventHandler(this.WeightedSystemNO_CheckedChanged);
			// 
			// weightedSystemLabel
			// 
			this.weightedSystemLabel.AutoSize = true;
			this.weightedSystemLabel.Location = new System.Drawing.Point(13, 70);
			this.weightedSystemLabel.Name = "weightedSystemLabel";
			this.weightedSystemLabel.Size = new System.Drawing.Size(96, 13);
			this.weightedSystemLabel.TabIndex = 4;
			this.weightedSystemLabel.Text = "Weighted System?";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.weightedSystemYES);
			this.panel1.Controls.Add(this.weightedSystemNO);
			this.panel1.Location = new System.Drawing.Point(142, 65);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(110, 29);
			this.panel1.TabIndex = 5;
			// 
			// assignmentCategoryPercentLabel
			// 
			this.assignmentCategoryPercentLabel.AutoSize = true;
			this.assignmentCategoryPercentLabel.Location = new System.Drawing.Point(13, 113);
			this.assignmentCategoryPercentLabel.Name = "assignmentCategoryPercentLabel";
			this.assignmentCategoryPercentLabel.Size = new System.Drawing.Size(104, 13);
			this.assignmentCategoryPercentLabel.TabIndex = 6;
			this.assignmentCategoryPercentLabel.Text = "Assignment Weight?";
			// 
			// assignmentPercentWeightBox
			// 
			this.assignmentPercentWeightBox.Location = new System.Drawing.Point(142, 110);
			this.assignmentPercentWeightBox.Name = "assignmentPercentWeightBox";
			this.assignmentPercentWeightBox.Size = new System.Drawing.Size(100, 20);
			this.assignmentPercentWeightBox.TabIndex = 7;
			// 
			// totalCategoryPercentLabel
			// 
			this.totalCategoryPercentLabel.AutoSize = true;
			this.totalCategoryPercentLabel.Location = new System.Drawing.Point(13, 167);
			this.totalCategoryPercentLabel.Name = "totalCategoryPercentLabel";
			this.totalCategoryPercentLabel.Size = new System.Drawing.Size(117, 13);
			this.totalCategoryPercentLabel.TabIndex = 8;
			this.totalCategoryPercentLabel.Text = "Total Filled Categories?";
			// 
			// totalCategoryPercentBox
			// 
			this.totalCategoryPercentBox.Location = new System.Drawing.Point(142, 164);
			this.totalCategoryPercentBox.Name = "totalCategoryPercentBox";
			this.totalCategoryPercentBox.Size = new System.Drawing.Size(100, 20);
			this.totalCategoryPercentBox.TabIndex = 9;
			// 
			// totalPointsLabel
			// 
			this.totalPointsLabel.AutoSize = true;
			this.totalPointsLabel.Location = new System.Drawing.Point(13, 205);
			this.totalPointsLabel.Name = "totalPointsLabel";
			this.totalPointsLabel.Size = new System.Drawing.Size(108, 13);
			this.totalPointsLabel.TabIndex = 10;
			this.totalPointsLabel.Text = "Category Total Points";
			// 
			// totalPointsBox
			// 
			this.totalPointsBox.Location = new System.Drawing.Point(142, 202);
			this.totalPointsBox.Name = "totalPointsBox";
			this.totalPointsBox.Size = new System.Drawing.Size(100, 20);
			this.totalPointsBox.TabIndex = 11;
			// 
			// valueOfAssignmentBox
			// 
			this.valueOfAssignmentBox.Location = new System.Drawing.Point(142, 228);
			this.valueOfAssignmentBox.Name = "valueOfAssignmentBox";
			this.valueOfAssignmentBox.Size = new System.Drawing.Size(100, 20);
			this.valueOfAssignmentBox.TabIndex = 13;
			// 
			// valueOfAssignmentLabel
			// 
			this.valueOfAssignmentLabel.AutoSize = true;
			this.valueOfAssignmentLabel.Location = new System.Drawing.Point(13, 231);
			this.valueOfAssignmentLabel.Name = "valueOfAssignmentLabel";
			this.valueOfAssignmentLabel.Size = new System.Drawing.Size(103, 13);
			this.valueOfAssignmentLabel.TabIndex = 12;
			this.valueOfAssignmentLabel.Text = "Value of Assignment";
			// 
			// desiredGradeBox
			// 
			this.desiredGradeBox.Location = new System.Drawing.Point(142, 254);
			this.desiredGradeBox.Name = "desiredGradeBox";
			this.desiredGradeBox.Size = new System.Drawing.Size(100, 20);
			this.desiredGradeBox.TabIndex = 15;
			// 
			// desiredGradeLabel
			// 
			this.desiredGradeLabel.AutoSize = true;
			this.desiredGradeLabel.Location = new System.Drawing.Point(13, 257);
			this.desiredGradeLabel.Name = "desiredGradeLabel";
			this.desiredGradeLabel.Size = new System.Drawing.Size(75, 13);
			this.desiredGradeLabel.TabIndex = 14;
			this.desiredGradeLabel.Text = "Desired Grade";
			// 
			// categoryOverallGradeBox
			// 
			this.categoryOverallGradeBox.Location = new System.Drawing.Point(142, 280);
			this.categoryOverallGradeBox.Name = "categoryOverallGradeBox";
			this.categoryOverallGradeBox.Size = new System.Drawing.Size(100, 20);
			this.categoryOverallGradeBox.TabIndex = 17;
			// 
			// categoryOverallGradeLabel
			// 
			this.categoryOverallGradeLabel.AutoSize = true;
			this.categoryOverallGradeLabel.Location = new System.Drawing.Point(13, 283);
			this.categoryOverallGradeLabel.Name = "categoryOverallGradeLabel";
			this.categoryOverallGradeLabel.Size = new System.Drawing.Size(117, 13);
			this.categoryOverallGradeLabel.TabIndex = 16;
			this.categoryOverallGradeLabel.Text = "Category Overall Grade";
			// 
			// gradeButton
			// 
			this.gradeButton.Location = new System.Drawing.Point(16, 308);
			this.gradeButton.Name = "gradeButton";
			this.gradeButton.Size = new System.Drawing.Size(145, 63);
			this.gradeButton.TabIndex = 18;
			this.gradeButton.Text = "Calculate Grade";
			this.gradeButton.UseVisualStyleBackColor = true;
			this.gradeButton.Click += new System.EventHandler(this.GradeButton_Click);
			// 
			// assignmentWeightHelper
			// 
			this.assignmentWeightHelper.ShowAlways = true;
			// 
			// totalCategoryPercentHelper
			// 
			this.totalCategoryPercentHelper.ShowAlways = true;
			// 
			// totalPointsHelper
			// 
			this.totalPointsHelper.ShowAlways = true;
			// 
			// valueOfAssignmentHelper
			// 
			this.valueOfAssignmentHelper.ShowAlways = true;
			// 
			// desiredGradeHelper
			// 
			this.desiredGradeHelper.ShowAlways = true;
			// 
			// categoryOverallGradeHelper
			// 
			this.categoryOverallGradeHelper.ShowAlways = true;
			// 
			// assignmentInEmptyCategoryLabel
			// 
			this.assignmentInEmptyCategoryLabel.AutoSize = true;
			this.assignmentInEmptyCategoryLabel.Location = new System.Drawing.Point(13, 141);
			this.assignmentInEmptyCategoryLabel.Name = "assignmentInEmptyCategoryLabel";
			this.assignmentInEmptyCategoryLabel.Size = new System.Drawing.Size(196, 13);
			this.assignmentInEmptyCategoryLabel.TabIndex = 19;
			this.assignmentInEmptyCategoryLabel.Text = "Assignment Going Into Empty Category?";
			// 
			// assignmentInNewCategoryCheckBox
			// 
			this.assignmentInNewCategoryCheckBox.AutoSize = true;
			this.assignmentInNewCategoryCheckBox.Location = new System.Drawing.Point(216, 141);
			this.assignmentInNewCategoryCheckBox.Name = "assignmentInNewCategoryCheckBox";
			this.assignmentInNewCategoryCheckBox.Size = new System.Drawing.Size(15, 14);
			this.assignmentInNewCategoryCheckBox.TabIndex = 20;
			this.assignmentInNewCategoryCheckBox.UseVisualStyleBackColor = true;
			this.assignmentInNewCategoryCheckBox.CheckedChanged += new System.EventHandler(this.AssignmentInNewCategoryCheckBox_CheckedChanged);
			// 
			// assignmentEmptyCategoryHelper
			// 
			this.assignmentEmptyCategoryHelper.ShowAlways = true;
			// 
			// applicationMenuStrip
			// 
			this.applicationMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.applicationMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.applicationMenuStrip.Name = "applicationMenuStrip";
			this.applicationMenuStrip.Size = new System.Drawing.Size(260, 24);
			this.applicationMenuStrip.TabIndex = 21;
			this.applicationMenuStrip.Text = "Application Menu";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInformationToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveInformationToolStripMenuItem
			// 
			this.saveInformationToolStripMenuItem.Name = "saveInformationToolStripMenuItem";
			this.saveInformationToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.saveInformationToolStripMenuItem.Text = "Save Information";
			this.saveInformationToolStripMenuItem.Click += new System.EventHandler(this.SaveInformationToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.exitToolStripMenuItem.Text = "Exit Program";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// githubToolStripMenuItem
			// 
			this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
			this.githubToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.githubToolStripMenuItem.Text = "View Project on Github";
			this.githubToolStripMenuItem.Click += new System.EventHandler(this.GithubToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.aboutToolStripMenuItem.Text = "About Grade Calculator";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// resetBox
			// 
			this.resetBox.Location = new System.Drawing.Point(167, 308);
			this.resetBox.Name = "resetBox";
			this.resetBox.Size = new System.Drawing.Size(75, 63);
			this.resetBox.TabIndex = 22;
			this.resetBox.Text = "Reset";
			this.resetBox.UseVisualStyleBackColor = true;
			this.resetBox.Click += new System.EventHandler(this.ResetBox_Click);
			// 
			// GradeCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 377);
			this.Controls.Add(this.resetBox);
			this.Controls.Add(this.assignmentInNewCategoryCheckBox);
			this.Controls.Add(this.assignmentInEmptyCategoryLabel);
			this.Controls.Add(this.gradeButton);
			this.Controls.Add(this.categoryOverallGradeBox);
			this.Controls.Add(this.categoryOverallGradeLabel);
			this.Controls.Add(this.desiredGradeBox);
			this.Controls.Add(this.desiredGradeLabel);
			this.Controls.Add(this.valueOfAssignmentBox);
			this.Controls.Add(this.valueOfAssignmentLabel);
			this.Controls.Add(this.totalPointsBox);
			this.Controls.Add(this.totalPointsLabel);
			this.Controls.Add(this.totalCategoryPercentBox);
			this.Controls.Add(this.totalCategoryPercentLabel);
			this.Controls.Add(this.assignmentPercentWeightBox);
			this.Controls.Add(this.assignmentCategoryPercentLabel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.weightedSystemLabel);
			this.Controls.Add(this.currentGradeLabel);
			this.Controls.Add(this.currentGradeBox);
			this.Controls.Add(this.applicationMenuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.applicationMenuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GradeCalculator";
			this.Text = "Grade Calculator";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.applicationMenuStrip.ResumeLayout(false);
			this.applicationMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label currentGradeLabel;
		private System.Windows.Forms.ToolTip currentGradeHelper;
		private System.Windows.Forms.RadioButton weightedSystemYES;
		private System.Windows.Forms.RadioButton weightedSystemNO;
		private System.Windows.Forms.Label weightedSystemLabel;
		private System.Windows.Forms.ToolTip weightedSystemHelper;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label assignmentCategoryPercentLabel;
		private System.Windows.Forms.Label totalCategoryPercentLabel;
		private System.Windows.Forms.Label totalPointsLabel;
		private System.Windows.Forms.Label valueOfAssignmentLabel;
		private System.Windows.Forms.Label desiredGradeLabel;
		private System.Windows.Forms.Label categoryOverallGradeLabel;
		private System.Windows.Forms.Button gradeButton;
		private System.Windows.Forms.TextBox currentGradeBox;
		private System.Windows.Forms.TextBox assignmentPercentWeightBox;
		private System.Windows.Forms.TextBox totalCategoryPercentBox;
		private System.Windows.Forms.TextBox totalPointsBox;
		private System.Windows.Forms.TextBox valueOfAssignmentBox;
		private System.Windows.Forms.TextBox desiredGradeBox;
		private System.Windows.Forms.TextBox categoryOverallGradeBox;
		private System.Windows.Forms.ToolTip assignmentWeightHelper;
		private System.Windows.Forms.ToolTip totalCategoryPercentHelper;
		private System.Windows.Forms.ToolTip totalPointsHelper;
		private System.Windows.Forms.ToolTip valueOfAssignmentHelper;
		private System.Windows.Forms.ToolTip desiredGradeHelper;
		private System.Windows.Forms.ToolTip categoryOverallGradeHelper;
		private System.Windows.Forms.Label assignmentInEmptyCategoryLabel;
		private System.Windows.Forms.CheckBox assignmentInNewCategoryCheckBox;
		private System.Windows.Forms.ToolTip assignmentEmptyCategoryHelper;
		private System.Windows.Forms.MenuStrip applicationMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Button resetBox;
		private System.Windows.Forms.ToolStripMenuItem saveInformationToolStripMenuItem;
	}
}

