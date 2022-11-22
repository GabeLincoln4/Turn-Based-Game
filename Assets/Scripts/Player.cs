using UnityEngine;

public class Player : MonoBehaviour
{
    private Attack _attack;
    private string _attackerName;
    private float _damageTaken;

    void Awake()
    {
        _attack = gameObject.AddComponent<Attack>();
        _attackerName = gameObject.name;

    }

    void Update()
    {
        _damageTaken = _attack.DisplayAttackData(_attackerName, "Ralphie", "Sword");
    }
}