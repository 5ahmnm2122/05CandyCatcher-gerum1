using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrightName : MonoBehaviour
{
    public DataSaver data;

    public Text Name;
   
        public void StartGame ()
    {
        data.PlayerName = Name.text;
    }
   
}
