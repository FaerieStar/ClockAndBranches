namespace BranchProgram
{
    class Branch
    {
        public int num;
        public Branch? left;
        public Branch? right;
        public Branch(int num)
        {
            this.num = num;
            left = null;
            right = null;
        }
    }
    class BranchList
    {
        Branch? root;
        List<Branch> branches;
        public BranchList()
        {
            root = null;
        }
        public void Add(int num)
        {
            root = AddRecur(root, num);
        }
        public Branch AddRecur(Branch curr, int num)
        {
            if (curr == null)
            {
                return new Branch(num);
            }

            if(num < curr.num)
            {
                curr.left = AddRecur(curr.left, num);
            }
            else if (num > curr.num)
            {
                curr.right = AddRecur(curr.right, num);
            }
            else
            {
                return curr;
            }
            return curr;
        }
        public int Depth()
        {
            return DepthRecur(root);
        }
        public int DepthRecur(Branch branch)
        {
            if(branch == null)
            {
                return 0;
            }
            int depthLeft = DepthRecur(branch.left);
            int depthRight = DepthRecur(branch.right);

            return depthLeft > depthRight ? (depthLeft + 1) : (depthRight + 1);
        }
    }
    class Program
    {
        public static void Main()
        {
            BranchList branches = new BranchList();
            char option = 'y';
            int num;
            while(option == 'y')
            {
                Console.WriteLine("Input number to add: ");
                num = Convert.ToInt32(Console.ReadLine());
                branches.Add(num);

                Console.WriteLine("Add new numbers? [y/n]");
                option = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Depth is: " + branches.Depth());
        }
    }
}
