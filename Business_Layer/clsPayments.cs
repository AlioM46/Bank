using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer { 
 public class clsPayments 
{ 



		public enum enMode {AddNew = 1, Update=2};
		public enMode Mode {get;set;}

		public int PaymentID {get; set;}
		public int ApplicationID {get; set;}
		public int TransactionID {get; set;}
		public decimal Amount {get; set;}
		public string Description {get; set;}
		public DateTime CreatedDate {get; set;}

		// Composition of Applications
		public clsApplications Applications ; 

		// Composition of Transactions
		public clsTransactions Transactions ; 



		public clsPayments(int PaymentID, int ApplicationID, int TransactionID, decimal Amount, string Description, DateTime CreatedDate) {
 
			this.PaymentID = PaymentID;
			this.ApplicationID = ApplicationID;

			Applications = clsApplications.Find(ApplicationID);

			this.TransactionID = TransactionID;

			Transactions = clsTransactions.Find(TransactionID);

			this.Amount = Amount;
			this.Description = Description;
			this.CreatedDate = CreatedDate;
			Mode= enMode.Update;

		}

		public clsPayments() {
 
			this.PaymentID = -1;
			this.ApplicationID = -1;
			this.TransactionID = -1;
			this.Amount = -1;
			this.Description = "";
			this.CreatedDate = DateTime.MaxValue;
			Mode= enMode.AddNew;

		}

		private bool _AddNewPayments() { 

  			this.PaymentID = DataAccess_Layer.clsPayments.AddNewPayments(this.ApplicationID, this.TransactionID, this.Amount, this.Description, this.CreatedDate);

			 return this.PaymentID != -1;
		 }

		private bool _UpdatePayments() { 

 			 return DataAccess_Layer.clsPayments.UpdatePayments(this.PaymentID, this.ApplicationID, this.TransactionID, this.Amount, this.Description, this.CreatedDate);
		 }

		private bool _DeletePayments() { 

 			 return DataAccess_Layer.clsPayments.DeletePayments(this.PaymentID);
		 }

		public static clsPayments Find(int PaymentID) { 

 		int ApplicationID = -1;
		int TransactionID = -1;
		decimal Amount = -1;
		string Description = "";

		DateTime CreatedDate = new DateTime();
		CreatedDate = DateTime.MaxValue;


		 if (DataAccess_Layer.clsPayments.Find(PaymentID,  ref ApplicationID,  ref TransactionID,  ref Amount,  ref Description,  ref CreatedDate)) { 

 		 return new clsPayments(PaymentID, ApplicationID, TransactionID, Amount, Description, CreatedDate);
		 } else 
		{ 
		return null;
}
		 }

		public bool Save() { 

 		 switch(Mode) { 
			 case enMode.Update:
			 return _UpdatePayments();

			 case enMode.AddNew: 

				 if (_AddNewPayments()) { 
					Mode = enMode.Update;
					return true;

			} else { 
 					 return false; } 
					default: return false;

 } 
		}

		public static bool DoesPaymentsExists(int PaymentID) {
			return DataAccess_Layer.clsPayments.DoesPaymentsExists(PaymentID);
		 }

		public  bool DoesPaymentsExists() {
			return DoesPaymentsExists(this.PaymentID);
		 }

	public static DataTable GetAllPayments() {
		 return DataAccess_Layer.clsPayments.GetAllPayments();
	}


}
}
