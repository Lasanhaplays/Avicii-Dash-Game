using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script que analiza o espectro do audio
public class AudioSpectrum : MonoBehaviour {

	private void Update(){
        //Recebe os dados do audio
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming);

        //Atribui valores para o espectro
        if (m_audioSpectrum != null && m_audioSpectrum.Length > 0) spectrumValue = m_audioSpectrum[0] * 100;
    }

    private void Start(){
        m_audioSpectrum = new float[128];
    }

    //Extracao do beat
    public static float spectrumValue {get; private set;}
    private float[] m_audioSpectrum;
}
