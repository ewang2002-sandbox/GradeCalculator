using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
	public partial class GradeCalculator : Form
	{
		// bunch of variables 
		private double currentGrade;
		private double gradeWeight;
		private double totalCategory; // total category filled
		private double catGrade; // cat overall grade
		private double totalPoints; // category total points
		private double wantedPercent;
		private double category;
		private double assignmentPoints;

		public GradeCalculator()
		{
			InitializeComponent();
			// associate the tooltip with the label
			this.currentGradeHelper.SetToolTip(currentGradeLabel, "Type your current class grade here. This should be a percent value. For example, if you have a 95.3%, you would type 95.3.");
			this.weightedSystemHelper.SetToolTip(weightedSystemLabel, "Whether the grading system is weighted or not. If the system is weighted, there will be multiple categories (for example, tests would be worth 60% of your grade, homework 10%, and so on).");
			this.assignmentWeightHelper.SetToolTip(assignmentCategoryPercentLabel, "The category that this assignment will be inputted into.\nType the category possible percent, NOT the earned percent.");
			this.totalCategoryPercentHelper.SetToolTip(totalCategoryPercentLabel, "The total percent of currently used categories.\nFor example, if the Test category (worth 70%) and Homework category (worth 20%) had points, but not the Final category (worth 10%), you would put 90.\nONLY count the categories WITH point values in, regardless of whether the assignment is going into an empty category or not.");
			this.totalPointsHelper.SetToolTip(totalPointsLabel, "The total points in the category (if weighted) or in the gradebook (if unweighted).");
			this.valueOfAssignmentHelper.SetToolTip(valueOfAssignmentLabel, "The point value of this assignment.");
			this.desiredGradeHelper.SetToolTip(desiredGradeLabel, "The desired grade, in percent value.");
			this.categoryOverallGradeHelper.SetToolTip(categoryOverallGradeLabel, "The percent value of the category. This can either be a fraction representing the grade OR the weighted earned percent (out of the maximum category percent) of the category.");
			this.assignmentEmptyCategoryHelper.SetToolTip(assignmentInEmptyCategoryLabel, "Whether the assignment is going into a new category or not. In other words, is this assignment going into a category that previously didn't have any points?");
		}

		/// <summary>
		/// For the checkmark.
		/// </summary>
		private void AssignmentInNewCategoryCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.assignmentInNewCategoryCheckBox.Checked)
			{
				this.categoryOverallGradeBox.ReadOnly = true;
				this.totalPointsBox.ReadOnly = true;
			}
			else
			{
				this.categoryOverallGradeBox.ReadOnly = false;
				this.totalPointsBox.ReadOnly = false;
			}
		}

		/// <summary>
		/// For the radio buttons - "Yes"
		/// </summary>
		private void WeightedSystemYES_CheckedChanged(object sender, EventArgs e)
		{
			WeightedGradeRadio();
		}

		/// <summary>
		/// For the radio buttons - "No"
		/// </summary>
		private void WeightedSystemNO_CheckedChanged(object sender, EventArgs e)
		{
			WeightedGradeRadio();
		}

		/// <summary>
		/// Determines if we should block off some of the settings based off option chosen in radio box (weighted system Q).
		/// </summary>
		private void WeightedGradeRadio()
		{
			if (this.weightedSystemYES.Checked)
			{
				this.assignmentPercentWeightBox.ReadOnly = false;
				this.totalCategoryPercentBox.ReadOnly = false;
				this.categoryOverallGradeBox.ReadOnly = false;
				this.assignmentInNewCategoryCheckBox.Enabled = true;
			}
			else  // because it doesnt render sometimes
			{
				this.assignmentPercentWeightBox.ReadOnly = true;
				this.totalCategoryPercentBox.ReadOnly = true;
				this.categoryOverallGradeBox.ReadOnly = true;
				this.assignmentInNewCategoryCheckBox.Checked = false;
				this.assignmentInNewCategoryCheckBox.Enabled = false;
			}
		}

		/// <summary>
		/// Where calculations begin.
		/// </summary>
		private void GradeButton_Click(object sender, EventArgs e)
		{
			try
			{
				// current grade
				this.currentGrade = double.Parse(this.currentGradeBox.Text.Replace("%", string.Empty));
				if (this.currentGrade > 2.0)
				{
					this.currentGrade /= 100;
				}

				// variables for conditional boxes
				if (this.weightedSystemYES.Checked)
				{
					// gradeweight is assignment weight box
					this.gradeWeight = double.Parse(this.assignmentPercentWeightBox.Text.Replace("%", string.Empty));
					if (this.gradeWeight > 2.0)
					{
						this.gradeWeight /= 100;
					}

					// get total categories filled
					this.totalCategory = double.Parse(this.totalCategoryPercentBox.Text.Replace("%", string.Empty));
					if (this.totalCategory > 2.0)
					{
						this.totalCategory /= 100;
					}

					// see if checkbox is checked.
					if (this.assignmentInNewCategoryCheckBox.Checked)
					{
						this.totalCategory += this.gradeWeight;
						this.totalPoints = 0.0;
						this.catGrade = this.currentGrade;
					}
					else
					{
						// advanced parsing of this.category grade (totally)
						if (categoryOverallGradeBox.Text.Contains('/'))
						{
							double num = double.Parse(categoryOverallGradeBox.Text.Split('/')[0]);
							double den = double.Parse(categoryOverallGradeBox.Text.Split('/')[1]);
							this.catGrade = num / den;
						}
						else
						{
							// we assume they put in the percent weight
							this.catGrade = double.Parse(this.categoryOverallGradeBox.Text.Replace("%", string.Empty));
							this.catGrade = (100 * this.catGrade) / (this.gradeWeight * 100);
							this.catGrade /= 100;
						}
						// get total points
						this.totalPoints = double.Parse(this.totalPointsBox.Text);
					}
					this.category = this.gradeWeight / this.totalCategory;
				}
				else
				{
					this.catGrade = this.currentGrade;
					this.category = 1;
					this.gradeWeight = 1;
					this.totalPoints = double.Parse(this.totalPointsBox.Text);
				}


				this.wantedPercent = double.Parse(this.desiredGradeBox.Text.Replace("%", string.Empty));
				this.assignmentPoints = double.Parse(this.valueOfAssignmentBox.Text);
				if (this.wantedPercent > 2.0)
				{
					this.wantedPercent /= 100;
				}

				// calculations
				double f = this.GetGradeNeeded();
				MessageBox.Show($"To get a(n) {this.wantedPercent * 100}% in the class, you need {Math.Round(f, 2)} / {this.assignmentPoints} inputted into the {this.gradeWeight * 100}% category.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred with your input. Ensure each box contains a number.\n\nSystem Message: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}


		/// <summary>
		/// Calculates the grade needed on the assignment to get a desired grade.
		/// </summary>
		/// <returns>Returns the grade you need on an assignment.</returns>
		private double GetGradeNeeded()
		{
			double a = this.currentGrade - (this.category * this.catGrade) + this.category * (this.catGrade * this.totalPoints) / (this.totalPoints + this.assignmentPoints);
			return (this.wantedPercent - a) * (this.totalPoints + this.assignmentPoints) / this.category;
		}

		/// <summary>
		/// Closes the application.
		/// </summary>
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Opens browser to Github
		/// </summary>
		private void GithubToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://github.com/ewang20027/gradecalculator");
		}

		/// <summary>
		/// Information about the application.
		/// </summary>
		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string desc = "Application developed by Edward Wang (ewang20027). This program was written in C#, using the Windows Forms API.\n\nFormula (used to calculate needed grade) by Dakota Frost (icicl).";
			MessageBox.Show(desc, "Application Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Resets every field.
		/// </summary>
		private void ResetBox_Click(object sender, EventArgs e)
		{
			// clear all fields
			this.currentGradeBox.Clear();
			this.assignmentPercentWeightBox.Clear();
			this.totalCategoryPercentBox.Clear();
			this.totalPointsBox.Clear();
			this.valueOfAssignmentBox.Clear();
			this.desiredGradeBox.Clear();
			this.categoryOverallGradeBox.Clear();
			// clear all vars
			this.currentGrade = 0.0;
			this.gradeWeight = 0.0;
			this.totalCategory = 0.0;
			this.catGrade = 0.0;
			this.totalPoints = 0.0;
			this.wantedPercent = 0.0;
			this.category = 0.0;
			this.assignmentPoints = 0.0;
		}

		/// <summary>
		/// Saves data as a text file.
		/// </summary>
		private void SaveInformationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (double.IsNaN(this.GetGradeNeeded()))
			{
				MessageBox.Show($"Please input information into the fields before you try saving. If you inputted information, please click \"Calculate Grade\" first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SaveFileDialog sfd = new SaveFileDialog
			{
				Filter = "Text file(*.txt)|*.txt",
				FilterIndex = 1
			};

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				string dirLocationString = sfd.FileName;
				// string results = $"Current Grade: {this.currentGrade}\nGrade Weight: {this.gradeWeight}\nTotal Filled Category %: {this.totalCategory}\nTotal Points In Category: {this.totalPoints}\nWanted Percentage: {this.wantedPercent}\nCategory Percent: {this.category}\nAssignment Value: {this.assignmentPoints}\n\nPoints Needed: {this.GetGradeNeeded()}";
				StringBuilder str = new StringBuilder();
				string results = str.Append($"Current Grade: {this.currentGrade}")
					.Append($"Grade Weight: {this.gradeWeight}")
					.Append($"Total Filled Category %: {this.totalCategory}")
					.Append($"Total Points In Category: {this.totalPoints}")
					.Append($"Wanted Percentage: {this.wantedPercent}")
					.Append($"Category Percent: {this.category}")
					.Append($"Assignment Value: {this.assignmentPoints}")
					.AppendLine()
					.Append($"Points Needed: {this.GetGradeNeeded()}")
					.ToString();

				File.WriteAllText(dirLocationString, results);
			}
		}
	}
}
