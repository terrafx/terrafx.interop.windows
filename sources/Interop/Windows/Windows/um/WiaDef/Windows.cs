// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.BASE_VAL_WIA_ERROR"]/*' />
    [NativeTypeName("#define BASE_VAL_WIA_ERROR 0x00000000")]
    public const int BASE_VAL_WIA_ERROR = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BASE_VAL_WIA_SUCCESS"]/*' />
    [NativeTypeName("#define BASE_VAL_WIA_SUCCESS 0x00000000")]
    public const int BASE_VAL_WIA_SUCCESS = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TYMED_CALLBACK"]/*' />
    [NativeTypeName("#define TYMED_CALLBACK 128")]
    public const int TYMED_CALLBACK = 128;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TYMED_MULTIPAGE_FILE"]/*' />
    [NativeTypeName("#define TYMED_MULTIPAGE_FILE 256")]
    public const int TYMED_MULTIPAGE_FILE = 256;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TYMED_MULTIPAGE_CALLBACK"]/*' />
    [NativeTypeName("#define TYMED_MULTIPAGE_CALLBACK 512")]
    public const int TYMED_MULTIPAGE_CALLBACK = 512;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_MSG_DATA_HEADER"]/*' />
    [NativeTypeName("#define IT_MSG_DATA_HEADER 0x0001")]
    public const int IT_MSG_DATA_HEADER = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_MSG_DATA"]/*' />
    [NativeTypeName("#define IT_MSG_DATA 0x0002")]
    public const int IT_MSG_DATA = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_MSG_STATUS"]/*' />
    [NativeTypeName("#define IT_MSG_STATUS 0x0003")]
    public const int IT_MSG_STATUS = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_MSG_TERMINATION"]/*' />
    [NativeTypeName("#define IT_MSG_TERMINATION 0x0004")]
    public const int IT_MSG_TERMINATION = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_MSG_NEW_PAGE"]/*' />
    [NativeTypeName("#define IT_MSG_NEW_PAGE 0x0005")]
    public const int IT_MSG_NEW_PAGE = 0x0005;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_MSG_FILE_PREVIEW_DATA"]/*' />
    [NativeTypeName("#define IT_MSG_FILE_PREVIEW_DATA 0x0006")]
    public const int IT_MSG_FILE_PREVIEW_DATA = 0x0006;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_MSG_FILE_PREVIEW_DATA_HEADER"]/*' />
    [NativeTypeName("#define IT_MSG_FILE_PREVIEW_DATA_HEADER 0x0007")]
    public const int IT_MSG_FILE_PREVIEW_DATA_HEADER = 0x0007;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_STATUS_TRANSFER_FROM_DEVICE"]/*' />
    [NativeTypeName("#define IT_STATUS_TRANSFER_FROM_DEVICE 0x0001")]
    public const int IT_STATUS_TRANSFER_FROM_DEVICE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_STATUS_PROCESSING_DATA"]/*' />
    [NativeTypeName("#define IT_STATUS_PROCESSING_DATA 0x0002")]
    public const int IT_STATUS_PROCESSING_DATA = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_STATUS_TRANSFER_TO_CLIENT"]/*' />
    [NativeTypeName("#define IT_STATUS_TRANSFER_TO_CLIENT 0x0004")]
    public const int IT_STATUS_TRANSFER_TO_CLIENT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IT_STATUS_MASK"]/*' />
    [NativeTypeName("#define IT_STATUS_MASK 0x0007")]
    public const int IT_STATUS_MASK = 0x0007;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeFree"]/*' />
    [NativeTypeName("#define WiaItemTypeFree 0x00000000")]
    public const int WiaItemTypeFree = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeImage"]/*' />
    [NativeTypeName("#define WiaItemTypeImage 0x00000001")]
    public const int WiaItemTypeImage = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeFile"]/*' />
    [NativeTypeName("#define WiaItemTypeFile 0x00000002")]
    public const int WiaItemTypeFile = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeFolder"]/*' />
    [NativeTypeName("#define WiaItemTypeFolder 0x00000004")]
    public const int WiaItemTypeFolder = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeRoot"]/*' />
    [NativeTypeName("#define WiaItemTypeRoot 0x00000008")]
    public const int WiaItemTypeRoot = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeAnalyze"]/*' />
    [NativeTypeName("#define WiaItemTypeAnalyze 0x00000010")]
    public const int WiaItemTypeAnalyze = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeAudio"]/*' />
    [NativeTypeName("#define WiaItemTypeAudio 0x00000020")]
    public const int WiaItemTypeAudio = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeDevice"]/*' />
    [NativeTypeName("#define WiaItemTypeDevice 0x00000040")]
    public const int WiaItemTypeDevice = 0x00000040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeDeleted"]/*' />
    [NativeTypeName("#define WiaItemTypeDeleted 0x00000080")]
    public const int WiaItemTypeDeleted = 0x00000080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeDisconnected"]/*' />
    [NativeTypeName("#define WiaItemTypeDisconnected 0x00000100")]
    public const int WiaItemTypeDisconnected = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeHPanorama"]/*' />
    [NativeTypeName("#define WiaItemTypeHPanorama 0x00000200")]
    public const int WiaItemTypeHPanorama = 0x00000200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeVPanorama"]/*' />
    [NativeTypeName("#define WiaItemTypeVPanorama 0x00000400")]
    public const int WiaItemTypeVPanorama = 0x00000400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeBurst"]/*' />
    [NativeTypeName("#define WiaItemTypeBurst 0x00000800")]
    public const int WiaItemTypeBurst = 0x00000800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeStorage"]/*' />
    [NativeTypeName("#define WiaItemTypeStorage 0x00001000")]
    public const int WiaItemTypeStorage = 0x00001000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeTransfer"]/*' />
    [NativeTypeName("#define WiaItemTypeTransfer 0x00002000")]
    public const int WiaItemTypeTransfer = 0x00002000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeGenerated"]/*' />
    [NativeTypeName("#define WiaItemTypeGenerated 0x00004000")]
    public const int WiaItemTypeGenerated = 0x00004000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeHasAttachments"]/*' />
    [NativeTypeName("#define WiaItemTypeHasAttachments 0x00008000")]
    public const int WiaItemTypeHasAttachments = 0x00008000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeVideo"]/*' />
    [NativeTypeName("#define WiaItemTypeVideo 0x00010000")]
    public const int WiaItemTypeVideo = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeRemoved"]/*' />
    [NativeTypeName("#define WiaItemTypeRemoved 0x80000000")]
    public const uint WiaItemTypeRemoved = 0x80000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeDocument"]/*' />
    [NativeTypeName("#define WiaItemTypeDocument 0x00040000")]
    public const int WiaItemTypeDocument = 0x00040000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeProgrammableDataSource"]/*' />
    [NativeTypeName("#define WiaItemTypeProgrammableDataSource 0x00080000")]
    public const int WiaItemTypeProgrammableDataSource = 0x00080000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WiaItemTypeMask"]/*' />
    [NativeTypeName("#define WiaItemTypeMask 0x800FFFFF")]
    public const uint WiaItemTypeMask = 0x800FFFFF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WHITEBALANCE_MANUAL"]/*' />
    [NativeTypeName("#define WHITEBALANCE_MANUAL 1")]
    public const int WHITEBALANCE_MANUAL = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WHITEBALANCE_AUTO"]/*' />
    [NativeTypeName("#define WHITEBALANCE_AUTO 2")]
    public const int WHITEBALANCE_AUTO = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WHITEBALANCE_ONEPUSH_AUTO"]/*' />
    [NativeTypeName("#define WHITEBALANCE_ONEPUSH_AUTO 3")]
    public const int WHITEBALANCE_ONEPUSH_AUTO = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WHITEBALANCE_DAYLIGHT"]/*' />
    [NativeTypeName("#define WHITEBALANCE_DAYLIGHT 4")]
    public const int WHITEBALANCE_DAYLIGHT = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WHITEBALANCE_FLORESCENT"]/*' />
    [NativeTypeName("#define WHITEBALANCE_FLORESCENT 5")]
    public const int WHITEBALANCE_FLORESCENT = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WHITEBALANCE_TUNGSTEN"]/*' />
    [NativeTypeName("#define WHITEBALANCE_TUNGSTEN 6")]
    public const int WHITEBALANCE_TUNGSTEN = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WHITEBALANCE_FLASH"]/*' />
    [NativeTypeName("#define WHITEBALANCE_FLASH 7")]
    public const int WHITEBALANCE_FLASH = 7;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FOCUSMODE_MANUAL"]/*' />
    [NativeTypeName("#define FOCUSMODE_MANUAL 1")]
    public const int FOCUSMODE_MANUAL = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FOCUSMODE_AUTO"]/*' />
    [NativeTypeName("#define FOCUSMODE_AUTO 2")]
    public const int FOCUSMODE_AUTO = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FOCUSMODE_MACROAUTO"]/*' />
    [NativeTypeName("#define FOCUSMODE_MACROAUTO 3")]
    public const int FOCUSMODE_MACROAUTO = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMETERING_AVERAGE"]/*' />
    [NativeTypeName("#define EXPOSUREMETERING_AVERAGE 1")]
    public const int EXPOSUREMETERING_AVERAGE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMETERING_CENTERWEIGHT"]/*' />
    [NativeTypeName("#define EXPOSUREMETERING_CENTERWEIGHT 2")]
    public const int EXPOSUREMETERING_CENTERWEIGHT = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMETERING_MULTISPOT"]/*' />
    [NativeTypeName("#define EXPOSUREMETERING_MULTISPOT 3")]
    public const int EXPOSUREMETERING_MULTISPOT = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMETERING_CENTERSPOT"]/*' />
    [NativeTypeName("#define EXPOSUREMETERING_CENTERSPOT 4")]
    public const int EXPOSUREMETERING_CENTERSPOT = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLASHMODE_AUTO"]/*' />
    [NativeTypeName("#define FLASHMODE_AUTO 1")]
    public const int FLASHMODE_AUTO = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLASHMODE_OFF"]/*' />
    [NativeTypeName("#define FLASHMODE_OFF 2")]
    public const int FLASHMODE_OFF = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLASHMODE_FILL"]/*' />
    [NativeTypeName("#define FLASHMODE_FILL 3")]
    public const int FLASHMODE_FILL = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLASHMODE_REDEYE_AUTO"]/*' />
    [NativeTypeName("#define FLASHMODE_REDEYE_AUTO 4")]
    public const int FLASHMODE_REDEYE_AUTO = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLASHMODE_REDEYE_FILL"]/*' />
    [NativeTypeName("#define FLASHMODE_REDEYE_FILL 5")]
    public const int FLASHMODE_REDEYE_FILL = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLASHMODE_EXTERNALSYNC"]/*' />
    [NativeTypeName("#define FLASHMODE_EXTERNALSYNC 6")]
    public const int FLASHMODE_EXTERNALSYNC = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMODE_MANUAL"]/*' />
    [NativeTypeName("#define EXPOSUREMODE_MANUAL 1")]
    public const int EXPOSUREMODE_MANUAL = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMODE_AUTO"]/*' />
    [NativeTypeName("#define EXPOSUREMODE_AUTO 2")]
    public const int EXPOSUREMODE_AUTO = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMODE_APERTURE_PRIORITY"]/*' />
    [NativeTypeName("#define EXPOSUREMODE_APERTURE_PRIORITY 3")]
    public const int EXPOSUREMODE_APERTURE_PRIORITY = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMODE_SHUTTER_PRIORITY"]/*' />
    [NativeTypeName("#define EXPOSUREMODE_SHUTTER_PRIORITY 4")]
    public const int EXPOSUREMODE_SHUTTER_PRIORITY = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMODE_PROGRAM_CREATIVE"]/*' />
    [NativeTypeName("#define EXPOSUREMODE_PROGRAM_CREATIVE 5")]
    public const int EXPOSUREMODE_PROGRAM_CREATIVE = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMODE_PROGRAM_ACTION"]/*' />
    [NativeTypeName("#define EXPOSUREMODE_PROGRAM_ACTION 6")]
    public const int EXPOSUREMODE_PROGRAM_ACTION = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXPOSUREMODE_PORTRAIT"]/*' />
    [NativeTypeName("#define EXPOSUREMODE_PORTRAIT 7")]
    public const int EXPOSUREMODE_PORTRAIT = 7;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CAPTUREMODE_NORMAL"]/*' />
    [NativeTypeName("#define CAPTUREMODE_NORMAL 1")]
    public const int CAPTUREMODE_NORMAL = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CAPTUREMODE_BURST"]/*' />
    [NativeTypeName("#define CAPTUREMODE_BURST 2")]
    public const int CAPTUREMODE_BURST = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CAPTUREMODE_TIMELAPSE"]/*' />
    [NativeTypeName("#define CAPTUREMODE_TIMELAPSE 3")]
    public const int CAPTUREMODE_TIMELAPSE = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EFFECTMODE_STANDARD"]/*' />
    [NativeTypeName("#define EFFECTMODE_STANDARD 1")]
    public const int EFFECTMODE_STANDARD = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EFFECTMODE_BW"]/*' />
    [NativeTypeName("#define EFFECTMODE_BW 2")]
    public const int EFFECTMODE_BW = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EFFECTMODE_SEPIA"]/*' />
    [NativeTypeName("#define EFFECTMODE_SEPIA 3")]
    public const int EFFECTMODE_SEPIA = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FOCUSMETERING_CENTERSPOT"]/*' />
    [NativeTypeName("#define FOCUSMETERING_CENTERSPOT 1")]
    public const int FOCUSMETERING_CENTERSPOT = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FOCUSMETERING_MULTISPOT"]/*' />
    [NativeTypeName("#define FOCUSMETERING_MULTISPOT 2")]
    public const int FOCUSMETERING_MULTISPOT = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.POWERMODE_LINE"]/*' />
    [NativeTypeName("#define POWERMODE_LINE 1")]
    public const int POWERMODE_LINE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.POWERMODE_BATTERY"]/*' />
    [NativeTypeName("#define POWERMODE_BATTERY 2")]
    public const int POWERMODE_BATTERY = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LEFT_JUSTIFIED"]/*' />
    [NativeTypeName("#define LEFT_JUSTIFIED 0")]
    public const int LEFT_JUSTIFIED = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RIGHT_JUSTIFIED"]/*' />
    [NativeTypeName("#define RIGHT_JUSTIFIED 2")]
    public const int RIGHT_JUSTIFIED = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TOP_JUSTIFIED"]/*' />
    [NativeTypeName("#define TOP_JUSTIFIED 0")]
    public const int TOP_JUSTIFIED = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BOTTOM_JUSTIFIED"]/*' />
    [NativeTypeName("#define BOTTOM_JUSTIFIED 2")]
    public const int BOTTOM_JUSTIFIED = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PORTRAIT"]/*' />
    [NativeTypeName("#define PORTRAIT 0")]
    public const int PORTRAIT = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LANSCAPE"]/*' />
    [NativeTypeName("#define LANSCAPE 1")]
    public const int LANSCAPE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LANDSCAPE"]/*' />
    [NativeTypeName("#define LANDSCAPE LANSCAPE")]
    public const int LANDSCAPE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ROT180"]/*' />
    [NativeTypeName("#define ROT180 2")]
    public const int ROT180 = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ROT270"]/*' />
    [NativeTypeName("#define ROT270 3")]
    public const int ROT270 = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MIRRORED"]/*' />
    [NativeTypeName("#define MIRRORED 0x01")]
    public const int MIRRORED = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FEED"]/*' />
    [NativeTypeName("#define FEED 0x01")]
    public const int FEED = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAT"]/*' />
    [NativeTypeName("#define FLAT 0x02")]
    public const int FLAT = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DUP"]/*' />
    [NativeTypeName("#define DUP 0x04")]
    public const int DUP = 0x04;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DETECT_FLAT"]/*' />
    [NativeTypeName("#define DETECT_FLAT 0x08")]
    public const int DETECT_FLAT = 0x08;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DETECT_SCAN"]/*' />
    [NativeTypeName("#define DETECT_SCAN 0x10")]
    public const int DETECT_SCAN = 0x10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DETECT_FEED"]/*' />
    [NativeTypeName("#define DETECT_FEED 0x20")]
    public const int DETECT_FEED = 0x20;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DETECT_DUP"]/*' />
    [NativeTypeName("#define DETECT_DUP 0x40")]
    public const int DETECT_DUP = 0x40;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DETECT_FEED_AVAIL"]/*' />
    [NativeTypeName("#define DETECT_FEED_AVAIL 0x80")]
    public const int DETECT_FEED_AVAIL = 0x80;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DETECT_DUP_AVAIL"]/*' />
    [NativeTypeName("#define DETECT_DUP_AVAIL 0x100")]
    public const int DETECT_DUP_AVAIL = 0x100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILM_TPA"]/*' />
    [NativeTypeName("#define FILM_TPA 0x200")]
    public const int FILM_TPA = 0x200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DETECT_FILM_TPA"]/*' />
    [NativeTypeName("#define DETECT_FILM_TPA 0x400")]
    public const int DETECT_FILM_TPA = 0x400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.STOR"]/*' />
    [NativeTypeName("#define STOR 0x800")]
    public const int STOR = 0x800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DETECT_STOR"]/*' />
    [NativeTypeName("#define DETECT_STOR 0x1000")]
    public const int DETECT_STOR = 0x1000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ADVANCED_DUP"]/*' />
    [NativeTypeName("#define ADVANCED_DUP 0x2000")]
    public const int ADVANCED_DUP = 0x2000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AUTO_SOURCE"]/*' />
    [NativeTypeName("#define AUTO_SOURCE 0x8000")]
    public const int AUTO_SOURCE = 0x8000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPRINTER"]/*' />
    [NativeTypeName("#define IMPRINTER 0x10000")]
    public const int IMPRINTER = 0x10000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENDORSER"]/*' />
    [NativeTypeName("#define ENDORSER 0x20000")]
    public const int ENDORSER = 0x20000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BARCODE_READER"]/*' />
    [NativeTypeName("#define BARCODE_READER 0x40000")]
    public const int BARCODE_READER = 0x40000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PATCH_CODE_READER"]/*' />
    [NativeTypeName("#define PATCH_CODE_READER 0x80000")]
    public const int PATCH_CODE_READER = 0x80000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MICR_READER"]/*' />
    [NativeTypeName("#define MICR_READER 0x100000")]
    public const int MICR_READER = 0x100000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FEED_READY"]/*' />
    [NativeTypeName("#define FEED_READY 0x01")]
    public const int FEED_READY = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAT_READY"]/*' />
    [NativeTypeName("#define FLAT_READY 0x02")]
    public const int FLAT_READY = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DUP_READY"]/*' />
    [NativeTypeName("#define DUP_READY 0x04")]
    public const int DUP_READY = 0x04;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLAT_COVER_UP"]/*' />
    [NativeTypeName("#define FLAT_COVER_UP 0x08")]
    public const int FLAT_COVER_UP = 0x08;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PATH_COVER_UP"]/*' />
    [NativeTypeName("#define PATH_COVER_UP 0x10")]
    public const int PATH_COVER_UP = 0x10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PAPER_JAM"]/*' />
    [NativeTypeName("#define PAPER_JAM 0x20")]
    public const int PAPER_JAM = 0x20;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FILM_TPA_READY"]/*' />
    [NativeTypeName("#define FILM_TPA_READY 0x40")]
    public const int FILM_TPA_READY = 0x40;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MULTIPLE_FEED"]/*' />
    [NativeTypeName("#define MULTIPLE_FEED 0x200")]
    public const int MULTIPLE_FEED = 0x200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LAMP_ERR"]/*' />
    [NativeTypeName("#define LAMP_ERR 0x800")]
    public const int LAMP_ERR = 0x800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IMPRINTER_READY"]/*' />
    [NativeTypeName("#define IMPRINTER_READY 0x1000")]
    public const int IMPRINTER_READY = 0x1000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ENDORSER_READY"]/*' />
    [NativeTypeName("#define ENDORSER_READY 0x2000")]
    public const int ENDORSER_READY = 0x2000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BARCODE_READER_READY"]/*' />
    [NativeTypeName("#define BARCODE_READER_READY 0x4000")]
    public const int BARCODE_READER_READY = 0x4000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PATCH_CODE_READER_READY"]/*' />
    [NativeTypeName("#define PATCH_CODE_READER_READY 0x8000")]
    public const int PATCH_CODE_READER_READY = 0x8000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MICR_READER_READY"]/*' />
    [NativeTypeName("#define MICR_READER_READY 0x10000")]
    public const int MICR_READER_READY = 0x10000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FEEDER"]/*' />
    [NativeTypeName("#define FEEDER 0x001")]
    public const int FEEDER = 0x001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FLATBED"]/*' />
    [NativeTypeName("#define FLATBED 0x002")]
    public const int FLATBED = 0x002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DUPLEX"]/*' />
    [NativeTypeName("#define DUPLEX 0x004")]
    public const int DUPLEX = 0x004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FRONT_FIRST"]/*' />
    [NativeTypeName("#define FRONT_FIRST 0x008")]
    public const int FRONT_FIRST = 0x008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BACK_FIRST"]/*' />
    [NativeTypeName("#define BACK_FIRST 0x010")]
    public const int BACK_FIRST = 0x010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FRONT_ONLY"]/*' />
    [NativeTypeName("#define FRONT_ONLY 0x020")]
    public const int FRONT_ONLY = 0x020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BACK_ONLY"]/*' />
    [NativeTypeName("#define BACK_ONLY 0x040")]
    public const int BACK_ONLY = 0x040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.NEXT_PAGE"]/*' />
    [NativeTypeName("#define NEXT_PAGE 0x080")]
    public const int NEXT_PAGE = 0x080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PREFEED"]/*' />
    [NativeTypeName("#define PREFEED 0x100")]
    public const int PREFEED = 0x100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AUTO_ADVANCE"]/*' />
    [NativeTypeName("#define AUTO_ADVANCE 0x200")]
    public const int AUTO_ADVANCE = 0x200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ADVANCED_DUPLEX"]/*' />
    [NativeTypeName("#define ADVANCED_DUPLEX 0x400")]
    public const int ADVANCED_DUPLEX = 0x400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIGHT_SOURCE_PRESENT_DETECT"]/*' />
    [NativeTypeName("#define LIGHT_SOURCE_PRESENT_DETECT 0x01")]
    public const int LIGHT_SOURCE_PRESENT_DETECT = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIGHT_SOURCE_PRESENT"]/*' />
    [NativeTypeName("#define LIGHT_SOURCE_PRESENT 0x02")]
    public const int LIGHT_SOURCE_PRESENT = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIGHT_SOURCE_DETECT_READY"]/*' />
    [NativeTypeName("#define LIGHT_SOURCE_DETECT_READY 0x04")]
    public const int LIGHT_SOURCE_DETECT_READY = 0x04;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIGHT_SOURCE_READY"]/*' />
    [NativeTypeName("#define LIGHT_SOURCE_READY 0x08")]
    public const int LIGHT_SOURCE_READY = 0x08;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRANSPARENCY_DYNAMIC_FRAME_SUPPORT"]/*' />
    [NativeTypeName("#define TRANSPARENCY_DYNAMIC_FRAME_SUPPORT 0x01")]
    public const int TRANSPARENCY_DYNAMIC_FRAME_SUPPORT = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TRANSPARENCY_STATIC_FRAME_SUPPORT"]/*' />
    [NativeTypeName("#define TRANSPARENCY_STATIC_FRAME_SUPPORT 0x02")]
    public const int TRANSPARENCY_STATIC_FRAME_SUPPORT = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIGHT_SOURCE_SELECT"]/*' />
    [NativeTypeName("#define LIGHT_SOURCE_SELECT 0x001")]
    public const int LIGHT_SOURCE_SELECT = 0x001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIGHT_SOURCE_POSITIVE"]/*' />
    [NativeTypeName("#define LIGHT_SOURCE_POSITIVE 0x002")]
    public const int LIGHT_SOURCE_POSITIVE = 0x002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LIGHT_SOURCE_NEGATIVE"]/*' />
    [NativeTypeName("#define LIGHT_SOURCE_NEGATIVE 0x004")]
    public const int LIGHT_SOURCE_NEGATIVE = 0x004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ALL_PAGES"]/*' />
    [NativeTypeName("#define ALL_PAGES 0")]
    public const int ALL_PAGES = 0;
}
