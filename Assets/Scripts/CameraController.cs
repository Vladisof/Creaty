using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  public DynamicJoystick joystick;
  public float rotationSpeed = 5f;

  private void Update()
  {
    float horizontalRotation = joystick.Horizontal;
    float verticalRotation = joystick.Vertical;
    
    RotateCamera(horizontalRotation, verticalRotation);
  }

  void RotateCamera(float horizontal, float vertical)
  {
    transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime);
    
    float newRotationX = transform.localEulerAngles.x - vertical * rotationSpeed * Time.deltaTime;
    transform.localEulerAngles = new Vector3(newRotationX, transform.localEulerAngles.y, 0);
  }
}