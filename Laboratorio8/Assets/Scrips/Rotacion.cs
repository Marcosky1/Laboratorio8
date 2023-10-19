using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion currentRotation = transform.rotation;

        float angle = rotationSpeed * Time.deltaTime;

        Quaternion rotation = Quaternion.Euler(0, angle, 0);

        currentRotation *= rotation;

        transform.rotation = currentRotation;
    }
}
