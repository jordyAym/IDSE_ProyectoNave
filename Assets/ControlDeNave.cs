using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeNave : MonoBehaviour
{
    private Rigidbody rigidbodyNave;
    public float fuerzaPropulsion = 1f;
    public float velocidadRotacion = 100f;

    void Start()
    {
        rigidbodyNave = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento hacia arriba (propulsor)
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbodyNave.AddRelativeForce(Vector3.up * fuerzaPropulsion, ForceMode.Impulse);
        }

        // Rotación hacia la derecha
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * velocidadRotacion * Time.deltaTime); // Rotar suavemente a la derecha
        }

        // Rotación hacia la izquierda
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * velocidadRotacion * Time.deltaTime); // Rotar suavemente a la izquierda
        }
    }
}

