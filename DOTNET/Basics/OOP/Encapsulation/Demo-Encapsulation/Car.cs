public class Car
{
    int speed;

    public int Speed
    {
        get
        {           
            return speed;
        }
        set
        {
            if (value > 200)
                throw new ArgumentException("too fast");
            else if (value < 0)
                throw new ArgumentException("invalid speed");
            else
                speed = value;
        }
    }

    public void SetSpeed(int newSpeed)
    {
        if (newSpeed > 200)
            throw new ArgumentException("too fast");
        else if (newSpeed < 0)
            throw new ArgumentException("invalid speed");
        else
            speed = newSpeed;
    }
    public int GetSpeed()
    {
        return speed;
    }

}