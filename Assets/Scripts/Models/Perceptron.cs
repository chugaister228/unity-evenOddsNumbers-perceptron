using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perceptron : MonoBehaviour
{
    [SerializeField] List<Square> squares;

    private List<double> weights = new List<double> { 
        0.20819073547709968,
        -0.13259043272128912,
        -0.535931010592026,
        0.07354548702500524,
        0.8010331417870871,
        0.13608606184298477,
        -0.6940915898910023,
        0.8606407310048889,
        -0.307206324775971,
        1.326911127155192,
        0.5158631309349835,
        0.2561216724114591,
        0.4792973359077778,
        -0.7613865896686803,
        -0.6988885751648736
    };
    private double teta = 0.9436227387558093;
    private List<int> inputs;

    public static event Action<int, double> OnCalculateResult;

    private void Start()
    {
        UpdateInputs();
    }

    private void UpdateInputs()
    {
        inputs = new List<int>();

        if (squares != null)
        {
            foreach (Square square in squares)
            {
                inputs.Add(square.GetsquareIsFilledNumber());
            }
        }
        else
        {
            Debug.LogWarning("Perceptron: squares list is empty!");
        }
    }

    public void CalculateResult()
    {
        UpdateInputs();

        double sum = 0;
        for (int i = 0; i < inputs.Count; i++)
        {
            sum += inputs[i] * weights[i];
        }
        sum += teta;

        if (sum >= 0)
        {
            OnCalculateResult?.Invoke(1, sum);
        }
        else
        {
            OnCalculateResult?.Invoke(0, sum);
        }
    }
}
