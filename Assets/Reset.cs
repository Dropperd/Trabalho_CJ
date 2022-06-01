using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{

     /*public string ResetButton = "Reset";

         public override InputData GenerateInput() {
            return new InputData
            {
                Reset = Input.GetButton(ResetButton),
            };
        }*/

 public void Update()
    {
        if (Input.GetKey("r"))
        {
            Debug.Log("premiste o r");
        }
    }



}
