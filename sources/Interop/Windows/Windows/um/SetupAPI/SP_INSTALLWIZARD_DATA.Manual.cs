// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_INSTALLWIZARD_DATA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_INSTALLWIZARD_DATA32));
            }
            else
            {
                return (uint)(sizeof(SP_INSTALLWIZARD_DATA64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_INSTALLWIZARD_DATA32 _value32;

    [FieldOffset(0)]
    public SP_INSTALLWIZARD_DATA64 _value64;

    public ref SP_CLASSINSTALL_HEADER ClassInstallHeader
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Unsafe.As<SP_CLASSINSTALL_HEADER32, SP_CLASSINSTALL_HEADER>(ref _value32.ClassInstallHeader), 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Unsafe.As<SP_CLASSINSTALL_HEADER64, SP_CLASSINSTALL_HEADER>(ref _value64.ClassInstallHeader), 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint Flags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Flags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Flags, 1));
            }
        }
    }

    [NativeTypeName("HPROPSHEETPAGE [20]")]
    public Span<HPROPSHEETPAGE> DynamicPages
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return _value32.DynamicPages.AsSpan();
            }
            else
            {
                return _value64.DynamicPages.AsSpan();
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint NumDynamicPages
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.NumDynamicPages, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.NumDynamicPages, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint DynamicPageFlags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.DynamicPageFlags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.DynamicPageFlags, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint PrivateFlags
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.PrivateFlags, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.PrivateFlags, 1));
            }
        }
    }

    public ref LPARAM PrivateData
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.PrivateData, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.PrivateData, 1));
            }
        }
    }

    public ref HWND hwndWizardDlg
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hwndWizardDlg, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hwndWizardDlg, 1));
            }
        }
    }

}
