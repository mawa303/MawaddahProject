using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "Coins: 0";
        healthText.text = "3 / 3 Health";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void UpdateCoinText(int coins){
        coinText.text = "Coins: " + coins.ToString();

    }
    public void UpdateHealthText(int currentHealth, int maxhealth){
        healthText.text = currentHealth.ToString() + " / " + maxhealth.ToString() + "Health";

    }
}
