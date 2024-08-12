using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{

    [SerializeField] int startingBalance = 150;
    int currBalance;
    public int CurrBalance { get{ return currBalance; } }

    void Awake(){
        currBalance = startingBalance;
    }

    public void Deposit(int amnt){
        currBalance += Mathf.Abs(amnt); // Mathf.Abs() used to convert -ive value to +ive.
    }

    public void Withdraw(int amnt){
        currBalance -= Mathf.Abs(amnt);
    }
}
