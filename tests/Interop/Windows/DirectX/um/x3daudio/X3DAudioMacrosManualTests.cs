// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported X3DAudio default curves.</summary>
public static unsafe class X3DAudioMacrosManualTests
{
    /// <summary>The default linear curve points at the two native curve points.</summary>
    [Test]
    public static void DefaultLinearCurveHasTwoStablePoints()
    {
        X3DAUDIO_DISTANCE_CURVE curve = DirectX.X3DAudioDefault_LinearCurve;

        Assert.That(curve.PointCount, Is.EqualTo(2U));
        Assert.That(curve.pPoints[0].Distance, Is.EqualTo(0.0f));
        Assert.That(curve.pPoints[0].DSPSetting, Is.EqualTo(1.0f));
        Assert.That(curve.pPoints[1].Distance, Is.EqualTo(1.0f));
        Assert.That(curve.pPoints[1].DSPSetting, Is.EqualTo(0.0f));
    }
}
