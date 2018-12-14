using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blueObjects : MonoBehaviour
{
    public Text textScore;
    public int score;
    private Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetScore();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("blueObjects"))
        {
            other.gameObject.SetActive(false);
            score += 1;
            SetScore();
        }
    }
    public void SetScore()
    {
        textScore.text = "Score: " + score.ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
