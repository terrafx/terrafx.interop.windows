// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates IPv4 class and Winsock control-code helpers.</summary>
    [Test]
    public static void WinsockAddressAndControlCodeMacrosTest()
    {
        Assert.That(IN_CLASSA(0x01000000), Is.True);
        Assert.That(IN_CLASSB(0x80000000), Is.True);
        Assert.That(IN_CLASSC(0xc0000000), Is.True);
        Assert.That(IN_CLASSD(0xe0000000), Is.True);
        Assert.That(IN_MULTICAST(0xe0000001), Is.True);
        Assert.That(IN_CLASSA(0x80000000), Is.False);

        Assert.That(_IO('x', 1), Is.EqualTo(0x20007801u));
        Assert.That(_IOR<uint>('x', 1), Is.EqualTo(0x40047801u));
        Assert.That(_IOW<uint>('x', 1), Is.EqualTo(0x80047801u));
        Assert.That(_WSAIO(IOC_WS2, 1), Is.EqualTo(0x28000001u));
        Assert.That(_WSAIOR(IOC_WS2, 1), Is.EqualTo(0x48000001u));
        Assert.That(_WSAIOW(IOC_WS2, 1), Is.EqualTo(0x88000001u));
        Assert.That(_WSAIORW(IOC_WS2, 1), Is.EqualTo(0xc8000001u));

        Assert.That(SIZEOF_SOCKET_ADDRESS_LIST(2), Is.EqualTo((nuint)(sizeof(SOCKET_ADDRESS_LIST) - sizeof(SOCKET_ADDRESS)) + (2u * (nuint)sizeof(SOCKET_ADDRESS))));
    }

    /// <summary>Validates ancillary-data alignment, sizing, and bounds helpers.</summary>
    [Test]
    public static void WinsockControlMessageMacrosTest()
    {
        byte* controlBuffer = stackalloc byte[64];
        WSAMSG message = new()
        {
            Control = new WSABUF
            {
                len = 64,
                buf = (sbyte*)controlBuffer,
            },
        };

        CMSGHDR* first = WSA_CMSG_FIRSTHDR(&message);
        Assert.That((nint)first, Is.EqualTo((nint)controlBuffer));
        Assert.That(WSA_CMSG_LEN(4), Is.EqualTo(WSA_CMSGDATA_ALIGN((nuint)sizeof(CMSGHDR)) + 4));
        Assert.That(WSA_CMSG_SPACE(4), Is.EqualTo(WSA_CMSGDATA_ALIGN((nuint)sizeof(CMSGHDR) + WSA_CMSGHDR_ALIGN(4))));
        Assert.That((nuint)WSA_CMSG_DATA(first) - (nuint)controlBuffer, Is.EqualTo(WSA_CMSGDATA_ALIGN((nuint)sizeof(CMSGHDR))));

        first->cmsg_len = WSA_CMSG_LEN(4);
        CMSGHDR* next = WSA_CMSG_NXTHDR(&message, first);
        Assert.That((nint)next, Is.Not.EqualTo(nint.Zero));

        nuint requiredLength = ((nuint)next - (nuint)controlBuffer) + (nuint)sizeof(CMSGHDR);
        message.Control.len = (uint)(requiredLength - 1);
        Assert.That((nint)WSA_CMSG_NXTHDR(&message, first), Is.EqualTo(nint.Zero));

        message.Control.len = 0;
        Assert.That((nint)WSA_CMSG_FIRSTHDR(&message), Is.EqualTo(nint.Zero));
    }
}
