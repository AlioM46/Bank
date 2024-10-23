using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer { 
 public class clsPeople 
{ 



		public enum enMode {AddNew = 1, Update=2};
		public enMode Mode {get;set;}

		public int PersonID {get; set;}
		public string FirstName {get; set;}
		public string SecondName {get; set;}
		public string ThirdName {get; set;}
		public string LastName {get; set;}
		public DateTime DateOfBirth {get; set;}
		public string Email {get; set;}
		public string Address {get; set;}



		public clsPeople(int PersonID, string FirstName, string SecondName, string ThirdName, string LastName, DateTime DateOfBirth, string Email, string Address) {
 
			this.PersonID = PersonID;
			this.FirstName = FirstName;
			this.SecondName = SecondName;
			this.ThirdName = ThirdName;
			this.LastName = LastName;
			this.DateOfBirth = DateOfBirth;
			this.Email = Email;
			this.Address = Address;
			Mode= enMode.Update;

		}

		public clsPeople() {
 
			this.PersonID = -1;
			this.FirstName = "";
			this.SecondName = "";
			this.ThirdName = "";
			this.LastName = "";
			this.DateOfBirth = DateTime.MaxValue;
			this.Email = "";
			this.Address = "";
			Mode= enMode.AddNew;

		}

		private bool _AddNewPeople() { 

  			this.PersonID = DataAccess_Layer.clsPeople.AddNewPeople(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Email, this.Address);

			 return this.PersonID != -1;
		 }

		private bool _UpdatePeople() { 

 			 return DataAccess_Layer.clsPeople.UpdatePeople(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Email, this.Address);
		 }

		private bool _DeletePeople() { 

 			 return DataAccess_Layer.clsPeople.DeletePeople(this.PersonID);
		 }

		public static clsPeople Find(int PersonID) { 

 		string FirstName = "";
		string SecondName = "";
		string ThirdName = "";
		string LastName = "";

		DateTime DateOfBirth = new DateTime();
		DateOfBirth = DateTime.MaxValue;

		string Email = "";
		string Address = "";

		 if (DataAccess_Layer.clsPeople.Find(PersonID,  ref FirstName,  ref SecondName,  ref ThirdName,  ref LastName,  ref DateOfBirth,  ref Email,  ref Address)) { 

 		 return new clsPeople(PersonID, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Email, Address);
		 } else 
		{ 
		return null;
}
		 }

		public bool Save() { 

 		 switch(Mode) { 
			 case enMode.Update:
			 return _UpdatePeople();

			 case enMode.AddNew: 

				 if (_AddNewPeople()) { 
					Mode = enMode.Update;
					return true;

			} else { 
 					 return false; } 
					default: return false;

 } 
		}

		public static bool DoesPeopleExists(int PersonID) {
			return DataAccess_Layer.clsPeople.DoesPeopleExists(PersonID);
		 }

		public  bool DoesPeopleExists() {
			return DoesPeopleExists(this.PersonID);
		 }

	public static DataTable GetAllPeople() {
		 return DataAccess_Layer.clsPeople.GetAllPeople();
	}


}
}
