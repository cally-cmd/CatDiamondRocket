using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager Instance {get; private set;}

    private int score;
    public int level;

    public TextMeshProUGUI scoreText;

    public GameObject sky;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void IncScore(int val) {
        score += val;
        if (score < 0) {
            score = 0;
        }
        scoreText.text = "Score : " + score;

        if (score >= 0 && score < 5) {
            level = 1;
        } else if (score >= 5 && score < 10) {
            level  = 2;
        } else {
            level = 3;
        }
    }

    void Start()
    {
        score = 0;
        level = 1;
        scoreText.text = "Score : " + score;
        sky.GetComponent<Dropping>().DropObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
