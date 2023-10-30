using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float moveSpeed;
    public float maxFloatHeight = 10;
    public float minFloatHeigh;

    public Camera freeLookCamera;
    private float currentHieght;
    private  Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        currentHieght = transform.position.y;
         anim = GetComponent<Animator>();

        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.W))
        {
            MoveCharacter();
        }
        else
        {
            DisbleMovment();
        }
        
        currentHieght = Mathf.Clamp(transform.position.y, currentHieght, maxFloatHeight);
        transform.position = new Vector3(transform.position.x, currentHieght, transform.position.z);

    }

    private void DisbleMovment()
    {
        throw new NotImplementedException();
    }

    private void MoveCharacter()
    {
        throw new NotImplementedException();
    }

    private void Movecharacter()
    {
        Vector3 cameraForward = new Vector3(freeLookCamera.transform.forward.x, 0, freeLookCamera.transform.forward.z);
        transform.rotation = Quaternion.LookRotation(cameraForward);
        transform.Rotate(new Vector3(0, 0, 0), Space.Self);

        anim.SetBool("isFlying", true);
        Vector3 forward = freeLookCamera.transform.forward;
        Vector3 flyDirection = forward.normalized;

        currentHieght += flyDirection.y * moveSpeed * Time.deltaTime;
        currentHieght = Mathf.Clamp(currentHieght, minFloatHeigh, maxFloatHeight);

        transform.position += flyDirection * moveSpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, currentHieght, transform.position.z);
    }

    private void DisableMovement()

    {
        anim.SetBool("isFlying", false);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
