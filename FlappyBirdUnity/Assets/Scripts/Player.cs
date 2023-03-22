
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    public Rigidbody2D rb;
    public BirdAnimation birdAnimation;
    public GameObject loseWindow;
    

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            rb.velocity = new Vector2();
            rb.AddForce((transform.up * jumpForce), ForceMode2D.Impulse);
            birdAnimation.startRotation();
        }
        if (loseWindow.activeSelf != true)
            birdAnimation.ApplyRotation(rb.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PipePart") || other.gameObject.CompareTag("floorTag") || other.gameObject.CompareTag("LoseTag"))
        {
            GameManager.instance.Lose();
        }
    }
}
