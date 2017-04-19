﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections.Generic;

namespace NodePanels
{
    [System.Serializable]
    public class NodePanelPair
    {
        public bool hideSelf;
        public Button openBtn;
        public Toggle openTog;
        public NodePanel nodePanel;
    }
}
