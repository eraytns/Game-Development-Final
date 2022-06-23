using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    float rotationOnX;
    float mouseSensitivity = 30f;





    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;

        rotationOnX -= mouseY;
        rotationOnX = Mathf.Clamp(rotationOnX, 0f, 0f);
        transform.localEulerAngles = new Vector3(rotationOnX, 0f, 0f);

    }
}
