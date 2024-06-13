using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI Scoretext;
    void Update()
    {
        Scoretext.text = player.position.z.ToString("0"); //to change text on runtime
    }
}
