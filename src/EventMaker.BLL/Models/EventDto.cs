﻿using System;
using EventMaker.Common.Enums;

namespace EventMaker.BLL.Models
{
    /// <summary>
    /// Event data transfer object.
    /// </summary>
    public class EventDto
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string UserId { get; set; }

        /// <summary>
        /// Author.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Title
        /// </summary>
#nullable enable
        public string? Title { get; set; }

        /// <summary>
        /// Info.
        /// </summary>
        public string? Info { get; set; }

        /// <summary>
        /// Comment.
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// Day of creation
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Start of the event.
        /// </summary>
        public DateTime Started { get; set; }

        /// <summary>
        /// End of the event.
        /// </summary>
        public DateTime? Closed { get; set; }

        /// <summary>
        /// Format.
        /// </summary>
        public EventFormats? Format { get; set; }

        /// <summary>
        /// Participants number
        /// </summary>
        public int? PNumber { get; set; }

        /// <summary>
        /// Remaining free seats of participants.
        /// </summary>
        public int? PFreeNumber { get; set; }
    }
}
