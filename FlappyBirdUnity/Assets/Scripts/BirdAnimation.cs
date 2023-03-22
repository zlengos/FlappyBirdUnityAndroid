using UnityEngine;

public class BirdAnimation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float takeoffRotation, landingRotation;

    private float rotZ;

    public void ApplyRotation(float velocityY)
    {
        if(rotZ > landingRotation)
        {
            float offset = 1f;
            if (velocityY > 0.5f) offset = velocityY;
            offset = Mathf.Abs(offset);

            rotZ -= rotationSpeed * Time.deltaTime / offset;
            transform.localEulerAngles = new Vector3(0, 0, rotZ);
        }
    }

    public void startRotation()
    {
        rotZ = takeoffRotation;
    }
}
