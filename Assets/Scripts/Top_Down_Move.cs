using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_Down_Move : MonoBehaviour
{
    public float moveSpeed;
    //public Weapon weapon;
    public Rigidbody2D rb;

    Vector2 moveDirection;
    Vector2 mousePosition;
    public FixedJoystick joystickscriptreference;
    void Update()
    {
        //float moveX = Input.GetAxisRaw("Horizontal");
        //float moveY = Input.GetAxisRaw("Vertical");

        float moveX  = joystickscriptreference.Horizontal;
        float moveY = joystickscriptreference.Vertical;

        //if(Input.GetMouseButtonDown(0))
        //{
        //   weapon.Fire();
        //}
        moveDirection = new Vector2(moveX, moveY).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);

       // Vector2 aimDirection = mousePosition - rb.position;
       // float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
       // rb.rotation = aimAngle;
    }
}