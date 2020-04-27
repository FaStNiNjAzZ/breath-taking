using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class PlayerData
{
    public bool militaryUnlock;
    public bool factoryUnlock;
   

    public PlayerData (PlayerScript player)
    {
        militaryUnlock = player.militaryUnlock;
        factoryUnlock = player.factoryUnlock;
    }
}
