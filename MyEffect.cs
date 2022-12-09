using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class MyEffect : UsableItem.UsageEffect
{
    public int healthAmount;
    public override bool Use(CharacterData user)
    {
        user.Stats.ChangeHealth(healthAmount);
        return true;
    }
}
