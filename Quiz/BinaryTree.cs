using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz
{
    public class BinaryTree
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }

        private static BinaryTree<QuizItem> GetTree()
        {
            BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();
            tree.Root = new BinaryTreeNode<QuizItem>()
            {
                Data = new QuizItem("Do you have experience in developing applications?"),
                Children = new List<TreeNode<QuizItem>>()
                {
                    new BinaryTreeNode<QuizItem>()
                    {
                        Data = new QuizItem("Have you worked as a developer for more than 5 years?"),
                        Children = new List<TreeNode<QuizItem>>()
                        {
                            Data = new QuizItem("Apply as a senior develope!"),
                         },
                         new BinaryTreeNode<QuizItem>()
                         {
                            Data = new QuizItem("Apply as a middle developer!")
                          }
                     }
                 },
                new BinaryTreeNode<QuizItem>()
                {
                    Data = new QuizItem("Have you completed the university?"),
                    Children = new List<TreeNode<QuizItem>>()
                    {
                        new BinaryTreeNode<QuizItem>()
                        {
                            Data = new QuizItem("Apply for a junior developer!")
                         },
                         new BinaryTreeNode<QuizItem>()
                         {
                            Data = new QuizItem("Will you find some time during the semester?"),
                            Children = new List<TreeNode<QuizItem>>()
                            {
                                new BinaryTreeNode<QuizItem>()
                                {
                                    Data = new QuizItem("Apply for our long-time internship program!")
                                 },
                                 new BinaryTreeNode<QuizItem>()
                                 {
                                    Data = new QuizItem("Apply for summer internship program!")

                                }
                             }

                        }
                     }
                }
            }
         };
        tree.Count = 9;
         return tree;    
    }
    private static void WriteAnswer(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
         }

     
}