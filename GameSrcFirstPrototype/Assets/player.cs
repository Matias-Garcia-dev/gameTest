using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Vector2 input;
    public float _speed;
    public float inputx;
    public float inputy;
    private Rigidbody2D _rigi;
    // Start is called before the first frame update
    void Start()
    {
        _rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.GetAxis("Horizontal");
        inputy = Input.GetAxis("Vertical");

        _rigi.MovePosition(transform.position + (new Vector3(inputx, inputy, 0)));


    }
}
