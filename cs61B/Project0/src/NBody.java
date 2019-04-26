import java.util.Scanner;

public class NBody {
    /* read the radius of the planes in the given file*/
    public static double readRadius(String filesrc){
        In in = new In(filesrc);
        int numOfPlanes = in.readInt();
        double radiusOfUniverse = in.readDouble();
        return radiusOfUniverse;
    }

    public static Body[] readBodies(String filesrc){
        In in = new In(filesrc);
        int numOfPlanes = in.readInt();
        double radiusOfUniverse = in.readDouble();
        Body[] bodies = new Body[numOfPlanes];
        for (int i = 0;i < numOfPlanes; i++) {
            bodies[i] = new Body(in.readDouble(),in.readDouble(),in.readDouble(),in.readDouble(),in.readDouble(),"images/"+in.readString());
        }
        return bodies;
    }

    public static void main(String[] args) {

        /*instead using StdIn which need command line args.I replace it with Scanner*/
        Scanner keyboard = new Scanner(System.in);
        System.out.println("Enter Animation Time: ");
        double T = keyboard.nextDouble();

        System.out.println("Enter the time period: ");
        double dt = keyboard.nextDouble();

        //double T = Double.parseDouble(args[0]);
        //double dt = Double.parseDouble(args[1]);
        System.out.println("enter the filename you want to read: ");
        String fileplanes = keyboard.next();

        double radius = readRadius(fileplanes);
        Body[] planes = readBodies(fileplanes);
//        In in = new In(fileplanes);
        int numOfPlanes = planes.length;

        double time = 0;
        while (time < T){
            double xForces[] = new double[numOfPlanes];
            double yForces[] = new double[numOfPlanes];
            /*Calculate the net x and y forces for each Body, storing these in the xForces and yForces arrays respectively.*/
            for (int i = 0; i < numOfPlanes; i++) {
                xForces[i] = planes[i].calcNetForceExertedByX(planes);
                yForces[i] = planes[i].calcNetForceExertedByY(planes);
            }

            /*After calculating the net forces for every Body, call update on each of the Bodys. This will update each body’s position, velocity, and acceleration.*/
            for (int i = 0; i < numOfPlanes; i++) {
                planes[i].update(dt,xForces[i],yForces[i]);
            }
            /*Draw the background image.*/
            String backgroundFile = "images/starfield.jpg";
            StdDraw.enableDoubleBuffering();
            StdDraw.setScale(-radius, radius);
            StdDraw.clear();
            StdDraw.picture(0, 0, backgroundFile);
            StdDraw.show();

            /*Draw planes into the canvas*/
            for(Body plane : planes){
                plane.draw();
            }

            StdDraw.show();
            StdDraw.pause(10);

            time += dt;
        }

        StdOut.printf("%d\n", planes.length);
        StdOut.printf("%.2e\n", radius);
        for (int i = 0; i < planes.length; i++) {
            StdOut.printf("%11.4e %11.4e %11.4e %11.4e %11.4e %12s\n",
                    planes[i].xxPos, planes[i].yyPos, planes[i].xxVel,
                    planes[i].yyVel, planes[i].mass, planes[i].imgFileName);
        }

    }
}
