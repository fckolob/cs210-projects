using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
public class Circle : Shape
{
    private double _radius = 0;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    { 
        double pi = Math.PI;
        return pi * _radius * _radius;
        
    }


}