using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinItem : item
{
    public int amount;
    
    /*
    public RuntimeAnimatorController animation;
    private void Start()
    {
        GetComponent<Animator>().runtimeAnimatorController = animation;
    }
    */

    public override void Apply(GameObject target)
    {
        if (target.TryGetComponent(out PuntuationBehavior ptb))
        {
            ptb.GetPoint(amount);
        }
        GetComponent<DestroyBehavior>().DisableObject();
        ItemManager.Instance.GetItem(name);
    }
}
