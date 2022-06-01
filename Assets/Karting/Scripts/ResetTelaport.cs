using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTelaport : MonoBehaviour
{

    public GameObject player;
    public CheckpointManager CheckpointManager;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("KartClassic_Player");
    }

    // Update is called once per frame
    void Update()
    {
         /*public string ResetButton = "Reset";

         public override InputData GenerateInput() {
            return new InputData
            {
                Reset = Input.GetButton(ResetButton),
            };
        }*/

        //telaport player to checkpoint           
        if (Input.GetKey("r"))
        {
            //Debug.Log("premiste o r");
            player.transform.position = CheckpointManager.instance.ultimochecpoint.position;
            player.transform.rotation = CheckpointManager.instance.ultimochecpoint.rotation;

            //player.transform.position = new Vector3(0, 0, 0);
        }
    
    }
}
