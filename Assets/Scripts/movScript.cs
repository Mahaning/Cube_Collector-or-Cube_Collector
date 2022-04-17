using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movScript : MonoBehaviour
{
 public  Rigidbody rb;
    public float speed=0.003f;
    public float force=500f;
    public float xmin=-3.7f;
    public float xmax=3.36f;
    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerpos=transform.position;
        playerpos.x=Mathf.Clamp(playerpos.x,xmin,xmax);
        transform.position=playerpos;

        if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed,0,0);
        }
     
       
        if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed,0,0);
        }
    //    rb.AddForce(0,0,force*Time.deltaTime);
    }
    private void FixedUpdate()
    {
         rb.AddForce(0,0,force*Time.deltaTime);
    }
  
}
