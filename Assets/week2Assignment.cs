using System;
using UnityEngine;

public class week2Assignment : MonoBehaviour
{
    //variables

    [SerializeField] string characterName;
    [SerializeField] int profiencyBonus;
    [SerializeField] bool finesseWeapon;
    [SerializeField][Range(-5, 5)] int strength;
    [SerializeField][Range(-5, 5)] int dexterity;
    


    // Start is called before the first frame update
    void Start()
    {
        int enemyAC = UnityEngine.Random.Range(1, 21);
        int D20 = UnityEngine.Random.Range(1, 21);


        Debug.Log(characterName + " hit modifier is " + (profiencyBonus + strength)  + " for strength and " + (profiencyBonus + dexterity) + " for dexterity");

        Debug.Log("Time to roll the die of fate: ");

        Debug.Log("You have rolled a " + (D20.ToString("+#;-#;0")));


        if (!finesseWeapon)
        { 
            if (strength + profiencyBonus + D20 > enemyAC)
            {
                Debug.Log("Enemy AC is " + enemyAC);

                Debug.Log(characterName + " attack is " +  (strength + profiencyBonus + D20));

                Debug.Log("Enemy is hit. Good job traveler! ");
            }

            else
            {
                Debug.Log("Enemy AC is " + enemyAC);

                Debug.Log(characterName + " attack is " + (strength + profiencyBonus + D20));

                Debug.Log(characterName + "'s attack has failed!");

            }
        
        
        }

        else 
        {
            if (strength > dexterity)
            {
                if(strength + profiencyBonus + D20 > enemyAC)
                {
                    Debug.Log("Enemy AC is " + enemyAC);

                    Debug.Log(characterName + " attack is " + (strength + profiencyBonus + D20));

                    Debug.Log("Enemy is hit. Good job traveler! ");
                }

                else
                {
                    Debug.Log("Enemy AC is " + enemyAC);

                    Debug.Log(characterName + " attack is " + (strength + profiencyBonus + D20));

                    Debug.Log(characterName + "'s attack has failed!");

                }


            }

            else
            {
                if (dexterity + profiencyBonus + D20 > enemyAC)
                {
                    Debug.Log("Enemy AC is " + enemyAC);

                    Debug.Log(characterName + " attack is " + (dexterity + profiencyBonus + D20));

                    Debug.Log("Enemy is hit. Good job traveler! ");
                }

                else
                {
                    Debug.Log("Enemy AC is " + enemyAC);

                    Debug.Log(characterName+ " attack is " + (dexterity + profiencyBonus + D20));

                    Debug.Log(characterName + "'s attack has failed!");

                }


            }


        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
