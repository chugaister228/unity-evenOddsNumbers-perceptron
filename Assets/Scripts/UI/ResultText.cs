using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        Perceptron.OnCalculateResult += ShowResult;
    }

    private void OnDisable()
    {
        Perceptron.OnCalculateResult -= ShowResult;
    }

    private void ShowResult(int res, double sum)
    {
        if (res == 0)
        {
            text.text = $"number is odd, y = {res}, s = {sum.ToString("0.000")}...";
        }
        else if (res == 1)
        {
            text.text = $"number is even, y = {res}, s = {sum.ToString("0.000")}...";
        }
        else
        {
            text.text = "smth went wrong!";
        }
    }
}
