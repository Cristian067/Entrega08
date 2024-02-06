using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class script : MonoBehaviour
{


    [SerializeField] private TextMeshProUGUI ej1_text;
    [SerializeField] private TextMeshProUGUI ej2_text;
    [SerializeField] private TextMeshProUGUI ej3_text;

    [SerializeField] private string word;





    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(ej1());
        StartCoroutine(ej2());
        StartCoroutine(ej3());
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    private IEnumerator ej1()
    {
        int numb = 0;
        //int numa = -1;
        //int suma = 0;



        for (int i = 0; i <= 10;i++)
        {
            yield return new WaitForSeconds(1);
            numb += i;
            ej1_text.text += $"{numb} \r\n";
        }
        

        //ej1_text.text += $"";
        
    }

    private IEnumerator ej2()
    {

        for (int bottle = 10; bottle > 0; bottle--)
        {
            yield return new WaitForSeconds(0.5f);

            ej2_text.text = $"{bottle} green bottles\r\n";
            yield return new WaitForSeconds(0.5f);
            ej2_text.text += $"Hanging on the wall\r\n";
            yield return new WaitForSeconds(0.5f);
            ej2_text.text += $"{bottle} green bottles\r\n";
            yield return new WaitForSeconds(0.5f);
            ej2_text.text += $"Hanging on the wall\r\n";
            yield return new WaitForSeconds(0.5f);
            ej2_text.text += $"And if one green bottle\r\n";
            yield return new WaitForSeconds(0.5f);
            ej2_text.text += $"Should accidentally fall\r\n";
            yield return new WaitForSeconds(0.5f);
            ej2_text.text += $"There’ll be {bottle-1} green bottles\r\n";
            yield return new WaitForSeconds(0.5f);
            ej2_text.text += $"Hanging on the wall ";
            yield return new WaitForSeconds(0.5f);
        }
    }

    private IEnumerator ej3()
    {
        string forming =  "";

        for (int i = 0; i < word.Length; i++)
        {
            char ch = word[i];
            yield return new WaitForSeconds(0.2f);

            forming = forming + ch;

            ej3_text.text += $"{forming} \r\n";
        }
    }

    
}
