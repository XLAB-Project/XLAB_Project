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
        int index = Random.Range(3, 4);
        yield return new WaitForSeconds(35);
        SceneManager.LoadScene(index);//Choice Scene
    }
}