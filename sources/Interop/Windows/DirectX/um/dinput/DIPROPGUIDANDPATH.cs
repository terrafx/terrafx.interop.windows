// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='DIPROPGUIDANDPATH.xml' path='doc/member[@name="DIPROPGUIDANDPATH"]/*' />
public partial struct DIPROPGUIDANDPATH
{
    /// <include file='DIPROPGUIDANDPATH.xml' path='doc/member[@name="DIPROPGUIDANDPATH.diph"]/*' />
    public DIPROPHEADER diph;

    /// <include file='DIPROPGUIDANDPATH.xml' path='doc/member[@name="DIPROPGUIDANDPATH.guidClass"]/*' />
    public Guid guidClass;

    /// <include file='DIPROPGUIDANDPATH.xml' path='doc/member[@name="DIPROPGUIDANDPATH.wszPath"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _wszPath_e__FixedBuffer wszPath;

    /// <include file='_wszPath_e__FixedBuffer.xml' path='doc/member[@name="_wszPath_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _wszPath_e__FixedBuffer
    {
        public char e0;
    }
}
