/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.ui;

import cobrafxml.util.Email;
import com.jfoenix.controls.JFXTextField;
import java.net.URL;
import java.util.ResourceBundle;
import javafx.concurrent.Task;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TextArea;


/**
 * FXML Controller class
 *
 * @author Aluno
 */
public class TelaEmailController implements Initializable {

    @FXML
    private JFXTextField txTitulo;
    @FXML
    private JFXTextField txDestinario;
    @FXML
    private Button btnEmail;
    @FXML
    private TextArea txAssunto;
    @FXML
    private Button btnLimpar;
    public Email uteis = new Email();
    private static boolean resp;
    private Alert alert;

    /**
     * Initializes the controller class.
     */
    @Override
    public void initialize(URL url, ResourceBundle rb) {
        
        // TODO
    }    

    @FXML
    private void clkEnviar(ActionEvent event) {
         Task task = new Task<Void>()
        {
            @Override
            protected Void call() throws Exception {
                resp = uteis.EnviarEmail(txDestinario.getText(), "email", txTitulo.getText(), txAssunto.getText());
                if(resp)
                {
                    alert = new Alert(Alert.AlertType.INFORMATION);
                    alert.setTitle("E-mail enviado!");
                    alert.setHeaderText("O e-mail foi enviado para o destinatário com sucesso!");
                    alert.showAndWait();
                }
                else
                {
                    alert = new Alert(Alert.AlertType.ERROR);
                    alert.setTitle("E-mail não enviado!");
                    alert.setHeaderText("O e-mail não foi enviado, verifique se as infomação estão preenchidas corretamente!");
                    alert.showAndWait();
                }
                return null;
            }
        };
        Thread th = new Thread(task);
        th.setDaemon(true);
        th.start();     
    }

    @FXML
    private void clkLimpar(ActionEvent event) {
        txDestinario.clear();
        txTitulo.clear();
        txAssunto.clear();
    }
    
}
