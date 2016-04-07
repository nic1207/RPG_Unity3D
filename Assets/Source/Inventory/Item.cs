using UnityEngine;
using System.Collections;

/*=======================================================================================*/
/*----------------Clase de persistencia para todos los items del juego-------------------*/
/*---Los items son cargados desde el archivo "Items.json"--------------------------------*/
/*=======================================================================================*/

public class Item : MonoBehaviour {
	public int Group;
	public int ID;
	public string Title;

	public Item(int Group, int ID, string Title)
	{
		this.Group = Group;
		this.ID = ID;
		this.Title = Title;
	}
}
