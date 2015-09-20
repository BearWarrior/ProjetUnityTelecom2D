using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Joueur : Personnage
{

	// Use this for initialization
	void Start ()
    {
        pointDeVieMax = 10;
        pointDeVie = pointDeVieMax - 5;

        inventaire = new List<Objet>();

        Ration res = new Ration();
        inventaire.Add(res);
    }
	

	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKey(KeyCode.P))
        {
            if(inventaire[0] is Consommable)
            {
                Debug.Log("consommable");
                if(UtiliserConsommable((inventaire[0] as Consommable)))
                {
                    inventaire.RemoveAt(0);
                }
            }
            else
            {
                Debug.Log("pas consommable");
            }
        }
	}


    bool UtiliserConsommable(Consommable c)
    {
        //Si on a réussi a soigner on renvoie true, sinon false
        //Au retour, si true : on détruit l'objet, si false : on le laisse
        if(Soigner(c.getPointDeVie()))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
