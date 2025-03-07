using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public Logicscript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
       // if (collision.gameObject.layer == 3)
       // {
            logic.addScore();
        }
   // }
}
