using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Book

    {
        string name;
        string writer;
        string page;
        public Book(string name, string writer, string page)

        {
            this.name = name;
            this.writer = writer;
            this.page = page;
            Console.WriteLine($"name: {this.name},writer : {writer}, page: {page}");
        }
    }
}


