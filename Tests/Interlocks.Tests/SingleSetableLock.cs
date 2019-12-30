// -----------------------------------------------------------------------
// <copyright file="SingleSetable.cs" company="Anori Soft">
// Copyright (c) Anori Soft. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Bfa.Common.Interlocks
{
    using System.Threading;

    /// <summary>
    ///     Single Set Class
    ///     The class enables thread safe checking if an object.
    /// </summary>
    public class SingleSetableLock
    {
        /// <summary>
        ///     The value.
        /// </summary>
        private bool value;

        /// <summary>
        ///     Gets a value indicating whether this <see cref="SingleSetableLock" /> is value.
        ///     Provides (non-thread-safe) access to the backing value.
        /// </summary>
        /// <value>
        ///     <c>true</c> if value; otherwise, <c>false</c>.
        /// </value>
        public bool Value => this.value;

        /// <summary>
        ///     Sets the specified set to value.
        /// </summary>
        /// <returns>
        ///     If the value is already set, it returns True.
        ///     If the value is not set, it returns False.
        /// </returns>
        public bool Set()
        {
            lock (this.locker)
            {
                if (value)
                {
                    return true;
                }

                value = true;
                return false;
            }
        }

        private readonly object locker = new object();
    }
}