using TMPro;
using UnityEngine;

public class TimerBehaviour : MonoBehaviour{

    private float timer;
    private TextMeshProUGUI textField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        textField = GetComponent<TextMeshProUGUI>();

        if (textField == null) {
            Debug.Log("No component found");
        }
    }

    // Update is called once per frame
    void Update() {
        timer = Time.time;

        int minutes = (int) timer / 60;
        int second = (int) timer % 60;

        string message = string.Format("Time: {0:00}:{1:00}", minutes, second); ;
        
        textField.text = message;

        //Debug.Log(timer);
    }
}
