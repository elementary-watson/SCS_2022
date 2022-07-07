using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoverLogic : MonoBehaviour
{
    public TextMeshProUGUI tmp_contentInformationBox;
    public GameObject hoverObject;
    //Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        //rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        hoverObject.transform.position = mousePosition;

        RaycastHit2D hit = Physics2D.Raycast(transform.position,transform.position);

        if (hit.collider != null)
        {
            if (hit.collider.name == "analysis_ECG_container")
            {
                tmp_contentInformationBox.text = "The UI must present the analysis and interpretation of the Patient";
            }
            else if (hit.collider.name == "ecgSim_img")
            {
                tmp_contentInformationBox.text = "this is the ECG-sinus rhythm derived from the electrical activity of the heart." + "\n" + "The recording was performed in 25 mm/s";
            }
            else if (hit.collider.name == "alarmElement")
            {
                tmp_contentInformationBox.text = "The Patient Status is critical";
            }
            else if (hit.collider.name == "alarmElement (1)")
            {
                tmp_contentInformationBox.text = "The Patient Status is normal";
            }
        }
        else
        { 
                tmp_contentInformationBox.text = "";
        }
    }
}
