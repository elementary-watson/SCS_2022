using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ecgSimulation_script : MonoBehaviour
{
    public TMP_Text infoBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseOver()
    {
        infoBox.SetText("Here you see a sinus rhythm is any cardiac rhythm in which depolarisation of the cardiac muscle begins at the sinus node.");
    }    
    
    public void OnMouseExit()
    {
        
    }
}
