using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* The Guardian Dog Studio Library */
/* Com esse script, você tem acesso à funções que envolvem o controle da câmera */
/* Esse script deve ser adicionado como componente da câmera principal */
/* Para mais informações, leia o arquivo README.txt */


public class TGDCamera : MonoBehaviour
{
    protected static TGDCamera instance; //Instancia um objeto da classe TGDcamera para ter acesso à função "StartCoroutine".


    void Awake()
    {
        instance = this; //Recebe o objeto no qual o script está atrelado (deve ser a câmera).
    }

    /// <summary>
    /// Treme a câmera utilizando os parâmetros de duração(duration) e a intensidade(magnitude).
    /// </summary>
    public static void shake(float duration, float magnitude) 
    {
        if (duration <= 0)
        {
            Debug.LogError("Duração do tremor deve ser um valor positivo!");
            return;
        }

        if (magnitude <= 0) {
            Debug.LogError("Magnitude do tremor deve ser um valor positivo!");
            return;
        }

        instance.StopAllCoroutines(); //Interrompe tremores anteriores
        instance.StartCoroutine(instance.cameraShakeController(duration, magnitude)); //Invoca a função que implementa o tremor da câmera.
    }


    private IEnumerator cameraShakeController(float duration, float magnitude) //Função que implementa o tremor da câmera.
    {
        Vector3 cameraOriginalPos = instance.transform.position; //Recebe posição inicial da câmera.
        float passedTime = 0.0f;
        float initialMagnitude = magnitude;
        float decreaseFactor = magnitude/duration; //Fator de desaceleração do tremor.

        while (passedTime <= duration)
        {
            float newX = Random.Range(-1f, 1f) * magnitude;
            float newY = Random.Range(-1f, 1f) * magnitude;

            instance.transform.position = new Vector3(newX, newY, cameraOriginalPos.z); //Muda posição da câmera para coordenadas randomizadas.
            passedTime += Time.deltaTime;
            magnitude = initialMagnitude - (passedTime * decreaseFactor); //Desacelera tremor de forma linear.

            yield return null;
        }

        instance.transform.position = cameraOriginalPos; //retorna câmera para posição inicial.
    }
}

