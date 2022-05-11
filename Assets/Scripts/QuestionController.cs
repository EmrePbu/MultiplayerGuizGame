using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionController : MonoBehaviour
{
    public static QuestionController instance;
    private List<Question> _questions;
    private List<List<Answer>> _answers;
    private int questionIndex = 0;

    public int QuestionIndex
    {
        get { return questionIndex; }
        set { questionIndex = value; }
    }

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void LoadQuestions()
    {
        _questions = new List<Question>();
        _answers = new List<List<Answer>>();

        List<Answer> answersList = new List<Answer>();

        _questions.Add(new Question(2, "Bir dizeyi tam sayıya dönüştüren Java işlevi nedir?", false));
        answersList.Add(new Answer(1, "int.parse()", false));
        answersList.Add(new Answer(2, "int.parseInt()", false));
        answersList.Add(new Answer(3, "Integer.parseInt()", true)); // ***
        answersList.Add(new Answer(4, "parseInt()", false));
        _answers.Add(answersList);


        _questions.Add(new Question(5, "Kanada'nın başkenti neresidir", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Quebec", false));
        answersList.Add(new Answer(2, "Ottawa", true)); // ***
        answersList.Add(new Answer(3, "Toronto", false));
        answersList.Add(new Answer(4, "Rabat", false));
        _answers.Add(answersList);


        _questions.Add(new Question(14, "https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/Flag_of_Belgium.svg/langfr-800px-Flag_of_Belgium.svg.png", true));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Belçika", true)); // ***
        answersList.Add(new Answer(3, "Norveç", false));
        answersList.Add(new Answer(2, "İsveç", false));
        answersList.Add(new Answer(4, "Jamaika", false));
        _answers.Add(answersList);


        _questions.Add(new Question(6, "Aşağıdaki elementlerden hangisi sudan alınır?", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Hidrojen ", true)); // ***
        answersList.Add(new Answer(2, "Helyum", false));
        answersList.Add(new Answer(3, "Karbon", false));
        answersList.Add(new Answer(4, "Klor", false));
        _answers.Add(answersList);

        _questions.Add(new Question(14, "https://www.biography.com/.image/t_share/MTQ1NDY2OTM4NTY5NTMzMjAx/freddie-mercury---musical-legacy.jpg", true));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Jack Johnson", false));
        answersList.Add(new Answer(3, "John Mayer", false));
        answersList.Add(new Answer(2, "Freddy Mercury", true)); // ***
        answersList.Add(new Answer(4, "Jason Mraz", false));
        _answers.Add(answersList);

        _questions.Add(new Question(7, "https://upload.wikimedia.org/wikipedia/commons/a/af/Flag_of_Japan_bordered.png", true));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Kore", false));
        answersList.Add(new Answer(2, "Çin", false));
        answersList.Add(new Answer(3, "Fransa", false));
        answersList.Add(new Answer(4, "Japonya", true)); // ***
        _answers.Add(answersList);

        _questions.Add(new Question(7, "İngiltere'nin başkenti hangi şehirdir ?", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Rabat", false));
        answersList.Add(new Answer(2, "Manchester", false));
        answersList.Add(new Answer(3, "London", true)); // ***
        answersList.Add(new Answer(4, "Amsterdam", false));
        _answers.Add(answersList);

        _questions.Add(new Question(8, "n'nin değeri nedir?\nint n=0;\nn++;\nSystem.out.println(n++)", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "1", true)); // ***
        answersList.Add(new Answer(2, "3", false));
        answersList.Add(new Answer(3, "2", false));
        answersList.Add(new Answer(4, "4", false));
        _answers.Add(answersList);

        _questions.Add(new Question(9, "Dünya şampiyonası olan ilk spor hangisidir ?", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Bilardo", true)); // ***
        answersList.Add(new Answer(2, "Yüzme", false));
        answersList.Add(new Answer(3, "Futbol", false));
        answersList.Add(new Answer(4, "Karete", false));
        _answers.Add(answersList);


        _questions.Add(new Question(9, "Fas'ın başkenti hangi şehirdir ?", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Casablanca", false));
        answersList.Add(new Answer(2, "London", false));
        answersList.Add(new Answer(3, "Rabat", true)); // ***
        answersList.Add(new Answer(4, "Agadir", false));
        _answers.Add(answersList);

        _questions.Add(new Question(10, "Almanya'nın başkenti hangi şehirdir ?", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Düsseldorf", false));
        answersList.Add(new Answer(2, "Berlin", true)); // ***
        answersList.Add(new Answer(3, "Hamburg", false));
        answersList.Add(new Answer(4, "Munich", false));
        _answers.Add(answersList);

        _questions.Add(new Question(12, "Güneşe en yakın gezegen hangisidir ?", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "Venüs", true));
        answersList.Add(new Answer(2, "Dünya", false));
        answersList.Add(new Answer(3, "Merkür", true)); // ***
        answersList.Add(new Answer(4, "Mars", false));
        _answers.Add(answersList);

        _questions.Add(new Question(13, "Hangi teori Einstein teorisi olarak bilinir ?", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(2, "Görecelilik Teorisi", true)); // ***
        answersList.Add(new Answer(1, "Evrim Teorisi", false));
        answersList.Add(new Answer(3, "Büyük Patlama Teorisi", false));
        answersList.Add(new Answer(4, "Kuantum Kütle Çekim Teorisi", false));
        _answers.Add(answersList);


        _questions.Add(new Question(13, "Gökkuşağında kaç renk vardır ?", false));
        answersList = new List<Answer>();
        answersList.Add(new Answer(1, "6", false));
        answersList.Add(new Answer(3, "4", false));
        answersList.Add(new Answer(2, "7", true)); // ***
        answersList.Add(new Answer(4, "6", false));
        _answers.Add(answersList);
    }

    public void Next()
    {
        GameUIController.instance.ShowQuestion(_questions[QuestionIndex], _answers[QuestionIndex]);
        GameUIController.instance.EnableBuzzer(true);
        GameUIController.instance.EnableAnswers(false);
        QuestionIndex++;
    }

    public void Next(int index)
    {
        GameUIController.instance.ShowQuestion(_questions[index], _answers[index]);
        GameUIController.instance.EnableBuzzer(true);
        GameUIController.instance.EnableAnswers(false);
    }
}
