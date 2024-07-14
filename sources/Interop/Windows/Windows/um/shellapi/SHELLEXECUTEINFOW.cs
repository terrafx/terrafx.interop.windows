// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW"]/*' />
public unsafe partial struct SHELLEXECUTEINFOW
{
    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.fMask"]/*' />
    [NativeTypeName("ULONG")]
    public uint fMask;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.lpVerb"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpVerb;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.lpFile"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpFile;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.lpParameters"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpParameters;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.lpDirectory"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpDirectory;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.nShow"]/*' />
    public int nShow;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.hInstApp"]/*' />
    public HINSTANCE hInstApp;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.lpIDList"]/*' />
    public void* lpIDList;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.lpClass"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpClass;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.hkeyClass"]/*' />
    public HKEY hkeyClass;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.dwHotKey"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHotKey;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_shellapi_L484_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='SHELLEXECUTEINFOW.xml' path='doc/member[@name="SHELLEXECUTEINFOW.hProcess"]/*' />
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
