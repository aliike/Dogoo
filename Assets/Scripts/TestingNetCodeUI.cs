using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class TestingNetCodeUI : MonoBehaviour
{
	// Start is called before the first frame update
	[SerializeField] private Button startHostButton;
	[SerializeField] private Button startClientButton;
	
	private void Awake() {
		startHostButton.onClick.AddListener(() => 
		{
			Debug.Log("HOST");
			NetworkManager.Singleton.StartHost();
			Hide();
		});
		startClientButton.onClick.AddListener(() => 
		{
			Debug.Log("CLIENT");
			NetworkManager.Singleton.StartClient(); 
			Hide();
		});
	}
	
	private void Hide()
	{
		gameObject.SetActive(false);
	}

}
