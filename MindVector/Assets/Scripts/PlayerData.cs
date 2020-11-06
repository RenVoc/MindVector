using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData {
    // Создаем конструктор сохранения и описываем что именно сохранять.


    public int level;

    public PlayerData (PlayerControl player)
    {
        level = player.level;
    }

}
