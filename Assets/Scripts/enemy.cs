using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over! Player hit the enemy.");
            Time.timeScale = 0; // Stop the game
        }
    }
}
