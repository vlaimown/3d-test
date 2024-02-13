using UnityEngine;
using TMPro;

public class Stopwatch : MonoBehaviour
{
    public bool hasFinished;

    float minutes;
    float seconds;

    public TMP_Text textMeshPro;
    void Start()
    {
        
    }

    void Update()
    {
        if (hasFinished == false)
        {
            seconds = seconds + Time.deltaTime;
        }
        if (seconds >= 60)
        {
            seconds = 0;
            minutes = minutes + 1;
        }

        int m = Mathf.RoundToInt(minutes);
        int s = Mathf.RoundToInt(seconds);

        textMeshPro.text = $"{m}:{s}";

        Debug.Log($"Секундомер :: {m}:{s}");
    }
}
