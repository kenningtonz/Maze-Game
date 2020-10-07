using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public float score = 0;

    public GameObject checkpointText;
    public int checkpointcounter = 0;
    // Start is called before the first frame update
    private void Start()
    {
      
    }

    public void setsheckpointcounter(int add)
    {
        checkpointcounter += add;
        checkpointText.GetComponent<Text>().text = checkpointcounter.ToString("0");
        Debug.Log("addcounter");
    }

    // Update is called once per frame
    public void setScore()
    {
        score += Time.deltaTime;
        scoreText.GetComponent<Text>().text = score.ToString("F0");
    }

    private void Update()
    {
        setScore();
    }
}
