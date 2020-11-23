package equacaodosegundograu;

import static java.lang.Math.sqrt;

/**
 *
 * @author Joatan
 */

// 6x^2+3x+1=0
// a = 6, b = 3 , c = 1
public class EquacaoDoSegundoGrau {
    public static void main(String[] args) {
        double x1, x2;
        int delta;
        delta = 3*3 - 4 * 6 * 1;
        x1 =(double) -3 + sqrt(delta)/(2*6);
        x2 = (double) -3 - sqrt(delta)/(2*6);
        System.out.println("Delta : " + delta);
        System.out.println("x1: " + x1);
        System.out.println("x2: " + x2);
    }
    
}
