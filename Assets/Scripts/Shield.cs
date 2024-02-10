using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField] float _rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += _rotateSpeed * Time.deltaTime;
        transform.eulerAngles = newRotation;
    }
}
