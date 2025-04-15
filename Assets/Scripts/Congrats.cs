using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Congrats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject){
            UIScript.ready = false;
            if(Input.GetMouseButtonDown(0)){
                StartCoroutine(destroy());
            }
        }
    }
    IEnumerator destroy(){
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
        UIScript.ready = true;
    }
}
