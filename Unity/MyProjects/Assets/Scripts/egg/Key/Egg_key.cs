using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_key : MonoBehaviour
{
    [SerializeField] private KeyType keyType;

    public enum KeyType
    {
        Purple,
        Green,
        Gold
    }

    public KeyType GetKeyType()
    {
        return keyType;
    }
}
