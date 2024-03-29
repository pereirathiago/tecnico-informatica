/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tela;

import java.util.List;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import persistencia.ClienteDAO;
import vo.Cliente;

/**
 *
 * @author Thiago
 */
public class TelaLocalizaCliente extends javax.swing.JFrame {

    ClienteDAO cd = new ClienteDAO();
    
    /**
     * Creates new form TelaLocalizaCliente
     */
    public TelaLocalizaCliente() {
        initComponents();
    }
    
    private void preencheTabela() {
        DefaultTableModel modelo = (DefaultTableModel) tlocaliza.getModel();
        int i = modelo.getRowCount();
        while (i-- > 0) {
            modelo.removeRow(i);
        }
        List<Cliente> lista;
        if (tFiltro.getText().equals("")) {
            lista = cd.pesquisa();
        } else {
            lista = cd.pesquisa(tFiltro.getText());
        }

        for (Cliente c : lista) {
            modelo.addRow(new Object[]{c.getId(), c.getNome(), c.getEndereco(), c.getCidade(), c.getUf(), c.getCpf(), c.getRg()});
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

        jLabel1 = new javax.swing.JLabel();
        tFiltro = new javax.swing.JTextField();
        bOk = new javax.swing.JButton();
        jScrollPane2 = new javax.swing.JScrollPane();
        tlocaliza = new javax.swing.JTable();
        bVeiculos = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        mNovo = new javax.swing.JMenuItem();
        mAlterar = new javax.swing.JMenuItem();
        mExcluir = new javax.swing.JMenuItem();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        addWindowFocusListener(new java.awt.event.WindowFocusListener() {
            public void windowGainedFocus(java.awt.event.WindowEvent evt) {
                formWindowGainedFocus(evt);
            }
            public void windowLostFocus(java.awt.event.WindowEvent evt) {
            }
        });

        jLabel1.setText("Filtro");

        bOk.setText("OK");
        bOk.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bOkActionPerformed(evt);
            }
        });

        tlocaliza.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null}
            },
            new String [] {
                "Id", "Nome", "Endereço", "Cidade", "UF", "CPF", "RG"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.Integer.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class, java.lang.String.class
            };
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false, false, false
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane2.setViewportView(tlocaliza);

        bVeiculos.setText("Ver Veículos");
        bVeiculos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                bVeiculosActionPerformed(evt);
            }
        });

        jMenu1.setText("Arquivo");

        mNovo.setText("Novo");
        mNovo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mNovoActionPerformed(evt);
            }
        });
        jMenu1.add(mNovo);

        mAlterar.setText("Alterar");
        mAlterar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mAlterarActionPerformed(evt);
            }
        });
        jMenu1.add(mAlterar);

        mExcluir.setText("Excluir");
        mExcluir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                mExcluirActionPerformed(evt);
            }
        });
        jMenu1.add(mExcluir);

        jMenuBar1.add(jMenu1);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(16, 16, 16)
                .addComponent(jLabel1)
                .addGap(18, 18, 18)
                .addComponent(tFiltro, javax.swing.GroupLayout.PREFERRED_SIZE, 102, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(bOk, javax.swing.GroupLayout.PREFERRED_SIZE, 51, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(bVeiculos)
                .addGap(55, 55, 55))
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 537, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(tFiltro, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(bOk)
                    .addComponent(bVeiculos))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 269, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(15, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void bOkActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bOkActionPerformed
        preencheTabela();
    }//GEN-LAST:event_bOkActionPerformed

    private void mNovoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mNovoActionPerformed
        TelaCliente t = new TelaCliente();
        t.setVisible(true);
    }//GEN-LAST:event_mNovoActionPerformed

    private void formWindowGainedFocus(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowGainedFocus
        preencheTabela();
    }//GEN-LAST:event_formWindowGainedFocus

    private void mAlterarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mAlterarActionPerformed
        DefaultTableModel modelo = (DefaultTableModel) tlocaliza.getModel();
        if (tlocaliza.getSelectedColumn() != -1) {
            int codigo = (Integer) modelo.getValueAt(tlocaliza.getSelectedRow(), 0);
            TelaCliente t = new TelaCliente();
            t.setCliente(cd.localiza(codigo));
            t.setVisible(true);
        } else {
            JOptionPane.showMessageDialog(this, "Não há nada selecionado");
        }
    }//GEN-LAST:event_mAlterarActionPerformed

    private void mExcluirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_mExcluirActionPerformed
        DefaultTableModel modelo = (DefaultTableModel) tlocaliza.getModel();
        if (tlocaliza.getSelectedRow() != -1) {
            int codigo = (Integer) modelo.getValueAt(tlocaliza.getSelectedRow(), 0);
            Cliente c = cd.localiza(codigo);
            if(JOptionPane.showConfirmDialog(this, "Confirmar exclusão de " + c.getNome()+ "?") == JOptionPane.YES_OPTION)
                cd.exclui(c);
        } else {
            JOptionPane.showMessageDialog(this, "Não há nada selecionado");
        }
    }//GEN-LAST:event_mExcluirActionPerformed

    private void bVeiculosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_bVeiculosActionPerformed
        TelaLocalizaVeiculo tv = new TelaLocalizaVeiculo();
        tv.setVisible(true);
    }//GEN-LAST:event_bVeiculosActionPerformed

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
            java.util.logging.Logger.getLogger(TelaLocalizaCliente.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(TelaLocalizaCliente.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(TelaLocalizaCliente.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(TelaLocalizaCliente.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new TelaLocalizaCliente().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton bOk;
    private javax.swing.JButton bVeiculos;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JMenuItem mAlterar;
    private javax.swing.JMenuItem mExcluir;
    private javax.swing.JMenuItem mNovo;
    private javax.swing.JTextField tFiltro;
    private javax.swing.JTable tlocaliza;
    // End of variables declaration//GEN-END:variables
}
