using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controll : MonoBehaviour
{
    [SerializeField] float _velocidade;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _movex;
    [SerializeField] float _movey;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _movex = Input.GetAxisRaw("Horizontal");
        _movey = Input.GetAxisRaw("Vertical");

        _rb.velocity = new Vector2(_movex,_movey);
        
    }
}
