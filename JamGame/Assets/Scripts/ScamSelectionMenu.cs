using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScamSelectionMenu : MonoBehaviour
{
    public void SelectCRA(){
        //stores the path for the CRA scammer image
        InterMenuSelection.scammerImagePath = "Scams/CRAScam/scammerman";

        //stores the path for the CRA scam text
        InterMenuSelection.scammerTextPath = "Scams/CRAScam/CRAScam";

        //loads the main interaction Scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void SelectAuto(){
        //stores the path for the CRA scammer image
        InterMenuSelection.scammerImagePath = "Scams/autoScam/AutoScammer";

        //stores the path for the CRA scam text
        InterMenuSelection.scammerTextPath = "Scams/autoScam/autoScam";

        //loads the main interaction Scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void MoveToScamSelection(){
        //moves to the scam selection scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
