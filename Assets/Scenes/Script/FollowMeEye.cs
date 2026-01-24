using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMeEye : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousPos = Camera.main.WorldToScreenPoint(Mouse.current.position.ReadValue());
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        transform.position = mousPos;

        if (screenPos.x >= 5f)
        {
            mousPos.x -=5f;
        }
        else
        {
            mousPos.x = screenPos;
        }


    }
}
