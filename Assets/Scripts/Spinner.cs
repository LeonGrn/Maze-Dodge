using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    float xValue = 0;
    float yValue = 1f;
    float zValue = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue , yValue , zValue);
    }
}
