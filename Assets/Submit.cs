using System;
using System.IO;
using TMPro;
using System.Text;
using UnityEngine;
using Unity.VisualScripting;

public class Submit : MonoBehaviour
{
    public TMP_InputField user ;
    public TMP_InputField password;   
    public void submitdata()
    {
        
        
            
            Debug.Log("goodone");
            Debug.Log(user.text);
            Debug.Log(password.text);
            userdata user_ = new userdata(user.text,password.text);
        string fileName = "user.json";

        userjson usr = new userjson
        {
            userid = user_.UserID,
            level = 0
        };
        message_info message = new message_info
        {
            cmd ="login",
            data = JsonUtility.ToJson(usr)
        };
        string jsonString = JsonUtility.ToJson(message);
        Debug.Log(jsonString);
        Debug.Log(user_.UserID);
        
        File.WriteAllText(fileName, jsonString);
        Runclient();




    }
    void Runclient()
    {
        string command = "python \"test.py\"";
        System.Diagnostics.Process.Start("CMD.exe", "/K " + command);
    }
}
