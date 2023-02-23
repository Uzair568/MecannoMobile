using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int scoreCount = 0;
    public int currentsteps = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coin"))
        {
            scoreCount++;
            GameManager.instance.UpdateScore01(scoreCount);
            Destroy(other.gameObject);
            Debug.Log("Coin Collected");
        }

        if (other.CompareTag("ParkPoint"))
        {
            GameManager.instance.completionPanel.SetActive(true);
        }

        if (other.CompareTag("bridge"))
        {

            GameManager.instance.UpdateScore01(scoreCount);

        }



    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hurdle"))
        {
            currentsteps++;
            GameManager.instance.level1HurdlesAllowed(currentsteps);
            //Destroy(other.gameObject);
            Debug.Log("hitted to hurdle");
        }
    }
}
