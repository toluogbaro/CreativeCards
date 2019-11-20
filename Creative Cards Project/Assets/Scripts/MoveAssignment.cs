using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveAssignment : MonoBehaviour
{
    public Button[] Moves;
    public bool[] MovesPicked;
    public bool MoveAssigned;
    public Button Move1, Move2, Move3, Move4, Move5, Move6, Move7;
    public float crit;
    public float critChance;
    bool Move1Picked, Move2Picked, Move3Picked, Move4Picked, Move5Picked, Move6Picked, Move7Picked;
    public int LustCounter;
    public int MoveNum;

    public GameObject FightManager;
    public GameObject GameManagerOBJ;

    Color GlutonyColour = new Color (1f, 0.647f, 0f);
    Color LustColour = new Color(0f, 0f, 1f);
    Color SlothColour = new Color(0.678f, 0.847f, 0.902f);
    Color PrideColour = new Color(0.471f, 0.318f, 0.663f);
    Color EnvyColour = new Color(0f, 1f, 0f);
    Color AngerColour = new Color(1f, 0f, 0f);
    Color GreedColour = new Color(1f, 1f, 0f);

    public void Awake() 
    {
        Moves = new Button[] { Move1, Move2, Move3, Move4, Move5, Move6, Move7 };
        MovesPicked = new bool[] { Move1Picked, Move2Picked, Move3Picked, Move4Picked, Move5Picked, Move6Picked, Move7Picked };
    }
    
    // Start is called before the first frame update
    void Start()
    {
        LustCounter = 1;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Glutony() 
    {
        if (FightManager.GetComponent<FightManager>().IsPlayersTurn == true)
        {
            Debug.Log("Gluttony Attack");
            crit = Random.value;

            if (crit <= critChance)
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 30 + Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
            else
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 20 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
        }
    }
    void Lust() 
    {
        if (FightManager.GetComponent<FightManager>().IsPlayersTurn == true)
        {
            Debug.Log("Lust Move");
            
            crit = Random.value;

            if (crit <= critChance)
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 20 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4) * (LustCounter/4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
            else
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 10 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4) * (LustCounter/4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }

            LustCounter += 1;
        }
    }
    void Sloth() 
    {
        if (FightManager.GetComponent<FightManager>().IsPlayersTurn == true)
        {
            Debug.Log("Sloth Move");
            crit = Random.value;

            if (crit <= critChance)
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 30 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
            else
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 20 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
        }
    }
    void Pride() 
    {
        if (FightManager.GetComponent<FightManager>().IsPlayersTurn == true)
        {
            Debug.Log("Pride Move");
            crit = Random.value;

            if (crit <= critChance)
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 30 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
            else
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 20 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
        }
    }
    void Envy() 
    {
        if (FightManager.GetComponent<FightManager>().IsPlayersTurn == true)
        {
            Debug.Log("Envy Move");
            crit = Random.value;

            if (crit <= critChance)
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 30 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
            else
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 20 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
        }
    }
    void Anger()
    {
        if (FightManager.GetComponent<FightManager>().IsPlayersTurn == true)
        {
            Debug.Log("Anger Move");
            crit = Random.value;

            if (crit <= critChance)
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 30 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
            else
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 20 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
            }
        }
    }
    void Greed() 
    {
        if (FightManager.GetComponent<FightManager>().IsPlayersTurn == true)
        {
            Debug.Log("Greed Move");
            crit = Random.value;

            if (crit <= critChance)
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 30 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
                GameManagerOBJ.GetComponent<GameManager>().Demons += (FightManager.GetComponent<FightManager>().EnemyHealth / 15);
            }
            else
            {
                FightManager.GetComponent<FightManager>().EnemyHealth -= 20 * Random.Range(10, (GameManagerOBJ.GetComponent<GameManager>().Demons / 4));
                FightManager.GetComponent<FightManager>().IsPlayersTurn = false;
                GameManagerOBJ.GetComponent<GameManager>().Demons += (FightManager.GetComponent<FightManager>().EnemyHealth / 10);
            }
        }
    }


    public void AddMove() 
    {
        for (int i = 0; i < MovesPicked.Length; i++) 
        {
            if (MovesPicked[i] == false && MoveAssigned == false) 
            {
                MoveAssigned = true;
                for (int j = 0; j < Moves.Length; j++) 
                {
                    if (i == j) 
                    {
                        #region MoveAssignments
                        if (MoveNum == 1) 
                        {
                            MovesPicked[i] = true;
                            Moves[j].onClick.AddListener(Glutony);
                            Moves[j].GetComponent<Image>().color = GlutonyColour;
                        }
                        if (MoveNum == 2)
                        {
                            MovesPicked[i] = true;
                            Moves[j].onClick.AddListener(Lust);
                            Moves[j].GetComponent<Image>().color = LustColour;
                        }
                        if (MoveNum == 3)
                        {
                            MovesPicked[i] = true;
                            Moves[j].onClick.AddListener(Sloth);
                            Moves[j].GetComponent<Image>().color = SlothColour;
                        }
                        if (MoveNum == 4)
                        {
                            MovesPicked[i] = true;
                            Moves[j].onClick.AddListener(Pride);
                            Moves[j].GetComponent<Image>().color = PrideColour;
                        }
                        if (MoveNum == 5)
                        {
                            MovesPicked[i] = true;
                            Moves[j].onClick.AddListener(Envy);
                            Moves[j].GetComponent<Image>().color = EnvyColour;
                        }
                        if (MoveNum == 6)
                        {
                            MovesPicked[i] = true;
                            Moves[j].onClick.AddListener(Anger);
                            Moves[j].GetComponent<Image>().color = AngerColour;
                        }
                        if (MoveNum == 7)
                        {
                            MovesPicked[i] = true;
                            Moves[j].onClick.AddListener(Greed);
                            Moves[j].GetComponent<Image>().color = GreedColour;
                        }
                        #endregion
                    }
                }
                
            }
        }


    }


}
