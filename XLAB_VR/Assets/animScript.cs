using UnityEngine;
using System.Collections;

public class treeHit : MonoBehaviour
{

    public AudioClip hitSound;

    private Animator Tree_anim;
    private AudioSource theAudio;


    void Start()
    {
        Tree_anim = GetComponent<Animator>();
        theAudio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Tree_01")
        {
            StartCoroutine(TriggerAnimatorBool("hit"));
            theAudio.PlayOneShot(hitSound, 0.9f);
        }
    }


    private IEnumerator TriggerAnimatorBool(string name)
    {
        Tree_anim.SetBool(name, true);
        yield return null;
        Tree_anim.SetBool(name, false);
    }

}