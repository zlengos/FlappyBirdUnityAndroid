 using UnityEngine;

public class Pipe : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out _))
        {
            ScoreManager.Instance.SetScore(1);
        }
    }
}
