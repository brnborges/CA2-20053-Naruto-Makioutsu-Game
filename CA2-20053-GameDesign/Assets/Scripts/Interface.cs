using UnityEngine;
using UnityEngine.SceneManagement;

public class Interface : MonoBehaviour {

    // Single Player Mode
	public void OnePlayer()
    {

        Debug.Log("OnePlayer Scene Loaded");
        SceneManager.LoadScene(1);

    }

    // Quit 
    public void Quit()
    {
        Debug.Log("Quit Application");
        Application.Quit();

    }


}
