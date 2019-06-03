using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VideoRefresh : MonoBehaviour
{

   
    

  

    public void OnClickRefresh()
    {
        Debug.Log("'Refresh' was called");

        SceneManager.LoadScene(0);
    }
}

