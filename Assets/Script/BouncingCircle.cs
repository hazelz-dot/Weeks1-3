using UnityEngine;

public class BouncingCircle : MonoBehaviour
{
    float speedX = 0.005f;
    float speedY = 0.003f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speedX;
        newPosition.y += speedY;
        transform.position = newPosition;

        //check if the position.x <0 or position.x > width of the screen 
        //Y : ,ultiply speed by -1 
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1;
        }

        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speedY = speedY * -1;
        }
    }
}
