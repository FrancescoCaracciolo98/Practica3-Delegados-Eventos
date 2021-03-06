using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cilindroB : MonoBehaviour
{
    public delegate void delegateB();
    public static event delegateB OnCollideB; // static para aplicarlo a todos
    private Text texto;

    void Start()
    {
        texto = GameObject.Find("Panel").GetComponent<Text>();
        cilindroA.OnCollideA += print;
        cilindroA.OnNear += updateColor;
    }

    private void print()
    {
        texto.text = "Ha colisionado";
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.localScale *= 1.5f;
            OnCollideB(); // dispara evento onCollideA al chocar con jugador
        }
    }

    void updateColor()
    {
        Color color = new Color(Random.value, Random.value, Random.value, Time.deltaTime);
        GetComponent<Renderer>().material.color = color;
    }
}