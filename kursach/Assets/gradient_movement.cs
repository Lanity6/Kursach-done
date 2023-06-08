using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gradient_movement : MonoBehaviour
{
    public parent_to_child root;
    public parent_to_child end;
    public GameObject end_Point;
    public float minDistance = 0.05f;

    float GetDistance(Vector3 point1, Vector3 point2)
    {
        return Vector3.Distance(point1, point2);
    }

    float CalculateSlope(parent_to_child arms)
    {
        float Delta = 0.01f;

        float distance1 = GetDistance(end.transform.position, end_Point.transform.position);

        arms.Rotate(Delta);

        float distance2 = GetDistance(end.transform.position, end_Point.transform.position);

        arms.Rotate(-Delta);

        return (distance2 - distance1) / Delta;
    }

    // Update is called once per frame
    void Update()
    {   
        if (GetDistance(end.transform.position, end_Point.transform.position) > minDistance)
        {
            parent_to_child current = root;
            float degree = 0;
            while (current != null)
            {
                float slope = CalculateSlope(current);
                
                degree = degree - slope;
                //Debug.Log(degree);

                current.Rotate(-slope);
                current = current.GetChild();

                
            }
        }   
    }

}
