using UnityEngine;
using UnityEngine.UIElements;

public class CharacterSheet : MonoBehaviour
{
    [SerializeField] string characterName;
    [SerializeField] int proficiency;
    [SerializeField] bool finesseWeapon;
    [SerializeField][Range(-5, 5)] int strength;
    [SerializeField][Range(-5, 5)] int dexterity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
