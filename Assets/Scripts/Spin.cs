using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

    [SerializeField] private float spinSpeed = 10.0f;

    void Update()
    {
        SpinObject();
    }

    private void SpinObject()
    {   
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

}
