using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*public class changeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/


public class changeScene : MonoBehaviour
{
    Scene Scenex;

    public changeScene(Scene Scenex)
    {
        this.Scenex = Scenex;
    }

    public void ManageScene()
    {
        SceneManager.LoadScene("Scene 2");
    }
}
