using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarTexto : MonoBehaviour
{
   public Canvas Canvas;

   void OnTriggerEnter(Collider Usuario){
       if(Usuario.tag == "Player"){
        Debug.Log("El usuario deberia ver el texto ahora mismo");
        Canvas.enabled=true;
       }
   }

   void OnTriggerExit(Collider Usuario){
    if(Usuario.tag == "Player"){
        Debug.Log("El usuario ya no deberia estar viendo el texto");
        Canvas.enabled=false;
       }
   }
}
