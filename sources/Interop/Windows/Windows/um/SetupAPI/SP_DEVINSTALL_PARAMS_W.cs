// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W"]/*' />
public unsafe partial struct SP_DEVINSTALL_PARAMS_W
{
    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.FlagsEx"]/*' />
    [NativeTypeName("DWORD")]
    public uint FlagsEx;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.hwndParent"]/*' />
    public HWND hwndParent;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.InstallMsgHandler"]/*' />
    [NativeTypeName("PSP_FILE_CALLBACK_W")]
    public delegate* unmanaged<void*, uint, nuint, nuint, uint> InstallMsgHandler;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.InstallMsgHandlerContext"]/*' />
    [NativeTypeName("PVOID")]
    public void* InstallMsgHandlerContext;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.FileQueue"]/*' />
    public HSPFILEQ FileQueue;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.ClassInstallReserved"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint ClassInstallReserved;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='SP_DEVINSTALL_PARAMS_W.xml' path='doc/member[@name="SP_DEVINSTALL_PARAMS_W.DriverPath"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _DriverPath_e__FixedBuffer DriverPath;

    /// <include file='_DriverPath_e__FixedBuffer.xml' path='doc/member[@name="_DriverPath_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _DriverPath_e__FixedBuffer
    {
        public char e0;
    }
}
