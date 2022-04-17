using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercolideScripts : MonoBehaviour
{
    public movScript mov;      
    public Score score;
    public GamecontrolScript gamecontrolScript;
    private void  OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "col")
        {
            score.Addscore(1);
            Destroy(other.gameObject);
        }
    } 
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "col"||other.gameObject.tag !="tra"){
            mov.enabled=false;
            gamecontrolScript.gameover();
        }
    } 
//     // Start is called before the first frame update
//     private void OnCollisionEnter(Collision other)
//     {
//         if(other.gameObject.name=="Red_cube")
//         {
//             Destroy(other.gameObject);
//         }
//     }
// // }
    // Update is called once per frame
//     void Update()
//     {
        
//     }
}
