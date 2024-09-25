/**
https://leetcode.com/problems/insert-into-a-binary-search-tree/
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InsertIntoBST(TreeNode root, int val) 
    {

        return FindTreeNodeNull(root, val);   
    }

    void InsertLeft(TreeNode node, int value)
    {

    }
    
    void InsertRight(TreeNode node, int value)
    {

    }

    TreeNode FindTreeNodeNull(TreeNode node, int value)
    {
       TreeNode currentNode = node;

       if(node == null)
       {
        currentNode.val = value;
        return node;
       }
       return node;
    }
}