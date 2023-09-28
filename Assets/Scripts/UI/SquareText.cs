using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquareText : MonoBehaviour
{
    [SerializeField] Square square;

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        text.text = square.GetsquareIsFilledNumber().ToString();
    }
}
