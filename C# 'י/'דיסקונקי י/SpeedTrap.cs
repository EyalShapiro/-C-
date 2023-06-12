public class SpeedTrap
{
    private int cars;
    private int code;
    private int road;
    private int speed;
    public SpeedTrap(int code,int road, int speed)
    {
        this.cars=0;
        this.code=code;
        this.road=road;
        this.speed=speed;
    }
    public int GetCode()
    {
        return this.code;
    }
    public int GetSpeed()
    {
        return this.speed;
    }
    public int GetCars()
    {
        return this.cars;
    }
    public int GetRoad()
    {
        return this.road;
    }
    public void SetSpeed(int speed)
    {
        this.speed=speed;
    }
    public void SetCars(int cars)
    {
        this.cars=cars;
    }
    public override ToString()
    {
        return string.Format("the code is: {0} the road number is: {1} the maximum speed was: {2} the number of cars are:{3}",this.code,this.road,this.speed,this.cars);
    }
}