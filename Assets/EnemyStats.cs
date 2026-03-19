using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [Header("Enemy Attributes")]
    public float speed = 5f;
    public int health = 100;

    void Start()
    {
        Debug.Log(gameObject.name + " spawned with speed: " + speed + " and health: " + health);
    }
}
