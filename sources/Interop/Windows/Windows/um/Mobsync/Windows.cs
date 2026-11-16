// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRPROGRESSITEM_STATUSTEXT"]/*' />
    [NativeTypeName("#define SYNCMGRPROGRESSITEM_STATUSTEXT 0x0001")]
    public const int SYNCMGRPROGRESSITEM_STATUSTEXT = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRPROGRESSITEM_STATUSTYPE"]/*' />
    [NativeTypeName("#define SYNCMGRPROGRESSITEM_STATUSTYPE 0x0002")]
    public const int SYNCMGRPROGRESSITEM_STATUSTYPE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRPROGRESSITEM_PROGVALUE"]/*' />
    [NativeTypeName("#define SYNCMGRPROGRESSITEM_PROGVALUE 0x0004")]
    public const int SYNCMGRPROGRESSITEM_PROGVALUE = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRPROGRESSITEM_MAXVALUE"]/*' />
    [NativeTypeName("#define SYNCMGRPROGRESSITEM_MAXVALUE 0x0008")]
    public const int SYNCMGRPROGRESSITEM_MAXVALUE = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRLOGERROR_ERRORFLAGS"]/*' />
    [NativeTypeName("#define SYNCMGRLOGERROR_ERRORFLAGS 0x0001")]
    public const int SYNCMGRLOGERROR_ERRORFLAGS = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRLOGERROR_ERRORID"]/*' />
    [NativeTypeName("#define SYNCMGRLOGERROR_ERRORID 0x0002")]
    public const int SYNCMGRLOGERROR_ERRORID = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRLOGERROR_ITEMID"]/*' />
    [NativeTypeName("#define SYNCMGRLOGERROR_ITEMID 0x0004")]
    public const int SYNCMGRLOGERROR_ITEMID = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRITEM_ITEMFLAGMASK"]/*' />
    [NativeTypeName("#define SYNCMGRITEM_ITEMFLAGMASK 0x007F")]
    public const int SYNCMGRITEM_ITEMFLAGMASK = 0x007F;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRHANDLERFLAG_MASK"]/*' />
    [NativeTypeName("#define SYNCMGRHANDLERFLAG_MASK 0x000f")]
    public const int SYNCMGRHANDLERFLAG_MASK = 0x000f;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SYNCMGRREGISTERFLAGS_MASK"]/*' />
    [NativeTypeName("#define SYNCMGRREGISTERFLAGS_MASK 0x07")]
    public const int SYNCMGRREGISTERFLAGS_MASK = 0x07;
}
