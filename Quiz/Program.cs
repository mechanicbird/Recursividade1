static void Main(string[] args)
{
    BinaryTree<QuizItem> tree = GetTree();
    BinaryTreeNode<QuizItem> node = tree.Root;
    while (node != null)
    {
        if (node.Left != null || node.Right != null)
        {
            Console.Write(node.Data.Text);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                    WriteAnswer(" Yes");
                    node = node.Left;
                    break;
                case ConsoleKey.N:
                    WriteAnswer(" No");
                    node = node.Right;
                    break;
            }
        }
        else
        {
            WriteAnswer(node.Data.Text);
            node = null;
        }
    }
     

}