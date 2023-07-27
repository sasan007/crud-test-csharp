namespace Mc2.CrudTest.Presentation.Server.Domain.Customer
{
    public class Customer
    {
        public int Id { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public string BankAccountNumber { get; private set; }

        private Customer()
        {
        }

        public static Customer Create(string firstname, string lastname, DateTime dateOfBirth,
                                      string phoneNumber, string email, string bankAccountNumber)
        {
            var customer = new Customer();
            customer.ChangeFirstname(firstname);
            customer.ChangeLastname(lastname);
            customer.ChangeDateOfBirth(dateOfBirth);
            customer.ChangePhoneNumber(phoneNumber);
            customer.ChangeEmail(email);
            customer.ChangeBankAccountNumber(bankAccountNumber);

            return customer;
        }

        public void ChangeFirstname(string firstname)
        {
            if (string.IsNullOrWhiteSpace(firstname))
                throw new ArgumentException("Firstname cannot be empty.", nameof(firstname));

            Firstname = firstname;
        }

        public void ChangeLastname(string lastname)
        {
            if (string.IsNullOrWhiteSpace(lastname))
                throw new ArgumentException("Lastname cannot be empty.", nameof(lastname));

            Lastname = lastname;
        }

        public void ChangeDateOfBirth(DateTime dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public void ChangePhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public void ChangeEmail(string email)
        {
            if (!IsValidEmail(email))
                throw new ArgumentException("Invalid email format.", nameof(email));

            Email = email;
        }

        public void ChangeBankAccountNumber(string bankAccountNumber)
        {
            BankAccountNumber = bankAccountNumber;
        }

        private static bool IsValidEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && email.Contains("@");
        }
    }
}
