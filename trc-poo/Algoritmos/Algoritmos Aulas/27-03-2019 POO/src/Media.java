/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.util.Scanner;
/**
 *
 * @author grachet
 */
public class Media {
    public static void main(String[]args){
        float d, t, v;
        Scanner read = new Scanner(System.in);
        
        System.out.print("Quantos KM o carro percorreu?: ");
        d = read.nextFloat();
        while (d < 0){
            System.out.println("");
            System.out.println("Não existe distância negativa.");
            System.out.print("Quantos KM o carro percorreu?: ");
            d = read.nextFloat();
        }
        
        System.out.print("Percorreu " + d+ " Km em quantas horas?: ");
        t = read.nextFloat();
        while (t <= 0) {
            System.out.println("");
            System.out.println("Só existem horas positivas");
            System.out.print("Percorreu " + d+ " Km em quantas horas?: ");
            t = read.nextFloat();
        }
        
        v = (float)(d/t);
        System.out.println("");
        System.out.println("A velocidade média foi: " + v + " km/h");
        
        System.out.printf("A velocidade média foi: %f km/h", v);
    }
}
