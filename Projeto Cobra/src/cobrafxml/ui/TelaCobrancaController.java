/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.ui;

import cobrafxml.db.cobradb.db.dal.DALCobranca;
import cobrafxml.db.cobradb.db.dal.DALOrigem;
import cobrafxml.db.cobradb.db.dal.DALPessoa;
import cobrafxml.db.cobradb.db.dal.DALSituacao;
import cobrafxml.db.cobradb.db.entidades.Cobrador;
import cobrafxml.db.cobradb.db.entidades.Cobranca;
import cobrafxml.db.cobradb.db.entidades.Devedor;
import cobrafxml.db.cobradb.db.entidades.Lembrete;
import cobrafxml.db.cobradb.db.entidades.Ocorrencia;
import cobrafxml.db.cobradb.db.entidades.Origem;
import cobrafxml.db.cobradb.db.entidades.Pessoa;
import cobrafxml.db.cobradb.db.entidades.Situacao;
import com.jfoenix.controls.JFXButton;
import java.io.IOException;
import java.net.URL;
import java.sql.Date;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.application.Platform;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.geometry.Bounds;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.ComboBox;
import javafx.scene.control.DatePicker;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.TextArea;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Region;
import javafx.stage.Stage;

/**
 * FXML Controller class
 *
 * @author Leonardo
 */
public class TelaCobrancaController implements Initializable {

    @FXML
    private JFXButton btnNovo;
    @FXML
    private JFXButton btnConfirmar;
    @FXML
    private JFXButton btnCancelar;
    @FXML
    private TextArea taHistoria;
    @FXML
    private DatePicker dpVencimento;
    @FXML
    private TextField txValor;
    @FXML
    private ComboBox<Devedor> cmbDevedor;
    @FXML
    private ComboBox<Cobrador> cmbCobrador;
    @FXML
    private ComboBox<Situacao> cmbSituacao;
    @FXML
    private ComboBox<Origem> cmbOrigem;
    @FXML
    private Button btnMenosOcorrencia;
    @FXML
    private Button btnMaisOcorrencia;
    @FXML
    private Button btnEmail;
    @FXML
    private DatePicker dpDataLembrete;
    @FXML
    private TextField txOcorrencia;
    @FXML
    private TableView tvOcorrencia;
    private TableColumn tcOcorrenciaCodigo;
    @FXML
    private TableColumn tcOcorrenciaTexto;
    @FXML
    private TableColumn tcOcorrenciaData;
    @FXML
    private TableView tvLembrete;
    private TableColumn tcLembreteCodigo;
    @FXML
    private TableColumn tcLembreteData;
    @FXML
    private TableColumn tcLembreteStatus;
    @FXML
    private TextField txLembrete;
    @FXML
    private Button btnMaisLembrete;
    @FXML
    private Button btnMenosLembrete;
    private ArrayList <Ocorrencia> conteudoTabelaOcorrencia;
    private ArrayList <Lembrete> conteudoTabelaLembrete;
    @FXML
    private TableColumn tcLembreteTexto;
    

    /**
     * Initializes the controller class.
     */
     
