using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandlingError;

public class FileReader
{
    public void ReadFile(string filePath)
    {

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                var contents = reader.ReadToEnd();

                if (contents.Length == 0) throw new FileEmptyException();

                Console.WriteLine(contents);
            }
        }
        catch (FileNotFoundException fnf)
        {
            Console.WriteLine("File does not exist error : {0}", fnf.Message);
        }
        catch (ArgumentNullException argNull)
        {
            Console.WriteLine("Argument is missing {0}", argNull.Message);
        }
        catch (FileEmptyException)
        {
            throw;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("finally block");
        }

        // only runs if no exception is thrown
        Console.WriteLine("test line");

    }
}
