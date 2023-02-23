using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAt : MonoBehaviour
{
    public GameObject _player;
    //public GameObject wireframe;

    void Start()
    {
       
    }
    void Update()
    {
        Vector3 direction = _player.transform.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direction, Color.green);
        Debug.Log("Magnitude: " + direction.magnitude);
        direction.Normalize();
        this.transform.Translate(direction * Time.deltaTime*2);
    }
}





















































