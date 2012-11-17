// ----------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// ----------------------------------------------------------------------------

using System;
//using Windows.Foundation.Collections;

namespace Microsoft.WindowsAzure.MobileServices
{

    /// <summary>
    ///     Describes the action that causes a change to a collection.
    ///     Port over from Windows.Foundation.Collections
    /// </summary>
    public enum CollectionChange
    {
        // Summary:
        //     The collection is changed.
        Reset = 0,
        //
        // Summary:
        //     An item is added to the collection.
        ItemInserted = 1,
        //
        // Summary:
        //     An item is removed from the collection.
        ItemRemoved = 2,
        //
        // Summary:
        //     An item is changed in the collection.
        ItemChanged = 3,
    }

    /// <summary>
    ///     Provides data for the changed event of a vector.
    ///     Port over from Windows.Foundation.Collections
    /// </summary>
    public interface IVectorChangedEventArgs
    {
        // Summary:
        //     Gets the type of change that occurred in the vector.
        //
        // Returns:
        //     The type of change in the vector.
        CollectionChange CollectionChange { get; }
        //
        // Summary:
        //     Gets the position where the change occurred in the vector.
        //
        // Returns:
        //     The zero-based position where the change occurred in the vector, if applicable.
        uint Index { get; }
    }

    /// <summary>
    /// Provides information about changes to an observable vector.
    /// </summary>
    internal class VectorChangedEventArgs : IVectorChangedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the VectorChangedEventArgs class.
        /// </summary>
        /// <param name="change">The change to the vector.</param>
        /// <param name="index">Index of the changed element.</param>
        public VectorChangedEventArgs(CollectionChange change, uint index)
        {
            this.CollectionChange = change;
            this.Index = index;
        }

        /// <summary>
        /// Gets the change to the vector.
        /// </summary>
        public CollectionChange CollectionChange { get; private set; }

        /// <summary>
        /// Gets the index of the changed element.
        /// </summary>
        public uint Index { get; private set; }
    }
}
