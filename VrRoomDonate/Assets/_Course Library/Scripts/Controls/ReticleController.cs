using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleController : MonoBehaviour
{
    [SerializeField] private float spinSpeed = 5f;
    [SerializeField] private float scaleSpeed = 0.1f;
    [SerializeField] private float maxScale = 1.5f;
    [SerializeField] private float minScale = 1f;

    private bool isScalingUp = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 private   void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        if (isScalingUp)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x <= minScale)
            {
                isScalingUp = false;
            }
            else
            {
                transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
                if (transform.localScale.x <= minScale)
                {
                    isScalingUp = true;
                }
            }    
        }
    }
}
