using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Reflection;

namespace QuizApp2
{
    sealed class QuizViewModel:INotifyPropertyChanged
    {

        IList<Question> shuffledQuestions;
        //change data passed to view here
        
        public int questionNumber
        {
            get { return shuffledQuestions[0].questionNumber; }

        }
        public string questiontext
        {
            get { return shuffledQuestions[0].questiontext; }
        }
        public string answer1
        {
            get { return shuffledQuestions[0].answer1; }
        }
        public string answer2
        {
            get { return shuffledQuestions[0].answer2; }
        }
        public string answer3
        {
            get { return shuffledQuestions[0].answer3; }
        }
        public string answer4
        {
            get { return shuffledQuestions[0].answer4; }
        }
        public string correctAnswer
        {
            get { return shuffledQuestions[0].correctAnswer; }
        }

        public IList<Question> questionList;
        //example to tie data in
        public QuizViewModel()
        {
            questionList = new List<Question>
            {
            new Question
                {
                    questionNumber = 1,
                    questiontext = "test question1",
                    answer1 = "test1",
                    answer2 = "test2",
                    answer3 = "test3",
                    answer4 = "test4",
                    correctAnswer = "test3"
                },
             new Question
                {
                    questionNumber = 2,
                    questiontext = "test question2",
                    answer1 = "test5",
                    answer2 = "test6",
                    answer3 = "test7",
                    answer4 = "test8",
                    correctAnswer = "test5"
                }
            };
            shuffledQuestions = questionList.OrderBy(x => Guid.NewGuid()).ToList();
            //pseudo random shuffling of questions
        
        }
        void m_inputs_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "answered":
                    checkAnswer();
                    break;
            }
        }
        public void checkAnswer()
        {
            
            ErrorMessage = string.Empty;
            //if (operation != null)
            //{
            //    try
            //    {
                    
            //        ErrorMessage = string.Empty;
            //    }
            //    catch (Exception ex)
            //    {
            //        ErrorMessage = ex.Message + " " + ex.InnerException;
            //    }
            //}
            
            OnPropertyChange("OperationComplete");
        }
        public string ErrorMessage { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
