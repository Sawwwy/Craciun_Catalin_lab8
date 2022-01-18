public IndexModel(Nume_Pren_Lab8.Data.Nume_Pren_Lab8Context context)
{
    _context = context;
}
public IList<Book> Book { get; set; }
public BookData BookD { get; set; }
public int BookID { get; set; }
public int CategoryID { get; set; }
public async Task OnGetAsync(int? id, int? categoryID)
{
    BookD = new BookData();

    BookD.Books = await _context.Book
    .Include(b => b.Publisher)
    .Include(b => b.BookCategories)
    .ThenInclude(b => b.Category)
    .AsNoTracking()
    .OrderBy(b => b.Title)
    .ToListAsync();
    if (id != null)
    {
        BookID = id.Value;
        Book book = BookD.Books
        .Where(i => i.ID == id.Value).Single();
        BookD.Categories = book.BookCategories.Select(s => s.Category);
    }
}
 }