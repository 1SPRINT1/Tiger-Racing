using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ComboPlas : MonoBehaviour
{
   public GameObject effect;

   public void EffectEnd()
   {
      Instantiate(effect, transform.position, Quaternion.identity);
   }
}
