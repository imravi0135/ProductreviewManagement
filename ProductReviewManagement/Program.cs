﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        readonly List<ProductReview> ProductReviewList;
        public Program()
        {
            ProductReviewList = new List<ProductReview>()
            {
                 new ProductReview(){ProductID=1,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=4,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="bas",isLike=true},
                new ProductReview(){ProductID=8,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=2,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=11,UserID=1,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=12,UserID=1,Rating=2,Review="Good",isLike=true},
                new ProductReview(){ProductID=12,UserID=1,Rating=4,Review="Good",isLike=true},
                new ProductReview(){ProductID=13,UserID=1,Rating=5,Review="Good",isLike=true},
                new ProductReview(){ProductID=14,UserID=1,Rating=6,Review="Good",isLike=false},
                new ProductReview(){ProductID=15,UserID=1,Rating=2,Review="nice",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=1,Review="bad",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=2,Review="bad",isLike=true},
                new ProductReview(){ProductID=15,UserID=1,Rating=1,Review="Good",isLike=false},
                new ProductReview(){ProductID=18,UserID=1,Rating=9,Review="nice",isLike=true},
                new ProductReview(){ProductID=19,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=20,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=21,UserID=1,Rating=3,Review="nice",isLike=true},
                new ProductReview(){ProductID=22,UserID=1,Rating=10,Review="nice",isLike=true},
                new ProductReview(){ProductID=22,UserID=1,Rating=8,Review="nice",isLike=true},
                new ProductReview(){ProductID=25,UserID=1,Rating=3,Review="nice",isLike=true}
            };
        }
        public void DisplayList(List<ProductReview> ProductReviewsList)
        {
            foreach (var ProductReview in ProductReviewsList)
            {
                Console.WriteLine("Product ID: {0}, \nUser ID: {1}, \nRating: {2}, \nReview: {3}, " +
                    "\nIs Like: {4} \n", ProductReview.ProductID, ProductReview.UserID, ProductReview.Rating, ProductReview.Review,
                     ProductReview.isLike);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management using LINQ");
            Program program = new Program();
            Managenent management = new Managenent();
            int option;
            do
            {
                Console.WriteLine("Choose a Number:");
                Console.WriteLine("1 to display the list of items");
                Console.WriteLine("0 to EXIT");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        program.DisplayList(program.ProductReviewList);
                        break;

                    default:
                        break;
                }

            } while (option != 0);
        }
    }

}

