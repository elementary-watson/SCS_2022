using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelManager_script : MonoBehaviour
{
    [SerializeField] GameObject selectPatient_Panel;
    [SerializeField] GameObject ecgSimulation_Panel;
    [SerializeField] GameObject login_Panel;
    public patientListing_script patList_reference;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void callCreatePatientList() 
    {
        patList_reference.createPatientListElement(this);
    }   
    
    public void successfulLogin() 
    {
        selectPatient_Panel.SetActive(true);
        login_Panel.SetActive(false);
        callCreatePatientList();
    }

}
