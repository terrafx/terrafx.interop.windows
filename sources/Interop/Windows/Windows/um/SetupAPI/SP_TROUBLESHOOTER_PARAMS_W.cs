// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_TROUBLESHOOTER_PARAMS_W.xml' path='doc/member[@name="SP_TROUBLESHOOTER_PARAMS_W"]/*' />
public partial struct SP_TROUBLESHOOTER_PARAMS_W
{
    /// <include file='SP_TROUBLESHOOTER_PARAMS_W.xml' path='doc/member[@name="SP_TROUBLESHOOTER_PARAMS_W.ClassInstallHeader"]/*' />
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    /// <include file='SP_TROUBLESHOOTER_PARAMS_W.xml' path='doc/member[@name="SP_TROUBLESHOOTER_PARAMS_W.ChmFile"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _ChmFile_e__FixedBuffer ChmFile;

    /// <include file='SP_TROUBLESHOOTER_PARAMS_W.xml' path='doc/member[@name="SP_TROUBLESHOOTER_PARAMS_W.HtmlTroubleShooter"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _HtmlTroubleShooter_e__FixedBuffer HtmlTroubleShooter;

    /// <include file='_ChmFile_e__FixedBuffer.xml' path='doc/member[@name="_ChmFile_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _ChmFile_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_HtmlTroubleShooter_e__FixedBuffer.xml' path='doc/member[@name="_HtmlTroubleShooter_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _HtmlTroubleShooter_e__FixedBuffer
    {
        public char e0;
    }
}
