using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_lever_Script : MonoBehaviour
{
  
    public Sprite Medieval_props_free_11;
    public Sprite Medieval_props_free_12;
    public GameObject Door_1Object;
    public Sprite Medieval_props_free_1;
    public Sprite Medieval_props_free_2;

    private bool isPressed;

    private SpriteRenderer Door_lever_1SpriteRenderer;
    private SpriteRenderer Door_1SpriteRenderer;

    private void Start()
    {
        Door_lever_1SpriteRenderer = GetComponent<SpriteRenderer>();
        Door_1SpriteRenderer = Door_1Object.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (!isPressed)
        {
            Door_lever_1SpriteRenderer.sprite = Medieval_props_free_12;
            Door_1SpriteRenderer.sprite = Medieval_props_free_2;
            isPressed = true;
        }
        else
        {
            Door_lever_1SpriteRenderer.sprite = Medieval_props_free_11;
            Door_1SpriteRenderer.sprite = Medieval_props_free_1;
            isPressed = false;
        }
    }
}
