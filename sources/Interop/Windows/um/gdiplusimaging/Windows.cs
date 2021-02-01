// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatUndefined = new Guid(0xb96b3ca9, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatMemoryBMP = new Guid(0xb96b3caa, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatBMP = new Guid(0xb96b3cab, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatEMF = new Guid(0xb96b3cac, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatWMF = new Guid(0xb96b3cad, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatJPEG = new Guid(0xb96b3cae, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatPNG = new Guid(0xb96b3caf, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatGIF = new Guid(0xb96b3cb0, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatTIFF = new Guid(0xb96b3cb1, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatEXIF = new Guid(0xb96b3cb2, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatIcon = new Guid(0xb96b3cb5, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatHEIF = new Guid(0xb96b3cb6, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid ImageFormatWEBP = new Guid(0xb96b3cb7, 0x0728, 0x11d3, 0x9d, 0x7b, 0x00, 0x00, 0xf8, 0x1e, 0xf3, 0x2e);

        [NativeTypeName("const GUID")]
        public static readonly Guid FrameDimensionTime = new Guid(0x6aedbd6d, 0x3fb5, 0x418a, 0x83, 0xa6, 0x7f, 0x45, 0x22, 0x9d, 0xc8, 0x72);

        [NativeTypeName("const GUID")]
        public static readonly Guid FrameDimensionResolution = new Guid(0x84236f7b, 0x3bd3, 0x428f, 0x8d, 0xab, 0x4e, 0xa1, 0x43, 0x9c, 0xa3, 0x15);

        [NativeTypeName("const GUID")]
        public static readonly Guid FrameDimensionPage = new Guid(0x7462dc86, 0x6180, 0x4c7e, 0x8e, 0x3f, 0xee, 0x73, 0x33, 0xa7, 0xa4, 0x83);

        [NativeTypeName("const GUID")]
        public static readonly Guid FormatIDImageInformation = new Guid(0xe5836cbe, 0x5eef, 0x4f1d, 0xac, 0xde, 0xae, 0x4c, 0x43, 0xb6, 0x08, 0xce);

        [NativeTypeName("const GUID")]
        public static readonly Guid FormatIDJpegAppHeaders = new Guid(0x1c4afdcd, 0x6177, 0x43cf, 0xab, 0xc7, 0x5f, 0x51, 0xaf, 0x39, 0xee, 0x85);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderCompression = new Guid(0xe09d739d, 0xccd4, 0x44ee, 0x8e, 0xba, 0x3f, 0xbf, 0x8b, 0xe4, 0xfc, 0x58);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderColorDepth = new Guid(0x66087055, 0xad66, 0x4c7c, 0x9a, 0x18, 0x38, 0xa2, 0x31, 0x0b, 0x83, 0x37);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderScanMethod = new Guid(0x3a4e2661, 0x3109, 0x4e56, 0x85, 0x36, 0x42, 0xc1, 0x56, 0xe7, 0xdc, 0xfa);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderVersion = new Guid(0x24d18c76, 0x814a, 0x41a4, 0xbf, 0x53, 0x1c, 0x21, 0x9c, 0xcc, 0xf7, 0x97);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderRenderMethod = new Guid(0x6d42c53a, 0x229a, 0x4825, 0x8b, 0xb7, 0x5c, 0x99, 0xe2, 0xb9, 0xa8, 0xb8);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderQuality = new Guid(0x1d5be4b5, 0xfa4a, 0x452d, 0x9c, 0xdd, 0x5d, 0xb3, 0x51, 0x05, 0xe7, 0xeb);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderTransformation = new Guid(0x8d0eb2d1, 0xa58e, 0x4ea8, 0xaa, 0x14, 0x10, 0x80, 0x74, 0xb7, 0xb6, 0xf9);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderLuminanceTable = new Guid(0xedb33bce, 0x0266, 0x4a77, 0xb9, 0x04, 0x27, 0x21, 0x60, 0x99, 0xe7, 0x17);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderChrominanceTable = new Guid(0xf2e455dc, 0x09b3, 0x4316, 0x82, 0x60, 0x67, 0x6a, 0xda, 0x32, 0x48, 0x1c);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderSaveFlag = new Guid(0x292266fc, 0xac40, 0x47bf, 0x8c, 0xfc, 0xa8, 0x5b, 0x89, 0xa6, 0x55, 0xde);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderColorSpace = new Guid(0xae7a62a0, 0xee2c, 0x49d8, 0x9d, 0x7, 0x1b, 0xa8, 0xa9, 0x27, 0x59, 0x6e);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderImageItems = new Guid(0x63875e13, 0x1f1d, 0x45ab, 0x91, 0x95, 0xa2, 0x9b, 0x60, 0x66, 0xa6, 0x50);

        [NativeTypeName("const GUID")]
        public static readonly Guid EncoderSaveAsCMYK = new Guid(0xa219bbc9, 0xa9d, 0x4005, 0xa3, 0xee, 0x3a, 0x42, 0x1b, 0x8b, 0xb0, 0x6c);

        [NativeTypeName("const GUID")]
        public static readonly Guid CodecIImageBytes = new Guid(0x025d1823, 0x6c7d, 0x447b, 0xbb, 0xdb, 0xa3, 0xcb, 0xc3, 0xdf, 0xa2, 0xfc);

        [NativeTypeName("#define PropertyTagTypeByte 1")]
        public const int PropertyTagTypeByte = 1;

        [NativeTypeName("#define PropertyTagTypeASCII 2")]
        public const int PropertyTagTypeASCII = 2;

        [NativeTypeName("#define PropertyTagTypeShort 3")]
        public const int PropertyTagTypeShort = 3;

        [NativeTypeName("#define PropertyTagTypeLong 4")]
        public const int PropertyTagTypeLong = 4;

        [NativeTypeName("#define PropertyTagTypeRational 5")]
        public const int PropertyTagTypeRational = 5;

        [NativeTypeName("#define PropertyTagTypeUndefined 7")]
        public const int PropertyTagTypeUndefined = 7;

        [NativeTypeName("#define PropertyTagTypeSLONG 9")]
        public const int PropertyTagTypeSLONG = 9;

        [NativeTypeName("#define PropertyTagTypeSRational 10")]
        public const int PropertyTagTypeSRational = 10;

        [NativeTypeName("#define PropertyTagExifIFD 0x8769")]
        public const int PropertyTagExifIFD = 0x8769;

        [NativeTypeName("#define PropertyTagGpsIFD 0x8825")]
        public const int PropertyTagGpsIFD = 0x8825;

        [NativeTypeName("#define PropertyTagNewSubfileType 0x00FE")]
        public const int PropertyTagNewSubfileType = 0x00FE;

        [NativeTypeName("#define PropertyTagSubfileType 0x00FF")]
        public const int PropertyTagSubfileType = 0x00FF;

        [NativeTypeName("#define PropertyTagImageWidth 0x0100")]
        public const int PropertyTagImageWidth = 0x0100;

        [NativeTypeName("#define PropertyTagImageHeight 0x0101")]
        public const int PropertyTagImageHeight = 0x0101;

        [NativeTypeName("#define PropertyTagBitsPerSample 0x0102")]
        public const int PropertyTagBitsPerSample = 0x0102;

        [NativeTypeName("#define PropertyTagCompression 0x0103")]
        public const int PropertyTagCompression = 0x0103;

        [NativeTypeName("#define PropertyTagPhotometricInterp 0x0106")]
        public const int PropertyTagPhotometricInterp = 0x0106;

        [NativeTypeName("#define PropertyTagThreshHolding 0x0107")]
        public const int PropertyTagThreshHolding = 0x0107;

        [NativeTypeName("#define PropertyTagCellWidth 0x0108")]
        public const int PropertyTagCellWidth = 0x0108;

        [NativeTypeName("#define PropertyTagCellHeight 0x0109")]
        public const int PropertyTagCellHeight = 0x0109;

        [NativeTypeName("#define PropertyTagFillOrder 0x010A")]
        public const int PropertyTagFillOrder = 0x010A;

        [NativeTypeName("#define PropertyTagDocumentName 0x010D")]
        public const int PropertyTagDocumentName = 0x010D;

        [NativeTypeName("#define PropertyTagImageDescription 0x010E")]
        public const int PropertyTagImageDescription = 0x010E;

        [NativeTypeName("#define PropertyTagEquipMake 0x010F")]
        public const int PropertyTagEquipMake = 0x010F;

        [NativeTypeName("#define PropertyTagEquipModel 0x0110")]
        public const int PropertyTagEquipModel = 0x0110;

        [NativeTypeName("#define PropertyTagStripOffsets 0x0111")]
        public const int PropertyTagStripOffsets = 0x0111;

        [NativeTypeName("#define PropertyTagOrientation 0x0112")]
        public const int PropertyTagOrientation = 0x0112;

        [NativeTypeName("#define PropertyTagSamplesPerPixel 0x0115")]
        public const int PropertyTagSamplesPerPixel = 0x0115;

        [NativeTypeName("#define PropertyTagRowsPerStrip 0x0116")]
        public const int PropertyTagRowsPerStrip = 0x0116;

        [NativeTypeName("#define PropertyTagStripBytesCount 0x0117")]
        public const int PropertyTagStripBytesCount = 0x0117;

        [NativeTypeName("#define PropertyTagMinSampleValue 0x0118")]
        public const int PropertyTagMinSampleValue = 0x0118;

        [NativeTypeName("#define PropertyTagMaxSampleValue 0x0119")]
        public const int PropertyTagMaxSampleValue = 0x0119;

        [NativeTypeName("#define PropertyTagXResolution 0x011A")]
        public const int PropertyTagXResolution = 0x011A;

        [NativeTypeName("#define PropertyTagYResolution 0x011B")]
        public const int PropertyTagYResolution = 0x011B;

        [NativeTypeName("#define PropertyTagPlanarConfig 0x011C")]
        public const int PropertyTagPlanarConfig = 0x011C;

        [NativeTypeName("#define PropertyTagPageName 0x011D")]
        public const int PropertyTagPageName = 0x011D;

        [NativeTypeName("#define PropertyTagXPosition 0x011E")]
        public const int PropertyTagXPosition = 0x011E;

        [NativeTypeName("#define PropertyTagYPosition 0x011F")]
        public const int PropertyTagYPosition = 0x011F;

        [NativeTypeName("#define PropertyTagFreeOffset 0x0120")]
        public const int PropertyTagFreeOffset = 0x0120;

        [NativeTypeName("#define PropertyTagFreeByteCounts 0x0121")]
        public const int PropertyTagFreeByteCounts = 0x0121;

        [NativeTypeName("#define PropertyTagGrayResponseUnit 0x0122")]
        public const int PropertyTagGrayResponseUnit = 0x0122;

        [NativeTypeName("#define PropertyTagGrayResponseCurve 0x0123")]
        public const int PropertyTagGrayResponseCurve = 0x0123;

        [NativeTypeName("#define PropertyTagT4Option 0x0124")]
        public const int PropertyTagT4Option = 0x0124;

        [NativeTypeName("#define PropertyTagT6Option 0x0125")]
        public const int PropertyTagT6Option = 0x0125;

        [NativeTypeName("#define PropertyTagResolutionUnit 0x0128")]
        public const int PropertyTagResolutionUnit = 0x0128;

        [NativeTypeName("#define PropertyTagPageNumber 0x0129")]
        public const int PropertyTagPageNumber = 0x0129;

        [NativeTypeName("#define PropertyTagTransferFuncition 0x012D")]
        public const int PropertyTagTransferFuncition = 0x012D;

        [NativeTypeName("#define PropertyTagSoftwareUsed 0x0131")]
        public const int PropertyTagSoftwareUsed = 0x0131;

        [NativeTypeName("#define PropertyTagDateTime 0x0132")]
        public const int PropertyTagDateTime = 0x0132;

        [NativeTypeName("#define PropertyTagArtist 0x013B")]
        public const int PropertyTagArtist = 0x013B;

        [NativeTypeName("#define PropertyTagHostComputer 0x013C")]
        public const int PropertyTagHostComputer = 0x013C;

        [NativeTypeName("#define PropertyTagPredictor 0x013D")]
        public const int PropertyTagPredictor = 0x013D;

        [NativeTypeName("#define PropertyTagWhitePoint 0x013E")]
        public const int PropertyTagWhitePoint = 0x013E;

        [NativeTypeName("#define PropertyTagPrimaryChromaticities 0x013F")]
        public const int PropertyTagPrimaryChromaticities = 0x013F;

        [NativeTypeName("#define PropertyTagColorMap 0x0140")]
        public const int PropertyTagColorMap = 0x0140;

        [NativeTypeName("#define PropertyTagHalftoneHints 0x0141")]
        public const int PropertyTagHalftoneHints = 0x0141;

        [NativeTypeName("#define PropertyTagTileWidth 0x0142")]
        public const int PropertyTagTileWidth = 0x0142;

        [NativeTypeName("#define PropertyTagTileLength 0x0143")]
        public const int PropertyTagTileLength = 0x0143;

        [NativeTypeName("#define PropertyTagTileOffset 0x0144")]
        public const int PropertyTagTileOffset = 0x0144;

        [NativeTypeName("#define PropertyTagTileByteCounts 0x0145")]
        public const int PropertyTagTileByteCounts = 0x0145;

        [NativeTypeName("#define PropertyTagInkSet 0x014C")]
        public const int PropertyTagInkSet = 0x014C;

        [NativeTypeName("#define PropertyTagInkNames 0x014D")]
        public const int PropertyTagInkNames = 0x014D;

        [NativeTypeName("#define PropertyTagNumberOfInks 0x014E")]
        public const int PropertyTagNumberOfInks = 0x014E;

        [NativeTypeName("#define PropertyTagDotRange 0x0150")]
        public const int PropertyTagDotRange = 0x0150;

        [NativeTypeName("#define PropertyTagTargetPrinter 0x0151")]
        public const int PropertyTagTargetPrinter = 0x0151;

        [NativeTypeName("#define PropertyTagExtraSamples 0x0152")]
        public const int PropertyTagExtraSamples = 0x0152;

        [NativeTypeName("#define PropertyTagSampleFormat 0x0153")]
        public const int PropertyTagSampleFormat = 0x0153;

        [NativeTypeName("#define PropertyTagSMinSampleValue 0x0154")]
        public const int PropertyTagSMinSampleValue = 0x0154;

        [NativeTypeName("#define PropertyTagSMaxSampleValue 0x0155")]
        public const int PropertyTagSMaxSampleValue = 0x0155;

        [NativeTypeName("#define PropertyTagTransferRange 0x0156")]
        public const int PropertyTagTransferRange = 0x0156;

        [NativeTypeName("#define PropertyTagJPEGProc 0x0200")]
        public const int PropertyTagJPEGProc = 0x0200;

        [NativeTypeName("#define PropertyTagJPEGInterFormat 0x0201")]
        public const int PropertyTagJPEGInterFormat = 0x0201;

        [NativeTypeName("#define PropertyTagJPEGInterLength 0x0202")]
        public const int PropertyTagJPEGInterLength = 0x0202;

        [NativeTypeName("#define PropertyTagJPEGRestartInterval 0x0203")]
        public const int PropertyTagJPEGRestartInterval = 0x0203;

        [NativeTypeName("#define PropertyTagJPEGLosslessPredictors 0x0205")]
        public const int PropertyTagJPEGLosslessPredictors = 0x0205;

        [NativeTypeName("#define PropertyTagJPEGPointTransforms 0x0206")]
        public const int PropertyTagJPEGPointTransforms = 0x0206;

        [NativeTypeName("#define PropertyTagJPEGQTables 0x0207")]
        public const int PropertyTagJPEGQTables = 0x0207;

        [NativeTypeName("#define PropertyTagJPEGDCTables 0x0208")]
        public const int PropertyTagJPEGDCTables = 0x0208;

        [NativeTypeName("#define PropertyTagJPEGACTables 0x0209")]
        public const int PropertyTagJPEGACTables = 0x0209;

        [NativeTypeName("#define PropertyTagYCbCrCoefficients 0x0211")]
        public const int PropertyTagYCbCrCoefficients = 0x0211;

        [NativeTypeName("#define PropertyTagYCbCrSubsampling 0x0212")]
        public const int PropertyTagYCbCrSubsampling = 0x0212;

        [NativeTypeName("#define PropertyTagYCbCrPositioning 0x0213")]
        public const int PropertyTagYCbCrPositioning = 0x0213;

        [NativeTypeName("#define PropertyTagREFBlackWhite 0x0214")]
        public const int PropertyTagREFBlackWhite = 0x0214;

        [NativeTypeName("#define PropertyTagICCProfile 0x8773")]
        public const int PropertyTagICCProfile = 0x8773;

        [NativeTypeName("#define PropertyTagGamma 0x0301")]
        public const int PropertyTagGamma = 0x0301;

        [NativeTypeName("#define PropertyTagICCProfileDescriptor 0x0302")]
        public const int PropertyTagICCProfileDescriptor = 0x0302;

        [NativeTypeName("#define PropertyTagSRGBRenderingIntent 0x0303")]
        public const int PropertyTagSRGBRenderingIntent = 0x0303;

        [NativeTypeName("#define PropertyTagImageTitle 0x0320")]
        public const int PropertyTagImageTitle = 0x0320;

        [NativeTypeName("#define PropertyTagCopyright 0x8298")]
        public const int PropertyTagCopyright = 0x8298;

        [NativeTypeName("#define PropertyTagResolutionXUnit 0x5001")]
        public const int PropertyTagResolutionXUnit = 0x5001;

        [NativeTypeName("#define PropertyTagResolutionYUnit 0x5002")]
        public const int PropertyTagResolutionYUnit = 0x5002;

        [NativeTypeName("#define PropertyTagResolutionXLengthUnit 0x5003")]
        public const int PropertyTagResolutionXLengthUnit = 0x5003;

        [NativeTypeName("#define PropertyTagResolutionYLengthUnit 0x5004")]
        public const int PropertyTagResolutionYLengthUnit = 0x5004;

        [NativeTypeName("#define PropertyTagPrintFlags 0x5005")]
        public const int PropertyTagPrintFlags = 0x5005;

        [NativeTypeName("#define PropertyTagPrintFlagsVersion 0x5006")]
        public const int PropertyTagPrintFlagsVersion = 0x5006;

        [NativeTypeName("#define PropertyTagPrintFlagsCrop 0x5007")]
        public const int PropertyTagPrintFlagsCrop = 0x5007;

        [NativeTypeName("#define PropertyTagPrintFlagsBleedWidth 0x5008")]
        public const int PropertyTagPrintFlagsBleedWidth = 0x5008;

        [NativeTypeName("#define PropertyTagPrintFlagsBleedWidthScale 0x5009")]
        public const int PropertyTagPrintFlagsBleedWidthScale = 0x5009;

        [NativeTypeName("#define PropertyTagHalftoneLPI 0x500A")]
        public const int PropertyTagHalftoneLPI = 0x500A;

        [NativeTypeName("#define PropertyTagHalftoneLPIUnit 0x500B")]
        public const int PropertyTagHalftoneLPIUnit = 0x500B;

        [NativeTypeName("#define PropertyTagHalftoneDegree 0x500C")]
        public const int PropertyTagHalftoneDegree = 0x500C;

        [NativeTypeName("#define PropertyTagHalftoneShape 0x500D")]
        public const int PropertyTagHalftoneShape = 0x500D;

        [NativeTypeName("#define PropertyTagHalftoneMisc 0x500E")]
        public const int PropertyTagHalftoneMisc = 0x500E;

        [NativeTypeName("#define PropertyTagHalftoneScreen 0x500F")]
        public const int PropertyTagHalftoneScreen = 0x500F;

        [NativeTypeName("#define PropertyTagJPEGQuality 0x5010")]
        public const int PropertyTagJPEGQuality = 0x5010;

        [NativeTypeName("#define PropertyTagGridSize 0x5011")]
        public const int PropertyTagGridSize = 0x5011;

        [NativeTypeName("#define PropertyTagThumbnailFormat 0x5012")]
        public const int PropertyTagThumbnailFormat = 0x5012;

        [NativeTypeName("#define PropertyTagThumbnailWidth 0x5013")]
        public const int PropertyTagThumbnailWidth = 0x5013;

        [NativeTypeName("#define PropertyTagThumbnailHeight 0x5014")]
        public const int PropertyTagThumbnailHeight = 0x5014;

        [NativeTypeName("#define PropertyTagThumbnailColorDepth 0x5015")]
        public const int PropertyTagThumbnailColorDepth = 0x5015;

        [NativeTypeName("#define PropertyTagThumbnailPlanes 0x5016")]
        public const int PropertyTagThumbnailPlanes = 0x5016;

        [NativeTypeName("#define PropertyTagThumbnailRawBytes 0x5017")]
        public const int PropertyTagThumbnailRawBytes = 0x5017;

        [NativeTypeName("#define PropertyTagThumbnailSize 0x5018")]
        public const int PropertyTagThumbnailSize = 0x5018;

        [NativeTypeName("#define PropertyTagThumbnailCompressedSize 0x5019")]
        public const int PropertyTagThumbnailCompressedSize = 0x5019;

        [NativeTypeName("#define PropertyTagColorTransferFunction 0x501A")]
        public const int PropertyTagColorTransferFunction = 0x501A;

        [NativeTypeName("#define PropertyTagThumbnailData 0x501B")]
        public const int PropertyTagThumbnailData = 0x501B;

        [NativeTypeName("#define PropertyTagThumbnailImageWidth 0x5020")]
        public const int PropertyTagThumbnailImageWidth = 0x5020;

        [NativeTypeName("#define PropertyTagThumbnailImageHeight 0x5021")]
        public const int PropertyTagThumbnailImageHeight = 0x5021;

        [NativeTypeName("#define PropertyTagThumbnailBitsPerSample 0x5022")]
        public const int PropertyTagThumbnailBitsPerSample = 0x5022;

        [NativeTypeName("#define PropertyTagThumbnailCompression 0x5023")]
        public const int PropertyTagThumbnailCompression = 0x5023;

        [NativeTypeName("#define PropertyTagThumbnailPhotometricInterp 0x5024")]
        public const int PropertyTagThumbnailPhotometricInterp = 0x5024;

        [NativeTypeName("#define PropertyTagThumbnailImageDescription 0x5025")]
        public const int PropertyTagThumbnailImageDescription = 0x5025;

        [NativeTypeName("#define PropertyTagThumbnailEquipMake 0x5026")]
        public const int PropertyTagThumbnailEquipMake = 0x5026;

        [NativeTypeName("#define PropertyTagThumbnailEquipModel 0x5027")]
        public const int PropertyTagThumbnailEquipModel = 0x5027;

        [NativeTypeName("#define PropertyTagThumbnailStripOffsets 0x5028")]
        public const int PropertyTagThumbnailStripOffsets = 0x5028;

        [NativeTypeName("#define PropertyTagThumbnailOrientation 0x5029")]
        public const int PropertyTagThumbnailOrientation = 0x5029;

        [NativeTypeName("#define PropertyTagThumbnailSamplesPerPixel 0x502A")]
        public const int PropertyTagThumbnailSamplesPerPixel = 0x502A;

        [NativeTypeName("#define PropertyTagThumbnailRowsPerStrip 0x502B")]
        public const int PropertyTagThumbnailRowsPerStrip = 0x502B;

        [NativeTypeName("#define PropertyTagThumbnailStripBytesCount 0x502C")]
        public const int PropertyTagThumbnailStripBytesCount = 0x502C;

        [NativeTypeName("#define PropertyTagThumbnailResolutionX 0x502D")]
        public const int PropertyTagThumbnailResolutionX = 0x502D;

        [NativeTypeName("#define PropertyTagThumbnailResolutionY 0x502E")]
        public const int PropertyTagThumbnailResolutionY = 0x502E;

        [NativeTypeName("#define PropertyTagThumbnailPlanarConfig 0x502F")]
        public const int PropertyTagThumbnailPlanarConfig = 0x502F;

        [NativeTypeName("#define PropertyTagThumbnailResolutionUnit 0x5030")]
        public const int PropertyTagThumbnailResolutionUnit = 0x5030;

        [NativeTypeName("#define PropertyTagThumbnailTransferFunction 0x5031")]
        public const int PropertyTagThumbnailTransferFunction = 0x5031;

        [NativeTypeName("#define PropertyTagThumbnailSoftwareUsed 0x5032")]
        public const int PropertyTagThumbnailSoftwareUsed = 0x5032;

        [NativeTypeName("#define PropertyTagThumbnailDateTime 0x5033")]
        public const int PropertyTagThumbnailDateTime = 0x5033;

        [NativeTypeName("#define PropertyTagThumbnailArtist 0x5034")]
        public const int PropertyTagThumbnailArtist = 0x5034;

        [NativeTypeName("#define PropertyTagThumbnailWhitePoint 0x5035")]
        public const int PropertyTagThumbnailWhitePoint = 0x5035;

        [NativeTypeName("#define PropertyTagThumbnailPrimaryChromaticities 0x5036")]
        public const int PropertyTagThumbnailPrimaryChromaticities = 0x5036;

        [NativeTypeName("#define PropertyTagThumbnailYCbCrCoefficients 0x5037")]
        public const int PropertyTagThumbnailYCbCrCoefficients = 0x5037;

        [NativeTypeName("#define PropertyTagThumbnailYCbCrSubsampling 0x5038")]
        public const int PropertyTagThumbnailYCbCrSubsampling = 0x5038;

        [NativeTypeName("#define PropertyTagThumbnailYCbCrPositioning 0x5039")]
        public const int PropertyTagThumbnailYCbCrPositioning = 0x5039;

        [NativeTypeName("#define PropertyTagThumbnailRefBlackWhite 0x503A")]
        public const int PropertyTagThumbnailRefBlackWhite = 0x503A;

        [NativeTypeName("#define PropertyTagThumbnailCopyRight 0x503B")]
        public const int PropertyTagThumbnailCopyRight = 0x503B;

        [NativeTypeName("#define PropertyTagLuminanceTable 0x5090")]
        public const int PropertyTagLuminanceTable = 0x5090;

        [NativeTypeName("#define PropertyTagChrominanceTable 0x5091")]
        public const int PropertyTagChrominanceTable = 0x5091;

        [NativeTypeName("#define PropertyTagFrameDelay 0x5100")]
        public const int PropertyTagFrameDelay = 0x5100;

        [NativeTypeName("#define PropertyTagLoopCount 0x5101")]
        public const int PropertyTagLoopCount = 0x5101;

        [NativeTypeName("#define PropertyTagGlobalPalette 0x5102")]
        public const int PropertyTagGlobalPalette = 0x5102;

        [NativeTypeName("#define PropertyTagIndexBackground 0x5103")]
        public const int PropertyTagIndexBackground = 0x5103;

        [NativeTypeName("#define PropertyTagIndexTransparent 0x5104")]
        public const int PropertyTagIndexTransparent = 0x5104;

        [NativeTypeName("#define PropertyTagPixelUnit 0x5110")]
        public const int PropertyTagPixelUnit = 0x5110;

        [NativeTypeName("#define PropertyTagPixelPerUnitX 0x5111")]
        public const int PropertyTagPixelPerUnitX = 0x5111;

        [NativeTypeName("#define PropertyTagPixelPerUnitY 0x5112")]
        public const int PropertyTagPixelPerUnitY = 0x5112;

        [NativeTypeName("#define PropertyTagPaletteHistogram 0x5113")]
        public const int PropertyTagPaletteHistogram = 0x5113;

        [NativeTypeName("#define PropertyTagExifExposureTime 0x829A")]
        public const int PropertyTagExifExposureTime = 0x829A;

        [NativeTypeName("#define PropertyTagExifFNumber 0x829D")]
        public const int PropertyTagExifFNumber = 0x829D;

        [NativeTypeName("#define PropertyTagExifExposureProg 0x8822")]
        public const int PropertyTagExifExposureProg = 0x8822;

        [NativeTypeName("#define PropertyTagExifSpectralSense 0x8824")]
        public const int PropertyTagExifSpectralSense = 0x8824;

        [NativeTypeName("#define PropertyTagExifISOSpeed 0x8827")]
        public const int PropertyTagExifISOSpeed = 0x8827;

        [NativeTypeName("#define PropertyTagExifOECF 0x8828")]
        public const int PropertyTagExifOECF = 0x8828;

        [NativeTypeName("#define PropertyTagExifVer 0x9000")]
        public const int PropertyTagExifVer = 0x9000;

        [NativeTypeName("#define PropertyTagExifDTOrig 0x9003")]
        public const int PropertyTagExifDTOrig = 0x9003;

        [NativeTypeName("#define PropertyTagExifDTDigitized 0x9004")]
        public const int PropertyTagExifDTDigitized = 0x9004;

        [NativeTypeName("#define PropertyTagExifCompConfig 0x9101")]
        public const int PropertyTagExifCompConfig = 0x9101;

        [NativeTypeName("#define PropertyTagExifCompBPP 0x9102")]
        public const int PropertyTagExifCompBPP = 0x9102;

        [NativeTypeName("#define PropertyTagExifShutterSpeed 0x9201")]
        public const int PropertyTagExifShutterSpeed = 0x9201;

        [NativeTypeName("#define PropertyTagExifAperture 0x9202")]
        public const int PropertyTagExifAperture = 0x9202;

        [NativeTypeName("#define PropertyTagExifBrightness 0x9203")]
        public const int PropertyTagExifBrightness = 0x9203;

        [NativeTypeName("#define PropertyTagExifExposureBias 0x9204")]
        public const int PropertyTagExifExposureBias = 0x9204;

        [NativeTypeName("#define PropertyTagExifMaxAperture 0x9205")]
        public const int PropertyTagExifMaxAperture = 0x9205;

        [NativeTypeName("#define PropertyTagExifSubjectDist 0x9206")]
        public const int PropertyTagExifSubjectDist = 0x9206;

        [NativeTypeName("#define PropertyTagExifMeteringMode 0x9207")]
        public const int PropertyTagExifMeteringMode = 0x9207;

        [NativeTypeName("#define PropertyTagExifLightSource 0x9208")]
        public const int PropertyTagExifLightSource = 0x9208;

        [NativeTypeName("#define PropertyTagExifFlash 0x9209")]
        public const int PropertyTagExifFlash = 0x9209;

        [NativeTypeName("#define PropertyTagExifFocalLength 0x920A")]
        public const int PropertyTagExifFocalLength = 0x920A;

        [NativeTypeName("#define PropertyTagExifSubjectArea 0x9214")]
        public const int PropertyTagExifSubjectArea = 0x9214;

        [NativeTypeName("#define PropertyTagExifMakerNote 0x927C")]
        public const int PropertyTagExifMakerNote = 0x927C;

        [NativeTypeName("#define PropertyTagExifUserComment 0x9286")]
        public const int PropertyTagExifUserComment = 0x9286;

        [NativeTypeName("#define PropertyTagExifDTSubsec 0x9290")]
        public const int PropertyTagExifDTSubsec = 0x9290;

        [NativeTypeName("#define PropertyTagExifDTOrigSS 0x9291")]
        public const int PropertyTagExifDTOrigSS = 0x9291;

        [NativeTypeName("#define PropertyTagExifDTDigSS 0x9292")]
        public const int PropertyTagExifDTDigSS = 0x9292;

        [NativeTypeName("#define PropertyTagExifFPXVer 0xA000")]
        public const int PropertyTagExifFPXVer = 0xA000;

        [NativeTypeName("#define PropertyTagExifColorSpace 0xA001")]
        public const int PropertyTagExifColorSpace = 0xA001;

        [NativeTypeName("#define PropertyTagExifPixXDim 0xA002")]
        public const int PropertyTagExifPixXDim = 0xA002;

        [NativeTypeName("#define PropertyTagExifPixYDim 0xA003")]
        public const int PropertyTagExifPixYDim = 0xA003;

        [NativeTypeName("#define PropertyTagExifRelatedWav 0xA004")]
        public const int PropertyTagExifRelatedWav = 0xA004;

        [NativeTypeName("#define PropertyTagExifInterop 0xA005")]
        public const int PropertyTagExifInterop = 0xA005;

        [NativeTypeName("#define PropertyTagExifFlashEnergy 0xA20B")]
        public const int PropertyTagExifFlashEnergy = 0xA20B;

        [NativeTypeName("#define PropertyTagExifSpatialFR 0xA20C")]
        public const int PropertyTagExifSpatialFR = 0xA20C;

        [NativeTypeName("#define PropertyTagExifFocalXRes 0xA20E")]
        public const int PropertyTagExifFocalXRes = 0xA20E;

        [NativeTypeName("#define PropertyTagExifFocalYRes 0xA20F")]
        public const int PropertyTagExifFocalYRes = 0xA20F;

        [NativeTypeName("#define PropertyTagExifFocalResUnit 0xA210")]
        public const int PropertyTagExifFocalResUnit = 0xA210;

        [NativeTypeName("#define PropertyTagExifSubjectLoc 0xA214")]
        public const int PropertyTagExifSubjectLoc = 0xA214;

        [NativeTypeName("#define PropertyTagExifExposureIndex 0xA215")]
        public const int PropertyTagExifExposureIndex = 0xA215;

        [NativeTypeName("#define PropertyTagExifSensingMethod 0xA217")]
        public const int PropertyTagExifSensingMethod = 0xA217;

        [NativeTypeName("#define PropertyTagExifFileSource 0xA300")]
        public const int PropertyTagExifFileSource = 0xA300;

        [NativeTypeName("#define PropertyTagExifSceneType 0xA301")]
        public const int PropertyTagExifSceneType = 0xA301;

        [NativeTypeName("#define PropertyTagExifCfaPattern 0xA302")]
        public const int PropertyTagExifCfaPattern = 0xA302;

        [NativeTypeName("#define PropertyTagExifCustomRendered 0xA401")]
        public const int PropertyTagExifCustomRendered = 0xA401;

        [NativeTypeName("#define PropertyTagExifExposureMode 0xA402")]
        public const int PropertyTagExifExposureMode = 0xA402;

        [NativeTypeName("#define PropertyTagExifWhiteBalance 0xA403")]
        public const int PropertyTagExifWhiteBalance = 0xA403;

        [NativeTypeName("#define PropertyTagExifDigitalZoomRatio 0xA404")]
        public const int PropertyTagExifDigitalZoomRatio = 0xA404;

        [NativeTypeName("#define PropertyTagExifFocalLengthIn35mmFilm 0xA405")]
        public const int PropertyTagExifFocalLengthIn35mmFilm = 0xA405;

        [NativeTypeName("#define PropertyTagExifSceneCaptureType 0xA406")]
        public const int PropertyTagExifSceneCaptureType = 0xA406;

        [NativeTypeName("#define PropertyTagExifGainControl 0xA407")]
        public const int PropertyTagExifGainControl = 0xA407;

        [NativeTypeName("#define PropertyTagExifContrast 0xA408")]
        public const int PropertyTagExifContrast = 0xA408;

        [NativeTypeName("#define PropertyTagExifSaturation 0xA409")]
        public const int PropertyTagExifSaturation = 0xA409;

        [NativeTypeName("#define PropertyTagExifSharpness 0xA40A")]
        public const int PropertyTagExifSharpness = 0xA40A;

        [NativeTypeName("#define PropertyTagExifDeviceSettingDesc 0xA40B")]
        public const int PropertyTagExifDeviceSettingDesc = 0xA40B;

        [NativeTypeName("#define PropertyTagExifSubjectDistanceRange 0xA40C")]
        public const int PropertyTagExifSubjectDistanceRange = 0xA40C;

        [NativeTypeName("#define PropertyTagExifUniqueImageID 0xA420")]
        public const int PropertyTagExifUniqueImageID = 0xA420;

        [NativeTypeName("#define PropertyTagGpsVer 0x0000")]
        public const int PropertyTagGpsVer = 0x0000;

        [NativeTypeName("#define PropertyTagGpsLatitudeRef 0x0001")]
        public const int PropertyTagGpsLatitudeRef = 0x0001;

        [NativeTypeName("#define PropertyTagGpsLatitude 0x0002")]
        public const int PropertyTagGpsLatitude = 0x0002;

        [NativeTypeName("#define PropertyTagGpsLongitudeRef 0x0003")]
        public const int PropertyTagGpsLongitudeRef = 0x0003;

        [NativeTypeName("#define PropertyTagGpsLongitude 0x0004")]
        public const int PropertyTagGpsLongitude = 0x0004;

        [NativeTypeName("#define PropertyTagGpsAltitudeRef 0x0005")]
        public const int PropertyTagGpsAltitudeRef = 0x0005;

        [NativeTypeName("#define PropertyTagGpsAltitude 0x0006")]
        public const int PropertyTagGpsAltitude = 0x0006;

        [NativeTypeName("#define PropertyTagGpsGpsTime 0x0007")]
        public const int PropertyTagGpsGpsTime = 0x0007;

        [NativeTypeName("#define PropertyTagGpsGpsSatellites 0x0008")]
        public const int PropertyTagGpsGpsSatellites = 0x0008;

        [NativeTypeName("#define PropertyTagGpsGpsStatus 0x0009")]
        public const int PropertyTagGpsGpsStatus = 0x0009;

        [NativeTypeName("#define PropertyTagGpsGpsMeasureMode 0x00A")]
        public const int PropertyTagGpsGpsMeasureMode = 0x00A;

        [NativeTypeName("#define PropertyTagGpsGpsDop 0x000B")]
        public const int PropertyTagGpsGpsDop = 0x000B;

        [NativeTypeName("#define PropertyTagGpsSpeedRef 0x000C")]
        public const int PropertyTagGpsSpeedRef = 0x000C;

        [NativeTypeName("#define PropertyTagGpsSpeed 0x000D")]
        public const int PropertyTagGpsSpeed = 0x000D;

        [NativeTypeName("#define PropertyTagGpsTrackRef 0x000E")]
        public const int PropertyTagGpsTrackRef = 0x000E;

        [NativeTypeName("#define PropertyTagGpsTrack 0x000F")]
        public const int PropertyTagGpsTrack = 0x000F;

        [NativeTypeName("#define PropertyTagGpsImgDirRef 0x0010")]
        public const int PropertyTagGpsImgDirRef = 0x0010;

        [NativeTypeName("#define PropertyTagGpsImgDir 0x0011")]
        public const int PropertyTagGpsImgDir = 0x0011;

        [NativeTypeName("#define PropertyTagGpsMapDatum 0x0012")]
        public const int PropertyTagGpsMapDatum = 0x0012;

        [NativeTypeName("#define PropertyTagGpsDestLatRef 0x0013")]
        public const int PropertyTagGpsDestLatRef = 0x0013;

        [NativeTypeName("#define PropertyTagGpsDestLat 0x0014")]
        public const int PropertyTagGpsDestLat = 0x0014;

        [NativeTypeName("#define PropertyTagGpsDestLongRef 0x0015")]
        public const int PropertyTagGpsDestLongRef = 0x0015;

        [NativeTypeName("#define PropertyTagGpsDestLong 0x0016")]
        public const int PropertyTagGpsDestLong = 0x0016;

        [NativeTypeName("#define PropertyTagGpsDestBearRef 0x0017")]
        public const int PropertyTagGpsDestBearRef = 0x0017;

        [NativeTypeName("#define PropertyTagGpsDestBear 0x0018")]
        public const int PropertyTagGpsDestBear = 0x0018;

        [NativeTypeName("#define PropertyTagGpsDestDistRef 0x0019")]
        public const int PropertyTagGpsDestDistRef = 0x0019;

        [NativeTypeName("#define PropertyTagGpsDestDist 0x001A")]
        public const int PropertyTagGpsDestDist = 0x001A;

        [NativeTypeName("#define PropertyTagGpsProcessingMethod 0x001B")]
        public const int PropertyTagGpsProcessingMethod = 0x001B;

        [NativeTypeName("#define PropertyTagGpsAreaInformation 0x001C")]
        public const int PropertyTagGpsAreaInformation = 0x001C;

        [NativeTypeName("#define PropertyTagGpsDate 0x001D")]
        public const int PropertyTagGpsDate = 0x001D;

        [NativeTypeName("#define PropertyTagGpsDifferential 0x001E")]
        public const int PropertyTagGpsDifferential = 0x001E;

        public static readonly Guid IID_IImageBytes = new Guid(0x025D1823, 0x6C7D, 0x447B, 0xBB, 0xDB, 0xA3, 0xCB, 0xC3, 0xDF, 0xA2, 0xFC);
    }
}
