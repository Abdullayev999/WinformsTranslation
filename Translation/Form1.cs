using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translation
{
    public enum Language
    {
        AZ, RU, EN,UA
    }

    public partial class Form1 : Form
    {
        public bool CheckChange { get; set; }
        public Language From { get; set; }
        public Language To { get; set; }
        public Dictionary<Language, Dictionary<Language, Dictionary<string, string>>> Translation { get; set; }
        public Form1()
        {
            InitializeComponent();
            CheckChange = false;
            Translation = new Dictionary<Language, Dictionary<Language, Dictionary<string, string>>>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.SelectedItem == null)
            {
                MessageBox.Show("You dont select From language", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = comboBoxFrom.SelectedIndex;
            From = SelectLanguage(index);


            if (comboBoxTo.SelectedItem == null)
            {
                MessageBox.Show("You dont select To language", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            index = comboBoxTo.SelectedIndex;
            To = SelectLanguage(index);


            if (From == To)
            {
                richTextBoxTo.Text = richTextBoxFrom.Text;
            }
            else
            {
                //ctob ne delat casto inicializaciyu tolko toqda koqda izmenyatsa yaziki
                if (CheckChange)
                {
                    Translation[From] = new Dictionary<Language, Dictionary<string, string>>();
                    Translation[From][To] = new Dictionary<string, string>();

                    switch (From)
                    {
                        case Language.AZ when To == Language.RU: AzRu(); break;
                        case Language.AZ when To == Language.EN: AzEn(); break;
                        case Language.RU when To == Language.EN: RuEn(); break;
                        case Language.RU when To == Language.AZ: RuAz(); break;
                        case Language.EN when To == Language.AZ: EnAz(); break;
                        case Language.EN when To == Language.RU: EnRu(); break;
                        case Language.AZ when To == Language.UA: AzUa(); break;
                        case Language.UA when To == Language.AZ: UaAz(); break;
                        case Language.RU when To == Language.UA: RuUa(); break;
                        case Language.UA when To == Language.RU: UaRu(); break;
                        case Language.EN when To == Language.UA: EnUa(); break;
                        case Language.UA when To == Language.EN: UaEn(); break;
                        default: break;
                    }


                    CheckChange = false;
                }

                richTextBoxTo.Text = SentenceTranslation(richTextBoxFrom.Text.ToLower() + " ");

            }

        }

        // Можно вводить любой уровень сложности , покрайней мере я так думаю)
        // Примеры
        //hello mother!@#oekdeinfs hel hell$blue@##BlaCk:bLUE1@#$%hElLo1993.Mother,father,123cat#$ !@#dog .,
        



        public String SentenceTranslation(string text)
        {
            StringBuilder newText = new StringBuilder(300);
            StringBuilder newWord = new StringBuilder(100);
            Random random = new Random();
            string randomWords = "abcdfghjklmnpqrstvwxyz";
            int startWordIndex = 0;
            int endWordIndex = 0;

            for (int a = 0; a < text.Length; a++)
            {
                if (CheckPunctuation(text[a]))
                {
                    endWordIndex = a;

                    for (int b = startWordIndex; b < endWordIndex; b++)
                    {
                        newWord.Append(text[b]);
                    }

                    if (Translation[From][To].ContainsKey(newWord.ToString()))
                    {
                        newText.Append(Translation[From][To][newWord.ToString()]);
                    }
                    else
                    {
                        for (int c = 0; c < newWord.Length; c++)
                        {
                             newText.Append(randomWords[random.Next(0, randomWords.Length)]);
                        }                        
                    }
                    newText.Append(text[a]);
                    newWord.Clear();

                    startWordIndex = a + 1;
                }  
            }
            return newText.ToString();
        }

        public bool CheckPunctuation(char symb)
        {
            string punctuationAndNum = @" ,./;'[]<>!?L:{}@#$%^&*()1234567890";
            
            for (int j = 0; j < punctuationAndNum.Length; j++)
            {
                if (symb.Equals(punctuationAndNum[j]))
                return true;
                            
            }
            return false;
        }

        public void AzEn()
        {
            Translation[From][To].Add("salam", "hello");
            Translation[From][To].Add("sagol", "bye");
            Translation[From][To].Add("ana", "mother");
            Translation[From][To].Add("ata", "father");
            Translation[From][To].Add("qardas", "brother");
            Translation[From][To].Add("baci", "sister");
            Translation[From][To].Add("ela", "good");
            Translation[From][To].Add("seher", "city");
            Translation[From][To].Add("olke", "country");
            Translation[From][To].Add("mawin", "car");
            Translation[From][To].Add("mekteb", "school");
            Translation[From][To].Add("sinif", "class");
            Translation[From][To].Add("pisik", "cat");
            Translation[From][To].Add("it", "dog");
            Translation[From][To].Add("qara", "black");
            Translation[From][To].Add("goy", "blue");
            Translation[From][To].Add("agilli", "smart");
            Translation[From][To].Add("sevgi", "love");
            Translation[From][To].Add("kicik", "small");
            Translation[From][To].Add("ev", "house");
            Translation[From][To].Add("at", "horse");
            Translation[From][To].Add("hava", "air");
            Translation[From][To].Add("cay", "tea");
            Translation[From][To].Add("derin", "deep");
            Translation[From][To].Add("uzun", "long");
        }
        public void EnAz()
        {
            Translation[From][To].Add("hello", "salam");
            Translation[From][To].Add("bye", "sagol");
            Translation[From][To].Add("mother", "ana");
            Translation[From][To].Add("father", "ata");
            Translation[From][To].Add("brother", "qardas");
            Translation[From][To].Add("sister", "baci");
            Translation[From][To].Add("good", "ela");
            Translation[From][To].Add("city", "seher");
            Translation[From][To].Add("country", "olke");
            Translation[From][To].Add("car", "mawin");
            Translation[From][To].Add("school", "mekteb");
            Translation[From][To].Add("class", "sinif");
            Translation[From][To].Add("cat", "pisik");
            Translation[From][To].Add("dog", "it");
            Translation[From][To].Add("black", "qara");
            Translation[From][To].Add("blue", "goy");
            Translation[From][To].Add("smart", "agilli");
            Translation[From][To].Add("love", "sevgi");
            Translation[From][To].Add("small", "kicik");
            Translation[From][To].Add("house", "ev");
            Translation[From][To].Add("horse", "at");
            Translation[From][To].Add("air", "hava");
            Translation[From][To].Add("tea", "cay");
            Translation[From][To].Add("deep", "derin");
            Translation[From][To].Add("long", "uzun");
        }
        public void EnRu()
        {
            Translation[From][To].Add("hello", "привет");
            Translation[From][To].Add("bye", "пока");
            Translation[From][To].Add("mother", "мама");
            Translation[From][To].Add("father", "папа");
            Translation[From][To].Add("brother", "брат");
            Translation[From][To].Add("sister", "сестра");
            Translation[From][To].Add("good", "хорошо");
            Translation[From][To].Add("city", "город");
            Translation[From][To].Add("country", "страна");
            Translation[From][To].Add("car", "машина");
            Translation[From][To].Add("school", "школа");
            Translation[From][To].Add("class", "класс");
            Translation[From][To].Add("cat", "кот");
            Translation[From][To].Add("dog", "собака");
            Translation[From][To].Add("black", "черный");
            Translation[From][To].Add("blue", "синий");
            Translation[From][To].Add("smart", "умный");
            Translation[From][To].Add("love", "любовь");
            Translation[From][To].Add("small", "маленький");
            Translation[From][To].Add("house", "дом");
            Translation[From][To].Add("horse", "лошадь");
            Translation[From][To].Add("air", "воздух");
            Translation[From][To].Add("tea", "чай");
            Translation[From][To].Add("deep", "глубако");
            Translation[From][To].Add("long", "длинный");
        }
        public void RuEn()
        {
            Translation[From][To].Add("привет", "hello");
            Translation[From][To].Add("пока", "bye");
            Translation[From][To].Add("мама", "mother");
            Translation[From][To].Add("папа", "father");
            Translation[From][To].Add("брат", "brother");
            Translation[From][To].Add("сестра", "sister");
            Translation[From][To].Add("хорошо", "good");
            Translation[From][To].Add("город", "city");
            Translation[From][To].Add("страна", "country");
            Translation[From][To].Add("машина", "car");
            Translation[From][To].Add("школа", "school");
            Translation[From][To].Add("класс", "class");
            Translation[From][To].Add("кот", "cat");
            Translation[From][To].Add("собака", "dog");
            Translation[From][To].Add("черный", "black");
            Translation[From][To].Add("синий", "blue");
            Translation[From][To].Add("умный", "smart");
            Translation[From][To].Add("любовь", "love");
            Translation[From][To].Add("маленький", "small");
            Translation[From][To].Add("дом", "house");
            Translation[From][To].Add("лошадь", "horse");
            Translation[From][To].Add("воздух", "air");
            Translation[From][To].Add("чай", "tea");
            Translation[From][To].Add("глубако", "deep");
            Translation[From][To].Add("длинный", "long");            
        }
        public void RuAz()
        {
            Translation[From][To].Add("привет", "salam");
            Translation[From][To].Add("пока", "sagol");
            Translation[From][To].Add("мама", "ana");
            Translation[From][To].Add("папа", "ata");
            Translation[From][To].Add("брат", "qardas");
            Translation[From][To].Add("сестра", "baci");
            Translation[From][To].Add("хорошо", "ela");
            Translation[From][To].Add("город", "seher");
            Translation[From][To].Add("страна", "olke");
            Translation[From][To].Add("машина", "masin");
            Translation[From][To].Add("школа", "mekteb");
            Translation[From][To].Add("класс", "sinif");
            Translation[From][To].Add("кот", "pisik");
            Translation[From][To].Add("собака", "it");
            Translation[From][To].Add("черный", "qara");
            Translation[From][To].Add("синий", "goy");
            Translation[From][To].Add("умный", "agilli");
            Translation[From][To].Add("любовь", "sevgi");
            Translation[From][To].Add("маленький", "kicik");
            Translation[From][To].Add("дом", "ev");
            Translation[From][To].Add("лошадь", "at");
            Translation[From][To].Add("воздух", "hava");
            Translation[From][To].Add("чай", "cay");
            Translation[From][To].Add("глубако", "derin");
            Translation[From][To].Add("длинный", "uzun");
          }
        public void AzRu()
        {
            Translation[From][To].Add("salam", "привет");
            Translation[From][To].Add("sagol", "пока");
            Translation[From][To].Add("ana", "мама");
            Translation[From][To].Add("ata", "папа");
            Translation[From][To].Add("qardas", "брат");
            Translation[From][To].Add("baci", "сестра");
            Translation[From][To].Add("ela", "хорошо");
            Translation[From][To].Add("seher", "город");
            Translation[From][To].Add("olke", "страна");
            Translation[From][To].Add("masin", "машина");
            Translation[From][To].Add("mekteb", "школа");
            Translation[From][To].Add("sinif", "класс");
            Translation[From][To].Add("pisik", "кот");
            Translation[From][To].Add("it", "собака");
            Translation[From][To].Add("qara", "черный");
            Translation[From][To].Add("goy", "синий");
            Translation[From][To].Add("agilli", "умный");
            Translation[From][To].Add("sevgi", "любовь");
            Translation[From][To].Add("kicik", "маленький");
            Translation[From][To].Add("ev", "дом");
            Translation[From][To].Add("at", "лошадь");
            Translation[From][To].Add("hava", "воздух");
            Translation[From][To].Add("cay", "чай");
            Translation[From][To].Add("derin", "глубако");
            Translation[From][To].Add("uzun", "длинный");
        }
        public void EnUa() {
            Translation[From][To].Add("hello", "здравствуйте");
            Translation[From][To].Add("bye", "до побачення");
            Translation[From][To].Add("mother", "мати");
            Translation[From][To].Add("father", "батько");
            Translation[From][To].Add("brother", "брате");
            Translation[From][To].Add("sister", "сестра");
            Translation[From][To].Add("good", "добре");
            Translation[From][To].Add("city", "місто");
            Translation[From][To].Add("country", "країна");
            Translation[From][To].Add("car", "автомобіль");
            Translation[From][To].Add("school", "школу");
            Translation[From][To].Add("class", "клас");
            Translation[From][To].Add("cat", "кішка");
            Translation[From][To].Add("dog", "пес");
            Translation[From][To].Add("black", "чорний");
            Translation[From][To].Add("blue", "блакитний");
            Translation[From][To].Add("smart", "розумний");
            Translation[From][To].Add("love", "кохання");
            Translation[From][To].Add("small", "маленький");
            Translation[From][To].Add("house", "будинок");
            Translation[From][To].Add("horse", "кінь");
            Translation[From][To].Add("air", "повітря");
            Translation[From][To].Add("tea", "чай");
            Translation[From][To].Add("deep", "глибокий");
            Translation[From][To].Add("long", "довгота");
        }
        public void UaEn() 
        {
            Translation[From][To].Add("здравствуйте", "hello");
            Translation[From][To].Add("до побачення", "bye");
            Translation[From][To].Add("мати", "mother");
            Translation[From][To].Add("батько", "father");
            Translation[From][To].Add("брате", "brother");
            Translation[From][To].Add("сестра", "sister");
            Translation[From][To].Add("добре", "good");
            Translation[From][To].Add("місто", "city");
            Translation[From][To].Add("країна", "country");
            Translation[From][To].Add("автомобіль", "car");
            Translation[From][To].Add("школу", "school");
            Translation[From][To].Add("клас", "class");
            Translation[From][To].Add("кішка", "cat");
            Translation[From][To].Add("пес", "dog");
            Translation[From][To].Add("чорний", "black");
            Translation[From][To].Add("блакитний", "blue");
            Translation[From][To].Add("розумний", "smart");
            Translation[From][To].Add("кохання", "love");
            Translation[From][To].Add("маленький", "small");
            Translation[From][To].Add("будинок", "house");
            Translation[From][To].Add("кінь", "horse");
            Translation[From][To].Add("повітря", "air");
            Translation[From][To].Add("чай", "tea");
            Translation[From][To].Add("глибокий", "deep");
            Translation[From][To].Add("довгота", "long");
        }
        public void AzUa()
        {
            Translation[From][To].Add("salam", "здравствуйте");
            Translation[From][To].Add("sagol", "до побачення");
            Translation[From][To].Add("ana", "мати");
            Translation[From][To].Add("ata", "батько");
            Translation[From][To].Add("qardas", "брате");
            Translation[From][To].Add("baci", "сестра");
            Translation[From][To].Add("ela", "добре");
            Translation[From][To].Add("seher", "місто");
            Translation[From][To].Add("olke", "країна");
            Translation[From][To].Add("masin", "автомобіль");
            Translation[From][To].Add("mekteb", "школу");
            Translation[From][To].Add("sinif", "клас");
            Translation[From][To].Add("pisik", "кішка");
            Translation[From][To].Add("it", "пес");
            Translation[From][To].Add("qara", "чорний");
            Translation[From][To].Add("goy", "блакитний");
            Translation[From][To].Add("agilli", "розумний");
            Translation[From][To].Add("sevgi", "кохання");
            Translation[From][To].Add("kicik", "маленький");
            Translation[From][To].Add("ev", "будинок");
            Translation[From][To].Add("at", "кінь");
            Translation[From][To].Add("hava", "повітря");
            Translation[From][To].Add("cay", "чай");
            Translation[From][To].Add("derin", "глибокий");
            Translation[From][To].Add("uzun", "довгота");
        }
        public void UaAz() {
            Translation[From][To].Add("здравствуйте", "salam");
            Translation[From][To].Add("до побачення", "sagol");
            Translation[From][To].Add("мати", "ana");
            Translation[From][To].Add("батько", "ata");
            Translation[From][To].Add("брате", "qardas");
            Translation[From][To].Add("сестра", "baci");
            Translation[From][To].Add("добре", "ela");
            Translation[From][To].Add("місто", "seher");
            Translation[From][To].Add("країна", "olke");
            Translation[From][To].Add("автомобіль", "masin");
            Translation[From][To].Add("школу", "mekteb");
            Translation[From][To].Add("клас", "sinif");
            Translation[From][To].Add("кішка", "pisik");
            Translation[From][To].Add("пес", "it");
            Translation[From][To].Add("чорний", "qara");
            Translation[From][To].Add("блакитний", "goy");
            Translation[From][To].Add("розумний", "agilli");
            Translation[From][To].Add("кохання", "sevgi");
            Translation[From][To].Add("маленький", "kicik");
            Translation[From][To].Add("будинок", "ev");
            Translation[From][To].Add("кінь", "at");
            Translation[From][To].Add("повітря", "hava");
            Translation[From][To].Add("чай", "cay");
            Translation[From][To].Add("глибокий", "derin");
            Translation[From][To].Add("довгота", "uzun");
        }              
        public void RuUa() {
            Translation[From][To].Add("привет", "здравствуйте");
            Translation[From][To].Add("пока", "до побачення");
            Translation[From][To].Add("мама", "мати");
            Translation[From][To].Add("папа", "батько");
            Translation[From][To].Add("брат", "брате");
            Translation[From][To].Add("сестра", "сестра");
            Translation[From][To].Add("хорошо", "добре");
            Translation[From][To].Add("город", "місто");
            Translation[From][To].Add("страна", "країна");
            Translation[From][To].Add("машина", "автомобіль");
            Translation[From][To].Add("школа", "школу");
            Translation[From][To].Add("класс", "клас");
            Translation[From][To].Add("кот", "кішка");
            Translation[From][To].Add("собака", "пес");
            Translation[From][To].Add("черный", "чорний");
            Translation[From][To].Add("синий", "блакитний");
            Translation[From][To].Add("умный", "розумний");
            Translation[From][To].Add("любовь", "кохання");
            Translation[From][To].Add("маленький", "маленький");
            Translation[From][To].Add("дом", "будинок");
            Translation[From][To].Add("лошадь", "кінь");
            Translation[From][To].Add("воздух", "повітря");
            Translation[From][To].Add("чай", "чай");
            Translation[From][To].Add("глубако", "глибокий");
            Translation[From][To].Add("длинный", "довгота");
        }
        public void UaRu()
        {
            Translation[From][To].Add("здравствуйте", "привет");
            Translation[From][To].Add("до побачення", "пока");
            Translation[From][To].Add("мати", "мама");
            Translation[From][To].Add("батько", "папа");
            Translation[From][To].Add("брате", "брат");
            Translation[From][To].Add("сестра", "сестра");
            Translation[From][To].Add("добре", "хорошо");
            Translation[From][To].Add("місто", "город");
            Translation[From][To].Add("країна", "страна");
            Translation[From][To].Add("автомобіль", "машина");
            Translation[From][To].Add("школу", "школа");
            Translation[From][To].Add("клас", "класс");
            Translation[From][To].Add("кішка", "кот");
            Translation[From][To].Add("пес", "собака");
            Translation[From][To].Add("чорний", "черный");
            Translation[From][To].Add("блакитний", "синий");
            Translation[From][To].Add("розумний", "умный");
            Translation[From][To].Add("кохання", "любовь");
            Translation[From][To].Add("маленький", "маленький");
            Translation[From][To].Add("будинок", "дом");
            Translation[From][To].Add("кінь", "лошадь");
            Translation[From][To].Add("повітря", "воздух");
            Translation[From][To].Add("чай", "чай");
            Translation[From][To].Add("глибокий", "глубако");
            Translation[From][To].Add("довгота", "длинный");
        }
        public Language SelectLanguage(int index)
        {
            if (index == 0) return Language.EN;
            else if (index == 1) return Language.RU;
            else if(index == 2) return Language.AZ;             
            else return Language.UA;            
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckChange = true;
        }
    }
}
