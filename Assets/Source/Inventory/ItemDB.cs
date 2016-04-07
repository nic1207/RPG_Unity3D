using UnityEngine;
using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;

/*=======================================================================================*/
/*--------------------Esta clase contiene todos los items del juego----------------------*/
/*---Los items son cargados desde el archivo "Items.json"--------------------------------*/
/*=======================================================================================*/

public class ItemDB : MonoBehaviour {

	private List<Item> dataBase = new List<Item>(); //ArrayList with all the objects of type <Items> loaded from the JSon Object.
	private JsonData itemData; //Object with the data from the JSon.


	void Start()
	{
		/*----Cargo los items de la base de datos en el archivo "Items.json"----*/
		itemData = JsonMapper.ToObject ( File.ReadAllText (Application.dataPath + "/StreamingAssets/Items.json") );
		ConstructItemDataBase ();

	}

	/*----Metodo que construye la base de datos de items desde el archivo "Items.json"----*/
	void ConstructItemDataBase ()
	{
		for( int i=0 ; i < itemData.Count ; i++ )
		{
			dataBase.Add ( new Item( (int)itemData[i]["group"] , (int)itemData[i]["id"] , itemData[i]["title"].ToString() ) );
		}
	} 
}
