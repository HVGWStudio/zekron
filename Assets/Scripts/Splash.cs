using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    // Carregar as paradas
        Debug.Log("vai dormir");
        StartCoroutine(dormir(3)); // Gambiarra de leve
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public IEnumerator dormir(int segundos)
    {
        yield return new WaitForSeconds(segundos); // Gambiarra de leve
        
        Application.LoadLevel("Menu1");

        Debug.Log("acordou");
		
        Debug.Log("Erackson vai fuder tudo?");
        Debug.Log("Negativo! ;]");
    }

}
