using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Button1; //Path 0 is the initial dialogue
    public GameObject Button2;
    public GameObject Button3;
    public Animator animator;

    public string InfoText
    {
        get { return TextBox.GetComponent<Text>().text; }
        set { TextBox.GetComponent<Text>().text = value; }
    }

    public string Text1
    {
        get { return Button1.GetComponentInChildren<Text>().text; }
        set { Button1.GetComponentInChildren<Text>().text = value; }
    }

    public string Text2
    {
        get { return Button2.GetComponentInChildren<Text>().text; }
        set { Button2.GetComponentInChildren<Text>().text = value; }
    }

    public string Text3
    {
        get { return Button3.GetComponentInChildren<Text>().text; }
        set { Button3.GetComponentInChildren<Text>().text = value; }
    }
  


    public void onButtonClicked(int buttonIndex)
    {
        if (buttonIndex == 1)
        {
            if (Text1 == "Howdy feller")
            {
                animator.SetTrigger("IdleToLook");
                InfoText = "HE IS BETTER";
                Text1 = "Choice 1.1";
                Text2 = "Delicious";
                Text3 = "Spook";
            }
            else if (Text1 == "Choice 1.1")
            {
                InfoText = "YOU WIN";
                Text1 = "-";
                Text2 = "-";
                Text3 = "-";
            }
            else
            {
                Debug.LogError("Button 1 Unknown Choice", this);
            }
        }
        else if (buttonIndex == 2)
        {
            if (Text2 == "Choice 2")
            {
                InfoText = "HE IS SAD";
                Text1 = "Choice 2.1";
                Text2 = "Choice 2.2";
                Text3 = "Choice 2.3";
            }
            if (Text2 == "Delicious")
            {
                animator.SetTrigger("StandToStepScare");
                InfoText = "HE IS ANGRTY";
                Text1 = "Choice 2.1";
                Text2 = "Choice 2.2";
                Text3 = "Choice 2.3";
            }
            else
            {
                Debug.LogError("Button 2 Unknown Choice", this);
            }
        }
        else if (buttonIndex == 3)
        {
            if (Text3 == "Choice 3")
            {
                InfoText = "HE IS CONFUSED";
                Text1 = "Choice 3.1";
                Text2 = "Choice 3.2";
                Text3 = "Choice 3.3";
            }
            else if (Text3 == "Spook")
            {
                animator.SetTrigger("StandToStepScare");
                InfoText = "HE IS SCARED";
                Text1 = "Choice 3.1";
                Text2 = "Choice 3.2";
                Text3 = "Choice 3.3";
            }
            else
            {
                Debug.LogError("Button 3 Unknown Choice", this);
            }
        }
        else
        {
            Debug.LogError("Button Unknown Index", this);
        }
    }

    void Start()
    {
        InfoText = "A MAN IS THERE";
        Text1 = "Howdy feller";
        Text2 = "Choice 2";
        Text3 = "Choice 3";
    }
}
