/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package servicewebage_client;

import java.util.Date;
import java.util.Scanner;

/**
 *
 * @author 1795545
 */
public class ServiceWebAge_Client {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        
        try {
            
            Scanner sc = new Scanner(System.in);
            System.out.println("Entrer Votre Date de Naissance pour afficher l'activité:dd-mm-YYYY");
            String dateStr = sc.nextLine();
            String[] date = dateStr.split("-");
            int age = Integer.parseInt(date[2]);
            
            org.tempuri.WebServiceAgeActivity service = new org.tempuri.WebServiceAgeActivity();
            org.tempuri.WebServiceAgeActivitySoap port = service.getWebServiceAgeActivitySoap();
            
            String msg = port.messageAnneChoisir(age);
            System.out.println(msg);

        } catch (Exception ex) {
            //
        }
    }

}
