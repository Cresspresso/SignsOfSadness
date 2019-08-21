using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTree : MonoBehaviour
{
    ConvNode rootNode;
    public Text infoText;
    public Button[] buttons = new Button[3];
    
    class ConvNode
    {
        public string prompt;
        public string[] choices = new string[3] { "", "", "" };
        public ConvNode[] options = new ConvNode[3] { null, null, null };
    }

    void clickButton(int i)
    {
        rootNode = rootNode.options[i];
        loadNode();
    }

    void loadNode()
    {
        infoText.text = rootNode.prompt; // set prompt text

        // for each option button
        for (int i = 0; i < 3; ++i)
        {
            var button = buttons[i];
            button.GetComponentInChildren<Text>().text = rootNode.choices[i]; // set button text
            button.interactable = rootNode.options[i] != null; // gray out button if no next node
        }
    }
    
    void Start()
    {
        // for each button
        for (int i = 0; i < buttons.Length; i++)
        {
            // pass value by value instead of reference
            int tempi = i;

            // add listener to call clickButton with button index.
            buttons[i].onClick.AddListener(() => clickButton(tempi));
        }

        rootNode = new ConvNode();
        var node2 = new ConvNode();
        var node3 = new ConvNode();
        var node4 = new ConvNode();
        var node5 = new ConvNode();
        var node6 = new ConvNode();
        var node7 = new ConvNode();
        var node8 = new ConvNode();

        {
            node8.prompt = "But I'm missing out on their lives. I don't know what to do.";
            node8.choices[0] = "Surely they would understand?";
            node8.choices[1] = "Well, what can you do?";
            node8.choices[2] = "Maybe you can ask for some time off?";
        }

        {
            node7.prompt = "I need the money, I need to pay the bills and support my children.";
            node7.choices[0] = "...";
            node7.options[0] = node8;
        }

        {
            node6.prompt = "I just told you. I'm working too much.";
            node6.choices[0] = "...";
            node6.options[0] = node8;
        }

        {
            node5.prompt = "I don't have enough time for my family.";
            node5.choices[0] = "Sure you do.";
            node5.choices[1] = "Why not?";
            node5.options[1] = node6;
            node5.choices[2] = "Why are you working so much?";
            node5.options[2] = node7;
        }

        {
            node4.prompt = "I'm just tired. I've been working too much.";
            node4.choices[0] = "I know how you feel.";
            node4.choices[1] = "Tell me about it.";
            node4.choices[2] = "Are you struggling with something?";
            node4.options[2] = node5;

        }

        {
            node3.prompt = "...";
            node3.choices[0] = "Well, Whatever then.";
            node3.choices[1] = "Hey, did you hear me?";
            node3.choices[2] = "Do you want to talk about it?";
            node3.options[2] = node4;
        }

        {
            node2.prompt = "Yeah, I'm okay thanks.";
            node2.choices[0] = "You don't look alright.";
            node2.options[0] = node3;
        }

        {
            rootNode.prompt = "...";
            rootNode.choices[0] = "Hey, are you alright?";
            rootNode.options[0] = node2;
        }

        loadNode();



        ////node 0
        //nodes[0] = new ConvNode();
        //nodes[0].prompt = "...";
        //nodes[0].options[0] = new OptionButton();
        //nodes[0].options[1] = new OptionButton();
        //nodes[0].options[2] = new OptionButton();
        //nodes[0].options[0].reply = "Hey buddy, what the hell are you doing?";
        //nodes[0].options[0].link = 1;
        //nodes[0].options[0].effects = "effect1";

        //nodes[0].options[1].reply = "Let her go or I'll call the police!";
        //nodes[0].options[1].link = 1;

        //nodes[0].options[2].reply = "Sir, I suggest you let that woman go.";
        //nodes[0].options[2].link = 1;
        //nodes[0].options[2].effects[0] = "effect2";
        //nodes[0].options[2].effects[1] = "effect3";
        //// node 1
        //nodes[1] = new ConvNode();
        //nodes[1].prompt = "Get away from me! I don't want to hurt her but I will. And you, if you don't walk away!";
        //nodes[1].options[0] = new OptionButton();
        //nodes[1].options[1] = new OptionButton();
        //nodes[1].options[0].reply = "Take it easy, we can just talk about it. What happened?";
        //nodes[1].options[0].link = 2;
        //nodes[1].options[1].reply = "Be smart, man. Give up, you're not going to get away.";
        //nodes[1].options[1].link = 2;
        ////node 2
        //nodes[2] = new ConvNode();
        //nodes[2].prompt = "No! I am done talking. Talking is what I've done for the past half year. Talking is what I've been doing in court. I won't let her take my Ben.";
        //nodes[2].options[0] = new OptionButton();
        //nodes[2].options[1] = new OptionButton();
        //nodes[2].options[0].reply = "Your Ben? Is he your kid? Is this woman your wife?";
        //nodes[2].options[0].link = 3;
        //nodes[2].options[1].reply = "Look, buddy, relax. You're not going to accomplish anything like this. Put down the gun.";
        //nodes[2].options[1].link = 3;
        ////node 3
        //nodes[3] = new ConvNode();
        //nodes[3].prompt = "Ben is... He's my son. *to woman* Hear that, bitch? MY son! *to player* She's trying to take him from me. Josh, Ben needs a better father, she said. While he was in the damn living room with us!";
        //nodes[3].options[0] = new OptionButton();
        //nodes[3].options[1] = new OptionButton();
        //nodes[3].options[0].reply = "<say nothing>";
        //nodes[3].options[0].link = 4;
        //nodes[3].options[1].reply = "<say nothing>";
        //nodes[3].options[1].link = 4;
        ////node 4
        //nodes[4] = new ConvNode();
        //nodes[4].prompt = "Woman: You know Ben deserves better than you! This proves it, doesn't it?";
        //nodes[4].options[0] = new OptionButton();
        //nodes[4].options[1] = new OptionButton();
        //nodes[4].options[0].reply = "<say nothing>";
        //nodes[4].options[0].link = 0;
        //nodes[4].options[1].reply = "<say nothing>";
        //nodes[4].options[1].link = 0;

    }
}
