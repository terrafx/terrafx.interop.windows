// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="CATID_BrowsableShellExt" /> property is correct.</summary>
        [Test]
        public static void CATID_BrowsableShellExtTest()
        {
            Assert.That(CATID_BrowsableShellExt, Is.EqualTo(new Guid(0x00021490, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="CATID_BrowseInPlace" /> property is correct.</summary>
        [Test]
        public static void CATID_BrowseInPlaceTest()
        {
            Assert.That(CATID_BrowseInPlace, Is.EqualTo(new Guid(0x00021491, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="CATID_DeskBand" /> property is correct.</summary>
        [Test]
        public static void CATID_DeskBandTest()
        {
            Assert.That(CATID_DeskBand, Is.EqualTo(new Guid(0x00021492, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="CATID_InfoBand" /> property is correct.</summary>
        [Test]
        public static void CATID_InfoBandTest()
        {
            Assert.That(CATID_InfoBand, Is.EqualTo(new Guid(0x00021493, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="CATID_CommBand" /> property is correct.</summary>
        [Test]
        public static void CATID_CommBandTest()
        {
            Assert.That(CATID_CommBand, Is.EqualTo(new Guid(0x00021494, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_Intshcut" /> property is correct.</summary>
        [Test]
        public static void FMTID_IntshcutTest()
        {
            Assert.That(FMTID_Intshcut, Is.EqualTo(new Guid(0x000214A0, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_InternetSite" /> property is correct.</summary>
        [Test]
        public static void FMTID_InternetSiteTest()
        {
            Assert.That(FMTID_InternetSite, Is.EqualTo(new Guid(0x000214A1, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="CGID_Explorer" /> property is correct.</summary>
        [Test]
        public static void CGID_ExplorerTest()
        {
            Assert.That(CGID_Explorer, Is.EqualTo(new Guid(0x000214D0, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="CGID_ShellDocView" /> property is correct.</summary>
        [Test]
        public static void CGID_ShellDocViewTest()
        {
            Assert.That(CGID_ShellDocView, Is.EqualTo(new Guid(0x000214D1, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="CGID_ShellServiceObject" /> property is correct.</summary>
        [Test]
        public static void CGID_ShellServiceObjectTest()
        {
            Assert.That(CGID_ShellServiceObject, Is.EqualTo(new Guid(0x000214D2, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="CGID_ExplorerBarDoc" /> property is correct.</summary>
        [Test]
        public static void CGID_ExplorerBarDocTest()
        {
            Assert.That(CGID_ExplorerBarDoc, Is.EqualTo(new Guid(0x000214D3, 0, 0, 0xC0, 0, 0, 0, 0, 0, 0, 0x46)));
        }

        /// <summary>Validates that the value of the <see cref="SID_DefView" /> property is correct.</summary>
        [Test]
        public static void SID_DefViewTest()
        {
            Assert.That(SID_DefView, Is.EqualTo(new Guid(0x6D12FE80, 0x7911, 0x11CF, 0x95, 0x34, 0x00, 0x00, 0xC0, 0x5B, 0xAE, 0x0B)));
        }

        /// <summary>Validates that the value of the <see cref="CGID_DefView" /> property is correct.</summary>
        [Test]
        public static void CGID_DefViewTest()
        {
            Assert.That(CGID_DefView, Is.EqualTo(new Guid(0x4af07f10, 0xd231, 0x11d0, 0xb9, 0x42, 0x0, 0xa0, 0xc9, 0x3, 0x12, 0xe1)));
        }

        /// <summary>Validates that the value of the <see cref="VID_LargeIcons" /> property is correct.</summary>
        [Test]
        public static void VID_LargeIconsTest()
        {
            Assert.That(VID_LargeIcons, Is.EqualTo(new Guid(0x0057D0E0, 0x3573, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)));
        }

        /// <summary>Validates that the value of the <see cref="VID_SmallIcons" /> property is correct.</summary>
        [Test]
        public static void VID_SmallIconsTest()
        {
            Assert.That(VID_SmallIcons, Is.EqualTo(new Guid(0x089000C0, 0x3573, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)));
        }

        /// <summary>Validates that the value of the <see cref="VID_List" /> property is correct.</summary>
        [Test]
        public static void VID_ListTest()
        {
            Assert.That(VID_List, Is.EqualTo(new Guid(0x0E1FA5E0, 0x3573, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)));
        }

        /// <summary>Validates that the value of the <see cref="VID_Details" /> property is correct.</summary>
        [Test]
        public static void VID_DetailsTest()
        {
            Assert.That(VID_Details, Is.EqualTo(new Guid(0x137E7700, 0x3573, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62)));
        }

        /// <summary>Validates that the value of the <see cref="VID_Tile" /> property is correct.</summary>
        [Test]
        public static void VID_TileTest()
        {
            Assert.That(VID_Tile, Is.EqualTo(new Guid(0x65f125e5, 0x7be1, 0x4810, 0xba, 0x9d, 0xd2, 0x71, 0xc8, 0x43, 0x2c, 0xe3)));
        }

        /// <summary>Validates that the value of the <see cref="VID_Content" /> property is correct.</summary>
        [Test]
        public static void VID_ContentTest()
        {
            Assert.That(VID_Content, Is.EqualTo(new Guid(0x30c2c434, 0x0889, 0x4c8d, 0x98, 0x5d, 0xa9, 0xf7, 0x18, 0x30, 0xb0, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="VID_Thumbnails" /> property is correct.</summary>
        [Test]
        public static void VID_ThumbnailsTest()
        {
            Assert.That(VID_Thumbnails, Is.EqualTo(new Guid(0x8bebb290, 0x52d0, 0x11d0, 0xb7, 0xf4, 0x0, 0xc0, 0x4f, 0xd7, 0x6, 0xec)));
        }

        /// <summary>Validates that the value of the <see cref="VID_ThumbStrip" /> property is correct.</summary>
        [Test]
        public static void VID_ThumbStripTest()
        {
            Assert.That(VID_ThumbStrip, Is.EqualTo(new Guid(0x8EEFA624, 0xD1E9, 0x445B, 0x94, 0xB7, 0x74, 0xFB, 0xCE, 0x2E, 0xA1, 0x1A)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SInPlaceBrowser" /> property is correct.</summary>
        [Test]
        public static void SID_SInPlaceBrowserTest()
        {
            Assert.That(SID_SInPlaceBrowser, Is.EqualTo(new Guid(0x1D2AE02B, 0x3655, 0x46CC, 0xB6, 0x3A, 0x28, 0x59, 0x88, 0x15, 0x3B, 0xCA)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SSearchBoxInfo" /> property is correct.</summary>
        [Test]
        public static void SID_SSearchBoxInfoTest()
        {
            Assert.That(SID_SSearchBoxInfo, Is.EqualTo(new Guid(0x142daa61, 0x516b, 0x4713, 0xb4, 0x9c, 0xfb, 0x98, 0x5e, 0xf8, 0x29, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="SID_CommandsPropertyBag" /> property is correct.</summary>
        [Test]
        public static void SID_CommandsPropertyBagTest()
        {
            Assert.That(SID_CommandsPropertyBag, Is.EqualTo(new Guid(0x6e043250, 0x4416, 0x485c, 0xb1, 0x43, 0xe6, 0x2a, 0x76, 0x0d, 0x9f, 0xe5)));
        }

        /// <summary>Validates that the value of the <see cref="SID_STopLevelBrowser" /> property is correct.</summary>
        [Test]
        public static void SID_STopLevelBrowserTest()
        {
            Assert.That(SID_STopLevelBrowser, Is.EqualTo(new Guid(0x4C96BE40, 0x915C, 0x11CF, 0x99, 0xD3, 0x00, 0xAA, 0x00, 0x4A, 0xE8, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="CGID_ShortCut" /> property is correct.</summary>
        [Test]
        public static void CGID_ShortCutTest()
        {
            Assert.That(CGID_ShortCut, Is.EqualTo(new Guid(0x93a68750, 0x951a, 0x11d1, 0x94, 0x6f, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_ShellDetails" /> property is correct.</summary>
        [Test]
        public static void FMTID_ShellDetailsTest()
        {
            Assert.That(FMTID_ShellDetails, Is.EqualTo(new Guid(0x28636aa6, 0x953d, 0x11d2, 0xb5, 0xd6, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_Storage" /> property is correct.</summary>
        [Test]
        public static void FMTID_StorageTest()
        {
            Assert.That(FMTID_Storage, Is.EqualTo(new Guid(0xb725f130, 0x47ef, 0x101a, 0xa5, 0xf1, 0x02, 0x60, 0x8c, 0x9e, 0xeb, 0xac)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_ImageProperties" /> property is correct.</summary>
        [Test]
        public static void FMTID_ImagePropertiesTest()
        {
            Assert.That(FMTID_ImageProperties, Is.EqualTo(new Guid(0x14b81da1, 0x0135, 0x4d31, 0x96, 0xd9, 0x6c, 0xbf, 0xc9, 0x67, 0x1a, 0x99)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_CustomImageProperties" /> property is correct.</summary>
        [Test]
        public static void FMTID_CustomImagePropertiesTest()
        {
            Assert.That(FMTID_CustomImageProperties, Is.EqualTo(new Guid(0x7ecd8b0e, 0xc136, 0x4a9b, 0x94, 0x11, 0x4e, 0xbd, 0x66, 0x73, 0xcc, 0xc3)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_LibraryProperties" /> property is correct.</summary>
        [Test]
        public static void FMTID_LibraryPropertiesTest()
        {
            Assert.That(FMTID_LibraryProperties, Is.EqualTo(new Guid(0x5d76b67f, 0x9b3d, 0x44bb, 0xb6, 0xae, 0x25, 0xda, 0x4f, 0x63, 0x8a, 0x67)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_Displaced" /> property is correct.</summary>
        [Test]
        public static void FMTID_DisplacedTest()
        {
            Assert.That(FMTID_Displaced, Is.EqualTo(new Guid(0x9b174b33, 0x40ff, 0x11d2, 0xa2, 0x7e, 0x0, 0xc0, 0x4f, 0xc3, 0x8, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_Briefcase" /> property is correct.</summary>
        [Test]
        public static void FMTID_BriefcaseTest()
        {
            Assert.That(FMTID_Briefcase, Is.EqualTo(new Guid(0x328d8b21, 0x7729, 0x4bfc, 0x95, 0x4c, 0x90, 0x2b, 0x32, 0x9d, 0x56, 0xb0)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_Misc" /> property is correct.</summary>
        [Test]
        public static void FMTID_MiscTest()
        {
            Assert.That(FMTID_Misc, Is.EqualTo(new Guid(0x9b174b34, 0x40ff, 0x11d2, 0xa2, 0x7e, 0x0, 0xc0, 0x4f, 0xc3, 0x8, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_WebView" /> property is correct.</summary>
        [Test]
        public static void FMTID_WebViewTest()
        {
            Assert.That(FMTID_WebView, Is.EqualTo(new Guid(0xf2275480, 0xf782, 0x4291, 0xbd, 0x94, 0xf1, 0x36, 0x93, 0x51, 0x3a, 0xec)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_MUSIC" /> property is correct.</summary>
        [Test]
        public static void FMTID_MUSICTest()
        {
            Assert.That(FMTID_MUSIC, Is.EqualTo(new Guid(0x56a3372e, 0xce9c, 0x11d2, 0x9f, 0xe, 0x0, 0x60, 0x97, 0xc6, 0x86, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_DRM" /> property is correct.</summary>
        [Test]
        public static void FMTID_DRMTest()
        {
            Assert.That(FMTID_DRM, Is.EqualTo(new Guid(0xaeac19e4, 0x89ae, 0x4508, 0xb9, 0xb7, 0xbb, 0x86, 0x7a, 0xbe, 0xe2, 0xed)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_Volume" /> property is correct.</summary>
        [Test]
        public static void FMTID_VolumeTest()
        {
            Assert.That(FMTID_Volume, Is.EqualTo(new Guid(0x9b174b35, 0x40ff, 0x11d2, 0xa2, 0x7e, 0x0, 0xc0, 0x4f, 0xc3, 0x8, 0x71)));
        }

        /// <summary>Validates that the value of the <see cref="FMTID_Query" /> property is correct.</summary>
        [Test]
        public static void FMTID_QueryTest()
        {
            Assert.That(FMTID_Query, Is.EqualTo(new Guid(0x49691c90, 0x7e17, 0x101a, 0xa9, 0x1c, 0x08, 0x00, 0x2b, 0x2e, 0xcd, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="SID_STopWindow" /> property is correct.</summary>
        [Test]
        public static void SID_STopWindowTest()
        {
            Assert.That(SID_STopWindow, Is.EqualTo(new Guid(0x49e1b500, 0x4636, 0x11d3, 0x97, 0xf7, 0x0, 0xc0, 0x4f, 0x45, 0xd0, 0xb3)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SGetViewFromViewDual" /> property is correct.</summary>
        [Test]
        public static void SID_SGetViewFromViewDualTest()
        {
            Assert.That(SID_SGetViewFromViewDual, Is.EqualTo(new Guid(0x889A935D, 0x971E, 0x4B12, 0xB9, 0x0C, 0x24, 0xDF, 0xC9, 0xE1, 0xE5, 0xE8)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_SFObject" /> property is correct.</summary>
        [Test]
        public static void BHID_SFObjectTest()
        {
            Assert.That(BHID_SFObject, Is.EqualTo(new Guid(0x3981e224, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_SFUIObject" /> property is correct.</summary>
        [Test]
        public static void BHID_SFUIObjectTest()
        {
            Assert.That(BHID_SFUIObject, Is.EqualTo(new Guid(0x3981e225, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_SFViewObject" /> property is correct.</summary>
        [Test]
        public static void BHID_SFViewObjectTest()
        {
            Assert.That(BHID_SFViewObject, Is.EqualTo(new Guid(0x3981e226, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_Storage" /> property is correct.</summary>
        [Test]
        public static void BHID_StorageTest()
        {
            Assert.That(BHID_Storage, Is.EqualTo(new Guid(0x3981e227, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_Stream" /> property is correct.</summary>
        [Test]
        public static void BHID_StreamTest()
        {
            Assert.That(BHID_Stream, Is.EqualTo(new Guid(0x1cebb3ab, 0x7c10, 0x499a, 0xa4, 0x17, 0x92, 0xca, 0x16, 0xc4, 0xcb, 0x83)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_RandomAccessStream" /> property is correct.</summary>
        [Test]
        public static void BHID_RandomAccessStreamTest()
        {
            Assert.That(BHID_RandomAccessStream, Is.EqualTo(new Guid(0xf16fc93b, 0x77ae, 0x4cfe, 0xbd, 0xa7, 0xa8, 0x66, 0xee, 0xa6, 0x87, 0x8d)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_LinkTargetItem" /> property is correct.</summary>
        [Test]
        public static void BHID_LinkTargetItemTest()
        {
            Assert.That(BHID_LinkTargetItem, Is.EqualTo(new Guid(0x3981e228, 0xf559, 0x11d3, 0x8e, 0x3a, 0x00, 0xc0, 0x4f, 0x68, 0x37, 0xd5)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_StorageEnum" /> property is correct.</summary>
        [Test]
        public static void BHID_StorageEnumTest()
        {
            Assert.That(BHID_StorageEnum, Is.EqualTo(new Guid(0x4621a4e3, 0xf0d6, 0x4773, 0x8a, 0x9c, 0x46, 0xe7, 0x7b, 0x17, 0x48, 0x40)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_Transfer" /> property is correct.</summary>
        [Test]
        public static void BHID_TransferTest()
        {
            Assert.That(BHID_Transfer, Is.EqualTo(new Guid(0xd5e346a1, 0xf753, 0x4932, 0xb4, 0x3, 0x45, 0x74, 0x80, 0xe, 0x24, 0x98)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_PropertyStore" /> property is correct.</summary>
        [Test]
        public static void BHID_PropertyStoreTest()
        {
            Assert.That(BHID_PropertyStore, Is.EqualTo(new Guid(0x0384e1a4, 0x1523, 0x439c, 0xa4, 0xc8, 0xab, 0x91, 0x10, 0x52, 0xf5, 0x86)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_ThumbnailHandler" /> property is correct.</summary>
        [Test]
        public static void BHID_ThumbnailHandlerTest()
        {
            Assert.That(BHID_ThumbnailHandler, Is.EqualTo(new Guid(0x7b2e650a, 0x8e20, 0x4f4a, 0xb0, 0x9e, 0x65, 0x97, 0xaf, 0xc7, 0x2f, 0xb0)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_EnumItems" /> property is correct.</summary>
        [Test]
        public static void BHID_EnumItemsTest()
        {
            Assert.That(BHID_EnumItems, Is.EqualTo(new Guid(0x94f60519, 0x2850, 0x4924, 0xaa, 0x5a, 0xd1, 0x5e, 0x84, 0x86, 0x80, 0x39)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_DataObject" /> property is correct.</summary>
        [Test]
        public static void BHID_DataObjectTest()
        {
            Assert.That(BHID_DataObject, Is.EqualTo(new Guid(0xb8c0bd9f, 0xed24, 0x455c, 0x83, 0xe6, 0xd5, 0x39, 0xc, 0x4f, 0xe8, 0xc4)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_AssociationArray" /> property is correct.</summary>
        [Test]
        public static void BHID_AssociationArrayTest()
        {
            Assert.That(BHID_AssociationArray, Is.EqualTo(new Guid(0xbea9ef17, 0x82f1, 0x4f60, 0x92, 0x84, 0x4f, 0x8d, 0xb7, 0x5c, 0x3b, 0xe9)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_Filter" /> property is correct.</summary>
        [Test]
        public static void BHID_FilterTest()
        {
            Assert.That(BHID_Filter, Is.EqualTo(new Guid(0x38d08778, 0xf557, 0x4690, 0x9e, 0xbf, 0xba, 0x54, 0x70, 0x6a, 0xd8, 0xf7)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_EnumAssocHandlers" /> property is correct.</summary>
        [Test]
        public static void BHID_EnumAssocHandlersTest()
        {
            Assert.That(BHID_EnumAssocHandlers, Is.EqualTo(new Guid(0xb8ab0b9c, 0xc2ec, 0x4f7a, 0x91, 0x8d, 0x31, 0x49, 0x00, 0xe6, 0x28, 0x0a)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_StorageItem" /> property is correct.</summary>
        [Test]
        public static void BHID_StorageItemTest()
        {
            Assert.That(BHID_StorageItem, Is.EqualTo(new Guid(0x404e2109, 0x77d2, 0x4699, 0xa5, 0xa0, 0x4f, 0xdf, 0x10, 0xdb, 0x98, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="BHID_FilePlaceholder" /> property is correct.</summary>
        [Test]
        public static void BHID_FilePlaceholderTest()
        {
            Assert.That(BHID_FilePlaceholder, Is.EqualTo(new Guid(0x8677dceb, 0xaae0, 0x4005, 0x8d, 0x3d, 0x54, 0x7f, 0xa8, 0x52, 0xf8, 0x25)));
        }

        /// <summary>Validates that the value of the <see cref="CATID_FilePlaceholderMergeHandler" /> property is correct.</summary>
        [Test]
        public static void CATID_FilePlaceholderMergeHandlerTest()
        {
            Assert.That(CATID_FilePlaceholderMergeHandler, Is.EqualTo(new Guid(0x3e9c9a51, 0xd4aa, 0x4870, 0xb4, 0x7c, 0x74, 0x24, 0xb4, 0x91, 0xf1, 0xcc)));
        }

        /// <summary>Validates that the value of the <see cref="SID_CtxQueryAssociations" /> property is correct.</summary>
        [Test]
        public static void SID_CtxQueryAssociationsTest()
        {
            Assert.That(SID_CtxQueryAssociations, Is.EqualTo(new Guid(0xfaadfc40, 0xb777, 0x4b69, 0xaa, 0x81, 0x77, 0x03, 0x5e, 0xf0, 0xe6, 0xe8)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SMenuBandChild" /> property is correct.</summary>
        [Test]
        public static void SID_SMenuBandChildTest()
        {
            Assert.That(SID_SMenuBandChild, Is.EqualTo(new Guid(0xed9cc020, 0x8b9, 0x11d1, 0x98, 0x23, 0x0, 0xc0, 0x4f, 0xd9, 0x19, 0x72)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SMenuBandParent" /> property is correct.</summary>
        [Test]
        public static void SID_SMenuBandParentTest()
        {
            Assert.That(SID_SMenuBandParent, Is.EqualTo(new Guid(0x8c278eec, 0x3eab, 0x11d1, 0x8c, 0xb0, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SMenuPopup" /> property is correct.</summary>
        [Test]
        public static void SID_SMenuPopupTest()
        {
            Assert.That(SID_SMenuPopup, Is.EqualTo(new Guid(0xD1E7AFEB, 0x6A2E, 0x11d0, 0x8C, 0x78, 0x0, 0xC0, 0x4F, 0xD9, 0x18, 0xB4)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SMenuBandBottomSelected" /> property is correct.</summary>
        [Test]
        public static void SID_SMenuBandBottomSelectedTest()
        {
            Assert.That(SID_SMenuBandBottomSelected, Is.EqualTo(new Guid(0x165ebaf4, 0x6d51, 0x11d2, 0x83, 0xad, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SMenuBandBottom" /> property is correct.</summary>
        [Test]
        public static void SID_SMenuBandBottomTest()
        {
            Assert.That(SID_SMenuBandBottom, Is.EqualTo(new Guid(0x743ca664, 0xdeb, 0x11d1, 0x98, 0x25, 0x0, 0xc0, 0x4f, 0xd9, 0x19, 0x72)));
        }

        /// <summary>Validates that the value of the <see cref="SID_MenuShellFolder" /> property is correct.</summary>
        [Test]
        public static void SID_MenuShellFolderTest()
        {
            Assert.That(SID_MenuShellFolder, Is.EqualTo(new Guid(0xa6c17eb4, 0x2d65, 0x11d2, 0x83, 0x8f, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0xd0)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SMenuBandContextMenuModifier" /> property is correct.</summary>
        [Test]
        public static void SID_SMenuBandContextMenuModifierTest()
        {
            Assert.That(SID_SMenuBandContextMenuModifier, Is.EqualTo(new Guid(0x39545874, 0x7162, 0x465e, 0xb7, 0x83, 0x2a, 0xa1, 0x87, 0x4f, 0xef, 0x81)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SMenuBandBKContextMenu" /> property is correct.</summary>
        [Test]
        public static void SID_SMenuBandBKContextMenuTest()
        {
            Assert.That(SID_SMenuBandBKContextMenu, Is.EqualTo(new Guid(0x164bbd86, 0x1d0d, 0x4de0, 0x9a, 0x3b, 0xd9, 0x72, 0x96, 0x47, 0xc2, 0xb8)));
        }

        /// <summary>Validates that the value of the <see cref="CGID_MENUDESKBAR" /> property is correct.</summary>
        [Test]
        public static void CGID_MENUDESKBARTest()
        {
            Assert.That(CGID_MENUDESKBAR, Is.EqualTo(new Guid(0x5c9f0a12, 0x959e, 0x11d0, 0xa3, 0xa4, 0x0, 0xa0, 0xc9, 0x8, 0x26, 0x36)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SMenuBandTop" /> property is correct.</summary>
        [Test]
        public static void SID_SMenuBandTopTest()
        {
            Assert.That(SID_SMenuBandTop, Is.EqualTo(new Guid(0x9493a810, 0xec38, 0x11d0, 0xbc, 0x46, 0x0, 0xaa, 0x0, 0x6c, 0xe2, 0xf5)));
        }

        /// <summary>Validates that the value of the <see cref="SID_SCommDlgBrowser" /> property is correct.</summary>
        [Test]
        public static void SID_SCommDlgBrowserTest()
        {
            Assert.That(SID_SCommDlgBrowser, Is.EqualTo(new Guid(0x80f30233, 0xb7df, 0x11d2, 0xa3, 0x3b, 0x0, 0x60, 0x97, 0xdf, 0x5b, 0xd4)));
        }

        /// <summary>Validates that the value of the <see cref="CPFG_LOGON_USERNAME" /> property is correct.</summary>
        [Test]
        public static void CPFG_LOGON_USERNAMETest()
        {
            Assert.That(CPFG_LOGON_USERNAME, Is.EqualTo(new Guid(0xda15bbe8, 0x954d, 0x4fd3, 0xb0, 0xf4, 0x1f, 0xb5, 0xb9, 0x0b, 0x17, 0x4b)));
        }

        /// <summary>Validates that the value of the <see cref="CPFG_LOGON_PASSWORD" /> property is correct.</summary>
        [Test]
        public static void CPFG_LOGON_PASSWORDTest()
        {
            Assert.That(CPFG_LOGON_PASSWORD, Is.EqualTo(new Guid(0x60624cfa, 0xa477, 0x47b1, 0x8a, 0x8e, 0x3a, 0x4a, 0x19, 0x98, 0x18, 0x27)));
        }

        /// <summary>Validates that the value of the <see cref="CPFG_SMARTCARD_USERNAME" /> property is correct.</summary>
        [Test]
        public static void CPFG_SMARTCARD_USERNAMETest()
        {
            Assert.That(CPFG_SMARTCARD_USERNAME, Is.EqualTo(new Guid(0x3e1ecf69, 0x568c, 0x4d96, 0x9d, 0x59, 0x46, 0x44, 0x41, 0x74, 0xe2, 0xd6)));
        }

        /// <summary>Validates that the value of the <see cref="CPFG_SMARTCARD_PIN" /> property is correct.</summary>
        [Test]
        public static void CPFG_SMARTCARD_PINTest()
        {
            Assert.That(CPFG_SMARTCARD_PIN, Is.EqualTo(new Guid(0x4fe5263b, 0x9181, 0x46c1, 0xb0, 0xa4, 0x9d, 0xed, 0xd4, 0xdb, 0x7d, 0xea)));
        }

        /// <summary>Validates that the value of the <see cref="CPFG_CREDENTIAL_PROVIDER_LOGO" /> property is correct.</summary>
        [Test]
        public static void CPFG_CREDENTIAL_PROVIDER_LOGOTest()
        {
            Assert.That(CPFG_CREDENTIAL_PROVIDER_LOGO, Is.EqualTo(new Guid(0x2d837775, 0xf6cd, 0x464e, 0xa7, 0x45, 0x48, 0x2f, 0xd0, 0xb4, 0x74, 0x93)));
        }

        /// <summary>Validates that the value of the <see cref="CPFG_CREDENTIAL_PROVIDER_LABEL" /> property is correct.</summary>
        [Test]
        public static void CPFG_CREDENTIAL_PROVIDER_LABELTest()
        {
            Assert.That(CPFG_CREDENTIAL_PROVIDER_LABEL, Is.EqualTo(new Guid(0x286bbff3, 0xbad4, 0x438f, 0xb0, 0x7, 0x79, 0xb7, 0x26, 0x7c, 0x3d, 0x48)));
        }

        /// <summary>Validates that the value of the <see cref="CPFG_STANDALONE_SUBMIT_BUTTON" /> property is correct.</summary>
        [Test]
        public static void CPFG_STANDALONE_SUBMIT_BUTTONTest()
        {
            Assert.That(CPFG_STANDALONE_SUBMIT_BUTTON, Is.EqualTo(new Guid(0x0b7b0ad8, 0xcc36, 0x4d59, 0x80, 0x2b, 0x82, 0xf7, 0x14, 0xfa, 0x70, 0x22)));
        }

        /// <summary>Validates that the value of the <see cref="CPFG_STYLE_LINK_AS_BUTTON" /> property is correct.</summary>
        [Test]
        public static void CPFG_STYLE_LINK_AS_BUTTONTest()
        {
            Assert.That(CPFG_STYLE_LINK_AS_BUTTON, Is.EqualTo(new Guid(0x088fa508, 0x94a6, 0x4430, 0xa4, 0xcb, 0x6f, 0xc6, 0xe3, 0xc0, 0xb9, 0xe2)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Invalid" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_InvalidTest()
        {
            Assert.That(FOLDERTYPEID_Invalid, Is.EqualTo(new Guid(0x57807898, 0x8c4f, 0x4462, 0xbb, 0x63, 0x71, 0x04, 0x23, 0x80, 0xb1, 0x09)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Generic" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_GenericTest()
        {
            Assert.That(FOLDERTYPEID_Generic, Is.EqualTo(new Guid(0x5c4f28b5, 0xf869, 0x4e84, 0x8e, 0x60, 0xf1, 0x1d, 0xb9, 0x7c, 0x5c, 0xc7)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_GenericSearchResults" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_GenericSearchResultsTest()
        {
            Assert.That(FOLDERTYPEID_GenericSearchResults, Is.EqualTo(new Guid(0x7fde1a1e, 0x8b31, 0x49a5, 0x93, 0xb8, 0x6b, 0xe1, 0x4c, 0xfa, 0x49, 0x43)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_GenericLibrary" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_GenericLibraryTest()
        {
            Assert.That(FOLDERTYPEID_GenericLibrary, Is.EqualTo(new Guid(0x5f4eab9a, 0x6833, 0x4f61, 0x89, 0x9d, 0x31, 0xcf, 0x46, 0x97, 0x9d, 0x49)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Documents" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_DocumentsTest()
        {
            Assert.That(FOLDERTYPEID_Documents, Is.EqualTo(new Guid(0x7d49d726, 0x3c21, 0x4f05, 0x99, 0xaa, 0xfd, 0xc2, 0xc9, 0x47, 0x46, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Pictures" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_PicturesTest()
        {
            Assert.That(FOLDERTYPEID_Pictures, Is.EqualTo(new Guid(0xb3690e58, 0xe961, 0x423b, 0xb6, 0x87, 0x38, 0x6e, 0xbf, 0xd8, 0x32, 0x39)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Music" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_MusicTest()
        {
            Assert.That(FOLDERTYPEID_Music, Is.EqualTo(new Guid(0x94d6ddcc, 0x4a68, 0x4175, 0xa3, 0x74, 0xbd, 0x58, 0x4a, 0x51, 0x0b, 0x78)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Videos" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_VideosTest()
        {
            Assert.That(FOLDERTYPEID_Videos, Is.EqualTo(new Guid(0x5fa96407, 0x7e77, 0x483c, 0xac, 0x93, 0x69, 0x1d, 0x05, 0x85, 0x0d, 0xe8)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Downloads" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_DownloadsTest()
        {
            Assert.That(FOLDERTYPEID_Downloads, Is.EqualTo(new Guid(0x885a186e, 0xa440, 0x4ada, 0x81, 0x2b, 0xdb, 0x87, 0x1b, 0x94, 0x22, 0x59)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_UserFiles" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_UserFilesTest()
        {
            Assert.That(FOLDERTYPEID_UserFiles, Is.EqualTo(new Guid(0xcd0fc69b, 0x71e2, 0x46e5, 0x96, 0x90, 0x5b, 0xcd, 0x9f, 0x57, 0xaa, 0xb3)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_UsersLibraries" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_UsersLibrariesTest()
        {
            Assert.That(FOLDERTYPEID_UsersLibraries, Is.EqualTo(new Guid(0xc4d98f09, 0x6124, 0x4fe0, 0x99, 0x42, 0x82, 0x64, 0x16, 0x8, 0x2d, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_OtherUsers" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_OtherUsersTest()
        {
            Assert.That(FOLDERTYPEID_OtherUsers, Is.EqualTo(new Guid(0xb337fd00, 0x9dd5, 0x4635, 0xa6, 0xd4, 0xda, 0x33, 0xfd, 0x10, 0x2b, 0x7a)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_PublishedItems" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_PublishedItemsTest()
        {
            Assert.That(FOLDERTYPEID_PublishedItems, Is.EqualTo(new Guid(0x7f2f5b96, 0xff74, 0x41da, 0xaf, 0xd8, 0x1c, 0x78, 0xa5, 0xf3, 0xae, 0xa2)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Communications" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_CommunicationsTest()
        {
            Assert.That(FOLDERTYPEID_Communications, Is.EqualTo(new Guid(0x91475fe5, 0x586b, 0x4eba, 0x8d, 0x75, 0xd1, 0x74, 0x34, 0xb8, 0xcd, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Contacts" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_ContactsTest()
        {
            Assert.That(FOLDERTYPEID_Contacts, Is.EqualTo(new Guid(0xde2b70ec, 0x9bf7, 0x4a93, 0xbd, 0x3d, 0x24, 0x3f, 0x78, 0x81, 0xd4, 0x92)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_StartMenu" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_StartMenuTest()
        {
            Assert.That(FOLDERTYPEID_StartMenu, Is.EqualTo(new Guid(0xef87b4cb, 0xf2ce, 0x4785, 0x86, 0x58, 0x4c, 0xa6, 0xc6, 0x3e, 0x38, 0xc6)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_RecordedTV" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_RecordedTVTest()
        {
            Assert.That(FOLDERTYPEID_RecordedTV, Is.EqualTo(new Guid(0x5557a28f, 0x5da6, 0x4f83, 0x88, 0x09, 0xc2, 0xc9, 0x8a, 0x11, 0xa6, 0xfa)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_SavedGames" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_SavedGamesTest()
        {
            Assert.That(FOLDERTYPEID_SavedGames, Is.EqualTo(new Guid(0xd0363307, 0x28cb, 0x4106, 0x9f, 0x23, 0x29, 0x56, 0xe3, 0xe5, 0xe0, 0xe7)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_OpenSearch" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_OpenSearchTest()
        {
            Assert.That(FOLDERTYPEID_OpenSearch, Is.EqualTo(new Guid(0x8faf9629, 0x1980, 0x46ff, 0x80, 0x23, 0x9d, 0xce, 0xab, 0x9c, 0x3e, 0xe3)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_SearchConnector" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_SearchConnectorTest()
        {
            Assert.That(FOLDERTYPEID_SearchConnector, Is.EqualTo(new Guid(0x982725ee, 0x6f47, 0x479e, 0xb4, 0x47, 0x81, 0x2b, 0xfa, 0x7d, 0x2e, 0x8f)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_AccountPictures" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_AccountPicturesTest()
        {
            Assert.That(FOLDERTYPEID_AccountPictures, Is.EqualTo(new Guid(0xdb2a5d8f, 0x06e6, 0x4007, 0xab, 0xa6, 0xaf, 0x87, 0x7d, 0x52, 0x6e, 0xa6)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Games" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_GamesTest()
        {
            Assert.That(FOLDERTYPEID_Games, Is.EqualTo(new Guid(0xb689b0d0, 0x76d3, 0x4cbb, 0x87, 0xf7, 0x58, 0x5d, 0x0e, 0x0c, 0xe0, 0x70)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_ControlPanelCategory" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_ControlPanelCategoryTest()
        {
            Assert.That(FOLDERTYPEID_ControlPanelCategory, Is.EqualTo(new Guid(0xde4f0660, 0xfa10, 0x4b8f, 0xa4, 0x94, 0x06, 0x8b, 0x20, 0xb2, 0x23, 0x07)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_ControlPanelClassic" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_ControlPanelClassicTest()
        {
            Assert.That(FOLDERTYPEID_ControlPanelClassic, Is.EqualTo(new Guid(0x0c3794f3, 0xb545, 0x43aa, 0xa3, 0x29, 0xc3, 0x74, 0x30, 0xc5, 0x8d, 0x2a)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Printers" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_PrintersTest()
        {
            Assert.That(FOLDERTYPEID_Printers, Is.EqualTo(new Guid(0x2c7bbec6, 0xc844, 0x4a0a, 0x91, 0xfa, 0xce, 0xf6, 0xf5, 0x9c, 0xfd, 0xa1)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_RecycleBin" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_RecycleBinTest()
        {
            Assert.That(FOLDERTYPEID_RecycleBin, Is.EqualTo(new Guid(0xd6d9e004, 0xcd87, 0x442b, 0x9d, 0x57, 0x5e, 0x0a, 0xeb, 0x4f, 0x6f, 0x72)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_SoftwareExplorer" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_SoftwareExplorerTest()
        {
            Assert.That(FOLDERTYPEID_SoftwareExplorer, Is.EqualTo(new Guid(0xd674391b, 0x52d9, 0x4e07, 0x83, 0x4e, 0x67, 0xc9, 0x86, 0x10, 0xf3, 0x9d)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_CompressedFolder" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_CompressedFolderTest()
        {
            Assert.That(FOLDERTYPEID_CompressedFolder, Is.EqualTo(new Guid(0x80213e82, 0xbcfd, 0x4c4f, 0x88, 0x17, 0xbb, 0x27, 0x60, 0x12, 0x67, 0xa9)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_NetworkExplorer" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_NetworkExplorerTest()
        {
            Assert.That(FOLDERTYPEID_NetworkExplorer, Is.EqualTo(new Guid(0x25cc242b, 0x9a7c, 0x4f51, 0x80, 0xe0, 0x7a, 0x29, 0x28, 0xfe, 0xbe, 0x42)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_Searches" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_SearchesTest()
        {
            Assert.That(FOLDERTYPEID_Searches, Is.EqualTo(new Guid(0x0b0ba2e3, 0x405f, 0x415e, 0xa6, 0xee, 0xca, 0xd6, 0x25, 0x20, 0x78, 0x53)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_SearchHome" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_SearchHomeTest()
        {
            Assert.That(FOLDERTYPEID_SearchHome, Is.EqualTo(new Guid(0x834d8a44, 0x0974, 0x4ed6, 0x86, 0x6e, 0xf2, 0x03, 0xd8, 0x0b, 0x38, 0x10)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_StorageProviderGeneric" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_StorageProviderGenericTest()
        {
            Assert.That(FOLDERTYPEID_StorageProviderGeneric, Is.EqualTo(new Guid(0x4F01EBC5, 0x2385, 0x41f2, 0xA2, 0x8E, 0x2C, 0x5C, 0x91, 0xFB, 0x56, 0xE0)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_StorageProviderDocuments" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_StorageProviderDocumentsTest()
        {
            Assert.That(FOLDERTYPEID_StorageProviderDocuments, Is.EqualTo(new Guid(0xDD61BD66, 0x70E8, 0x48dd, 0x96, 0x55, 0x65, 0xC5, 0xE1, 0xAA, 0xC2, 0xD1)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_StorageProviderPictures" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_StorageProviderPicturesTest()
        {
            Assert.That(FOLDERTYPEID_StorageProviderPictures, Is.EqualTo(new Guid(0x71d642a9, 0xf2b1, 0x42cd, 0xad, 0x92, 0xeb, 0x93, 0x0, 0xc7, 0xcc, 0xa)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_StorageProviderMusic" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_StorageProviderMusicTest()
        {
            Assert.That(FOLDERTYPEID_StorageProviderMusic, Is.EqualTo(new Guid(0x672ECD7E, 0xAF04, 0x4399, 0x87, 0x5C, 0x02, 0x90, 0x84, 0x5B, 0x62, 0x47)));
        }

        /// <summary>Validates that the value of the <see cref="FOLDERTYPEID_StorageProviderVideos" /> property is correct.</summary>
        [Test]
        public static void FOLDERTYPEID_StorageProviderVideosTest()
        {
            Assert.That(FOLDERTYPEID_StorageProviderVideos, Is.EqualTo(new Guid(0x51294DA1, 0xD7B1, 0x485b, 0x9E, 0x9A, 0x17, 0xCF, 0xFE, 0x33, 0xE1, 0x87)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_Icon" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_IconTest()
        {
            Assert.That(SYNCMGR_OBJECTID_Icon, Is.EqualTo(new Guid(0x6dbc85c3, 0x5d07, 0x4c72, 0xa7, 0x77, 0x7f, 0xec, 0x78, 0x7, 0x2c, 0x6)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_EventStore" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_EventStoreTest()
        {
            Assert.That(SYNCMGR_OBJECTID_EventStore, Is.EqualTo(new Guid(0x4bef34b9, 0xa786, 0x4075, 0xba, 0x88, 0xc, 0x2b, 0x9d, 0x89, 0xa9, 0x8f)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_ConflictStore" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_ConflictStoreTest()
        {
            Assert.That(SYNCMGR_OBJECTID_ConflictStore, Is.EqualTo(new Guid(0xd78181f4, 0x2389, 0x47e4, 0xa9, 0x60, 0x60, 0xbc, 0xc2, 0xed, 0x93, 0xb)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_BrowseContent" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_BrowseContentTest()
        {
            Assert.That(SYNCMGR_OBJECTID_BrowseContent, Is.EqualTo(new Guid(0x57cbb584, 0xe9b4, 0x47ae, 0xa1, 0x20, 0xc4, 0xdf, 0x33, 0x35, 0xde, 0xe2)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_ShowSchedule" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_ShowScheduleTest()
        {
            Assert.That(SYNCMGR_OBJECTID_ShowSchedule, Is.EqualTo(new Guid(0xedc6f3e3, 0x8441, 0x4109, 0xad, 0xf3, 0x6c, 0x1c, 0xa0, 0xb7, 0xde, 0x47)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_QueryBeforeActivate" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_QueryBeforeActivateTest()
        {
            Assert.That(SYNCMGR_OBJECTID_QueryBeforeActivate, Is.EqualTo(new Guid(0xd882d80b, 0xe7aa, 0x49ed, 0x86, 0xb7, 0xe6, 0xe1, 0xf7, 0x14, 0xcd, 0xfe)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_QueryBeforeDeactivate" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_QueryBeforeDeactivateTest()
        {
            Assert.That(SYNCMGR_OBJECTID_QueryBeforeDeactivate, Is.EqualTo(new Guid(0xa0efc282, 0x60e0, 0x460e, 0x93, 0x74, 0xea, 0x88, 0x51, 0x3c, 0xfc, 0x80)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_QueryBeforeEnable" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_QueryBeforeEnableTest()
        {
            Assert.That(SYNCMGR_OBJECTID_QueryBeforeEnable, Is.EqualTo(new Guid(0x4cbf7f0, 0x5beb, 0x4de1, 0xbc, 0x90, 0x90, 0x83, 0x45, 0xc4, 0x80, 0xf6)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_QueryBeforeDisable" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_QueryBeforeDisableTest()
        {
            Assert.That(SYNCMGR_OBJECTID_QueryBeforeDisable, Is.EqualTo(new Guid(0xbb5f64aa, 0xf004, 0x4eb5, 0x8e, 0x4d, 0x26, 0x75, 0x19, 0x66, 0x34, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_QueryBeforeDelete" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_QueryBeforeDeleteTest()
        {
            Assert.That(SYNCMGR_OBJECTID_QueryBeforeDelete, Is.EqualTo(new Guid(0xf76c3397, 0xafb3, 0x45d7, 0xa5, 0x9f, 0x5a, 0x49, 0xe9, 0x5, 0x43, 0x7e)));
        }

        /// <summary>Validates that the value of the <see cref="SYNCMGR_OBJECTID_EventLinkClick" /> property is correct.</summary>
        [Test]
        public static void SYNCMGR_OBJECTID_EventLinkClickTest()
        {
            Assert.That(SYNCMGR_OBJECTID_EventLinkClick, Is.EqualTo(new Guid(0x2203bdc1, 0x1af1, 0x4082, 0x8c, 0x30, 0x28, 0x39, 0x9f, 0x41, 0x38, 0x4c)));
        }

        /// <summary>Validates that the value of the <see cref="EP_NavPane" /> property is correct.</summary>
        [Test]
        public static void EP_NavPaneTest()
        {
            Assert.That(EP_NavPane, Is.EqualTo(new Guid(0xcb316b22, 0x25f7, 0x42b8, 0x8a, 0x09, 0x54, 0x0d, 0x23, 0xa4, 0x3c, 0x2f)));
        }

        /// <summary>Validates that the value of the <see cref="EP_Commands" /> property is correct.</summary>
        [Test]
        public static void EP_CommandsTest()
        {
            Assert.That(EP_Commands, Is.EqualTo(new Guid(0xd9745868, 0xca5f, 0x4a76, 0x91, 0xcd, 0xf5, 0xa1, 0x29, 0xfb, 0xb0, 0x76)));
        }

        /// <summary>Validates that the value of the <see cref="EP_Commands_Organize" /> property is correct.</summary>
        [Test]
        public static void EP_Commands_OrganizeTest()
        {
            Assert.That(EP_Commands_Organize, Is.EqualTo(new Guid(0x72e81700, 0xe3ec, 0x4660, 0xbf, 0x24, 0x3c, 0x3b, 0x7b, 0x64, 0x88, 0x06)));
        }

        /// <summary>Validates that the value of the <see cref="EP_Commands_View" /> property is correct.</summary>
        [Test]
        public static void EP_Commands_ViewTest()
        {
            Assert.That(EP_Commands_View, Is.EqualTo(new Guid(0x21f7c32d, 0xeeaa, 0x439b, 0xbb, 0x51, 0x37, 0xb9, 0x6f, 0xd6, 0xa9, 0x43)));
        }

        /// <summary>Validates that the value of the <see cref="EP_DetailsPane" /> property is correct.</summary>
        [Test]
        public static void EP_DetailsPaneTest()
        {
            Assert.That(EP_DetailsPane, Is.EqualTo(new Guid(0x43abf98b, 0x89b8, 0x472d, 0xb9, 0xce, 0xe6, 0x9b, 0x82, 0x29, 0xf0, 0x19)));
        }

        /// <summary>Validates that the value of the <see cref="EP_PreviewPane" /> property is correct.</summary>
        [Test]
        public static void EP_PreviewPaneTest()
        {
            Assert.That(EP_PreviewPane, Is.EqualTo(new Guid(0x893c63d1, 0x45c8, 0x4d17, 0xbe, 0x19, 0x22, 0x3b, 0xe7, 0x1b, 0xe3, 0x65)));
        }

        /// <summary>Validates that the value of the <see cref="EP_QueryPane" /> property is correct.</summary>
        [Test]
        public static void EP_QueryPaneTest()
        {
            Assert.That(EP_QueryPane, Is.EqualTo(new Guid(0x65bcde4f, 0x4f07, 0x4f27, 0x83, 0xa7, 0x1a, 0xfc, 0xa4, 0xdf, 0x7d, 0xdd)));
        }

        /// <summary>Validates that the value of the <see cref="EP_AdvQueryPane" /> property is correct.</summary>
        [Test]
        public static void EP_AdvQueryPaneTest()
        {
            Assert.That(EP_AdvQueryPane, Is.EqualTo(new Guid(0xb4e9db8b, 0x34ba, 0x4c39, 0xb5, 0xcc, 0x16, 0xa1, 0xbd, 0x2c, 0x41, 0x1c)));
        }

        /// <summary>Validates that the value of the <see cref="EP_StatusBar" /> property is correct.</summary>
        [Test]
        public static void EP_StatusBarTest()
        {
            Assert.That(EP_StatusBar, Is.EqualTo(new Guid(0x65fe56ce, 0x5cfe, 0x4bc4, 0xad, 0x8a, 0x7a, 0xe3, 0xfe, 0x7e, 0x8f, 0x7c)));
        }

        /// <summary>Validates that the value of the <see cref="EP_Ribbon" /> property is correct.</summary>
        [Test]
        public static void EP_RibbonTest()
        {
            Assert.That(EP_Ribbon, Is.EqualTo(new Guid(0xd27524a8, 0xc9f2, 0x4834, 0xa1, 0x6, 0xdf, 0x88, 0x89, 0xfd, 0x4f, 0x37)));
        }

        /// <summary>Validates that the value of the <see cref="CATID_LocationFactory" /> property is correct.</summary>
        [Test]
        public static void CATID_LocationFactoryTest()
        {
            Assert.That(CATID_LocationFactory, Is.EqualTo(new Guid(0x965c4d51, 0x8b76, 0x4e57, 0x80, 0xb7, 0x56, 0x4d, 0x2e, 0xa4, 0xb5, 0x5e)));
        }

        /// <summary>Validates that the value of the <see cref="CATID_LocationProvider" /> property is correct.</summary>
        [Test]
        public static void CATID_LocationProviderTest()
        {
            Assert.That(CATID_LocationProvider, Is.EqualTo(new Guid(0x1b3ca474, 0x2614, 0x414b, 0xb8, 0x13, 0x1a, 0xce, 0xca, 0x3e, 0x3d, 0xd8)));
        }

        /// <summary>Validates that the value of the <see cref="ItemCount_Property_GUID" /> property is correct.</summary>
        [Test]
        public static void ItemCount_Property_GUIDTest()
        {
            Assert.That(ItemCount_Property_GUID, Is.EqualTo(new Guid(0xabbf5c45, 0x5ccc, 0x47b7, 0xbb, 0x4e, 0x87, 0xcb, 0x87, 0xbb, 0xd1, 0x62)));
        }

        /// <summary>Validates that the value of the <see cref="SelectedItemCount_Property_GUID" /> property is correct.</summary>
        [Test]
        public static void SelectedItemCount_Property_GUIDTest()
        {
            Assert.That(SelectedItemCount_Property_GUID, Is.EqualTo(new Guid(0x8fe316d2, 0xe52, 0x460a, 0x9c, 0x1e, 0x48, 0xf2, 0x73, 0xd4, 0x70, 0xa3)));
        }

        /// <summary>Validates that the value of the <see cref="ItemIndex_Property_GUID" /> property is correct.</summary>
        [Test]
        public static void ItemIndex_Property_GUIDTest()
        {
            Assert.That(ItemIndex_Property_GUID, Is.EqualTo(new Guid(0x92a053da, 0x2969, 0x4021, 0xbf, 0x27, 0x51, 0x4c, 0xfc, 0x2e, 0x4a, 0x69)));
        }

        /// <summary>Validates that the value of the <see cref="CATID_SearchableApplication" /> property is correct.</summary>
        [Test]
        public static void CATID_SearchableApplicationTest()
        {
            Assert.That(CATID_SearchableApplication, Is.EqualTo(new Guid(0x366c292a, 0xd9b3, 0x4dbf, 0xbb, 0x70, 0xe6, 0x2e, 0xc3, 0xd0, 0xbb, 0xbf)));
        }
    }
}
