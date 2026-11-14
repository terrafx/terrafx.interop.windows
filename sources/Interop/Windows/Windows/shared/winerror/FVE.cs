// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FVE
{
    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_LOCKED_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_LOCKED_VOLUME _HRESULT_TYPEDEF_(0x80310000L)")]
    public const int FVE_E_LOCKED_VOLUME = unchecked((int)(0x80310000));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ENCRYPTED"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ENCRYPTED _HRESULT_TYPEDEF_(0x80310001L)")]
    public const int FVE_E_NOT_ENCRYPTED = unchecked((int)(0x80310001));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_TPM_BIOS"]/*' />
    [NativeTypeName("#define FVE_E_NO_TPM_BIOS _HRESULT_TYPEDEF_(0x80310002L)")]
    public const int FVE_E_NO_TPM_BIOS = unchecked((int)(0x80310002));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_MBR_METRIC"]/*' />
    [NativeTypeName("#define FVE_E_NO_MBR_METRIC _HRESULT_TYPEDEF_(0x80310003L)")]
    public const int FVE_E_NO_MBR_METRIC = unchecked((int)(0x80310003));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_BOOTSECTOR_METRIC"]/*' />
    [NativeTypeName("#define FVE_E_NO_BOOTSECTOR_METRIC _HRESULT_TYPEDEF_(0x80310004L)")]
    public const int FVE_E_NO_BOOTSECTOR_METRIC = unchecked((int)(0x80310004));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_BOOTMGR_METRIC"]/*' />
    [NativeTypeName("#define FVE_E_NO_BOOTMGR_METRIC _HRESULT_TYPEDEF_(0x80310005L)")]
    public const int FVE_E_NO_BOOTMGR_METRIC = unchecked((int)(0x80310005));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_WRONG_BOOTMGR"]/*' />
    [NativeTypeName("#define FVE_E_WRONG_BOOTMGR _HRESULT_TYPEDEF_(0x80310006L)")]
    public const int FVE_E_WRONG_BOOTMGR = unchecked((int)(0x80310006));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SECURE_KEY_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_SECURE_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310007L)")]
    public const int FVE_E_SECURE_KEY_REQUIRED = unchecked((int)(0x80310007));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ACTIVATED"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ACTIVATED _HRESULT_TYPEDEF_(0x80310008L)")]
    public const int FVE_E_NOT_ACTIVATED = unchecked((int)(0x80310008));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_ACTION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_ACTION_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310009L)")]
    public const int FVE_E_ACTION_NOT_ALLOWED = unchecked((int)(0x80310009));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_SCHEMA_NOT_INSTALLED"]/*' />
    [NativeTypeName("#define FVE_E_AD_SCHEMA_NOT_INSTALLED _HRESULT_TYPEDEF_(0x8031000AL)")]
    public const int FVE_E_AD_SCHEMA_NOT_INSTALLED = unchecked((int)(0x8031000A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_INVALID_DATATYPE"]/*' />
    [NativeTypeName("#define FVE_E_AD_INVALID_DATATYPE _HRESULT_TYPEDEF_(0x8031000BL)")]
    public const int FVE_E_AD_INVALID_DATATYPE = unchecked((int)(0x8031000B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_INVALID_DATASIZE"]/*' />
    [NativeTypeName("#define FVE_E_AD_INVALID_DATASIZE _HRESULT_TYPEDEF_(0x8031000CL)")]
    public const int FVE_E_AD_INVALID_DATASIZE = unchecked((int)(0x8031000C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_NO_VALUES"]/*' />
    [NativeTypeName("#define FVE_E_AD_NO_VALUES _HRESULT_TYPEDEF_(0x8031000DL)")]
    public const int FVE_E_AD_NO_VALUES = unchecked((int)(0x8031000D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_ATTR_NOT_SET"]/*' />
    [NativeTypeName("#define FVE_E_AD_ATTR_NOT_SET _HRESULT_TYPEDEF_(0x8031000EL)")]
    public const int FVE_E_AD_ATTR_NOT_SET = unchecked((int)(0x8031000E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_GUID_NOT_FOUND"]/*' />
    [NativeTypeName("#define FVE_E_AD_GUID_NOT_FOUND _HRESULT_TYPEDEF_(0x8031000FL)")]
    public const int FVE_E_AD_GUID_NOT_FOUND = unchecked((int)(0x8031000F));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BAD_INFORMATION"]/*' />
    [NativeTypeName("#define FVE_E_BAD_INFORMATION _HRESULT_TYPEDEF_(0x80310010L)")]
    public const int FVE_E_BAD_INFORMATION = unchecked((int)(0x80310010));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TOO_SMALL"]/*' />
    [NativeTypeName("#define FVE_E_TOO_SMALL _HRESULT_TYPEDEF_(0x80310011L)")]
    public const int FVE_E_TOO_SMALL = unchecked((int)(0x80310011));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SYSTEM_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_SYSTEM_VOLUME _HRESULT_TYPEDEF_(0x80310012L)")]
    public const int FVE_E_SYSTEM_VOLUME = unchecked((int)(0x80310012));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FAILED_WRONG_FS"]/*' />
    [NativeTypeName("#define FVE_E_FAILED_WRONG_FS _HRESULT_TYPEDEF_(0x80310013L)")]
    public const int FVE_E_FAILED_WRONG_FS = unchecked((int)(0x80310013));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BAD_PARTITION_SIZE"]/*' />
    [NativeTypeName("#define FVE_E_BAD_PARTITION_SIZE _HRESULT_TYPEDEF_(0x80310014L)")]
    public const int FVE_E_BAD_PARTITION_SIZE = unchecked((int)(0x80310014));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80310015L)")]
    public const int FVE_E_NOT_SUPPORTED = unchecked((int)(0x80310015));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BAD_DATA"]/*' />
    [NativeTypeName("#define FVE_E_BAD_DATA _HRESULT_TYPEDEF_(0x80310016L)")]
    public const int FVE_E_BAD_DATA = unchecked((int)(0x80310016));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_VOLUME_NOT_BOUND"]/*' />
    [NativeTypeName("#define FVE_E_VOLUME_NOT_BOUND _HRESULT_TYPEDEF_(0x80310017L)")]
    public const int FVE_E_VOLUME_NOT_BOUND = unchecked((int)(0x80310017));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_NOT_OWNED"]/*' />
    [NativeTypeName("#define FVE_E_TPM_NOT_OWNED _HRESULT_TYPEDEF_(0x80310018L)")]
    public const int FVE_E_TPM_NOT_OWNED = unchecked((int)(0x80310018));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_DATA_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_NOT_DATA_VOLUME _HRESULT_TYPEDEF_(0x80310019L)")]
    public const int FVE_E_NOT_DATA_VOLUME = unchecked((int)(0x80310019));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_INSUFFICIENT_BUFFER"]/*' />
    [NativeTypeName("#define FVE_E_AD_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x8031001AL)")]
    public const int FVE_E_AD_INSUFFICIENT_BUFFER = unchecked((int)(0x8031001A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_CONV_READ"]/*' />
    [NativeTypeName("#define FVE_E_CONV_READ _HRESULT_TYPEDEF_(0x8031001BL)")]
    public const int FVE_E_CONV_READ = unchecked((int)(0x8031001B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_CONV_WRITE"]/*' />
    [NativeTypeName("#define FVE_E_CONV_WRITE _HRESULT_TYPEDEF_(0x8031001CL)")]
    public const int FVE_E_CONV_WRITE = unchecked((int)(0x8031001C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_KEY_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_KEY_REQUIRED _HRESULT_TYPEDEF_(0x8031001DL)")]
    public const int FVE_E_KEY_REQUIRED = unchecked((int)(0x8031001D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_CLUSTERING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_CLUSTERING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8031001EL)")]
    public const int FVE_E_CLUSTERING_NOT_SUPPORTED = unchecked((int)(0x8031001E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_VOLUME_BOUND_ALREADY"]/*' />
    [NativeTypeName("#define FVE_E_VOLUME_BOUND_ALREADY _HRESULT_TYPEDEF_(0x8031001FL)")]
    public const int FVE_E_VOLUME_BOUND_ALREADY = unchecked((int)(0x8031001F));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_OS_NOT_PROTECTED"]/*' />
    [NativeTypeName("#define FVE_E_OS_NOT_PROTECTED _HRESULT_TYPEDEF_(0x80310020L)")]
    public const int FVE_E_OS_NOT_PROTECTED = unchecked((int)(0x80310020));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PROTECTION_DISABLED"]/*' />
    [NativeTypeName("#define FVE_E_PROTECTION_DISABLED _HRESULT_TYPEDEF_(0x80310021L)")]
    public const int FVE_E_PROTECTION_DISABLED = unchecked((int)(0x80310021));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_RECOVERY_KEY_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_RECOVERY_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310022L)")]
    public const int FVE_E_RECOVERY_KEY_REQUIRED = unchecked((int)(0x80310022));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FOREIGN_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_FOREIGN_VOLUME _HRESULT_TYPEDEF_(0x80310023L)")]
    public const int FVE_E_FOREIGN_VOLUME = unchecked((int)(0x80310023));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_OVERLAPPED_UPDATE"]/*' />
    [NativeTypeName("#define FVE_E_OVERLAPPED_UPDATE _HRESULT_TYPEDEF_(0x80310024L)")]
    public const int FVE_E_OVERLAPPED_UPDATE = unchecked((int)(0x80310024));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_SRK_AUTH_NOT_ZERO"]/*' />
    [NativeTypeName("#define FVE_E_TPM_SRK_AUTH_NOT_ZERO _HRESULT_TYPEDEF_(0x80310025L)")]
    public const int FVE_E_TPM_SRK_AUTH_NOT_ZERO = unchecked((int)(0x80310025));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FAILED_SECTOR_SIZE"]/*' />
    [NativeTypeName("#define FVE_E_FAILED_SECTOR_SIZE _HRESULT_TYPEDEF_(0x80310026L)")]
    public const int FVE_E_FAILED_SECTOR_SIZE = unchecked((int)(0x80310026));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FAILED_AUTHENTICATION"]/*' />
    [NativeTypeName("#define FVE_E_FAILED_AUTHENTICATION _HRESULT_TYPEDEF_(0x80310027L)")]
    public const int FVE_E_FAILED_AUTHENTICATION = unchecked((int)(0x80310027));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_OS_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_NOT_OS_VOLUME _HRESULT_TYPEDEF_(0x80310028L)")]
    public const int FVE_E_NOT_OS_VOLUME = unchecked((int)(0x80310028));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AUTOUNLOCK_ENABLED"]/*' />
    [NativeTypeName("#define FVE_E_AUTOUNLOCK_ENABLED _HRESULT_TYPEDEF_(0x80310029L)")]
    public const int FVE_E_AUTOUNLOCK_ENABLED = unchecked((int)(0x80310029));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_WRONG_BOOTSECTOR"]/*' />
    [NativeTypeName("#define FVE_E_WRONG_BOOTSECTOR _HRESULT_TYPEDEF_(0x8031002AL)")]
    public const int FVE_E_WRONG_BOOTSECTOR = unchecked((int)(0x8031002A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_WRONG_SYSTEM_FS"]/*' />
    [NativeTypeName("#define FVE_E_WRONG_SYSTEM_FS _HRESULT_TYPEDEF_(0x8031002BL)")]
    public const int FVE_E_WRONG_SYSTEM_FS = unchecked((int)(0x8031002B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_PASSWORD_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_PASSWORD_REQUIRED _HRESULT_TYPEDEF_(0x8031002CL)")]
    public const int FVE_E_POLICY_PASSWORD_REQUIRED = unchecked((int)(0x8031002C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_CANNOT_SET_FVEK_ENCRYPTED"]/*' />
    [NativeTypeName("#define FVE_E_CANNOT_SET_FVEK_ENCRYPTED _HRESULT_TYPEDEF_(0x8031002DL)")]
    public const int FVE_E_CANNOT_SET_FVEK_ENCRYPTED = unchecked((int)(0x8031002D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_CANNOT_ENCRYPT_NO_KEY"]/*' />
    [NativeTypeName("#define FVE_E_CANNOT_ENCRYPT_NO_KEY _HRESULT_TYPEDEF_(0x8031002EL)")]
    public const int FVE_E_CANNOT_ENCRYPT_NO_KEY = unchecked((int)(0x8031002E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BOOTABLE_CDDVD"]/*' />
    [NativeTypeName("#define FVE_E_BOOTABLE_CDDVD _HRESULT_TYPEDEF_(0x80310030L)")]
    public const int FVE_E_BOOTABLE_CDDVD = unchecked((int)(0x80310030));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PROTECTOR_EXISTS"]/*' />
    [NativeTypeName("#define FVE_E_PROTECTOR_EXISTS _HRESULT_TYPEDEF_(0x80310031L)")]
    public const int FVE_E_PROTECTOR_EXISTS = unchecked((int)(0x80310031));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_RELATIVE_PATH"]/*' />
    [NativeTypeName("#define FVE_E_RELATIVE_PATH _HRESULT_TYPEDEF_(0x80310032L)")]
    public const int FVE_E_RELATIVE_PATH = unchecked((int)(0x80310032));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PROTECTOR_NOT_FOUND"]/*' />
    [NativeTypeName("#define FVE_E_PROTECTOR_NOT_FOUND _HRESULT_TYPEDEF_(0x80310033L)")]
    public const int FVE_E_PROTECTOR_NOT_FOUND = unchecked((int)(0x80310033));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_KEY_FORMAT"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_KEY_FORMAT _HRESULT_TYPEDEF_(0x80310034L)")]
    public const int FVE_E_INVALID_KEY_FORMAT = unchecked((int)(0x80310034));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_PASSWORD_FORMAT"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_PASSWORD_FORMAT _HRESULT_TYPEDEF_(0x80310035L)")]
    public const int FVE_E_INVALID_PASSWORD_FORMAT = unchecked((int)(0x80310035));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FIPS_RNG_CHECK_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_FIPS_RNG_CHECK_FAILED _HRESULT_TYPEDEF_(0x80310036L)")]
    public const int FVE_E_FIPS_RNG_CHECK_FAILED = unchecked((int)(0x80310036));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FIPS_PREVENTS_RECOVERY_PASSWORD"]/*' />
    [NativeTypeName("#define FVE_E_FIPS_PREVENTS_RECOVERY_PASSWORD _HRESULT_TYPEDEF_(0x80310037L)")]
    public const int FVE_E_FIPS_PREVENTS_RECOVERY_PASSWORD = unchecked((int)(0x80310037));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FIPS_PREVENTS_EXTERNAL_KEY_EXPORT"]/*' />
    [NativeTypeName("#define FVE_E_FIPS_PREVENTS_EXTERNAL_KEY_EXPORT _HRESULT_TYPEDEF_(0x80310038L)")]
    public const int FVE_E_FIPS_PREVENTS_EXTERNAL_KEY_EXPORT = unchecked((int)(0x80310038));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_DECRYPTED"]/*' />
    [NativeTypeName("#define FVE_E_NOT_DECRYPTED _HRESULT_TYPEDEF_(0x80310039L)")]
    public const int FVE_E_NOT_DECRYPTED = unchecked((int)(0x80310039));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_PROTECTOR_TYPE"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_PROTECTOR_TYPE _HRESULT_TYPEDEF_(0x8031003AL)")]
    public const int FVE_E_INVALID_PROTECTOR_TYPE = unchecked((int)(0x8031003A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_PROTECTORS_TO_TEST"]/*' />
    [NativeTypeName("#define FVE_E_NO_PROTECTORS_TO_TEST _HRESULT_TYPEDEF_(0x8031003BL)")]
    public const int FVE_E_NO_PROTECTORS_TO_TEST = unchecked((int)(0x8031003B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_KEYFILE_NOT_FOUND"]/*' />
    [NativeTypeName("#define FVE_E_KEYFILE_NOT_FOUND _HRESULT_TYPEDEF_(0x8031003CL)")]
    public const int FVE_E_KEYFILE_NOT_FOUND = unchecked((int)(0x8031003C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_KEYFILE_INVALID"]/*' />
    [NativeTypeName("#define FVE_E_KEYFILE_INVALID _HRESULT_TYPEDEF_(0x8031003DL)")]
    public const int FVE_E_KEYFILE_INVALID = unchecked((int)(0x8031003D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_KEYFILE_NO_VMK"]/*' />
    [NativeTypeName("#define FVE_E_KEYFILE_NO_VMK _HRESULT_TYPEDEF_(0x8031003EL)")]
    public const int FVE_E_KEYFILE_NO_VMK = unchecked((int)(0x8031003E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_DISABLED"]/*' />
    [NativeTypeName("#define FVE_E_TPM_DISABLED _HRESULT_TYPEDEF_(0x8031003FL)")]
    public const int FVE_E_TPM_DISABLED = unchecked((int)(0x8031003F));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ALLOWED_IN_SAFE_MODE"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_IN_SAFE_MODE _HRESULT_TYPEDEF_(0x80310040L)")]
    public const int FVE_E_NOT_ALLOWED_IN_SAFE_MODE = unchecked((int)(0x80310040));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_INVALID_PCR"]/*' />
    [NativeTypeName("#define FVE_E_TPM_INVALID_PCR _HRESULT_TYPEDEF_(0x80310041L)")]
    public const int FVE_E_TPM_INVALID_PCR = unchecked((int)(0x80310041));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_NO_VMK"]/*' />
    [NativeTypeName("#define FVE_E_TPM_NO_VMK _HRESULT_TYPEDEF_(0x80310042L)")]
    public const int FVE_E_TPM_NO_VMK = unchecked((int)(0x80310042));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PIN_INVALID"]/*' />
    [NativeTypeName("#define FVE_E_PIN_INVALID _HRESULT_TYPEDEF_(0x80310043L)")]
    public const int FVE_E_PIN_INVALID = unchecked((int)(0x80310043));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AUTH_INVALID_APPLICATION"]/*' />
    [NativeTypeName("#define FVE_E_AUTH_INVALID_APPLICATION _HRESULT_TYPEDEF_(0x80310044L)")]
    public const int FVE_E_AUTH_INVALID_APPLICATION = unchecked((int)(0x80310044));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AUTH_INVALID_CONFIG"]/*' />
    [NativeTypeName("#define FVE_E_AUTH_INVALID_CONFIG _HRESULT_TYPEDEF_(0x80310045L)")]
    public const int FVE_E_AUTH_INVALID_CONFIG = unchecked((int)(0x80310045));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FIPS_DISABLE_PROTECTION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_FIPS_DISABLE_PROTECTION_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310046L)")]
    public const int FVE_E_FIPS_DISABLE_PROTECTION_NOT_ALLOWED = unchecked((int)(0x80310046));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FS_NOT_EXTENDED"]/*' />
    [NativeTypeName("#define FVE_E_FS_NOT_EXTENDED _HRESULT_TYPEDEF_(0x80310047L)")]
    public const int FVE_E_FS_NOT_EXTENDED = unchecked((int)(0x80310047));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FIRMWARE_TYPE_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_FIRMWARE_TYPE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80310048L)")]
    public const int FVE_E_FIRMWARE_TYPE_NOT_SUPPORTED = unchecked((int)(0x80310048));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_LICENSE"]/*' />
    [NativeTypeName("#define FVE_E_NO_LICENSE _HRESULT_TYPEDEF_(0x80310049L)")]
    public const int FVE_E_NO_LICENSE = unchecked((int)(0x80310049));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ON_STACK"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ON_STACK _HRESULT_TYPEDEF_(0x8031004AL)")]
    public const int FVE_E_NOT_ON_STACK = unchecked((int)(0x8031004A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FS_MOUNTED"]/*' />
    [NativeTypeName("#define FVE_E_FS_MOUNTED _HRESULT_TYPEDEF_(0x8031004BL)")]
    public const int FVE_E_FS_MOUNTED = unchecked((int)(0x8031004B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TOKEN_NOT_IMPERSONATED"]/*' />
    [NativeTypeName("#define FVE_E_TOKEN_NOT_IMPERSONATED _HRESULT_TYPEDEF_(0x8031004CL)")]
    public const int FVE_E_TOKEN_NOT_IMPERSONATED = unchecked((int)(0x8031004C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DRY_RUN_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_DRY_RUN_FAILED _HRESULT_TYPEDEF_(0x8031004DL)")]
    public const int FVE_E_DRY_RUN_FAILED = unchecked((int)(0x8031004D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_REBOOT_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_REBOOT_REQUIRED _HRESULT_TYPEDEF_(0x8031004EL)")]
    public const int FVE_E_REBOOT_REQUIRED = unchecked((int)(0x8031004E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DEBUGGER_ENABLED"]/*' />
    [NativeTypeName("#define FVE_E_DEBUGGER_ENABLED _HRESULT_TYPEDEF_(0x8031004FL)")]
    public const int FVE_E_DEBUGGER_ENABLED = unchecked((int)(0x8031004F));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_RAW_ACCESS"]/*' />
    [NativeTypeName("#define FVE_E_RAW_ACCESS _HRESULT_TYPEDEF_(0x80310050L)")]
    public const int FVE_E_RAW_ACCESS = unchecked((int)(0x80310050));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_RAW_BLOCKED"]/*' />
    [NativeTypeName("#define FVE_E_RAW_BLOCKED _HRESULT_TYPEDEF_(0x80310051L)")]
    public const int FVE_E_RAW_BLOCKED = unchecked((int)(0x80310051));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BCD_APPLICATIONS_PATH_INCORRECT"]/*' />
    [NativeTypeName("#define FVE_E_BCD_APPLICATIONS_PATH_INCORRECT _HRESULT_TYPEDEF_(0x80310052L)")]
    public const int FVE_E_BCD_APPLICATIONS_PATH_INCORRECT = unchecked((int)(0x80310052));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ALLOWED_IN_VERSION"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_IN_VERSION _HRESULT_TYPEDEF_(0x80310053L)")]
    public const int FVE_E_NOT_ALLOWED_IN_VERSION = unchecked((int)(0x80310053));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_AUTOUNLOCK_MASTER_KEY"]/*' />
    [NativeTypeName("#define FVE_E_NO_AUTOUNLOCK_MASTER_KEY _HRESULT_TYPEDEF_(0x80310054L)")]
    public const int FVE_E_NO_AUTOUNLOCK_MASTER_KEY = unchecked((int)(0x80310054));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_MOR_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_MOR_FAILED _HRESULT_TYPEDEF_(0x80310055L)")]
    public const int FVE_E_MOR_FAILED = unchecked((int)(0x80310055));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_HIDDEN_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_HIDDEN_VOLUME _HRESULT_TYPEDEF_(0x80310056L)")]
    public const int FVE_E_HIDDEN_VOLUME = unchecked((int)(0x80310056));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TRANSIENT_STATE"]/*' />
    [NativeTypeName("#define FVE_E_TRANSIENT_STATE _HRESULT_TYPEDEF_(0x80310057L)")]
    public const int FVE_E_TRANSIENT_STATE = unchecked((int)(0x80310057));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PUBKEY_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_PUBKEY_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310058L)")]
    public const int FVE_E_PUBKEY_NOT_ALLOWED = unchecked((int)(0x80310058));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_VOLUME_HANDLE_OPEN"]/*' />
    [NativeTypeName("#define FVE_E_VOLUME_HANDLE_OPEN _HRESULT_TYPEDEF_(0x80310059L)")]
    public const int FVE_E_VOLUME_HANDLE_OPEN = unchecked((int)(0x80310059));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_FEATURE_LICENSE"]/*' />
    [NativeTypeName("#define FVE_E_NO_FEATURE_LICENSE _HRESULT_TYPEDEF_(0x8031005AL)")]
    public const int FVE_E_NO_FEATURE_LICENSE = unchecked((int)(0x8031005A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_STARTUP_OPTIONS"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_STARTUP_OPTIONS _HRESULT_TYPEDEF_(0x8031005BL)")]
    public const int FVE_E_INVALID_STARTUP_OPTIONS = unchecked((int)(0x8031005B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_RECOVERY_PASSWORD_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_RECOVERY_PASSWORD_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8031005CL)")]
    public const int FVE_E_POLICY_RECOVERY_PASSWORD_NOT_ALLOWED = unchecked((int)(0x8031005C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_RECOVERY_PASSWORD_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_RECOVERY_PASSWORD_REQUIRED _HRESULT_TYPEDEF_(0x8031005DL)")]
    public const int FVE_E_POLICY_RECOVERY_PASSWORD_REQUIRED = unchecked((int)(0x8031005D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_RECOVERY_KEY_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_RECOVERY_KEY_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8031005EL)")]
    public const int FVE_E_POLICY_RECOVERY_KEY_NOT_ALLOWED = unchecked((int)(0x8031005E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_RECOVERY_KEY_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_RECOVERY_KEY_REQUIRED _HRESULT_TYPEDEF_(0x8031005FL)")]
    public const int FVE_E_POLICY_RECOVERY_KEY_REQUIRED = unchecked((int)(0x8031005F));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_STARTUP_PIN_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_PIN_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310060L)")]
    public const int FVE_E_POLICY_STARTUP_PIN_NOT_ALLOWED = unchecked((int)(0x80310060));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_STARTUP_PIN_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_PIN_REQUIRED _HRESULT_TYPEDEF_(0x80310061L)")]
    public const int FVE_E_POLICY_STARTUP_PIN_REQUIRED = unchecked((int)(0x80310061));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_STARTUP_KEY_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_KEY_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310062L)")]
    public const int FVE_E_POLICY_STARTUP_KEY_NOT_ALLOWED = unchecked((int)(0x80310062));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_STARTUP_KEY_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310063L)")]
    public const int FVE_E_POLICY_STARTUP_KEY_REQUIRED = unchecked((int)(0x80310063));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_STARTUP_PIN_KEY_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_PIN_KEY_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310064L)")]
    public const int FVE_E_POLICY_STARTUP_PIN_KEY_NOT_ALLOWED = unchecked((int)(0x80310064));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_STARTUP_PIN_KEY_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_PIN_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310065L)")]
    public const int FVE_E_POLICY_STARTUP_PIN_KEY_REQUIRED = unchecked((int)(0x80310065));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_STARTUP_TPM_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_TPM_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310066L)")]
    public const int FVE_E_POLICY_STARTUP_TPM_NOT_ALLOWED = unchecked((int)(0x80310066));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_STARTUP_TPM_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_TPM_REQUIRED _HRESULT_TYPEDEF_(0x80310067L)")]
    public const int FVE_E_POLICY_STARTUP_TPM_REQUIRED = unchecked((int)(0x80310067));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_INVALID_PIN_LENGTH"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_INVALID_PIN_LENGTH _HRESULT_TYPEDEF_(0x80310068L)")]
    public const int FVE_E_POLICY_INVALID_PIN_LENGTH = unchecked((int)(0x80310068));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_KEY_PROTECTOR_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_KEY_PROTECTOR_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80310069L)")]
    public const int FVE_E_KEY_PROTECTOR_NOT_SUPPORTED = unchecked((int)(0x80310069));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_PASSPHRASE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_PASSPHRASE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8031006AL)")]
    public const int FVE_E_POLICY_PASSPHRASE_NOT_ALLOWED = unchecked((int)(0x8031006A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_PASSPHRASE_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_PASSPHRASE_REQUIRED _HRESULT_TYPEDEF_(0x8031006BL)")]
    public const int FVE_E_POLICY_PASSPHRASE_REQUIRED = unchecked((int)(0x8031006B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FIPS_PREVENTS_PASSPHRASE"]/*' />
    [NativeTypeName("#define FVE_E_FIPS_PREVENTS_PASSPHRASE _HRESULT_TYPEDEF_(0x8031006CL)")]
    public const int FVE_E_FIPS_PREVENTS_PASSPHRASE = unchecked((int)(0x8031006C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_OS_VOLUME_PASSPHRASE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_OS_VOLUME_PASSPHRASE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8031006DL)")]
    public const int FVE_E_OS_VOLUME_PASSPHRASE_NOT_ALLOWED = unchecked((int)(0x8031006D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_BITLOCKER_OID"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_BITLOCKER_OID _HRESULT_TYPEDEF_(0x8031006EL)")]
    public const int FVE_E_INVALID_BITLOCKER_OID = unchecked((int)(0x8031006E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_VOLUME_TOO_SMALL"]/*' />
    [NativeTypeName("#define FVE_E_VOLUME_TOO_SMALL _HRESULT_TYPEDEF_(0x8031006FL)")]
    public const int FVE_E_VOLUME_TOO_SMALL = unchecked((int)(0x8031006F));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DV_NOT_SUPPORTED_ON_FS"]/*' />
    [NativeTypeName("#define FVE_E_DV_NOT_SUPPORTED_ON_FS _HRESULT_TYPEDEF_(0x80310070L)")]
    public const int FVE_E_DV_NOT_SUPPORTED_ON_FS = unchecked((int)(0x80310070));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DV_NOT_ALLOWED_BY_GP"]/*' />
    [NativeTypeName("#define FVE_E_DV_NOT_ALLOWED_BY_GP _HRESULT_TYPEDEF_(0x80310071L)")]
    public const int FVE_E_DV_NOT_ALLOWED_BY_GP = unchecked((int)(0x80310071));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_USER_CERTIFICATE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_USER_CERTIFICATE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310072L)")]
    public const int FVE_E_POLICY_USER_CERTIFICATE_NOT_ALLOWED = unchecked((int)(0x80310072));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_USER_CERTIFICATE_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_USER_CERTIFICATE_REQUIRED _HRESULT_TYPEDEF_(0x80310073L)")]
    public const int FVE_E_POLICY_USER_CERTIFICATE_REQUIRED = unchecked((int)(0x80310073));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_USER_CERT_MUST_BE_HW"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_USER_CERT_MUST_BE_HW _HRESULT_TYPEDEF_(0x80310074L)")]
    public const int FVE_E_POLICY_USER_CERT_MUST_BE_HW = unchecked((int)(0x80310074));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_USER_CONFIGURE_FDV_AUTOUNLOCK_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_USER_CONFIGURE_FDV_AUTOUNLOCK_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310075L)")]
    public const int FVE_E_POLICY_USER_CONFIGURE_FDV_AUTOUNLOCK_NOT_ALLOWED = unchecked((int)(0x80310075));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_USER_CONFIGURE_RDV_AUTOUNLOCK_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_USER_CONFIGURE_RDV_AUTOUNLOCK_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310076L)")]
    public const int FVE_E_POLICY_USER_CONFIGURE_RDV_AUTOUNLOCK_NOT_ALLOWED = unchecked((int)(0x80310076));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_USER_CONFIGURE_RDV_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_USER_CONFIGURE_RDV_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310077L)")]
    public const int FVE_E_POLICY_USER_CONFIGURE_RDV_NOT_ALLOWED = unchecked((int)(0x80310077));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_USER_ENABLE_RDV_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_USER_ENABLE_RDV_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310078L)")]
    public const int FVE_E_POLICY_USER_ENABLE_RDV_NOT_ALLOWED = unchecked((int)(0x80310078));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_USER_DISABLE_RDV_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_USER_DISABLE_RDV_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310079L)")]
    public const int FVE_E_POLICY_USER_DISABLE_RDV_NOT_ALLOWED = unchecked((int)(0x80310079));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_INVALID_PASSPHRASE_LENGTH"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_INVALID_PASSPHRASE_LENGTH _HRESULT_TYPEDEF_(0x80310080L)")]
    public const int FVE_E_POLICY_INVALID_PASSPHRASE_LENGTH = unchecked((int)(0x80310080));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_PASSPHRASE_TOO_SIMPLE"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_PASSPHRASE_TOO_SIMPLE _HRESULT_TYPEDEF_(0x80310081L)")]
    public const int FVE_E_POLICY_PASSPHRASE_TOO_SIMPLE = unchecked((int)(0x80310081));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_RECOVERY_PARTITION"]/*' />
    [NativeTypeName("#define FVE_E_RECOVERY_PARTITION _HRESULT_TYPEDEF_(0x80310082L)")]
    public const int FVE_E_RECOVERY_PARTITION = unchecked((int)(0x80310082));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_CONFLICT_FDV_RK_OFF_AUK_ON"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_FDV_RK_OFF_AUK_ON _HRESULT_TYPEDEF_(0x80310083L)")]
    public const int FVE_E_POLICY_CONFLICT_FDV_RK_OFF_AUK_ON = unchecked((int)(0x80310083));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_CONFLICT_RDV_RK_OFF_AUK_ON"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_RDV_RK_OFF_AUK_ON _HRESULT_TYPEDEF_(0x80310084L)")]
    public const int FVE_E_POLICY_CONFLICT_RDV_RK_OFF_AUK_ON = unchecked((int)(0x80310084));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NON_BITLOCKER_OID"]/*' />
    [NativeTypeName("#define FVE_E_NON_BITLOCKER_OID _HRESULT_TYPEDEF_(0x80310085L)")]
    public const int FVE_E_NON_BITLOCKER_OID = unchecked((int)(0x80310085));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_PROHIBITS_SELFSIGNED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_PROHIBITS_SELFSIGNED _HRESULT_TYPEDEF_(0x80310086L)")]
    public const int FVE_E_POLICY_PROHIBITS_SELFSIGNED = unchecked((int)(0x80310086));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_CONFLICT_RO_AND_STARTUP_KEY_REQUIRED"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_RO_AND_STARTUP_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310087L)")]
    public const int FVE_E_POLICY_CONFLICT_RO_AND_STARTUP_KEY_REQUIRED = unchecked((int)(0x80310087));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_CONV_RECOVERY_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_CONV_RECOVERY_FAILED _HRESULT_TYPEDEF_(0x80310088L)")]
    public const int FVE_E_CONV_RECOVERY_FAILED = unchecked((int)(0x80310088));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_VIRTUALIZED_SPACE_TOO_BIG"]/*' />
    [NativeTypeName("#define FVE_E_VIRTUALIZED_SPACE_TOO_BIG _HRESULT_TYPEDEF_(0x80310089L)")]
    public const int FVE_E_VIRTUALIZED_SPACE_TOO_BIG = unchecked((int)(0x80310089));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_CONFLICT_OSV_RP_OFF_ADB_ON"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_OSV_RP_OFF_ADB_ON _HRESULT_TYPEDEF_(0x80310090L)")]
    public const int FVE_E_POLICY_CONFLICT_OSV_RP_OFF_ADB_ON = unchecked((int)(0x80310090));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_CONFLICT_FDV_RP_OFF_ADB_ON"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_FDV_RP_OFF_ADB_ON _HRESULT_TYPEDEF_(0x80310091L)")]
    public const int FVE_E_POLICY_CONFLICT_FDV_RP_OFF_ADB_ON = unchecked((int)(0x80310091));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_CONFLICT_RDV_RP_OFF_ADB_ON"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_RDV_RP_OFF_ADB_ON _HRESULT_TYPEDEF_(0x80310092L)")]
    public const int FVE_E_POLICY_CONFLICT_RDV_RP_OFF_ADB_ON = unchecked((int)(0x80310092));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NON_BITLOCKER_KU"]/*' />
    [NativeTypeName("#define FVE_E_NON_BITLOCKER_KU _HRESULT_TYPEDEF_(0x80310093L)")]
    public const int FVE_E_NON_BITLOCKER_KU = unchecked((int)(0x80310093));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PRIVATEKEY_AUTH_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_PRIVATEKEY_AUTH_FAILED _HRESULT_TYPEDEF_(0x80310094L)")]
    public const int FVE_E_PRIVATEKEY_AUTH_FAILED = unchecked((int)(0x80310094));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_REMOVAL_OF_DRA_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_REMOVAL_OF_DRA_FAILED _HRESULT_TYPEDEF_(0x80310095L)")]
    public const int FVE_E_REMOVAL_OF_DRA_FAILED = unchecked((int)(0x80310095));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_OPERATION_NOT_SUPPORTED_ON_VISTA_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_OPERATION_NOT_SUPPORTED_ON_VISTA_VOLUME _HRESULT_TYPEDEF_(0x80310096L)")]
    public const int FVE_E_OPERATION_NOT_SUPPORTED_ON_VISTA_VOLUME = unchecked((int)(0x80310096));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_CANT_LOCK_AUTOUNLOCK_ENABLED_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_CANT_LOCK_AUTOUNLOCK_ENABLED_VOLUME _HRESULT_TYPEDEF_(0x80310097L)")]
    public const int FVE_E_CANT_LOCK_AUTOUNLOCK_ENABLED_VOLUME = unchecked((int)(0x80310097));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FIPS_HASH_KDF_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_FIPS_HASH_KDF_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310098L)")]
    public const int FVE_E_FIPS_HASH_KDF_NOT_ALLOWED = unchecked((int)(0x80310098));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_ENH_PIN_INVALID"]/*' />
    [NativeTypeName("#define FVE_E_ENH_PIN_INVALID _HRESULT_TYPEDEF_(0x80310099L)")]
    public const int FVE_E_ENH_PIN_INVALID = unchecked((int)(0x80310099));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_PIN_CHARS"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_PIN_CHARS _HRESULT_TYPEDEF_(0x8031009AL)")]
    public const int FVE_E_INVALID_PIN_CHARS = unchecked((int)(0x8031009A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_DATUM_TYPE"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_DATUM_TYPE _HRESULT_TYPEDEF_(0x8031009BL)")]
    public const int FVE_E_INVALID_DATUM_TYPE = unchecked((int)(0x8031009B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EFI_ONLY"]/*' />
    [NativeTypeName("#define FVE_E_EFI_ONLY _HRESULT_TYPEDEF_(0x8031009CL)")]
    public const int FVE_E_EFI_ONLY = unchecked((int)(0x8031009C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_MULTIPLE_NKP_CERTS"]/*' />
    [NativeTypeName("#define FVE_E_MULTIPLE_NKP_CERTS _HRESULT_TYPEDEF_(0x8031009DL)")]
    public const int FVE_E_MULTIPLE_NKP_CERTS = unchecked((int)(0x8031009D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_REMOVAL_OF_NKP_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_REMOVAL_OF_NKP_FAILED _HRESULT_TYPEDEF_(0x8031009EL)")]
    public const int FVE_E_REMOVAL_OF_NKP_FAILED = unchecked((int)(0x8031009E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_NKP_CERT"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_NKP_CERT _HRESULT_TYPEDEF_(0x8031009FL)")]
    public const int FVE_E_INVALID_NKP_CERT = unchecked((int)(0x8031009F));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_EXISTING_PIN"]/*' />
    [NativeTypeName("#define FVE_E_NO_EXISTING_PIN _HRESULT_TYPEDEF_(0x803100A0L)")]
    public const int FVE_E_NO_EXISTING_PIN = unchecked((int)(0x803100A0));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PROTECTOR_CHANGE_PIN_MISMATCH"]/*' />
    [NativeTypeName("#define FVE_E_PROTECTOR_CHANGE_PIN_MISMATCH _HRESULT_TYPEDEF_(0x803100A1L)")]
    public const int FVE_E_PROTECTOR_CHANGE_PIN_MISMATCH = unchecked((int)(0x803100A1));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PIN_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_PIN_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED _HRESULT_TYPEDEF_(0x803100A2L)")]
    public const int FVE_E_PIN_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED = unchecked((int)(0x803100A2));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PROTECTOR_CHANGE_MAX_PIN_CHANGE_ATTEMPTS_REACHED"]/*' />
    [NativeTypeName("#define FVE_E_PROTECTOR_CHANGE_MAX_PIN_CHANGE_ATTEMPTS_REACHED _HRESULT_TYPEDEF_(0x803100A3L)")]
    public const int FVE_E_PROTECTOR_CHANGE_MAX_PIN_CHANGE_ATTEMPTS_REACHED = unchecked((int)(0x803100A3));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_PASSPHRASE_REQUIRES_ASCII"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_PASSPHRASE_REQUIRES_ASCII _HRESULT_TYPEDEF_(0x803100A4L)")]
    public const int FVE_E_POLICY_PASSPHRASE_REQUIRES_ASCII = unchecked((int)(0x803100A4));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE"]/*' />
    [NativeTypeName("#define FVE_E_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE _HRESULT_TYPEDEF_(0x803100A5L)")]
    public const int FVE_E_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)(0x803100A5));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_WIPE_NOT_ALLOWED_ON_TP_STORAGE"]/*' />
    [NativeTypeName("#define FVE_E_WIPE_NOT_ALLOWED_ON_TP_STORAGE _HRESULT_TYPEDEF_(0x803100A6L)")]
    public const int FVE_E_WIPE_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)(0x803100A6));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_KEY_LENGTH_NOT_SUPPORTED_BY_EDRIVE"]/*' />
    [NativeTypeName("#define FVE_E_KEY_LENGTH_NOT_SUPPORTED_BY_EDRIVE _HRESULT_TYPEDEF_(0x803100A7L)")]
    public const int FVE_E_KEY_LENGTH_NOT_SUPPORTED_BY_EDRIVE = unchecked((int)(0x803100A7));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_EXISTING_PASSPHRASE"]/*' />
    [NativeTypeName("#define FVE_E_NO_EXISTING_PASSPHRASE _HRESULT_TYPEDEF_(0x803100A8L)")]
    public const int FVE_E_NO_EXISTING_PASSPHRASE = unchecked((int)(0x803100A8));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PROTECTOR_CHANGE_PASSPHRASE_MISMATCH"]/*' />
    [NativeTypeName("#define FVE_E_PROTECTOR_CHANGE_PASSPHRASE_MISMATCH _HRESULT_TYPEDEF_(0x803100A9L)")]
    public const int FVE_E_PROTECTOR_CHANGE_PASSPHRASE_MISMATCH = unchecked((int)(0x803100A9));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PASSPHRASE_TOO_LONG"]/*' />
    [NativeTypeName("#define FVE_E_PASSPHRASE_TOO_LONG _HRESULT_TYPEDEF_(0x803100AAL)")]
    public const int FVE_E_PASSPHRASE_TOO_LONG = unchecked((int)(0x803100AA));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_PASSPHRASE_WITH_TPM"]/*' />
    [NativeTypeName("#define FVE_E_NO_PASSPHRASE_WITH_TPM _HRESULT_TYPEDEF_(0x803100ABL)")]
    public const int FVE_E_NO_PASSPHRASE_WITH_TPM = unchecked((int)(0x803100AB));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_TPM_WITH_PASSPHRASE"]/*' />
    [NativeTypeName("#define FVE_E_NO_TPM_WITH_PASSPHRASE _HRESULT_TYPEDEF_(0x803100ACL)")]
    public const int FVE_E_NO_TPM_WITH_PASSPHRASE = unchecked((int)(0x803100AC));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ALLOWED_ON_CSV_STACK"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_ON_CSV_STACK _HRESULT_TYPEDEF_(0x803100ADL)")]
    public const int FVE_E_NOT_ALLOWED_ON_CSV_STACK = unchecked((int)(0x803100AD));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ALLOWED_ON_CLUSTER"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_ON_CLUSTER _HRESULT_TYPEDEF_(0x803100AEL)")]
    public const int FVE_E_NOT_ALLOWED_ON_CLUSTER = unchecked((int)(0x803100AE));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EDRIVE_NO_FAILOVER_TO_SW"]/*' />
    [NativeTypeName("#define FVE_E_EDRIVE_NO_FAILOVER_TO_SW _HRESULT_TYPEDEF_(0x803100AFL)")]
    public const int FVE_E_EDRIVE_NO_FAILOVER_TO_SW = unchecked((int)(0x803100AF));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EDRIVE_BAND_IN_USE"]/*' />
    [NativeTypeName("#define FVE_E_EDRIVE_BAND_IN_USE _HRESULT_TYPEDEF_(0x803100B0L)")]
    public const int FVE_E_EDRIVE_BAND_IN_USE = unchecked((int)(0x803100B0));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EDRIVE_DISALLOWED_BY_GP"]/*' />
    [NativeTypeName("#define FVE_E_EDRIVE_DISALLOWED_BY_GP _HRESULT_TYPEDEF_(0x803100B1L)")]
    public const int FVE_E_EDRIVE_DISALLOWED_BY_GP = unchecked((int)(0x803100B1));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EDRIVE_INCOMPATIBLE_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_EDRIVE_INCOMPATIBLE_VOLUME _HRESULT_TYPEDEF_(0x803100B2L)")]
    public const int FVE_E_EDRIVE_INCOMPATIBLE_VOLUME = unchecked((int)(0x803100B2));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING _HRESULT_TYPEDEF_(0x803100B3L)")]
    public const int FVE_E_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING = unchecked((int)(0x803100B3));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EDRIVE_DV_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_EDRIVE_DV_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100B4L)")]
    public const int FVE_E_EDRIVE_DV_NOT_SUPPORTED = unchecked((int)(0x803100B4));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_PREBOOT_KEYBOARD_DETECTED"]/*' />
    [NativeTypeName("#define FVE_E_NO_PREBOOT_KEYBOARD_DETECTED _HRESULT_TYPEDEF_(0x803100B5L)")]
    public const int FVE_E_NO_PREBOOT_KEYBOARD_DETECTED = unchecked((int)(0x803100B5));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_PREBOOT_KEYBOARD_OR_WINRE_DETECTED"]/*' />
    [NativeTypeName("#define FVE_E_NO_PREBOOT_KEYBOARD_OR_WINRE_DETECTED _HRESULT_TYPEDEF_(0x803100B6L)")]
    public const int FVE_E_NO_PREBOOT_KEYBOARD_OR_WINRE_DETECTED = unchecked((int)(0x803100B6));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_REQUIRES_STARTUP_PIN_ON_TOUCH_DEVICE"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_REQUIRES_STARTUP_PIN_ON_TOUCH_DEVICE _HRESULT_TYPEDEF_(0x803100B7L)")]
    public const int FVE_E_POLICY_REQUIRES_STARTUP_PIN_ON_TOUCH_DEVICE = unchecked((int)(0x803100B7));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_REQUIRES_RECOVERY_PASSWORD_ON_TOUCH_DEVICE"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_REQUIRES_RECOVERY_PASSWORD_ON_TOUCH_DEVICE _HRESULT_TYPEDEF_(0x803100B8L)")]
    public const int FVE_E_POLICY_REQUIRES_RECOVERY_PASSWORD_ON_TOUCH_DEVICE = unchecked((int)(0x803100B8));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_WIPE_CANCEL_NOT_APPLICABLE"]/*' />
    [NativeTypeName("#define FVE_E_WIPE_CANCEL_NOT_APPLICABLE _HRESULT_TYPEDEF_(0x803100B9L)")]
    public const int FVE_E_WIPE_CANCEL_NOT_APPLICABLE = unchecked((int)(0x803100B9));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SECUREBOOT_DISABLED"]/*' />
    [NativeTypeName("#define FVE_E_SECUREBOOT_DISABLED _HRESULT_TYPEDEF_(0x803100BAL)")]
    public const int FVE_E_SECUREBOOT_DISABLED = unchecked((int)(0x803100BA));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SECUREBOOT_CONFIGURATION_INVALID"]/*' />
    [NativeTypeName("#define FVE_E_SECUREBOOT_CONFIGURATION_INVALID _HRESULT_TYPEDEF_(0x803100BBL)")]
    public const int FVE_E_SECUREBOOT_CONFIGURATION_INVALID = unchecked((int)(0x803100BB));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EDRIVE_DRY_RUN_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_EDRIVE_DRY_RUN_FAILED _HRESULT_TYPEDEF_(0x803100BCL)")]
    public const int FVE_E_EDRIVE_DRY_RUN_FAILED = unchecked((int)(0x803100BC));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SHADOW_COPY_PRESENT"]/*' />
    [NativeTypeName("#define FVE_E_SHADOW_COPY_PRESENT _HRESULT_TYPEDEF_(0x803100BDL)")]
    public const int FVE_E_SHADOW_COPY_PRESENT = unchecked((int)(0x803100BD));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_INVALID_ENHANCED_BCD_SETTINGS"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_INVALID_ENHANCED_BCD_SETTINGS _HRESULT_TYPEDEF_(0x803100BEL)")]
    public const int FVE_E_POLICY_INVALID_ENHANCED_BCD_SETTINGS = unchecked((int)(0x803100BE));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EDRIVE_INCOMPATIBLE_FIRMWARE"]/*' />
    [NativeTypeName("#define FVE_E_EDRIVE_INCOMPATIBLE_FIRMWARE _HRESULT_TYPEDEF_(0x803100BFL)")]
    public const int FVE_E_EDRIVE_INCOMPATIBLE_FIRMWARE = unchecked((int)(0x803100BF));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PROTECTOR_CHANGE_MAX_PASSPHRASE_CHANGE_ATTEMPTS_REACHED"]/*' />
    [NativeTypeName("#define FVE_E_PROTECTOR_CHANGE_MAX_PASSPHRASE_CHANGE_ATTEMPTS_REACHED _HRESULT_TYPEDEF_(0x803100C0L)")]
    public const int FVE_E_PROTECTOR_CHANGE_MAX_PASSPHRASE_CHANGE_ATTEMPTS_REACHED = unchecked((int)(0x803100C0));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PASSPHRASE_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_PASSPHRASE_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED _HRESULT_TYPEDEF_(0x803100C1L)")]
    public const int FVE_E_PASSPHRASE_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED = unchecked((int)(0x803100C1));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_LIVEID_ACCOUNT_SUSPENDED"]/*' />
    [NativeTypeName("#define FVE_E_LIVEID_ACCOUNT_SUSPENDED _HRESULT_TYPEDEF_(0x803100C2L)")]
    public const int FVE_E_LIVEID_ACCOUNT_SUSPENDED = unchecked((int)(0x803100C2));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_LIVEID_ACCOUNT_BLOCKED"]/*' />
    [NativeTypeName("#define FVE_E_LIVEID_ACCOUNT_BLOCKED _HRESULT_TYPEDEF_(0x803100C3L)")]
    public const int FVE_E_LIVEID_ACCOUNT_BLOCKED = unchecked((int)(0x803100C3));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_PROVISIONED_ON_ALL_VOLUMES"]/*' />
    [NativeTypeName("#define FVE_E_NOT_PROVISIONED_ON_ALL_VOLUMES _HRESULT_TYPEDEF_(0x803100C4L)")]
    public const int FVE_E_NOT_PROVISIONED_ON_ALL_VOLUMES = unchecked((int)(0x803100C4));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_FIXED_DATA_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_DE_FIXED_DATA_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100C5L)")]
    public const int FVE_E_DE_FIXED_DATA_NOT_SUPPORTED = unchecked((int)(0x803100C5));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_HARDWARE_NOT_COMPLIANT"]/*' />
    [NativeTypeName("#define FVE_E_DE_HARDWARE_NOT_COMPLIANT _HRESULT_TYPEDEF_(0x803100C6L)")]
    public const int FVE_E_DE_HARDWARE_NOT_COMPLIANT = unchecked((int)(0x803100C6));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_WINRE_NOT_CONFIGURED"]/*' />
    [NativeTypeName("#define FVE_E_DE_WINRE_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x803100C7L)")]
    public const int FVE_E_DE_WINRE_NOT_CONFIGURED = unchecked((int)(0x803100C7));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_PROTECTION_SUSPENDED"]/*' />
    [NativeTypeName("#define FVE_E_DE_PROTECTION_SUSPENDED _HRESULT_TYPEDEF_(0x803100C8L)")]
    public const int FVE_E_DE_PROTECTION_SUSPENDED = unchecked((int)(0x803100C8));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_OS_VOLUME_NOT_PROTECTED"]/*' />
    [NativeTypeName("#define FVE_E_DE_OS_VOLUME_NOT_PROTECTED _HRESULT_TYPEDEF_(0x803100C9L)")]
    public const int FVE_E_DE_OS_VOLUME_NOT_PROTECTED = unchecked((int)(0x803100C9));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_DEVICE_LOCKEDOUT"]/*' />
    [NativeTypeName("#define FVE_E_DE_DEVICE_LOCKEDOUT _HRESULT_TYPEDEF_(0x803100CAL)")]
    public const int FVE_E_DE_DEVICE_LOCKEDOUT = unchecked((int)(0x803100CA));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_PROTECTION_NOT_YET_ENABLED"]/*' />
    [NativeTypeName("#define FVE_E_DE_PROTECTION_NOT_YET_ENABLED _HRESULT_TYPEDEF_(0x803100CBL)")]
    public const int FVE_E_DE_PROTECTION_NOT_YET_ENABLED = unchecked((int)(0x803100CB));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_PIN_CHARS_DETAILED"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_PIN_CHARS_DETAILED _HRESULT_TYPEDEF_(0x803100CCL)")]
    public const int FVE_E_INVALID_PIN_CHARS_DETAILED = unchecked((int)(0x803100CC));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DEVICE_LOCKOUT_COUNTER_UNAVAILABLE"]/*' />
    [NativeTypeName("#define FVE_E_DEVICE_LOCKOUT_COUNTER_UNAVAILABLE _HRESULT_TYPEDEF_(0x803100CDL)")]
    public const int FVE_E_DEVICE_LOCKOUT_COUNTER_UNAVAILABLE = unchecked((int)(0x803100CD));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DEVICELOCKOUT_COUNTER_MISMATCH"]/*' />
    [NativeTypeName("#define FVE_E_DEVICELOCKOUT_COUNTER_MISMATCH _HRESULT_TYPEDEF_(0x803100CEL)")]
    public const int FVE_E_DEVICELOCKOUT_COUNTER_MISMATCH = unchecked((int)(0x803100CE));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BUFFER_TOO_LARGE"]/*' />
    [NativeTypeName("#define FVE_E_BUFFER_TOO_LARGE _HRESULT_TYPEDEF_(0x803100CFL)")]
    public const int FVE_E_BUFFER_TOO_LARGE = unchecked((int)(0x803100CF));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_SUCH_CAPABILITY_ON_TARGET"]/*' />
    [NativeTypeName("#define FVE_E_NO_SUCH_CAPABILITY_ON_TARGET _HRESULT_TYPEDEF_(0x803100D0L)")]
    public const int FVE_E_NO_SUCH_CAPABILITY_ON_TARGET = unchecked((int)(0x803100D0));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_PREVENTED_FOR_OS"]/*' />
    [NativeTypeName("#define FVE_E_DE_PREVENTED_FOR_OS _HRESULT_TYPEDEF_(0x803100D1L)")]
    public const int FVE_E_DE_PREVENTED_FOR_OS = unchecked((int)(0x803100D1));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_VOLUME_OPTED_OUT"]/*' />
    [NativeTypeName("#define FVE_E_DE_VOLUME_OPTED_OUT _HRESULT_TYPEDEF_(0x803100D2L)")]
    public const int FVE_E_DE_VOLUME_OPTED_OUT = unchecked((int)(0x803100D2));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DE_VOLUME_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_DE_VOLUME_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100D3L)")]
    public const int FVE_E_DE_VOLUME_NOT_SUPPORTED = unchecked((int)(0x803100D3));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EOW_NOT_SUPPORTED_IN_VERSION"]/*' />
    [NativeTypeName("#define FVE_E_EOW_NOT_SUPPORTED_IN_VERSION _HRESULT_TYPEDEF_(0x803100D4L)")]
    public const int FVE_E_EOW_NOT_SUPPORTED_IN_VERSION = unchecked((int)(0x803100D4));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_ADBACKUP_NOT_ENABLED"]/*' />
    [NativeTypeName("#define FVE_E_ADBACKUP_NOT_ENABLED _HRESULT_TYPEDEF_(0x803100D5L)")]
    public const int FVE_E_ADBACKUP_NOT_ENABLED = unchecked((int)(0x803100D5));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT"]/*' />
    [NativeTypeName("#define FVE_E_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT _HRESULT_TYPEDEF_(0x803100D6L)")]
    public const int FVE_E_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT = unchecked((int)(0x803100D6));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_DE_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_NOT_DE_VOLUME _HRESULT_TYPEDEF_(0x803100D7L)")]
    public const int FVE_E_NOT_DE_VOLUME = unchecked((int)(0x803100D7));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PROTECTION_CANNOT_BE_DISABLED"]/*' />
    [NativeTypeName("#define FVE_E_PROTECTION_CANNOT_BE_DISABLED _HRESULT_TYPEDEF_(0x803100D8L)")]
    public const int FVE_E_PROTECTION_CANNOT_BE_DISABLED = unchecked((int)(0x803100D8));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_OSV_KSR_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_OSV_KSR_NOT_ALLOWED _HRESULT_TYPEDEF_(0x803100D9L)")]
    public const int FVE_E_OSV_KSR_NOT_ALLOWED = unchecked((int)(0x803100D9));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_OS_DRIVE"]/*' />
    [NativeTypeName("#define FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_OS_DRIVE _HRESULT_TYPEDEF_(0x803100DAL)")]
    public const int FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_OS_DRIVE = unchecked((int)(0x803100DA));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_FIXED_DRIVE"]/*' />
    [NativeTypeName("#define FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_FIXED_DRIVE _HRESULT_TYPEDEF_(0x803100DBL)")]
    public const int FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_FIXED_DRIVE = unchecked((int)(0x803100DB));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_REMOVABLE_DRIVE"]/*' />
    [NativeTypeName("#define FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_REMOVABLE_DRIVE _HRESULT_TYPEDEF_(0x803100DCL)")]
    public const int FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_REMOVABLE_DRIVE = unchecked((int)(0x803100DC));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_KEY_ROTATION_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_KEY_ROTATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100DDL)")]
    public const int FVE_E_KEY_ROTATION_NOT_SUPPORTED = unchecked((int)(0x803100DD));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EXECUTE_REQUEST_SENT_TOO_SOON"]/*' />
    [NativeTypeName("#define FVE_E_EXECUTE_REQUEST_SENT_TOO_SOON _HRESULT_TYPEDEF_(0x803100DEL)")]
    public const int FVE_E_EXECUTE_REQUEST_SENT_TOO_SOON = unchecked((int)(0x803100DE));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_KEY_ROTATION_NOT_ENABLED"]/*' />
    [NativeTypeName("#define FVE_E_KEY_ROTATION_NOT_ENABLED _HRESULT_TYPEDEF_(0x803100DFL)")]
    public const int FVE_E_KEY_ROTATION_NOT_ENABLED = unchecked((int)(0x803100DF));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DEVICE_NOT_JOINED_AAD"]/*' />
    [NativeTypeName("#define FVE_E_DEVICE_NOT_JOINED_AAD _HRESULT_TYPEDEF_(0x803100E0L)")]
    public const int FVE_E_DEVICE_NOT_JOINED_AAD = unchecked((int)(0x803100E0));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AAD_ENDPOINT_BUSY"]/*' />
    [NativeTypeName("#define FVE_E_AAD_ENDPOINT_BUSY _HRESULT_TYPEDEF_(0x803100E1L)")]
    public const int FVE_E_AAD_ENDPOINT_BUSY = unchecked((int)(0x803100E1));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_NBP_CERT"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_NBP_CERT _HRESULT_TYPEDEF_(0x803100E2L)")]
    public const int FVE_E_INVALID_NBP_CERT = unchecked((int)(0x803100E2));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EDRIVE_BAND_ENUMERATION_FAILED"]/*' />
    [NativeTypeName("#define FVE_E_EDRIVE_BAND_ENUMERATION_FAILED _HRESULT_TYPEDEF_(0x803100E3L)")]
    public const int FVE_E_EDRIVE_BAND_ENUMERATION_FAILED = unchecked((int)(0x803100E3));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_POLICY_ON_RDV_EXCLUSION_LIST"]/*' />
    [NativeTypeName("#define FVE_E_POLICY_ON_RDV_EXCLUSION_LIST _HRESULT_TYPEDEF_(0x803100E4L)")]
    public const int FVE_E_POLICY_ON_RDV_EXCLUSION_LIST = unchecked((int)(0x803100E4));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PREDICTED_TPM_PROTECTOR_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_PREDICTED_TPM_PROTECTOR_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100E5L)")]
    public const int FVE_E_PREDICTED_TPM_PROTECTOR_NOT_SUPPORTED = unchecked((int)(0x803100E5));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SETUP_TPM_CALLBACK_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_SETUP_TPM_CALLBACK_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100E6L)")]
    public const int FVE_E_SETUP_TPM_CALLBACK_NOT_SUPPORTED = unchecked((int)(0x803100E6));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_CONTEXT_SETUP_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_TPM_CONTEXT_SETUP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100E7L)")]
    public const int FVE_E_TPM_CONTEXT_SETUP_NOT_SUPPORTED = unchecked((int)(0x803100E7));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_UPDATE_INVALID_CONFIG"]/*' />
    [NativeTypeName("#define FVE_E_UPDATE_INVALID_CONFIG _HRESULT_TYPEDEF_(0x803100E8L)")]
    public const int FVE_E_UPDATE_INVALID_CONFIG = unchecked((int)(0x803100E8));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AAD_SERVER_FAIL_RETRY_AFTER_AAD"]/*' />
    [NativeTypeName("#define FVE_E_AAD_SERVER_FAIL_RETRY_AFTER_AAD _HRESULT_TYPEDEF_(0x803100E9L)")]
    public const int FVE_E_AAD_SERVER_FAIL_RETRY_AFTER_AAD = unchecked((int)(0x803100E9));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AAD_SERVER_FAIL_BACKOFF_AAD"]/*' />
    [NativeTypeName("#define FVE_E_AAD_SERVER_FAIL_BACKOFF_AAD _HRESULT_TYPEDEF_(0x803100EAL)")]
    public const int FVE_E_AAD_SERVER_FAIL_BACKOFF_AAD = unchecked((int)(0x803100EA));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DATASET_FULL"]/*' />
    [NativeTypeName("#define FVE_E_DATASET_FULL _HRESULT_TYPEDEF_(0x803100EBL)")]
    public const int FVE_E_DATASET_FULL = unchecked((int)(0x803100EB));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_METADATA_FULL"]/*' />
    [NativeTypeName("#define FVE_E_METADATA_FULL _HRESULT_TYPEDEF_(0x803100ECL)")]
    public const int FVE_E_METADATA_FULL = unchecked((int)(0x803100EC));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DISCOVERY_VOLUME_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define FVE_E_DISCOVERY_VOLUME_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100EDL)")]
    public const int FVE_E_DISCOVERY_VOLUME_NOT_SUPPORTED = unchecked((int)(0x803100ED));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EXCEED_LIMIT_RP"]/*' />
    [NativeTypeName("#define FVE_E_EXCEED_LIMIT_RP _HRESULT_TYPEDEF_(0x803100EEL)")]
    public const int FVE_E_EXCEED_LIMIT_RP = unchecked((int)(0x803100EE));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_BACKUP_ACCOUNT"]/*' />
    [NativeTypeName("#define FVE_E_NO_BACKUP_ACCOUNT _HRESULT_TYPEDEF_(0x803100EFL)")]
    public const int FVE_E_NO_BACKUP_ACCOUNT = unchecked((int)(0x803100EF));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SUSPEND_PROTECTION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_SUSPEND_PROTECTION_NOT_ALLOWED _HRESULT_TYPEDEF_(0x803100F0L)")]
    public const int FVE_E_SUSPEND_PROTECTION_NOT_ALLOWED = unchecked((int)(0x803100F0));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_CANNOT_PREDICT_PCR7"]/*' />
    [NativeTypeName("#define FVE_E_CANNOT_PREDICT_PCR7 _HRESULT_TYPEDEF_(0x803100F1L)")]
    public const int FVE_E_CANNOT_PREDICT_PCR7 = unchecked((int)(0x803100F1));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_ENTRY_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define FVE_E_ENTRY_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803100F2L)")]
    public const int FVE_E_ENTRY_ALREADY_EXISTS = unchecked((int)(0x803100F2));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_ENTRY_NOT_FOUND"]/*' />
    [NativeTypeName("#define FVE_E_ENTRY_NOT_FOUND _HRESULT_TYPEDEF_(0x803100F3L)")]
    public const int FVE_E_ENTRY_NOT_FOUND = unchecked((int)(0x803100F3));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DATUM_PARTIALLY_INVALID"]/*' />
    [NativeTypeName("#define FVE_E_DATUM_PARTIALLY_INVALID _HRESULT_TYPEDEF_(0x803100F4L)")]
    public const int FVE_E_DATUM_PARTIALLY_INVALID = unchecked((int)(0x803100F4));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DATASET_TPM_DATUMS_INCONSISTENT"]/*' />
    [NativeTypeName("#define FVE_E_DATASET_TPM_DATUMS_INCONSISTENT _HRESULT_TYPEDEF_(0x803100F5L)")]
    public const int FVE_E_DATASET_TPM_DATUMS_INCONSISTENT = unchecked((int)(0x803100F5));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SECURE_BOOT_BINDINGS_OUT_OF_SYNC"]/*' />
    [NativeTypeName("#define FVE_E_SECURE_BOOT_BINDINGS_OUT_OF_SYNC _HRESULT_TYPEDEF_(0x803100F6L)")]
    public const int FVE_E_SECURE_BOOT_BINDINGS_OUT_OF_SYNC = unchecked((int)(0x803100F6));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_SECURE_BOOT_BINDING_DATA_OUT_OF_SYNC"]/*' />
    [NativeTypeName("#define FVE_E_SECURE_BOOT_BINDING_DATA_OUT_OF_SYNC _HRESULT_TYPEDEF_(0x803100F7L)")]
    public const int FVE_E_SECURE_BOOT_BINDING_DATA_OUT_OF_SYNC = unchecked((int)(0x803100F7));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_ORPHANED_TPM_BINDING_DATUM"]/*' />
    [NativeTypeName("#define FVE_E_ORPHANED_TPM_BINDING_DATUM _HRESULT_TYPEDEF_(0x803100F8L)")]
    public const int FVE_E_ORPHANED_TPM_BINDING_DATUM = unchecked((int)(0x803100F8));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BAD_TPM_DATUM_ASSOCIATION"]/*' />
    [NativeTypeName("#define FVE_E_BAD_TPM_DATUM_ASSOCIATION _HRESULT_TYPEDEF_(0x803100F9L)")]
    public const int FVE_E_BAD_TPM_DATUM_ASSOCIATION = unchecked((int)(0x803100F9));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FINAL_TPM_PCR_VALUES_MATCH"]/*' />
    [NativeTypeName("#define FVE_E_FINAL_TPM_PCR_VALUES_MATCH _HRESULT_TYPEDEF_(0x803100FAL)")]
    public const int FVE_E_FINAL_TPM_PCR_VALUES_MATCH = unchecked((int)(0x803100FA));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_MATCHING_PCRS_TPM_FAILURE"]/*' />
    [NativeTypeName("#define FVE_E_MATCHING_PCRS_TPM_FAILURE _HRESULT_TYPEDEF_(0x803100FBL)")]
    public const int FVE_E_MATCHING_PCRS_TPM_FAILURE = unchecked((int)(0x803100FB));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BACKUP_CACHE_NOT_ALLOCATED"]/*' />
    [NativeTypeName("#define FVE_E_BACKUP_CACHE_NOT_ALLOCATED _HRESULT_TYPEDEF_(0x803100FCL)")]
    public const int FVE_E_BACKUP_CACHE_NOT_ALLOCATED = unchecked((int)(0x803100FC));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_MSA_BACKUP_CACHE_NOT_ALLOCATED"]/*' />
    [NativeTypeName("#define FVE_E_MSA_BACKUP_CACHE_NOT_ALLOCATED _HRESULT_TYPEDEF_(0x803100FDL)")]
    public const int FVE_E_MSA_BACKUP_CACHE_NOT_ALLOCATED = unchecked((int)(0x803100FD));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AD_BACKUP_CACHE_NOT_ALLOCATED"]/*' />
    [NativeTypeName("#define FVE_E_AD_BACKUP_CACHE_NOT_ALLOCATED _HRESULT_TYPEDEF_(0x803100FEL)")]
    public const int FVE_E_AD_BACKUP_CACHE_NOT_ALLOCATED = unchecked((int)(0x803100FE));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_GENERAL_TPM_FAILURE"]/*' />
    [NativeTypeName("#define FVE_E_GENERAL_TPM_FAILURE _HRESULT_TYPEDEF_(0x803100FFL)")]
    public const int FVE_E_GENERAL_TPM_FAILURE = unchecked((int)(0x803100FF));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_NONEXISTENT"]/*' />
    [NativeTypeName("#define FVE_E_TPM_NONEXISTENT _HRESULT_TYPEDEF_(0x80310100L)")]
    public const int FVE_E_TPM_NONEXISTENT = unchecked((int)(0x80310100));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_PCR_BOOT_LOCK_BOUNDARY"]/*' />
    [NativeTypeName("#define FVE_E_NO_PCR_BOOT_LOCK_BOUNDARY _HRESULT_TYPEDEF_(0xC0310101L)")]
    public const int FVE_E_NO_PCR_BOOT_LOCK_BOUNDARY = unchecked((int)(0xC0310101));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_PCR_BOOT_LOCK_BOUNDARY"]/*' />
    [NativeTypeName("#define FVE_E_PCR_BOOT_LOCK_BOUNDARY _HRESULT_TYPEDEF_(0xC0310102L)")]
    public const int FVE_E_PCR_BOOT_LOCK_BOUNDARY = unchecked((int)(0xC0310102));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FW_UPDATE_TPM_BINDINGS_NOT_REFRESHED"]/*' />
    [NativeTypeName("#define FVE_E_FW_UPDATE_TPM_BINDINGS_NOT_REFRESHED _HRESULT_TYPEDEF_(0xC0310103L)")]
    public const int FVE_E_FW_UPDATE_TPM_BINDINGS_NOT_REFRESHED = unchecked((int)(0xC0310103));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_EXCEED_MAX_LIMIT_RP_IN_MEID"]/*' />
    [NativeTypeName("#define FVE_E_EXCEED_MAX_LIMIT_RP_IN_MEID _HRESULT_TYPEDEF_(0xC0310104L)")]
    public const int FVE_E_EXCEED_MAX_LIMIT_RP_IN_MEID = unchecked((int)(0xC0310104));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_INVALID_TPM_BINDING_CONFIGURATION"]/*' />
    [NativeTypeName("#define FVE_E_INVALID_TPM_BINDING_CONFIGURATION _HRESULT_TYPEDEF_(0xC0310105L)")]
    public const int FVE_E_INVALID_TPM_BINDING_CONFIGURATION = unchecked((int)(0xC0310105));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TOO_MANY_TPM_BINDINGS"]/*' />
    [NativeTypeName("#define FVE_E_TOO_MANY_TPM_BINDINGS _HRESULT_TYPEDEF_(0xC0310106L)")]
    public const int FVE_E_TOO_MANY_TPM_BINDINGS = unchecked((int)(0xC0310106));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_BINDING_ASSOCIATION_FAILURE"]/*' />
    [NativeTypeName("#define FVE_E_TPM_BINDING_ASSOCIATION_FAILURE _HRESULT_TYPEDEF_(0xC0310107L)")]
    public const int FVE_E_TPM_BINDING_ASSOCIATION_FAILURE = unchecked((int)(0xC0310107));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_ORPHANED_PCR_DIGEST_DATUM"]/*' />
    [NativeTypeName("#define FVE_E_ORPHANED_PCR_DIGEST_DATUM _HRESULT_TYPEDEF_(0xC0310108L)")]
    public const int FVE_E_ORPHANED_PCR_DIGEST_DATUM = unchecked((int)(0xC0310108));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_HW_ACCELERATED_ENCRYPTION_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define FVE_E_HW_ACCELERATED_ENCRYPTION_NOT_ALLOWED _HRESULT_TYPEDEF_(0xC0310109L)")]
    public const int FVE_E_HW_ACCELERATED_ENCRYPTION_NOT_ALLOWED = unchecked((int)(0xC0310109));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_MATCHING_TPM_BINDINGS"]/*' />
    [NativeTypeName("#define FVE_E_NO_MATCHING_TPM_BINDINGS _HRESULT_TYPEDEF_(0xC031010AL)")]
    public const int FVE_E_NO_MATCHING_TPM_BINDINGS = unchecked((int)(0xC031010A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPMPV2_USED_FAILURE"]/*' />
    [NativeTypeName("#define FVE_E_TPMPV2_USED_FAILURE _HRESULT_TYPEDEF_(0xC031010BL)")]
    public const int FVE_E_TPMPV2_USED_FAILURE = unchecked((int)(0xC031010B));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NO_TPM_BINDINGS"]/*' />
    [NativeTypeName("#define FVE_E_NO_TPM_BINDINGS _HRESULT_TYPEDEF_(0xC031010CL)")]
    public const int FVE_E_NO_TPM_BINDINGS = unchecked((int)(0xC031010C));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_BOOT_CRIT_DEVICE_UNEXPECTED_BEHAVIOR"]/*' />
    [NativeTypeName("#define FVE_E_BOOT_CRIT_DEVICE_UNEXPECTED_BEHAVIOR _HRESULT_TYPEDEF_(0xC031010DL)")]
    public const int FVE_E_BOOT_CRIT_DEVICE_UNEXPECTED_BEHAVIOR = unchecked((int)(0xC031010D));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FW_UPDATE_PCRS_BLOCK"]/*' />
    [NativeTypeName("#define FVE_E_FW_UPDATE_PCRS_BLOCK _HRESULT_TYPEDEF_(0xC031010EL)")]
    public const int FVE_E_FW_UPDATE_PCRS_BLOCK = unchecked((int)(0xC031010E));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FW_UPDATE_PCRS_NOT_EXCLUDED"]/*' />
    [NativeTypeName("#define FVE_E_FW_UPDATE_PCRS_NOT_EXCLUDED _HRESULT_TYPEDEF_(0xC031010FL)")]
    public const int FVE_E_FW_UPDATE_PCRS_NOT_EXCLUDED = unchecked((int)(0xC031010F));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_DEVICE_NOT_JOINED"]/*' />
    [NativeTypeName("#define FVE_E_DEVICE_NOT_JOINED _HRESULT_TYPEDEF_(0x80310110L)")]
    public const int FVE_E_DEVICE_NOT_JOINED = unchecked((int)(0x80310110));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AAD_SERVER_FAIL_RETRY_AFTER"]/*' />
    [NativeTypeName("#define FVE_E_AAD_SERVER_FAIL_RETRY_AFTER _HRESULT_TYPEDEF_(0x80310111L)")]
    public const int FVE_E_AAD_SERVER_FAIL_RETRY_AFTER = unchecked((int)(0x80310111));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_AAD_SERVER_FAIL_BACKOFF"]/*' />
    [NativeTypeName("#define FVE_E_AAD_SERVER_FAIL_BACKOFF _HRESULT_TYPEDEF_(0x80310112L)")]
    public const int FVE_E_AAD_SERVER_FAIL_BACKOFF = unchecked((int)(0x80310112));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_FAILED_TO_UNWRAP_HW_WRAPPED_KEY"]/*' />
    [NativeTypeName("#define FVE_E_FAILED_TO_UNWRAP_HW_WRAPPED_KEY _HRESULT_TYPEDEF_(0xC0310113L)")]
    public const int FVE_E_FAILED_TO_UNWRAP_HW_WRAPPED_KEY = unchecked((int)(0xC0310113));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_HARDWARE_CRYPTO_ACCELERATOR_NOT_FIPS_COMPLIANT"]/*' />
    [NativeTypeName("#define FVE_E_HARDWARE_CRYPTO_ACCELERATOR_NOT_FIPS_COMPLIANT _HRESULT_TYPEDEF_(0xC0310114L)")]
    public const int FVE_E_HARDWARE_CRYPTO_ACCELERATOR_NOT_FIPS_COMPLIANT = unchecked((int)(0xC0310114));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_HARDWARE_CRYPTO_KEY_MANAGER_NOT_FIPS_COMPLIANT"]/*' />
    [NativeTypeName("#define FVE_E_HARDWARE_CRYPTO_KEY_MANAGER_NOT_FIPS_COMPLIANT _HRESULT_TYPEDEF_(0xC0310115L)")]
    public const int FVE_E_HARDWARE_CRYPTO_KEY_MANAGER_NOT_FIPS_COMPLIANT = unchecked((int)(0xC0310115));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_NOT_ALLOWED_ON_EPHEMERAL_VOLUME"]/*' />
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_ON_EPHEMERAL_VOLUME _HRESULT_TYPEDEF_(0xC0310116L)")]
    public const int FVE_E_NOT_ALLOWED_ON_EPHEMERAL_VOLUME = unchecked((int)(0xC0310116));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_UNTRUSTED_OFFLOAD_STORAGE"]/*' />
    [NativeTypeName("#define FVE_E_UNTRUSTED_OFFLOAD_STORAGE _HRESULT_TYPEDEF_(0xC0310117L)")]
    public const int FVE_E_UNTRUSTED_OFFLOAD_STORAGE = unchecked((int)(0xC0310117));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_TPM_PCRS_DO_NOT_MATCH_LOG"]/*' />
    [NativeTypeName("#define FVE_E_TPM_PCRS_DO_NOT_MATCH_LOG _HRESULT_TYPEDEF_(0xC0310118L)")]
    public const int FVE_E_TPM_PCRS_DO_NOT_MATCH_LOG = unchecked((int)(0xC0310118));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_MISSING_PROTECTORS"]/*' />
    [NativeTypeName("#define FVE_E_MISSING_PROTECTORS _HRESULT_TYPEDEF_(0xC0310119L)")]
    public const int FVE_E_MISSING_PROTECTORS = unchecked((int)(0xC0310119));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_METHOD_MISMATCH"]/*' />
    [NativeTypeName("#define FVE_E_METHOD_MISMATCH _HRESULT_TYPEDEF_(0xC031011AL)")]
    public const int FVE_E_METHOD_MISMATCH = unchecked((int)(0xC031011A));

    /// <include file='FVE.xml' path='doc/member[@name="FVE.FVE_E_WIM_TRUST_DISABLED_BY_POLICY"]/*' />
    [NativeTypeName("#define FVE_E_WIM_TRUST_DISABLED_BY_POLICY _HRESULT_TYPEDEF_(0xC031011CL)")]
    public const int FVE_E_WIM_TRUST_DISABLED_BY_POLICY = unchecked((int)(0xC031011C));
}
