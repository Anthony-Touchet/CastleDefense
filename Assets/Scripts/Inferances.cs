using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public interface Damageable
    {
        int health { get; set; }
    }

    public interface DoesDamage
    {
        int damage { get; set; }
    }
}
