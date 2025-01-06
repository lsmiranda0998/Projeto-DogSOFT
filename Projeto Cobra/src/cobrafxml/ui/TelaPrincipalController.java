/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.ui;

import cobrafxml.db.cobradb.Banco;
import java.io.IOException;
import java.net.URL;
import java.sql.ResultSet;
import java.util.HashMap;
import java.util.Map;
import java.util.ResourceBundle;
import java.util.logging.Level;
import java.util.logging.Logger;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.geometry.Bounds;
import javafx.scene.Parent;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ScrollPane;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Region;
import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JRResultSetDataSource;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.view.JasperViewer;

/**
 *
 * @author Aluno
 */
public class TelaPrincipalController implements Initializable {
    
    @FXML
    private ScrollPane pnCentral;
    @FXML
    private Label itOrigem;
    @FXML
    private Label itCobrador;
    @FXML
    private Label itDevedor;
    @FXML
    private Label itSituacao;
    @FXML
    private Label itnovaCobranca;
    @FXML
    private Label itUsuario;
    @FXML
    private Label itBackup;
    @FXML
    private Label clkitRestore;
    @FXML
    private Label itrelCidades;
    @FXML
    private Label itrelCidadesFiltro;
    @FXML
    private Label itrelDevedores;
    @FXML
    private Label itrelCobradores;
    @FXML
    private Label itrelLembretes;

    @Override
    public void initialize(URL url, ResourceBundle rb) {
        
        // TODO
    }    
    
private void gerarRelatorio(String sql, String relat, String titulotela, Map param)
{
        try {  //sql para obter os dados para o relatorio
            ResultSet rs = Banco.getCon().consultar(sql);
            //implementação da interface JRDataSource para DataSource ResultSet
            JRResultSetDataSource jrRS = new JRResultSetDataSource(rs);
            //preenchendo e chamando o relatório
            String jasperPrint = JasperFillManager.fillReportToFile(relat, param, jrRS);
            JasperViewer viewer = new JasperViewer(jasperPrint, false, false);
            
            viewer.setExtendedState(JasperViewer.MAXIMIZED_BOTH);//maximizado
            viewer.setTitle(titulotela);
            viewer.setVisible(true);
        } catch (JRException erro) {
            System.out.println(erro);
        }
    }


    private void center(Bounds viewPortBounds, Parent centeredNode) {
        double width = viewPortBounds.getWidth();    double height = viewPortBounds.getHeight();
        double pwidth=((Region)centeredNode).getPrefWidth();
        double pheight=((Region)centeredNode).getPrefHeight();
        if (width > pwidth) {  centeredNode.setTranslateX((width - pwidth) / 2); } 
        else {   centeredNode.setTranslateX(0); }
        if (height > pheight) {  centeredNode.setTranslateY((height - pheight) / 2);
        } else {   centeredNode.setTranslateY(0);
        }
    }


    @FXML
    private void clkItemOrigem(MouseEvent event) {
        try
        {
         Parent tela = FXMLLoader.load(getClass().getResource("TelaOrigem.fxml"));
        
         pnCentral.setContent(tela);  // é um scrollpane
         
         // centralizando a tela no scroolpane
         this.center(pnCentral.getViewportBounds(), tela);
         pnCentral.viewportBoundsProperty().addListener((observable, oldValue, newValue) -> {
            this.center(newValue, tela);
        });
        }
        catch(Exception e){System.out.println(e);}

    }

    @FXML
    private void clkitemCobrador(MouseEvent event) {
        try
        {
         Parent tela = FXMLLoader.load(getClass().getResource("TelaCobrador.fxml"));
         pnCentral.setContent(tela);  // é um scrollpane
         
         // centralizando a tela no scroolpane
         this.center(pnCentral.getViewportBounds(), tela);
         pnCentral.viewportBoundsProperty().addListener((observable, oldValue, newValue) -> {
            this.center(newValue, tela);
        });
        }
        catch(Exception e){System.out.println(e);}
        
    }

    @FXML
    private void clkitemDevedor(MouseEvent event) {      
            try
            {
              Parent tela = FXMLLoader.load(getClass().getResource("TelaDevedor.fxml"));
         pnCentral.setContent(tela);  // é um scrollpane
         
         // centralizando a tela no scroolpane
         this.center(pnCentral.getViewportBounds(), tela);
         pnCentral.viewportBoundsProperty().addListener((observable, oldValue, newValue) -> {
            this.center(newValue, tela);
        });  
            }
         
        
        catch(Exception e){System.out.println(e);}
        
    }

