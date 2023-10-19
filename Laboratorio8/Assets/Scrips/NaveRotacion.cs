using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveRotacion : MonoBehaviour
{
    public float rotationSpeedZ = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.z += rotationSpeedZ * Time.deltaTime;
        transform.rotation = Quaternion.Euler(currentRotation);
    }
}
