using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {

    //Name of the Character
    public string name;

    //(min,max)
    [TextArea(3,10)]
    //In the inspector, this show us the sentences we can edit
    public string[] sentences;
}
