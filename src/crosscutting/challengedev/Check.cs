using System.Linq;

namespace WappaMobile.ChallengeDev
{
    public static class Check
    {
        /// <summary>
        /// Make sure all characters are numeric
        /// </summary>
        /// <param name="value">String to test</param>
        /// <returns>true if all characters are numeric</returns>
        public static bool IsNumeric(object value) => value.ToString().All(x => "0123456789".Contains(x));

        /// <summary>
        /// Make sure all characters are letter
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool IsLetter(object values) => values.ToString().ToLower().ToCharArray().All(x => "abcdefghijklmnopqrstuvwxyz ".Contains(x));
    }
}
