using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    public static int targetUp = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("target"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            targetUp--;
        }
    }
}
