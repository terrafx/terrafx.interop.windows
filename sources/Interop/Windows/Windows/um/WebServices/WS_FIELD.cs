// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WS_FIELD
{
    /// <include file='WS_FIELD.xml' path='doc/member[@name="WS_FIELD.WS_FIELD_POINTER"]/*' />
    public const int WS_FIELD_POINTER = 0x1;
    /// <include file='WS_FIELD.xml' path='doc/member[@name="WS_FIELD.WS_FIELD_OPTIONAL"]/*' />
    public const int WS_FIELD_OPTIONAL = 0x2;
    /// <include file='WS_FIELD.xml' path='doc/member[@name="WS_FIELD.WS_FIELD_NILLABLE"]/*' />
    public const int WS_FIELD_NILLABLE = 0x4;
    /// <include file='WS_FIELD.xml' path='doc/member[@name="WS_FIELD.WS_FIELD_NILLABLE_ITEM"]/*' />
    public const int WS_FIELD_NILLABLE_ITEM = 0x8;
    /// <include file='WS_FIELD.xml' path='doc/member[@name="WS_FIELD.WS_FIELD_OTHER_NAMESPACE"]/*' />
    public const int WS_FIELD_OTHER_NAMESPACE = 0x10;
}
