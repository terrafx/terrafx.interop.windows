// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define UPDFCACHE_NODATACACHE ( 0x1 )")]
        public const int UPDFCACHE_NODATACACHE = (0x1);

        [NativeTypeName("#define UPDFCACHE_ONSAVECACHE ( 0x2 )")]
        public const int UPDFCACHE_ONSAVECACHE = (0x2);

        [NativeTypeName("#define UPDFCACHE_ONSTOPCACHE ( 0x4 )")]
        public const int UPDFCACHE_ONSTOPCACHE = (0x4);

        [NativeTypeName("#define UPDFCACHE_NORMALCACHE ( 0x8 )")]
        public const int UPDFCACHE_NORMALCACHE = (0x8);

        [NativeTypeName("#define UPDFCACHE_IFBLANK ( 0x10 )")]
        public const int UPDFCACHE_IFBLANK = (0x10);

        [NativeTypeName("#define UPDFCACHE_ONLYIFBLANK ( 0x80000000 )")]
        public const uint UPDFCACHE_ONLYIFBLANK = (0x80000000);

        [NativeTypeName("#define UPDFCACHE_IFBLANKORONSAVECACHE ( ( UPDFCACHE_IFBLANK | UPDFCACHE_ONSAVECACHE )  )")]
        public const int UPDFCACHE_IFBLANKORONSAVECACHE = (((0x10) | (0x2)));

        [NativeTypeName("#define UPDFCACHE_ALL ( ( DWORD  )~UPDFCACHE_ONLYIFBLANK )")]
        public const uint UPDFCACHE_ALL = ((uint)(~(0x80000000)));

        [NativeTypeName("#define UPDFCACHE_ALLBUTNODATACACHE ( ( UPDFCACHE_ALL & ( DWORD  )~UPDFCACHE_NODATACACHE )  )")]
        public const uint UPDFCACHE_ALLBUTNODATACACHE = unchecked((((uint)(~(0x80000000))) & (uint)(~(0x1))));

        [NativeTypeName("#define MK_ALT ( 0x20 )")]
        public const int MK_ALT = (0x20);

        [NativeTypeName("#define DROPEFFECT_NONE ( 0 )")]
        public const int DROPEFFECT_NONE = (0);

        [NativeTypeName("#define DROPEFFECT_COPY ( 1 )")]
        public const int DROPEFFECT_COPY = (1);

        [NativeTypeName("#define DROPEFFECT_MOVE ( 2 )")]
        public const int DROPEFFECT_MOVE = (2);

        [NativeTypeName("#define DROPEFFECT_LINK ( 4 )")]
        public const int DROPEFFECT_LINK = (4);

        [NativeTypeName("#define DROPEFFECT_SCROLL ( 0x80000000 )")]
        public const uint DROPEFFECT_SCROLL = (0x80000000);

        [NativeTypeName("#define DD_DEFSCROLLINSET ( 11 )")]
        public const int DD_DEFSCROLLINSET = (11);

        [NativeTypeName("#define DD_DEFSCROLLDELAY ( 50 )")]
        public const int DD_DEFSCROLLDELAY = (50);

        [NativeTypeName("#define DD_DEFSCROLLINTERVAL ( 50 )")]
        public const int DD_DEFSCROLLINTERVAL = (50);

        [NativeTypeName("#define DD_DEFDRAGDELAY ( 200 )")]
        public const int DD_DEFDRAGDELAY = (200);

        [NativeTypeName("#define DD_DEFDRAGMINDIST ( 2 )")]
        public const int DD_DEFDRAGMINDIST = (2);

        [NativeTypeName("#define CFSTR_ENTERPRISE_ID (TEXT(\"EnterpriseDataProtectionId\"))")]
        public const string CFSTR_ENTERPRISE_ID = ("EnterpriseDataProtectionId");

        public static readonly Guid IID_IOleAdviseHolder = new Guid(0x00000111, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleCache = new Guid(0x0000011E, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleCache2 = new Guid(0x00000128, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleCacheControl = new Guid(0x00000129, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IParseDisplayName = new Guid(0x0000011A, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleContainer = new Guid(0x0000011B, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleClientSite = new Guid(0x00000118, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleObject = new Guid(0x00000112, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleWindow = new Guid(0x00000114, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleLink = new Guid(0x0000011D, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleItemContainer = new Guid(0x0000011C, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleInPlaceUIWindow = new Guid(0x00000115, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleInPlaceActiveObject = new Guid(0x00000117, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleInPlaceFrame = new Guid(0x00000116, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleInPlaceObject = new Guid(0x00000113, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IOleInPlaceSite = new Guid(0x00000119, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IContinue = new Guid(0x0000012A, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IViewObject = new Guid(0x0000010D, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IViewObject2 = new Guid(0x00000127, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IDropSource = new Guid(0x00000121, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IDropTarget = new Guid(0x00000122, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IDropSourceNotify = new Guid(0x0000012B, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnterpriseDropTarget = new Guid(0x390E3878, 0xFD55, 0x4E18, 0x81, 0x9D, 0x46, 0x82, 0x08, 0x1C, 0x0C, 0xFD);

        public static readonly Guid IID_IEnumOLEVERB = new Guid(0x00000104, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);
    }
}
