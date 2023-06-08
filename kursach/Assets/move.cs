using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class move: MonoBehaviour
{
    public Text error;
    [SerializeField] private Text InputTextX, InputTextY, InputTextZ;
    [SerializeField] private InputField inputFieldX, inputFieldY, InputFieldZ;
    [SerializeField] private string MyX, MyY, MyZ;
    public GameObject endpoint;
    public GameObject point;

    float Y = 0f;
    float X = 150f;
    float Z = 25f;
    public static void Sleep(int millisecondsTimeout)
    {
        Thread.Sleep(millisecondsTimeout);
    }

    public void CheckParse()
    {
        MyX = InputTextX.text;
        MyY = InputTextY.text;
        MyZ = InputTextZ.text;
        if ((float.TryParse(MyX, out X)) && (float.TryParse(MyY, out Y)) && (float.TryParse(MyZ, out Z)))
        {
            X = float.Parse(MyX) * 10f;
            Y = float.Parse(MyY) * 10f;
            Z = float.Parse(MyZ);

            if ((Mathf.Pow(X, 2) + Mathf.Pow(Y, 2) > Mathf.Pow(151, 2)) || (Z > 35 || Z < 10) || (X <= -10 && Y > -5 && Y < 5) || (Mathf.Pow(X, 2) + Mathf.Pow(Y, 2) < Mathf.Pow(38, 2)) || (X >= -6 && X <= -3 && Y <= 2.9 && Y >= -2.9))
            {
                error.text = ("Точка вне зоны");

            }
            else
            {
                error.text = (" ");
                endpoint.transform.position = new Vector3(X, Z, Y);


                point.transform.position = new Vector3(point.transform.position.x, Z, point.transform.position.z);
            }

        }

    }

}
