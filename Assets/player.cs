using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pos_to_mat : MonoBehaviour
{
    static float AppendRatio = 1f;
    Vector3 pos;
    float append_speed=1;                       //123
    public float changeratio = 1.01f;           //abc
    public float maxchangeratio = 3;
    public float append_speed_speed = 0.001f;
    public float player_speed = 5;
    public float max_map_size = 10000;
    public Camera player_cam = null;
    public float base_fov = 8;
    public float min_fov = 2;
    public float zoomSpeed = 2f;
    public int zoom_camear_speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)&& pos.y < max_map_size)
        {
            pos.y += AppendRatio*player_speed*Time.deltaTime;
            AppendSpeedRatio(changeratio, maxchangeratio);
            
        }
        if (Input.GetKey(KeyCode.S)&& pos.y*-1 < max_map_size)
        {
            pos.y -= AppendRatio * player_speed * Time.deltaTime;
            AppendSpeedRatio(changeratio, maxchangeratio);
        }
        if (Input.GetKey(KeyCode.A) && pos.x *-1 < max_map_size)
        {
            pos.x -= AppendRatio*player_speed * Time.deltaTime;
            AppendSpeedRatio(changeratio, maxchangeratio);

        }
        if (Input.GetKey(KeyCode.D) && pos.x < max_map_size)
        {
            pos.x += AppendRatio*  player_speed * Time.deltaTime;
            AppendSpeedRatio(changeratio, maxchangeratio);
        }
        if(!(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.D)))
        {
            AppendRatio = 1;
        }
        
        transform.position = pos;
        
        //float current_pos = (Mathf.Abs(pos.x) + Mathf.Abs(pos.y))/2;
        //player_cam.fieldOfView = Mathf.Lerp(min_fov, base_fov, (max_map_size - current_pos) / zoom_camear_speed);
        //player_cam.fieldOfView = Mathf.Lerp(player_cam.fieldOfView, base_fov, zoomSpeed * Time.deltaTime);

    }
    //ratio Change should >1
    static float AppendSpeedRatio(float RatioChange,float MaxRatio)
    {
        
        if (RatioChange > 1&&AppendRatio<=MaxRatio)
        {
            
            AppendRatio *= RatioChange;
        }
        return AppendRatio;
    }
}
