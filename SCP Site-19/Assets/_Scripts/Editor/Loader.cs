using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEditor;

public class Loader : EditorWindow
{
    [MenuItem("Window/Site19Custom/SQL")]
    public static void ShowWindow()
    {
        GetWindow<Loader>("Scene Quick Loader");
    }

    void OnGUI()
    {
        GUILayout.BeginHorizontal();

        if (GUILayout.Button("Discord Loader"))
        {
            EditorSceneManager.OpenScene("Assets/_Scenes/DiscordLoader.unity");
        }

        if (GUILayout.Button("Hauptmen�"))
        {
            EditorSceneManager.OpenScene("Assets/_Scenes/MainMenu.unity");
        }

        if (GUILayout.Button("Einzelspieler"))
        {
            EditorSceneManager.OpenScene("Assets/_Scenes/Einzelspieler.unity");
        }

        if (GUILayout.Button("Mehrspieler"))
        {
            EditorSceneManager.OpenScene("Assets/_Scenes/MehrspielerError.unity");
        }

        GUILayout.EndHorizontal();
    }
}
