namespace VincenteWilliamsA7.Model
{
    /// <summary>
    /// This is the car comparer class that compares two car objects.
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IComparer&lt;VincenteWilliamsA7.Model.Car&gt;" />
    public class CarComparer : IComparer<Car>
    {
        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        /// <returns>
        /// A signed integer that indicates the relative values of <paramref name="x" /> and <paramref name="y" />, as shown in the following table.
        /// <list type="table"><listheader><term> Value</term><description> Meaning</description></listheader><item><term> Less than zero</term><description><paramref name="x" /> is less than <paramref name="y" />.</description></item><item><term> Zero</term><description><paramref name="x" /> equals <paramref name="y" />.</description></item><item><term> Greater than zero</term><description><paramref name="x" /> is greater than <paramref name="y" />.</description></item></list>
        /// </returns>
        public int Compare(Car x, Car y)
        {
            int makeComparison = x.Make.CompareTo(y.Make);
            if (makeComparison == 0)
            {
                return x.Price.CompareTo(y.Price);
            }
            return makeComparison;
        }
    }
}
