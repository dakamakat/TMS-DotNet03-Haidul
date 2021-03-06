﻿using System.Collections.Generic;
using EventMaker.Common.Interfaces;

namespace EventMaker.DAL.Entities
{
    /// <summary>
    /// Tag.
    /// </summary>
    public class Tag : IHasDbIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Navigation to event tags.
        /// </summary>
        public ICollection<EventTag> EventTags { get; set; }
    }
}
