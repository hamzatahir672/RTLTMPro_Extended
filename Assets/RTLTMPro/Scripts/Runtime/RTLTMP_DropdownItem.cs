using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RTLTMPro
{
    public class RTLTMP_DropdownItem : MonoBehaviour
    {
        RTLTextMeshPro text;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void OnEnable()
        {
            StartCoroutine(DoOnNextFrame(() =>
            {
                Transform parnt = GetComponentInParent<Toggle>().transform;
                string optionText = parnt.name;
                optionText = optionText.Replace("Item " + (parnt.GetSiblingIndex() - 1) + ": ", "");

                text = GetComponent<RTLTextMeshPro>();

                text.ChangeText(optionText);
            })); ;
        }

        IEnumerator DoOnNextFrame(System.Action toDo) 
        {

            yield return null;

            toDo.Invoke();
        }

        //// Update is called once per frame
        //void Update()
        //{

        //}
    }
}
