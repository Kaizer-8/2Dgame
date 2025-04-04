using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    private float speed = 15f;
    private float horizontal;
    private float jumpingPower = 20f;
    private bool isFacingRight;
    private bool dubbleJump = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            if (IsGrounded())
            {
                Debug.Log(dubbleJump);
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
            }
            if(!IsGrounded() && dubbleJump)
            {
                Debug.Log(dubbleJump);
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpingPower);
                dubbleJump = false;
                Debug.Log(dubbleJump);
            }
        }
        if (Input.GetButtonUp("Jump") && rb.linearVelocity.y > 0f)
        {
            rb.linearVelocity = new Vector2 (rb.linearVelocity.x, rb.linearVelocity.y * 0.5f);
        }
        flip();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }
    public bool IsGrounded()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.5f, groundLayer);
        dubbleJump = isGrounded ? true : dubbleJump;
        return isGrounded;
    } // checks if the player is on the ground
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
    jumpingPower = 30;
    }
}


