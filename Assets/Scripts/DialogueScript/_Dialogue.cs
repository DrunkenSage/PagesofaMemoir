﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class _Dialogue {

    public string name;

    [TextArea(3,10)]
    public string[] sentences;
    public bool HasSkillOn;

}
    // Start is called before the first frame update

