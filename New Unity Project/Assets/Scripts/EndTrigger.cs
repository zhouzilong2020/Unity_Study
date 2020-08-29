
using UnityEngine;
using UnityEngine.UI;
public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();

    }
}
