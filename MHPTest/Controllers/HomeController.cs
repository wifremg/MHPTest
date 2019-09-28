using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using MHPTest.Models;


namespace MHPTest.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()                               // Get Action (For the first time)
        {
            FormClass model = new FormClass();
            return View(model);
        }

        //---------------------------------------
        public String Operations ( 
            ref String temp, 
            ref Stack Numbers, 
            ref Boolean insert,
            String symbol)
        {
            Double one = 0;                                       // First element of the operation
            Double two = 0;                                       // Second element of the operation
            Double total = 0;                                     // Total. Element to store

            temp = "";
            insert = false;
            two = (double)Numbers.Pop();                          // Reading from the stack

            if (symbol == "S")
            {
                total = Math.Sqrt(two);
                Numbers.Push(total);                             // Saving the total result
                return two.ToString("0.00") + " SQRT = " +
                       total.ToString("0.00");
            }
            else
            {
                one = (double)Numbers.Pop();                     // Reading from the stack

                if (symbol == "+") { total = one + two; }        // Operations
                if (symbol == "-") { total = one - two; }
                if (symbol == "*") { total = one * two; }
                if (symbol == "/") { total = one / two; }

                Numbers.Push(total);                              // Saving the total result 
                return one.ToString("0.00") + " " +               // Creating the string that will be displayed
                   symbol + " " +
                   two.ToString("0.00") + " = " +
                   total.ToString("0.00");

            }
        }

        //------------------------------------------
        [HttpPost]
        public ActionResult Index(FormClass model)                // Post Action
        {
            Boolean error = false;
            if ((model is null) || (model.Operation is null))     // Validating that the data is not empty
            {
                model.Error_Message = "Unvalid entry";
                error = true;
            }
            if (!error)
            {
                Stack Numbers = new Stack();                      // Stores the data I read from the chain in a stack
                String temp = "";                                 // Temporarily save the character
                Boolean insert = false;                           // Variable that authorizes saving on the stack
                int i = 0;                                        // Counter
                while ((i < model.Operation.Length) && (!error))
                {     
                    if ((Char.IsNumber(model.Operation[i])) ||    // Validating allowed characters
                        (model.Operation[i] == 'S') ||
                        (model.Operation[i] == '+') ||
                        (model.Operation[i] == '-') ||
                        (model.Operation[i] == '/') ||
                        (model.Operation[i] == '*') ||
                        (model.Operation[i] == ',') ||
                        (model.Operation[i] == '.') ||
                        (model.Operation[i] == ' '))
                    {
                        if (model.Operation[i] == '+')            // Sum
                        {
                            model.Text.Add(
                                Operations(
                                    ref temp, ref Numbers, ref insert, "+"));
                        }
                        else if (model.Operation[i] == '-')       // Subtraction
                        {
                            model.Text.Add(
                                Operations(
                                    ref temp, ref Numbers, ref insert, "-"));
                        }
                        else if (model.Operation[i] == '*')       // Multiplication
                        {
                            model.Text.Add(
                               Operations(
                                   ref temp, ref Numbers, ref insert, "*"));
                        }
                        else if (model.Operation[i] == '/')       // Division
                        {
                            model.Text.Add(
                               Operations(
                                   ref temp, ref Numbers, ref insert, "/"));
                        }
                        else if (model.Operation[i] == 'S')       // Square root
                        {
                            model.Text.Add(
                               Operations(
                                   ref temp, ref Numbers, ref insert, "S"));
                        }
                        else if (model.Operation[i] != ' ')       // Not a space and not operator, then a number
                        {
                            temp = temp + model.Operation[i];     // Creating the string with the number
                            insert = true;
                        }
                        else if (insert == true)                  // Blank space. After a number, insert.
                        {
                            Numbers.Push(Convert.ToDouble(temp)); // Inserting the number in the stack
                            temp = "";
                            insert = false;
                        }
                        i++;
                    }
                    else
                    {
                        model.Error_Message = "Unvalid entry";    // Feedback message
                        error = true;
                    }                    
                }
            }
            return View(model);
        }
    }
}