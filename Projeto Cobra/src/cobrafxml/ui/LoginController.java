/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.ui;

import cobrafxml.db.cobradb.db.dal.DALPessoa;
import cobrafxml.db.cobradb.db.entidades.Usuario;
import com.jfoenix.controls.JFXButton;
import com.jfoenix.controls.JFXPasswordField;
import com.jfoenix.controls.JFXTextField;
import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Alert;
import javafx.stage.Stage;

/**
 * FXML Controller class
 *
 * @author Leonardo
 */
public class LoginController implements Initializable {

    @FXML
    private JFXTextField txUsuario;
    @FXML
    private JFXPasswordField txSenha;
    @FXML
    private JFXButton btnConfirmar;
    @FXML
    private JFXButton btnCancelar;
    private DALPessoa dalPessoa = new DALPessoa();
    private static Usuario user;
    private ArrayList array;
    private static boolean acessou;

    /**
     * Initializes the controller class.
     */
    
    public LoginController() {
        
    }    

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        acessou = false;
        // TODO
    }    

    @FXML
    private void clkEntrar(ActionEvent event) {
        if(txUsuario.getText().trim().contains("") && txSenha.getText().trim().contains(""))
        {
            array = new ArrayList();
            user = new Usuario();

            user.setNome(txUsuario.getText());

            array = dalPessoa.getAllPessoas(user,"");
            user = (Usuario) array.get(0);

            if(user.getSenha().contains(txSenha.getText()))
            {
                try
                {
                    Stage stage = null;
                    Parent root = FXMLLoader.load(getClass().getResource("ui/TelaPrincipal.fxml"));
                    //stage.setMaximized(true);
                    Scene scene = new Scene(root);
                    stage.setScene(scene);
                   
                    stage.show();
                }
                catch(Exception e){System.out.println(e.getMessage());}
                
            }
                
            else
            {
                Alert alert = new Alert(Alert.AlertType.ERROR);
                alert.setTitle("Senha incorreta!");
                alert.setHeaderText("Verifique se a senha foi preenchida corretamente!");
                alert.showAndWait();
            }
        }
    }

    @FXML
    private void clkCancelar(ActionEvent event) {
        
    }
    public boolean permissao()
    {
        return acessou;
    }
    
    public static Usuario getUsuario()
    {
        return user;
    }
    
}
