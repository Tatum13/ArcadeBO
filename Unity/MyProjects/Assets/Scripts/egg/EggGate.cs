using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggGate : MonoBehaviour
{
    [SerializeField] private Egg_key.KeyType keyType;

    public Egg_key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenGate()
    {
        gameObject.SetActive(false);
    }
}
