using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DoSManager : MonoBehaviour
{
    public User standardUser;
    public User maliciousUser;

    public DataPacket sendDataPacket(string IP, string network) 
    {
        DataPacket myPacket = new DataPacket();
        myPacket.IPAddress = IP;
        myPacket.PacketSize = UnityEngine.Random.Range(1,9);
        myPacket.NetworkType = network;
        myPacket.PacketData = "Random Information";

        return myPacket;
    }

    public List<User> createBotNetwork(string IP) 
    {
        List<User> botnetwork = new List<User>();
        User bot1 = new User();
        bot1.isMalicious = true;
        bot1.IP = IP;
        botnetwork.Add(bot1);

        User bot2 = new User();
        bot2.isMalicious = true;
        bot2.IP = IP;
        botnetwork.Add(bot2);

        User bot3 = new User();
        bot3.isMalicious = true;
        bot3.IP = IP;
        botnetwork.Add(bot3);

        User bot4 = new User();
        bot4.isMalicious = true;
        bot4.IP = IP;
        botnetwork.Add(bot4);

        User bot5 = new User();
        bot5.isMalicious = true;
        bot5.IP = IP;
        botnetwork.Add(bot5);

        return botnetwork;
    }

    public void floodScript(List<User> Bots) 
    {
        foreach (User B in Bots) 
        {
            sendDataPacket(B.IP, "public");
            sendDataPacket(B.IP, "public");
            sendDataPacket(B.IP, "public");
            sendDataPacket(B.IP, "public");
            sendDataPacket(B.IP, "public");
        }
    }

    public bool filtrationSystem(DataPacket incomingPacket, List<int> approvedSuffix) 
    {
        bool goodPacket = false;
        foreach (int i in approvedSuffix) 
        {
            if (i == Convert.ToInt32(incomingPacket.IPAddress.Substring(0,2)))
            {
                goodPacket = true;
                break;
            }
        }
        return goodPacket;
    }
    public void simAttack() 
    {
        List<User> botNetwork = createBotNetwork(maliciousUser.IP);
        floodScript(botNetwork);
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
