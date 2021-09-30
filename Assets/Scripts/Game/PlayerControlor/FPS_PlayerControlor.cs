using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_PlayerControlor : MonoBehaviour
{
    [Header("Camera Rotation")]
    public Transform playerCamera;
    public float mouseSpeed;
    private float mouseX;
    private float mouseY;
    private float yRotation = 0;
    [Header("Player Move")]
    private CharacterController cc;
    private float dir_x;
    private float dir_y;
    private Vector3 dir;
    public float moveSpeed;

    private void Start()
    {
        playerCamera.localRotation = Quaternion.Euler(0, 0, 0);
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Camera Rotation
        mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -70, 70);
        transform.Rotate(Vector3.up * mouseX);
        playerCamera.localRotation = Quaternion.Euler(yRotation, 0, 0);
        // Player Move
        dir_x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        dir_y = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        dir = transform.forward * dir_y + transform.right * dir_x;
        cc.Move(dir);
    }
}
