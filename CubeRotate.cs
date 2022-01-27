using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    public Transform player;

    void Start() {
        cilindroA.OnNear += Rotate;
        player = GameObject.Find("Cube_player").GetComponent<Transform>();
    }

    void Rotate() {
        transform.LookAt(player);
    }
}
