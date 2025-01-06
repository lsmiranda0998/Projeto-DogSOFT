/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.util;

import org.apache.commons.mail.DefaultAuthenticator;
import org.apache.commons.mail.SimpleEmail;

/**
 *
 * @author Aluno
 */
public class Email {

    public Email() {
    }
    
    public static boolean EnviarEmail (String dest, String rem, String titulo, String assunto)
    {
        try
        {
            SimpleEmail email = new SimpleEmail();
            email.setHostName("smtp.gmail.com");
            email.setSmtpPort(465);
            email.setAuthenticator(new DefaultAuthenticator(rem, "pass"));
            email.setSSLOnConnect(true);
            email.setFrom(rem);
            email.setSubject(titulo);
            email.setMsg(assunto);
            email.addTo(dest);
            email.send();
            return true;

        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
            return false;
        }
        
    }
    
}
