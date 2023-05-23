using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpringCompletion : MonoBehaviour
{
    public AudioSource[] voiceAudio;
    public Text subtitles;
    private string voiceLine;
    // Start is called before the first frame update
    void Start()
    {
        if (SpringDataTracker.springGoodCount > 2)
        {
            StartCoroutine(SpringGoodKey());
        }
        else if (SpringDataTracker.springBadCount > 2)
        {
            StartCoroutine(SpringBadKey());
        }
    }
    void Update()
    {
        subtitles.text = voiceLine;
    }
    IEnumerator SpringGoodKey()
    {
        yield return new WaitForSeconds(1.0f);
        voiceLine = "Blisty: Well done! Now they can all be \n together and";
        voiceAudio[0].Play();
        yield return new WaitForSeconds(2.9f);
        voiceLine = "enjoy this beautiful place, coming and going as they please.";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(4.1f);
        voiceLine = "Take this key and enjoy this moment.";
        voiceAudio[2].Play();
        yield return new WaitForSeconds(2.5f);
        voiceLine = "";
    }

    IEnumerator SpringBadKey()
    {
        yield return new WaitForSeconds(1.0f);
        voiceLine = "Mist: (chuckles) That’s one way of doing it.";
        voiceAudio[1].Play();
        yield return new WaitForSeconds(4.2f);
        voiceLine = "Well done, they are all where they need to be.";
        yield return new WaitForSeconds(3.5f);
        voiceLine = "Worry not, they can swim. They are \n united but can still be on their own.";
        yield return new WaitForSeconds(6.5f);
        voiceLine = "Sounds pleasant, doesn’t it?";
        yield return new WaitForSeconds(1.6f);
        voiceLine = "Here, take this key; you will be needing it.";
        yield return new WaitForSeconds(3.6f);
        voiceLine = "";
    }
}
