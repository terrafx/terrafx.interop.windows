// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DISPID
{
    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_EVENT_ON_STATE_CHANGED"]/*' />
    [NativeTypeName("#define DISPID_EVENT_ON_STATE_CHANGED ( 5 )")]
    public const int DISPID_EVENT_ON_STATE_CHANGED = (5);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_EVENT_ON_TERMINATION"]/*' />
    [NativeTypeName("#define DISPID_EVENT_ON_TERMINATION ( 6 )")]
    public const int DISPID_EVENT_ON_TERMINATION = (6);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_EVENT_ON_CONTEXT_DATA"]/*' />
    [NativeTypeName("#define DISPID_EVENT_ON_CONTEXT_DATA ( 7 )")]
    public const int DISPID_EVENT_ON_CONTEXT_DATA = (7);

    /// <include file='DISPID.xml' path='doc/member[@name="DISPID.DISPID_EVENT_ON_SEND_ERROR"]/*' />
    [NativeTypeName("#define DISPID_EVENT_ON_SEND_ERROR ( 8 )")]
    public const int DISPID_EVENT_ON_SEND_ERROR = (8);
}
