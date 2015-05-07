﻿/***************************************************************************************/
/*
	filename   	Level2.as 
	author		Elie Abi Chahine
	email   	eabichahine@digipen.edu
	date		10/02/2013 
	
	brief:
	This class contains level 3's gameplay code. 
	
*/        	 
/***************************************************************************************/
package GamePlay.Level3
{
	import Engine.*;
	import GamePlay.Level2.HeroSP;
	import flash.ui.Keyboard;

	public class Level3 extends State
	{
		/*******************************************************************************/
		/*
			Description:
				The load function will load all needed tile map xmls. 
			
			Parameters:
				- None
				
			Return:
				- None
		*/
		/*******************************************************************************/
		override public function Load():void
		{
		}

		/*******************************************************************************/
		/*
			Description:
				The create function is called after all the xmls are loaded. Its job is
				to load the tile map information from each xml. Only the background xml
				is added at this point since it will not be added again when we restart
				the level.
			
			Parameters:
				- None
				
			Return:
				- None
		*/
		/*******************************************************************************/
		override public function Create():void
		{			
		}
		
		/*******************************************************************************/
		/*
			Description:
				The Initialize function will add the dynamic tile map objects.
			
			Parameters:
				- None
				
			Return:
				- None
		*/
		/*******************************************************************************/
		override public function Initialize():void
		{
			ObjectManager.AddObject(new HeroSP(), "Hero", ObjectManager.OM_DYNAMICOBJECT);
			ObjectManager.AddObject(new CoinSP(), "Coin", ObjectManager.OM_DYNAMICOBJECT);
		}
		
		/*******************************************************************************/
		/*
			Description:
				The update function handles the user's choice. The user can restart the 
				level by pressing "R" or go back to the main menu by pressing "M". If
				all coins are picked up, the level is over and the game goes back to the
				main menu.
			
			Parameters:
				- None
				
			Return:
				- None
		*/
		/*******************************************************************************/
		override public function Update():void
		{
			if(InputManager.IsTriggered(Keyboard.R))
			{
				GameStateManager.RestartState();
			}
		}

		/*******************************************************************************/
		/*
			Description:
				The uninitialize function is responsible to clean up objects that were 
				created in the initialize function. 
			
			Parameters:
				- None
				
			Return:
				- None
		*/
		/*******************************************************************************/
		override public function Uninitialize():void
		{
			ObjectManager.RemoveAllObjectsByName("Hero", ObjectManager.OM_DYNAMICOBJECT);
			ObjectManager.RemoveAllObjectsByName("Coin", ObjectManager.OM_DYNAMICOBJECT);
		}
	}
}