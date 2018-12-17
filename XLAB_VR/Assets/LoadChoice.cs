using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadChoice : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(StormDelay());
    }

    IEnumerator StormDelay()
    {
        int index = PlayerPrefs.GetInt("endScene",0);
        yield return new WaitForSeconds(35);
        SceneManager.LoadScene(index);//Choice Scene
    }
}