using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectPatientBtn_script : MonoBehaviour
{

    [SerializeField] panelManager_script pm_reference;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setPanelManager(panelManager_script pm_reference)
    {
        this.pm_reference = pm_reference;
    }
}
