using UnityEngine;
using System.Collections;

public class RedBorder : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == Constants.PlayerTag)
            GameManager.Instance.Die();
    }
}
