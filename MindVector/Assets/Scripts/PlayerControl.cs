using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public int level = 1;

    public void ChangeLevel (int amount)
    {
        level += amount;
    }
}
