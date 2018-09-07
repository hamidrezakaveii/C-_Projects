/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package control;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;


/**
 *
 * @author 1795545
 */
public class main {

    public static void main(String args[]) {
        
        Acitivity act = new Acitivity();
        
        
        org.tempuri.Service1 service = new org.tempuri.Service1();
        org.tempuri.IService1 port = service.getBasicHttpBindingIService1();

        //XMLGregorianCalendar date = new
        try {
            //Current Date
            GregorianCalendar gc = new GregorianCalendar();
            Date currentdate = new Date();
            gc.setTime(currentdate);
            XMLGregorianCalendar gCurrDate = DatatypeFactory.newInstance().newXMLGregorianCalendar(gc);

            //My Date
            GregorianCalendar mygc = new GregorianCalendar();
            SimpleDateFormat format = new SimpleDateFormat("yyyy-MM-dd");
            String dateString = format.format(new Date());
            Date date = format.parse("2009-12-31");
            mygc.setTime(date);
            XMLGregorianCalendar gMyDate = DatatypeFactory.newInstance().newXMLGregorianCalendar(mygc);

            System.out.println(gCurrDate);
            System.out.println("*************************");
            System.out.println(gMyDate);
            
            String msg = port.messageAnneChoisir("", "", "", gCurrDate, gMyDate);
            
            System.out.println(msg);

        } catch (DatatypeConfigurationException ex) {
            Logger.getLogger(main.class.getName()).log(Level.SEVERE, null, ex);
        } catch (ParseException ex) {
            Logger.getLogger(main.class.getName()).log(Level.SEVERE, null, ex);
        }

        //port.messageAnneChoisir(machineName, machinIP, username, dateTime, anne);
    }

}
