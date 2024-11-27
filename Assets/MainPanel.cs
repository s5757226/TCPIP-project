using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    public Image panelImage;
    Color color = new Color(0f, 0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        panelImage.color = Color.white;
        if(panelImage != null)
        {
            panelImage.color = Color.white;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
