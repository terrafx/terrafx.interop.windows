// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SHCREATEPROCESSINFOW
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SHCREATEPROCESSINFO32W));
            }
            else
            {
                return (uint)(sizeof(SHCREATEPROCESSINFO64W));
            }
        }
    }

    [FieldOffset(0)]
    public SHCREATEPROCESSINFO32W _value32;

    [FieldOffset(0)]
    public SHCREATEPROCESSINFO64W _value64;

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

    [NativeTypeName("ULONG")]
    [UnscopedRef]
    public ref uint fMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.fMask;
            }
            else
            {
                return ref _value64.fMask;
            }
        }
    }

    [UnscopedRef]
    public ref HWND hwnd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hwnd;
            }
            else
            {
                return ref _value64.hwnd;
            }
        }
    }

    [NativeTypeName("LPCWSTR")]
    [UnscopedRef]
    public ref ushort* pszFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pszFile;
            }
            else
            {
                return ref _value64.pszFile;
            }
        }
    }

    [NativeTypeName("LPCWSTR")]
    [UnscopedRef]
    public ref ushort* pszParameters
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pszParameters;
            }
            else
            {
                return ref _value64.pszParameters;
            }
        }
    }

    [NativeTypeName("LPCWSTR")]
    [UnscopedRef]
    public ref ushort* pszCurrentDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.pszCurrentDirectory;
            }
            else
            {
                return ref _value64.pszCurrentDirectory;
            }
        }
    }

    [UnscopedRef]
    public ref HANDLE hUserToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hUserToken;
            }
            else
            {
                return ref _value64.hUserToken;
            }
        }
    }

    [NativeTypeName("LPSECURITY_ATTRIBUTES")]
    [UnscopedRef]
    public ref SECURITY_ATTRIBUTES* lpProcessAttributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpProcessAttributes;
            }
            else
            {
                return ref _value64.lpProcessAttributes;
            }
        }
    }

    [NativeTypeName("LPSECURITY_ATTRIBUTES")]
    [UnscopedRef]
    public ref SECURITY_ATTRIBUTES* lpThreadAttributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpThreadAttributes;
            }
            else
            {
                return ref _value64.lpThreadAttributes;
            }
        }
    }

    [UnscopedRef]
    public ref BOOL bInheritHandles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.bInheritHandles;
            }
            else
            {
                return ref _value64.bInheritHandles;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint dwCreationFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.dwCreationFlags;
            }
            else
            {
                return ref _value64.dwCreationFlags;
            }
        }
    }

    [NativeTypeName("LPSTARTUPINFOW")]
    [UnscopedRef]
    public ref STARTUPINFOW* lpStartupInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpStartupInfo;
            }
            else
            {
                return ref _value64.lpStartupInfo;
            }
        }
    }

    [NativeTypeName("LPPROCESS_INFORMATION")]
    [UnscopedRef]
    public ref PROCESS_INFORMATION* lpProcessInformation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.lpProcessInformation;
            }
            else
            {
                return ref _value64.lpProcessInformation;
            }
        }
    }
}
