using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPoints : MonoBehaviour
{
    public int points = 0;
    private GUIStyle guiStyle = new GUIStyle();
  
    void Start () {
        guiStyle.fontSize = 40;
        guiStyle.normal.textColor = Color.black;
    }
    // Update is called once per frame
    void Update () {
	  //Se ejecuta en cada iteración del bucle de juego
        
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "cilindroPunto") {
            points++;
        }
    }
    void OnGUI() {
        GUILayout.Label($"Puntos: {points}", guiStyle);
    }
}
