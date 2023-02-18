using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    Rigidbody _rd;
    [SerializeField]float _playerspeed = 10f;
    [SerializeField]float _playerrotatespeed = 100f;
   
    

    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical")*Time.deltaTime*_playerspeed;
        float rotation = Input.GetAxis("Horizontal")*Time.deltaTime*_playerrotatespeed;
        transform.Translate(0f,0f,translation);
        transform.Rotate(0f,rotation,0f);
    }
}
