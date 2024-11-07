using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Q
{
    public partial class Study : Form
    {
        private List<string> question;
        private List<string> answer;

        string currentQuestion;
        public int correctCount = 0;

        public Study(List<string> question, List<string> answer)
        {
            InitializeComponent();
            remainingQuestion.Text = "問題数 1/5";
            this.question = question;
            this.answer = answer;
            ReStart();
        }

        public void ReStart()
        {
            correctCount = 0;
            questionLabel.Text = question[0];

            remainingQuestion.Text = "問題数 1/5";

            pictureCorrect.Visible = false;
            pictureNoCorrect.Visible = false;

            panelStudy.Visible = true;
            panelStudyResulte.Visible = false;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (questionLabel.Text == question[0])
            {
                questionLabel.Text = question[1];

                remainingQuestion.Text = "問題数 2/5";
            }
            else if (questionLabel.Text == question[1])
            {
                questionLabel.Text = question[2];

                remainingQuestion.Text = "問題数 3/5";
            }
            else if (questionLabel.Text == question[2])
            {
                questionLabel.Text = question[3];

                remainingQuestion.Text = "問題数 4/5";
            }
            else if (questionLabel.Text == question[3])
            {
                questionLabel.Text = question[4];

                remainingQuestion.Text = "問題数 5/5";
            }
            else if (questionLabel.Text == question[4])
            {
                remainingQuestion.Text = "";
                answerTextBox.Text = "";
                studyScore.Text = correctCount.ToString() + "点";

                pictureCorrect.Visible = false;
                pictureNoCorrect.Visible = false;
                timer1.Start();

                panelStudy.Visible = true;
                panelStudyResulte.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void answerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (questionLabel.Text == question[0])
                {
                    remainingQuestion.Text = "問題数 2/5";

                    if (answerTextBox.Text == answer[0])
                    {
                        correctCount++;
                        answerTextBox.Text = "";

                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;
                        timer1.Start();

                        questionLabel.Text = question[1];
                    }
                    else
                    {
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;
                        timer1.Start();

                        questionLabel.Text = question[1];
                    }
                }


                else if (questionLabel.Text == question[1])
                {
                    remainingQuestion.Text = "問題数 3/5";

                    if (answerTextBox.Text == answer[1])
                    {
                        correctCount++;
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;
                        timer1.Start();

                        questionLabel.Text = question[2];

                    }
                    else
                    {
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;
                        timer1.Start();

                        questionLabel.Text = question[2];
                    }
                }


                else if (questionLabel.Text == question[2])
                {
                    remainingQuestion.Text = "問題数 4/5";

                    if (answerTextBox.Text == answer[2])
                    {
                        correctCount++;
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;
                        timer1.Start();

                        questionLabel.Text = question[3];
                    }
                    else
                    {
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;
                        timer1.Start();

                        questionLabel.Text = question[3];
                    }
                }


                else if (questionLabel.Text == question[3])
                {
                    remainingQuestion.Text = "問題数 5/5";

                    if (answerTextBox.Text == answer[3])
                    {
                        correctCount++;
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;
                        timer1.Start();

                        questionLabel.Text = question[4];

                    }
                    else
                    {
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;
                        timer1.Start();

                        questionLabel.Text = question[4];
                    }
                }


                else if (questionLabel.Text == question[4])
                {
                    if (answerTextBox.Text == answer[4])
                    {
                        correctCount++;
                        remainingQuestion.Text = "";
                        answerTextBox.Text = "";
                        studyScore.Text = correctCount.ToString() + "点";


                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;
                        timer1.Start();

                        panelStudy.Visible = true;
                        panelStudyResulte.Visible = true;
                    }
                    else
                    {
                        remainingQuestion.Text = "";
                        answerTextBox.Text = "";
                        studyScore.Text = correctCount.ToString() + "点";

                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;
                        timer1.Start();

                        panelStudy.Visible = true;
                        panelStudyResulte.Visible = true;
                    }
                }
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            ReStart();
        }

        private void btnEndResult_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureCorrect.Visible = false;
            pictureNoCorrect.Visible = false;
            timer1.Stop();
        }
    }
}