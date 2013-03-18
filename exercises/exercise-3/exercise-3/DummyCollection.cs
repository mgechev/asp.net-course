using System;
using System.Collections.Generic;

namespace exercise_3
{
    /// <summary>
    /// Very basic implementation of the IEnumerable generic interface.
    /// </summary>
    public class DummyCollection<T>: IEnumerable<T> where T: IComparable
    {
        private List<T> data;

        /// <summary>
        /// Initializes a new instance of the <see cref="DummyCollection{T}"/> class.
        /// </summary>
        public DummyCollection()
        {
            this.data = new List<T>();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new DummyEnumerator<T>(this);
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns></returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public int Size
        {
            get
            {
                return this.data.Count;
            }
        }

        /// <summary>
        /// Gets item at specified index.
        /// </summary>
        /// <param name="idx">The index.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException"></exception>
        public T GetItemAt(int idx)
        {
            if (idx >= this.Size || idx < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return this.data[idx];
        }

        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="item">The item.</param>
        public void AddItem(T item)
        {
            this.data.Add(item);
        }

        /// <summary>
        /// Sorts this instance.
        /// </summary>
        public void Sort()
        {
            this.data.Sort();
        }

        #region Implementation of the iterator

        /// <summary>
        /// Implementation of the iterator.
        /// 
        /// Sample tasks:
        ///     1. Change the way the DummyIterator iterates through the collection.
        ///     2. Implement binary search tree with suitable iterator.
        /// </summary>
        /// <typeparam name="U"></typeparam>
        public class DummyEnumerator<U> : IDisposable, IEnumerator<U> where U : IComparable
        {
            private DummyCollection<U> collection;
            private int current;

            /// <summary>
            /// Initializes a new instance of the <see cref="DummyEnumerator`1"/> class.
            /// </summary>
            /// <param name="collection">The collection.</param>
            public DummyEnumerator(DummyCollection<U> collection)
            {
                this.collection = collection;
                this.current = -1;
            }

            /// <summary>
            /// Gets the element in the collection at the current position of the enumerator.
            /// </summary>
            /// <returns>
            /// The element in the collection at the current position of the enumerator.
            ///   </returns>
            public U Current
            {
                get
                {
                    return this.collection.GetItemAt(this.current);
                }
            }

            /// <summary>
            /// Gets the element in the collection at the current position of the enumerator.
            /// </summary>
            /// <returns>
            /// The element in the collection at the current position of the enumerator.
            ///   </returns>
            object System.Collections.IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            /// <summary>
            /// Sets the enumerator to its initial position, which is before the first element in the collection.
            /// </summary>
            public void Reset()
            {
                this.current = -1;
            }

            /// <summary>
            /// Advances the enumerator to the next element of the collection.
            /// </summary>
            /// <returns>
            /// true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.
            /// </returns>
            public bool MoveNext()
            {
                this.current += 1;
                if (this.current < this.collection.Size)
                {
                    return true;
                }
                return false;
            }

            /// <summary>
            /// Advances the enumerator to the next element of the collection.
            /// </summary>
            /// <returns>
            /// true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.
            /// </returns>
            bool System.Collections.IEnumerator.MoveNext()
            {
                return this.MoveNext();
            }

            /// <summary>
            /// Sets the enumerator to its initial position, which is before the first element in the collection.
            /// </summary>
            void System.Collections.IEnumerator.Reset()
            {
                this.Reset();
            }

            /// <summary>
            /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
            /// </summary>
            public void Dispose()
            {
                this.collection = null;
            }
        }

        #endregion

    }
}
