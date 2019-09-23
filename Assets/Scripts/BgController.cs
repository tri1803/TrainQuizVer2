using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgController : MonoBehaviour
{
    private int speed;
    private GameObject bg;
    private bool check = false;
    void Start()
    {
        
        bg = GameObject.FindGameObjectWithTag("BG");
        speed = 0;
        StartCoroutine(Example(9f));
       
    }
    void Update()
    {

        //speed = 50;
        
        bg.transform.Translate(-speed * Time.deltaTime, 0.0f, 0.0f);
    }
    IEnumerator Example(float second)
    {
        yield return new WaitForSeconds(second);    
        speed = 50;
    }
    IEnumerator Wait()
    {
        speed = 0;
        yield return new WaitForSeconds(3);
        //speed = 100;
    }
}

