// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using NUnit.Framework;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Validates manually ported DirectInput macros.</summary>
public static unsafe class DirectInputMacrosManualTests
{
    /// <summary>Object type, collection, and usage macros pack and extract their native bit fields.</summary>
    [Test]
    public static void TypeAndUsageMacrosPackValues()
    {
        Assert.That(DIDFT.DIDFT_MAKEINSTANCE(0x1234), Is.EqualTo(0x00123400u));
        Assert.That(DIDFT.DIDFT_GETTYPE(0x1234ABu), Is.EqualTo(0xAB));
        Assert.That(DIDFT.DIDFT_GETINSTANCE(0xABCD1234), Is.EqualTo((ushort)0xCD12));
        Assert.That(DIDFT.DIDFT_ENUMCOLLECTION(0x1234), Is.EqualTo(0x00123400u));
        Assert.That(DIEFT.DIEFT_GETTYPE(0x1234ABu), Is.EqualTo(0xAB));
        Assert.That(DirectX.DIMAKEUSAGEDWORD(0x1234, 0xABCD), Is.EqualTo(0x1234ABCDu));
        Assert.That(DirectX.GET_DIDEVICE_TYPE(0xABCD1234), Is.EqualTo(0x34));
        Assert.That(DirectX.GET_DIDEVICE_SUBTYPE(0xABCD1234), Is.EqualTo(0x12));
        Assert.That(DirectX.DIBUTTON_ANY(0x123), Is.EqualTo(0xFF004523u));
    }

    /// <summary>Joystick slider and POV offsets advance by native element sizes.</summary>
    [Test]
    public static void JoystickOffsetsMatchNativeLayout()
    {
        Assert.That(DIJOFS.DIJOFS_SLIDER(1), Is.EqualTo(DIJOFS.DIJOFS_SLIDER(0) + sizeof(int)));
        Assert.That(DIJOFS.DIJOFS_POV(3), Is.EqualTo(DIJOFS.DIJOFS_POV(0) + 3 * sizeof(uint)));
        Assert.That(DIJOFS.DIJOFS_SLIDER(0), Is.EqualTo(24U));
        Assert.That(DIJOFS.DIJOFS_POV(0), Is.EqualTo(32U));
    }

    /// <summary>Sequence comparison uses signed wraparound ordering and property IDs remain pointer encodings.</summary>
    [Test]
    public static void SequenceAndPropertyMacrosPreserveEncodings()
    {
        Assert.That(DirectX.DISEQUENCE_COMPARE(0x10, 0xFFFFFFF0), Is.EqualTo(32));
        Assert.That(DirectX.DISEQUENCE_COMPARE(0xFFFFFFF0, 0x10), Is.EqualTo(-32));
        Assert.That((nint)DirectX.MAKEDIPROP(4), Is.EqualTo((nint)4));
    }
}
