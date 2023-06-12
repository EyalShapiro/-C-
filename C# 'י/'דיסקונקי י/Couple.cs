/* כל הזכויות שמורות להוצאת מבט לחלונות */
public class Couple
{

    private int num1;
    private int num2;

    public Couple(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public int GetNum1()
    {
        return num1;
    }

    public int GetNum2()
    {
        return num2;
    }

    public void SetNum1(int num1)
    {
        this.num1 = num1;
    }

    public void SetNum2(int num2)
    {
        this.num2 = num2;
    }

    public override string ToString()
    {
        return "num1: " + this.num1 + " num2: " + this.num2;
    }

}