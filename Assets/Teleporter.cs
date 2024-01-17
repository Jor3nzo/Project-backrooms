using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public string nextLevelName;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("First Person Controller"))
        {
            SceneManager.LoadScene("Play");
            print("teleport");
        }
    }
}
