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
    public class Friends : List<Friend>
    {
        public Friends()
        {
            Add(new Friend()
            {
                Family = "Pindiurin",
                Name = "Katya",
                Birthdate = new DateTime(2006, 4, 18),
                Email = "kp8341@pb.amalnet.k12.il",
                Phone = "050-3036883",
                Picture = ""
            });

            Add(new Friend()
            {
                Family = "Shvarts",
                Name = "Liam",
                Birthdate = new DateTime(2006, 1, 12),
                Email = "ls0011@pb.amalnet.k12.il",
                Phone = "054-9927210",
                Picture = ""
            });

            Add(new Friend()
            {
                Family = "Ehel",
                Name = "Ziv",
                Birthdate = new DateTime(1990, 8, 1),
                Email = "Ehel.Ziv@gmail.com",
                Phone = "050-7485328",
                Picture = ""
            });
        }

        public new void Sort()
        {
            base.Sort((item1, item2) =>
            {
                int compare = item1.Family.CompareTo(item2.Family);
                return (compare != 0) ? compare :
                item1.Name.CompareTo(item2.Name);
            });
        }

        public bool Exists(Friend f)
        {
            return Find(item => item.Phone == f.Phone) != null;
        }

    }
}