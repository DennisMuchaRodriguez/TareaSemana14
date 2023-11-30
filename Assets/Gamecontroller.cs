using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamecontroller : MonoBehaviour
{
   
    void Start()
    {
        
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
