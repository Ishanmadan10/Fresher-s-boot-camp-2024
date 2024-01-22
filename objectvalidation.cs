using System;
using System.Collections.Generic;

namespace Validation
{
    class Device
    {
        public string Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
    }

    class ObjectValidator
    {
        public static bool Validate(Device device, out List<string> errors)
        {
            errors = new List<string>();

            if (string.IsNullOrEmpty(device.Id))
            {
                errors.Add("ID Property Requires Value");
            }

            if (device.Code < 10 || device.Code > 100)
            {
                errors.Add("Code Value Must Be Within 10-100");
            }

            if (device.Description?.Length > 100)
            {
                errors.Add("Max of 100 Characters are allowed for Description");
            }

            return errors.Count == 0;
        }
    }

    class Program
    {
        static void Main()
        {
            Device deviceObj = new Device();
            Console.WriteLine("Enter Id");
            deviceObj.Id = Console.ReadLine();
            Console.WriteLine("Enter Code");
            if(int.TryParse(Console.ReadLine(), out int codeInput))
            {
                deviceObj.Code = codeInput;
            }
            else
            {
                Console.WriteLine("invalid input");
                return;
            }
            Console.WriteLine("Enter Description");
            deviceObj.Description = Console.ReadLine();
            List<string> errors;

            bool isValid = ObjectValidator.Validate(deviceObj, out errors);

            if (!isValid)
            {
                foreach (string item in errors)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Validation successfull");
            }
        }
    }
}
