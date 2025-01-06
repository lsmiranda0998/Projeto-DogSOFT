/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.ui;

import cobrafxml.db.cobradb.db.dal.DALPessoa;
import cobrafxml.db.cobradb.db.entidades.Devedor;
import cobrafxml.db.cobradb.db.entidades.Pessoa;
import cobrafxml.db.cobradb.db.entidades.Usuario;
import com.jfoenix.controls.JFXButton;
import com.jfoenix.controls.JFXPasswordField;
import com.jfoenix.controls.JFXTextField;
import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.control.Alert;
import javafx.scene.control.ScrollPane;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.VBox;

/**
 * FXML Controller class
 *
 * @author Aluno
 */
public class TelaUsuarioController implements Initializable {

    @FXML
    private VBox pnDados;
    @FXML
    private JFXButton btnNovo;

    @FXML
    private JFXButton btnApagar;
    @FXML
    private JFXButton btnConfirmar;
    @FXML
    private JFXButton btnCancelar;
    @FXML
    private JFXTextField txCodigo;
    @FXML
    private JFXTextField txNome;
    @FXML
    private JFXPasswordField txSenha;
    @FXML
    private JFXTextField txNivel;
    @FXML
    private VBox pnPesquisa;
    @FXML
    private TableColumn tcCodigo;
    @FXML
    private TableColumn tcNome;
    @FXML
    private TableColumn tcNivel;
    @FXML
    private TableView tvUsuario;

    /**
     * Initializes the controller class.
     */
    private void estadoInclusao()
    {
        txCodigo.setDisable(true);

        txNome.setDisable(false);
        txNivel.setDisable(false);
        txSenha.setDisable(false);
        btnNovo.setDisable(true);
        tvUsuario.setDisable(false);
        btnApagar.setDisable(true);
      
        pnPesquisa.setDisable(false);
        btnConfirmar.setDisable(false);
    }
    private void estadoInicial()
    {
        txCodigo.setDisable(true);
        txNome.setDisable(true);
        txNivel.setDisable(true);
        txSenha.setDisable(true);
        btnApagar.setDisable(true);
        tvUsuario.setDisable(true);
        btnConfirmar.setDisable(true);
        btnNovo.setDisable(false);
        pnPesquisa.setDisable(true);
    }
     private void carregaTabela()
    {
        Usuario u = new Usuario();
        
        DALPessoa ctrlPessoa = new DALPessoa();
        ArrayList<Pessoa> todosUsuarios = new ArrayList(); 
        todosUsuarios = ctrlPessoa.getAllPessoas(u,"");
        ObservableList <Pessoa> conteudoTabela;
        conteudoTabela = FXCollections.observableArrayList(todosUsuarios);
        tcCodigo.setCellValueFactory(new PropertyValueFactory<>("codigo"));
        tcNome.setCellValueFactory(new PropertyValueFactory<>("nome")); 
        tcNivel.setCellValueFactory(new PropertyValueFactory<>("nivel")); 
        tvUsuario.setItems(conteudoTabela);
    }
    private void limpaTela()
    {
        txCodigo.clear();
        txSenha.clear();
        txNome.clear();
        txNivel.clear();
    }
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        limpaTela();
        estadoInicial();
        carregaTabela();
        
        // TODO
    }    

    @FXML
    private void clkbtnNovo(ActionEvent event) {
        estadoInclusao();
    }
    @FXML
    private void clkbtnApagar(ActionEvent event) {
    }

    @FXML
    private void clkbtnConfirmar(ActionEvent event) {
         DALPessoa ctrlPessoa = new DALPessoa();
         // public Usuario(int nivel, String nome, String senha)
         Pessoa p = new Usuario (Integer.parseInt(txNivel.getText()),txNome.getText(),txSenha.getText());
        if (txCodigo.getText() == null || txCodigo.getText().trim().equals(""))
        {
           ctrlPessoa.gravarPessoa(p);
           Alert a = new Alert(Alert.AlertType.CONFIRMATION);
           a.setContentText("Cadastro realizado com sucesso!");
           a.showAndWait();
           limpaTela();
           carregaTabela();
           estadoInicial();
        }
        else
        {
            
        }
        
    }

    @FXML
    private void clkbtnCancelar(ActionEvent event) {
        if (!btnConfirmar.isDisable())
        {
            estadoInicial();
            limpaTela();
        }
        else//era pra voltar pra tela inicial mas n consegui
        {    
                Parent aux = btnConfirmar.getParent();
                while (aux != (ScrollPane)aux)
                {
                    aux = aux.getParent();
                }  
        }
        
    }

    @FXML
    private void clktvUsuario(MouseEvent event) {
    }
    
}
