using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    private List<Egg_key.KeyType> keyList;

    private void Awake()
    {
        keyList = new List<Egg_key.KeyType>();
    }

    public void AddKey(Egg_key.KeyType keyType)
    {
        Debug.Log("Added Key: " + keyType);
        keyList.Add(keyType);
    }

    public void RemoveKey(Egg_key.KeyType keyType)
    {
        keyList.Remove(keyType);
    }

    public bool ContainsKey(Egg_key.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter(Collider collider)
    {
        Egg_key key = collider.GetComponent<Egg_key>();
        if(key != null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }

        EggGate eggGate = collider.GetComponent<EggGate>();
        if(eggGate != null)
        {
            if (ContainsKey(eggGate.GetKeyType()))
            {
                RemoveKey(eggGate.GetKeyType());
                eggGate.OpenGate();
            }
        }
    }
}
