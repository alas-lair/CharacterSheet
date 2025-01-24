using UnityEngine;
using UnityEngine.UIElements;

public class CharacterSheet : MonoBehaviour
{
    [SerializeField] string characterName;
    [SerializeField] int proficiency;
    [SerializeField] bool finesseWeapon;
    [SerializeField][Range(-5, 5)] int strength;
    [SerializeField][Range(-5, 5)] int dexterity;

    string AddSign(int n)
    {
        if (n < 0)
        {
            return n.ToString();
        }
        else
        {
            return $"+{n}";
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int hitModifier = (finesseWeapon ? Mathf.Max(strength, dexterity) : strength) + proficiency;
        Debug.Log($"{characterName}'s hit modifier is {AddSign(hitModifier)}");

        int enemyAC = Random.Range(10, 20 + 1);
        Debug.Log($"Enemy AC is {enemyAC}");
        
        int dieRoll = Random.Range(1, 20 + 1);
        Debug.Log($"{characterName} rolled a {dieRoll}");
        
        if (dieRoll + hitModifier >= enemyAC)
        {
            Debug.Log("Enemy is hit!");
        }
        else
        {
            Debug.Log("You miss!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
