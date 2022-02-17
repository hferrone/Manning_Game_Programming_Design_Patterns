using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuilder    
{
    IBuilder BuildFrame();    
    IBuilder BuildMotor();    
    IBuilder BuildWeapon();    

    SupportAlly GetAlly();    
}

public class TankBuilder : IBuilder    
{
    private SupportAlly _ally;    

    public TankBuilder()    
    {
        _ally = new SupportAlly("Tank");    
    }

    public IBuilder BuildFrame()    
    {
        _ally.AddComponent("Steel Frame");
        return this;
    }

    public IBuilder BuildMotor()    
    {
        _ally.AddComponent("Heavy Treads");
        return this;
    }

    public IBuilder BuildWeapon()    
    {
        _ally.AddComponent("Mortar");
        return this;
    }

    public SupportAlly GetAlly()    
    {
        return _ally;   
    }
}

public class DroneBuilder : IBuilder    
{
    private SupportAlly _ally;    

    public DroneBuilder()    
    {
        _ally = new SupportAlly("Drone");    
    }

    public IBuilder BuildFrame()
    {
        _ally.AddComponent("Titanium Hull");
        return this;
    }

    public IBuilder BuildMotor()    
    {
        _ally.AddComponent("Fiberglass Wings");
        return this;
    }

    public IBuilder BuildWeapon()    
    {
        _ally.AddComponent("Missiles");
        return this;
    }

    public SupportAlly GetAlly()    
    {
        return _ally;    
    }
}
