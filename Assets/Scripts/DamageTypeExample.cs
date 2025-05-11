using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public enum DAMAGE_TYPE
    {
        SLASHING,
        PIERCING,
        BLUDGEONING,
        MAGICAL,
        FORCE
    }

    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistance;
    public DAMAGE_TYPE weakness;
    public int baseDamage = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (attackType == resistance)
        {
            baseDamage /= 2;
            Debug.Log("Il nemico è resistente a " + attackType);
            Debug.Log("Il danno è: " + baseDamage);
        }
        else if (attackType == weakness)
        {
            baseDamage *= 2;
            Debug.Log("Il nemico è debole a " + attackType);
            Debug.Log("Il danno è: " + baseDamage);
        }

        Debug.Log("Il danno finale è: " + baseDamage);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
