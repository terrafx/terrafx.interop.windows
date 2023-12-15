// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHELL_ITEM_RESOURCE.xml' path='doc/member[@name="SHELL_ITEM_RESOURCE"]/*' />
public partial struct SHELL_ITEM_RESOURCE
{
    /// <include file='SHELL_ITEM_RESOURCE.xml' path='doc/member[@name="SHELL_ITEM_RESOURCE.guidType"]/*' />
    public Guid guidType;

    /// <include file='SHELL_ITEM_RESOURCE.xml' path='doc/member[@name="SHELL_ITEM_RESOURCE.szName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szName_e__FixedBuffer szName;

    /// <include file='_szName_e__FixedBuffer.xml' path='doc/member[@name="_szName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szName_e__FixedBuffer
    {
        public char e0;
    }
}
