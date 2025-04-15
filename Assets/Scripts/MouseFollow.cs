using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject mouse;
    [SerializeField]
    private GameObject congrats;
    [SerializeField]
    private GameObject congrats2;

    private Vector3 mousePos;
    private bool rockBottom = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(giveCongrats());
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        mousePos = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
        mouse.transform.position = new Vector3 (mousePos.x+0.2f,mousePos.y-0.15f,0.0f);
        if(UIScript.money <= 0 && rockBottom == false){
            UIScript.money = 0;
            rockBottom = true;
            Instantiate(congrats2);
            congrats2.transform.position = new Vector3(0f,0f,0f);
        }
    }
    IEnumerator giveCongrats(){
        yield return new WaitForSeconds(1);
        Instantiate(congrats);
        congrats.transform.position = new Vector3(0f,0f,0f);
    }
}
