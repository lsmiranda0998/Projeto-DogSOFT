/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.ui;

import cobrafxml.db.cobradb.db.dal.DALOrigem;
import cobrafxml.db.cobradb.db.dal.DALPessoa;
import cobrafxml.db.cobradb.db.dal.DALSituacao;
import cobrafxml.db.cobradb.db.entidades.Cobrador;
import cobrafxml.db.cobradb.db.entidades.Origem;
import cobrafxml.db.cobradb.db.entidades.Pessoa;
import cobrafxml.db.cobradb.db.entidades.Situacao;
import com.jfoenix.controls.JFXButton;
import com.jfoenix.controls.JFXTextField;
import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.VBox;
import javax.swing.JOptionPane;

/**
 * FXML Controller class
 *
 * @author Leonardo
 */
public class TelaSituacaoController implements Initializable {

    @FXML
    private VBox pnDados;
    @FXML
    private JFXButton btnNovo;
    @FXML
    private JFXButton btnAlterar;
    @FXML
    private JFXButton btnApagar;
    @FXML
    private JFXButton btnConfirmar;
    @FXML
    private JFXButton btnCancelar;
    @FXML
    private JFXTextField txCodigo;
    @FXML
    private JFXTextField txDescricao;
    @FXML
    private VBox pnPesquisa;
    @FXML
    private TableColumn tcCodigo;
    @FXML
    private TableColumn tcDescricao;
    @FXML
    private TableView tvSituacao;

    /**
     * Initializes the controller class.
     */
    private void estadoInclusao()
    {
        txCodigo.setDisable(true);
        txDescricao.setDisable(false);
        btnNovo.setDisable(true);
        btnApagar.setDisable(true);
        btnAlterar.setDisable(true);
        btnConfirmar.setDisable(false);
        pnPesquisa.setDisable(false);
    }
    private void estadoInicial()
    {
        txCodigo.setDisable(true);
        txDescricao.setDisable(true);
        btnApagar.setDisable(true);
        btnAlterar.setDisable(true);
        btnConfirmar.setDisable(true);
        btnNovo.setDisable(false);
        pnPesquisa.setDisable(true);
    }
    private void carregaTabela()
    {
     
        DALSituacao ctrlSituacao = new DALSituacao();
        ArrayList<Situacao> todasSituacoes = new ArrayList();
        
        todasSituacoes = ctrlSituacao.buscaTodos("");
        ObservableList <Situacao> conteudoTabela;
        conteudoTabela = FXCollections.observableArrayList(todasSituacoes);
        
        tcCodigo.setCellValueFactory(new PropertyValueFactory<>("codigo"));
        tcDescricao.setCellValueFactory(new PropertyValueFactory<>("descricao"));
      
        tvSituacao.setItems(conteudoTabela);
    }
    private void limpaTela()
    {
        txCodigo.clear();
        txDescricao.clear();
    }
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        carregaTabela();
        estadoInicial();
        // TODO
    }    

    @FXML
    private void clkbtnNovo(ActionEvent event) {
         estadoInclusao();
    }

    @FXML
    private void clkbtnAlterar(ActionEvent event) {
       
    }

    @FXML
    private void clkbtnApagar(ActionEvent event) {
    }

    @FXML
    private void clkbtnConfirmar(ActionEvent event) {
       
        if (txCodigo.getText() == null || txCodigo.getText().trim().equals(""))
        {
           DALSituacao ctrlSituacao = new DALSituacao();
           Situacao sit = new Situacao(txDescricao.getText());
           ctrlSituacao.cadSituacao(sit);
           Alert a = new Alert(Alert.AlertType.CONFIRMATION);
           a.setContentText("Cadastro realizado com sucesso!");
           a.showAndWait();
           limpaTela();
           carregaTabela();
           estadoInicial();
        }
    }

    @FXML
    private void clkbtnCancelar(ActionEvent event) {
        if (!btnConfirmar.isDisable())
        {
            estadoInicial();
            limpaTela();
        }
        else
        {
        
         //queria voltar pra tela inicial mas n consegui
         btnConfirmar.getParent().getScene().getWindow().hide();   
        }
    }
    
}
