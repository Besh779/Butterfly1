using UnityEngine;
using UnityEngine.UI;

public class LoadingCircle : MonoBehaviour
{
    public Image fillImage;
    public float rotationSpeed = 100f;
    private float currentFillAmount = 0f;

    // Add any other necessary variables here

    void Update()
    {
        // Rotate the loading circle
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        // Update the fill amount
        currentFillAmount += Time.deltaTime;
        if (currentFillAmount >= 1f)
        {
            currentFillAmount = 0f;
        }

        fillImage.fillAmount = currentFillAmount;
    }
}