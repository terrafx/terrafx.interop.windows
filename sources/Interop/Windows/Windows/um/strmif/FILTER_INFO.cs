// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILTER_INFO.xml' path='doc/member[@name="FILTER_INFO"]/*' />
public unsafe partial struct FILTER_INFO
{
    /// <include file='FILTER_INFO.xml' path='doc/member[@name="FILTER_INFO.achName"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _achName_e__FixedBuffer achName;

    /// <include file='FILTER_INFO.xml' path='doc/member[@name="FILTER_INFO.pGraph"]/*' />
    public IFilterGraph* pGraph;

    /// <include file='_achName_e__FixedBuffer.xml' path='doc/member[@name="_achName_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _achName_e__FixedBuffer
    {
        public char e0;
    }
}
