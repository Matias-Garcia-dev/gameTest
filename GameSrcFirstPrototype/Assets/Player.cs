using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 input;
    public float _speed;
    public float inputX;
    public float inputY;
    private Rigidbody2D _rigi;
    // Start is called before the first frame update
    void Start()
    {
        _rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");

        _rigi.MovePosition(transform.position + (new Vector3(inputX, inputY, 0))); 

    }
}
