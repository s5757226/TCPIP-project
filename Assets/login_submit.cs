using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Security.Cryptography;
using System.IO;
using System;
using System.Text;
using UnityEngine.XR;
using System.Xml.Linq;
using System.Buffers.Text;

[System.Serializable]
public class message_info
{
    public string cmd;
    public string data;
}
[System.Serializable]
public class userjson
{
    public string userid;
    public int level;
}
public class userdata
{
    
    public string UserID;
    public userdata(string username,string password)
    {
        UserID = EncryptStringToBytes_Aes(username+password, Encoding.UTF8.GetBytes("0123456789ABCDEF0123456789ABCDEF"), Encoding.UTF8.GetBytes("ABCDEF0123456789"));
        


}
    string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
    {
        // Check arguments.
        if (plainText == null || plainText.Length <= 0)
            throw new ArgumentNullException("plainText");
        if (Key == null || Key.Length <= 0)
            throw new ArgumentNullException("Key");
        if (IV == null || IV.Length <= 0)
            throw new ArgumentNullException("IV");
        byte[] encrypted;
        

        // Create an Aes object
        // with the specified key and IV.
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = IV;

            // Create an encryptor to perform the stream transform.
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            // Create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        //Write all data to the stream.
                        swEncrypt.Write(plainText);
                    }
                    encrypted = msEncrypt.ToArray();
                }
            }
        }
        
        
        // Return the encrypted bytes from the memory stream.
        return Convert.ToBase64String(encrypted);
    }
}

public class login_submit : MonoBehaviour
{
    // Start is called before the first frame update
    
}
