using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField]float moveSpeed = 0.1f;

    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("We are psuhing forward");
        }
        
        else if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("We are psuhing backwards");
        }
        
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("We are psuhing left");
        }
        
        else if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("We are psuhing right");
        }

        transform.Rotate(0, 0, steerSpeed);
        transform.Translate(0, moveSpeed, 0);
    }
}
