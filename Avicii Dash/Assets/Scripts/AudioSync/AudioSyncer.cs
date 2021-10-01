using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script responsavel por extrair os beats do espectro
public class AudioSyncer : MonoBehaviour {

	public virtual void OnBeat(){
		m_timer = 0;
		m_isBeat = true;
	}
	public virtual void OnUpdate(){ 
		//Atualiza o valor do audio
		m_previousAudioValue = m_audioValue;
		m_audioValue = AudioSpectrum.spectrumValue;

		//Se o valor do audio no frame for menor que o bias
		if (m_previousAudioValue > bias && m_audioValue <= bias){
			//Se o menor intervalo e alcancado
			if (m_timer > timeStep) OnBeat();
		}

		//Se o valor do audio no frame for maior que o bias
		if (m_previousAudioValue <= bias && m_audioValue > bias){
			//Se o menor intervalo e alcancado
			if (m_timer > timeStep) OnBeat();
		}

		m_timer += Time.deltaTime;
	}

	private void Update(){
		OnUpdate();
	}

	public float bias;
	public float timeStep;
	public float timeToBeat;
	public float restSmoothTime;

	private float m_previousAudioValue;
	private float m_audioValue;
	private float m_timer;

	protected bool m_isBeat;
}
