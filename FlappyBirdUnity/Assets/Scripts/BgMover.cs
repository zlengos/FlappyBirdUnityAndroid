
using UnityEngine;

public class BgMover : MonoBehaviour
{
    public float StartX;
    public float EndX;

    void Update()
    {
        if(transform.position.x < EndX)
        {
            transform.position = new Vector2(StartX, transform.position.y);
        }
      
    }

}
