using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine;

public class WallScript : MonoBehaviour
{
    public float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.LogError("GAME OVER");

        // TODO: Actually make a Game Over appear on screen
        // TODO: Pause all movement in the game
        // TODO: Activate "Restart Key"
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        // This function will be called when the object with this script
        // enters a trigger collider.
        Debug.LogWarning("Trigger Entered"); 
    }
}
