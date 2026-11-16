// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_NODATACACHE"]/*' />
    [NativeTypeName("#define UPDFCACHE_NODATACACHE ( 0x1 )")]
    public const int UPDFCACHE_NODATACACHE = (0x1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_ONSAVECACHE"]/*' />
    [NativeTypeName("#define UPDFCACHE_ONSAVECACHE ( 0x2 )")]
    public const int UPDFCACHE_ONSAVECACHE = (0x2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_ONSTOPCACHE"]/*' />
    [NativeTypeName("#define UPDFCACHE_ONSTOPCACHE ( 0x4 )")]
    public const int UPDFCACHE_ONSTOPCACHE = (0x4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_NORMALCACHE"]/*' />
    [NativeTypeName("#define UPDFCACHE_NORMALCACHE ( 0x8 )")]
    public const int UPDFCACHE_NORMALCACHE = (0x8);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_IFBLANK"]/*' />
    [NativeTypeName("#define UPDFCACHE_IFBLANK ( 0x10 )")]
    public const int UPDFCACHE_IFBLANK = (0x10);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_ONLYIFBLANK"]/*' />
    [NativeTypeName("#define UPDFCACHE_ONLYIFBLANK ( 0x80000000 )")]
    public const uint UPDFCACHE_ONLYIFBLANK = (0x80000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_IFBLANKORONSAVECACHE"]/*' />
    [NativeTypeName("#define UPDFCACHE_IFBLANKORONSAVECACHE ( ( UPDFCACHE_IFBLANK | UPDFCACHE_ONSAVECACHE )  )")]
    public const int UPDFCACHE_IFBLANKORONSAVECACHE = (((0x10) | (0x2)));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_ALL"]/*' />
    [NativeTypeName("#define UPDFCACHE_ALL ( ( DWORD  )~UPDFCACHE_ONLYIFBLANK )")]
    public const uint UPDFCACHE_ALL = ((uint)(~(0x80000000)));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UPDFCACHE_ALLBUTNODATACACHE"]/*' />
    [NativeTypeName("#define UPDFCACHE_ALLBUTNODATACACHE ( ( UPDFCACHE_ALL & ( DWORD  )~UPDFCACHE_NODATACACHE )  )")]
    public const uint UPDFCACHE_ALLBUTNODATACACHE = unchecked((((uint)(~(0x80000000))) & (uint)(~(0x1))));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DROPEFFECT_NONE"]/*' />
    [NativeTypeName("#define DROPEFFECT_NONE ( 0 )")]
    public const int DROPEFFECT_NONE = (0);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DROPEFFECT_COPY"]/*' />
    [NativeTypeName("#define DROPEFFECT_COPY ( 1 )")]
    public const int DROPEFFECT_COPY = (1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DROPEFFECT_MOVE"]/*' />
    [NativeTypeName("#define DROPEFFECT_MOVE ( 2 )")]
    public const int DROPEFFECT_MOVE = (2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DROPEFFECT_LINK"]/*' />
    [NativeTypeName("#define DROPEFFECT_LINK ( 4 )")]
    public const int DROPEFFECT_LINK = (4);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DROPEFFECT_SCROLL"]/*' />
    [NativeTypeName("#define DROPEFFECT_SCROLL ( 0x80000000 )")]
    public const uint DROPEFFECT_SCROLL = (0x80000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DROPEFFECT_NEWTARGET"]/*' />
    [NativeTypeName("#define DROPEFFECT_NEWTARGET ( 0x40000000 )")]
    public const int DROPEFFECT_NEWTARGET = (0x40000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DROPEFFECT_BACKGROUNDTARGET"]/*' />
    [NativeTypeName("#define DROPEFFECT_BACKGROUNDTARGET ( 0x20000000 )")]
    public const int DROPEFFECT_BACKGROUNDTARGET = (0x20000000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DD_DEFSCROLLINSET"]/*' />
    [NativeTypeName("#define DD_DEFSCROLLINSET ( 11 )")]
    public const int DD_DEFSCROLLINSET = (11);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DD_DEFSCROLLDELAY"]/*' />
    [NativeTypeName("#define DD_DEFSCROLLDELAY ( 50 )")]
    public const int DD_DEFSCROLLDELAY = (50);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DD_DEFSCROLLINTERVAL"]/*' />
    [NativeTypeName("#define DD_DEFSCROLLINTERVAL ( 50 )")]
    public const int DD_DEFSCROLLINTERVAL = (50);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DD_DEFDRAGDELAY"]/*' />
    [NativeTypeName("#define DD_DEFDRAGDELAY ( 200 )")]
    public const int DD_DEFDRAGDELAY = (200);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DD_DEFDRAGMINDIST"]/*' />
    [NativeTypeName("#define DD_DEFDRAGMINDIST ( 2 )")]
    public const int DD_DEFDRAGMINDIST = (2);
}
