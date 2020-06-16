using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{

    GameObject Camera;

    GameObject Player;

    public int CameraHeight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       Camera.transform.position = new Vector3( Player.transform.postition.x, CameraHeight , Player.transform.postition.z ); 

    }
}