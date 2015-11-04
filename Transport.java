/**
 * Created by sf2013 on 22.04.15.
 */
public class Transport {
    public static void main (String[] args) {
        Car [] myCar = new Car[4];
        myCar[0] = new Car();
        myCar[1] = new PassengerCar();
        myCar[2] = new Jeep();
        myCar[3] = new Chevrolet();

        for (Car car: myCar) {
            car.introdution();
        }
    }
}
