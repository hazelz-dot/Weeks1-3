using UnityEngine;

public class MovingSpiders : MonoBehaviour
{
    //set speed for the spiders
    //public so we can edit the spiders to have different speed in unity
    public float speedX = 0.002f;
    public float speedY = 0.004f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //spider will move with the speed that we set in float
        Vector2 newPosition = transform.position;
        newPosition.x += speedX;
        newPosition.y += speedY;
        transform.position = newPosition;

        //check if the position.x <0 or position.x > width of the screen 
        //Y : ,ultiply speed by -1 
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        //the spider bounces back so they don't leave screen 
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
