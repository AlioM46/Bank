using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Presentation_Layer.CustomControls
{
    public partial class ctrlTextBoxValidation : TextBox
    {
        public ctrlTextBoxValidation()
        {
            InitializeComponent();

            MinCharLength = 8;
            Pattern = enPattern.Password;
        }


        public string ErrorMessage { get; private set; }
        public int MinCharLength { get; set; }
        public string RegExp { get;  set; } 

        public enum enPattern
        {
            Password = 1,
            Username = 2,
        }

        private enPattern _pattern;
        public enPattern Pattern
        {
            get { return _pattern; }
            set
            {
                _pattern = value;

                switch (value)
                {
                    
                    case enPattern.Password:
                        RegExp = $"^[a-zA-Z0-9]{{{MinCharLength},}}$";
                        ErrorMessage = $"Only Characters Is Available With Min Length {MinCharLength}";
                        break;
                    case enPattern.Username:
                        RegExp = "^[a-zA-Z0-9]{3,16}$";
                        ErrorMessage = $"Only Characters And Number Is Available, Min Length is 3";
                        break;
                    default:
                        throw new InvalidEnumArgumentException();
                }
            }
        }

        public bool IsValid()
        {
            if (!Regex.IsMatch(Text, RegExp))
            {
                return false;
            }
            return true;
        }
    }
}
