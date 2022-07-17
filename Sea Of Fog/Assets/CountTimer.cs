using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountTimer : MonoBehaviour
{
    public float timeStart = 60;
    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox.text = timeStart.ToString("F1");
    }

    // Update is called once per frame
    void Update()
    {
        timeStart += Time.deltaTime;
        textbox.text = timeStart.ToString("F1");
    }
}
