using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEvent : MonoBehaviour
{
	public ParticleSystem[] particle;
	public float modSpeed = 1f / 6f;
	public void PlayParticle0(float particleSpeed)
	{
		PlayParticle(0, particleSpeed);
	}
	public void PlayParticle1(float particleSpeed)
	{
		PlayParticle(1, particleSpeed);
	}
	public void PlayParticle2(float particleSpeed)
	{
		PlayParticle(2, particleSpeed);
	}
	public void PlayParticle3(float particleSpeed)
	{
		PlayParticle(3, particleSpeed);
	}
	public void PlayParticle4(float particleSpeed)
	{
		PlayParticle(4, particleSpeed);
	}
	public void PlayParticle5(float particleSpeed)
	{
		PlayParticle(5, particleSpeed);
	}
	public void PlayParticle6(float particleSpeed)
	{
		PlayParticle(6, particleSpeed);
	}
	public void PlayParticle7(float particleSpeed)
	{
		PlayParticle(7, particleSpeed);
	}
	public void PlayParticle8(float particleSpeed)
	{
		PlayParticle(8, particleSpeed);
	}
	public void PlayParticle9(float particleSpeed)
	{
		PlayParticle(9, particleSpeed);
	}
	public void PlayParticle(int index, float particleSpeed)
	{
		if (particleSpeed == 0)
			particleSpeed = 1;
		Animator ani = GetComponent<Animator>();
		AnimatorStateInfo info = ani.GetCurrentAnimatorStateInfo(0);
		float pSpeed = info.speed * modSpeed * particleSpeed;
		PlayP(particle[index], particle[index].transform, pSpeed);
		var main = particle[index].main;
		main.simulationSpeed = pSpeed;
		particle[index].Play();
	}
	void PlayP(ParticleSystem playParticle, Transform t, float speed)
	{
		for (int i = 0; i < t.childCount; i++)
		{
			Transform tt = t.GetChild(i);
			ParticleSystem ps = tt.GetComponent<ParticleSystem>();
			if (ps != null)
			{
				var main = playParticle.main;
				main = ps.main;
				main.simulationSpeed = speed;
			}
			PlayP(playParticle, tt, speed);
		}
	}
}
