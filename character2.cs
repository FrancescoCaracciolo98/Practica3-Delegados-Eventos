using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character2 : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 10f;
        rotateSpeed = 100F;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal2") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical2") * Time.deltaTime);
    }
}
