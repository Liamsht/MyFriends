using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MODEL
{
    public class Friend
    {
        private int id;
        private string family;
        private string name;
        private DateTime birthdate;
        private string phone;
        private string email;
        private string password;
        private string picture;

        public int Id { get => id; set => id = value; }
        public string Family { get => family; set => family = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Picture { get => picture; set => picture = value; }


        public Friend() { }

        public override bool Equals(object obj)
        {
            return obj is Friend friend &&
                   id == friend.id &&
                   family == friend.family &&
                   name == friend.name &&
                   birthdate == friend.birthdate &&
                   phone == friend.phone &&
                   email == friend.email &&
                   password == friend.password &&
                   picture == friend.picture;
        }

        public static bool operator ==(Friend left, Friend right)
        {
            return EqualityComparer<Friend>.Default.Equals(left, right);
        }

        public static bool operator !=(Friend left, Friend right)
        {
            return !(left == right);
        }

        public int Age
        {
            get { return DateTime.Now.Year - birthdate.Year; }
        }

        public string FullName
        {
            get { return name + ' ' + family; }
        }
    }
}