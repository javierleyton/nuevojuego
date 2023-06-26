using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthManager : MonoBehaviour
{
    public static int playerHP = 100;
    public TextMeshProUGUI playerHPText;
    public static bool isGameOver;
    public int damageAmount = 10;


    void Start()
    {

        isGameOver = false;
        playerHP = 100;

    }


    void Update()
    {
        playerHPText.text = "+" + playerHP;
        if (isGameOver)
        {
            SceneManager.LoadScene("Juego");

        }

    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("arma"))
        {
            TakeDamage(damageAmount);



            print("Daño");

        }

    }

    public void TakeDamage(int damageamount)
    {
        playerHP -= damageamount;
        if (playerHP <= 0)
            isGameOver = true;
    }
}
