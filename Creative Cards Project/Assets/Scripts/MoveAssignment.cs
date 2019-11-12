using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveAssignment : MonoBehaviour
{
    public Button[] Moves;
    public bool[] MovesPicked;

    public Button Move1, Move2, Move3, Move4, Move5, Move6, Move7;

    bool Move1Picked, Move2Picked, Move3Picked, Move4Picked, Move5Picked, Move6Picked, Move7Picked;

    int MoveNum;



    public void Awake() 
    {
        Moves = new Button[] { Move1, Move2, Move3, Move4, Move5, Move6, Move7 };
        MovesPicked = new bool[] { Move1Picked, Move2Picked, Move3Picked, Move4Picked, Move5Picked, Move6Picked, Move7Picked };
    }
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    void Glutony() 
    {
        Debug.Log("Glutnoy Move");
    }
    void Lust() 
    {
        Debug.Log("Lust Move");
    }
    void Sloth() 
    {
        Debug.Log("Sloth Move");
    }
    void Pride() 
    {
        Debug.Log("Pride Move");
    }
    void Envy() 
    {
        Debug.Log("Envy Move");
    }
    void Anger()
    {
        Debug.Log("Anger Move");
    }
    void Greed() 
    {
        Debug.Log("Greed Move");
    }


    void AddMove() 
    {
        for (int i = 0; i < MovesPicked.Length; i++) 
        {
            if (MovesPicked[i] == false) 
            {
                for (int j = 0; j < Moves.Length; j++) 
                {
                    if (i == j) 
                    {
                        #region MoveAssignments
                        if (MoveNum == 1) 
                        {
                            Moves[j].onClick.AddListener(Glutony);
                        }
                        if (MoveNum == 2)
                        {
                            Moves[j].onClick.AddListener(Lust);
                        }
                        if (MoveNum == 3)
                        {
                            Moves[j].onClick.AddListener(Sloth);
                        }
                        if (MoveNum == 4)
                        {
                            Moves[j].onClick.AddListener(Pride);
                        }
                        if (MoveNum == 5)
                        {
                            Moves[j].onClick.AddListener(Envy);
                        }
                        if (MoveNum == 6)
                        {
                            Moves[j].onClick.AddListener(Anger);
                        }
                        if (MoveNum == 7)
                        {
                            Moves[j].onClick.AddListener(Greed);
                        }
                        #endregion
                    }
                }
                
            }
        }


    }


}
