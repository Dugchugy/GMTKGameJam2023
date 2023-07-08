using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public bool isUpdating;

    public int curLength;
    public int finalLength;

    public float typeRate = 30;

    public string[] finalTexts;

    public int curType = 0;

    private float passedTime = 0;

    private float timePerChar = 0;

    private GameObject ScammerFrame;
    private GameObject OptionsFrame;
    private GameObject EndingFrame;

    // Start is called before the first frame update
    void Start()
    {
        timePerChar = 1.0f/typeRate;

        //gets the frames
        ScammerFrame = GameObject.Find("ScammerText");
        OptionsFrame = GameObject.Find("Options");

        //intializes the state controller to a non-updating, textless state
        curType = 0;
        isUpdating = false;
        curLength = 0;
        finalLength = 0;
        finalTexts = new string[] {"baseText"};
    }

    // Update is called once per frame
    void Update()
    {
        if(isUpdating && curType > 0){
            //adds the delta time to the passed time
            passedTime += Time.deltaTime;

            //loop until the passed time is less than the time required to write on char
            while(passedTime >= timePerChar){
                //decreases the plassed time by the time to write one char
                passedTime -= timePerChar;
                curLength += 1;

                //breaks the loop if the current length is longer than the longest string
                if(curLength >= finalLength){
                    break;
                }
            }

            if(curLength >= finalLength){
                isUpdating = false;
            }

            //switches based on teh current type
            switch(curType){

            case 1:
                //gets the text source from the scammer frame
                TMPro.TMP_Text text = ScammerFrame.transform.GetChild(0).gameObject.GetComponent<TMPro.TMP_Text>();

                //writes that it's current text should be...
                text.text = finalTexts[0].Substring(0, curLength);
                break;

            default:

                break;
            }
        }
    }

    public void QueueUpdate(StateBase newState){

        //resets the current length
        curLength = 0;

        //queues more updates to occur later
        isUpdating = true;

        //stores the final length (sets to 0 to be overridden later)
        finalLength = 0;

        //craetes a new array to copy the contents too
        finalTexts = new string[newState.contents.Length]; 

        for(int i = 0; i < newState.contents.Length; i++){
            //copies the current content to the final texts
            finalTexts[i] = newState.contents[i];

            //checks if the current final text is longer than final length
            if(finalLength < finalTexts[i].Length){
                //bumps the length up to match the final texts
                finalLength = finalTexts[i].Length;
            }
        }

        //sets the type
        curType = newState.type;

        //switchs to enabled the correct frame based on the current state type
        switch(curType){
            case 1:
                //enables the scammer frame
                ScammerFrame.SetActive(true);

                //disables the options frame
                OptionsFrame.SetActive(false);

                break;

            default:

                //disables the scammer frame
                ScammerFrame.SetActive(false);

                //enables the options frame
                OptionsFrame.SetActive(true);

                break;
        }

    }
}
