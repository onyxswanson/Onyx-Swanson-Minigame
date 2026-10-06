using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour
{
    public GameObject targetPrefab;
    private List<Vector3> setOne = new List<Vector3>() { new Vector3(-8.78f, -0.47f, -9.13f), new Vector3(-1.67f, -0.47f, 4.15f), new Vector3(9.07f, -0.47f, -2.39f), new Vector3(1.47f, -0.47f, 9.18f),};
    private List<Vector3> setTwo = new List<Vector3>() { new Vector3(2.13f, -0.47f, -7.19f), new Vector3(-8.71f, -0.47f, 7.24f), new Vector3(5.28f, -0.47f, 4.54f), new Vector3(-5.92f, -0.47f, -3.3f), };
    private List<Vector3> setThree = new List<Vector3>() { new Vector3(8.98f, -0.47f, -0.76f), new Vector3(-8.71f, -0.47f, 2.19f), new Vector3(0.03f, -0.47f, 6.83f), new Vector3(2.08f, -0.47f, -9.25f), };
    private List<Vector3> setFour = new List<Vector3>() { new Vector3(-6.18f, -0.47f, 3.72f), new Vector3(5.14f, -0.47f, 4.49f), new Vector3(-8.77f, -0.47f, -7.2f), new Vector3(7.97f, -0.47f, -9.06f), };
    private List<Vector3> setFive = new List<Vector3>() { new Vector3(-9.11f, -0.47f, 5.57f), new Vector3(9.25f, -0.47f, 7.09f), new Vector3(-6.14f, -0.47f, -9f), new Vector3(7.5f, -0.47f, -5.59f), };
    public Quaternion zeroRotation = Quaternion.Euler(0f, 0f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int presetInt = UnityEngine.Random.Range(1, 6);

        if (presetInt == 1)
        {
            Instantiate(targetPrefab, setOne[0], zeroRotation);
            Instantiate(targetPrefab, setOne[1], zeroRotation);
            Instantiate(targetPrefab, setOne[2], zeroRotation);
            Instantiate(targetPrefab, setOne[3], zeroRotation);
        }
        if (presetInt == 2)
        {
            Instantiate(targetPrefab, setTwo[0], zeroRotation);
            Instantiate(targetPrefab, setTwo[1], zeroRotation);
            Instantiate(targetPrefab, setTwo[2], zeroRotation);
            Instantiate(targetPrefab, setTwo[3], zeroRotation);
        }
        if (presetInt == 3)
        {
            Instantiate(targetPrefab, setThree[0], zeroRotation);
            Instantiate(targetPrefab, setThree[1], zeroRotation);
            Instantiate(targetPrefab, setThree[2], zeroRotation);
            Instantiate(targetPrefab, setThree[3], zeroRotation);
        }
        if (presetInt == 4)
        {
            Instantiate(targetPrefab, setFour[0], zeroRotation);
            Instantiate(targetPrefab, setFour[1], zeroRotation);
            Instantiate(targetPrefab, setFour[2], zeroRotation);
            Instantiate(targetPrefab, setFour[3], zeroRotation);
        }
        if (presetInt == 5)
        {
            Instantiate(targetPrefab, setFive[0], zeroRotation);
            Instantiate(targetPrefab, setFive[1], zeroRotation);
            Instantiate(targetPrefab, setFive[2], zeroRotation);
            Instantiate(targetPrefab, setFive[3], zeroRotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
