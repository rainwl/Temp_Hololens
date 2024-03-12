using UnityEngine;

public class Test : MonoBehaviour
{
    #region Fields

    public GameObject go;
    
    #endregion

    #region Unity cycle

    private void Awake()
    {
        Debug.Log("awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
    }

    #endregion

    #region Implement

    public void MyFunction()
    {
        Debug.Log("123");
    }

    #endregion
}
