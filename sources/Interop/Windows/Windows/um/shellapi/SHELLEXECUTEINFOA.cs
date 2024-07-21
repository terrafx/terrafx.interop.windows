// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA"]/*' />
public unsafe partial struct SHELLEXECUTEINFOA
{
    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.fMask"]/*' />
    [NativeTypeName("ULONG")]
    public uint fMask;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.lpVerb"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpVerb;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.lpFile"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpFile;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.lpParameters"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpParameters;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.lpDirectory"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpDirectory;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.nShow"]/*' />
    public int nShow;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.hInstApp"]/*' />
    public HINSTANCE hInstApp;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.lpIDList"]/*' />
    public void* lpIDList;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.lpClass"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpClass;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.hkeyClass"]/*' />
    public HKEY hkeyClass;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.dwHotKey"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHotKey;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_shellapi_L461_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='SHELLEXECUTEINFOA.xml' path='doc/member[@name="SHELLEXECUTEINFOA.hProcess"]/*' />
    public HANDLE hProcess;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hIcon"]/*' />
    [UnscopedRef]
    public ref HANDLE hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hIcon;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hMonitor"]/*' />
    [UnscopedRef]
    public ref HANDLE hMonitor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hMonitor;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hIcon"]/*' />
        [FieldOffset(0)]
        public HANDLE hIcon;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hMonitor"]/*' />
        [FieldOffset(0)]
        public HANDLE hMonitor;
    }
}
