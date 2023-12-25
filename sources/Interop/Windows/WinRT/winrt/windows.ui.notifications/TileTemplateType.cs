// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType"]/*' />
public enum TileTemplateType
{
    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquareImage"]/*' />
    [Obsolete("TileSquareImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Image.")]
    TileTemplateType_TileSquareImage = 0,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquareBlock"]/*' />
    [Obsolete("TileSquareBlock may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Block.")]
    TileTemplateType_TileSquareBlock = 1,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquareText01"]/*' />
    [Obsolete("TileSquareText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text01.")]
    TileTemplateType_TileSquareText01 = 2,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquareText02"]/*' />
    [Obsolete("TileSquareText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text02.")]
    TileTemplateType_TileSquareText02 = 3,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquareText03"]/*' />
    [Obsolete("TileSquareText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text03.")]
    TileTemplateType_TileSquareText03 = 4,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquareText04"]/*' />
    [Obsolete("TileSquareText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150Text04.")]
    TileTemplateType_TileSquareText04 = 5,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquarePeekImageAndText01"]/*' />
    [Obsolete("TileSquarePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText01.")]
    TileTemplateType_TileSquarePeekImageAndText01 = 6,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquarePeekImageAndText02"]/*' />
    [Obsolete("TileSquarePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText02.")]
    TileTemplateType_TileSquarePeekImageAndText02 = 7,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquarePeekImageAndText03"]/*' />
    [Obsolete("TileSquarePeekImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText03.")]
    TileTemplateType_TileSquarePeekImageAndText03 = 8,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquarePeekImageAndText04"]/*' />
    [Obsolete("TileSquarePeekImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileSquare150x150PeekImageAndText04.")]
    TileTemplateType_TileSquarePeekImageAndText04 = 9,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideImage"]/*' />
    [Obsolete("TileWideImage may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Image.")]
    TileTemplateType_TileWideImage = 10,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideImageCollection"]/*' />
    [Obsolete("TileWideImageCollection may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageCollection.")]
    TileTemplateType_TileWideImageCollection = 11,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideImageAndText01"]/*' />
    [Obsolete("TileWideImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText01.")]
    TileTemplateType_TileWideImageAndText01 = 12,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideImageAndText02"]/*' />
    [Obsolete("TileWideImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150ImageAndText02.")]
    TileTemplateType_TileWideImageAndText02 = 13,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideBlockAndText01"]/*' />
    [Obsolete("TileWideBlockAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText01.")]
    TileTemplateType_TileWideBlockAndText01 = 14,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideBlockAndText02"]/*' />
    [Obsolete("TileWideBlockAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150BlockAndText02.")]
    TileTemplateType_TileWideBlockAndText02 = 15,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImageCollection01"]/*' />
    [Obsolete("TileWidePeekImageCollection01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection01.")]
    TileTemplateType_TileWidePeekImageCollection01 = 16,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImageCollection02"]/*' />
    [Obsolete("TileWidePeekImageCollection02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection02.")]
    TileTemplateType_TileWidePeekImageCollection02 = 17,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImageCollection03"]/*' />
    [Obsolete("TileWidePeekImageCollection03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection03.")]
    TileTemplateType_TileWidePeekImageCollection03 = 18,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImageCollection04"]/*' />
    [Obsolete("TileWidePeekImageCollection04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection04.")]
    TileTemplateType_TileWidePeekImageCollection04 = 19,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImageCollection05"]/*' />
    [Obsolete("TileWidePeekImageCollection05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection05.")]
    TileTemplateType_TileWidePeekImageCollection05 = 20,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImageCollection06"]/*' />
    [Obsolete("TileWidePeekImageCollection06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageCollection06.")]
    TileTemplateType_TileWidePeekImageCollection06 = 21,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImageAndText01"]/*' />
    [Obsolete("TileWidePeekImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText01.")]
    TileTemplateType_TileWidePeekImageAndText01 = 22,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImageAndText02"]/*' />
    [Obsolete("TileWidePeekImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImageAndText02.")]
    TileTemplateType_TileWidePeekImageAndText02 = 23,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImage01"]/*' />
    [Obsolete("TileWidePeekImage01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage01.")]
    TileTemplateType_TileWidePeekImage01 = 24,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImage02"]/*' />
    [Obsolete("TileWidePeekImage02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage02.")]
    TileTemplateType_TileWidePeekImage02 = 25,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImage03"]/*' />
    [Obsolete("TileWidePeekImage03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage03.")]
    TileTemplateType_TileWidePeekImage03 = 26,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImage04"]/*' />
    [Obsolete("TileWidePeekImage04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage04.")]
    TileTemplateType_TileWidePeekImage04 = 27,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImage05"]/*' />
    [Obsolete("TileWidePeekImage05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage05.")]
    TileTemplateType_TileWidePeekImage05 = 28,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWidePeekImage06"]/*' />
    [Obsolete("TileWidePeekImage06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150PeekImage06.")]
    TileTemplateType_TileWidePeekImage06 = 29,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideSmallImageAndText01"]/*' />
    [Obsolete("TileWideSmallImageAndText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText01.")]
    TileTemplateType_TileWideSmallImageAndText01 = 30,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideSmallImageAndText02"]/*' />
    [Obsolete("TileWideSmallImageAndText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText02.")]
    TileTemplateType_TileWideSmallImageAndText02 = 31,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideSmallImageAndText03"]/*' />
    [Obsolete("TileWideSmallImageAndText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText03.")]
    TileTemplateType_TileWideSmallImageAndText03 = 32,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideSmallImageAndText04"]/*' />
    [Obsolete("TileWideSmallImageAndText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText04.")]
    TileTemplateType_TileWideSmallImageAndText04 = 33,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideSmallImageAndText05"]/*' />
    [Obsolete("TileWideSmallImageAndText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150SmallImageAndText05.")]
    TileTemplateType_TileWideSmallImageAndText05 = 34,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText01"]/*' />
    [Obsolete("TileWideText01 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text01.")]
    TileTemplateType_TileWideText01 = 35,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText02"]/*' />
    [Obsolete("TileWideText02 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text02.")]
    TileTemplateType_TileWideText02 = 36,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText03"]/*' />
    [Obsolete("TileWideText03 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text03.")]
    TileTemplateType_TileWideText03 = 37,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText04"]/*' />
    [Obsolete("TileWideText04 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text04.")]
    TileTemplateType_TileWideText04 = 38,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText05"]/*' />
    [Obsolete("TileWideText05 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text05.")]
    TileTemplateType_TileWideText05 = 39,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText06"]/*' />
    [Obsolete("TileWideText06 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text06.")]
    TileTemplateType_TileWideText06 = 40,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText07"]/*' />
    [Obsolete("TileWideText07 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text07.")]
    TileTemplateType_TileWideText07 = 41,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText08"]/*' />
    [Obsolete("TileWideText08 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text08.")]
    TileTemplateType_TileWideText08 = 42,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText09"]/*' />
    [Obsolete("TileWideText09 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text09.")]
    TileTemplateType_TileWideText09 = 43,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText10"]/*' />
    [Obsolete("TileWideText10 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text10.")]
    TileTemplateType_TileWideText10 = 44,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWideText11"]/*' />
    [Obsolete("TileWideText11 may be altered or unavailable for releases after Windows 8.1. Instead, use TileWide310x150Text11.")]
    TileTemplateType_TileWideText11 = 45,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150Image"]/*' />
    TileTemplateType_TileSquare150x150Image = 0,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150Block"]/*' />
    TileTemplateType_TileSquare150x150Block = 1,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150Text01"]/*' />
    TileTemplateType_TileSquare150x150Text01 = 2,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150Text02"]/*' />
    TileTemplateType_TileSquare150x150Text02 = 3,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150Text03"]/*' />
    TileTemplateType_TileSquare150x150Text03 = 4,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150Text04"]/*' />
    TileTemplateType_TileSquare150x150Text04 = 5,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150PeekImageAndText01"]/*' />
    TileTemplateType_TileSquare150x150PeekImageAndText01 = 6,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150PeekImageAndText02"]/*' />
    TileTemplateType_TileSquare150x150PeekImageAndText02 = 7,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150PeekImageAndText03"]/*' />
    TileTemplateType_TileSquare150x150PeekImageAndText03 = 8,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150PeekImageAndText04"]/*' />
    TileTemplateType_TileSquare150x150PeekImageAndText04 = 9,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Image"]/*' />
    TileTemplateType_TileWide310x150Image = 10,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150ImageCollection"]/*' />
    TileTemplateType_TileWide310x150ImageCollection = 11,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150ImageAndText01"]/*' />
    TileTemplateType_TileWide310x150ImageAndText01 = 12,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150ImageAndText02"]/*' />
    TileTemplateType_TileWide310x150ImageAndText02 = 13,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150BlockAndText01"]/*' />
    TileTemplateType_TileWide310x150BlockAndText01 = 14,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150BlockAndText02"]/*' />
    TileTemplateType_TileWide310x150BlockAndText02 = 15,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImageCollection01"]/*' />
    TileTemplateType_TileWide310x150PeekImageCollection01 = 16,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImageCollection02"]/*' />
    TileTemplateType_TileWide310x150PeekImageCollection02 = 17,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImageCollection03"]/*' />
    TileTemplateType_TileWide310x150PeekImageCollection03 = 18,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImageCollection04"]/*' />
    TileTemplateType_TileWide310x150PeekImageCollection04 = 19,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImageCollection05"]/*' />
    TileTemplateType_TileWide310x150PeekImageCollection05 = 20,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImageCollection06"]/*' />
    TileTemplateType_TileWide310x150PeekImageCollection06 = 21,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImageAndText01"]/*' />
    TileTemplateType_TileWide310x150PeekImageAndText01 = 22,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImageAndText02"]/*' />
    TileTemplateType_TileWide310x150PeekImageAndText02 = 23,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImage01"]/*' />
    TileTemplateType_TileWide310x150PeekImage01 = 24,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImage02"]/*' />
    TileTemplateType_TileWide310x150PeekImage02 = 25,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImage03"]/*' />
    TileTemplateType_TileWide310x150PeekImage03 = 26,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImage04"]/*' />
    TileTemplateType_TileWide310x150PeekImage04 = 27,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImage05"]/*' />
    TileTemplateType_TileWide310x150PeekImage05 = 28,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150PeekImage06"]/*' />
    TileTemplateType_TileWide310x150PeekImage06 = 29,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150SmallImageAndText01"]/*' />
    TileTemplateType_TileWide310x150SmallImageAndText01 = 30,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150SmallImageAndText02"]/*' />
    TileTemplateType_TileWide310x150SmallImageAndText02 = 31,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150SmallImageAndText03"]/*' />
    TileTemplateType_TileWide310x150SmallImageAndText03 = 32,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150SmallImageAndText04"]/*' />
    TileTemplateType_TileWide310x150SmallImageAndText04 = 33,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150SmallImageAndText05"]/*' />
    TileTemplateType_TileWide310x150SmallImageAndText05 = 34,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text01"]/*' />
    TileTemplateType_TileWide310x150Text01 = 35,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text02"]/*' />
    TileTemplateType_TileWide310x150Text02 = 36,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text03"]/*' />
    TileTemplateType_TileWide310x150Text03 = 37,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text04"]/*' />
    TileTemplateType_TileWide310x150Text04 = 38,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text05"]/*' />
    TileTemplateType_TileWide310x150Text05 = 39,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text06"]/*' />
    TileTemplateType_TileWide310x150Text06 = 40,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text07"]/*' />
    TileTemplateType_TileWide310x150Text07 = 41,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text08"]/*' />
    TileTemplateType_TileWide310x150Text08 = 42,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text09"]/*' />
    TileTemplateType_TileWide310x150Text09 = 43,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text10"]/*' />
    TileTemplateType_TileWide310x150Text10 = 44,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150Text11"]/*' />
    TileTemplateType_TileWide310x150Text11 = 45,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310BlockAndText01"]/*' />
    TileTemplateType_TileSquare310x310BlockAndText01 = 46,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310BlockAndText02"]/*' />
    TileTemplateType_TileSquare310x310BlockAndText02 = 47,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Image"]/*' />
    TileTemplateType_TileSquare310x310Image = 48,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310ImageAndText01"]/*' />
    TileTemplateType_TileSquare310x310ImageAndText01 = 49,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310ImageAndText02"]/*' />
    TileTemplateType_TileSquare310x310ImageAndText02 = 50,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310ImageAndTextOverlay01"]/*' />
    TileTemplateType_TileSquare310x310ImageAndTextOverlay01 = 51,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310ImageAndTextOverlay02"]/*' />
    TileTemplateType_TileSquare310x310ImageAndTextOverlay02 = 52,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310ImageAndTextOverlay03"]/*' />
    TileTemplateType_TileSquare310x310ImageAndTextOverlay03 = 53,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310ImageCollectionAndText01"]/*' />
    TileTemplateType_TileSquare310x310ImageCollectionAndText01 = 54,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310ImageCollectionAndText02"]/*' />
    TileTemplateType_TileSquare310x310ImageCollectionAndText02 = 55,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310ImageCollection"]/*' />
    TileTemplateType_TileSquare310x310ImageCollection = 56,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310SmallImagesAndTextList01"]/*' />
    TileTemplateType_TileSquare310x310SmallImagesAndTextList01 = 57,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310SmallImagesAndTextList02"]/*' />
    TileTemplateType_TileSquare310x310SmallImagesAndTextList02 = 58,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310SmallImagesAndTextList03"]/*' />
    TileTemplateType_TileSquare310x310SmallImagesAndTextList03 = 59,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310SmallImagesAndTextList04"]/*' />
    TileTemplateType_TileSquare310x310SmallImagesAndTextList04 = 60,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text01"]/*' />
    TileTemplateType_TileSquare310x310Text01 = 61,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text02"]/*' />
    TileTemplateType_TileSquare310x310Text02 = 62,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text03"]/*' />
    TileTemplateType_TileSquare310x310Text03 = 63,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text04"]/*' />
    TileTemplateType_TileSquare310x310Text04 = 64,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text05"]/*' />
    TileTemplateType_TileSquare310x310Text05 = 65,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text06"]/*' />
    TileTemplateType_TileSquare310x310Text06 = 66,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text07"]/*' />
    TileTemplateType_TileSquare310x310Text07 = 67,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text08"]/*' />
    TileTemplateType_TileSquare310x310Text08 = 68,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310TextList01"]/*' />
    TileTemplateType_TileSquare310x310TextList01 = 69,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310TextList02"]/*' />
    TileTemplateType_TileSquare310x310TextList02 = 70,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310TextList03"]/*' />
    TileTemplateType_TileSquare310x310TextList03 = 71,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310SmallImageAndText01"]/*' />
    TileTemplateType_TileSquare310x310SmallImageAndText01 = 72,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310SmallImagesAndTextList05"]/*' />
    TileTemplateType_TileSquare310x310SmallImagesAndTextList05 = 73,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare310x310Text09"]/*' />
    TileTemplateType_TileSquare310x310Text09 = 74,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare71x71IconWithBadge"]/*' />
    TileTemplateType_TileSquare71x71IconWithBadge = 75,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare150x150IconWithBadge"]/*' />
    TileTemplateType_TileSquare150x150IconWithBadge = 76,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileWide310x150IconWithBadgeAndText"]/*' />
    TileTemplateType_TileWide310x150IconWithBadgeAndText = 77,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileSquare71x71Image"]/*' />
    TileTemplateType_TileSquare71x71Image = 78,

    /// <include file='TileTemplateType.xml' path='doc/member[@name="TileTemplateType.TileTemplateType_TileTall150x310Image"]/*' />
    TileTemplateType_TileTall150x310Image = 79,
}
