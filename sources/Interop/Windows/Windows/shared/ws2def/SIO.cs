// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SIO
{
    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_ASSOCIATE_HANDLE"]/*' />
    [NativeTypeName("#define SIO_ASSOCIATE_HANDLE _WSAIOW(IOC_WS2,1)")]
    public const uint SIO_ASSOCIATE_HANDLE = (0x80000000 | (0x08000000) | (1));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_ENABLE_CIRCULAR_QUEUEING"]/*' />
    [NativeTypeName("#define SIO_ENABLE_CIRCULAR_QUEUEING _WSAIO(IOC_WS2,2)")]
    public const int SIO_ENABLE_CIRCULAR_QUEUEING = (0x20000000 | (0x08000000) | (2));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_FIND_ROUTE"]/*' />
    [NativeTypeName("#define SIO_FIND_ROUTE _WSAIOR(IOC_WS2,3)")]
    public const int SIO_FIND_ROUTE = (0x40000000 | (0x08000000) | (3));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_FLUSH"]/*' />
    [NativeTypeName("#define SIO_FLUSH _WSAIO(IOC_WS2,4)")]
    public const int SIO_FLUSH = (0x20000000 | (0x08000000) | (4));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_GET_BROADCAST_ADDRESS"]/*' />
    [NativeTypeName("#define SIO_GET_BROADCAST_ADDRESS _WSAIOR(IOC_WS2,5)")]
    public const int SIO_GET_BROADCAST_ADDRESS = (0x40000000 | (0x08000000) | (5));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_GET_EXTENSION_FUNCTION_POINTER"]/*' />
    [NativeTypeName("#define SIO_GET_EXTENSION_FUNCTION_POINTER _WSAIORW(IOC_WS2,6)")]
    public const uint SIO_GET_EXTENSION_FUNCTION_POINTER = ((0x80000000 | 0x40000000) | (0x08000000) | (6));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_GET_QOS"]/*' />
    [NativeTypeName("#define SIO_GET_QOS _WSAIORW(IOC_WS2,7)")]
    public const uint SIO_GET_QOS = ((0x80000000 | 0x40000000) | (0x08000000) | (7));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_GET_GROUP_QOS"]/*' />
    [NativeTypeName("#define SIO_GET_GROUP_QOS _WSAIORW(IOC_WS2,8)")]
    public const uint SIO_GET_GROUP_QOS = ((0x80000000 | 0x40000000) | (0x08000000) | (8));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_MULTIPOINT_LOOPBACK"]/*' />
    [NativeTypeName("#define SIO_MULTIPOINT_LOOPBACK _WSAIOW(IOC_WS2,9)")]
    public const uint SIO_MULTIPOINT_LOOPBACK = (0x80000000 | (0x08000000) | (9));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_MULTICAST_SCOPE"]/*' />
    [NativeTypeName("#define SIO_MULTICAST_SCOPE _WSAIOW(IOC_WS2,10)")]
    public const uint SIO_MULTICAST_SCOPE = (0x80000000 | (0x08000000) | (10));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_SET_QOS"]/*' />
    [NativeTypeName("#define SIO_SET_QOS _WSAIOW(IOC_WS2,11)")]
    public const uint SIO_SET_QOS = (0x80000000 | (0x08000000) | (11));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_SET_GROUP_QOS"]/*' />
    [NativeTypeName("#define SIO_SET_GROUP_QOS _WSAIOW(IOC_WS2,12)")]
    public const uint SIO_SET_GROUP_QOS = (0x80000000 | (0x08000000) | (12));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_TRANSLATE_HANDLE"]/*' />
    [NativeTypeName("#define SIO_TRANSLATE_HANDLE _WSAIORW(IOC_WS2,13)")]
    public const uint SIO_TRANSLATE_HANDLE = ((0x80000000 | 0x40000000) | (0x08000000) | (13));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_ROUTING_INTERFACE_QUERY"]/*' />
    [NativeTypeName("#define SIO_ROUTING_INTERFACE_QUERY _WSAIORW(IOC_WS2,20)")]
    public const uint SIO_ROUTING_INTERFACE_QUERY = ((0x80000000 | 0x40000000) | (0x08000000) | (20));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_ROUTING_INTERFACE_CHANGE"]/*' />
    [NativeTypeName("#define SIO_ROUTING_INTERFACE_CHANGE _WSAIOW(IOC_WS2,21)")]
    public const uint SIO_ROUTING_INTERFACE_CHANGE = (0x80000000 | (0x08000000) | (21));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_ADDRESS_LIST_QUERY"]/*' />
    [NativeTypeName("#define SIO_ADDRESS_LIST_QUERY _WSAIOR(IOC_WS2,22)")]
    public const int SIO_ADDRESS_LIST_QUERY = (0x40000000 | (0x08000000) | (22));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_ADDRESS_LIST_CHANGE"]/*' />
    [NativeTypeName("#define SIO_ADDRESS_LIST_CHANGE _WSAIO(IOC_WS2,23)")]
    public const int SIO_ADDRESS_LIST_CHANGE = (0x20000000 | (0x08000000) | (23));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_QUERY_TARGET_PNP_HANDLE"]/*' />
    [NativeTypeName("#define SIO_QUERY_TARGET_PNP_HANDLE _WSAIOR(IOC_WS2,24)")]
    public const int SIO_QUERY_TARGET_PNP_HANDLE = (0x40000000 | (0x08000000) | (24));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_QUERY_RSS_PROCESSOR_INFO"]/*' />
    [NativeTypeName("#define SIO_QUERY_RSS_PROCESSOR_INFO _WSAIOR(IOC_WS2,37)")]
    public const int SIO_QUERY_RSS_PROCESSOR_INFO = (0x40000000 | (0x08000000) | (37));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_ADDRESS_LIST_SORT"]/*' />
    [NativeTypeName("#define SIO_ADDRESS_LIST_SORT _WSAIORW(IOC_WS2,25)")]
    public const uint SIO_ADDRESS_LIST_SORT = ((0x80000000 | 0x40000000) | (0x08000000) | (25));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_RESERVED_1"]/*' />
    [NativeTypeName("#define SIO_RESERVED_1 _WSAIOW(IOC_WS2,26)")]
    public const uint SIO_RESERVED_1 = (0x80000000 | (0x08000000) | (26));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_RESERVED_2"]/*' />
    [NativeTypeName("#define SIO_RESERVED_2 _WSAIOW(IOC_WS2,33)")]
    public const uint SIO_RESERVED_2 = (0x80000000 | (0x08000000) | (33));

    /// <include file='SIO.xml' path='doc/member[@name="SIO.SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER"]/*' />
    [NativeTypeName("#define SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER _WSAIORW(IOC_WS2,36)")]
    public const uint SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER = ((0x80000000 | 0x40000000) | (0x08000000) | (36));
}
