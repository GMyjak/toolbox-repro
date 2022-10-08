using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public SerializedScene serializedScene;
    
    void Start()
    {
        SceneManager.LoadScene(serializedScene.BuildIndex);
    }
}
