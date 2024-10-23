using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer { 
 public class clsAccounts 
{ 



		public enum enMode {AddNew = 1, Update=2};
		public enMode Mode {get;set;}

		public int AccountID {get; set;}
		public int CustomerID {get; set;}
		public int AccountTypeID {get; set;}
		public decimal Balance {get; set;}
		public string AccountNumber {get; set;}
		public string Currency {get; set;}
		public int Status {get; set;}
		public DateTime CreatedDate {get; set;}

		// Composition of Customers
		public clsCustomers Customers ; 

		// Composition of AccountTypes
		public clsAccountTypes AccountTypes ; 



		public clsAccounts(int AccountID, int CustomerID, int AccountTypeID, decimal Balance, string AccountNumber, string Currency, int Status, DateTime CreatedDate) {
 
			this.AccountID = AccountID;
			this.CustomerID = CustomerID;

			Customers = clsCustomers.Find(CustomerID);

			this.AccountTypeID = AccountTypeID;

			AccountTypes = clsAccountTypes.Find(AccountTypeID);

			this.Balance = Balance;
			this.AccountNumber = AccountNumber;
			this.Currency = Currency;
			this.Status = Status;
			this.CreatedDate = CreatedDate;
			Mode= enMode.Update;

		}

		public clsAccounts() {
 
			this.AccountID = -1;
			this.CustomerID = -1;
			this.AccountTypeID = -1;
			this.Balance = -1;
			this.AccountNumber = "";
			this.Currency = "";
			this.Status = -1;
			this.CreatedDate = DateTime.MaxValue;
			Mode= enMode.AddNew;

		}

		private bool _AddNewAccounts() { 

  			this.AccountID = DataAccess_Layer.clsAccounts.AddNewAccounts(this.CustomerID, this.AccountTypeID, this.Balance, this.AccountNumber, this.Currency, this.Status, this.CreatedDate);

			 return this.AccountID != -1;
		 }

		private bool _UpdateAccounts() { 

 			 return DataAccess_Layer.clsAccounts.UpdateAccounts(this.AccountID, this.CustomerID, this.AccountTypeID, this.Balance, this.AccountNumber, this.Currency, this.Status, this.CreatedDate);
		 }

		private bool _DeleteAccounts() { 

 			 return DataAccess_Layer.clsAccounts.DeleteAccounts(this.AccountID);
		 }

		public static clsAccounts Find(int AccountID) { 

 		int CustomerID = -1;
		int AccountTypeID = -1;
		decimal Balance = -1;
		string AccountNumber = "";
		string Currency = "";
		int Status = -1;

		DateTime CreatedDate = new DateTime();
		CreatedDate = DateTime.MaxValue;


		 if (DataAccess_Layer.clsAccounts.Find(AccountID,  ref CustomerID,  ref AccountTypeID,  ref Balance,  ref AccountNumber,  ref Currency,  ref Status,  ref CreatedDate)) { 

 		 return new clsAccounts(AccountID, CustomerID, AccountTypeID, Balance, AccountNumber, Currency, Status, CreatedDate);
		 } else 
		{ 
		return null;
}
		 }

		public bool Save() { 

 		 switch(Mode) { 
			 case enMode.Update:
			 return _UpdateAccounts();

			 case enMode.AddNew: 

				 if (_AddNewAccounts()) { 
					Mode = enMode.Update;
					return true;

			} else { 
 					 return false; } 
					default: return false;

 } 
		}

		public static bool DoesAccountsExists(int AccountID) {
			return DataAccess_Layer.clsAccounts.DoesAccountsExists(AccountID);
		 }

		public  bool DoesAccountsExists() {
			return DoesAccountsExists(this.AccountID);
		 }

	public static DataTable GetAllAccounts() {
		 return DataAccess_Layer.clsAccounts.GetAllAccounts();
	}


}
}
