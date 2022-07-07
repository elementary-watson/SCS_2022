using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class login_script : MonoBehaviour
{
    [SerializeField] GameObject IDInputfield;
    [SerializeField] GameObject passwordInputfield;
    [SerializeField] panelManager_script pm_reference;
    public AudioSource successLoginSound;
    public AudioSource failLoginSound;
    public TMP_Text credentialErrorMsg;
    public userProfile_script userProfile_reference;

    // Start is called before the first frame update
    void Start()
    {
        userProfile_reference = new userProfile_script();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void submit_btn()
    {
        string id = IDInputfield.GetComponent<TMP_InputField>().text;
        string password = passwordInputfield.GetComponent<TMP_InputField>().text;

        print(id + " - " +
            "" + password);

        if (id == userProfile_reference.getID() && password == userProfile_reference.getPassword())
        {
            successLoginSound.Play();
            pm_reference.successfulLogin();
        }
        else
        {
            failLoginSound.Play();
            credentialErrorMsg.SetText("Please enter your correct user ID and password into the inputfields");

        }
    }
}
