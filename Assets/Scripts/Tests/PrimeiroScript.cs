using UnityEngine;

public class PrimeiroScript : MonoBehaviour
{
public float position;
        
        void Start()
    {
        position = PlayerPrefs.GetFloat("Posi��o", 1);
        position++;
        PlayerPrefs.SetFloat("Posi��o", 150);
    }

   
}
