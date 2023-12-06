using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class Candy : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
    }

    void OnTriggerEnter(Collider col)
    {
        UIManager.Instance.IncreaseScore(ScorePoints);
        Destroy(this.gameObject);
    }

    public int ScorePoints = 100;
    public float rotateSpeed = 50f;
}
