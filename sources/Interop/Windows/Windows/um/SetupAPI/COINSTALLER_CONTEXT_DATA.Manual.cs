// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

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

    public ref BOOL PostProcessing
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.PostProcessing, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.PostProcessing, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint InstallResult
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.InstallResult, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.InstallResult, 1));
            }
        }
    }

    [NativeTypeName("PVOID")]
    public ref void* PrivateData
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).PrivateData;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).PrivateData;
            }
        }
    }
}
