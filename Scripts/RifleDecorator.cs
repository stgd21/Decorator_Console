﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class RifleDecorator : IRifle
{
    protected IRifle m_DecoratedRifle;

    public RifleDecorator(IRifle rifle)
    {
        m_DecoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return m_DecoratedRifle.GetAccuracy();
    }
}

public class WithScope : RifleDecorator
{
    private float m_ScopeAccuracy = 20f;

    public WithScope(IRifle rifle) : base(rifle)
    {

    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }
}

public class WithStabilizer : RifleDecorator
{
    private float m_StabilizerAccuracy = 10f;

    public WithStabilizer(IRifle rifle) : base(rifle)
    {

    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StabilizerAccuracy;
    }
}

public class WithLaser : RifleDecorator
{
    private float m_LaserAccuracy = 5f;

    public WithLaser(IRifle rifle) : base(rifle)
    {

    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_LaserAccuracy;
    }
}

public class WithStock : RifleDecorator
{
    private float m_StockAccuracy = 15f;

    public WithStock(IRifle rifle) : base(rifle)
    {

    }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StockAccuracy;
    }
}

