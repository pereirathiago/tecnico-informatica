/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tela;

import java.util.List;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import persistencia.ProdutoDAO;
import vo.Produto;

/**
 *
 * @author Thiago
 */
public class TelaLocalizaProduto extends javax.swing.JFrame {

    /**
     * Creates new form TelaLocalizaProduto
     */
    ProdutoDAO pd = new ProdutoDAO();

    public TelaLocalizaProduto() {
        initComponents();
    }

    private void preencheTabela() {
        DefaultTableModel modelo = (DefaultTableModel) tLocaliza.getModel();
        int i = modelo.getRowCount();
        while (i-- > 0) {
            modelo.removeRow(i);;
        }
        List<Produto> lista;
        if (tFiltro.getText().equals("")) {
            lista = pd.pesquisa();
        } else {
            lista = pd.pesquisa(tFiltro.getText());
        }
        for (Produto p : lista) {
            modelo.addRow(new Object[]{p.getId(), p.getCodbar(), p.getDescricao(), p.getQuantidade(), p.getMinimo()});
        }
    }

    private void preencheTabelaFaltaEstoque() {
        DefaultTableModel modelo = (DefaultTableModel) tLocaliza.getModel();
        int i = modelo.getRowCount();
        while (i-- > 0) {
            modelo.removeRow(i);;
        }
        List<Produto> lista;
        lista = pd.filtrarMinimo();
        for (Produto p : lista) {
            modelo.addRow(new Object[]{p.getId(), p.getCodbar(), p.getDescricao(), p.getQuantidade(), p.getMinimo()});
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jMenu1 = new javax.swing.JMenu();
        jPopupMenu1 = new javax.swing.JPopupMenu();
        jPopupMenu2 = new javax.swing.JPopupMenu();
        jLabel1 = new javax.swing.JLabel();
        tFiltro = new javax.swing.JTextField();
        bOk = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tLocaliza = new javax.swing.JTable();
        bFaltaEstoque = new javax.swing.JButton();
        bTodos = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        mArquivo = new javax.swing.JMenu();
        mNovo = new javax.swing.JMenuItem();
        mAltera = new javax.swing.JMenuItem();
        mExcluir = new javax.swing.JMenuItem();

        jMenu1.setText("jMenu1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        addWindowFocusListener(new java.awt.event.WindowFocusListener() {
            public void windowGainedFocus(java.awt.event.WindowEvent evt) {
                formWindowGainedFocus(evt);
            }
            public void windowLostFocus(java.awt.event.WindowEvent evt) {
            }
        });

        jLabel1.setText("Filtro");

        bOk.setText("Ok");
        bOk.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bOkActionPerformed(evt);
            }
        });

        tLocaliza.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null},
                {null, null, null, null, null},
                {null, null, null, null, null},
                {null, null, null, null, null}
            },
            new String [] {
                "Código", "Código de barra", "Descrição", "Quantidade", "Mínimo"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.Integer.class, java.lang.String.class, java.lang.String.class, java.lang.Double.class, java.lang.Double.class
            };
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane1.setViewportView(tLocaliza);

        bFaltaEstoque.setText("Falta em estoque");
        bFaltaEstoque.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bFaltaEstoqueActionPerformed(evt);
            }
        });

        bTodos.setText("Ver todos");
        bTodos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bTodosActionPerformed(evt);
            }
        });

        mArquivo.setText("Arquivo");

        mNovo.setText("Novo");
        mNovo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mNovoActionPerformed(evt);
            }
        });
        mArquivo.add(mNovo);

        mAltera.setText("Alterar");
        mAltera.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mAlteraActionPerformed(evt);
            }
        });
        mArquivo.add(mAltera);

        mExcluir.setText("Excluir");
        mExcluir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mExcluirActionPerformed(evt);
            }
        });
        mArquivo.add(mExcluir);

        jMenuBar1.add(mArquivo);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jLabel1)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(tFiltro, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(bOk, javax.swing.GroupLayout.PREFERRED_SIZE, 57, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(67, 67, 67)
                        .addComponent(bFaltaEstoque)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(bTodos))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(24, 24, 24)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 560, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(21, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(tFiltro, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(bOk)
                    .addComponent(bFaltaEstoque)
                    .addComponent(bTodos))
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 417, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(16, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void formWindowGainedFocus(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowGainedFocus
        preencheTabela();
    }//GEN-LAST:event_formWindowGainedFocus

    private void mNovoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mNovoActionPerformed
        TelaCadastraProduto t = new TelaCadastraProduto();
        t.setVisible(true);
    }//GEN-LAST:event_mNovoActionPerformed

    private void mAlteraActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mAlteraActionPerformed
        DefaultTableModel modelo = (DefaultTableModel) tLocaliza.getModel();
        if (tLocaliza.getSelectedRow() != -1) {
            int id = (Integer) modelo.getValueAt(tLocaliza.getSelectedRow(), 0);
            TelaAlteraProduto t = new TelaAlteraProduto();
            t.setProduto(pd.localiza(id));
            t.setVisible(true);
        } else {
            JOptionPane.showMessageDialog(this, "Não há linha selecionada!");
        }
    }//GEN-LAST:event_mAlteraActionPerformed

    private void mExcluirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mExcluirActionPerformed
        DefaultTableModel modelo = (DefaultTableModel) tLocaliza.getModel();
        if (tLocaliza.getSelectedRow() != -1) {
            int id = (Integer) modelo.getValueAt(tLocaliza.getSelectedRow(), 0);
            Produto p = pd.localiza(id);
            if (JOptionPane.showConfirmDialog(this, "Confirma exclusão de " + p.getCodbar() + "?") == JOptionPane.YES_OPTION) {
                pd.excluir(p);
            }
        } else {
            JOptionPane.showConfirmDialog(this, "Não há linha selecionada!");
        }
    }//GEN-LAST:event_mExcluirActionPerformed

    private void bOkActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bOkActionPerformed
        preencheTabela();
    }//GEN-LAST:event_bOkActionPerformed

    private void bTodosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bTodosActionPerformed
        tFiltro.setText("");
        preencheTabela();
    }//GEN-LAST:event_bTodosActionPerformed

    private void bFaltaEstoqueActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bFaltaEstoqueActionPerformed
        preencheTabelaFaltaEstoque();
    }//GEN-LAST:event_bFaltaEstoqueActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(TelaLocalizaProduto.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(TelaLocalizaProduto.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(TelaLocalizaProduto.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(TelaLocalizaProduto.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new TelaLocalizaProduto().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton bFaltaEstoque;
    private javax.swing.JButton bOk;
    private javax.swing.JButton bTodos;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JPopupMenu jPopupMenu1;
    private javax.swing.JPopupMenu jPopupMenu2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JMenuItem mAltera;
    private javax.swing.JMenu mArquivo;
    private javax.swing.JMenuItem mExcluir;
    private javax.swing.JMenuItem mNovo;
    private javax.swing.JTextField tFiltro;
    private javax.swing.JTable tLocaliza;
    // End of variables declaration//GEN-END:variables
}
