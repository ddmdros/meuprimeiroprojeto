using System.Linq;
using UnityEngine;
using MeuJogo.Bus.Manager;
using System.Collections.Generic;
using UnityEngine.Events;


public enum Animals
{ 
    Dog,
    Cat,
    Fish
}

public class ScriptTest : MonoBehaviour
{
    public UnityEvent eventCallback;

    public EnemyBase enemyBase;

    public List<GameObject> listOfObjects;

    private void Attack()
    {
        foreach (var o in listOfObjects)
        {
            if (o != null)
            {
                var damageable = o.GetComponent<IDamageable<int>>();
                if (damageable != null)
                {
                    damageable.Damage(1);
                }
            }
        }
    }

    public void DebugLog()
    {
        Debug.Log("Cliquei no botão");
    }
   


    public List<AnimalSetup> animalSetup;

    public bool checkStatus = false;
    
    [Range(-5,5)]
    public int value01;
    [Range(-5, 5)]
    public int value02;

    public int checkOne = 0;

    public Animals animal;

    private void CheckSwitchCase(Animals a)
    {
        switch (a)
        {
            case Animals.Cat:
                OnReadCat();
                break;
            case Animals.Dog:
                OnReadDog();
                break; 
            case Animals.Fish:
                OnReadFish();
                break;
            default:
                Debug.Log("Default");
                break;

        }
    }

    private void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //if (eventCallback != null) eventCallback.Invoke();
            eventCallback.Invoke();
            //CheckSwitchCase(Animals.Cat);
            ShowTextByAnimal(Animals.Cat);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            enemyBase.Attack();
            //CheckSwitchCase(Animals.Dog);
           // ShowTextByAnimal(Animals.Dog);

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {

            Attack();
            //ShowTextByAnimal(Animals.Fish);
            // CheckSwitchCase(Animals.Fish);
        }
    }

    private void ShowTextByAnimal(Animals a)
    {
        foreach (var animal in animalSetup)
            if (animal.animalType == a)
            {
                Debug.Log(animal.text);
            }
    }

    private void OnReadCat()
    {
        foreach (var animal in animalSetup)
        if(animal.animalType == Animals.Cat)
        {
            Debug.Log(animal.text);
        }
    }

    private void OnReadDog()
    {
        foreach (var animal in animalSetup)
            if (animal.animalType == Animals.Dog)
            {
                Debug.Log(animal.text);
            }
    }

    private void OnReadFish()
    {
        foreach (var animal in animalSetup)
            if (animal.animalType == Animals.Fish)
            {
                Debug.Log(animal.text);
            }


    }

    private void Update()
    {
        //CheckSwitchCase();
        CheckKeys();
        // CheckValues();
        
    }

}

[System.Serializable]

public class AnimalSetup
{
    public Animals animalType;
    public string text;
}