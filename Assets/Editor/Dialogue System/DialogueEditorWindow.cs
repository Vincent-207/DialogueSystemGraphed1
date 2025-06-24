using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace DS.Windows
{
    public class DialogueEditorWindow : EditorWindow
    {
        [MenuItem("Window/Dialogue System/Dialogue Graph")]
        public static void ShowExample()
        {
            GetWindow<DialogueEditorWindow>("Dialogue Graph");
        }

        public void CreateGUI()
        {
            AddGraphView();
            AddStyles();
        }

        private void AddGraphView()
        {
            DSGraphView graphView = new DSGraphView();

            graphView.StretchToParentSize();

            rootVisualElement.Add(graphView);
        }

        private void AddStyles()
        {
            StyleSheet styleSheet = (StyleSheet)EditorGUIUtility.Load("DialogueSystem/DSVariables.uss");
            rootVisualElement.styleSheets.Add(styleSheet);
        }
    }

    
}
