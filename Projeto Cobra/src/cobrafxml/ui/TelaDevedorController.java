/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.ui;

import cobrafxml.db.cobradb.db.dal.DALCidade;
import cobrafxml.db.cobradb.db.dal.DALPessoa;
import cobrafxml.db.cobradb.db.entidades.Cidade;
import cobrafxml.db.cobradb.db.entidades.Cobrador;
import cobrafxml.db.cobradb.db.entidades.Devedor;
import cobrafxml.db.cobradb.db.entidades.Pessoa;
import cobrafxml.util.AcessoWS;
import com.jfoenix.controls.JFXButton;
import com.jfoenix.controls.JFXComboBox;
import com.jfoenix.controls.JFXTextField;
import java.net.URL;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.ResourceBundle;
import javafx.application.Platform;
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
import javax.swing.JOptionPane;
import org.json.JSONObject;


/**
 * FXML Controller class
 *
 * @author Leonardo
 */
public class TelaDevedorController implements Initializable {

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
    private JFXTextField txNome;
    @FXML
    private JFXTextField txTelefone;
    @FXML
    private JFXTextField txEmail;
    @FXML
    private JFXTextField txCPF;
    @FXML
    private JFXTextField txEndereco;
 
    @FXML
    private VBox pnPesquisa;
    @FXML
    private TableColumn tcCodigo;
    @FXML
    private TableColumn tcNome;
    @FXML
    private TableView tvDevedor;
    @FXML
    private JFXTextField txBairro;
    @FXML
    private JFXTextField txLogradouro;
    @FXML
    private JFXComboBox<Cidade> cbbCidade;
  

    /**
     * Initializes the controller class.
     */
    private void estadoInclusao()
    {
        txCodigo.setDisable(true);
        txCPF.setDisable(false);
        txEndereco.setDisable(false);
        cbbCidade.setDisable(false);
        txNome.setDisable(false);
        txBairro.setDisable(false);
        txTelefone.setDisable(false);
        txEmail.setDisable(false);
        btnNovo.setDisable(true);
        txLogradouro.setDisable(false);
        btnApagar.setDisable(false);
        btnAlterar.setDisable(true);
        pnPesquisa.setDisable(false);
        btnConfirmar.setDisable(false);
    }
    private void estadoInicial()
    {
        txCodigo.setDisable(true);
        txNome.setDisable(true);
        txCPF.setDisable(true);
        txEndereco.setDisable(true);
        cbbCidade.setDisable(true);
        txBairro.setDisable(true);
        txTelefone.setDisable(true);
        txEmail.setDisable(true);
        txLogradouro.setDisable(true);
        btnApagar.setDisable(true);
        btnAlterar.setDisable(true);
        btnConfirmar.setDisable(true);
        btnNovo.setDisable(false);
        pnPesquisa.setDisable(true);
    }
    private void carregaComboBOX() 
    {
        DALCidade ctrlCidade = new DALCidade();
        Platform.runLater(()->
        {ObservableList lista = FXCollections.observableArrayList(ctrlCidade.buscaAllCid(""));
         cbbCidade.getItems().setAll(lista);
        }
        );
       
       

    }
    private void carregaTabela()
    {
        Devedor dev = new Devedor();
        DALPessoa ctrlPessoa = new DALPessoa();
        ArrayList<Pessoa> todosDevedores= new ArrayList(); 
        todosDevedores = ctrlPessoa.getAllPessoas(dev,"");
        ObservableList <Pessoa> conteudoTabela;
        conteudoTabela = FXCollections.observableArrayList(todosDevedores);
        tcCodigo.setCellValueFactory(new PropertyValueFactory<>("codigo"));
        tcNome.setCellValueFactory(new PropertyValueFactory<>("nome")); 
        tvDevedor.setItems(conteudoTabela);
    }
    private void limpaTela()
    {
        txCodigo.clear();
        txCPF.clear();
        txEndereco.clear();
        txNome.clear();
        txTelefone.clear();
        txEmail.clear();
        txBairro.clear();
        txLogradouro.clear();
    }
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        limpaTela();
        estadoInicial();
        carregaTabela();
        carregaComboBOX();
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
        DALPessoa ctrlPessoa = new DALPessoa();
        Devedor d = new Devedor();
        d.setCodigo( Integer.parseInt(txCodigo.getText()));
        
        
        String message = "Deseja realmente excluir o cobrador?";
        String title = "Confirmação";
        int reply = JOptionPane.showConfirmDialog(null, message, title, JOptionPane.YES_NO_OPTION);
        if (reply == JOptionPane.YES_OPTION)
        {
            if(ctrlPessoa.excluiPessoa(d))
            {
                Alert a = new Alert(Alert.AlertType.CONFIRMATION);
                a.setContentText("Excluido com sucesso!");
                a.showAndWait();
                limpaTela();
                estadoInicial();
                carregaTabela();
            }
            else
            {
                 Alert a = new Alert(Alert.AlertType.CONFIRMATION);
                a.setContentText("Esse Devedor esta associado a uma cobrança, exclua a cobrança primeiro!");
                a.showAndWait();
            }
            
        }
        else
        {
            Alert a = new Alert(Alert.AlertType.CONFIRMATION);
            a.setContentText("Falha na exclusao!");
            a.showAndWait();
        }
    }

    @FXML
    private void clkbtnConfirmar(ActionEvent event) {
        DALPessoa ctrlPessoa = new DALPessoa();
        //int cpf, int cep, String bairro, String telefone, String email, String nome)
        Cidade cid = new Cidade();
        
        cid = cbbCidade.getSelectionModel().getSelectedItem();
        
        ///dev = (Devedor)cmbDevedor.getSelectionModel().getSelectedItem();
       //public Devedor(int cpf, int cep, String logradouro, String bairro, Cidade cidade, String telefone, String email, String nome)
        //public Devedor(int cpf, int cep, String logradouro, String bairro, Cidade cidade, String telefone, String email, String nome)
       Pessoa p = new Devedor(Integer.parseInt(txCPF.getText()),Integer.parseInt(txEndereco.getText()),txLogradouro.getText(),txBairro.getText(),cid,txTelefone.getText(),txEmail.getText(),txNome.getText());
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
    private void digitou(ActionEvent event) {
        Platform.runLater(new Runnable() {
            @Override
            public void run()
            {
                try
                {
                     String res = AcessoWS.consultaCep(txEndereco.getText(), "json");
                    JSONObject my_obj = new JSONObject(res);
                    
                    txBairro.setText(my_obj.getString("bairro"));
                    
                }
                catch(Exception e)
                {
                    System.out.println("Ocorreu algum erro na concexão!");
                }
            }
        });
        
        
    }

    @FXML
    private void clktvdevedor(MouseEvent event) {
         if(event.getClickCount()==2)
        {
            
            DALPessoa ctrlPessoa = new DALPessoa();
            Devedor  p = (Devedor) tvDevedor.getSelectionModel().getSelectedItem();
            //p = (Devedor) ctrlPessoa.getPessoa(p.getCodigo(),2);
           txCodigo.setText(Integer.toString(p.getCodigo()));
           txNome.setText(p.getNome());
           txEmail.setText(p.getEmail());
           txCPF.setText(Integer.toString(p.getCpf()));
           txLogradouro.setText(p.getLogradouro());
           txBairro.setText(p.getBairro());
           //txEndereco.setText(p.get);
           txTelefone.setText(p.getTelefone());
            
           
        } 
    }
    
}
