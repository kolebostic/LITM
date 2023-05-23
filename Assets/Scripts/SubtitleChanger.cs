using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubtitleChanger : MonoBehaviour
{
    public Text subtitles;
    public AudioSource[] voiceAudio;
    private string voiceLine;
    private Scene currentScene;
    private string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (sceneName == "MainMenu")
        {
            StartCoroutine(GameWakeInitLines());
        }
        if (sceneName == "NewMainScene" && GameDataTracker.scenesCompleted == 0)
        {
            StartCoroutine(MainSceneInitLines());
        }
        if (sceneName == "NewMainScene" && GameDataTracker.scenesCompleted == 1)
        {
            StartCoroutine(FirstClearing());
        }
        if (sceneName == "NewMainScene" && GameDataTracker.scenesCompleted == 2)
        {
            StartCoroutine(SecondClearing());
        }
        if (sceneName == "NewMainScene" && GameDataTracker.scenesCompleted == 3)
        {
            StartCoroutine(ThirdClearing());
        }
        if (sceneName == "SpringScene")
        {
            StartCoroutine(SpringInitLines());
        }
        if (sceneName == "SummerScene")
        {
            StartCoroutine(SummerInitLines());
        }
        if (sceneName == "FallScene")
        {
            StartCoroutine(AutumnInitLines());
        }
        if (sceneName == "WinterScene")
        {
            StartCoroutine(WinterInitLines());
        }
        if (sceneName == "GoodEnd")
        {
            StartCoroutine(GoodEnding());
        }
        if (sceneName == "BadEnd")
        {
            StartCoroutine(BadEnding());
        }
    }

    // Update is called once per frame
    void Update()
    {
        subtitles.text = voiceLine;
    }
    IEnumerator GameWakeInitLines()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: Welcome, traveler! Please, do not be alarmed; \n we have been expecting you.";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(5.6f);
        voiceLine = "Mist: Take a moment to breathe; calm yourself. \n You have found a safe place.";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(5.4f);
        voiceLine = "Both: The place you have been looking for.";
        voiceAudio[2].Play();
        yield return new WaitForSeconds(2.7f);
        voiceLine = "";
    }
    IEnumerator MainSceneInitLines()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: The path has brought you here, \n another will send you forth.";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Mist: The path is, however, yours to make.";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(3.2f);
        voiceLine = "Blisty: You are not alone; \n we will be here to guide you.";
        voiceAudio[2].Play();
        yield return new WaitForSeconds(3.4f);
        voiceLine = "Mist: Just as the others who \n courageously came before.";
        voiceAudio[3].Play();
        yield return new WaitForSeconds(3.4f);
        voiceLine = "Both: We know why you are here.";
        voiceAudio[4].Play();
        yield return new WaitForSeconds(2.4f);
        voiceLine = "Blisty: Now. There are four paths \n you can take from this clearing.";
        voiceAudio[5].Play();
        yield return new WaitForSeconds(4.2f);
        voiceLine = "Four paths that will deliver \n you to four clearings.";
        yield return new WaitForSeconds(3.4f);
        voiceLine = "Four clearings that present four \n challenges for you to complete.";
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Four challenges that will \n reward you with four keys.";
        yield return new WaitForSeconds(4.2f);
        voiceLine = "Both: Four keys that will create your path.";
        voiceAudio[6].Play();
        yield return new WaitForSeconds(3.1f);
        voiceLine = "Mist: Your order is not important; \n time matters not to us.";
        voiceAudio[7].Play();
        yield return new WaitForSeconds(4.2f);
        voiceLine = "Blisty: Trust in yourself, and your \n path will be found with ease.";
        voiceAudio[8].Play();
        yield return new WaitForSeconds(4.2f);
        voiceLine = "Now go. We will speak again soon.";
        voiceAudio[9].Play();
        yield return new WaitForSeconds(3.6f);
        voiceLine = "";
    }

    IEnumerator SpringInitLines()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: Welcome to Spring: the land of new \n beginnings and hope for your journey.";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(5.3f);
        voiceLine = "Mist: Light filters through the \n mist, reflecting off the pond.";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(4.1f);
        voiceLine = "Blisty: Anywhere else there may be a rainbow, but instead, we have—";
        voiceAudio[2].Play();
        yield return new WaitForSeconds(4.8f);
        voiceLine = "*ribbit*";
        yield return new WaitForSeconds(1.3f);
        voiceLine = "Mist: Frogs.";
        yield return new WaitForSeconds(0.8f);
        voiceLine = "Blisty: You seem startled; it has \n been a while, hasn’t it?";
        voiceAudio[3].Play();
        yield return new WaitForSeconds(3.6f);
        voiceLine = "Mist: A quiet existence it \n must be without creatures.";
        voiceAudio[4].Play();
        yield return new WaitForSeconds(3.3f);
        voiceLine = "Blisty: Such a dull one, to be sure. \n That is not home.";
        voiceAudio[5].Play();
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Both: Here, we are home.";
        voiceAudio[6].Play();
        yield return new WaitForSeconds(2.8f);
        voiceLine = "Blisty: They are almost home; \n they live in this pond.";
        voiceAudio[7].Play();
        yield return new WaitForSeconds(4.0f);
        voiceLine = "But, they could do with some help.";
        yield return new WaitForSeconds(2.6f);
        voiceLine = "Mist: Your responsibility--";
        voiceAudio[8].Play();
        yield return new WaitForSeconds(2.0f);
        voiceLine = "Blisty: (pointedly) We love to help \n one another, right?";
        yield return new WaitForSeconds(4.1f);
        voiceLine = "Mist: One good turn deserves another.";
        voiceAudio[9].Play();
        yield return new WaitForSeconds(2.4f);
        voiceLine = "Blisty: Right; step by step, \n like lily pads,";
        voiceAudio[10].Play();
        yield return new WaitForSeconds(3.8f);
        voiceLine = "you create a path to good tidings!";
        yield return new WaitForSeconds(2.4f);
        voiceLine = "Mist: That’s enough. Let them work; \n get the frogs in the pond.";
        voiceAudio[11].Play();
        yield return new WaitForSeconds(4.5f);
        voiceLine = "";
    }

    IEnumerator SummerInitLines()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Mist: This is Summer; the clearing \n from before extends out here.";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(4.6f);
        voiceLine = "Blisty: Summers look different \n outside of the forest, right?";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(3.5f);
        voiceLine = "I am pretty sure they get \n lots of sun out there.";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Mist: Normally, yes. It’s unrelenting, though";
        voiceAudio[2].Play();
        yield return new WaitForSeconds(4.5f);
        voiceLine = "Being under the shade with \n the mist surrounding everything";
        yield return new WaitForSeconds(2.7f);
        voiceLine = "is much more pleasant for some creatures.";
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Blisty: At least we have flowers;\n oh wait, where did they go?";
        voiceAudio[3].Play();
        yield return new WaitForSeconds(5.0f);
        voiceLine = "Mist: The mist is not \n enough to sustain them;";
        voiceAudio[4].Play();
        yield return new WaitForSeconds(3.4f);
        voiceLine = "the bees alone cannot help.";
        yield return new WaitForSeconds(2.0f);
        voiceLine = "Blisty: That’s a good point. Traveler, \n grab that bucket and water the flowers!";
        voiceAudio[5].Play();
        yield return new WaitForSeconds(4.5f);
        voiceLine = "We need to feed the bees!";
        yield return new WaitForSeconds(2.6f);
        voiceLine = "Mist: They don’t eat flowers. \n Besides, it looks like";
        voiceAudio[6].Play();
        yield return new WaitForSeconds(4.5f);
        voiceLine = "someone else has their eye on those bees.";
        yield return new WaitForSeconds(3.1f);
        voiceLine = "Blisty: Ah, don’t listen to him! \n Three pours should do it!";
        voiceAudio[7].Play();
        yield return new WaitForSeconds(3.9f);
        voiceLine = "";
    }

    IEnumerator AutumnInitLines()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: Fall is such a world of color; ";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(2.6f);
        voiceLine = "it feels like someone just painted \n the entire forest with a giant brush.";
        yield return new WaitForSeconds(5.2f);
        voiceLine = "Mist: I had assumed that you \n had done that to begin with.";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(3.2f);
        voiceLine = "Blisty: Me? Not this whole \n forest; I’m not that good.";
        voiceAudio[2].Play();
        yield return new WaitForSeconds(4.1f);
        voiceLine = "Mist: My mistake.";
        voiceAudio[3].Play();
        yield return new WaitForSeconds(2.0f);
        voiceLine = "Blisty: Oh wait, they’re apple trees! \n We should get some; the animals will love it.";
        voiceAudio[4].Play();
        yield return new WaitForSeconds(6.0f);
        voiceLine = "Mist: Can’t they climb \n the trees themselves?";
        voiceAudio[5].Play();
        yield return new WaitForSeconds(3.3f);
        voiceLine = "Blisty: Some can, but not all of them. \n Let’s make it easier for them.";
        voiceAudio[6].Play();
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Grab all the apples you can reach \n and put them in the basket.";
        yield return new WaitForSeconds(3.7f);
        voiceLine = "Mist: (chuckles) Careful you don’t get too hungry.";
        voiceAudio[7].Play();
        yield return new WaitForSeconds(5.2f);
        voiceLine = "";
    }
    IEnumerator WinterInitLines()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Mist: Welcome to Winter; \n I hope you aren’t too cold.";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(4.4f);
        voiceLine = "Blisty: It’s so beautiful here, like a blank canvas! \n Oh, look! There’s a snowman over there.";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(7.2f);
        voiceLine = "Mist: Don’t ask us how it got here. \n  Whose hat is that?";
        voiceAudio[2].Play();
        yield return new WaitForSeconds(4.9f);
        voiceLine = "Blisty: He’s by himself though, \n out here alone in the cold. ";
        voiceAudio[3].Play();
        yield return new WaitForSeconds(3.4f);
        voiceLine = "It’s kind of sad… he needs \n a friend or something.";
        yield return new WaitForSeconds(3.6f);
        voiceLine = "Mist: That’s where you come in: \n let’s make him feel warm and cozy.";
        voiceAudio[4].Play();
        yield return new WaitForSeconds(5.7f);
        voiceLine = "";
    }

    IEnumerator FirstClearing()
    {
        yield return new WaitForSeconds(2.0f);
        voiceLine = "Blisty: Hooray, you got a key! \n Keep it up, you’ve got it!";
        voiceAudio[10].Play();
        yield return new WaitForSeconds(4.2f);
        voiceLine = "Mist: I wonder how they got it. \n Are you sure of your choice?";
        voiceAudio[11].Play();
        yield return new WaitForSeconds(5.0f);
        voiceLine = "";
    }

    IEnumerator SecondClearing()
    {
        yield return new WaitForSeconds(2.0f);
        voiceLine = "Mist: Halfway there: how does it feel?";
        voiceAudio[12].Play();
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: Are you excited? Maybe nervous? Maybe both?!";
        voiceAudio[13].Play();
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Mist: Calm down.";
        voiceAudio[14].Play();
        yield return new WaitForSeconds(2.0f);
        voiceLine = "";
    }

    IEnumerator ThirdClearing()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: Good job! \n (whispering) Does this mean they leave here soon?";
        voiceAudio[15].Play();
        yield return new WaitForSeconds(4.4f);
        voiceLine = "Mist: Naturally.";
        voiceAudio[16].Play();
        yield return new WaitForSeconds(1.4f);
        voiceLine = "Blisty: Noooooo, I hate it \n when they leave so soon.";
        voiceAudio[17].Play();
        yield return new WaitForSeconds(3.5f);
        voiceLine = "Mist: You never know; maybe \n our friend will want to stay.";
        voiceAudio[18].Play();
        yield return new WaitForSeconds(4.2f);
        voiceLine = "";
    }

    IEnumerator GoodEnding()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: You have done well, so very well.";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(4.0f);
        voiceLine = "You have stayed true to your \n ambition as well as your heart.";
        yield return new WaitForSeconds(4.0f);
        voiceLine = "You took no fear in straying from \n the road to lend a helping hand,";
        yield return new WaitForSeconds(3.6f);
        voiceLine = "because you knew you would \n always find your way back.";
        yield return new WaitForSeconds(2.9f);
        voiceLine = "Back home. Back to your destiny.";
        yield return new WaitForSeconds(3.2f);
        voiceLine = "You have always wanted to \n see the world, haven’t you?";
        yield return new WaitForSeconds(2.9f);
        voiceLine = "Your village, shrouded in a mellowed air, \n surrounded by nothing but forest and fog.";
        yield return new WaitForSeconds(5.6f);
        voiceLine = "The mist has not been kind to you, has it?";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "There is more out there, and you were brave \n enough to try and reach it. You are almost there.";
        yield return new WaitForSeconds(7.0f);
        voiceLine = "Your path is clear now; you should soon see \n the mist lift enough to show you your way. ";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "Do you have enough supplies with you?";
        yield return new WaitForSeconds(2.8f);
        voiceLine = "I wish you well, and would wish to meet again, \n but I don’t believe that is what you would want.";
        yield return new WaitForSeconds(5.6f);
        voiceLine = "Go, travel beyond this place, and bask in the sun’s warmth. ";
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Meet others, creatures different from you.";
        yield return new WaitForSeconds(2.8f);
        voiceLine = "I think you will find it rewarding. Goodbye, and good luck!";
        yield return new WaitForSeconds(5.3f);
        voiceLine = "";
        yield return new WaitForSeconds(3.0f);
        voiceAudio[1].Play();
        voiceLine = "World Design/Lead Developer \n Asset Manager/Artistic Director \n Kole Bostic";
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Story Writer/Artistic Manager \n Brenda Segda";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Scene Design/Assistant Developer \n Teuta Salihu";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Executive Producer/Artistic Manager \n Sabrina Balcerak";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: Brenda Segda \n Mist: Kole Bostic";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "Music by Ludoloon Studio \n 'Mysterious Fog'";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "Thanks for playing Lost in the Mist!";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "...really. It means so much. :')";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "";
        yield return new WaitForSeconds(10.0f);
        voiceLine = "Feel free to end the game now. \n Or maybe you could just stay a while.";
        yield return new WaitForSeconds(8.0f);
        voiceLine = "";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "Have yourself an apple if \n you want. You've earned it!";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "I once fed a giant squirrel and he \n made a big crunch sound. Just saying.";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "";
    }
    
    IEnumerator BadEnding()
    {
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Mist: Your path is your own. \n We knew why you came here.";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(4.6f);
        voiceLine = "You were not the first. (wolf howls) \n You will not be the last.";
        yield return new WaitForSeconds(6.5f);
        voiceLine = "I commend your resolve, though it may \n have been placed into better ethos.";
        yield return new WaitForSeconds(5.2f);
        voiceLine = "I have said, an unwavering focus on your goals \n supports your ambitions... unless other forces are involved.";
        yield return new WaitForSeconds(8.8f);
        voiceLine = "Your village was dark, feeling desolate.";
        yield return new WaitForSeconds(3.2f);
        voiceLine = "There were people, there was a chance at life but, \n to you, it was not truly a life.";
        yield return new WaitForSeconds(6.6f);
        voiceLine = "You wished to break free, regardless of the \n tales of warning passed down from youth.";
        yield return new WaitForSeconds(6.0f);
        voiceLine = "Better to risk your life than \n stay where you were, unsatisfied.";
        yield return new WaitForSeconds(4.8f);
        voiceLine = "How could one ever find satisfaction \n in such an unfortunate state?...";
        yield return new WaitForSeconds(5.6f);
        voiceLine = "But that’s not what really happened, was it?";
        yield return new WaitForSeconds(3.5f);
        voiceLine = "You are not here for want of freedom. \n For want of exploration, of expanding your horizons,";
        yield return new WaitForSeconds(6.9f);
        voiceLine = "of seeing what a horizon really is, or \n the beauty of the sun sinking past it.";
        yield return new WaitForSeconds(5.5f);
        voiceLine = "Such a thing slips through \n your fingers, meaninglessly.";
        yield return new WaitForSeconds(4.3f);
        voiceLine = "Each breath, slipping in and out \n of your lungs without a thought";
        yield return new WaitForSeconds(3.6f);
        voiceLine = "of what it could be used for, \n aside from self-preservation.";
        yield return new WaitForSeconds(5.1f);
        voiceLine = "I do not pretend to \n know everything of you.";
        yield return new WaitForSeconds(2.9f);
        voiceLine = "You are here for the hunt, to lay \n claim to the wonders of this forest,";
        yield return new WaitForSeconds(4.6f);
        voiceLine = "or to search for one of your \n own who has met the same fate.";
        yield return new WaitForSeconds(4.1f);
        voiceLine = "You blend together after a while, you know?";
        yield return new WaitForSeconds(4.3f);
        voiceLine = "I recognize you only from your patterns of actions, \n those tales of hunger, amusement, and destruction.";
        yield return new WaitForSeconds(7.8f);
        voiceLine = "One day I hope they fade away, banishing the mist \n from this place and setting free the lost travelers.";
        yield return new WaitForSeconds(7.7f);
        voiceLine = "pitiful souls, into the sun \n and the grasslands outside.";
        yield return new WaitForSeconds(4.7f);
        voiceLine = "And I will fade too, move beyond \n this role into something more fulfilling...";
        yield return new WaitForSeconds(5.4f);
        voiceLine = "having peace instead of \n obstructing her view...";
        yield return new WaitForSeconds(4.5f);
        voiceLine = "but this is for naught.";
        yield return new WaitForSeconds(3.1f);
        voiceLine = "That time is not now, and your path is here.";
        yield return new WaitForSeconds(4.3f);
        voiceLine = "(chuckles) Looking for your keys? \n I’m afraid you don’t have them.";
        yield return new WaitForSeconds(7.6f);
        voiceLine = "They have crumbled into dust, \n if they were even there at all.";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "Your skeleton keys were \n better called 'phantoms.'";
        yield return new WaitForSeconds(4.6f);
        voiceLine = "Though your path ends here, this \n need not be the end of your story.";
        yield return new WaitForSeconds(4.8f);
        voiceLine = "The mist surrounds and fills this \n place, maybe even guiding you.";
        yield return new WaitForSeconds(5.7f);
        voiceLine = "You will join the rest of them, \n transformed into the unity,";
        yield return new WaitForSeconds(4.0f);
        voiceLine = "into the mist, but still able \n to persevere on your own.";
        yield return new WaitForSeconds(4.6f);
        voiceLine = "Sounds pleasant, does it not?";
        yield return new WaitForSeconds(3.4f);
        voiceLine = "Take a moment to breathe; calm yourself. \n You have found a safe place.";
        yield return new WaitForSeconds(6.0f);
        voiceLine = "The place you had been looking for.";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Now, go. We will speak again soon.";
        yield return new WaitForSeconds(4.5f);
        voiceLine = "";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(2.0f);
        voiceLine = "World Design/Lead Developer \n Asset Manager/Artistic Director \n Kole Bostic";
        yield return new WaitForSeconds(4.0f);
        voiceLine = "Story Writer/Artistic Manager \n Brenda Segda";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Scene Design/Assistant Developer \n Teuta Salihu";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Executive Producer/Artistic Manager \n Sabrina Balcerak";
        yield return new WaitForSeconds(3.0f);
        voiceLine = "Blisty: Brenda Segda \n Mist: Kole Bostic";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "Music by Ludoloon Studio \n 'Mysterious Fog'";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "Thanks for playing Lost in the Mist!";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "...you may now leave this place.";
        yield return new WaitForSeconds(5.0f);
        voiceLine = "";
    }
}
