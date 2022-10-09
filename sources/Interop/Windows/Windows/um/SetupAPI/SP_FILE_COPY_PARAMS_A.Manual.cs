// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_FILE_COPY_PARAMS_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_FILE_COPY_PARAMS32_A));
            }
            else
            {
                return (uint)(sizeof(SP_FILE_COPY_PARAMS64_A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_FILE_COPY_PARAMS32_A _value32;

    [FieldOffset(0)]
    public SP_FILE_COPY_PARAMS64_A _value64;

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

    [UnscopedRef]
    public ref HSPFILEQ QueueHandle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.QueueHandle;
            }
            else
            {
                return ref _value64.QueueHandle;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* SourceRootPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SourceRootPath;
            }
            else
            {
                return ref _value64.SourceRootPath;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* SourcePath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SourcePath;
            }
            else
            {
                return ref _value64.SourcePath;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* SourceFilename
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SourceFilename;
            }
            else
            {
                return ref _value64.SourceFilename;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* SourceDescription
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SourceDescription;
            }
            else
            {
                return ref _value64.SourceDescription;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* SourceTagfile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SourceTagfile;
            }
            else
            {
                return ref _value64.SourceTagfile;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* TargetDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.TargetDirectory;
            }
            else
            {
                return ref _value64.TargetDirectory;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* TargetFilename
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.TargetFilename;
            }
            else
            {
                return ref _value64.TargetFilename;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint CopyStyle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.CopyStyle;
            }
            else
            {
                return ref _value64.CopyStyle;
            }
        }
    }

    [UnscopedRef]
    public ref HINF LayoutInf
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.LayoutInf;
            }
            else
            {
                return ref _value64.LayoutInf;
            }
        }
    }

    [NativeTypeName("PCSTR")]
    [UnscopedRef]
    public ref sbyte* SecurityDescriptor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.SecurityDescriptor;
            }
            else
            {
                return ref _value64.SecurityDescriptor;
            }
        }
    }
}
