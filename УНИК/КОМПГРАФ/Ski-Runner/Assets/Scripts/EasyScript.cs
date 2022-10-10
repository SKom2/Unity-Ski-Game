using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Scenec(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }
}
