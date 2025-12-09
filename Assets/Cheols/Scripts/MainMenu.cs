using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheols
{
    public class MainMenu : MonoBehaviour
    {
        public GameObject MenuBack;
        public GameObject Menual;
        public GameObject Story;
        public void BtnMenual()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("GameMenual", 1.5f);
        }
        public void BtnStory()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Close");
            Invoke("OpenStory", 1.5f);
        }

        void OpenMeneual()
        {
            Menual.GetComponent<Animator>().SetTrigger("Open");
        }
        void OpenMenuBack()
        {
            MenuBack.GetComponent<Animator>().SetTrigger("Open");
        }
        void OpenStory()
        {
            Story.SetActive(true);
            Story.GetComponent<Animator>().SetTrigger("Open");
        }
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
