//теперь тут всё закоментить нужно, ибо я гляну, в ахуе буду
using System.ComponentModel;// для использования TypeDescriptor
using System;
namespace Sem8
{
    public static class Checker
    {
        public static T CheckInput<T>(Predicate<T> Validation, string InputMessage, string errorMessage)
        where T : struct
        {
            bool Parse(string input, out T value)
            {
                value = default(T);
                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        // Cast ConvertFromString(string text) : object to (T)
                        value = (T)converter.ConvertFromString(input);
                        return true;
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }
            T Input;
            do
            {
               // Console.Clear();
                Console.WriteLine(InputMessage);
                if (Parse(Console.ReadLine(), out Input))//пытается проверить на число или нет
                {
                    if (Validation(Input))
                    {
                        Console.WriteLine(errorMessage);
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Алёрт, была введена не цифра!");
                }
                Console.ReadLine();
            } while (true);
            return Input;
        }
    }
}