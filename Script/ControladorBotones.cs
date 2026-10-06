using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorBotones : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IrAMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void IrAFlipbook()
    {
        SceneManager.LoadScene(1);
    }
    public void IrACarpeta()
    {
        SceneManager.LoadScene(2);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
