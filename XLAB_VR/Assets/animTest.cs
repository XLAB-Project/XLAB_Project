using UnityEngine;

using System.Collections;

public class animTest : MonoBehaviour

{

    public AudioClip hitSound;

    private Animator anim;

    private AudioSource theAudio;

  

    void Start()

    {

        anim = GetComponent<Animator>();

        theAudio = GetComponent<AudioSource>();

        anim.SetBool("hit", false);

    }

 void OnCollisionEnter(Collision col)

    {
			Debug.Log ("collision detected");
	
            StartCoroutine(TriggerAnimatorBool("hit"));

            theAudio.PlayOneShot(hitSound, 0.9f);

    }

    private IEnumerator TriggerAnimatorBool(string name)

    {

        anim.SetBool(name, true);

        yield return null;

    }

}