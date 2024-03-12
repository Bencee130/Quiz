using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Quiz
{
    public partial class MainWindow : Window
    {
        private readonly List<Question> questions = new List<Question>
        {
            new Question
            {
                Text = "Mi a LINQ rövidítése és mit jelent?",
                Answers = new List<string>
                {
                    "a) Language-Integrated Query, nyelvszintű lekérdezés",
                    "b) List-Integrated Query, lista alapú lekérdezés",
                    "c) Local-Integrated Query, helyi alapú lekérdezés"
                },
                CorrectAnswer = "a) Language-Integrated Query, nyelvszintű lekérdezés"
            },
            new Question
            {
                Text = "Hogyan lehet a LINQ-t használni egy gyűjteményben található elemek kiválasztására?",
                Answers = new List<string>
                {
                    "a) Az OfType<T> metódus segítségével",
                    "b) A Select metódus segítségével",
                    "c) Az OrderBy metódus segítségével"
                },
                CorrectAnswer = "b) A Select metódus segítségével"
            },
            new Question
            {
                Text = "Milyen típusú adatforrásokat támogat a LINQ?",
                Answers = new List<string>
                {
                    "a) Csak adatbázisokat",
                    "b) Csak gyűjteményeket",
                    "c) Szinte minden típusú adatforrást"
                },
                CorrectAnswer = "c) Szinte minden típusú adatforrást"
            },
            new Question
            {
                Text = "Hogyan lehet a LINQ-t használni adatbázisokhoz való hozzáféréshez?",
                Answers = new List<string>
                {
                    "a) Az Entity Framework használatával ",
                    "b) A Join művelettel",
                    "c) Az OrderBy művelettel "
                },
                CorrectAnswer = "a) Az Entity Framework használatával"
            },
            new Question
            {
                Text = "Mi a különbség a nyelvszintű lekérdezési szintaxis és az IEnumerable<T> API között?",
                Answers = new List<string>
                {
                    "a) A nyelvszintű lekérdezés rövidebb és olvashatóbb kódolást tesz lehetővé",
                    "b) Az IEnumerable<T> manuálisan írott foreach ciklusokat igényel",
                    "c) A nyelvszintű lekérdezés széles körű adatfeldolgozást tesz lehetővé"
                },
                CorrectAnswer = "a) A nyelvszintű lekérdezés rövidebb és olvashatóbb kódolást tesz lehetővé"
            },
            new Question
            {
                Text = "Hogyan lehet egy gyűjteményt szótárrá konvertálni a LINQ segítségével?",
                Answers = new List<string>
                {
                    "a) Az XmlDocument osztály használatával",
                    "b) Az XDocument és XElement típusokkal",
                    "c) Az XmlSerializer attribútumokkal"
                },
                CorrectAnswer = "b) Az XDocument és XElement típusokkal"
            },
            new Question
            {
                Text = "Milyen előnyei vannak a LINQ használatának az imperatív kódhoz képest?",
                Answers = new List<string>
                {
                    "a) Kompaktabb, olvashatóbb kód ",
                    "b) Kiváló teljesítmény az adatfeldolgozásban",
                    "c) Több szálon történő párhuzamosítás támogatása"
                },
                CorrectAnswer = "a) Kompaktabb, olvashatóbb kód "
            },
            new Question
            {
                Text = "Hogyan lehet a LINQ-t használni XML-dokumentumok kezelésére?",
                Answers = new List<string>
                {
                    "a) Az XmlDocument osztály használatával",
                    "b) Az XDocument és XElement típusokkal",
                    "c) Az XmlSerializer attribútumokkal"
                },
                CorrectAnswer = "b) Az XDocument és XElement típusokkal"
            },
            new Question
            {
                Text = "Mi a LINQ-szolgáltató és milyen példák vannak rá?",
                Answers = new List<string>
                {
                    "a) Az adatforrástól függő specifikus LINQ implementáció",
                    "b) Példák: LINQ to SQL, LINQ to Entities, LINQ to XML",
                    "c) Az IEnumerable<T> interfész implementációja"
                },
                CorrectAnswer = "b) Példák: LINQ to SQL, LINQ to Entities, LINQ to XML"
            },
            new Question
            {
                Text = "Hogyan lehet saját LINQ-szolgáltatót írni?",
                Answers = new List<string>
                {
                    "a) Az IQueryable<T> interfész implementálásával ",
                    "b) Az IEnumerable<T> interfész kiterjesztésével",
                    "c) Az OrderBy művelet felülírásával"
                },
                CorrectAnswer = "a) Az IQueryable<T> interfész implementálásával "
            },
            new Question
            {
                Text = "Miért hasznos a LINQ a kódbázis méretének csökkentésében?",
                Answers = new List<string>
                {
                    "a) Az ismétlődő kód elkerülése és újrafelhasználhatóság növelése ",
                    "b) A kompakt és olvasható kód miatt könnyebb karbantarthatóság",
                    "c) A LINQ automatikusan optimalizálja a lekérdezéseket"
                },
                CorrectAnswer = "a) Az ismétlődő kód elkerülése és újrafelhasználhatóság növelése "
            },
            new Question
            {
                Text = "Hogyan lehet a LINQ-t használni JSON-dokumentumok kezelésére?",
                Answers = new List<string>
                {
                    "a) Az Newtonsoft.Json könyvtár használatával ",
                    "b) Az XmlSerializer attribútumokkal",
                    "c) Az IEnumerable<T> interfész implementációjával"
                },
                CorrectAnswer = "a) Az Newtonsoft.Json könyvtár használatával "
            },
            new Question
            {
                Text = "Miért fontos a LINQ használata az adathozzáférés egyszerűsítése érdekében?",
                Answers = new List<string>
                {
                    "a) Rövid, olvasható kód a bonyolult adatműveletekhez",
                    "b) Könnyű és gyors adatfeldolgozás a LINQ kényelmes műveleteivel",
                    "c) A LINQ automatikusan optimalizálja a lekérdezéseket és kezeli az adatkapcsolatokat"
                },
                CorrectAnswer = "b) Könnyű és gyors adatfeldolgozás a LINQ kényelmes műveleteivel"
            },
            new Question
            {
                Text = "Hány ötöst érdemel a csapat?",
                Answers = new List<string>
                {
                    "a) Az összeset + 2",
                    "b) Mennyit akartok?",
                    "c) Annyit amennyivel Dunát lehet rekeszteni"
                },
                CorrectAnswer = "a) Az összeset + 2"
            },

            // Add more questions here...
        };

        private int currentQuestionIndex = 0;
        private int correctAnswers = 0;

        public MainWindow()
        {
            InitializeComponent();
            LoadQuestion(currentQuestionIndex);
        }

        private void LoadQuestion(int index)
        {
            if (index < questions.Count)
            {
                Question question = questions[index];
                QuestionTextBlock.Text = question.Text;

                List<string> answers = question.Answers.OrderBy(a => Guid.NewGuid()).ToList();
                RadioOptionA.Content = answers[0];
                RadioOptionB.Content = answers[1];
                RadioOptionC.Content = answers[2];

                // Reset radio button selection
                RadioOptionA.IsChecked = false;
                RadioOptionB.IsChecked = false;
                RadioOptionC.IsChecked = false;
            }
            else
            {
                MessageBox.Show($"Kvíz vége! Helyes válaszok: {correctAnswers} / {questions.Count}");
                Close();
            }
        }

        public void CheckAnswer(string selectedAnswer)
        {
            if (selectedAnswer == questions[currentQuestionIndex].CorrectAnswer)
            {
                correctAnswers++;
            }

            currentQuestionIndex++;
            LoadQuestion(currentQuestionIndex);
        }

        public void RadioOption_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton selectedOption = sender as RadioButton;
            if (selectedOption != null && selectedOption.IsChecked == true)
            {
                string selectedAnswer = selectedOption.Content.ToString();
                CheckAnswer(selectedAnswer);
            }
        }

        

        private void NextButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (RadioOptionA.IsChecked == false && RadioOptionB.IsChecked == false && RadioOptionC.IsChecked == false)
            {
                MessageBox.Show("Kérem válasszon egy válaszlehetőséget!");
                return;
            }

            if (currentQuestionIndex < questions.Count)
            {
                string selectedAnswer = "";
                if (RadioOptionA.IsChecked == true)
                {
                    selectedAnswer = RadioOptionA.Content.ToString();
                }
                else if (RadioOptionB.IsChecked == true)
                {
                    selectedAnswer = RadioOptionB.Content.ToString();
                }
                else if (RadioOptionC.IsChecked == true)
                {
                    selectedAnswer = RadioOptionC.Content.ToString();
                }

                CheckAnswer(selectedAnswer);
            }
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
