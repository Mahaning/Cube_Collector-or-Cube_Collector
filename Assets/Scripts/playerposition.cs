using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerposition : MonoBehaviour
{
     public Transform playertran;
     public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 campos = transform.position;
        campos.z= playertran.position.z+offset;
        transform.position =campos;

    }
    
}
