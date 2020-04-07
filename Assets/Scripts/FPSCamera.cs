using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    public float mouseSens = 500f;

    public Transform player;

    float yRot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        yRot -= y;
        yRot = Mathf.Clamp(yRot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(yRot, 0f, 0f);
        player.Rotate(Vector3.up * x);

    }
}
