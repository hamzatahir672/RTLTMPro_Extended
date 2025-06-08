using TMPro;
using UnityEngine;

namespace RTLTMPro
{
    [RequireComponent(typeof(TMP_Dropdown))]
    public class RTLTMP_Dropdown : MonoBehaviour
    {
        TMP_Dropdown dropdown;
        RTLTextMeshPro labelText; 

        protected  void Awake()
        {
            dropdown = GetComponent<TMP_Dropdown>();
            labelText = (RTLTextMeshPro)dropdown.captionText;
            dropdown.onValueChanged.AddListener((int selectedOption) =>
            {
                labelText.ChangeText(dropdown.options[selectedOption].text);
            });
        }

        private void OnEnable()
        {
            labelText.ChangeText(dropdown.options[0].text);
            labelText.UpdateText();
        }
    }
}