using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer { 
 public class clsTransactionTypes 
{ 



		public enum enMode {AddNew = 1, Update=2};
		public enMode Mode {get;set;}

		public int TransactionTypeID {get; set;}
		public string TransactionType {get; set;}
		public string TransactionDescription {get; set;}



		public clsTransactionTypes(int TransactionTypeID, string TransactionType, string TransactionDescription) {
 
			this.TransactionTypeID = TransactionTypeID;
			this.TransactionType = TransactionType;
			this.TransactionDescription = TransactionDescription;
			Mode= enMode.Update;

		}

		public clsTransactionTypes() {
 
			this.TransactionTypeID = -1;
			this.TransactionType = "";
			this.TransactionDescription = "";
			Mode= enMode.AddNew;

		}

		private bool _AddNewTransactionTypes() { 

  			this.TransactionTypeID = DataAccess_Layer.clsTransactionTypes.AddNewTransactionTypes(this.TransactionType, this.TransactionDescription);

			 return this.TransactionTypeID != -1;
		 }

		private bool _UpdateTransactionTypes() { 

 			 return DataAccess_Layer.clsTransactionTypes.UpdateTransactionTypes(this.TransactionTypeID, this.TransactionType, this.TransactionDescription);
		 }

		private bool _DeleteTransactionTypes() { 

 			 return DataAccess_Layer.clsTransactionTypes.DeleteTransactionTypes(this.TransactionTypeID);
		 }

		public static clsTransactionTypes Find(int TransactionTypeID) { 

 		string TransactionType = "";
		string TransactionDescription = "";

		 if (DataAccess_Layer.clsTransactionTypes.Find(TransactionTypeID,  ref TransactionType,  ref TransactionDescription)) { 

 		 return new clsTransactionTypes(TransactionTypeID, TransactionType, TransactionDescription);
		 } else 
		{ 
		return null;
}
		 }

		public bool Save() { 

 		 switch(Mode) { 
			 case enMode.Update:
			 return _UpdateTransactionTypes();

			 case enMode.AddNew: 

				 if (_AddNewTransactionTypes()) { 
					Mode = enMode.Update;
					return true;

			} else { 
 					 return false; } 
					default: return false;

 } 
		}

		public static bool DoesTransactionTypesExists(int TransactionTypeID) {
			return DataAccess_Layer.clsTransactionTypes.DoesTransactionTypesExists(TransactionTypeID);
		 }

		public  bool DoesTransactionTypesExists() {
			return DoesTransactionTypesExists(this.TransactionTypeID);
		 }

	public static DataTable GetAllTransactionTypes() {
		 return DataAccess_Layer.clsTransactionTypes.GetAllTransactionTypes();
	}


}
}
