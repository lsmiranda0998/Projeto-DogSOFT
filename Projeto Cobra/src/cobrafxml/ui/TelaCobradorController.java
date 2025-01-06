/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.ui;

import cobrafxml.db.cobradb.db.entidades.Cobrador;
import cobrafxml.db.cobradb.db.dal.DALPessoa;
import cobrafxml.db.cobradb.db.entidades.Pessoa;
import com.jfoenix.controls.JFXButton;
import com.jfoenix.controls.JFXTextField;
import cobrafxml.ui.TelaPrincipalController;
import com.github.sarxos.webcam.Webcam;
import com.jfoenix.controls.JFXComboBox;
import static com.sun.deploy.uitoolkit.ToolkitStore.dispose;
import java.awt.Dimension;
import java.awt.image.BufferedImage;
import java.io.File;
import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.application.Platform;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.concurrent.Task;
import javafx.embed.swing.SwingFXUtils;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Cursor;
import javafx.scene.Parent;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.image.WritableImage;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.VBox;
import javafx.stage.FileChooser;
import javax.swing.JOptionPane;

/**
 * FXML Controller class
 *
 * @author Leonardo
 */
public class TelaCobradorController implements Initializable {

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
    private VBox pnPesquisa;
    @FXML
    private TableView tvCobrador;
    @FXML
    private TableColumn tcCodigo;
    @FXML
    private TableColumn tcNome;
    @FXML
    private JFXTextField txTelefone;
    @FXML
    private JFXTextField txEmail;
    @FXML
    private ImageView ivImagem;
    @FXML
    private Button btnImagem;
    @FXML
    private Button btnConectar;
    private int codigoCobrador;
    @FXML
    private Button btnCapturar;
    private Webcam webcam = null;
    private boolean conectou;


