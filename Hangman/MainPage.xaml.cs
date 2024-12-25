using System.ComponentModel;
using System.Diagnostics;

namespace HangmanGameGame
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        #region Fields
        string word = "";
        private string showcase;
        List<char> guesses = new List<char>();
        private List<char> letters = new List<char>();
        private string result;
        int mistakes = 0;
        int mistakeLimit = 6;
        private string status;
        private string image = "img0.jpg";

        List<string> words = new List<string>()
        {
            "python",
            "javascript",
            "java",
            "html",
            "typescript",
            "maui",
            "csharp",
            "xaml",
            "rust",
            "kotlin",
            "switft",
            "ruby",
            "perl",
            "react",
            "angular",
        };
        #endregion

        #region UI Properties
        public string Showcase
        {
            get => showcase;
            set
            {
                showcase = value;
                OnPropertyChanged();
            }
        }

        public List<char> Letters
        {
            get => letters;
            set
            {
                letters = value;
                OnPropertyChanged();
            }
        }

        public string Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        public string Status
        {
            get => status;
            set
            {
                status = value;
                OnPropertyChanged();
            }
        }

        public string Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public MainPage()
        {
            InitializeComponent();
            Letters.AddRange("abcdefghijklmnopqrstuvwxyz");
            BindingContext = this;
            ChooseWord();
            UpdateShowcase(word, guesses);
        }

        #region Methods
        private void ChooseWord()
        {
            word = words[new Random().Next(0, words.Count)];
            Debug.WriteLine(word);
        }

        private void UpdateShowcase(string word, List<char> guesses)
        {
            var temp = word.Select(g => guesses.IndexOf(g) >= 0 ? g : '_').ToArray();
            Showcase = string.Join(' ', temp);
        }

        private void SelectLetter(char letter)
        {
            if (guesses.IndexOf(letter) == -1)
            {
                guesses.Add(letter);
            }

            if (word.IndexOf(letter) >= 0)
            {
                UpdateShowcase(word, guesses);
                VerifyGuesses();
            }
            else if (word.IndexOf(letter) == -1)
            {
                mistakes++;
                UpdateStatus();
                VerifyMistakes();
                Image = $"img{mistakes}.jpg";
            }
        }

        private void VerifyMistakes()
        {
            if (mistakes == mistakeLimit)
            {
                Status = "You lost!";
                DisableLetters();
            }
        }

        private void DisableLetters()
        {
            foreach (var children in LettersContainer.Children)
            {
                var button = children as Button;
                if (button != null)
                {
                    button.IsEnabled = false;
                }
            }
        }

        private void EnableLetters()
        {
            foreach (var children in LettersContainer.Children)
            {
                var button = children as Button;
                if (button != null)
                {
                    button.IsEnabled = true;
                }
            }
        }

        private void VerifyGuesses()
        {
            if (Showcase.Replace(" ", "") == word)
            {
                Result = "You won!";
                DisableLetters();
            }
        }

        private void UpdateStatus()
        {
            Status = $"Mistakes: {mistakes} of {mistakeLimit}";
        }
        #endregion

        private void Letter_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var letter = button.Text;
                button.IsEnabled = false;
                SelectLetter(letter[0]);
            }
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            mistakes = 0;
            guesses = new List<char>();
            Image = "img0.jpg";
            ChooseWord();
            UpdateShowcase(word, guesses);
            Result = "";
            UpdateStatus();
            EnableLetters();
        }
    }
}
