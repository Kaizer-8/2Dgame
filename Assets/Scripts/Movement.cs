using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 25f;
    private float horizontal;
    private float jumpingPower = 20f;
    private bool isFacingRight;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
        }
        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2 (rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
        flip();
        IsGrounded();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position,0.2f,groundLayer);
    }
    private void flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    public void SetSpeed(float newSpeed)
    {
    speed = newSpeed;
    }
    public void SetJumpingPower()
    {
    jumpingPower = 32;
    }
}
//op het bewegende platform mijn positie van de player op dezelfde speed omlaag zetten als het platform zodat je dat gebounc niet krijg


