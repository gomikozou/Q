﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q
{
    public partial class NormalStudy : Form
    {
        List<string> question = new List<string> { "89 + 507 = ?" , "20 × 8 = ?", "200 ÷ 4 = ?",
                                      "容赦の読み方は？", "罪業の読み方は？" };

        string currentQuestion;
        public int correctCount = 0;

        public NormalStudy()
        {
            InitializeComponent();
            ReStart();
        }

        public void ReStart()
        {
            correctCount = 0;
            questionLabel.Text = question[0];

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
            }
            else if (questionLabel.Text == question[1])
            {
                questionLabel.Text = question[2];
            }
            else if (questionLabel.Text == question[2])
            {
                questionLabel.Text = question[3];
            }
            else if (questionLabel.Text == question[3])
            {
                questionLabel.Text = question[4];
            }
            else if (questionLabel.Text == question[4])
            {
                panelStudy.Visible = true;
                panelStudyResulte.Visible = true;
                studyScore.Text = correctCount.ToString() + "点";
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
                    if (answerTextBox.Text == "596")
                    {
                        correctCount++;
                        answerTextBox.Text = "";

                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;


                        questionLabel.Text = question[1];
                    }
                    else
                    {
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;

                        questionLabel.Text = question[1];
                    }
                }


                else if (questionLabel.Text == question[1])
                {
                    if (answerTextBox.Text == "160")
                    {
                        correctCount++;
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;

                        questionLabel.Text = question[2];

                    }
                    else
                    {
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;

                        questionLabel.Text = question[2];
                    }
                }


                else if (questionLabel.Text == question[2])
                {
                    if (answerTextBox.Text == "50")
                    {
                        correctCount++;
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;

                        questionLabel.Text = question[3];
                    }
                    else
                    {
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;

                        questionLabel.Text = question[3];
                    }
                }


                else if (questionLabel.Text == question[3])
                {
                    if (answerTextBox.Text == "ようしゃ" || answerTextBox.Text == "yousya" || answerTextBox.Text == "yousha")
                    {
                        correctCount++;
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;

                        questionLabel.Text = question[4];

                    }
                    else
                    {
                        answerTextBox.Text = "";


                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;

                        questionLabel.Text = question[4];
                    }
                }

                else if (questionLabel.Text == question[4])
                {
                    if (answerTextBox.Text == "ざいごう" || answerTextBox.Text == "zaigou")
                    {
                        correctCount++;
                        answerTextBox.Text = "";
                        studyScore.Text = correctCount.ToString() + "点";


                        pictureCorrect.Visible = true;
                        pictureNoCorrect.Visible = false;

                        panelStudy.Visible = true;
                        panelStudyResulte.Visible = true;
                    }
                    else
                    {
                        answerTextBox.Text = "";
                        studyScore.Text = correctCount.ToString() + "点";

                        pictureCorrect.Visible = false;
                        pictureNoCorrect.Visible = true;

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
    }
}
