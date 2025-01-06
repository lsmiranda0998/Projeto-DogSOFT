/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml;

import cobrafxml.db.cobradb.Banco;
import cobrafxml.db.cobradb.db.entidades.Usuario;
import cobrafxml.ui.LoginController;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

/**
 *
 * @author Aluno
 */
public class CobraFXML extends Application {
    
    @Override
    public void start(Stage stage) throws Exception {
        Parent root = FXMLLoader.load(getClass().getResource("ui/TelaPrincipal.fxml"));
        //stage.setMaximized(true);
        
        Scene scene = new Scene(root);
        
        stage.setScene(scene);
        stage.show();
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Usuario user;
        user = LoginController.getUsuario();
        if(Banco.conectar())
        {
              System.out.println("Conectado com sucesso!");
              launch(args);
         }
        else
         {
             if (Banco.criarBD("cobra"))
             {
                 if (Banco.criarTabelas("scripts/tables.sql","cobra"))
                    System.out.println("Base de dados instalada. Execute novamente o sistema");
                 else    
                    System.out.println("Erro ao criar tabelas da base de dados"+Banco.getCon().getMensagemErro());
                 
             }       
             else    
               System.out.println("Erro ao criar base de dados"+Banco.getCon().getMensagemErro());
         }
    }
    
}
