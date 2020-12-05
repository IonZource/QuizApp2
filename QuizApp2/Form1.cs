using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizApp2
{
    public partial class Form1 : Form
    {
        QuizViewModel q_viewModel;
        //declare new mewmodel
        public Form1()
        {
            InitializeComponent();
        }

        private void question_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            q_viewModel = new QuizViewModel();
            questionbox.Text = q_viewModel.questiontext;
            QuestionNumber.Text = "Question " + (q_viewModel.questionNumber).ToString() + ":";
            //convert int to string to display

            radioButton1.Text = q_viewModel.answer1;
            radioButton2.Text = q_viewModel.answer2;
            radioButton3.Text = q_viewModel.answer3;
            radioButton4.Text = q_viewModel.answer4;
            InfoDisplay1.Text = "test";
            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            //if (PropertyChanged != null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs("answered"));
            //}
            
            if (radioButton1.Checked)
            {
                if (radioButton1.Text == q_viewModel.correctAnswer)
                {
                    InfoDisplay1.Text = "Previous answer was correct!";
                }
                else
                {
                    InfoDisplay1.Text = "Previous answer was incorrect!";
                }

            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Text == q_viewModel.correctAnswer)
                {
                    InfoDisplay1.Text = "Previous answer was correct!";
                }
                else
                {
                    InfoDisplay1.Text = "Previous answer was incorrect!";
                }

            }
            if (radioButton3.Checked)
            {
                if (radioButton3.Text == q_viewModel.correctAnswer)
                {
                    InfoDisplay1.Text = "Previous answer was correct!";
                }
                else
                {
                    InfoDisplay1.Text = "Previous answer was incorrect!";
                }

            }
            if (radioButton4.Checked)
            {
                if (radioButton4.Text == q_viewModel.correctAnswer)
                {
                    InfoDisplay1.Text = "Previous answer was correct!";
                }
                else
                {
                    InfoDisplay1.Text = "Previous answer was incorrect!";
                }

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void InfoDisplay1_Click(object sender, EventArgs e)
        {

        }
    }
}
