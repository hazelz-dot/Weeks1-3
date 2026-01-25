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
        //convert screen to world and let the eye follow the mouse
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = mousPos;

    }
}
