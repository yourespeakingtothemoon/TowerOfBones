using MongoDB.Driver;
using System;
using System.Collections.Generic;
using TowerOfBones.Models;


namespace TowerOfBones.DAL
{
	public class DataAccessLayer
	{
		//public MongoClient Skeledb = new MongoClient("mongodb+srv://skeleton.c2whijm.mongodb.net/?authSource=%24external&authMechanism=MONGODB-X509&retryWrites=true&w=majority");

		public static IMongoDatabase Database = new MongoClient("mongodb+srv://skeleton.c2whijm.mongodb.net/?authSource=%24external&authMechanism=MONGODB-X509&retryWrites=true&w=majority").GetDatabase("TowerBone");
		public List<User> GetUsers()
		{
			List<User> users = new List<User>();
			try
			{
				users = Database.GetCollection<User>("Users").Find(x => true).ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return users;
		}
	}
}
