using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarAppAdam.Entities
{
    public class Member : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Email { get; set; }
        public decimal Wallet { get; set; } = 0;
        public bool IsOwner { get; set; } = false;

        public Member (string firstName, string lastName, string address, string eMail, bool isOwner)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = eMail;
            IsOwner = isOwner;
        }


        public override string ToString()           //This method is used to store a member in the Order Table.
        {                                           //MemberID is also included in order to link more accurate.
            return $"{FirstName} {LastName}";
        }

    }
}
