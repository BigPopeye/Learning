public class Body {
    public double xxPos; //Its current x position
    public double yyPos; //Its current y position
    public double xxVel; //Its current velocity in the x direction
    public double yyVel; //Its current velocity in the y direction
    public double mass; //Its mass
    public String imgFileName; //The name of the file that corresponds to the image that depicts the body (for example, jupiter.gif)
    public static final double G = 6.67e-11;

    public Body(double xP, double yP, double xV, double yV, double m, String img){
        xxPos = xP;
        yyPos = yP;
        xxVel = xV;
        yyVel = yV;
        mass = m;
        imgFileName = img;
    }

    public Body(Body b){
        xxPos = b.xxPos;
        yyPos = b.yyPos;
        xxVel = b.xxVel;
        yyVel = b.yyVel;
        mass = b.mass;
        imgFileName = b.imgFileName;
    }
    /* Calculates the distance between two Bodys.
    * This method will take in a single Body and should return a double equal to
    * the distance between the supplied body and the body that is doing the calculation.*/
    public double calcDistance(Body b){
        double dis;
        dis = Math.sqrt(Math.pow((this.xxPos-b.xxPos),2) + Math.pow((this.yyPos-b.yyPos),2));
        return dis;
    }

    /* returns a double describing the force exerted on this body by the given body*/
    public double calcForceExertedBy(Body b){
        double f = G * this.mass * b.mass / Math.pow(calcDistance(b),2);
        return f;
    }

    /* describe the force exerted in the X directions*/
    public double calcForceExertedByX(Body b){
        double fx = calcForceExertedBy(b) * (b.xxPos - this.xxPos) / calcDistance(b);
        return fx;
    }

    /* describe the force exerted in the Y directions*/
    public double calcForceExertedByY(Body b){
        double fy = calcForceExertedBy(b) * (b.yyPos - this.yyPos) /calcDistance(b);
        return fy;
    }

    /*calculates the net X and net Y force exerted by all bodies in that array upon the current Body*/
    public double calcNetForceExertedByX(Body[] bodies){
        double fnx = 0.0;
        for (Body b:bodies){
            if(this.equals(b)){
                continue;
            }else{
                fnx += calcForceExertedByX(b);
            }
        }
        return fnx;
    }

    public double calcNetForceExertedByY(Body[] bodies){
        double fny = 0.0;
        for (Body b:bodies){
            if(this.equals(b)){
                continue;
            }else{
                fny += calcForceExertedByY(b);
            }
        }
        return fny;
    }

    public void update(double t, double fnx, double fny){
        /* Step 1: calculate the this body's net acceleration*/
        double anx = fnx / this.mass;
        double any = fny / this.mass;

        /* Step 2: calculate this body's new velocity */
        this.xxVel = this.xxVel + t * anx;
        this.yyVel = this.yyVel + t * any;

        /* Step 3: calculate the new position of this body*/
        xxPos = xxPos + t * this.xxVel;
        yyPos = yyPos + t * this.yyVel;
    }

    public void draw(){
        StdDraw.enableDoubleBuffering();
        StdDraw.picture(xxPos,yyPos,imgFileName);
        StdDraw.show();
//        StdDraw.pause(2000);
    }
}
