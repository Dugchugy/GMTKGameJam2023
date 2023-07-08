using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingController : MonoBehaviour
{
    private TMPro.TMP_Text endingText;

    // Start is called before the first frame update
    void Start()
    {
        //splits the ending text into the text to display and the ending conditions
        string[] endingConditions = InterMenuSelection.Endtext.Split("|$|");

        //get the tecxt object to use for displaying the ending text
        endingText = GameObject.Find("Ending Text").GetComponent<TMPro.TMP_Text>();

        //displays the ending text
        endingText.text = endingConditions[0];
    }

    public void returnToMenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
