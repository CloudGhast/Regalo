using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
public Camera mainCamera;
  public Transform[] cameraPositions; // Array to store camera transform positions
  private int currentPositionIndex = 0; // Keeps track of the current camera position

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.N))
    {
      // Update position index
      currentPositionIndex = (currentPositionIndex + 1) % cameraPositions.Length;

      // Move camera to new position
      mainCamera.transform.position = cameraPositions[currentPositionIndex].position;
      mainCamera.transform.rotation = cameraPositions[currentPositionIndex].rotation;
    }
  }
}
