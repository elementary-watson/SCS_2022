using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Logic : MonoBehaviour
{

    public GameObject target;
    [SerializeField] MovingMarker _movingMarker;
    // Start is called before the first frame update

    public void OnTriggerEnter2D()
    {
        if (GameObject.FindWithTag("target_img"))
        {
            Debug.Log("match");
            target.SetActive(false);
            _movingMarker.SetMarkerFalse(false);
        }
     
    }
}
