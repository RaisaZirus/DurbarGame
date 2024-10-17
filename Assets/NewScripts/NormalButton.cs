using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NormalButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameO;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoTOSceeen(){
        SceneManager.LoadScene(gameO.name);
    }
}
