using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheols
{
    public class Cheat : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                //GameObject.Find("Player").GetComponent<Player>().SetBomb();
            }
            if(GameObject.Find("GameManger") != null)
            {
                /*if (GameObject.Find("GameManger").GetComponent<GameManager>().isBoss)
                {
                    Destroy(GameObject.Find("Boss"));
                    GameObject.Find("GameManger").GetComponent<GameManager>().GameClear();
                }*/
            }
        }
    }
}
