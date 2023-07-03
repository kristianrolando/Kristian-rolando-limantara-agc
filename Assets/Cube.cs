using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
        transform.Rotate(Vector3.right * Time.deltaTime * (speed-8f));
        transform.Rotate(Vector3.forward * Time.deltaTime * (speed+3f));
    }
}
