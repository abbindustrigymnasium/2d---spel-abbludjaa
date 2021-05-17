using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathScript : MonoBehaviour
{
    public float CurrentY = 1;
    public float HighY = 1;
    // Start is called before the first frame update
    void Start()
    {
         CurrentY = GetComponent<Rigidbody2D>().position.y;
         HighY = CurrentY;
    }

    // Update is called once per frame
    void Update()
    {
         CurrentY = GetComponent<Rigidbody2D>().position.y;
        if (CurrentY > HighY)
        {
             HighY = CurrentY;
        }

        if (CurrentY+8 <= HighY)
        {
            Debug.Log("Restarted...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}