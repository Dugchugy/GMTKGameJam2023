using UnityEngine;

public class SwitchBackground : MonoBehavior
{
    private SpriteRenderer spriteRenderer;
    //public string background1Path;
    //public string background2Path;

    void Start()
    {

    }

    void Update(
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // if statements to load different backgrounds - if input is A.. if input is B ... etc.
            
            //spriteRenderer.sprite = Resources.Load<Sprite>(background1Path);
            //spriteRenderer.sprite = Resources.Load<Sprite>(background2Path);
        }
    }
    )
}