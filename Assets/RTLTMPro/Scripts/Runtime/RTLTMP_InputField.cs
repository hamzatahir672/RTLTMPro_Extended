using TMPro;
using UnityEngine;

namespace RTLTMPro
{
    public class RTLTMP_InputField : TMP_InputField
    {

        [SerializeField]
        RTLTextMeshPro displayText;

        protected override void Awake()
        {
            displayText = GetComponentInChildren<RTLTextMeshPro>();
            onValueChanged.AddListener((string newText) =>
            {
                UpdateRTLText(newText); ;

            });
        }


        void UpdateRTLText(string newText)
        {
            if (displayText == null)
            {
                Debug.LogError("Display text not found.");
                return;
            }

            if (displayText == m_Placeholder)
            {
                Debug.LogError("Display text not found. Make sure the DisplayText is placed as first child object.");
                return;
            }

            displayText.ChangeText(newText);
        }
    }
}
