namespace Library
{
    using System;

    public class Comment
    {
        private string Author { get; private set; }
        private DateTime PublishingDate { get; private set; }
        private string Text { get; private set; }

        public Comment(string author, string text)
        {
            this.Author = author;
            this.Text = text;
            this.PublishingDate = DateTime.Now;
        }
    }
}
