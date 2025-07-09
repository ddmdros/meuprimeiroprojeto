using UnityEngine;

public class PrimeiroScript : MonoBehaviour
{
public float position;
        
        void Start()
    {
        position = PlayerPrefs.GetFloat("Posição", 1);
        position++;
        PlayerPrefs.SetFloat("Posição", 150);
    }

   
}
