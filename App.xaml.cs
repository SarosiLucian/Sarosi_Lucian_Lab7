﻿using System;
using Sarosi_Lucian_Lab7;
using System.IO;
using Sarosi_Lucian_Lab7.Data;

public partial class App : Application
{
    static ShoppingListDatabase database;
    public static ShoppingListDatabase Database 
	{ 
		get 
		{ 
			if (database == null) 
			{ 
				database = new 
					ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
					LocalApplicationData), "ShoppingList.db3")); 
			} 
			return database; 
		} 
	}
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
