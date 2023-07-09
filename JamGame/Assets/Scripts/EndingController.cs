using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingController : MonoBehaviour
{
    private TMPro.TMP_Text endingText;
    private Image ColorImage;

    // Start is called before the first frame update
    void Start()
    {
        //reads the color image from the screen
        ColorImage = GameObject.Find("BackgroundColorLayer").GetComponent<Image>();

        //splits the ending text into the text to display and the ending conditions
        string[] endingConditions = InterMenuSelection.Endtext.Split("|$|");

        //get the tecxt object to use for displaying the ending text
        endingText = GameObject.Find("Ending Text").GetComponent<TMPro.TMP_Text>();

        //displays the ending text
        endingText.text = endingConditions[0];

        //checks if you failed to not get scammed
        if(endingConditions[1] == "F"){
            ColorImage.color = new Color(188, 0, 0, 255);
        }else{
            ColorImage.color = new Color(56, 170, 183, 255);
        }
    }

    public void returnToMenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
