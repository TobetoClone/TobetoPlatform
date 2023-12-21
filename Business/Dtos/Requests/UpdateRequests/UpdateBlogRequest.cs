﻿namespace Business.Dtos.Requests.UpdateRequests
{
    public class UpdateBlogRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ThumbnailPath { get; set; }
    }
}