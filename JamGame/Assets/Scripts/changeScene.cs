using UnityEngine;

public class SwitchBackground : MonoBehavior
{
    private SpriteRenderer spriteRenderer;
    //public string defaultBackgroundPath;
    //public string firstBackgroundPath;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Resources.Load<Sprite>(defaultBack);
    }

    void Update(
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //If statements to load different backgrounds - if input is A.. if input is B ... etc.

            //spriteRenderer.sprite = Resources.Load<Sprite>(defaultBack);
            //spriteRenderer.sprite = Resources.Load<Sprite>(firstBackground);
        }
    }
    )
}