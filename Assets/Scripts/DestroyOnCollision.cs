using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
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
        if (gameObject.CompareTag("walls"))
        {
            Destroy(other.gameObject);
        }
    }
}
