using UnityEngine;
using System.Collections;

public class Consommable : Objet
{
    protected float pointDeVie;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}


    public override void Utiliser()
    {
        
    }


    public float getPointDeVie()
    {
        return pointDeVie;
    }
}
