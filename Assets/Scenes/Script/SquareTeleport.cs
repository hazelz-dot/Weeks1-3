using UnityEngine;
using UnityEngine.UIElements;

public class SquareTeleport : MonoBehaviour
{
    float speed = -0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speed;
        
        if (newPosition.x < -5)
        {
            newPosition.x = 9;

        }
        transform.position = newPosition;
    }
}
