using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    [SerializeField]
    private float xrotation;
    [SerializeField]
    private float yrotation;

    public float sensitivity;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        xrotation += Input.GetAxis("Mouse X") * sensitivity;
        yrotation += Input.GetAxis("Mouse Y") * sensitivity;
        transform.parent.transform.localRotation = Quaternion.Euler(-yrotation, xrotation, 0);
    }
}
