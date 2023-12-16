// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW"]/*' />
public unsafe partial struct SHCREATEPROCESSINFOW
{
    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.fMask"]/*' />
    [NativeTypeName("ULONG")]
    public uint fMask;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.pszFile"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszFile;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.pszParameters"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszParameters;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.pszCurrentDirectory"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszCurrentDirectory;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.hUserToken"]/*' />
    public HANDLE hUserToken;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.lpProcessAttributes"]/*' />
    [NativeTypeName("LPSECURITY_ATTRIBUTES")]
    public SECURITY_ATTRIBUTES* lpProcessAttributes;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.lpThreadAttributes"]/*' />
    [NativeTypeName("LPSECURITY_ATTRIBUTES")]
    public SECURITY_ATTRIBUTES* lpThreadAttributes;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.bInheritHandles"]/*' />
    public BOOL bInheritHandles;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.dwCreationFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCreationFlags;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.lpStartupInfo"]/*' />
    [NativeTypeName("LPSTARTUPINFOW")]
    public STARTUPINFOW* lpStartupInfo;

    /// <include file='SHCREATEPROCESSINFOW.xml' path='doc/member[@name="SHCREATEPROCESSINFOW.lpProcessInformation"]/*' />
    [NativeTypeName("LPPROCESS_INFORMATION")]
    public PROCESS_INFORMATION* lpProcessInformation;
}
