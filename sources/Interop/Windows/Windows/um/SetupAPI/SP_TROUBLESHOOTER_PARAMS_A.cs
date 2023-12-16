// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_TROUBLESHOOTER_PARAMS_A.xml' path='doc/member[@name="SP_TROUBLESHOOTER_PARAMS_A"]/*' />
public partial struct SP_TROUBLESHOOTER_PARAMS_A
{
    /// <include file='SP_TROUBLESHOOTER_PARAMS_A.xml' path='doc/member[@name="SP_TROUBLESHOOTER_PARAMS_A.ClassInstallHeader"]/*' />
    public SP_CLASSINSTALL_HEADER ClassInstallHeader;

    /// <include file='SP_TROUBLESHOOTER_PARAMS_A.xml' path='doc/member[@name="SP_TROUBLESHOOTER_PARAMS_A.ChmFile"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _ChmFile_e__FixedBuffer ChmFile;

    /// <include file='SP_TROUBLESHOOTER_PARAMS_A.xml' path='doc/member[@name="SP_TROUBLESHOOTER_PARAMS_A.HtmlTroubleShooter"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _HtmlTroubleShooter_e__FixedBuffer HtmlTroubleShooter;

    /// <include file='_ChmFile_e__FixedBuffer.xml' path='doc/member[@name="_ChmFile_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _ChmFile_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_HtmlTroubleShooter_e__FixedBuffer.xml' path='doc/member[@name="_HtmlTroubleShooter_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _HtmlTroubleShooter_e__FixedBuffer
    {
        public sbyte e0;
    }
}
