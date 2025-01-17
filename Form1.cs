using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;
        private bool quizFinished;
        public Form1()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            questions = new List<Question>
            {
                new Question("کدام گزینه برای تعریف یک آرایه صحیح در سی شارپ درست است؟", new List<string> { "int array = new int[5]", "int[] int array = new int[5]", "array int[5]", "int array[5]" }, "int[] int array = new int[5]"),
                new Question("نگه داری؟ false یا true چه نوعی از داده می تواند یک مقدار", new List<string> { "int", "float", "bool", "string" }, "bool"),
                new Question("در سی شارپ چیست؟ int مقدار پیش فرض یک متغییر نوع", new List<string> { "1", "-1", "0", "مقدار پیش فرض ندارد" }, "0"),
                new Question("برای جلوگیری از ارث بری از یک کلاس از چه کلمه ای استفاده می شود؟", new List<string> { "sealed", "abstract", "private", "virtual" }, "sealed"),
                new Question("کدارم یک کلمه کلیدی بریا تعریف یک رابط در سی شاپ است؟", new List<string> { "interface", "abstract", "implements", "class" }, "interface"),
                new Question("برای مدیریت خطاها در سی شاپ از چه ساختاری استفاده می کنیم؟", new List<string> { "if - else", "try - catch", "switch - case", "for - loop" }, "try - catch"),
                new Question("کدام گزینه برای مقداردهی متغییر ثابت صحیح است؟", new List<string> { "int coset x = int 10", "int coset x = 10", "const int x; x = 10", "const int = 10" }, "const int = 10"),
                new Question("کدام یک از کلمات کلیدی برای اجرای چندریسمانی استفاده می شود؟", new List<string> { "thread", "Task", "await", "همه موارد" }, "همه موارد"),
                new Question("کدام ساختار برای استفاده از فضای نام صحیح است؟", new List<string> { "namespace System", "using System", "import System", "include System" }, "using System"),
                new Question("کدام گزینه یک ویژگی از شی گرایی نیست؟", new List<string> { "کپسوله سازی", "ارث بری", "چندریسمانی", "چندریختی" }, "چندریسمانی"),
                // Add more questions here
            };

            currentQuestionIndex = 0;
            score = 0;
            quizFinished = false;

            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];

                questionLabel.Text = currentQuestion.Text;
                choiceRadioButton1.Text = currentQuestion.Choices[0];
                choiceRadioButton2.Text = currentQuestion.Choices[1];
                choiceRadioButton3.Text = currentQuestion.Choices[2];
                choiceRadioButton4.Text = currentQuestion.Choices[3];

                choicesGroupBox.Controls.OfType<RadioButton>().ToList().ForEach(radioButton => radioButton.Checked = false);

                choicesGroupBox.Visible = true;
                nextButton.Visible = true;
                scoreLabel.Visible = false;
                retryButton.Visible = false;
            }
            else
            {
                quizFinished = true;
                questionLabel.Text = "پایان آزمون";
                choicesGroupBox.Visible = false;
                nextButton.Visible = false;
                scoreLabel.Visible = true;
                retryButton.Visible = true;

                scoreLabel.Text = $"نمره: {score}/{questions.Count}";
            }
        }



        private void nextButton_Click(object sender, EventArgs e)
        {
            // Check the selected answer
            if (choicesGroupBox.Controls.OfType<RadioButton>().Any(radioButton => radioButton.Checked))
            {
                Question currentQuestion = questions[currentQuestionIndex];
                RadioButton selectedRadioButton = choicesGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);
                string selectedAnswer = selectedRadioButton.Text;

                if (selectedAnswer == currentQuestion.CorrectAnswer)
                {
                    score++;
                }

                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("لطفا یک گزینه را انتخاب کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Question
        {
            public string Text { get; }
            public List<string> Choices { get; }
            public string CorrectAnswer { get; }

            public Question(string text, List<string> choices, string correctAnswer)
            {
                Text = text;
                Choices = choices;
                CorrectAnswer = correctAnswer;
            }
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            InitializeQuiz();
        }
    }
}
