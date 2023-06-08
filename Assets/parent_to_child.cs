using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parent_to_child : MonoBehaviour
{
    public parent_to_child child;

    public parent_to_child GetChild()
    {
        return child;
    }
    
    public void Rotate(float angle)
    {
        transform.Rotate(Vector3.up * angle);
    }
}
