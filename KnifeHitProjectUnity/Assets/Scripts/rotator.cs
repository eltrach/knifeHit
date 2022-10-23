using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    [SerializeField] private int rotateSpeed = 20;

    void Update()
    {
        
        transform.RotateAround(gameObject.transform.position, Vector3.forward, rotateSpeed * Time.deltaTime);



    }
}
