using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (AudioSource) )]

public class AudioVisualiser : MonoBehaviour
{

    AudioSource _audioSource;
    public float[] _samples = new float[512];

    // Start is called before the first frame update
    void Start()
    {

      //  _audioSource = GetComponent<GetSpectrumAudioSource>();
    }



   /* void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);

    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
    }
   */
}
