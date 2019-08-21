using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueTree : MonoBehaviour
{
    ConvNode rootNode;
    public Text infoText;
    public Button[] buttons = new Button[3];
    public Animator animator;
    
    class ConvNode
    {
        public string prompt;
        public string[] choices = new string[3] { "", "", "" };
        public ConvNode[] options = new ConvNode[3] { null, null, null };
        public Action onLoad = null;
    }

    ConvNode goToMenuNode;

    void clickButton(int i)
    {
        if (rootNode.options[i] == goToMenuNode)
        {
            SceneManager.LoadScene("Menu");
        }
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

        if (rootNode.onLoad != null)
        {
            rootNode.onLoad();
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
        goToMenuNode = new ConvNode();
        var node02 = new ConvNode();
        var node03 = new ConvNode();
        var node04 = new ConvNode();
        var node05 = new ConvNode();
        var node06 = new ConvNode();
        var node07 = new ConvNode();
        var node08 = new ConvNode();
        var node09 = new ConvNode();
        var node10 = new ConvNode();
        var node11 = new ConvNode();
        var node12 = new ConvNode();
        var node13 = new ConvNode();
        var node14 = new ConvNode();
        var node15 = new ConvNode();
        var node16 = new ConvNode();
        var node17 = new ConvNode();
        var node18 = new ConvNode();
        var node19 = new ConvNode();
        var node20 = new ConvNode();
        var node21 = new ConvNode();
        var node22 = new ConvNode();
        var node23 = new ConvNode();
        var node24 = new ConvNode();
        var node25 = new ConvNode();
        var node26 = new ConvNode();
        var node27 = new ConvNode();
        var node28 = new ConvNode();
        var node29 = new ConvNode();
        var node30 = new ConvNode();
        var node31 = new ConvNode();
        var node32 = new ConvNode();
        var node33 = new ConvNode();
        var node34 = new ConvNode();
        var node35 = new ConvNode();
        var node36 = new ConvNode();
        var node37 = new ConvNode();
        var node38 = new ConvNode();
        var node39 = new ConvNode();
        var node40 = new ConvNode();
        var node41 = new ConvNode();
        var node42 = new ConvNode();
        var node43 = new ConvNode();
        var node44 = new ConvNode();
        var node45 = new ConvNode();
        var node46 = new ConvNode();
        var node47 = new ConvNode();
        var node48 = new ConvNode();
        var node49 = new ConvNode();
        var node50 = new ConvNode();
        var node51 = new ConvNode();
        var node52 = new ConvNode();
        var node53 = new ConvNode();
        var node54 = new ConvNode();
        var node55 = new ConvNode();
        var node56 = new ConvNode();
        var node57 = new ConvNode();
        var node58 = new ConvNode();
        var node59 = new ConvNode();
        var node60 = new ConvNode();
        var node61 = new ConvNode();
        var node62 = new ConvNode();
        var node63 = new ConvNode();
        var node64 = new ConvNode();
        var node65 = new ConvNode();
        var node66 = new ConvNode();
        var node67 = new ConvNode();
        var node68 = new ConvNode();
        var node69 = new ConvNode();
        var node70 = new ConvNode();
        var node71 = new ConvNode();
        var node72 = new ConvNode();
        var node73 = new ConvNode();
        var node74 = new ConvNode();
        var node75 = new ConvNode();
        var node76 = new ConvNode();

        {
            node76.prompt = "It's good to have someone who listens.";
            node76.choices[2] = "[Win the Game]";
            node76.options[2] = goToMenuNode;
        }

        {
            node73.prompt = "What...?";
            node73.choices[0] = "...";
            node73.options[0] = node74;

            node74.prompt = "Something is wrong with your head. For the record, I have a wife.";
            node74.choices[0] = "...";
            node74.options[0] = node75;

            node75.prompt = "Speaking of her...";
            node75.choices[0] = "...";
            node75.options[0] = node57;
        }

        {
            node70.prompt = "Yeah... I remember that feeling.";
            node70.choices[0] = "...";
            node70.options[0] = node71;

            node71.prompt = "When I first joined this company, I dedicated everything to my work.";
            node71.choices[0] = "...";
            node71.options[0] = node72;

            node72.prompt = "But even after all this time, I'm stuck at the bottom.";
            node72.choices[0] = "...";
            node72.options[0] = node15;
        }

        {
            node68.prompt = "You're a real piece of work, you hypocrite.";
            node68.choices[0] = "...";
            node68.options[0] = node69;

            node69.prompt = "I don't want to talk anymore. Leave me alone.";
            node69.choices[2] = "[Return to Menu]";
            node69.options[2] = goToMenuNode;
        }

        {
            node66.prompt = "That's what a drone would say.";
            node66.choices[0] = "...";
            node66.options[0] = node67;

            node67.prompt = "You must be high up in the company. Are you?";
            node67.choices[0] = "Wouldn't you like to know?";
            node67.options[0] = node68;
            node67.choices[1] = "I'm just passionate about this company.";
            node67.options[1] = node70;
            node67.choices[2] = "Enough about me. More about you.";
            node67.options[2] = node73;
        }

        {
            node64.prompt = "I don't even know.";
            node64.choices[0] = "...";
            node64.options[0] = node65;

            node65.prompt = "Any legal trouble would be the end of the job at any rate.";
            node65.choices[0] = "...";
            node65.options[0] = node13;
        }

        {
            node62.prompt = "Maybe you're right.";
            node62.choices[2] = "[End]";
            node62.options[2] = goToMenuNode;

            node63.prompt = "I know, I know. But sometimes I just wish that things could be a bit easier.";
            node63.choices[0] = "...";
            node63.options[0] = node23;
        }

        {
            node60.prompt = "Maybe you're right.";
            node60.choices[2] = "[End]";
            node60.options[2] = goToMenuNode;

            node61.prompt = "Yes but for the years I have put into this company I expect some things to have reached my expectations.";
            node61.choices[0] = "...";
            node61.options[0] = node18;
        }

        {
            node56.prompt = "It is a problem and I feel like my kids are growing up without me in their lives.";
            node56.choices[0] = "...";
            node56.options[0] = node57;

            node57.prompt = "I feel like my wife could leave me at any moment and I wouldn't even blame her.";
            node57.choices[0] = "Oof.";
            node57.options[0] = node58;
            node57.choices[1] = "What's your relationship like?";
            node57.options[1] = node59;
            node57.choices[2] = "Have you talked to your family about this?";
            node57.options[2] = node11;

            node58.prompt = "Yeah.. I'm not even kidding.";
            node58.choices[0] = "...";
            node58.options[0] = node13;

            node59.prompt = "Sorry, but that's none of your business.";
            node59.choices[0] = "...";
            node59.options[0] = node15;
        }

        {
            node52.prompt = "That's not the point. It's not right.";
            node52.choices[0] = "...";
            node52.options[0] = node53;

            node53.prompt = "I want to be with my family.";
            node53.choices[0] = "...";
            node53.options[0] = node57;

            node54.prompt = "Yeah, well not much. I was kind of hoping for a more helpful answer.";
            node54.choices[0] = "...";
            node54.options[0] = node55;

            node55.prompt = "I want to spend more time with my family.";
            node55.choices[0] = "...";
            node55.options[0] = node57;

        }

        {
            node49.prompt = "Is that meant to be your way of breaking the ice?";
            node49.choices[0] = "...";
            node49.options[0] = node50;

            node50.prompt = "Well, whatever. But seriously, I don't have enough time for my family.";
            node50.choices[0] = "...";
            node50.options[0] = node07;

            node51.prompt = "You're a strange person, you know that?";
            node51.choices[0] = "...";
            node51.options[0] = node07;
        }

        {
            node45.prompt = "What? What are you playing at?";
            node45.choices[0] = "...";
            node45.options[0] = node46;

            node46.prompt = "You don't know the first thing about me. You don't even know me at all.";
            node46.choices[0] = "I know that you're pretty depressing.";
            node46.options[0] = node47;
            node46.choices[1] = "Hey we've been talking for a good minute or so, haven't we?";
            node46.options[1] = node49;
            node46.choices[2] = "You're right. I'm sorry.";
            node46.options[2] = node51;

            node47.prompt = "Well, screw you too.";
            node47.choices[0] = "...";
            node47.options[0] = node48;

            node48.prompt = "People like you are what's wrong with this world!";
            node48.choices[2] = "[Return to Menu]";
            node48.options[2] = goToMenuNode;
        }

        {
            node44.prompt = "Rough is right. There's too much work, too much time away from home.";
            node44.choices[0] = "...";
            node44.options[0] = node05;
        }

        {
            node42.prompt = "Well, at least you're honest, I guess..";
            node42.choices[0] = "...";
            node42.options[0] = node43;

            node43.prompt = "It's rough. All this work, all this time away from home.";
            node43.choices[0] = "...";
            node43.options[0] = node05;
        }

        {
            node40.prompt = "Is that how you see me? As a curiosity?";
            node40.choices[0] = "Yeah, pretty much.";
            node40.options[0] = node41;
            node40.choices[1] = "No, but I am curious.";
            node40.options[1] = node42;
            node40.choices[2] = "No. I didn't mean it like that. You just look like you're having a rough time of it."; // TODO split
            node40.options[2] = node44;

            node41.prompt = "What's wrong with you? Get the hell away from me!";
            node41.choices[2] = "[Return to Menu]";
            node41.options[2] = goToMenuNode;
        }

        {
            node37.prompt = "Hmm. Yeah, I suppose. I appreciate it.";
            node37.choices[0] = "...";
            node37.options[0] = node39;

            node39.prompt = "It's rough. All this work, all this time away from home.";
            node39.choices[0] = "...";
            node39.options[0] = node05;
        }

        {
            node36.prompt = "Then why are we still talking?";
            node36.choices[0] = "...";
            node36.options[0] = node38;

            node38.prompt = "Go away, you're just wasting my time.";
            node38.choices[2] = "[Return to Menu]";
            node38.options[2] = goToMenuNode;
        }

        {
            node35.prompt = "Why do you even care?";
            node35.choices[0] = "I don't really.";
            node35.options[0] = node36;
            node35.choices[1] = "You got me curious.";
            node35.options[1] = node40;
            node35.choices[2] = "Sometimes we all need someone to talk to.";
            node35.options[2] = node37;
        }

        {
            node33.prompt = "I wonder about that.";
            node33.choices[0] = "...";
            node33.options[0] = node34;

            node34.prompt = "It's rough. All this work, all this time away from home.";
            node34.choices[0] = "...";
            node34.options[0] = node05;
        }

        {
            node27.prompt = "Yeah, sorry. It's kind of a heavy topic.";
            node27.choices[0] = "Oh, okay. I'll leave you to it, then";
            node27.options[0] = node31;
            node27.choices[1] = "No worries, let it all out.";
            node27.options[1] = node32;
            node27.choices[2] = "Do you want to talk about it?";
            node27.options[2] = node04;

            node31.prompt = "Right. Bye.";
            node31.choices[2] = "[Return to Menu]";
            node31.options[2] = goToMenuNode;

            node32.prompt = "Uh, okay?";
            node32.choices[0] = "...";
            node32.options[0] = node04;
        }

        {
            node26.prompt = "Oh gee, thanks.";
            node26.choices[0] = "You're Welcome.";
            node26.options[0] = node28;
            node26.choices[1] = "You didn't answer me. Why are you so glum?";
            node26.options[1] = node29;
            node26.choices[2] = "Sorry, it's just that you didn't say anything.";
            node26.options[2] = node30;

            node28.prompt = "I have enough things to deal with, besides you coming to bother me.";
            node28.choices[2] = "[Return to Menu]";
            node28.options[2] = goToMenuNode;

            node29.prompt = "Well you didn't have to be a prick about it.";
            node29.choices[0] = "...";
            node29.options[0] = node04;

            node30.prompt = "Yeah, sorry.";
            node30.choices[0] = "...";
            node30.options[0] = node04;
        }

        {
            node25.prompt = "Thanks for listening to me ramble.";
            node25.choices[2] = "Anytime. Sometimes we just need someone to talk to.";
            node25.options[2] = node76;
        }

        {
            node23.prompt = "I.. I want to stay in this company. I've put too much into this.";
            node23.choices[0] = "...";
            node23.options[0] = node24;

            node24.prompt = "I can't let my family suffer for my career, but still I don't want to give up!";
            node24.choices[0] = "...";
            node24.options[0] = node25;
        }

        {
            node21.prompt = "My career isn't what's making me unhappy, it's a combination of family and work.";
            node21.choices[0] = "...";
            node21.options[0] = node22;

            node22.prompt = "I cannot balance the two and both tend to suffer because of it. I want to be better.";
            node22.choices[0] = "...";
            node22.options[0] = node25;
        }

        {
            node19.prompt = "I try my hardest everyday, but it never seems to be enough.";
            node19.choices[0] = "...";
            node19.options[0] = node20;

            node20.prompt = "I want my family to be proud of me, I want my children to be proud of me, and I want to have pride in the work that I do.";
            node20.choices[0] = "...";
            node20.options[0] = node25;
        }

        {
            node18.prompt = "I'm all alone in this company. Sometimes I wonder why I even try.";
            node18.choices[0] = "Don't give up.";
            node18.options[0] = node19;
            node18.choices[1] = "If it's not making you happy, then you need to rethink your career.";
            node18.options[1] = node21;
            node18.choices[2] = "What do you want to do?";
            node18.options[2] = node23;
        }

        {
            node17.prompt = "No, I've tried. Most of my co-workers either don't care, or are in the same situation as I am.";
            node17.choices[0] = "...";
            node17.options[0] = node18;
        }

        {
            node16.prompt = "How is this fair?";
            node16.choices[0] = "You might have to find a different company then.";
            node16.options[0] = node60;
            node16.choices[1] = "It's not fair. But we all have to make the best of what we have.";
            node16.options[1] = node63;
            node16.choices[2] = "Is there anyone in this company that can help you?";
            node16.options[2] = node17;
        }

        {
            node15.prompt = "I've put years into this company, and I have little to show for it.";
            node15.choices[0] = "...";
            node15.options[0] = node16;
        }

        {
            node14.prompt = "Yes. Just like everyone else, I guess. I thought that with my skills I would be higher up the ladder by now.";
            node14.choices[0] = "...";
            node14.options[0] = node15;
        }

        {
            node13.prompt = "I never imagined that I'd be struggling like this. This is not what I had in mind.";
            node13.choices[0] = "It seems like you have a decision to make.";
            node13.options[0] = node62;

            node13.choices[1] = "Reality is often different from the picture in your mind.";
            node13.options[1] = node61;

            node13.choices[2] = "Did you have a plan when you joined this company?";
            node13.options[2] = node14;

        }

        {
            node12.prompt = "But she's unhappy with the amount of hours I'm putting in.";
            node12.choices[0] = "...";
            node12.options[0] = node13;

        }

        {
            node11.prompt = "Only my wife. This shouldn't be the childrens' problem.";
            node11.choices[0] = "...";
            node11.options[0] = node12;
        }

        {
            node10.prompt = "He said that there's too much work, and that they can't afford to allow for any time off.";
            node10.choices[0] = "Well, it's for the good of the company.";
            node10.options[0] = node66;
            node10.choices[1] = "Is that even legal?";
            node10.options[1] = node64;
            node10.choices[2] = "That sounds like a serious problem.";
            node10.options[2] = node56;
        }

        {
            node09.prompt = "I tried. My boss won't let me.";
            node09.choices[0] = "...";
            node09.options[0] = node10;

        }

        {
            node08.prompt = "But I'm missing out on their lives. I don't know what to do.";
            node08.choices[0] = "Surely they would understand?";
            node08.options[0] = node52;
            node08.choices[1] = "Well, what can you do?";
            node08.options[1] = node54;
            node08.choices[2] = "Maybe you can ask for some time off?";
            node08.options[2] = node09;
        }

        {
            node07.prompt = "I need the money, I need to pay the bills and support my children.";
            node07.choices[0] = "...";
            node07.options[0] = node08;
        }

        {
            node06.prompt = "I just told you. I'm working too much.";
            node06.choices[0] = "...";
            node06.options[0] = node07;
        }

        {
            node05.prompt = "I don't have enough time for my family.";
            node05.choices[0] = "Sure you do.";
            node05.options[0] = node45;
            node05.choices[1] = "Why not?";
            node05.options[1] = node06;
            node05.choices[2] = "Why are you working so much?";
            node05.options[2] = node07;
        }

        {
            node04.prompt = "I'm just tired. I've been working too much.";
            node04.choices[0] = "I know how you feel.";
            node04.options[0] = node33;
            node04.choices[1] = "Tell me about it.";
            node04.options[1] = node35;
            node04.choices[2] = "Are you struggling with something?";
            node04.options[2] = node05;

        }

        {
            node03.prompt = "...";
            node03.choices[0] = "Well, Whatever then.";
            node03.options[0] = node26;
            node03.choices[1] = "Hey, did you hear me?";
            node03.options[1] = node27;
            node03.choices[2] = "Do you want to talk about it?";
            node03.options[2] = node04;
        }

        {
            node02.prompt = "Yeah, I'm okay thanks.";
            node02.choices[0] = "You don't look alright.";
            node02.options[0] = node03;
            node02.onLoad = () => animator.SetTrigger("LookToStanding");
        }

        {
            rootNode.prompt = "*Crying silently*";
            rootNode.choices[0] = "Hey, are you alright?";
            rootNode.options[0] = node02;
            rootNode.onLoad = () => animator.SetTrigger("CryingToLook");
        }

        loadNode();
    }
}
