using UnityEngine;
using System.Collections;

public class OpenTheDoors : MonoBehaviour {
	public Animation anim;
	public bool Chave=false;



		void OnTriggerEnter(Collider other) 
		{
			if (other.gameObject.CompareTag("Player"))
			{
			anim.Play("open");
			}
		}
	void OnTriggerExit(Collider other) 
	{
		if (other.gameObject.CompareTag("Player"))
		{
			anim.Play("close");
		}
	}

	public void PegouChave()
	{
		Chave = true;
	}


}


