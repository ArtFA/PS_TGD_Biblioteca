using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* The Guardian Dog Studio Library */
/* Com esse script, você tem acesso à uma série de funções relacioandas à matemática e vetores */
/* Para mais informações, leia o arquivo README.txt */


public class TGDMath
{

    /// <summary>
    ///Retorna um número aleatório dado o intervalo entre min e max (incluindo os limites).
    /// </summary>
    public static float random(float min, float max) 
    {
        return Random.Range(min, max);
    }


    /// <summary>
    /// Retorna um vetor de 2 dimensões de forma aleatória, dados os intervalos para cada dimensão (incluindo os limites).
    /// </summary>
    public static Vector2 randomVector(float minX, float maxX, float minY, float maxY) 
    {
        return new Vector2 (Random.Range(minX, maxX), Random.Range(minY, maxY));
    }


    /// <summary>
    /// Retorna o ângulo entre 2 planos (em graus).
    /// </summary>
    public static float angleBetweenPlanes(Plane plane1, Plane plane2)
    {
        float normalsAngle = Vector3.SignedAngle(plane1.normal, plane2.normal, new Vector3(0,0,0));

        return normalsAngle == 180 ? 0 : normalsAngle;  //Se ângulo entre normais dos planos for 180°, retorne 0, se não, retorne o ângulo.
    }


    /// <summary>
    /// Rotaciona um vetor de 2 dimensões no ângulo especificado em graus, retorna o vetor rotacionado.
    /// </summary>
    public static Vector2 rotateVector(Vector2 vector, float angle)
    {
        float angleRad = Mathf.Deg2Rad * angle; //recebe o ângulo especificado em radianos.

        return new Vector2(
            vector.x * Mathf.Cos(angleRad) - vector.y * Mathf.Sin(angleRad),  // Calcula a componente x do novo vetor.
            vector.x * Mathf.Sin(angleRad) + vector.y * Mathf.Cos(angleRad)   // Calcula a componente y do novo vetor.
        );
    }


    /// <summary>
    /// Retorna um vetor de 2 dimensões aleatório normalizado.
    /// </summary>
    public static Vector2 generateNormalizedVector()
    {
        Vector2 vetor = new Vector2(random(-100,100), random(-100, 100)); //Randomiza valores para um vetor.
        
        return vetor.normalized; //Retorna esse vetor normalizado.
    }

}
