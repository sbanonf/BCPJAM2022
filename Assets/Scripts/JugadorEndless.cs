using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorEndless : MonoBehaviour
{
    public int JumpForce;
    public int Velocity;
    Rigidbody2D _rb;
    BoxCollider2D _bx;
    [SerializeField] public LayerMask Ground;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _bx = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space)) {
            _rb.AddForce(new Vector2(0, JumpForce));
            Debug.Log("Oprimido");
        }
        _rb.velocity = new Vector2(Velocity, _rb.velocity.y);
    }
    private bool IsGrounded() {
        Color raycolor;
        float extra = .10f;
        RaycastHit2D _ry = Physics2D.Raycast(_bx.bounds.center, Vector2.down, _bx.bounds.extents.y+extra,Ground);
        if (_ry.collider != null) { raycolor = Color.green; } raycolor = Color.red;
        Debug.DrawRay(_bx.bounds.center, Vector2.down * (_bx.bounds.extents.y + extra),raycolor);
        //Debug.Log(_ry.collider);
        return _ry.collider != null;
        
    }
}
