using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScammerControl : MonoBehaviour
{

    public List<StateBase> states;

    private StateController controller;

    private bool FirstFrame = true;

    private StateBase curState;

    // Start is called before the first frame update
    void Start()
    {
        FirstFrame = true;

        //initalizes as an empty list
        states = new List<StateBase>();

        //reads teh state controller off this object
        controller = gameObject.GetComponent<StateController>();

        //temp controls
        //loads the test scam
        LoadFromResource("Scams/TestScam/TestScam");

        curState = states[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(FirstFrame){
            //calls the state controller to update with the initial state (doesn't work while start is executed)
            controller.QueueUpdate(curState);

            //marks that the first frame has passed
            FirstFrame = false;
        }
    }

    void LoadFromResource(string resourceName){
        //initalizes as an empty list
        states = new List<StateBase>();

        Debug.Log("loading resource: " + resourceName);

        //attempts to read the content of the specifed resource as a string
        string Filetext = Resources.Load<TextAsset>(resourceName).ToString();

        //splits up the lines
        string[] lines = Filetext.Split('\n');

        //loops for each line
        for(int i = 0; i < lines.Length; i++){

            //adds a new state to the state list for each line
            states.Add(new StateBase(lines[i]));

        }

        //links all the states together
        connectLinks(states);

        
    }

    public void progressScammerText(){
        //logs  that the state is changing
        Debug.Log("changing state");

        //moves to the next state
        curState = curState.nextState[0];

        //queues the state controller to update to the next state
        controller.QueueUpdate(curState);
    }

    static void connectLinks(List<StateBase> states){

        //loops for each state in the list
        states.ForEach(delegate(StateBase state){

            //only links if first state is not -1 (ending state)
            if(state.linkIndexs[0] >= 0){

                //creates a array of links to the next state from the state lengths
                state.nextState = new StateBase[state.linkIndexs.Length];

                //loops for each of the attempted links
                for(int i = 0; i < state.linkIndexs.Length; i++){
                    //creates a link
                    state.nextState[i] = states[state.linkIndexs[i]];
                }

                //marks that the state is linked
                state.linked = true;

            }

        });
    }
}
