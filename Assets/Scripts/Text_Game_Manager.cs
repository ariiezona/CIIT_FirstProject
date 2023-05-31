using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_Game_Manager : MonoBehaviour
{

    //declares int variable
    public int hpValue, sanityValue;
    //declares TextMeshPro variable
    public TextMeshProUGUI hpTextValue, sanityTextValue, storyTextValue;
    //declares string variable
    public string startOfStory;
    //declares game object
    public GameObject level1_Choices;


    // Start is called before the first frame update
    void Start()
    {
        hpValue = 10;
        sanityValue = 10;
        startOfStory = "I woke up from a deep and refreshing sleep";
    }

    // Update is called once per frame
    void Update()
    {
        //Textmesh pro Variable = hpValue int
        hpTextValue.text = hpValue.ToString();
        sanityTextValue.text = sanityValue.ToString();
        storyTextValue.text = startOfStory;
    }

    public void exploreRoom()
    {
        hpValue -= 2;
        startOfStory = "You stubbed your toe";
        level1_Choices.SetActive(false);
    }
    public void doMorningRoutine()
    {

    }
    public void goBackToSleep()
    {

    }
}
