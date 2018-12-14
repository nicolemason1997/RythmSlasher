using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sampleScene")
        {
            SceneManager.LoadScene("sampleScene");
        }
        if (other.gameObject.tag == "Instructions")
        {
            SceneManager.LoadScene("Instructions");
        }
        if (other.gameObject.tag == "Quit")
        {
            SceneManager.LoadScene("Quit");
            Application.Quit();
        }
        if (other.gameObject.tag == "menu")
        {
            SceneManager.LoadScene("Start");
        }
        if (other.gameObject.tag == "end")
        {
            SceneManager.LoadScene("End");
        }
    }
}
