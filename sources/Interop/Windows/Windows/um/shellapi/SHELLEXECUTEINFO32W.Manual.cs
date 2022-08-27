// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHELLEXECUTEINFO32W
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("ULONG")]
    public uint fMask;

    public HWND hwnd;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpVerb;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpFile;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpParameters;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpDirectory;

    public int nShow;

    public HINSTANCE hInstApp;

    public void* lpIDList;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpClass;

    public HKEY hkeyClass;

    [NativeTypeName("DWORD")]
    public uint dwHotKey;

    [NativeTypeName("_SHELLEXECUTEINFOW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/shellapi.h:484:5)")]
    public _Anonymous_e__Union Anonymous;

    public HANDLE hProcess;

    [UnscopedRef]
    public ref HANDLE hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hIcon;
        }
    }

    [UnscopedRef]
    public ref HANDLE hMonitor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hMonitor;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HANDLE hIcon;

        [FieldOffset(0)]
        public HANDLE hMonitor;
    }
}
