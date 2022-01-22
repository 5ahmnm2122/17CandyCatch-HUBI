using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerScore : MonoBehaviour
{
    public DataServer data;
    public Text scoreText;

    public int score =0;
    public Text PlayerName;
    public float time = 60f;

    public Text TimeText;
    public int badGefangen = 0;


    void Awake ()
    {
        scoreText.text = "0";
        PlayerName.text = data.PlayerName;
    }



    private void Update()
    {
        time -= Time.deltaTime;
        int timeFormat = (int)time;
        TimeText.text = timeFormat.ToString();

        if (time < 0)
        {
            data.score = score;
            data.Lost = false;
            SceneManager.LoadScene("EndScene");
        }
    }
    void OnTriggerEnter2D (Collider2D target)
    {
        if (target.tag == "Bad")
        {
            if (score > 0)
            {
                score -= 1;
            }

            badGefangen ++;
            scoreText.text = score.ToString();
            Destroy(target.gameObject);

            if (badGefangen == 3){
                data.score = score;
                data.Lost = true;
                SceneManager.LoadScene("EndScene");
            }

        }
        if (target.tag == "Candy")
        {
            Destroy(target.gameObject);
            score++;
            scoreText.text = score.ToString();
        }

    }
    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene("EndScene");
    }
    
}
