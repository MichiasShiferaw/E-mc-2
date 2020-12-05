//Scan all primitive data types
import java.util.Scanner;
/** 
 * This program finds e in e=mc^2 given mass.
 * @author Michias Shiferaw
 * @Version 2.0
 * @since 2020-02-18.
 */
 
public class Einstein {
  
  public static void main(String[] args) {
    
    //Asking for question
    Scanner input = new Scanner(System.in);
    System.out.println("Please enter a mass (kg).");
      
    //place the user's input in a specified variable
    double mass = input.nextDouble();
    try { 
      if (mass >= 0) {
        //Recognize a constant
        double speedOfLight = (299792458);
     
        //process of calculating the energy used and also converting into Kiloton bombs
        final double energy = mass * Math.pow(299792458,2);
        final double kilotonE =(int)( energy * 0.00000000000023901);
     
        //output
        System.out.println("This mass releases " + energy + "J of energy.");
        System.out.println(" " + mass + "kg can also be equivalent to " + kilotonE + "kt bombs.");
     
      } else {
        System.err.println("Not valid input");
        System.out.println("Mass can only be negative if it is being repelled by gravity.");
      }
    } catch (NumberFormatException nfe) {
      System.err.println("Invalid input!");
    }
       
    System.out.println();
    System.out.println("Bye Bye!");
  }
  
}
