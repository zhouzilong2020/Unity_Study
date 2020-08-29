
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scourText;
    // Update is called once per frame
    void Update()
    {
        scourText.text = player.position.z.ToString("0");
    }
}
