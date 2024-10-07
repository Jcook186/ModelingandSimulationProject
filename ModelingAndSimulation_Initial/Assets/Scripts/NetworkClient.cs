using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkClient : MonoBehaviour
{
    public int maximumResources = 100;
    public int availableResources = 100;
    public DataPacket packet;

    public string returnService(DataPacket packet, int resources) 
    {
        if (resources > packet.PacketSize)
        {
            availableResources -= packet.PacketSize;
            Debug.Log("Service Returned");
            return "Service Returned";
        }
        else 
        {
            availableResources -= packet.PacketSize;
            Debug.Log("Service Failed !!!");
            return "Service Failed";
        }
    }
    public void RestoreResource(DataPacket packet) 
    {
        availableResources += packet.PacketSize;
    }

    public void networkFailure(string networkStatus) 
    {
        if (networkStatus.Equals("Service Failed")) 
        {

        }
    }
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
