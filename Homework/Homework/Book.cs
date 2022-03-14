using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Book:Product
    {
        public Book(int no,string name,double price,string genre):base(no,name,price)
        {
            this.Genre = genre; 
        }
        public string Genre;

        public string GetInfo()
        {
            return $"No: {this.No} -  Name: {this.Name} - Genre: {this.Genre}  - Price: {this.Price}";
        }
    }
}
