using Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Labs
{
    interface Engine
    {
        string getInfo();
    }

    class ICE : Engine
    {
        private double volume;
        private int power;
        private int gas_consumption;
        public ICE() { }
        public ICE(double volume, int power, int gas_consumption)
        {
            this.volume = volume;
            this.power = power;
            this.gas_consumption = gas_consumption;
        }
        public ICE(ICE obj)
        {
            this.volume = obj.volume;
            this.power = obj.power;
            this.gas_consumption = obj.gas_consumption;
        }
        public string getInfo() => 
            $"Engine specification :" +
            $"\n\tVolume          = {this.volume}L" +
            $"\n\tPower           = {this.power}L/S" +
            $"\n\tGas Consumption = {this.gas_consumption}L/100km"
        ;

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            ICE other = (ICE)obj;
            return other == null ? false :
                this.power == other.power &&
                this.volume == other.volume &&
                this.gas_consumption == other.gas_consumption
            ;
        }
    }

    class ElectricEngine : Engine
    {
        private int power;
        private int voltage;
        private int phaseAmount;

        public ElectricEngine() { }
        public ElectricEngine(int power, int voltage, int phaseAmount)
        {
            this.power = power;
            this.voltage = voltage;
            this.phaseAmount = phaseAmount;
        }

        public string getInfo() =>
            $"Engine Specification :" +
            $"\n\tPower =        {this.power}" +
            $"\n\tVoltage =      {this.voltage}" +
            $"\n\tPhase Amount = {this.phaseAmount}"
        ;

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;
            ElectricEngine other = (ElectricEngine)obj;
            return other == null ? false :
                this.power == other.power &&
                this.voltage == other.voltage &&
                this.phaseAmount == other.phaseAmount
            ;
        }
    }

    class PerpetuumMobile : Engine
    {
        public string getInfo()
        {
            throw new Exception("It is not possible!");
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return (PerpetuumMobile)obj == null;
        }
    }

    static class Lab1
    {
        public static void lab1_func()
        {
            List<Engine> data = new List<Engine>() {
                new ICE(2.2d,13,11),
                new ICE(3d,20,15),
                new ElectricEngine(10,50,3),
                new ElectricEngine(10,50,3),
                new PerpetuumMobile()
            };

            data.MapIn((x) => {
                try
                {
                    Console.WriteLine(x.getInfo());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error occured : {e.Message}\n");
                }
                return x;
            });


            dynamic obj = new ElectricEngine(15, 50, 3);
            Console.WriteLine($"Late binding example\n: {obj.getInfo()}\n");


            Console.WriteLine($"Compare first from the list with second : {data[0].Equals(data[1])}");
            Console.WriteLine($"Compare third from the list with forth : {data[2].Equals(data[3])}");
            
        }
    }
}
