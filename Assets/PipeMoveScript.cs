using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed;
    public float deadZone=-100;
    public bool isGameOver = false;


    void Start()
    {
        // Adjust pipe speed based on screen width
        // float screenWidth = Camera.main.orthographicSize * 2 * Screen.width / Screen.height;
        //moveSpeed = screenWidth * 0.5f;  // 50% of screen width per second
        //float screenWidth = Screen.width; // Use pixel width instead
        //moveSpeed = screenWidth * 0.005f;

       // Debug.Log("Pipe Speed Adjusted: " + moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;    //Time.deltaTime is used for adjusting frame rate with different devices

        //transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
   
}
