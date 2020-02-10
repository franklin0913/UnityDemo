using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameData
{
    public class GameFlowData
    {
        public string UserID { get; set; }

        public GameFlowData(string userid)
        {
            UserID = userid;
        }
    }
}
