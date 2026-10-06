using UnityEngine;

public class ControladorPiernas : MonoBehaviour
{
    public Animator animator;

    public void Derecha()
    {
        animator.SetTrigger("CambiarDerecha");
    }

    public void Izquierda()
    {
        animator.SetTrigger("CambiarIzquierda");
    }
}

