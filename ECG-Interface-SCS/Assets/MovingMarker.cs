using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMarker : MonoBehaviour
{
    //////////////Methode 1
    //public float speed = 0f;

    public GameObject target;
    float y;
    bool startMarker;
    
    // Start is called before the first frame update
    void Start()
    {
        startMarker = true;
        
        /////Methode 2
        y = target.transform.position.y;
    }

    private void FixedUpdate()
    {
        if(startMarker)
        {
            ////////////Methode 1
            //transform.Translate(new Vector2(1f,0f)* speed * Time.deltaTime);

            ///////////Methode 2
            transform.position = new Vector2(transform.position.x + 1.9f, y);
        }
    }

    public void SetMarkerFalse(bool value)
    {
        startMarker = value;
    }

}
