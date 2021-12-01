// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ADPCMWAVEFORMAT
{
    /// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT.wfx"]/*' />
    public WAVEFORMATEX wfx;

    /// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT.wSamplesPerBlock"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSamplesPerBlock;

    /// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT.wNumCoef"]/*' />
    [NativeTypeName("WORD")]
    public ushort wNumCoef;

    /// <include file='ADPCMWAVEFORMAT.xml' path='doc/member[@name="ADPCMWAVEFORMAT.aCoef"]/*' />
    [NativeTypeName("ADPCMCOEFSET []")]
    public ADPCMCOEFSET aCoef;
}
