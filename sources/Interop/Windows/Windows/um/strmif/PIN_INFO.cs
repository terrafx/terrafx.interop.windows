// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PIN_INFO.xml' path='doc/member[@name="PIN_INFO"]/*' />
public unsafe partial struct PIN_INFO
{
    /// <include file='PIN_INFO.xml' path='doc/member[@name="PIN_INFO.pFilter"]/*' />
    public IBaseFilter* pFilter;

    /// <include file='PIN_INFO.xml' path='doc/member[@name="PIN_INFO.dir"]/*' />
    public PIN_DIRECTION dir;

    /// <include file='PIN_INFO.xml' path='doc/member[@name="PIN_INFO.achName"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _achName_e__FixedBuffer achName;

    /// <include file='_achName_e__FixedBuffer.xml' path='doc/member[@name="_achName_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _achName_e__FixedBuffer
    {
        public char e0;
    }
}
