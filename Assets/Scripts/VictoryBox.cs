using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryBox : MonoBehaviour
{

    void OnCollisionEnter(Collision vic) {
        if(vic.collider.tag == "Victory Square"){
            SceneManager.LoadScene("Finish");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
