using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        if (Bird.gameOver == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;

            if (transform.position.x < -5) // Xóa nếu ra khỏi màn hình
            {
                Destroy(gameObject);
            }
        }
    }
}
