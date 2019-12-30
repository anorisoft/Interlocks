// -----------------------------------------------------------------------
// <copyright file="SingleSetable.cs" company="Anori Soft">
// Copyright (c) Anori Soft. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Interlocks
{
    using System.Threading;

    /// <summary>
    ///     Single Set Class
    ///     The class enables thread safe checking if an object.
    /// </summary>
    public class SingleSetable
    {
        /// <summary>
        ///     The value.
        /// </summary>
        private int value;

        /// <summary>
        ///     Gets a value indicating whether this <see cref="SingleSetable" /> is value.
        ///     Provides (non-thread-safe) access to the backing value.
        /// </summary>
        /// <value>
        ///     <c>true</c> if value; otherwise, <c>false</c>.
        /// </value>
        public bool Value => this.value > 0;

        /// <summary>
        ///     Sets the specified set to value.
        /// </summary>
        /// <returns>
        ///     If the value is already set, it returns True.
        ///     If the value is not set, it returns False.
        /// </returns>
        public bool Set() => Interlocked.CompareExchange(ref this.value, 1, 0) > 0;
    }
}