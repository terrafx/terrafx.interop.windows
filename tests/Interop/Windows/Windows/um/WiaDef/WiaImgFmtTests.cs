// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.WiaImgFmt;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WiaImgFmt" /> class.</summary>
public static partial class WiaImgFmtTests
{
    /// <summary>Validates that the value of the <see cref="WiaImgFmt_UNDEFINED" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_UNDEFINEDTest()
    {
        Assert.That(WiaImgFmt_UNDEFINED, Is.EqualTo(new Guid(0xb96b3ca9, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_RAWRGB" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_RAWRGBTest()
    {
        Assert.That(WiaImgFmt_RAWRGB, Is.EqualTo(new Guid(0xbca48b55, 0xf272, 0x4371, 0xb0, 0xf1, 0x4a, 0x15, 0x0d, 0x05, 0x7b, 0xb4)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_MEMORYBMP" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_MEMORYBMPTest()
    {
        Assert.That(WiaImgFmt_MEMORYBMP, Is.EqualTo(new Guid(0xb96b3caa, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_BMP" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_BMPTest()
    {
        Assert.That(WiaImgFmt_BMP, Is.EqualTo(new Guid(0xb96b3cab, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_EMF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_EMFTest()
    {
        Assert.That(WiaImgFmt_EMF, Is.EqualTo(new Guid(0xb96b3cac, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_WMF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_WMFTest()
    {
        Assert.That(WiaImgFmt_WMF, Is.EqualTo(new Guid(0xb96b3cad, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_JPEG" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_JPEGTest()
    {
        Assert.That(WiaImgFmt_JPEG, Is.EqualTo(new Guid(0xb96b3cae, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_PNG" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_PNGTest()
    {
        Assert.That(WiaImgFmt_PNG, Is.EqualTo(new Guid(0xb96b3caf, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_GIF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_GIFTest()
    {
        Assert.That(WiaImgFmt_GIF, Is.EqualTo(new Guid(0xb96b3cb0, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_TIFF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_TIFFTest()
    {
        Assert.That(WiaImgFmt_TIFF, Is.EqualTo(new Guid(0xb96b3cb1, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_EXIF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_EXIFTest()
    {
        Assert.That(WiaImgFmt_EXIF, Is.EqualTo(new Guid(0xb96b3cb2, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_PHOTOCD" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_PHOTOCDTest()
    {
        Assert.That(WiaImgFmt_PHOTOCD, Is.EqualTo(new Guid(0xb96b3cb3, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_FLASHPIX" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_FLASHPIXTest()
    {
        Assert.That(WiaImgFmt_FLASHPIX, Is.EqualTo(new Guid(0xb96b3cb4, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_ICO" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_ICOTest()
    {
        Assert.That(WiaImgFmt_ICO, Is.EqualTo(new Guid(0xb96b3cb5, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_CIFF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_CIFFTest()
    {
        Assert.That(WiaImgFmt_CIFF, Is.EqualTo(new Guid(0x9821a8ab, 0x3a7e, 0x4215, 0x94, 0xe0, 0xd2, 0x7a, 0x46, 0x0c, 0x03, 0xb2)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_PICT" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_PICTTest()
    {
        Assert.That(WiaImgFmt_PICT, Is.EqualTo(new Guid(0xa6bc85d8, 0x6b3e, 0x40ee, 0xa9, 0x5c, 0x25, 0xd4, 0x82, 0xe4, 0x1a, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_JPEG2K" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_JPEG2KTest()
    {
        Assert.That(WiaImgFmt_JPEG2K, Is.EqualTo(new Guid(0x344ee2b2, 0x39db, 0x4dde, 0x81, 0x73, 0xc4, 0xb7, 0x5f, 0x8f, 0x1e, 0x49)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_JPEG2KX" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_JPEG2KXTest()
    {
        Assert.That(WiaImgFmt_JPEG2KX, Is.EqualTo(new Guid(0x43e14614, 0xc80a, 0x4850, 0xba, 0xf3, 0x4b, 0x15, 0x2d, 0xc8, 0xda, 0x27)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_RAW" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_RAWTest()
    {
        Assert.That(WiaImgFmt_RAW, Is.EqualTo(new Guid(0x6f120719, 0xf1a8, 0x4e07, 0x9a, 0xde, 0x9b, 0x64, 0xc6, 0x3a, 0x3d, 0xcc)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_JBIG" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_JBIGTest()
    {
        Assert.That(WiaImgFmt_JBIG, Is.EqualTo(new Guid(0x41e8dd92, 0x2f0a, 0x43d4, 0x86, 0x36, 0xf1, 0x61, 0x4b, 0xa1, 0x1e, 0x46)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_JBIG2" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_JBIG2Test()
    {
        Assert.That(WiaImgFmt_JBIG2, Is.EqualTo(new Guid(0xbb8e7e67, 0x283c, 0x4235, 0x9e, 0x59, 0x0b, 0x9b, 0xf9, 0x4c, 0xa6, 0x87)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_RTF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_RTFTest()
    {
        Assert.That(WiaImgFmt_RTF, Is.EqualTo(new Guid(0x573dd6a3, 0x4834, 0x432d, 0xa9, 0xb5, 0xe1, 0x98, 0xdd, 0x9e, 0x89, 0x0d)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_XML" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_XMLTest()
    {
        Assert.That(WiaImgFmt_XML, Is.EqualTo(new Guid(0xb9171457, 0xdac8, 0x4884, 0xb3, 0x93, 0x15, 0xb4, 0x71, 0xd5, 0xf0, 0x7e)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_HTML" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_HTMLTest()
    {
        Assert.That(WiaImgFmt_HTML, Is.EqualTo(new Guid(0xc99a4e62, 0x99de, 0x4a94, 0xac, 0xca, 0x71, 0x95, 0x6a, 0xc2, 0x97, 0x7d)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_TXT" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_TXTTest()
    {
        Assert.That(WiaImgFmt_TXT, Is.EqualTo(new Guid(0xfafd4d82, 0x723f, 0x421f, 0x93, 0x18, 0x30, 0x50, 0x1a, 0xc4, 0x4b, 0x59)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_PDFA" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_PDFATest()
    {
        Assert.That(WiaImgFmt_PDFA, Is.EqualTo(new Guid(0x9980bd5b, 0x3463, 0x43c7, 0xbd, 0xca, 0x3c, 0xaa, 0x14, 0x6f, 0x22, 0x9f)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_XPS" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_XPSTest()
    {
        Assert.That(WiaImgFmt_XPS, Is.EqualTo(new Guid(0x700b4a0f, 0x2011, 0x411c, 0xb4, 0x30, 0xd1, 0xe0, 0xb2, 0xe1, 0x0b, 0x28)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_OXPS" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_OXPSTest()
    {
        Assert.That(WiaImgFmt_OXPS, Is.EqualTo(new Guid(0x2c7b1240, 0xc14d, 0x4109, 0x97, 0x55, 0x04, 0xb8, 0x90, 0x25, 0x15, 0x3a)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_CSV" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_CSVTest()
    {
        Assert.That(WiaImgFmt_CSV, Is.EqualTo(new Guid(0x355bda24, 0x5a9f, 0x4494, 0x80, 0xdc, 0xbe, 0x75, 0x2c, 0xec, 0xbc, 0x8c)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_MPG" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_MPGTest()
    {
        Assert.That(WiaImgFmt_MPG, Is.EqualTo(new Guid(0xecd757e4, 0xd2ec, 0x4f57, 0x95, 0x5d, 0xbc, 0xf8, 0xa9, 0x7c, 0x4e, 0x52)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_AVI" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_AVITest()
    {
        Assert.That(WiaImgFmt_AVI, Is.EqualTo(new Guid(0x32f8ca14, 0x087c, 0x4908, 0xb7, 0xc4, 0x67, 0x57, 0xfe, 0x7e, 0x90, 0xab)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_ASF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_ASFTest()
    {
        Assert.That(WiaImgFmt_ASF, Is.EqualTo(new Guid(0x8d948ee9, 0xd0aa, 0x4a12, 0x9d, 0x9a, 0x9c, 0xc5, 0xde, 0x36, 0x19, 0x9b)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_SCRIPT" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_SCRIPTTest()
    {
        Assert.That(WiaImgFmt_SCRIPT, Is.EqualTo(new Guid(0xfe7d6c53, 0x2dac, 0x446a, 0xb0, 0xbd, 0xd7, 0x3e, 0x21, 0xe9, 0x24, 0xc9)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_EXEC" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_EXECTest()
    {
        Assert.That(WiaImgFmt_EXEC, Is.EqualTo(new Guid(0x485da097, 0x141e, 0x4aa5, 0xbb, 0x3b, 0xa5, 0x61, 0x8d, 0x95, 0xd0, 0x2b)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_UNICODE16" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_UNICODE16Test()
    {
        Assert.That(WiaImgFmt_UNICODE16, Is.EqualTo(new Guid(0x1b7639b6, 0x6357, 0x47d1, 0x9a, 0x07, 0x12, 0x45, 0x2d, 0xc0, 0x73, 0xe9)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_DPOF" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_DPOFTest()
    {
        Assert.That(WiaImgFmt_DPOF, Is.EqualTo(new Guid(0x369eeeab, 0xa0e8, 0x45ca, 0x86, 0xa6, 0xa8, 0x3c, 0xe5, 0x69, 0x7e, 0x28)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_XMLBAR" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_XMLBARTest()
    {
        Assert.That(WiaImgFmt_XMLBAR, Is.EqualTo(new Guid(0x6235701c, 0x3a98, 0x484c, 0xb2, 0xa8, 0xfd, 0xff, 0xd8, 0x7e, 0x6b, 0x16)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_RAWBAR" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_RAWBARTest()
    {
        Assert.That(WiaImgFmt_RAWBAR, Is.EqualTo(new Guid(0xda63f833, 0xd26e, 0x451e, 0x90, 0xd2, 0xea, 0x55, 0xa1, 0x36, 0x5d, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_XMLPAT" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_XMLPATTest()
    {
        Assert.That(WiaImgFmt_XMLPAT, Is.EqualTo(new Guid(0xf8986f55, 0xf052, 0x460d, 0x95, 0x23, 0x3a, 0x7d, 0xfe, 0xdb, 0xb3, 0x3c)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_RAWPAT" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_RAWPATTest()
    {
        Assert.That(WiaImgFmt_RAWPAT, Is.EqualTo(new Guid(0x7760507c, 0x5064, 0x400c, 0x9a, 0x17, 0x57, 0x56, 0x24, 0xd8, 0x82, 0x4b)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_XMLMIC" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_XMLMICTest()
    {
        Assert.That(WiaImgFmt_XMLMIC, Is.EqualTo(new Guid(0x2d164c61, 0xb9ae, 0x4b23, 0x89, 0x73, 0xc7, 0x06, 0x7e, 0x1f, 0xbd, 0x31)));
    }

    /// <summary>Validates that the value of the <see cref="WiaImgFmt_RAWMIC" /> property is correct.</summary>
    [Test]
    public static void WiaImgFmt_RAWMICTest()
    {
        Assert.That(WiaImgFmt_RAWMIC, Is.EqualTo(new Guid(0x22c4f058, 0x0d88, 0x409c, 0xac, 0x1c, 0xee, 0xc1, 0x2b, 0x0e, 0xa6, 0x80)));
    }
}
