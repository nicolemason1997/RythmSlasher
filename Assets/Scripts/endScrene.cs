using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScrene : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "endhit")
        {
            SceneManager.LoadScene("end");
        }
    }
}
        // Use this for initialization
     

