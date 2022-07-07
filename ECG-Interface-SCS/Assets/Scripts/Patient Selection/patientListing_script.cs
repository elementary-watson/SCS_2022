using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class patientListing_script : MonoBehaviour
{

    [SerializeField] private Transform content;
    [SerializeField] private GameObject patientListing;
    [SerializeField] private ScrollRect scrollRect;
    patientDataset_script patDB_reference = new patientDataset_script();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void createPatientListElement(panelManager_script pm_reference)
    {
        //Erstelle ein list element in der Scroll View

        GameObject patientListElement = Instantiate(patientListing, content, false);
        selectPatientBtn_script spbtn_reference = patientListElement.GetComponent<selectPatientBtn_script>();
        spbtn_reference.setPanelManager(pm_reference);

        //Update die scroll view damit Scroll view ganz nach unten aktualisiert
        Canvas.ForceUpdateCanvases();
        //content.transform.parent.GetParentComponent<ScrollRect>().verticalNormalizedPosition = 0;
        content.transform.parent.GetComponentInParent<ScrollRect>().verticalNormalizedPosition = 0;

        //var findRawimage= chatElement.GetComponentInChildren<RawImage>();
       
        Texture2D p_texture2D = new Texture2D(92, 92);
        //patientListElement.GetComponentInChildren<RawImage>().texture = p_texture2D;

        string patientInfo = patDB_reference.getFirstname() + " " + patDB_reference.getSurname() + " | Gender: " + patDB_reference.getGender() + " | Age: " + patDB_reference.getAge(); 

        patientListElement.GetComponentInChildren<TextMeshProUGUI>().text = patientInfo;
        
    }
}
