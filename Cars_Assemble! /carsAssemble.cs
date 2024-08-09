using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed <= 0)
        {
            return 0.0;
        }
        else if (speed <= 4)
        {
            return 1.0;
        }
        else if (speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed == 10)
        {
            return 0.77;
        }
        else
        {
            return 0.0; 
        }
    }
           
    public static double ProductionRatePerHour(int speed)
    {
        double sucesso = SuccessRate(speed );
        double result = sucesso * 221;
        double result_ = result * speed;
        
        return result_;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        int carro = (speed * 221) / 60;
            return carro;
    }
}
