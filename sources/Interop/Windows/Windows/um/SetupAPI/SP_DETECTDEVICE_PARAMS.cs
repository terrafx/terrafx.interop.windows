// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SP_DETECTDEVICE_PARAMS.xml' path='doc/member[@name="SP_DETECTDEVICE_PARAMS"]/*' />
public unsafe partial struct SP_DETECTDEVICE_PARAMS
{
    /// <include file='SP_DETECTDEVICE_PARAMS.xml' path='doc/member[@name="SP_DETECTDEVICE_PARAMS.ClassInstallHeader"]/*' />
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    /// <include file='SP_DETECTDEVICE_PARAMS.xml' path='doc/member[@name="SP_DETECTDEVICE_PARAMS.DetectProgressNotify"]/*' />
    [NativeTypeName("PDETECT_PROGRESS_NOTIFY")]
    public delegate* unmanaged<void*, uint, BOOL> DetectProgressNotify;

    /// <include file='SP_DETECTDEVICE_PARAMS.xml' path='doc/member[@name="SP_DETECTDEVICE_PARAMS.ProgressNotifyParam"]/*' />
    [NativeTypeName("PVOID")]
    public void* ProgressNotifyParam;
}
