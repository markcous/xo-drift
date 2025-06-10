using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Canvas))]
public class ConfigScreenController : MonoBehaviour
{
    [Header("Data (SO)")]
    public MissionData missionData;

    [Header("UI Refs")]
    public RectTransform contentParent;
    public GameObject itemTemplate;
    public Button confirmButton;

    private int selectedIndex = -1;

    void Start()
    {
        // Hide the template so only clones show
        itemTemplate.SetActive(false);

        // Populate list from missionData.options
        for (int i = 0; i < missionData.options.Length; i++)
        {
            GameObject clone = Instantiate(itemTemplate, contentParent);
            clone.SetActive(true);

            // Find the TMP label under this clone
            var label = clone.GetComponentInChildren<TextMeshProUGUI>();
            if (label != null)
                label.text = missionData.options[i];
            else
                Debug.LogError("No TextMeshProUGUI found on ItemTemplate clone!");

            int idx = i;
            var btn = clone.GetComponent<Button>();
            if (btn != null)
                btn.onClick.AddListener(() => OnItemClicked(idx));
        }

        confirmButton.onClick.AddListener(OnConfirm);
    }

    void OnItemClicked(int idx)
    {
        selectedIndex = idx;
        missionData.selectedOption = missionData.options[idx];
        Debug.Log($"Selected: {missionData.selectedOption}");
        HighlightSelectedItem();
    }

    void OnConfirm()
    {
        if (selectedIndex >= 0)
            Debug.Log($"Confirmed: {missionData.selectedOption}");
        else
            Debug.LogWarning("No option selected!");
    }

    void HighlightSelectedItem()
    {
        for (int i = 0; i < contentParent.childCount; i++)
        {
            var child = contentParent.GetChild(i);
            var img = child.GetComponent<Image>();
            if (img != null)
                img.color = (i == selectedIndex)
                    ? new Color32(51, 102, 204, 255)
                    : Color.white;

            var label = child.GetComponentInChildren<TextMeshProUGUI>();
            if (label != null)
                label.fontStyle = (i == selectedIndex)
                    ? FontStyles.Bold
                    : FontStyles.Normal;
        }
    }
}
