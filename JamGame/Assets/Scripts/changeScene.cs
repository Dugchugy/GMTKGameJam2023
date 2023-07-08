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

    void Update()
    {
            if (Input.GetKeyDown(KeyCode.1)
            {
                spriteRenderer.sprite = Resources.Load<Sprite>(firstBackground);
            }

        )
    }
}