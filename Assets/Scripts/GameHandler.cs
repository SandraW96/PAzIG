using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public Sprite[] Sprites;
    public Button Answer1;
    public Button Answer2;
    public Button Answer3;
    public Text QuestionTextBox;
    public Text ScoreText;

    private List<string> questions;
    private int answerChosen = 0;
    private int correctAnswer = 0;
    private bool allowNextQuestion = true;
    private int gamePoints = 0;


    // Start is called before the first frame update
    void Start()
    {
        questions = new List<string>();
        questions.Add("Brzeg �opatki");
        questions.Add("Ko�� czworoboczna");
        questions.Add("G�owa ko�ci skokowej");
        questions.Add("Ko�� g��wkowata");
        questions.Add("Guzek wi�kszy");
        questions.Add("Ko�� haczykowata");
        questions.Add("K�t �opatki");
        questions.Add("Ko�� ��deczkowata");
        questions.Add("Ko�� ��dkowata");
        questions.Add("Ko�� �okciowa");
        questions.Add("Obojczyk");
        questions.Add("Ko�� pi�towa");
        questions.Add("Ko�� piszcelowa");
        questions.Add("Ko�� promieniowa");
        questions.Add("Ko�� strza�kowa");
        questions.Add("Szyjka chirurgiczna");
        questions.Add("Wyrostek barkowo-�opatkowy");
        questions.Add("Zatoka st�pu");

    }

    // Update is called once per frame
    void Update()
    {
        if (allowNextQuestion)
        {
            generateQuestion();
        }
        checkTheAnswer();
        ScoreText.text = gamePoints.ToString();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

    }

    private void generateQuestion()
    {
        int index = Random.Range(0, 18);
        int buttonToSelect = Random.Range(1, 4);
        correctAnswer = buttonToSelect;

        string questionText = questions[index];
        Sprite questionImage = Sprites[index];

        QuestionTextBox.text = questionText;

        if (buttonToSelect==1)
        {
            Answer1.image.sprite = questionImage;
            Answer2.image.sprite = Sprites[Random.Range(0, 18)];
            Answer3.image.sprite = Sprites[Random.Range(0, 18)];

        }
        if (buttonToSelect == 2)
        {
            Answer2.image.sprite = questionImage;
            Answer1.image.sprite = Sprites[Random.Range(0, 18)];
            Answer3.image.sprite = Sprites[Random.Range(0, 18)];
        }
        if (buttonToSelect == 3)
        {
            Answer3.image.sprite = questionImage;
            Answer2.image.sprite = Sprites[Random.Range(0, 18)];
            Answer1.image.sprite = Sprites[Random.Range(0, 18)];
        }


        allowNextQuestion = false;
    }

    private void checkTheAnswer()
    {
        if (answerChosen!=0)
        {
            if (answerChosen == correctAnswer)
            {
                gamePoints++;

            }
            answerChosen = 0;
            allowNextQuestion=true;
        }
        
    }

    #region OnClickListeners

    public void OnAnswer1Click()
    {
        answerChosen = 1;
    }
    public void OnAnswer2Click()
    {
        answerChosen = 2;
    }
    public void OnAnswer3Click()
    {
        answerChosen = 3;
    }
    #endregion
}
