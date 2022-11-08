using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWordChoice : MonoBehaviour
{
    private int Number { get; set; }
    private string Word { get; set; }
    public bool IsCorrectChoice;

    private string[,] WordOptions = new string[,] {
        // {Correct, Incorrect}
        {"Calendar", "Calender"},
        {"License", "Licence"},
        {"Necessary", "Neccessary"},
        {"Until", "Untill"},
        {"A lot", "Alot"},
        {"Believe", "Beleive"},
        {"Cemetery", "Cemetary"},
        {"Raspberry", "Rasberry"},
        {"Acquire", "Aquire"},
        {"Colleague", "Collegue"},
        {"Fulfill", "Fullfill"},
        {"Pastime", "Pasttime"},
        {"Privilege", "Priviledge"},
        {"Receive", "Recieve"},
        {"Referred", "Refered"},
        {"Separate", "Seperate"},
        {"Consensus", "Concencus"},
        {"Achieve", "Acheive"},
        {"Across", "Accross"},
        {"Basically", "Basicly"},
        {"Category", "Catagory"},
        {"Copyright", "Copywrite"},
        {"Tomato", "Tomato"},
        {"Apparent", "Apparrent"},
        {"Entrepreneur", "Entrepeneur"},
        {"Pronunciation", "Pronounciation"},
        {"Tendency", "Tendancy"},
        {"Weather", "Wether"},
        {"Beautiful", "Beutiful"},
        {"Niece", "Neice"},
        {"Environment", "Enviroment"},
        {"Definitely", "Definately"},
        {"Persistent", "Persistant"},
        {"Siege", "Seige"},
        {"Misspell", "Mispell"},
    };

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Number == 0)
        {
            Number = GetComponentInParent<RandomNumber>().Number;
            Word = GetWord();
            TMPro.TMP_Text tm = gameObject.GetComponentInChildren<TMPro.TMP_Text>();
            tm.text = Word;
        }
    }

    string GetWord()
    {
        int wordOptionsCount = WordOptions.GetLength(0);;
        int randomIndex = Number % wordOptionsCount;

        if (IsCorrectChoice)
            return WordOptions[randomIndex, 0];
        else
            return WordOptions[randomIndex, 1];
    }
}
