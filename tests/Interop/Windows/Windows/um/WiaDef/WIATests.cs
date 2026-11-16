// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.WIA;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WIA" /> class.</summary>
public static partial class WIATests
{
    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_FINISHED_FILE" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_FINISHED_FILETest()
    {
        Assert.That(WIA_CATEGORY_FINISHED_FILE, Is.EqualTo(new Guid(0xff2b77ca, 0xcf84, 0x432b, 0xa7, 0x35, 0x3a, 0x13, 0x0d, 0xde, 0x2a, 0x88)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_FLATBED" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_FLATBEDTest()
    {
        Assert.That(WIA_CATEGORY_FLATBED, Is.EqualTo(new Guid(0xfb607b1f, 0x43f3, 0x488b, 0x85, 0x5b, 0xfb, 0x70, 0x3e, 0xc3, 0x42, 0xa6)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_FEEDER" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_FEEDERTest()
    {
        Assert.That(WIA_CATEGORY_FEEDER, Is.EqualTo(new Guid(0xfe131934, 0xf84c, 0x42ad, 0x8d, 0xa4, 0x61, 0x29, 0xcd, 0xdd, 0x72, 0x88)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_FILM" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_FILMTest()
    {
        Assert.That(WIA_CATEGORY_FILM, Is.EqualTo(new Guid(0xfcf65be7, 0x3ce3, 0x4473, 0xaf, 0x85, 0xf5, 0xd3, 0x7d, 0x21, 0xb6, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_ROOT" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_ROOTTest()
    {
        Assert.That(WIA_CATEGORY_ROOT, Is.EqualTo(new Guid(0xf193526f, 0x59b8, 0x4a26, 0x98, 0x88, 0xe1, 0x6e, 0x4f, 0x97, 0xce, 0x10)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_FOLDER" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_FOLDERTest()
    {
        Assert.That(WIA_CATEGORY_FOLDER, Is.EqualTo(new Guid(0xc692a446, 0x6f5a, 0x481d, 0x85, 0xbb, 0x92, 0xe2, 0xe8, 0x6f, 0xd3, 0xa)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_FEEDER_FRONT" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_FEEDER_FRONTTest()
    {
        Assert.That(WIA_CATEGORY_FEEDER_FRONT, Is.EqualTo(new Guid(0x4823175c, 0x3b28, 0x487b, 0xa7, 0xe6, 0xee, 0xbc, 0x17, 0x61, 0x4f, 0xd1)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_FEEDER_BACK" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_FEEDER_BACKTest()
    {
        Assert.That(WIA_CATEGORY_FEEDER_BACK, Is.EqualTo(new Guid(0x61ca74d4, 0x39db, 0x42aa, 0x89, 0xb1, 0x8c, 0x19, 0xc9, 0xcd, 0x4c, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_AUTO" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_AUTOTest()
    {
        Assert.That(WIA_CATEGORY_AUTO, Is.EqualTo(new Guid(0xdefe5fd8, 0x6c97, 0x4dde, 0xb1, 0x1e, 0xcb, 0x50, 0x9b, 0x27, 0x0e, 0x11)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_IMPRINTER" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_IMPRINTERTest()
    {
        Assert.That(WIA_CATEGORY_IMPRINTER, Is.EqualTo(new Guid(0xfc65016d, 0x9202, 0x43dd, 0x91, 0xa7, 0x64, 0xc2, 0x95, 0x4c, 0xfb, 0x8b)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_ENDORSER" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_ENDORSERTest()
    {
        Assert.That(WIA_CATEGORY_ENDORSER, Is.EqualTo(new Guid(0x47102cc3, 0x127f, 0x4771, 0xad, 0xfc, 0x99, 0x1a, 0xb8, 0xee, 0x1e, 0x97)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_BARCODE_READER" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_BARCODE_READERTest()
    {
        Assert.That(WIA_CATEGORY_BARCODE_READER, Is.EqualTo(new Guid(0x36e178a0, 0x473f, 0x494b, 0xaf, 0x8f, 0x6c, 0x3f, 0x6d, 0x74, 0x86, 0xfc)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_PATCH_CODE_READER" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_PATCH_CODE_READERTest()
    {
        Assert.That(WIA_CATEGORY_PATCH_CODE_READER, Is.EqualTo(new Guid(0x8faa1a6d, 0x9c8a, 0x42cd, 0x98, 0xb3, 0xee, 0x97, 0x00, 0xcb, 0xc7, 0x4f)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CATEGORY_MICR_READER" /> property is correct.</summary>
    [Test]
    public static void WIA_CATEGORY_MICR_READERTest()
    {
        Assert.That(WIA_CATEGORY_MICR_READER, Is.EqualTo(new Guid(0x3b86c1ec, 0x71bc, 0x4645, 0xb4, 0xd5, 0x1b, 0x19, 0xda, 0x2b, 0xe9, 0x78)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_DEVICE_DISCONNECTED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_DEVICE_DISCONNECTEDTest()
    {
        Assert.That(WIA_EVENT_DEVICE_DISCONNECTED, Is.EqualTo(new Guid(0x143e4e83, 0x6497, 0x11d2, 0xa2, 0x31, 0x00, 0xc0, 0x4f, 0xa3, 0x18, 0x09)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_DEVICE_CONNECTED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_DEVICE_CONNECTEDTest()
    {
        Assert.That(WIA_EVENT_DEVICE_CONNECTED, Is.EqualTo(new Guid(0xa28bbade, 0x64b6, 0x11d2, 0xa2, 0x31, 0x00, 0xc0, 0x4f, 0xa3, 0x18, 0x09)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_ITEM_DELETED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_ITEM_DELETEDTest()
    {
        Assert.That(WIA_EVENT_ITEM_DELETED, Is.EqualTo(new Guid(0x1d22a559, 0xe14f, 0x11d2, 0xb3, 0x26, 0x00, 0xc0, 0x4f, 0x68, 0xce, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_ITEM_CREATED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_ITEM_CREATEDTest()
    {
        Assert.That(WIA_EVENT_ITEM_CREATED, Is.EqualTo(new Guid(0x4c8f4ef5, 0xe14f, 0x11d2, 0xb3, 0x26, 0x00, 0xc0, 0x4f, 0x68, 0xce, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_TREE_UPDATED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_TREE_UPDATEDTest()
    {
        Assert.That(WIA_EVENT_TREE_UPDATED, Is.EqualTo(new Guid(0xc9859b91, 0x4ab2, 0x4cd6, 0xa1, 0xfc, 0x58, 0x2e, 0xec, 0x55, 0xe5, 0x85)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_VOLUME_INSERT" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_VOLUME_INSERTTest()
    {
        Assert.That(WIA_EVENT_VOLUME_INSERT, Is.EqualTo(new Guid(0x9638bbfd, 0xd1bd, 0x11d2, 0xb3, 0x1f, 0x00, 0xc0, 0x4f, 0x68, 0xce, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_IMAGE" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_IMAGETest()
    {
        Assert.That(WIA_EVENT_SCAN_IMAGE, Is.EqualTo(new Guid(0xa6c5a715, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x00, 0x00, 0xf8, 0x7a, 0x92, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_PRINT_IMAGE" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_PRINT_IMAGETest()
    {
        Assert.That(WIA_EVENT_SCAN_PRINT_IMAGE, Is.EqualTo(new Guid(0xb441f425, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x00, 0x00, 0xf8, 0x7a, 0x92, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_FAX_IMAGE" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_FAX_IMAGETest()
    {
        Assert.That(WIA_EVENT_SCAN_FAX_IMAGE, Is.EqualTo(new Guid(0xc00eb793, 0x8c6e, 0x11d2, 0x97, 0x7a, 0x00, 0x00, 0xf8, 0x7a, 0x92, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_OCR_IMAGE" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_OCR_IMAGETest()
    {
        Assert.That(WIA_EVENT_SCAN_OCR_IMAGE, Is.EqualTo(new Guid(0x9d095b89, 0x37d6, 0x4877, 0xaf, 0xed, 0x62, 0xa2, 0x97, 0xdc, 0x6d, 0xbe)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_EMAIL_IMAGE" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_EMAIL_IMAGETest()
    {
        Assert.That(WIA_EVENT_SCAN_EMAIL_IMAGE, Is.EqualTo(new Guid(0xc686dcee, 0x54f2, 0x419e, 0x9a, 0x27, 0x2f, 0xc7, 0xf2, 0xe9, 0x8f, 0x9e)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_FILM_IMAGE" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_FILM_IMAGETest()
    {
        Assert.That(WIA_EVENT_SCAN_FILM_IMAGE, Is.EqualTo(new Guid(0x9b2b662c, 0x6185, 0x438c, 0xb6, 0x8b, 0xe3, 0x9e, 0xe2, 0x5e, 0x71, 0xcb)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_IMAGE2" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_IMAGE2Test()
    {
        Assert.That(WIA_EVENT_SCAN_IMAGE2, Is.EqualTo(new Guid(0xfc4767c1, 0xc8b3, 0x48a2, 0x9c, 0xfa, 0x2e, 0x90, 0xcb, 0x3d, 0x35, 0x90)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_IMAGE3" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_IMAGE3Test()
    {
        Assert.That(WIA_EVENT_SCAN_IMAGE3, Is.EqualTo(new Guid(0x154e27be, 0xb617, 0x4653, 0xac, 0xc5, 0x0f, 0xd7, 0xbd, 0x4c, 0x65, 0xce)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_SCAN_IMAGE4" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_SCAN_IMAGE4Test()
    {
        Assert.That(WIA_EVENT_SCAN_IMAGE4, Is.EqualTo(new Guid(0xa65b704a, 0x7f3c, 0x4447, 0xa7, 0x5d, 0x8a, 0x26, 0xdf, 0xca, 0x1f, 0xdf)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_STORAGE_CREATED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_STORAGE_CREATEDTest()
    {
        Assert.That(WIA_EVENT_STORAGE_CREATED, Is.EqualTo(new Guid(0x353308b2, 0xfe73, 0x46c8, 0x89, 0x5e, 0xfa, 0x45, 0x51, 0xcc, 0xc8, 0x5a)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_STORAGE_DELETED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_STORAGE_DELETEDTest()
    {
        Assert.That(WIA_EVENT_STORAGE_DELETED, Is.EqualTo(new Guid(0x5e41e75e, 0x9390, 0x44c5, 0x9a, 0x51, 0xe4, 0x70, 0x19, 0xe3, 0x90, 0xcf)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_STI_PROXY" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_STI_PROXYTest()
    {
        Assert.That(WIA_EVENT_STI_PROXY, Is.EqualTo(new Guid(0xd711f81f, 0x1f0d, 0x422d, 0x86, 0x41, 0x92, 0x7d, 0x1b, 0x93, 0xe5, 0xe5)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_CANCEL_IO" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_CANCEL_IOTest()
    {
        Assert.That(WIA_EVENT_CANCEL_IO, Is.EqualTo(new Guid(0xc860f7b8, 0x9ccd, 0x41ea, 0xbb, 0xbf, 0x4d, 0xd0, 0x9c, 0x5b, 0x17, 0x95)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_POWER_SUSPEND" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_POWER_SUSPENDTest()
    {
        Assert.That(WIA_EVENT_POWER_SUSPEND, Is.EqualTo(new Guid(0xa0922ff9, 0xc3b4, 0x411c, 0x9e, 0x29, 0x03, 0xa6, 0x69, 0x93, 0xd2, 0xbe)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_POWER_RESUME" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_POWER_RESUMETest()
    {
        Assert.That(WIA_EVENT_POWER_RESUME, Is.EqualTo(new Guid(0x618f153e, 0xf686, 0x4350, 0x96, 0x34, 0x41, 0x15, 0xa3, 0x04, 0x83, 0x0c)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_HANDLER_NO_ACTION" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_HANDLER_NO_ACTIONTest()
    {
        Assert.That(WIA_EVENT_HANDLER_NO_ACTION, Is.EqualTo(new Guid(0xe0372b7d, 0xe115, 0x4525, 0xbc, 0x55, 0xb6, 0x29, 0xe6, 0x8c, 0x74, 0x5a)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_HANDLER_PROMPT" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_HANDLER_PROMPTTest()
    {
        Assert.That(WIA_EVENT_HANDLER_PROMPT, Is.EqualTo(new Guid(0x5f4baad0, 0x4d59, 0x4fcd, 0xb2, 0x13, 0x78, 0x3c, 0xe7, 0xa9, 0x2f, 0x22)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_DEVICE_NOT_READY" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_DEVICE_NOT_READYTest()
    {
        Assert.That(WIA_EVENT_DEVICE_NOT_READY, Is.EqualTo(new Guid(0xd8962d7e, 0xe4dc, 0x4b4d, 0xba, 0x29, 0x66, 0x8a, 0x87, 0xf4, 0x2e, 0x6f)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_DEVICE_READY" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_DEVICE_READYTest()
    {
        Assert.That(WIA_EVENT_DEVICE_READY, Is.EqualTo(new Guid(0x7523ec6c, 0x988b, 0x419e, 0x9a, 0x0a, 0x42, 0x5a, 0xc3, 0x1b, 0x37, 0xdc)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_FLATBED_LID_OPEN" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_FLATBED_LID_OPENTest()
    {
        Assert.That(WIA_EVENT_FLATBED_LID_OPEN, Is.EqualTo(new Guid(0xba0a0623, 0x437d, 0x4f03, 0xa9, 0x7d, 0x77, 0x93, 0xb1, 0x23, 0x11, 0x3c)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_FLATBED_LID_CLOSED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_FLATBED_LID_CLOSEDTest()
    {
        Assert.That(WIA_EVENT_FLATBED_LID_CLOSED, Is.EqualTo(new Guid(0xf879af0f, 0x9b29, 0x4283, 0xad, 0x95, 0xd4, 0x12, 0x16, 0x4d, 0x39, 0xa9)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_FEEDER_LOADED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_FEEDER_LOADEDTest()
    {
        Assert.That(WIA_EVENT_FEEDER_LOADED, Is.EqualTo(new Guid(0xcc8d701e, 0x9aba, 0x481d, 0xbf, 0x74, 0x78, 0xf7, 0x63, 0xdc, 0x34, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_FEEDER_EMPTIED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_FEEDER_EMPTIEDTest()
    {
        Assert.That(WIA_EVENT_FEEDER_EMPTIED, Is.EqualTo(new Guid(0xe70b4b82, 0x6dda, 0x46bb, 0x8f, 0xf9, 0x53, 0xce, 0xb1, 0xa0, 0x3e, 0x35)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_COVER_OPEN" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_COVER_OPENTest()
    {
        Assert.That(WIA_EVENT_COVER_OPEN, Is.EqualTo(new Guid(0x19a12136, 0xfa1c, 0x4f66, 0x90, 0x0f, 0x8f, 0x91, 0x4e, 0xc7, 0x4e, 0xc9)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_EVENT_COVER_CLOSED" /> property is correct.</summary>
    [Test]
    public static void WIA_EVENT_COVER_CLOSEDTest()
    {
        Assert.That(WIA_EVENT_COVER_CLOSED, Is.EqualTo(new Guid(0x6714a1e6, 0xe285, 0x468c, 0x9b, 0x8c, 0xda, 0x7d, 0xc4, 0xcb, 0xaa, 0x05)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_SYNCHRONIZE" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_SYNCHRONIZETest()
    {
        Assert.That(WIA_CMD_SYNCHRONIZE, Is.EqualTo(new Guid(0x9b26b7b2, 0xacad, 0x11d2, 0xa0, 0x93, 0x00, 0xc0, 0x4f, 0x72, 0xdc, 0x3c)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_TAKE_PICTURE" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_TAKE_PICTURETest()
    {
        Assert.That(WIA_CMD_TAKE_PICTURE, Is.EqualTo(new Guid(0xaf933cac, 0xacad, 0x11d2, 0xa0, 0x93, 0x00, 0xc0, 0x4f, 0x72, 0xdc, 0x3c)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_DELETE_ALL_ITEMS" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_DELETE_ALL_ITEMSTest()
    {
        Assert.That(WIA_CMD_DELETE_ALL_ITEMS, Is.EqualTo(new Guid(0xe208c170, 0xacad, 0x11d2, 0xa0, 0x93, 0x00, 0xc0, 0x4f, 0x72, 0xdc, 0x3c)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_CHANGE_DOCUMENT" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_CHANGE_DOCUMENTTest()
    {
        Assert.That(WIA_CMD_CHANGE_DOCUMENT, Is.EqualTo(new Guid(0x04e725b0, 0xacae, 0x11d2, 0xa0, 0x93, 0x00, 0xc0, 0x4f, 0x72, 0xdc, 0x3c)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_UNLOAD_DOCUMENT" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_UNLOAD_DOCUMENTTest()
    {
        Assert.That(WIA_CMD_UNLOAD_DOCUMENT, Is.EqualTo(new Guid(0x1f3b3d8e, 0xacae, 0x11d2, 0xa0, 0x93, 0x00, 0xc0, 0x4f, 0x72, 0xdc, 0x3c)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_DIAGNOSTIC" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_DIAGNOSTICTest()
    {
        Assert.That(WIA_CMD_DIAGNOSTIC, Is.EqualTo(new Guid(0x10ff52f5, 0xde04, 0x4cf0, 0xa5, 0xad, 0x69, 0x1f, 0x8d, 0xce, 0x01, 0x41)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_FORMAT" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_FORMATTest()
    {
        Assert.That(WIA_CMD_FORMAT, Is.EqualTo(new Guid(0xc3a693aa, 0xf788, 0x4d34, 0xa5, 0xb0, 0xbe, 0x71, 0x90, 0x75, 0x9a, 0x24)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_DELETE_DEVICE_TREE" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_DELETE_DEVICE_TREETest()
    {
        Assert.That(WIA_CMD_DELETE_DEVICE_TREE, Is.EqualTo(new Guid(0x73815942, 0xdbea, 0x11d2, 0x84, 0x16, 0x00, 0xc0, 0x4f, 0xa3, 0x61, 0x45)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_BUILD_DEVICE_TREE" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_BUILD_DEVICE_TREETest()
    {
        Assert.That(WIA_CMD_BUILD_DEVICE_TREE, Is.EqualTo(new Guid(0x9cba5ce0, 0xdbea, 0x11d2, 0x84, 0x16, 0x00, 0xc0, 0x4f, 0xa3, 0x61, 0x45)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_START_FEEDER" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_START_FEEDERTest()
    {
        Assert.That(WIA_CMD_START_FEEDER, Is.EqualTo(new Guid(0x5a9df6c9, 0x5f2d, 0x4a39, 0x9d, 0x6c, 0x00, 0x45, 0x6d, 0x04, 0x7f, 0x00)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_STOP_FEEDER" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_STOP_FEEDERTest()
    {
        Assert.That(WIA_CMD_STOP_FEEDER, Is.EqualTo(new Guid(0xd847b06d, 0x3905, 0x459c, 0x95, 0x09, 0x9b, 0x29, 0xcd, 0xb6, 0x91, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref="WIA_CMD_PAUSE_FEEDER" /> property is correct.</summary>
    [Test]
    public static void WIA_CMD_PAUSE_FEEDERTest()
    {
        Assert.That(WIA_CMD_PAUSE_FEEDER, Is.EqualTo(new Guid(0x50985e4d, 0xa5b2, 0x4b71, 0x9c, 0x95, 0x6d, 0x7d, 0x7c, 0x46, 0x9a, 0x43)));
    }
}
