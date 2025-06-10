using UnityEngine;

[CreateAssetMenu(fileName = "NewMissionData", menuName = "XO Drift/Mission Data")]
public class MissionData : ScriptableObject
{
    [Header("Configuration Options")]
    [Tooltip("List of choices to display in the Config screen")]
    public string[] options;

    [Header("User Selection")]
    [Tooltip("The option chosen by the player")]
    public string selectedOption;
}