    /**
     * Initializes the controller class.
     */
    private void estadoInclusao()
    {
        txCodigo.setDisable(true);
        txNome.setDisable(false);
        txTelefone.setDisable(false);
        txEmail.setDisable(false);
        btnNovo.setDisable(true);
        btnApagar.setDisable(false);

        pnPesquisa.setDisable(false);
        btnConfirmar.setDisable(false);
        btnImagem.setDisable(false);
        btnConectar.setDisable(false);
        tvCobrador.setDisable(false);
        btnCapturar.setDisable(false);
    }
    private void estadoInicial()
    {
        txCodigo.setDisable(true);
        txNome.setDisable(true);
        txTelefone.setDisable(true);
        txEmail.setDisable(true);
        btnApagar.setDisable(true);
        tvCobrador.setDisable(true);
        btnConfirmar.setDisable(true);
        btnNovo.setDisable(false);
        pnPesquisa.setDisable(true);
        btnImagem.setDisable(true);
        btnConectar.setDisable(true);
        btnCapturar.setDisable(true);
    }
    private void carregaTabela()
    {
        Cobrador cobr = new Cobrador();
        DALPessoa ctrlPessoa = new DALPessoa();
        ArrayList<Pessoa> todosCobradores = new ArrayList();
        todosCobradores = ctrlPessoa.getAllPessoas(cobr, "");
        ObservableList <Pessoa> conteudoTabela;
        conteudoTabela = FXCollections.observableArrayList(todosCobradores);       
        tcCodigo.setCellValueFactory(new PropertyValueFactory<>("codigo"));
        tcNome.setCellValueFactory(new PropertyValueFactory<>("nome"));   
        tvCobrador.setItems(conteudoTabela);
    }
    private void limpaTela()
    {
        txCodigo.clear();
        txNome.clear();
        txTelefone.clear();
        txEmail.clear();
    }
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        limpaTela();
        carregaTabela();
        estadoInicial();
        // TODO
    }    
    @FXML
    private void clkbtnNovo(ActionEvent event) {
        estadoInclusao();
    }


    @FXML
    private void clkbtnApagar(ActionEvent event) {
        DALPessoa ctrlPessoa = new DALPessoa();
        Cobrador cobr = new Cobrador(txNome.getText(), txTelefone.getText(), txEmail.getText(),null);
        cobr.setCodigo(codigoCobrador);
        
        String message = "Deseja realmente excluir o cobrador?";
        String title = "Confirmação";
        int reply = JOptionPane.showConfirmDialog(null, message, title, JOptionPane.YES_NO_OPTION);
        if (reply == JOptionPane.YES_OPTION)
        {
            if(ctrlPessoa.excluiPessoa(cobr))
            {
                Alert a = new Alert(Alert.AlertType.CONFIRMATION);
            a.setContentText("Excluido com sucesso!");
            a.showAndWait();
            limpaTela();
            estadoInicial();
            carregaTabela();
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
        BufferedImage buf;
        buf = SwingFXUtils.fromFXImage(ivImagem.getImage(), null);
        DALPessoa ctrlPessoa = new DALPessoa();
        if (txCodigo.getText() == null || txCodigo.getText().trim().equals(""))
        { 
           Pessoa p = new Cobrador(txTelefone.getText(),txEmail.getText(),txNome.getText(),buf);
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
           Pessoa p = new Cobrador(txTelefone.getText(),txEmail.getText(),txNome.getText(),buf);
           ctrlPessoa.setPessoa(p);
           Alert a = new Alert(Alert.AlertType.CONFIRMATION);
           a.setContentText("Alterado realizado com sucesso!");
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
            btnConfirmar.getParent().getScene().getWindow().hide();   
        }
    }
    @FXML
    private void clkbtnImagem(ActionEvent event) {
        Image img = null;
        FileChooser fc = new FileChooser();
        fc.getExtensionFilters().add(new FileChooser.ExtensionFilter("*.jpg", "*.jpg"));
        
        File fto = fc.showOpenDialog(null);
        if(fto != null)
        {
            img = new Image(fto.toURI().toString());
            img.widthProperty().add(ivImagem.getFitWidth());
            img.heightProperty().add(ivImagem.getFitHeight());
            
            /*ivImagem.setFitWidth(img.getWidth());
            ivImagem.setFitHeight(img.getHeight());       */     
            ivImagem.setImage(img);
            //btnImagem.setVisible(false);
        }
    }
    public void ativar()
    {
        Platform.runLater(() -> {
            btnCapturar.getScene().setCursor(Cursor.WAIT);
        });
        webcam = Webcam.getDefault();
        webcam.setViewSize(new Dimension(320, 240));
        webcam.open();
        
        Platform.runLater(()
                -> {
            btnCapturar.setDisable(false);
            //btConectar.setText("Desconectar");
            btnCapturar.getScene().setCursor(Cursor.DEFAULT);
        });
    }
    @FXML
    private void clkbtnConectar(ActionEvent event) {
        if(!conectou)
        {  
            new Thread(new Task<Void>() {
                @Override
                protected Void call() throws Exception {
                    ativar();
                    return null;
                }
            }).start();
            conectou = true;
            
            
            
        } 
        else {   
            webcam.close();
            //btConectar.setDisable(true);
            conectou = false;  
        }
        
    }
    @FXML
    private void clkbtnCapturar(ActionEvent event) {
        if (webcam.isOpen()) {
            BufferedImage bimage;
            bimage = webcam.getImage();
            WritableImage wimg;
            wimg = SwingFXUtils.toFXImage(bimage, null);
            // aplicar no componente ImageView
            ivImagem.setImage(wimg);
        }
    }

    @FXML
    private void clktvCobrador(MouseEvent event) {
        if(event.getClickCount()==2)
        {
            
            DALPessoa ctrlPessoa = new DALPessoa();
            Cobrador cobr = (Cobrador) tvCobrador.getSelectionModel().getSelectedItem();
            //cobr = (Cobrador) ctrlPessoa.getPessoa(cobr.getCodigo(),3);
            txCodigo.setText(Integer.toString(cobr.getCodigo()));
            txNome.setText(cobr.getNome());
            txTelefone.setText(cobr.getTelefone());
            txEmail.setText(cobr.getEmail());
            codigoCobrador = cobr.getCodigo();
           
        } 
    }   
}