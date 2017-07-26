using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHP
{
    public static class MyTreeView
    {

        public static bool HasChild(this TreeNode node)
        {
            if (node.Nodes.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int level(this TreeNode node)
        {
            int i = -1;
            
            while (node != null)
            {
                i++;
                node = node.Parent;
            }

            return i;
        }


        public static List<TreeNode> GetParentNodes(this TreeView treeView)
        {
            List<TreeNode> results = new List<TreeNode>();
            foreach (TreeNode node in treeView.Nodes)
            {
                results.AddRange(GetNodes(node));
            }
            return results;
        }

        private static List<TreeNode> GetNodes(TreeNode parentNode)
        {
            List<TreeNode> results = new List<TreeNode>();
            if (parentNode.Nodes.Count > 0)
            {
                results.Add(parentNode);
                foreach (TreeNode node in parentNode.Nodes)
                {
                    results.AddRange(GetNodes(node));
                }
            }
            return results;
        }


        

    }
}
