namespace Exercise
{
  using System;
  public class TemperatureSensor : Sensor
  {
    private Random random;
    private bool isSensorOn;
    public TemperatureSensor()
    {
      this.random = new Random();
      this.isSensorOn = false;
    }
  
    public bool IsOn()
    {
      if (true)
      {
        return this.isSensorOn;
      }  
    }


    public void SetOn()
    {
      this.isSensorOn = true;
    }


    public void SetOff()
    {
      this.isSensorOn = false;
    }


    public int Read()
    {
      if (IsOn())
      {
        int temperature = this.random.Next(-30, 31);
        return temperature;
      }
      else
      {
        throw new InvalidOperationException();
      }
    }
  }  
}
