/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package demo14_serviceweb_javaclient;

/**
 *
 * @author 1795545
 */
public class Demo14_ServiceWeb_JavaClient {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
     try{
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap();
        //todo initialize WS operation arguments here
        double a = 15.0d;
        double b = 8.3d;
        //TODO process result here
        double result = port.calculSoustraction(a, b);
        System.out.println("Resultat de la soustraction = "+result);
    }catch(Exception ex){
        //
    }

    }
}
