using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadEnd : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ChoiceDelay());
    }

    IEnumerator ChoiceDelay()
    {

        yield return new WaitForSeconds(35);
        SceneManager.LoadScene(7);//EndScene
    }
}

