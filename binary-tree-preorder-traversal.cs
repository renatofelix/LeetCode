/**
https://leetcode.com/problems/binary-tree-preorder-traversal/
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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        PreorderHelper(root, result);
        return result;
    }
    
    private void PreorderHelper(TreeNode node, List<int> result) {
        if (node == null) return;
        
        result.Add(node.val);              // Visitar o nó
        PreorderHelper(node.left, result); // Percorrer a subárvore esquerda
        PreorderHelper(node.right, result); // Percorrer a subárvore direita
    }
}