using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Municiones : MonoBehaviour
{
    private float municion;


    private TextMeshProUGUI textMesh;
    // Start is called before the first frame update
    void Start()
    {
        textMesh= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
 
    public void SumarPuntos(float municionRecibida)
    {
        municion += municionRecibida;
        textMesh.text = municion.ToString("0");
    }
   
}
