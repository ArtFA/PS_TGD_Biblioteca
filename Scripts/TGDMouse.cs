using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* The Guardian Dog Studio Library */
/* Com esse script, você tem acesso à funções que envolvem checar a posição do mouse */
/* Para mais informações, leia o arquivo README.txt */


public class TGDMouse
{
    /// <summary>
    ///Retorna um vetor de 2 dimensões com a posição do mouse em relação ao que se encontra na cena. 
    /// </summary>    
    public static Vector2 positionOnScene() 
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z * -1); //Recebe a posição do mouse, independente da distância da câmera.       
        return Camera.main.ScreenToWorldPoint(mousePos);
    }


    /// <summary>
    ///Retorna um vetor de 2 dimensões com a posição do mouse em relação ao que se encontra na UI (espaço visível na tela). 
    /// </summary>   
    public static Vector2 positionOnScreen() 
    {
        return Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }


    /// <summary>
    ///Retorna true se o mouse está sobre um objeto. 
    /// </summary>   
    public static bool isHittingObject()
    {
        Vector3 mouse = Input.mousePosition;  //Recebe posição do mouse
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);  //Instancia um raio de colisão a partir da posição do mouse
        RaycastHit hit;

        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))  //Verifica se o raio de colisão está entrando em contato com algum objeto
            return true;
        else
            return false;
    }  

}
