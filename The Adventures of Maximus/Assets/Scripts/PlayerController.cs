using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Rigidbody stiffBody;
    public Boundary boundary;

    #region Windows
    void WindowsMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 5.0f, moveVertical);
        stiffBody.velocity = movement * speed;

        stiffBody.position = new Vector3
        (
            Mathf.Clamp(stiffBody.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(stiffBody.position.z, boundary.zMin, boundary.zMax)
        );

        stiffBody.rotation = Quaternion.Euler(0.0f, 90f, stiffBody.velocity.x * -tilt);
    }
    #endregion

    void FixedUpdate()
    {
        WindowsMovement();
    }
}