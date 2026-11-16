// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTPAPI_EQUAL_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTPAPI_EQUAL_VERSION(HTTPAPI_VERSION version, ushort major, ushort minor)
        => (version.HttpApiMajorVersion == major) && (version.HttpApiMinorVersion == minor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTPAPI_GREATER_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTPAPI_GREATER_VERSION(HTTPAPI_VERSION version, ushort major, ushort minor)
        => (version.HttpApiMajorVersion > major)
        || ((version.HttpApiMajorVersion == major) && (version.HttpApiMinorVersion > minor));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTPAPI_LESS_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTPAPI_LESS_VERSION(HTTPAPI_VERSION version, ushort major, ushort minor)
        => (version.HttpApiMajorVersion < major)
        || ((version.HttpApiMajorVersion == major) && (version.HttpApiMinorVersion < minor));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTPAPI_VERSION_GREATER_OR_EQUAL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTPAPI_VERSION_GREATER_OR_EQUAL(HTTPAPI_VERSION version, ushort major, ushort minor)
        => !HTTPAPI_LESS_VERSION(version, major, minor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTP_EQUAL_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTP_EQUAL_VERSION(HTTP_VERSION version, ushort major, ushort minor)
        => (version.MajorVersion == major) && (version.MinorVersion == minor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTP_GREATER_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTP_GREATER_VERSION(HTTP_VERSION version, ushort major, ushort minor)
        => (version.MajorVersion > major)
        || ((version.MajorVersion == major) && (version.MinorVersion > minor));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTP_LESS_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTP_LESS_VERSION(HTTP_VERSION version, ushort major, ushort minor)
        => (version.MajorVersion < major)
        || ((version.MajorVersion == major) && (version.MinorVersion < minor));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTP_NOT_EQUAL_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTP_NOT_EQUAL_VERSION(HTTP_VERSION version, ushort major, ushort minor)
        => !HTTP_EQUAL_VERSION(version, major, minor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTP_GREATER_EQUAL_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTP_GREATER_EQUAL_VERSION(HTTP_VERSION version, ushort major, ushort minor)
        => !HTTP_LESS_VERSION(version, major, minor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTP_LESS_EQUAL_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTP_LESS_EQUAL_VERSION(HTTP_VERSION version, ushort major, ushort minor)
        => !HTTP_GREATER_VERSION(version, major, minor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTP_SET_VERSION"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void HTTP_SET_VERSION(ref HTTP_VERSION version, ushort major, ushort minor)
    {
        version.MajorVersion = major;
        version.MinorVersion = minor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HTTP_IS_NULL_ID([NativeTypeName("PHTTP_REQUEST_ID")] ulong* pid)
        => *pid == HTTP.HTTP_NULL_ID;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong HTTP_SET_NULL_ID([NativeTypeName("PHTTP_REQUEST_ID")] ulong* pid)
    {
        *pid = HTTP.HTTP_NULL_ID;
        return *pid;
    }
}
