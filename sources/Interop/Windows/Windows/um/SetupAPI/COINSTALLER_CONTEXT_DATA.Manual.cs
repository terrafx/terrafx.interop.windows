// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct COINSTALLER_CONTEXT_DATA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(COINSTALLER_CONTEXT_DATA32));
            }
            else
            {
                return (uint)(sizeof(COINSTALLER_CONTEXT_DATA64));
            }
        }
    }

    [FieldOffset(0)]
    public COINSTALLER_CONTEXT_DATA32 _value32;

    [FieldOffset(0)]
    public COINSTALLER_CONTEXT_DATA64 _value64;

    [UnscopedRef]
    public ref BOOL PostProcessing
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.PostProcessing;
            }
            else
            {
                return ref _value64.PostProcessing;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint InstallResult
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.InstallResult;
            }
            else
            {
                return ref _value64.InstallResult;
            }
        }
    }

    [NativeTypeName("PVOID")]
    [UnscopedRef]
    public ref void* PrivateData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.PrivateData;
            }
            else
            {
                return ref _value64.PrivateData;
            }
        }
    }
}
