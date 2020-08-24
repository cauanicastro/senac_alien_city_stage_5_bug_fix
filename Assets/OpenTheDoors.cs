using UnityEngine;

public class OpenTheDoors : MonoBehaviour {
	public Animation anim;
	public bool Chave = false;

	void OnTriggerEnter(Collider other) 
	{
		if (Chave && other.gameObject.CompareTag("Player"))
		{
		    anim.Play("open");
		}
	}
	void OnTriggerExit(Collider other) 
	{
		if (Chave && other.gameObject.CompareTag("Player"))
		{
			anim.Play("close");
		}
	}

	public void PegouChave()
	{
		Chave = true;
	}
}
