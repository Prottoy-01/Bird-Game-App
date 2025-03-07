using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float jumpforce;

    public Rigidbody2D myRigidbody;
    public Logicscript logic;
    public bool birdIsAlive = true;
   // public Rigidbody2D rb;
    //private float jumpForce;
    void Start()
    {

       // float screenHeight = Camera.main.orthographicSize * 2;
       // jumpForce = screenHeight * 0.25f;

       // Debug.Log("Jump Force Adjusted: " + jumpForce);

    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space)==true&&birdIsAlive==true)
        if (Input.GetMouseButtonDown(0) && birdIsAlive == true)
       // if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            myRigidbody.linearVelocity = Vector2.up * jumpforce; // Moves object upward
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
