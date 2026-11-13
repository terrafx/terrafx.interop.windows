// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public static bool IN_CLASSA([NativeTypeName("ULONG")] uint address) => (address & 0x80000000u) == 0;

    public static bool IN_CLASSB([NativeTypeName("ULONG")] uint address) => (address & 0xc0000000u) == 0x80000000u;

    public static bool IN_CLASSC([NativeTypeName("ULONG")] uint address) => (address & 0xe0000000u) == 0xc0000000u;

    public static bool IN_CLASSD([NativeTypeName("ULONG")] uint address) => (address & 0xf0000000u) == 0xe0000000u;

    public static bool IN_MULTICAST([NativeTypeName("ULONG")] uint address) => IN_CLASSD(address);

    public static nuint SIZEOF_SOCKET_ADDRESS_LIST([NativeTypeName("ULONG")] uint addressCount)
        => unchecked((nuint)(sizeof(SOCKET_ADDRESS_LIST) - sizeof(SOCKET_ADDRESS)) + ((nuint)addressCount * (nuint)sizeof(SOCKET_ADDRESS)));

    public static uint _IO(int x, int y)
        => unchecked((uint)(IOC_VOID | (x << 8) | y));

    public static uint _IOR<T>(int x, int y) where T : unmanaged
        => unchecked((uint)(IOC_OUT | (((sizeof(T) & IOCPARM_MASK) << 16)) | (x << 8) | y));

    public static uint _IOW<T>(int x, int y) where T : unmanaged
        => (uint)IOC_IN | (((uint)sizeof(T) & (uint)IOCPARM_MASK) << 16) | ((uint)x << 8) | (uint)y;

    public static uint _WSAIO(int x, int y)
        => unchecked((uint)(IOC_VOID | x | y));

    public static uint _WSAIOR(int x, int y)
        => unchecked((uint)(IOC_OUT | x | y));

    public static uint _WSAIOW(int x, int y)
        => (uint)IOC_IN | (uint)x | (uint)y;

    public static uint _WSAIORW(int x, int y)
        => IOC_INOUT | (uint)x | (uint)y;

    public static nuint WSA_CMSGHDR_ALIGN([NativeTypeName("SIZE_T")] nuint length)
        => AlignSize(length, (nuint)sizeof(nuint));

    public static nuint WSA_CMSGDATA_ALIGN([NativeTypeName("SIZE_T")] nuint length)
        => AlignSize(length, (nuint)sizeof(nint));

    public static CMSGHDR* WSA_CMSG_FIRSTHDR(WSAMSG* message)
        => (message->Control.len >= sizeof(CMSGHDR)) ? (CMSGHDR*)message->Control.buf : null;

    public static CMSGHDR* WSA_CMSG_NXTHDR(WSAMSG* message, CMSGHDR* controlMessage)
    {
        if (controlMessage == null)
        {
            return WSA_CMSG_FIRSTHDR(message);
        }

        nuint nextHeader = unchecked((nuint)controlMessage + WSA_CMSGHDR_ALIGN(controlMessage->cmsg_len));
        nuint controlBufferEnd = unchecked((nuint)message->Control.buf + message->Control.len);
        nuint nextHeaderEnd = unchecked(nextHeader + (nuint)sizeof(CMSGHDR));

        return (nextHeaderEnd > controlBufferEnd) ? null : (CMSGHDR*)nextHeader;
    }

    public static byte* WSA_CMSG_DATA(CMSGHDR* controlMessage)
        => (byte*)((nuint)controlMessage + WSA_CMSGDATA_ALIGN((nuint)sizeof(CMSGHDR)));

    public static nuint WSA_CMSG_SPACE([NativeTypeName("SIZE_T")] nuint length)
        => unchecked(WSA_CMSGDATA_ALIGN((nuint)sizeof(CMSGHDR) + WSA_CMSGHDR_ALIGN(length)));

    public static nuint WSA_CMSG_LEN([NativeTypeName("SIZE_T")] nuint length)
        => unchecked(WSA_CMSGDATA_ALIGN((nuint)sizeof(CMSGHDR)) + length);

    private static nuint AlignSize(nuint value, nuint alignment)
        => unchecked((value + alignment - 1) & ~(alignment - 1));
}
