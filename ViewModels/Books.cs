using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class Books
    {
        public ObservableCollection<Book> AppBooks { get; set; } = new ObservableCollection<Book>()
        {
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book(),
            new Book()
        };
    }
}
