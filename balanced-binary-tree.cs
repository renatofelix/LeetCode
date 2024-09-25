/**
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
     public bool IsBalanced(TreeNode root) {
        
          // Função auxiliar para calcular a altura e verificar balanceamento
        return CheckHeight(root) != -1;
    }

    private int CheckHeight(TreeNode node) {
        // Se o nó for nulo, a altura é 0 (árvore vazia)
        if (node == null) return 0;
        
        // Calcula a altura da subárvore esquerda
        int leftHeight = CheckHeight(node.left);
        if (leftHeight == -1) return -1;  // Se a subárvore esquerda não é balanceada
        
        // Calcula a altura da subárvore direita
        int rightHeight = CheckHeight(node.right);
        if (rightHeight == -1) return -1;  // Se a subárvore direita não é balanceada
        
        // Verifica a diferença entre as alturas
        if (Math.Abs(leftHeight - rightHeight) > 1) return -1;  // Não balanceado
        
        // Retorna a altura dessa subárvore
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}