using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{

    [SerializeField] int startingBalance = 150;
    [SerializeField] int currBalance;
    public int CurrBalance { get{ return currBalance; } }

    [SerializeField] TextMeshProUGUI text;

    void Start(){
        currBalance = startingBalance;
        UpdateText();
    }

    public void Deposit(int amnt){
        currBalance += Mathf.Abs(amnt); // Mathf.Abs() used to convert -ive value to +ive.
        UpdateText();
    }

    public void Withdraw(int amnt){
        currBalance -= Mathf.Abs(amnt);
        UpdateText();

        if(currBalance < 0){
            ReloadLevel();
        }
    }

    void ReloadLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void UpdateText(){
        text.text = $"Gold : {currBalance}";

    }
}
