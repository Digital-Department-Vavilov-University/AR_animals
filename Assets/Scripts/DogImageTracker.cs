
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using TMPro;


public class DogImageTracker : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject infoPanel;
    public TextMeshProUGUI textPoroda;
    public TextMeshProUGUI textDescription;
    public Image dogPhoto;

    public Sprite huskySprite, chihuahuaSprite, labradorSprite;

    void OnEnable() => trackedImageManager.trackedImagesChanged += OnImageChanged;
    void OnDisable() => trackedImageManager.trackedImagesChanged -= OnImageChanged;

    void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            string name = trackedImage.referenceImage.name;
            infoPanel.SetActive(true);

            switch (name)
            {
                case "Husky":
                    textPoroda.text = "Хаски";
                    textDescription.text = "Активная и выносливая порода. Требует много прогулок.";
                    dogPhoto.sprite = huskySprite;
                    break;
                case "Chihuahua":
                    textPoroda.text = "Чихуахуа";
                    textDescription.text = "Маленькая и хрупкая порода. Требует бережного ухода.";
                    dogPhoto.sprite = chihuahuaSprite;
                    break;
                case "Labrador":
                    textPoroda.text = "Лабрадор";
                    textDescription.text = "Дружелюбная, семейная порода. Нуждается в активности.";
                    dogPhoto.sprite = labradorSprite;
                    break;
            }
        }
    }
}
