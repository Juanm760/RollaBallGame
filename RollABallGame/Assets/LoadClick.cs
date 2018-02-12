using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadClick : MonoBehaviour {
	public void loadScene(int level)
    {
        Application.LoadLevel(level);
    }
}
