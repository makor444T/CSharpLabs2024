using System;

namespace Pr3
{
    class Title
    {
        public string Name { get; private set; }

        public Title(string name)
        {
            Name = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: " + Name);
            Console.ResetColor();
        }
    }

    class Author
    {
        public string Name { get; set; }

        public Author(string name)
        {
            Name = name;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Author: " + Name);
            Console.ResetColor();
        }
    }

    class Content
    {
        public string Text { get; set; }

        public Content(string text)
        {
            Text = text;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Content: " + Text);
            Console.ResetColor();
        }
    }

    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(string title, string author, string content)
        {
            this.title = new Title(title);
            this.author = new Author(author);
            this.content = new Content(content);
        }

        public string Title
        {
            get { return title.Name; }
        }

        public string Author
        {
            get { return author.Name; }
            set { author.Name = value; }
        }

        public string Content
        {
            get { return content.Text; }
            set { content.Text = value; }
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }

    class Program
    {
        static void Main()
        {
            Book myBook = new("The Great Gatsby", "F. Scott Fitzgerald", "A novel about the American dream.");

            myBook.Show();
            myBook.Author = "Francis Scott Fitzgerald";
            myBook.Content = "A story about the mysterious Jay Gatsby and his unrequited love for Daisy Buchanan.";

            myBook.Show();
        }
    }
}