using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRIPT : MonoBehaviour
{
    public int GG ;
   public GameObject GameObject,Canvas;
    // Start is called before the first frame update   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Score")
        {
            GG++;
            print(GG);
        }
        if(other.tag=="Enemy")
        {   print("Ты клоун");
            Canvas.SetActive(true);
            GameObject.SetActive(false);
            

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
