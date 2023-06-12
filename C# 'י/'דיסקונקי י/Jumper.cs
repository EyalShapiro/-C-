/*כל הזכויות שמורות להוצאת מבט לחלונות*/
public class Jumper
{

    private string id;
    private double record;
    private double jump1;
    private double jump2;
    private double jump3;

    public Jumper(string id)
    {
        this.id = id;
        this.record = 0;
        this.jump1 = 0;
        this.jump2 = 0;
        this.jump3 = 0;
    }
    public double GetRecord()
    {
        return record;
    }
    public double GetJump1()
    {
        return jump1;
    }
    public double GetJump2()
    {
        return jump2;
    }
    public double GetJump3()
    {
        return jump3;
    }
    public void SetRecord(double record)
    {
        this.record = record;
    }
    public void SetJump1(double jump1)
    {
        this.jump1 = jump1;
    }
    public void SetJump2(double jump2)
    {
        this.jump2 = jump2;
    }
    public void SetJump3(double jump3)
    {
        this.jump3 = jump3;
    }
    public override string ToString()
    {
        return " id: " + this.id + "  record:" + this.record + "  jump1:" + this.jump1 + "  jump2:" + this.jump2 + "  jump3:" + this.jump3;
    }
}
 