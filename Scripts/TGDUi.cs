using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/* The Guardian Dog Studio Library */
/* Com esse script, você tem acesso à funções para criação de interfaces */
/* Para mais informações, leia o arquivo README.txt */


public class TGDUi : MonoBehaviour
{

    /// <summary>
    ///Renderiza txt na tela como um elemento de texto, passando um vetor de 2 dimesões com as posições x e y. (criado a partir do ponto superior esquerdo da tela).
    ///Se um texto for instanciado na mesma posição que outro, o anterior será removido. Isso possibilita o acompanhamento de variáveis em tempo real.
    /// </summary>
    public static void displayText(string txt, Vector2 pos)
    {        

        foreach (Text obj in FindObjectsOfType<Text>()){   
            if(obj.transform.localPosition.Equals(new Vector2(pos.x, pos.y)))  //Checa se o texto atual está sendo instanciado em cima de algum texto ja criado na mesma posição.
            {
                GameObject.Destroy(obj.transform.parent.gameObject);  //Se sim, remove o texto anterior.
            }
        }

        GameObject canvas = new GameObject("Canvas");  //Cria um novo objeto que será o canvas para renderizar o texto.
        GameObject textBox = new GameObject("Text");   //Cria um novo objeto que será o texto.
        textBox.transform.SetParent(canvas.transform); 

        canvas.AddComponent<Canvas>();  //Adiciona o componente Canvas ao canvas.
        canvas.AddComponent<CanvasScaler>();  
        canvas.AddComponent<GraphicRaycaster>(); 
        canvas.GetComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;  //Renderiza o canvas como um overlay da tela. Isso permite mover a câmera livremente sem alterar a posição do texto. 
        canvas.layer = LayerMask.NameToLayer("UI");  //Coloca o canvas na layer de UI.

        
        textBox.AddComponent<Text>();  //Adiciona o componente Canvas ao textbox.
        textBox.GetComponent<Text>().font = Resources.GetBuiltinResource<Font>("Arial.ttf");  
        textBox.GetComponent<Text>().color = Color.black;
        textBox.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);  //Define o tamanho da caixa de texto como o tamado de toda a tela. Permite controlar melhor a posição do texto.
        textBox.layer = LayerMask.NameToLayer("UI");  //Coloca o textbox na layer de UI.

        textBox.GetComponent<Text>().text = txt;  //Define o conteúdo do texto com o parâmetro passado.
        textBox.transform.localPosition = new Vector2(pos.x, pos.y);  //Define a posição do texto com os parâmetro passados.
        
    }
}
