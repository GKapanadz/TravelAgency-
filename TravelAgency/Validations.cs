
using System.Text.RegularExpressions;
using TravelAgencyAPP;

namespace TravelAgencyAPP
{
    static class Validations
    {

        public static bool ValidateName(string name, Form parentForm, Control controlToFocus = null)
        {
            name = name.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                FormHelper.ShowWarning(parentForm, "Please enter the name:");
                controlToFocus?.Focus();
                return false;
            }

            if (name.Length < 2 || name.Length > 50)
            {
                FormHelper.ShowWarning(parentForm, "Name must be between 2-50 letters:");
                controlToFocus?.Focus();
                return false;
            }

            string pattern = @"^[a-zA-Zა-ჰ\s]+$";
            if (!Regex.IsMatch(name, pattern))
            {
                FormHelper.ShowWarning(parentForm, "Name must include only letters.");
                controlToFocus?.Focus();
                return false;
            }

            return true;
        }

        public static bool ValidateDates(DateTime startDate, DateTime endDate, Form parentForm)
        {
            if (startDate > endDate)
            {
                FormHelper.ShowWarning(parentForm, "Start Date can't be after End Date.");
                return false;
            }

            if (startDate == endDate)
            {
                FormHelper.ShowWarning(parentForm, "Start Date and End Date can't be the same.");
                return false;
            }

            return true;
        }

        public static bool ValidateTotalPrice(string input, Form form, out double totalPrice)
        {
            totalPrice = 0;

            if (!double.TryParse(input.Trim(), out totalPrice) || totalPrice < 0)
            {
                FormHelper.ShowWarning(form, "Total price must be a valid non-negative integer.");
                return false;
            }

            return true;
        }

        public static bool ValidatePassword(string password, Form form)
        {
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");

            if (!regex.IsMatch(password))
            {
                FormHelper.ShowWarning(form, "Password must be at least 8 characters and include uppercase, lowercase, number, and symbol.");
                return false;
            }

            return true;
        }
    }
}
