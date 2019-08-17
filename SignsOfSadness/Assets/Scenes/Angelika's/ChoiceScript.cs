using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Path0DialogueOptionChoice1; //Path 0 is the initial dialogue
    public GameObject Path0DialogueOptionChoice2;
    public GameObject Path0DialogueOptionChoice3;

    public GameObject Path1DialogueOptionChoice1;
    public GameObject Path1DialogueOptionChoice2;
    public GameObject Path1DialogueOptionChoice3;

    //public GameObject Path2DialogueOptionChoice1;
    //public GameObject Path2DialogueOptionChoice2;
    //public GameObject Path2DialogueOptionChoice3;

    public int ChoiceMade;

    public void Path0DialogueChoiceOption1() //Path 1 Starts
    {
        TextBox.GetComponent<Text>().text = "BlablaBlah sad life.";
        ChoiceMade = 1; //path variable number
    }

    public void Path0DialogueChoiceOption2() // Path 2 starts
    {
        TextBox.GetComponent<Text>().text = "(The man sobs and then turns and faces you mopey looking.)";
        ChoiceMade = 2;
    }

    public void Path0DialogueChoiceOption3() // Path 3 starts
    {
        TextBox.GetComponent<Text>().text = "(The man sobs and then turns and faces as if seeking comfort.)";
        ChoiceMade = 3;
    }

    public void Path1DialogueChoiceOption1() //if select first option from path 1, the depressed npc replies this. 
    {
        TextBox.GetComponent<Text>().text = "Habibidi";
        ChoiceMade = 4;
    }

    public void Path1DialogueChoiceOption2()
    {
        TextBox.GetComponent<Text>().text = "Omomo";
        ChoiceMade = 5;
    }

    public void Path1DialogueChoiceOption3()
    {
        TextBox.GetComponent<Text>().text = "Jajaja";
        ChoiceMade = 6;
    }



    // Update is called once per frame
    void Update()
    {


        if (ChoiceMade >= 1)
        {
            Path0DialogueOptionChoice1.SetActive(false);
            Path0DialogueOptionChoice2.SetActive(false); //activation and deactivation of options when pressed
            Path0DialogueOptionChoice3.SetActive(false);
            Path1DialogueOptionChoice1.SetActive(true);
            Path1DialogueOptionChoice2.SetActive(true);
            Path1DialogueOptionChoice3.SetActive(true);
        }
        if (ChoiceMade >= 1)
        {
            Path1DialogueOptionChoice1.SetActive(true);
            Path1DialogueOptionChoice2.SetActive(true);
            Path1DialogueOptionChoice3.SetActive(true);
            Path0DialogueOptionChoice1.SetActive(false);
            Path0DialogueOptionChoice2.SetActive(false);
            Path0DialogueOptionChoice3.SetActive(false);
        }




    }
}
