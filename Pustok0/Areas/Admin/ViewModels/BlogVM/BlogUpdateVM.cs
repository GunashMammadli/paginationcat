﻿namespace Pustok0.Areas.Admin.ViewModels.BlogVM
{
    public class BlogUpdateVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<int>? TagId { get; set; }
        public IEnumerable<int>? AuthorId { get; set; }
    }
}
