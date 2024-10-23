using System;
using DataAccess_Layer;
using System.Data;

namespace Business_Layer { 
 public class clsLoanTypes 
{ 



		public enum enMode {AddNew = 1, Update=2};
		public enMode Mode {get;set;}

		public int LoanTypeID {get; set;}
		public decimal MinimumBalance {get; set;}
		public string LoanType {get; set;}
		public int MaxMonthsDuration {get; set;}
		public decimal MinAmount {get; set;}
		public decimal MaxAmount {get; set;}



		public clsLoanTypes(int LoanTypeID, decimal MinimumBalance, string LoanType, int MaxMonthsDuration, decimal MinAmount, decimal MaxAmount) {
 
			this.LoanTypeID = LoanTypeID;
			this.MinimumBalance = MinimumBalance;
			this.LoanType = LoanType;
			this.MaxMonthsDuration = MaxMonthsDuration;
			this.MinAmount = MinAmount;
			this.MaxAmount = MaxAmount;
			Mode= enMode.Update;

		}

		public clsLoanTypes() {
 
			this.LoanTypeID = -1;
			this.MinimumBalance = -1;
			this.LoanType = "";
			this.MaxMonthsDuration = -1;
			this.MinAmount = -1;
			this.MaxAmount = -1;
			Mode= enMode.AddNew;

		}

		private bool _AddNewLoanTypes() { 

  			this.LoanTypeID = DataAccess_Layer.clsLoanTypes.AddNewLoanTypes(this.MinimumBalance, this.LoanType, this.MaxMonthsDuration, this.MinAmount, this.MaxAmount);

			 return this.LoanTypeID != -1;
		 }

		private bool _UpdateLoanTypes() { 

 			 return DataAccess_Layer.clsLoanTypes.UpdateLoanTypes(this.LoanTypeID, this.MinimumBalance, this.LoanType, this.MaxMonthsDuration, this.MinAmount, this.MaxAmount);
		 }

		private bool _DeleteLoanTypes() { 

 			 return DataAccess_Layer.clsLoanTypes.DeleteLoanTypes(this.LoanTypeID);
		 }

		public static clsLoanTypes Find(int LoanTypeID) { 

 		decimal MinimumBalance = -1;
		string LoanType = "";
		int MaxMonthsDuration = -1;
		decimal MinAmount = -1;
		decimal MaxAmount = -1;

		 if (DataAccess_Layer.clsLoanTypes.Find(LoanTypeID,  ref MinimumBalance,  ref LoanType,  ref MaxMonthsDuration,  ref MinAmount,  ref MaxAmount)) { 

 		 return new clsLoanTypes(LoanTypeID, MinimumBalance, LoanType, MaxMonthsDuration, MinAmount, MaxAmount);
		 } else 
		{ 
		return null;
}
		 }

		public bool Save() { 

 		 switch(Mode) { 
			 case enMode.Update:
			 return _UpdateLoanTypes();

			 case enMode.AddNew: 

				 if (_AddNewLoanTypes()) { 
					Mode = enMode.Update;
					return true;

			} else { 
 					 return false; } 
					default: return false;

 } 
		}

		public static bool DoesLoanTypesExists(int LoanTypeID) {
			return DataAccess_Layer.clsLoanTypes.DoesLoanTypesExists(LoanTypeID);
		 }

		public  bool DoesLoanTypesExists() {
			return DoesLoanTypesExists(this.LoanTypeID);
		 }

	public static DataTable GetAllLoanTypes() {
		 return DataAccess_Layer.clsLoanTypes.GetAllLoanTypes();
	}


}
}
