using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
public Camera mainCamera;
  public Transform[] cameraPositions; // Array to store camera transform positions
  private int currentPositionIndex = 0; // Keeps track of the current camera position

  public float mouseSensitivity = 10f; // Adjust camera rotation speed

  private float xRotation = 0f;
  private float yRotation = 0f;
  private float yRotationMin = -90f; // Minimum vertical rotation limit
  private float yRotationMax = 90f;  // Maximum vertical rotation limit

  void Start()
  {
    // Set camera to the first position on game start, enforcing rotation
    mainCamera.transform.position = cameraPositions[currentPositionIndex].position;
    mainCamera.transform.rotation = cameraPositions[currentPositionIndex].rotation;

    // Enforce starting rotation even if script is attached elsewhere
    transform.rotation = Quaternion.identity; // Reset script's transform rotation

    // Lock cursor for smoother camera control (optional)
    Cursor.lockState = CursorLockMode.Locked;
  }

  void Update()
  {
    // Instant camera rotation based on mouse delta
    float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
    float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

    xRotation += mouseX;
    yRotation = Mathf.Clamp(yRotation - mouseY, yRotationMin, yRotationMax);

    Quaternion localRotation = Quaternion.Euler(yRotation, xRotation, 0f);
    mainCamera.transform.localRotation = localRotation;

    // Switch camera position
    if (Input.GetKeyDown(KeyCode.N))
    {
      currentPositionIndex = (currentPositionIndex + 1) % cameraPositions.Length;
      mainCamera.transform.position = cameraPositions[currentPositionIndex].position;
      mainCamera.transform.rotation = cameraPositions[currentPositionIndex].rotation;
    }
  }
}
