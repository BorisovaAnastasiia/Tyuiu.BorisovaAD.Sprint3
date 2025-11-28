using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BorisovaAD.Sprint3.Task3.V29.Lib
{
    public class DataService : ISprint3Task3V29
    {
        public string DeleteCharInString(string value, char item)
        {
            string result = value;
            foreach (char ch in value)
            {
                if (ch == item)
                {
                    // Замена всех вхождений символа 'h' на пустую строку
                    result = result.Replace(item.ToString(), "");
                }
            }
            return result;
        }
    }
}
