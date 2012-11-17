using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Azure.Zumo.WindowsPhone7.CSharp.Test
{
    internal partial class Enumerable
    {
        public static IEnumerable<TResult> Zip<TFirst, TSecond, TResult>(
                                               IEnumerable<TFirst> first,
                                               IEnumerable<TSecond> second,
                                               Func<TFirst, TSecond, TResult> resultSelector)
        {
            using (var firstEnum = first.GetEnumerator())
            using (var secondEnum = second.GetEnumerator())
            {
                while (firstEnum.MoveNext() && secondEnum.MoveNext())
                {
                    yield return resultSelector(firstEnum.Current, secondEnum.Current);
                }
            }
        }
    }

}