    @FXML
    private void clkitemSituacao(MouseEvent event) {
        try
            {
              Parent tela = FXMLLoader.load(getClass().getResource("TelaSituacao.fxml"));
         pnCentral.setContent(tela);  // é um scrollpane
         
         // centralizando a tela no scroolpane
         this.center(pnCentral.getViewportBounds(), tela);
         pnCentral.viewportBoundsProperty().addListener((observable, oldValue, newValue) -> {
            this.center(newValue, tela);
        });  
            }
         catch(Exception e){System.out.println(e);}
        
    }

    @FXML
    private void clkitemNovaCobranca(MouseEvent event) {
        try
            {
              Parent tela = FXMLLoader.load(getClass().getResource("TelaCobranca.fxml"));
         pnCentral.setContent(tela);  // é um scrollpane
         
         // centralizando a tela no scroolpane
         this.center(pnCentral.getViewportBounds(), tela);
         pnCentral.viewportBoundsProperty().addListener((observable, oldValue, newValue) -> {
            this.center(newValue, tela);
        });  
            }
         catch(Exception e){System.out.println(e);}
    }

    @FXML
    private void clkitemUsuario(MouseEvent event) {
        try
            {
                Parent tela = FXMLLoader.load(getClass().getResource("TelaUsuario.fxml"));
                pnCentral.setContent(tela);  // é um scrollpane
                // centralizando a tela no scroolpane
                this.center(pnCentral.getViewportBounds(), tela);
                pnCentral.viewportBoundsProperty().addListener((observable, oldValue, newValue) -> {
            this.center(newValue, tela);
        });  
            }
         catch(Exception e){System.out.println(e);}
        
    }

    @FXML
    private void clkitemBackup(MouseEvent event) {
        Banco.realizaBackup();
    }

    @FXML
    private void clkitemRestore(MouseEvent event) {
        Banco.realizaRestore();
    }

    @FXML
    private void clkitemrelCidades(MouseEvent event) {
        String SQL = "select c.cid_cod,c.cid_nome,e.est_sgl from cidade as c,estado as e where c.est_cod = e.est_cod order by c.cid_nome";
        gerarRelatorio (SQL,"Relatorios/RelCidadesSimples.jasper","Relatório de Cidades",null);
        
    }

    @FXML
    private void clkitemrelCidadesFiltro(MouseEvent event) {
        int codestado=2;
        String nomeestado="Alagoas";
        Map param=new HashMap();
        param.put("estado", nomeestado);
        String sql="select c.cid_cod, c.cid_nome, c.est_cod, e.est_sgl from cidade as c,estado as e where c.est_cod=e.est_cod and c.est_cod="+codestado+" order by c.cid_nome";                
        gerarRelatorio(sql,"relatorios/RelCidades.jasper", "Relatório de cidades por estado",param);
        
    }

    @FXML
    private void clkitemrelDevedores(MouseEvent event) {
         String SQL = "select dev_nome,dev_cpf,dev_cep,dev_email from devedor order by dev_nome";
         gerarRelatorio (SQL,"Relatorios/relaDevedoresjrxml.jasper","Relatório de Devedores",null);
        
    }

    @FXML
    private void clkitemrelCobradores(MouseEvent event) {
        String SQL = "select cbr_nome,cbr_telefone,cbr_email from cobrador";
        gerarRelatorio (SQL,"Relatorios/relCobradores.jasper","Relatório de Cobradores",null);
    }

    @FXML
    private void clkitemrelLembretes(MouseEvent event) {
        try
            {
                Parent tela = FXMLLoader.load(getClass().getResource("TelaLembretes.fxml"));
                pnCentral.setContent(tela);  // é um scrollpane
                // centralizando a tela no scroolpane
                this.center(pnCentral.getViewportBounds(), tela);
                pnCentral.viewportBoundsProperty().addListener((observable, oldValue, newValue) -> {
            this.center(newValue, tela);
        });  
            }
         catch(Exception e){System.out.println(e);}
    }   
}
