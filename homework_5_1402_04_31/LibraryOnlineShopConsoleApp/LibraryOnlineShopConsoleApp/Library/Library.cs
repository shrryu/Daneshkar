namespace LibraryOnlineShopConsoleApp.Library
{
    internal class Library
    {
        public List<Book> Books { get; set; }
        public List<Person> Members { get; set; }
        /// <summary>
        /// first element is book ISBN & second one is a members ID.
        /// </summary>
        public Dictionary<int, int> BorrowedBooks { get; set; }
        //TODO: maybe write a struct instead; with ISBN, ID, date of borrow & supposed return date.
        public int NumberOfShelfs { get; set; }
        public int ShelfCapacity { get; set; }
        public Library()
        {
            NumberOfShelfs = 100;
            ShelfCapacity = 10;
            Books.Capacity = ShelfCapacity * NumberOfShelfs;
        }
        /// <summary>
        /// Add multiple books to a library.
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(List<Book> books)
        {
            foreach(Book book in books)
            {
                AddBook(book);
            }
        }
        /// <summary>
        /// Add a single book to library.
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            if(!Books.Contains(book))
            {
                Books.Add(book);
            }
        }
        /// <summary>
        /// return the list of books.
        /// </summary>
        public void ShowBooks()
        {
            // book name, ISBN, writer, publisher, status
            foreach(Book book in Books)
            {
                bool borrowStatus = BorrowedBooks.Keys.Contains(book.ISBN);
                string logString = $"Book title: {book.Title}\t ";
                logString += $"Written by: {book.Writer}\t ";
                logString += $"Published by: {book.Publisher}\t ";
                logString += $"ISBN: {book.ISBN}\t ";
                logString += $"is borrowed: {borrowStatus}\t ";
                Console.WriteLine(logString);
            }
        }
        /// <summary>
        /// This method returns index of the book you are looking for. if not found, returns -1
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public int FindBook(in Book book)
        {
            return Books.IndexOf(book);
        }
        /// <summary>
        /// register a new person to our library if that person is not registered already.
        /// </summary>
        /// <param name="newPerson"></param>
        public void RegisterNewMemeber(Person newPerson)
        {
            if(Members.Contains(newPerson))
                Members.Add(newPerson);
        }
        /// <summary>
        /// Person borrows a certain book if it's not already borrowed by someone else.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="requestedBook"></param>
        public void Borrow(Person member, Book requestedBook)
        {
            if(!BorrowedBooks.ContainsKey(requestedBook.ISBN))
                BorrowedBooks.Add(requestedBook.ISBN, member.ID);
        }
        /// <summary>
        /// member brings back the book he/she borrowed. we check if the same person who borrowed the book now brought it back.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="book"></param>
        public void ReturnBook(Person member, Book book)
        {
            var matchPersonToBook = new KeyValuePair<int, int>(book.ISBN, member.ID);
            if(BorrowedBooks.Contains(matchPersonToBook))
                BorrowedBooks.Remove(book.ISBN);
        }
    }
}
