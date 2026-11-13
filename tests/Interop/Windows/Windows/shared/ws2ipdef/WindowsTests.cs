// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.CompilerServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates IPv6 equality, socket port, and variable-size filter helpers.</summary>
    [Test]
    public static void Ws2IpDefHelpersTest()
    {
        IN6_ADDR left = default;
        IN6_ADDR right = default;
        left.s6_bytes[15] = 1;
        right.s6_bytes[15] = 1;

        Assert.That(IN6_ARE_ADDR_EQUAL(&left, &right), Is.EqualTo((byte)1));
        right.s6_bytes[15] = 2;
        Assert.That(IN6_ARE_ADDR_EQUAL(&left, &right), Is.EqualTo((byte)0));

        SOCKADDR_STORAGE storage = default;
        ((SOCKADDR_IN*)&storage)->sin_port = 0x1234;
        Assert.That(SS_PORT(&storage), Is.EqualTo((ushort)0x1234));

        Assert.That(IP_MSFILTER_SIZE(3), Is.EqualTo((nuint)(Unsafe.SizeOf<IP_MSFILTER>() - Unsafe.SizeOf<IN_ADDR>()) + (3u * (nuint)Unsafe.SizeOf<IN_ADDR>())));
        Assert.That(GROUP_FILTER_SIZE(3), Is.EqualTo((nuint)(Unsafe.SizeOf<GROUP_FILTER>() - Unsafe.SizeOf<SOCKADDR_STORAGE>()) + (3u * (nuint)Unsafe.SizeOf<SOCKADDR_STORAGE>())));
    }
}
