using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpForce = 5f;
    public static bool gameOver;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gameOver == false) // Nhấn chuột hoặc chạm màn hình
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Game Over
        //Time.timeScale = 0;
        gameOver = true;
    }
}
