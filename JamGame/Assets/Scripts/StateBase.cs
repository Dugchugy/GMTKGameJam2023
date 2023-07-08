

public class StateBase
{
    public string[] contents;

    public int type;

    public StateBase[] nextState;

    public bool linked;

    public int[] linkIndexs;

    public StateBase(){
        //initalizes the state base as a colelction of unlinked, empty lists
        contents = new string[0];
        type = 0;
        nextState = new StateBase[0];
        linked = false;
        linkIndexs = new int[0];
    }

    public StateBase(string fileLine){
        //splits the line base on its 
        string[] parts = fileLine.Split("|!|");

        //takes the first part and stores int as the type
        type = int.Parse(parts[0]);

        //creates new content and linkIndexs arrays
        contents = new string[parts.Length - 1];
        linkIndexs = new int[parts.Length - 1];

        //loops for all the remaining parts
        for(int i = 1; i < parts.Length; i++){
            //splits the string on the |&| symbol
            string[] subparts = parts[i].Split("|&|");

            //reads the subpart type as content
            contents[i - 1] = subparts[0];

            //reads teh second subpart as the link index
            linkIndexs[i - 1] = int.Parse(subparts[1]) - 1;
        }

        nextState = new StateBase[0];
        linked = false;
    }
}
