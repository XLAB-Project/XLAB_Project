using System;
using UnityEngine;
    public class WaterBasic : MonoBehaviour
    {
    Vector3 pos;
    Vector3 rotate;
    Vector3 scale;
        int posy;
        int posx;
    Vector3 temp;
        private void Awake()
        {
        
        }
        private void Start()
        {
        pos = transform.position;
        scale = transform.localScale;
        temp = pos;
        //rotate = transform.rotation;

    }
        void Update()
        {
        temp.y += 1f;
        transform.position = temp;

            Debug.Log(pos);
            Renderer r = GetComponent<Renderer>();
            if (!r)
            {
                return;
            }
            Material mat = r.sharedMaterial;
            if (!mat)
            {
                return;
            }

            Vector4 waveSpeed = mat.GetVector("WaveSpeed");
            float waveScale = mat.GetFloat("_WaveScale");
            float t = Time.time / 20.0f;

            Vector4 offset4 = waveSpeed * (t * waveScale);
            Vector4 offsetClamped = new Vector4(Mathf.Repeat(offset4.x, 1.0f), Mathf.Repeat(offset4.y, 1.0f),
                Mathf.Repeat(offset4.z, 1.0f), Mathf.Repeat(offset4.w, 1.0f));
            mat.SetVector("_WaveOffset", offsetClamped);
        }

        void menu()
        {

        }
    }