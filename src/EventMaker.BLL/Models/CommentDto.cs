﻿namespace EventMaker.BLL.Models
{
    public class CommentDto
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public int EventId { get; set; }

        /// <summary>
        /// Author.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Message text.
        /// </summary>
        public string MessageText { get; set; }
    }
}