    private void estadoInclusao()
    {
        cmbDevedor.setDisable(false);
        cmbCobrador.setDisable(false);
        cmbSituacao.setDisable(false);
        cmbOrigem.setDisable(false);
        taHistoria.setDisable(false);
        dpVencimento.setDisable(false);
        txOcorrencia.setDisable(false);
        txLembrete.setDisable(false);
        btnMaisOcorrencia.setDisable(false);
        btnMenosOcorrencia.setDisable(false);
        dpDataLembrete.setDisable(false);
        btnMaisLembrete.setDisable(false);
        btnMenosLembrete.setDisable(false);
        tvOcorrencia.setDisable(false);
        tvLembrete.setDisable(false);
        btnNovo.setDisable(true);
        txValor.setDisable(false);
        btnEmail.setDisable(false);

        btnConfirmar.setDisable(false);
    }
    private void estadoInicial()
    {
        cmbDevedor.setDisable(true);
        cmbCobrador.setDisable(true);
        cmbSituacao.setDisable(true);
        cmbOrigem.setDisable(true);
        taHistoria.setDisable(true);
        dpVencimento.setDisable(true);
        txOcorrencia.setDisable(true);
        txValor.setDisable(true);
        btnEmail.setDisable(true);
        txLembrete.setDisable(true);
        btnMaisOcorrencia.setDisable(true);
        btnMenosOcorrencia.setDisable(true);
        dpDataLembrete.setDisable(true);
        btnMaisLembrete.setDisable(true);
        btnMenosLembrete.setDisable(true);
        tvOcorrencia.setDisable(true);
        tvLembrete.setDisable(true);        
        conteudoTabelaOcorrencia = new ArrayList();
        conteudoTabelaLembrete = new ArrayList();
        btnConfirmar.setDisable(true);
        btnNovo.setDisable(false);
    
    }
    private void carregaComboBOX()
    {    
        DALPessoa ctrlPessoa = new DALPessoa();
        DALSituacao ctrlSituacao = new DALSituacao();
        DALOrigem ctrlOrigem = new DALOrigem();
        Devedor dev = new Devedor();
        Cobrador cobr = new Cobrador();
        Platform.runLater(()->
        {
        ObservableList lista = FXCollections.observableArrayList(ctrlPessoa.getAllPessoas(dev, ""));
        cmbDevedor.getItems().setAll(lista);
        lista = FXCollections.observableArrayList(ctrlPessoa.getAllPessoas(cobr, ""));
        cmbCobrador.getItems().setAll(lista);
        lista = FXCollections.observableArrayList(ctrlSituacao.buscaTodos(""));
        cmbSituacao.getItems().setAll(lista);
        lista = FXCollections.observableArrayList(ctrlOrigem.buscarTodos(""));
        cmbOrigem.getItems().setAll(lista);
        
        //carrega tabela de ocorrencia
        /*tcOcorrenciaCodigo.setCellValueFactory(new PropertyValueFactory<>("codigo"));
        tcOcorrenciaTexto.setCellValueFactory(new PropertyValueFactory<>("texto"));
        tcOcorrenciaData.setCellValueFactory(new PropertyValueFactory<>("data"));         
        tvOcorrencia.setItems((ObservableList) conteudoTabelaOcorrencia);
        
        //carrega tabela de lembrete
        tcLembreteCodigo.setCellValueFactory(new PropertyValueFactory<>("codigo"));
        tcLembreteData.setCellValueFactory(new PropertyValueFactory<>("data"));
        tcLembreteStatus.setCellValueFactory(new PropertyValueFactory<>("status"));
        tvLembrete.setItems((ObservableList) conteudoTabelaLembrete);*/
        });
        
        
        
        
    
       
    }
    private void limpaTela()
    {
        cmbDevedor.getSelectionModel().clearSelection();
        cmbCobrador.getSelectionModel().clearSelection();
        cmbSituacao.getSelectionModel().clearSelection();
        cmbOrigem.getSelectionModel().clearSelection();
        taHistoria.clear();
        dpVencimento.valueProperty().setValue(null);
        txValor.clear();
        txOcorrencia.clear();
        dpDataLembrete.valueProperty().setValue(null);
        tvOcorrencia.getItems().clear();
        tvLembrete.getItems().clear();
     
    }
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        estadoInicial();
        carregaComboBOX();
        // TODO
    }    

    @FXML
    private void clkbtnNovo(ActionEvent event) {
        estadoInclusao();
        
    }

    @FXML
    private void clkbtnConfirmar(ActionEvent event) {
 //public Cobranca(double valor, LocalDate data, String texto, Origem origem, Situacao situacao, Cobrador cobrador, Devedor devedor)
        DALCobranca ctrlCobranca = new DALCobranca();
        System.out.println("xuxu");
       
        String historia;
        double valorTotal;
        LocalDate vencimento;
        Devedor dev;
        Cobrador cobrador;
        Situacao sit;
        Origem orig;
        //pega conteudo selecionado do combo
        dev = (Devedor)cmbDevedor.getSelectionModel().getSelectedItem();
        cobrador = (Cobrador)cmbCobrador.getSelectionModel().getSelectedItem();
        sit = (Situacao)cmbSituacao.getSelectionModel().getSelectedItem();
        orig = (Origem)cmbOrigem.getSelectionModel().getSelectedItem();
        valorTotal = Double.parseDouble(txValor.getText());
        vencimento =  dpVencimento.getValue();
        historia = taHistoria.getText();
        Cobranca cobranca = new Cobranca(valorTotal,vencimento,historia,orig,sit,cobrador,dev);
        for(int i = 0; i < conteudoTabelaLembrete.size(); i++)
         {
             cobranca.addLembrete(conteudoTabelaLembrete.get(i));
             //System.out.println(conteudoTabelaLembrete.get(i).getTexto());
         }
         for(int i = 0; i < conteudoTabelaOcorrencia.size(); i++)
         {
             
            cobranca.addOcorrencia(conteudoTabelaOcorrencia.get(i));
             //System.out.println(conteudoTabelaOcorrencia.get(i).getAnotacao());
         }
         
         
            
        /*cobranca.setDevedor(dev);
        cobranca.setCobrador(cobrador);
        cobranca.setSituacao(sit);
        cobranca.setOrigem(orig);
        cobranca.setValor(valorTotal);
        cobranca.setData(vencimento);
        cobranca.setTexto(historia);*/
        System.out.println(cobranca.getData());
        ctrlCobranca.gravarCobranca(cobranca);
        Alert a = new Alert(Alert.AlertType.CONFIRMATION);
        a.setContentText("Cadastro realizado com sucesso!");
        a.showAndWait();
        limpaTela();
        carregaComboBOX();
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
         btnConfirmar.getParent().getScene().getWindow().hide();   
        }
    }

    @FXML
    private void clkbtnMenosOcorrencia(ActionEvent event) {
        if(tvOcorrencia.getSelectionModel().getSelectedItem() != null)
        {
            conteudoTabelaOcorrencia.remove((Ocorrencia)tvOcorrencia.getSelectionModel().getSelectedItem());
            tvOcorrencia.getItems().remove((Ocorrencia)tvOcorrencia.getSelectionModel().getSelectedItem());
        }
    }

    @FXML
    private void clkbtnMaisOcorrencia(ActionEvent event) {
              
        //tvOcorrencia.setItems(conteudoTabelaOcorrencia);
        //tcOcorrenciaCodigo.setCellValueFactory(new PropertyValueFactory<>("codigo"));
     
          
        
        tcOcorrenciaData.setCellValueFactory(new PropertyValueFactory<>("data"));
        tcOcorrenciaTexto.setCellValueFactory(new PropertyValueFactory<>("anotacao"));
        Ocorrencia o = new Ocorrencia(LocalDate.now(),txOcorrencia.getText());
   
        tvOcorrencia.getItems().add(o);
       
        conteudoTabelaOcorrencia.add(o);
       
        txOcorrencia.clear();
        
        
    }

    @FXML
    private void clkbtnEmail(ActionEvent event) {
        
        Parent root;
        try {
            Stage stage = new Stage();
            root = FXMLLoader.load(getClass().getResource("TelaEmail.fxml"));
            stage.setTitle("Email");
            Scene scene = new Scene(root); 
            stage.setScene(scene);
            stage.show();
            //stage.setMaximized(true);
        } catch (IOException ex) {
            Logger.getLogger(TelaCobrancaController.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        
        
        
    }


    @FXML
    private void clkbtnMaisLembrete(ActionEvent event) {
      // comparar datas depois
        tcLembreteStatus.setCellValueFactory(new PropertyValueFactory<>("status"));
        tcLembreteData.setCellValueFactory(new PropertyValueFactory<>("data"));
        tcLembreteTexto.setCellValueFactory(new PropertyValueFactory<>("texto")); 
        
        Lembrete l = new Lembrete(1,dpDataLembrete.getValue(),txLembrete.getText());
        tvLembrete.getItems().add(l);
        conteudoTabelaLembrete.add(l);
        txLembrete.clear();
    }
    @FXML
    private void clickbtnMenosLembrete(ActionEvent event) {
         if(tvLembrete.getSelectionModel().getSelectedItem() != null)
        {
            conteudoTabelaLembrete.remove((Lembrete)tvLembrete.getSelectionModel().getSelectedItem());
            tvLembrete.getItems().remove((Lembrete)tvLembrete.getSelectionModel().getSelectedItem());
        }
    }




    
}
