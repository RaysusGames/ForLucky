using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ETeams {TeamA , TeamB}
public class Player : MonoBehaviour
{
    public Atribute hp = new Atribute(3);
    public ETeams team;
    public GameObject turnIndicator;
   
    public void NotifyShootComplete(Proyectil proyectil)
    {
        OnTurnFinish();
    }
    public void ApplyDamage(float Damage)
    {
        hp.RestToValue(Damage);
        
    }

    public void OnTurnBeggin()
    {
        GetComponent<Throw>().CanAttack = true;
        turnIndicator.SetActive(true);
    }
    public void OnTurnFinish()
    {
        GetComponent<Throw>().CanAttack = false;
        StartCoroutine(WaitForEndOfTurn());
        turnIndicator.SetActive(false);


    }
    IEnumerator WaitForEndOfTurn()
    {
        yield return new WaitForSeconds(5);
        GameManager.instance.SetNextTurn();
    }

}
