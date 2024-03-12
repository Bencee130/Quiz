using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Quiz
{
    public partial class MainWindow : Window
    {
        private List<Question> questions;
        private Grid AnswersGrid; // Hozzáadtuk az AnswersGrid mezőt

        public MainWindow()
        {
            InitializeComponents();
            InitializeComponent();
            InitializeQuestions();
            DisplayQuestion(0);
        }

        private void InitializeQuestions()
        {
            questions = new List<Question>
            {
                new Question("Mi a LINQ rövidítése?", new List<string> { "Language Integrated Query", "Linear Inquiry", "List Item and Query" }),
                new Question("Melyik LINQ metódus használható a csoportosításra?", new List<string> { "GroupBy", "Filter", "Select" }),


                // További kérdések és válaszok hozzáadása itt
            };
        }

        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < questions.Count)
            {
                Question question = questions[index];
                QuestionTextBlock.Text = question.Text;

                for (int i = 0; i < question.Answers.Count; i++)
                {
                    if (i < AnswersGrid.Children.Count)
                    {
                        RadioButton radioButton = (RadioButton)AnswersGrid.Children[i];
                        radioButton.Content = question.Answers[i];
                        radioButton.IsChecked = false;
                        radioButton.Visibility = Visibility.Visible; // Beállítjuk a láthatóságot
                    }
                }
                for (int i = question.Answers.Count; i < AnswersGrid.Children.Count; i++)
                {
                    RadioButton radioButton = (RadioButton)AnswersGrid.Children[i];
                    radioButton.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = questions.IndexOf(questions.FirstOrDefault(q => q.IsAnswered == false));
            if (nextIndex != -1)
                DisplayQuestion(nextIndex);
            else
                MessageBox.Show("Gratulálok, végeztél a quiz-el!");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.IsChecked == true)
            {
                Question question = questions.FirstOrDefault(q => q.Text == QuestionTextBlock.Text);
                if (question != null)
                {
                    question.IsAnswered = true;
                    // Ellenőrizhetjük itt a válasz helyességét és egyéb feladatokat végezhetünk el
                }
            }
        }

        private void InitializeComponents()
        {
            // Hozzáadjuk az AnswersGrid-et a MainWindow tartalmához
            this.AnswersGrid = new Grid();
            Grid.SetRow(this.AnswersGrid, 1);
            this.Content = this.AnswersGrid;

            // Hozzáadjuk a rádiógombokat az AnswersGrid-hez
            for (int i = 0; i < 3; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Margin = new Thickness(0, 5, 0, 0);
                Grid.SetRow(radioButton, i);
                Grid.SetColumn(radioButton, 0);
                AnswersGrid.Children.Add(radioButton)
        ;
            }

            // További inicializációk (pl. gombok, stb.) itt...
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public bool IsAnswered { get; set; }

        public Question(string text, List<string> answers)
        {
            Text = text;
            Answers = answers;
            IsAnswered = false;
        }
    }
}