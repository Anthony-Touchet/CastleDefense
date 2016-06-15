using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System;

public class EnemyAttributes : MonoBehaviour, Damageable {

    private int _health;
    public int damage;

    int Damageable.health
    {
        get { return _health; }
        set { _health = value; }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
