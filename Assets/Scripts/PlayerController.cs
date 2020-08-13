using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalMove;
    private float verticalMove;
    public CharacterController player;
    public float velocidadGiro;
    public float velocidadAvance;

    public AudioSource sonidoMotor;
    //public float velocidadGiro = 40f;
    //public float velocidadAvance = 0.2f;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        if(horizontalMove == 0 && verticalMove == 0){
            sonidoMotor.Pause();
        }else{
            sonidoMotor.UnPause();
        }
    }
    private void FixedUpdate() {
        player.Move(transform.forward * Time.deltaTime * verticalMove * velocidadAvance);
        transform.Rotate(Vector3.up * horizontalMove * velocidadGiro * Time.deltaTime);

        Vector3 moveVector = Vector3.zero;
        if (player.isGrounded == false)
        {
            moveVector += Physics.gravity;
        }
        player.Move(moveVector * Time.deltaTime);
    }
}

