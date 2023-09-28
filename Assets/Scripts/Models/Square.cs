using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    [SerializeField] int squareSequenceNumber;

    private bool isBlack = false;
    private SpriteRenderer spriteRenderer;
    private int squareIsFilledNumber = 0;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        if (isBlack)
        {
            spriteRenderer.color = Color.white;
            squareIsFilledNumber = 0;
        }
        else
        {
            spriteRenderer.color = Color.black;
            squareIsFilledNumber = 1;
        }

        isBlack = !isBlack;
    }

    public int GetsquareIsFilledNumber()
    {
        return squareIsFilledNumber;
    }
}
