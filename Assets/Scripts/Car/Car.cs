using UnityEngine;


public class Car : MonoBehaviour
{
    //variaveis sempre no começo da classe
# region VAR
    
    [Header("Variáveis")]
    public  int doors = 4;
    
    public float life = 10;
    public float damage = 0.5f;

    public bool canAccelerate = false;
          
    [Header("Cor")]
    public Color color = Color.red;

    [Header("Inputs")]
    public KeyCode keyCode = KeyCode.Space;

    //variadas privadas usam underscore antes do nome (convenção de mercado)
    //variaveis privadas vao no fim das var (convenção)
    [Header("Referências")]
    private GameObject _meuObjeto;
    private Transform _meuTransform;
    #endregion

    #region Methods

    public void ChangeColor(Color newColor)
    {
        color = newColor;
        life -= damage;
    }

    public void Test()
    {
        Debug.Log("Test");
    }

    public void Test(int i)
    {
        Debug.Log("Test int");
    }

    public void Test(float i)
    {
        Debug.Log("Test float");
    }

    public void Accelerate()
    {
        canAccelerate = true;
    }

    #region METODOS UNITY

    #endregion
    void Start()
    {
        GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    /*private void LateUpdate()
    {

        if (Input.GetKeyDown(keyCode))
        {
            Debug.Log("Key down Space");
            ChangeColor(Color.yellow);
        }
        else if (Input.GetKeyUp(keyCode))
        {
            Debug.Log("Key up Space");
            ChangeColor(Color.magenta);
        }
        else if (Input.GetKey(keyCode))
        {
            ChangeColor(Color.blue);
        }
        else if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse down");
        }
        else if (Input.GetButtonDown("Jump"))
        {

        }

    }*/
        
    #endregion
}
