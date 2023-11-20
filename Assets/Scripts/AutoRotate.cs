using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(25f * Time.deltaTime, 75f * Time.deltaTime, 0f, Space.Self);
    }
}
