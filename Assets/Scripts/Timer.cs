using UnityEngine;
using TMPro;
using UnityEditor.Rendering;

public class Timer : MonoBehaviour
{
    public float time;
    public TMP_Text text;

    void Update()
    {
        time = time + Time.deltaTime;
        text.text = time.ToString("0.00");
    }
}
