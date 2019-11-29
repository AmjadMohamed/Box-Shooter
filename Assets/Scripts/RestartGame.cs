using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if(col.transform.tag == "Projectile")
        {
            SceneManager.LoadScene(0);
        }
    }
}
