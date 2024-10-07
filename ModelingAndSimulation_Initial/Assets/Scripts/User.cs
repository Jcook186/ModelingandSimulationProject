using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{

    public bool isMalicious;
    public string IP;

    //Variables to be later implemented
    public string firstName;
    public string lastName;
    public string dateOfBirth;
    public int Age;
    public string gender;
    public string Address;

    public static string AccessPC(bool MaliciousIntent) 
    {
        if (MaliciousIntent == true)
        {
            int ipPrefix = Random.Range(10, 20);
            string ipSuffix = "";
            int myRand;
            for (int i = 0; i < 8; i++)
            {
                myRand = Random.Range(0, 9);
                ipSuffix += myRand;
            }
            string spoofedIP = ipPrefix + "." + ipSuffix;
            return spoofedIP;
        }
        else 
        {
            string trustedIP = "17.18943427";
            return trustedIP;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //IP = AccessPC(isMalicious);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
