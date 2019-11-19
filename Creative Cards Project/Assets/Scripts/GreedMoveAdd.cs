using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreedMoveAdd : MonoBehaviour
{
    public GameObject EncounterPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddGreedAttack()
    {
        EncounterPanel.GetComponent<MoveAssignment>().MoveAssigned = false;
        EncounterPanel.GetComponent<MoveAssignment>().MoveNum = 7;
        EncounterPanel.GetComponent<MoveAssignment>().AddMove();
        Debug.Log("Add Greed Move");
    }
}
