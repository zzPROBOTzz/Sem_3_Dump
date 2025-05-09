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
using System.Xml;

namespace Final_exam_oop
{
    //Name Meet Hingu
    //date 18/12/2024
    // desc: Final Exam
    public partial class Form2 : Form
    {
        private const string FolderPath = "../F2024";
        private const string TextFilePath = "../F2024/Final.txt";
        private const string XmlFilePath = "../F2024/Final.xml";

        public Form2()
        {
            InitializeComponent();
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
        }

        public interface IGrades
        {
            double CalculateTotalGrade();
            string CalculateLetterGrade();
        }

        public class Final : IGrades
        {
            private double midtermScore;
            private double projectScore;
            private double finalExamScore;

            // Public properties
            public double MidtermScore
            {
                get { return midtermScore; }
                set { midtermScore = value; }
            }

            public double ProjectScore
            {
                get { return projectScore; }
                set { projectScore = value; }
            }

            public double FinalExamScore
            {
                get { return finalExamScore; }
                set { finalExamScore = value; }
            }

            // Constructors
            public Final() { }

            public Final(double midterm, double project, double finalExam)
            {
                this.midtermScore = midterm;
                this.projectScore = project;
                this.finalExamScore = finalExam;
            }

            // Method to calculate the total grade
            public double CalculateTotalGrade()
            {
                return (midtermScore * 0.3) + (projectScore * 0.3) + (finalExamScore * 0.4);
            }

            // Method to calculate the letter grade
            public string CalculateLetterGrade()
            {
                double total = CalculateTotalGrade();

                if (total >= 90 && total <= 100) return "A";
                if (total >= 80 && total < 90) return "B";
                if (total >= 70 && total < 80) return "C";
                if (total >= 60 && total < 70) return "D";
                if (total >= 0 && total < 60) return "F";

                return "NaG"; // Not a Grade
            }
        }

        private void fbt_button1_Click(object sender, EventArgs e)
        {

            try
            {
                double midterm = double.Parse(ftx_txt1.Text);
                double project = double.Parse(ftx_txt2.Text);
                double finalExam = double.Parse(ftx_txt3.Text);
                Final studentGrades = new Final(midterm, project, finalExam);

                // Calculate total and letter grade
                double totalGrade = studentGrades.CalculateTotalGrade();
                string letterGrade = studentGrades.CalculateLetterGrade();

                // Display results
                ftx_txt4.Text = $"{totalGrade}";
                ftx_txt8.Text = $"{letterGrade}";
                double weightScore = midterm * 0.3;
                ftx_txt5.Text = weightScore.ToString("f2");
                double projectScore = project * 0.3;
                ftx_txt6.Text = projectScore.ToString("f2");
                double finalScore = finalExam * 0.4;
                ftx_txt7.Text = finalScore.ToString("f2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void fbt_button2_Click(object sender, EventArgs e)
        {
            try
            {
                string data = $"Midterm :{ftx_txt1.Text}|Project :{ftx_txt2.Text}|Final Exam:{ftx_txt3.Text}|Total Percentage:{ftx_txt4.Text}|Grade: {ftx_txt8.Text}";
                File.AppendAllText(TextFilePath, data + Environment.NewLine);
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void fbt_button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(TextFilePath))
                {
                    MessageBox.Show("Text file not found.");
                    return;
                }

                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Students");
                xmlDoc.AppendChild(root);

                foreach (string line in File.ReadAllLines(TextFilePath))
                {
                    string[] data = line.Split('|');
                    XmlElement student = xmlDoc.CreateElement("Student");
                    root.AppendChild(student);

                    student.SetAttribute("Midterm", data[0]);
                    student.SetAttribute("Project", data[1]);
                    student.SetAttribute("FinalExam", data[2]);
                    student.SetAttribute("Total", data[3]);
                    student.SetAttribute("Grade", data[4]);
                }

                xmlDoc.Save(XmlFilePath);
                MessageBox.Show("XML file generated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void fbt_button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(XmlFilePath))
                {
                    MessageBox.Show("XML file not found.");
                    return;
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(XmlFilePath);

                StringBuilder sb = new StringBuilder();
                foreach (XmlNode student in xmlDoc.SelectNodes("//Student"))
                {
                    sb.AppendLine($"Midterm: {student.Attributes["Midterm"].Value}, " +
                                  $"Project: {student.Attributes["Project"].Value}, " +
                                  $"Final: {student.Attributes["FinalExam"].Value}, " +
                                  $"Total: {student.Attributes["Total"].Value}, " +
                                  $"Grade: {student.Attributes["Grade"].Value}");
                }

                MessageBox.Show(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void fbt_button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fbt_button5_Click(object sender, EventArgs e)
        {
            ftx_txt8.Text = "0";
            ftx_txt7.Text = "0";
            ftx_txt6.Text = "0";
            ftx_txt5.Text = "0";
            ftx_txt4.Text = "0";
            ftx_txt3.Text = "0";
            ftx_txt2.Text = "0";
            ftx_txt1.Text = "0";
        }
    }
    }

