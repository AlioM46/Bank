using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer { 
 public class clsPhones 
{ 



		public enum enMode {AddNew = 1, Update=2};
		public enMode Mode {get;set;}

		public int PhoneID {get; set;}
		public string PhoneNumber {get; set;}
		public int PersonID {get; set;}

		// Composition of People
		public clsPeople People ; 



		public clsPhones(int PhoneID, string PhoneNumber, int PersonID) {
 
			this.PhoneID = PhoneID;
			this.PhoneNumber = PhoneNumber;
			this.PersonID = PersonID;

			People = clsPeople.Find(PersonID);

			Mode= enMode.Update;

		}

		public clsPhones() {
 
			this.PhoneID = -1;
			this.PhoneNumber = "";
			this.PersonID = -1;
			Mode= enMode.AddNew;

		}

		private bool _AddNewPhones() { 

  			this.PhoneID = DataAccess_Layer.clsPhones.AddNewPhones(this.PhoneNumber, this.PersonID);

			 return this.PhoneID != -1;
		 }

		private bool _UpdatePhones() { 

 			 return DataAccess_Layer.clsPhones.UpdatePhones(this.PhoneID, this.PhoneNumber, this.PersonID);
		 }

		private bool _DeletePhones() { 

 			 return DataAccess_Layer.clsPhones.DeletePhones(this.PhoneID);
		 }

		public static clsPhones Find(int PhoneID) { 

 		string PhoneNumber = "";
		int PersonID = -1;

		 if (DataAccess_Layer.clsPhones.Find(PhoneID,  ref PhoneNumber,  ref PersonID)) { 

 		 return new clsPhones(PhoneID, PhoneNumber, PersonID);
		 } else 
		{ 
		return null;
}
		 }

		public bool Save() { 

 		 switch(Mode) { 
			 case enMode.Update:
			 return _UpdatePhones();

			 case enMode.AddNew: 

				 if (_AddNewPhones()) { 
					Mode = enMode.Update;
					return true;

			} else { 
 					 return false; } 
					default: return false;

 } 
		}

		public static bool DoesPhonesExists(int PhoneID) {
			return DataAccess_Layer.clsPhones.DoesPhonesExists(PhoneID);
		 }

		public  bool DoesPhonesExists() {
			return DoesPhonesExists(this.PhoneID);
		 }

	public static DataTable GetAllPhones() {
		 return DataAccess_Layer.clsPhones.GetAllPhones();
	}


}
}
