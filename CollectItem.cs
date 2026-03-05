using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public int points = 1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.AddScore(points);
            Destroy(gameObject);
        }
    }
}
