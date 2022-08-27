// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_PROPSHEETPAGE_REQUEST
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_PROPSHEETPAGE_REQUEST32));
            }
            else
            {
                return (uint)(sizeof(SP_PROPSHEETPAGE_REQUEST64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_PROPSHEETPAGE_REQUEST32 _value32;

    [FieldOffset(0)]
    public SP_PROPSHEETPAGE_REQUEST64 _value64;

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.cbSize;
            }
            else
            {
                return ref _value64.cbSize;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint PageRequested
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.PageRequested;
            }
            else
            {
                return ref _value64.PageRequested;
            }
        }
    }

    [UnscopedRef]
    public ref HDEVINFO DeviceInfoSet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.DeviceInfoSet;
            }
            else
            {
                return ref _value64.DeviceInfoSet;
            }
        }
    }

    // The following isn't exposed as there isn't a good way to
    // convert from ref SP_DEVINFO_DATA32* to ref SP_DEVINFO_DATA*
    //
    // [NativeTypeName("PSP_DEVINFO_DATA")]
    // public ref SP_DEVINFO_DATA* DeviceInfoData;
}
