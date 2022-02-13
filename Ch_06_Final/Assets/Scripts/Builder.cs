using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBuilder
{
    void BuildFrame();
    void BuildMotor();
    void BuildWeapon();

    SupportAlly GetAlly();
}

public class TankBuilder : IBuilder
{
    private SupportAlly _ally;

    public TankBuilder()
    {
        _ally = new SupportAlly(AllyType.Tank);
    }

    public void BuildFrame()
    {
        _ally.AddComponent("TankBody");
    }

    public void BuildMotor()
    {
        _ally.AddComponent("TankTreads");
    }

    public void BuildWeapon()
    {
        _ally.AddComponent("TankWeapon");
    }

    public SupportAlly GetAlly()
    {
        return _ally;
    }
}

public class BomberBuilder : IBuilder
{
    private SupportAlly _ally;

    public BomberBuilder()
    {
        _ally = new SupportAlly(AllyType.Bomber);
    }

    public void BuildFrame()
    {
        _ally.AddComponent("Titanium hull");
    }

    public void BuildMotor()
    {
        _ally.AddComponent("Prop engines");
    }

    public void BuildWeapon()
    {
        _ally.AddComponent("Twin 50 cals");
    }

    public SupportAlly GetAlly()
    {
        return _ally;
    }
}