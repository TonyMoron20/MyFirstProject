using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Propiedades
    public float moveSpeed = 0f;
    public float rotateSpeed = 0f;
    public float jumpSpeed = 0f;
    public GameObject bullet;
    public Transform shootPoint;
    public float bulletSpeed = 100.0f;

    private float hInput, vInput;
    private Rigidbody _rb;
    private bool canJump = true;

    /*private enum PlayerAction { Attack, Defend, Fire, Jump };

    PlayerAction action = PlayerAction.Jump;*/

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // S = v * t
        //hInput = Input.GetAxis("Horizontal") * rotateSpeed;
        hInput = Input.GetAxis("Horizontal") * rotateSpeed / (Input.GetAxis("Fire1") > 0.5f ? 2.0f : 1.0f);
        //vInput = Input.GetAxis("Vertical") * moveSpeed;
        vInput = Input.GetAxis("Vertical") * moveSpeed / (Input.GetAxis("Fire1") > 0.5f ? 2.0f : 1.0f);

        /* Forma de mover al personaje sin utilizar las físicas
        this.transform.Translate(vInput * Time.deltaTime * Vector3.forward);
        this.transform.Rotate(hInput * Time.deltaTime * Vector3.up);
        */

        if(Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(bullet, shootPoint.position, shootPoint.rotation) as GameObject;
            Rigidbody bulletRb = newBullet.GetComponent<Rigidbody>();
            bulletRb.velocity = shootPoint.forward * bulletSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            _rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            canJump = false;
        }
    }

    private void FixedUpdate()
    {
        Vector3 rotation = Vector3.up * hInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        // Velocidad = Velocidad inicial + velocidad * tiempo
        _rb.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);

        _rb.MoveRotation(_rb.rotation * angleRot);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 6)
        {
            canJump = true;
        }
    }

}
