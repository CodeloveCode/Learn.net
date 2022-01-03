using System;

namespace key_spirit.utils
{
    public class RandomUtils
    {
        /**
         * 获取指定范围的一个随机数.
         *
         * @param start
         * @param end
         */
        public static long LongBetweenRange(long start, long end)
        {
            Random random = new Random();
            var d = random.NextDouble();
            return Convert.ToInt64(Math.Round((end - start) * d + start));
        }

        /**
         * 获取指定范围的一个随机数.
         *
         * @param start
         * @param end
         */
        public static int IntBetweenRange(int start, int end)
        {
            Random random = new Random();
            var d = random.NextDouble();
            return Convert.ToInt32(Math.Round((end - start) * d + start));
        }
    }

}
