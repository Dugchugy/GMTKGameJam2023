using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScamSelectionMenu : MonoBehaviour
{
    public void SelectCRA(){
        //stores the path for the CRA scammer image
        InterMenuSelection.scammerImagePath = "Scams/CRAScam/olddude1";

        //stores the path for the CRA scam text
        InterMenuSelection.scammerTextPath = "Scams/CRAScam/CRAScam";

        //loads the main interaction Scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
