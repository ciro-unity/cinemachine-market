using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterActions : MonoBehaviour
{
	private Animator animator;
	public Transform coin;
	public Transform target;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && coin != null)
		{
			animator.SetTrigger("PickUp");
			target.position = coin.position + new Vector3(0f, .1f, 0f);
		}
    }

	public void DisappearCoin()
	{
		if(coin != null)
			coin.gameObject.SetActive(false);
	}

	public void CoinAppear()
	{
		if(coin != null)
			coin.gameObject.SetActive(true);
	}
}
