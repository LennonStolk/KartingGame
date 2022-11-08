using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayNextOptions : MonoBehaviour
{
    private int Number { get; set; }
    private string Options { get; set; }
    public bool IsLeftOptionCorrect;
    public TMPro.TMP_Text UIText;


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
        
    }

    string GetOptions()
    {
        int wordOptionsCount = WordOptions.GetLength(0);;
        int randomIndex = Number % wordOptionsCount;

        if (IsLeftOptionCorrect)
            return WordOptions[randomIndex, 0] + "   or   " + WordOptions[randomIndex, 1];
        else
            return WordOptions[randomIndex, 1] + "   or   " + WordOptions[randomIndex, 0];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Number == 0)
        {
            Number = GetComponentInParent<RandomNumber>().Number;
            Options = GetOptions();
            UIText.text = Options;
        }
    }
}
