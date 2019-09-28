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
                Double one = 0;                                   // First element of the operation
                Double two = 0;                                   // Second element of the operation
                Double total = 0;                                 // Total. Element to store
                Boolean insert = false;                           // Variable that authorizes saving on the stack
                String symbol = "";                               // Operation
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
                            two = (double)Numbers.Pop();          // Reading from the stack
                            one = (double)Numbers.Pop();          
                            total = one + two;
                            Numbers.Push(total);                  // Saving the result
                            symbol = "+";
                            model.Text.Add(one.ToString("0.00") + " " + 
                                           symbol + " " + 
                                           two.ToString("0.00") + " = " + 
                                           total.ToString("0.00"));
                            temp = "";
                            insert = false;
                        }
                        else if (model.Operation[i] == '-')
                        {
                            two = (double)Numbers.Pop();
                            one = (double)Numbers.Pop();
                            total = one - two;
                            Numbers.Push(total);
                            symbol = "-";
                            model.Text.Add(one.ToString("0.00") + " " + 
                                           symbol + " " + 
                                           two.ToString("0.00") + " = " + 
                                           total.ToString("0.00"));
                            temp = "";
                            insert = false;
                        }
                        else if (model.Operation[i] == '*')
                        {
                            two = (double)Numbers.Pop();
                            one = (double)Numbers.Pop();
                            total = one * two;
                            Numbers.Push(total);
                            symbol = "*";
                            model.Text.Add(one.ToString("0.00") + " " + 
                                           symbol + " " + 
                                           two.ToString("0.00") + " = " + 
                                           total.ToString("0.00"));
                            temp = "";
                            insert = false;
                        }
                        else if (model.Operation[i] == '/')
                        {
                            two = (double)Numbers.Pop();
                            one = (double)Numbers.Pop();
                            total = one / two;
                            Numbers.Push(total);
                            symbol = "/";
                            model.Text.Add(one.ToString("0.00") + " " + 
                                           symbol + " " + 
                                           two.ToString("0.00") + " = " + 
                                           total.ToString("0.00"));
                            temp = "";
                            insert = false;
                        }
                        else if (model.Operation[i] == 'S')
                        {
                            one = (double)Numbers.Pop();
                            total = Math.Sqrt(one);
                            Numbers.Push(total);
                            symbol = "SQRT";
                            model.Text.Add(one.ToString("0.00") + " " + 
                                           symbol + " = " + 
                                           total.ToString("0.00"));
                            temp = "";
                            insert = false;
                        }
                        else if (model.Operation[i] != ' ')
                        {
                            temp = temp + model.Operation[i];
                            insert = true;
                        }
                        else if (insert == true)
                        {
                            Numbers.Push(Convert.ToDouble(temp));
                            temp = "";
                            insert = false;
                        }
                        i++;
                    }
                    else
                    {
                        model.Error_Message = "Unvalid entry";
                        error = true;
                    }                    
                }
            }
            return View(model);
        }
    }
}