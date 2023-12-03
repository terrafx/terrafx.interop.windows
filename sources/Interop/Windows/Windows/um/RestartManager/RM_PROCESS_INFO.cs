// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='RM_PROCESS_INFO.xml' path='doc/member[@name="RM_PROCESS_INFO"]/*' />
public partial struct RM_PROCESS_INFO
{
    /// <include file='RM_PROCESS_INFO.xml' path='doc/member[@name="RM_PROCESS_INFO.Process"]/*' />
    public RM_UNIQUE_PROCESS Process;

    /// <include file='RM_PROCESS_INFO.xml' path='doc/member[@name="RM_PROCESS_INFO.strAppName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _strAppName_e__FixedBuffer strAppName;

    /// <include file='RM_PROCESS_INFO.xml' path='doc/member[@name="RM_PROCESS_INFO.strServiceShortName"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _strServiceShortName_e__FixedBuffer strServiceShortName;

    /// <include file='RM_PROCESS_INFO.xml' path='doc/member[@name="RM_PROCESS_INFO.ApplicationType"]/*' />
    public RM_APP_TYPE ApplicationType;

    /// <include file='RM_PROCESS_INFO.xml' path='doc/member[@name="RM_PROCESS_INFO.AppStatus"]/*' />
    [NativeTypeName("ULONG")]
    public uint AppStatus;

    /// <include file='RM_PROCESS_INFO.xml' path='doc/member[@name="RM_PROCESS_INFO.TSSessionId"]/*' />
    [NativeTypeName("DWORD")]
    public uint TSSessionId;

    /// <include file='RM_PROCESS_INFO.xml' path='doc/member[@name="RM_PROCESS_INFO.bRestartable"]/*' />
    public BOOL bRestartable;

    /// <include file='_strAppName_e__FixedBuffer.xml' path='doc/member[@name="_strAppName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _strAppName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_strServiceShortName_e__FixedBuffer.xml' path='doc/member[@name="_strServiceShortName_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _strServiceShortName_e__FixedBuffer
    {
        public char e0;
    }
}
