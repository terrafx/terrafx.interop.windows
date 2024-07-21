// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_BACKUP_QUEUE_PARAMS_V2_W.xml' path='doc/member[@name="SP_BACKUP_QUEUE_PARAMS_V2_W"]/*' />
public partial struct SP_BACKUP_QUEUE_PARAMS_V2_W
{
    /// <include file='SP_BACKUP_QUEUE_PARAMS_V2_W.xml' path='doc/member[@name="SP_BACKUP_QUEUE_PARAMS_V2_W.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_BACKUP_QUEUE_PARAMS_V2_W.xml' path='doc/member[@name="SP_BACKUP_QUEUE_PARAMS_V2_W.FullInfPath"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _FullInfPath_e__FixedBuffer FullInfPath;

    /// <include file='SP_BACKUP_QUEUE_PARAMS_V2_W.xml' path='doc/member[@name="SP_BACKUP_QUEUE_PARAMS_V2_W.FilenameOffset"]/*' />
    public int FilenameOffset;

    /// <include file='SP_BACKUP_QUEUE_PARAMS_V2_W.xml' path='doc/member[@name="SP_BACKUP_QUEUE_PARAMS_V2_W.ReinstallInstance"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _ReinstallInstance_e__FixedBuffer ReinstallInstance;

    /// <include file='_FullInfPath_e__FixedBuffer.xml' path='doc/member[@name="_FullInfPath_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _FullInfPath_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_ReinstallInstance_e__FixedBuffer.xml' path='doc/member[@name="_ReinstallInstance_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _ReinstallInstance_e__FixedBuffer
    {
        public char e0;
    }
}
