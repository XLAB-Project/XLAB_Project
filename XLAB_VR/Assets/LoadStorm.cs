using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadStorm : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(BaseDelay());
    }

    IEnumerator BaseDelay()
    {

        yield return new WaitForSeconds(35);
        SceneManager.LoadScene(6);//Storm Scene
    }
}
