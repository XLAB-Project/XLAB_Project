using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevelOnClick : MonoBehaviour
{   //toggle button fields
     public Toggle FirstA, FirstB, FirstC;
     public Toggle SecondA,SecondB;
     public Toggle ThirdA, ThirdB;
     public Toggle FourthA, FourthB;
     public Toggle FifthA, FifthB, FifthC;
     public Toggle SixthA, SixthB, SixthC;
     public Toggle SeventhA, SeventhB, SeventhC;
     public Toggle EightA, EightB, EightC;
     public Toggle NinthA, NinthB, NinthC;
     public Toggle TenthA, TenthB, TenthC, TenthD;
     public Toggle EleventhA, EleventhB, EleventhC, EleventhD;
     public Toggle TwelveA, TwelveB, TwelveC, TwelveD;
     public float timeElapsed;
     public int first_val, second_val, third_val, fourth_val, fifth_val, 
        sixth_val, seventh_val, eight_val, ninth_val, tenth_val, eleventh_val, twelve_val; //value holders
     public int final_val; //to get total val 
    

    public void Start()
      {
        
        // if-elseif statements for Q1
        if (FirstA.isOn)
        {
            first_val = 5;
        }
        else if (FirstB.isOn)
        {
            first_val = 3;
        }
        else if (FirstC.isOn)
        {
            first_val = 1; 
        }

        //if-elseif statements for Q2
        if (SecondA.isOn)
        {
            second_val = 1;
        }
        else if (SecondB.isOn)
        {
            second_val = 4;
        }

        //if-elseif statements for Q3
        if(ThirdA.isOn)
        {
            third_val = 3;
        }
        else if (ThirdB.isOn)
        {
            third_val = 0;
        }


        //if-elseif statements for Q4
        if (FourthA.isOn)
        {
            fourth_val = 4;
        }
        else if (FourthB.isOn)
        {
            fourth_val = 2;
        }

        //if-elseif statements for Q5
        if(FifthA.isOn)
        {
            fifth_val = 5;
        }
        else if (FifthB.isOn)
        {
            fifth_val = 3;
        }
        else if(FifthC.isOn)
        {
            fifth_val = 1;
        }

        //if-elseif statement for Q6
        if(SixthA.isOn)
        {
            sixth_val = 5;
        }
        else if(SixthB.isOn)
        {
            sixth_val = 3;
        }
        else if(SixthC.isOn)
        {
            sixth_val = 1;
        }

        //if-elseif statement for Q7
        if (SeventhA.isOn)
        {
            seventh_val = 5;
        }
        else if (SeventhB.isOn)
        {
            seventh_val = 3;
        }
        else if (SeventhC.isOn)
        {
            seventh_val = 1;
        }

        //if-elseif statement for Q8
        if (EightA.isOn)
        {
            eight_val = 5;
        }
        else if (EightB.isOn)
        {
            eight_val = 3;
        }
        else if (EightC.isOn)
        {
            eight_val = 1;
        }

        //if-elseif statement for Q9
        if (NinthA.isOn)
        {
            ninth_val = 0;
        }
        else if (NinthB.isOn)
        {
            ninth_val = 1;
        }
        else if (NinthC.isOn)
        {
            ninth_val = 5;
        }

        //if-elseif statement for Q10
        if (TenthA.isOn)
        {
            tenth_val = 5;
        }
        else if (TenthB.isOn)
        {
            tenth_val = 4;
        }
        else if (TenthC.isOn)
        {
            tenth_val = 3;
        }
        else if (TenthD.isOn)
        {
            tenth_val = 2;
        }
        
        //if-elseif statement for Q11
        if (EleventhA.isOn)
        {
            eleventh_val = 0;
        }
        else if (EleventhB.isOn)
        {
            eleventh_val = 1;
        }
        else if (EleventhC.isOn)
        {
            eleventh_val = 4;
        }
        else if (EleventhD.isOn)
        {
            eleventh_val = 5;
        }
        
        //if-elseif statement for Q12
        if (TwelveA.isOn)
        {
            twelve_val = 2;
        }
        else if (EleventhB.isOn)
        {
            twelve_val = 3;
        }
        else if (EleventhC.isOn)
        {
            twelve_val = 4;
        }
        else if (EleventhD.isOn)
        {
            twelve_val = 5;
        }

        StartCoroutine(LoadAfterDelay());

    }

    IEnumerator LoadAfterDelay()
    {
        
        //public void LoadByIndex(int sceneIndex)
        //{

            final_val = first_val + second_val + third_val + fourth_val + fifth_val +
                sixth_val + seventh_val + eight_val + ninth_val + tenth_val + eleventh_val + twelve_val;

            //Loads Base
            if ((final_val >= 12) && (final_val <= 26))
            {
			PlayerPrefs.SetInt("endScene", 2);//Store aftermath scene
			//Debug.Log("BC");
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(5);//Base Scene
            //yield return new WaitForSeconds(5);
            //SceneManager.LoadScene(6);//Storm Scene
            //yield return new WaitForSeconds(5);
            //SceneManager.LoadScene(2);//Best Case
            //yield return new WaitForSeconds(5);
            //SceneManager.LoadScene(7);//End Scene
        }

            else if ((final_val >= 27) && (final_val <= 40))
            {
            //Load Base, Storm then Moderate Case Scenario Scene
			PlayerPrefs.SetInt("endScene", 3);//Store aftermath scene
			//Debug.Log("MC");
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(5);//Base Scene
            //yield return new WaitForSeconds(60);
            //SceneManager.LoadScene(6);//Storm Scene
            //yield return new WaitForSeconds(60);
            //SceneManager.LoadScene(3);//Moderate Case
            //yield return new WaitForSeconds(60);
            //SceneManager.LoadScene(7);//End Scene
        }

            else if ((final_val >= 41) && (final_val <= 56))
            {
            //Load Base, Storm, then Worst Case Scenario Scene
			PlayerPrefs.SetInt("endScene", 4);//Store aftermath scene
			//Debug.Log("WC");
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(5);//Base Scene
            //yield return new WaitForSeconds(60);
            //SceneManager.LoadScene(6);//Storm Scene
            //yield return new WaitForSeconds(60);
            //SceneManager.LoadScene(4);//Worst Case
            //yield return new WaitForSeconds(60);
            //SceneManager.LoadScene(7);//End Scene
        }
        //}
    }    
 }
