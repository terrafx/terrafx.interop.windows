// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.STORAGE_IDENTIFIER_TYPE;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [return: NativeTypeName("PVOID")]
        public static void* DeviceDsmParameterBlock([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input)
        {
            return (void*)((nuint)(Input) + Input->ParameterBlockOffset);
        }

        [return: NativeTypeName("PDEVICE_DSM_RANGE")]
        public static DEVICE_DATA_SET_RANGE* DeviceDsmDataSetRanges([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input)
        {
            return (DEVICE_DATA_SET_RANGE*)((nuint)(Input) + Input->DataSetRangesOffset);
        }

        public static void DeviceDsmInitializeInput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input, [NativeTypeName("DWORD")] uint InputLength, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Parameters, [NativeTypeName("DWORD")] uint ParameterBlockLength)
        {
            uint Bytes = 28;

            Unsafe.InitBlockUnaligned((Input), 0, (InputLength));
            Input->Size = unchecked(Bytes);
            Input->Action = Definition->Action;
            Input->Flags = Flags;
            if (ParameterBlockLength == 0)
            {
                goto Cleanup;
            }

            unchecked(Bytes) = unchecked(((Bytes) + ((Definition->ParameterBlockAlignment) - 1)) / (Definition->ParameterBlockAlignment) * (Definition->ParameterBlockAlignment));
            Input->ParameterBlockOffset = unchecked(Bytes);
            Input->ParameterBlockLength = ParameterBlockLength;
            if (Parameters == null)
            {
                goto Cleanup;
            }

            Unsafe.CopyBlockUnaligned((DeviceDsmParameterBlock(Input)), (Parameters), (Input->ParameterBlockLength));
            Cleanup:
            return;
        }

        [return: NativeTypeName("BOOLEAN")]
        public static byte DeviceDsmValidateInput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input, [NativeTypeName("DWORD")] uint InputLength)
        {
            uint Max = 0;
            uint Min = 0;
            byte Valid = 0;

            if (Definition->Action != Input->Action)
            {
                goto Cleanup;
            }

            if (Definition->ParameterBlockLength != 0)
            {
                Min = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES)));
                Max = InputLength;
                if (Input->ParameterBlockOffset < Min || Input->ParameterBlockOffset > Max || (Input->ParameterBlockOffset % Definition->ParameterBlockAlignment) != 0)
                {
                    goto Cleanup;
                }

                Min = Definition->ParameterBlockLength;
                Max = InputLength - Input->ParameterBlockOffset;
                if (Input->ParameterBlockLength < Min || Input->ParameterBlockLength > Max)
                {
                    goto Cleanup;
                }
            }

            if ((Input->Flags & 0x00000001) == 0)
            {
                Min = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES)));
                Max = InputLength;
                if (Input->DataSetRangesOffset < Min || Input->DataSetRangesOffset > Max || (Input->DataSetRangesOffset % 8) != 0)
                {
                    goto Cleanup;
                }

                Min = unchecked((uint)(sizeof(DEVICE_DATA_SET_RANGE)));
                Max = InputLength - Input->DataSetRangesOffset;
                if (Input->DataSetRangesLength < Min || Input->DataSetRangesLength > Max || (Input->DataSetRangesLength % Min) != 0)
                {
                    goto Cleanup;
                }

                if ((Definition->SingleRange) != 0 && Input->DataSetRangesLength != Min)
                {
                    goto Cleanup;
                }
            }
            else
            {
                if (Input->DataSetRangesOffset != 0 || Input->DataSetRangesLength != 0)
                {
                    goto Cleanup;
                }
            }

            if (Input->ParameterBlockOffset < Input->DataSetRangesOffset && Input->ParameterBlockOffset + Input->ParameterBlockLength > Input->DataSetRangesOffset)
            {
                goto Cleanup;
            }

            if (Input->DataSetRangesOffset < Input->ParameterBlockOffset && Input->DataSetRangesOffset + Input->DataSetRangesLength > Input->ParameterBlockOffset)
            {
                goto Cleanup;
            }

            Valid = 1;
            Cleanup:
            return Valid;
        }

        [SupportedOSPlatform("windows8.0")]
        [return: NativeTypeName("PVOID")]
        public static void* DeviceDsmOutputBlock([NativeTypeName("PDEVICE_DSM_OUTPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT* Output)
        {
            return (void*)((nuint)(Output) + Output->OutputBlockOffset);
        }

        [return: NativeTypeName("DWORD")]
        public static uint DeviceDsmGetOutputLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint OutputBlockLength)
        {
            uint Bytes = 0;

            if (Definition->HasOutput == 0)
            {
                goto Cleanup;
            }

            Bytes = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT)));
            if (Definition->OutputBlockLength == 0)
            {
                goto Cleanup;
            }

            if (Definition->OutputBlockLength > OutputBlockLength)
            {
                OutputBlockLength = Definition->OutputBlockLength;
            }

            Bytes = (((Bytes) + ((Definition->OutputBlockAlignment) - 1)) / (Definition->OutputBlockAlignment) * (Definition->OutputBlockAlignment));
            Bytes += OutputBlockLength;
            Cleanup:
            return Bytes;
        }

        [return: NativeTypeName("BOOLEAN")]
        public static byte DeviceDsmValidateOutputLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint OutputLength)
        {
            uint Bytes = DeviceDsmGetOutputLength(Definition, 0);

            return (byte)((OutputLength >= Bytes) ? 1 : 0);
        }

        [return: NativeTypeName("DWORD")]
        public static uint DeviceDsmGetOutputBlockLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint OutputLength)
        {
            uint Bytes = 0;

            if (Definition->OutputBlockLength == 0)
            {
                goto Cleanup;
            }

            Bytes = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT)));
            Bytes = (((Bytes) + ((Definition->OutputBlockAlignment) - 1)) / (Definition->OutputBlockAlignment) * (Definition->OutputBlockAlignment));
            Bytes = OutputLength - Bytes;
            Cleanup:
            return Bytes;
        }

        [SupportedOSPlatform("windows8.0")]
        public static void DeviceDsmInitializeOutput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_OUTPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT* Output, [NativeTypeName("DWORD")] uint OutputLength, [NativeTypeName("DWORD")] uint Flags)
        {
            uint Bytes = 36;

            Unsafe.InitBlockUnaligned((Output), 0, (OutputLength));
            Output->Size = unchecked(Bytes);
            Output->Action = Definition->Action;
            Output->Flags = Flags;
            if (Definition->OutputBlockLength != 0)
            {
                unchecked(Bytes) = unchecked(((Bytes) + ((Definition->OutputBlockAlignment) - 1)) / (Definition->OutputBlockAlignment) * (Definition->OutputBlockAlignment));
                Output->OutputBlockOffset = unchecked(Bytes);
                Output->OutputBlockLength = unchecked(OutputLength - Bytes);
            }

            return;
        }

        [SupportedOSPlatform("windows8.0")]
        [return: NativeTypeName("BOOLEAN")]
        public static byte DeviceDsmValidateOutput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_OUTPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT* Output, [NativeTypeName("DWORD")] uint OutputLength)
        {
            uint Max = 0;
            uint Min = 0;
            byte Valid = 0;

            if (Definition->Action != Output->Action)
            {
                goto Cleanup;
            }

            if (Definition->HasOutput == 0)
            {
                goto Cleanup;
            }

            if (Definition->OutputBlockLength != 0)
            {
                Min = unchecked((uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT)));
                Max = OutputLength;
                if (Output->OutputBlockOffset < Min || Output->OutputBlockOffset > Max || (Output->OutputBlockOffset % Definition->OutputBlockAlignment) != 0)
                {
                    goto Cleanup;
                }

                Min = Definition->OutputBlockLength;
                Max = OutputLength - Output->OutputBlockOffset;
                if (Output->OutputBlockLength < Min || Output->OutputBlockLength > Max)
                {
                    goto Cleanup;
                }
            }
            else
            {
                if (Output->OutputBlockOffset != 0 || Output->OutputBlockLength != 0)
                {
                    goto Cleanup;
                }
            }

            Valid = 1;
            Cleanup:
            return Valid;
        }

        [NativeTypeName("#define DiskClassGuid GUID_DEVINTERFACE_DISK")]
        public static ref readonly Guid DiskClassGuid => ref GUID_DEVINTERFACE_DISK;

        [NativeTypeName("#define CdRomClassGuid GUID_DEVINTERFACE_CDROM")]
        public static ref readonly Guid CdRomClassGuid => ref GUID_DEVINTERFACE_CDROM;

        [NativeTypeName("#define PartitionClassGuid GUID_DEVINTERFACE_PARTITION")]
        public static ref readonly Guid PartitionClassGuid => ref GUID_DEVINTERFACE_PARTITION;

        [NativeTypeName("#define TapeClassGuid GUID_DEVINTERFACE_TAPE")]
        public static ref readonly Guid TapeClassGuid => ref GUID_DEVINTERFACE_TAPE;

        [NativeTypeName("#define WriteOnceDiskClassGuid GUID_DEVINTERFACE_WRITEONCEDISK")]
        public static ref readonly Guid WriteOnceDiskClassGuid => ref GUID_DEVINTERFACE_WRITEONCEDISK;

        [NativeTypeName("#define VolumeClassGuid GUID_DEVINTERFACE_VOLUME")]
        public static ref readonly Guid VolumeClassGuid => ref GUID_DEVINTERFACE_VOLUME;

        [NativeTypeName("#define MediumChangerClassGuid GUID_DEVINTERFACE_MEDIUMCHANGER")]
        public static ref readonly Guid MediumChangerClassGuid => ref GUID_DEVINTERFACE_MEDIUMCHANGER;

        [NativeTypeName("#define FloppyClassGuid GUID_DEVINTERFACE_FLOPPY")]
        public static ref readonly Guid FloppyClassGuid => ref GUID_DEVINTERFACE_FLOPPY;

        [NativeTypeName("#define CdChangerClassGuid GUID_DEVINTERFACE_CDCHANGER")]
        public static ref readonly Guid CdChangerClassGuid => ref GUID_DEVINTERFACE_CDCHANGER;

        [NativeTypeName("#define StoragePortClassGuid GUID_DEVINTERFACE_STORAGEPORT")]
        public static ref readonly Guid StoragePortClassGuid => ref GUID_DEVINTERFACE_STORAGEPORT;

        [NativeTypeName("#define HiddenVolumeClassGuid GUID_DEVINTERFACE_HIDDEN_VOLUME")]
        public static ref readonly Guid HiddenVolumeClassGuid => ref GUID_DEVINTERFACE_HIDDEN_VOLUME;

        [NativeTypeName("#define GUID_CLASS_COMPORT GUID_DEVINTERFACE_COMPORT")]
        public static ref readonly Guid GUID_CLASS_COMPORT => ref GUID_DEVINTERFACE_COMPORT;

        [NativeTypeName("#define GUID_SERENUM_BUS_ENUMERATOR GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR")]
        public static ref readonly Guid GUID_SERENUM_BUS_ENUMERATOR => ref GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR;

        [NativeTypeName("#define METHOD_BUFFERED 0")]
        public const int METHOD_BUFFERED = 0;

        [NativeTypeName("#define METHOD_IN_DIRECT 1")]
        public const int METHOD_IN_DIRECT = 1;

        [NativeTypeName("#define METHOD_OUT_DIRECT 2")]
        public const int METHOD_OUT_DIRECT = 2;

        [NativeTypeName("#define METHOD_NEITHER 3")]
        public const int METHOD_NEITHER = 3;

        [NativeTypeName("#define METHOD_DIRECT_TO_HARDWARE METHOD_IN_DIRECT")]
        public const int METHOD_DIRECT_TO_HARDWARE = 1;

        [NativeTypeName("#define METHOD_DIRECT_FROM_HARDWARE METHOD_OUT_DIRECT")]
        public const int METHOD_DIRECT_FROM_HARDWARE = 2;

        [NativeTypeName("#define OBSOLETE_IOCTL_STORAGE_RESET_BUS CTL_CODE(IOCTL_STORAGE_BASE, 0x0400, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int OBSOLETE_IOCTL_STORAGE_RESET_BUS = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0400) << 2) | (0));

        [NativeTypeName("#define OBSOLETE_IOCTL_STORAGE_RESET_DEVICE CTL_CODE(IOCTL_STORAGE_BASE, 0x0401, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int OBSOLETE_IOCTL_STORAGE_RESET_DEVICE = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0401) << 2) | (0));

        [NativeTypeName("#define RECOVERED_WRITES_VALID 0x00000001")]
        public const int RECOVERED_WRITES_VALID = 0x00000001;

        [NativeTypeName("#define UNRECOVERED_WRITES_VALID 0x00000002")]
        public const int UNRECOVERED_WRITES_VALID = 0x00000002;

        [NativeTypeName("#define RECOVERED_READS_VALID 0x00000004")]
        public const int RECOVERED_READS_VALID = 0x00000004;

        [NativeTypeName("#define UNRECOVERED_READS_VALID 0x00000008")]
        public const int UNRECOVERED_READS_VALID = 0x00000008;

        [NativeTypeName("#define WRITE_COMPRESSION_INFO_VALID 0x00000010")]
        public const int WRITE_COMPRESSION_INFO_VALID = 0x00000010;

        [NativeTypeName("#define READ_COMPRESSION_INFO_VALID 0x00000020")]
        public const int READ_COMPRESSION_INFO_VALID = 0x00000020;

        [NativeTypeName("#define MEDIA_ERASEABLE 0x00000001")]
        public const int MEDIA_ERASEABLE = 0x00000001;

        [NativeTypeName("#define MEDIA_WRITE_ONCE 0x00000002")]
        public const int MEDIA_WRITE_ONCE = 0x00000002;

        [NativeTypeName("#define MEDIA_READ_ONLY 0x00000004")]
        public const int MEDIA_READ_ONLY = 0x00000004;

        [NativeTypeName("#define MEDIA_READ_WRITE 0x00000008")]
        public const int MEDIA_READ_WRITE = 0x00000008;

        [NativeTypeName("#define MEDIA_WRITE_PROTECTED 0x00000100")]
        public const int MEDIA_WRITE_PROTECTED = 0x00000100;

        [NativeTypeName("#define MEDIA_CURRENTLY_MOUNTED 0x80000000")]
        public const uint MEDIA_CURRENTLY_MOUNTED = 0x80000000;

        [NativeTypeName("#define SRB_TYPE_SCSI_REQUEST_BLOCK 0")]
        public const int SRB_TYPE_SCSI_REQUEST_BLOCK = 0;

        [NativeTypeName("#define SRB_TYPE_STORAGE_REQUEST_BLOCK 1")]
        public const int SRB_TYPE_STORAGE_REQUEST_BLOCK = 1;

        [NativeTypeName("#define StorageIdTypeNAA StorageIdTypeFCPHName")]
        public const STORAGE_IDENTIFIER_TYPE StorageIdTypeNAA = StorageIdTypeFCPHName;

        [NativeTypeName("#define DeviceDsmActionFlag_NonDestructive (0x80000000)")]
        public const uint DeviceDsmActionFlag_NonDestructive = (0x80000000);

        [NativeTypeName("#define DeviceDsmAction_None (0x00000000u)")]
        public const uint DeviceDsmAction_None = (0x00000000U);

        [NativeTypeName("#define DeviceDsmAction_Trim (0x00000001u)")]
        public const uint DeviceDsmAction_Trim = (0x00000001U);

        [NativeTypeName("#define DeviceDsmAction_Notification (0x00000002u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_Notification = (0x00000002U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_OffloadRead (0x00000003u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_OffloadRead = (0x00000003U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_OffloadWrite (0x00000004u)")]
        public const uint DeviceDsmAction_OffloadWrite = (0x00000004U);

        [NativeTypeName("#define DeviceDsmAction_Allocation (0x00000005u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_Allocation = (0x00000005U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_Repair (0x00000006u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_Repair = (0x00000006U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_Scrub (0x00000007u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_Scrub = (0x00000007U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_DrtQuery (0x00000008u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_DrtQuery = (0x00000008U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_DrtClear (0x00000009u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_DrtClear = (0x00000009U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_DrtDisable (0x0000000Au | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_DrtDisable = (0x0000000AU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_TieringQuery (0x0000000Bu | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_TieringQuery = (0x0000000BU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_Map (0x0000000Cu | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_Map = (0x0000000CU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_RegenerateParity (0x0000000Du | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_RegenerateParity = (0x0000000DU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_NvCache_Change_Priority (0x0000000Eu | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_NvCache_Change_Priority = (0x0000000EU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_NvCache_Evict (0x0000000Fu | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_NvCache_Evict = (0x0000000FU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_TopologyIdQuery (0x00000010u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_TopologyIdQuery = (0x00000010U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_GetPhysicalAddresses (0x00000011u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_GetPhysicalAddresses = (0x00000011U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_ScopeRegen (0x00000012u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_ScopeRegen = (0x00000012U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_ReportZones (0x00000013u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_ReportZones = (0x00000013U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_OpenZone (0x00000014u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_OpenZone = (0x00000014U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_FinishZone (0x00000015u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_FinishZone = (0x00000015U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_CloseZone (0x00000016u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_CloseZone = (0x00000016U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_ResetWritePointer (0x00000017u)")]
        public const uint DeviceDsmAction_ResetWritePointer = (0x00000017U);

        [NativeTypeName("#define DeviceDsmAction_GetRangeErrorInfo (0x00000018u | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_GetRangeErrorInfo = (0x00000018U | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_WriteZeroes (0x00000019u)")]
        public const uint DeviceDsmAction_WriteZeroes = (0x00000019U);

        [NativeTypeName("#define DeviceDsmAction_LostQuery (0x0000001Au | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_LostQuery = (0x0000001AU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_GetFreeSpace (0x0000001Bu | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_GetFreeSpace = (0x0000001BU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_ConversionQuery (0x0000001Cu | DeviceDsmActionFlag_NonDestructive)")]
        public const uint DeviceDsmAction_ConversionQuery = (0x0000001CU | (0x80000000));

        [NativeTypeName("#define DeviceDsmAction_VdtSet (0x0000001Du)")]
        public const uint DeviceDsmAction_VdtSet = (0x0000001DU);

        [NativeTypeName("#define DEVICE_DSM_FLAG_ENTIRE_DATA_SET_RANGE 0x00000001")]
        public const int DEVICE_DSM_FLAG_ENTIRE_DATA_SET_RANGE = 0x00000001;

        [NativeTypeName("#define DEVICE_DSM_FLAG_TRIM_NOT_FS_ALLOCATED 0x80000000")]
        public const uint DEVICE_DSM_FLAG_TRIM_NOT_FS_ALLOCATED = 0x80000000;

        [NativeTypeName("#define DEVICE_DSM_FLAG_TRIM_BYPASS_RZAT 0x40000000")]
        public const int DEVICE_DSM_FLAG_TRIM_BYPASS_RZAT = 0x40000000;

        [NativeTypeName("#define DEVICE_DSM_NOTIFY_FLAG_BEGIN 0x00000001")]
        public const int DEVICE_DSM_NOTIFY_FLAG_BEGIN = 0x00000001;

        [NativeTypeName("#define DEVICE_DSM_NOTIFY_FLAG_END 0x00000002")]
        public const int DEVICE_DSM_NOTIFY_FLAG_END = 0x00000002;

        [NativeTypeName("#define DEVICE_DSM_FLAG_ALLOCATION_CONSOLIDATEABLE_ONLY 0x40000000")]
        public const int DEVICE_DSM_FLAG_ALLOCATION_CONSOLIDATEABLE_ONLY = 0x40000000;

        [NativeTypeName("#define DEVICE_DSM_PARAMETERS_V1 1")]
        public const int DEVICE_DSM_PARAMETERS_V1 = 1;

        [NativeTypeName("#define DEVICE_DATA_SET_LBP_STATE_PARAMETERS_VERSION_V1 DEVICE_DSM_PARAMETERS_V1")]
        public const int DEVICE_DATA_SET_LBP_STATE_PARAMETERS_VERSION_V1 = 1;

        [NativeTypeName("#define DEVICE_DSM_ALLOCATION_OUTPUT_V1 (sizeof(DEVICE_DSM_ALLOCATION_OUTPUT))")]
        public const uint DEVICE_DSM_ALLOCATION_OUTPUT_V1 = (32);

        [NativeTypeName("#define DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V1 DEVICE_DSM_ALLOCATION_OUTPUT_V1")]
        public const uint DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V1 = (32);

        [NativeTypeName("#define DEVICE_DSM_ALLOCATION_OUTPUT_V2 (sizeof(DEVICE_DSM_ALLOCATION_OUTPUT2))")]
        public const uint DEVICE_DSM_ALLOCATION_OUTPUT_V2 = (40);

        [NativeTypeName("#define DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V2 DEVICE_DSM_ALLOCATION_OUTPUT_V2")]
        public const uint DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V2 = (40);

        [NativeTypeName("#define DEVICE_DSM_FLAG_REPAIR_INPUT_TOPOLOGY_ID_PRESENT 0x40000000")]
        public const int DEVICE_DSM_FLAG_REPAIR_INPUT_TOPOLOGY_ID_PRESENT = 0x40000000;

        [NativeTypeName("#define DEVICE_DSM_FLAG_REPAIR_OUTPUT_PARITY_EXTENT 0x20000000")]
        public const int DEVICE_DSM_FLAG_REPAIR_OUTPUT_PARITY_EXTENT = 0x20000000;

        [NativeTypeName("#define DEVICE_DSM_FLAG_SCRUB_SKIP_IN_SYNC 0x10000000")]
        public const int DEVICE_DSM_FLAG_SCRUB_SKIP_IN_SYNC = 0x10000000;

        [NativeTypeName("#define DEVICE_DSM_FLAG_SCRUB_OUTPUT_PARITY_EXTENT 0x20000000")]
        public const int DEVICE_DSM_FLAG_SCRUB_OUTPUT_PARITY_EXTENT = 0x20000000;

        [NativeTypeName("#define DEVICE_DSM_FLAG_PHYSICAL_ADDRESSES_OMIT_TOTAL_RANGES 0x10000000")]
        public const int DEVICE_DSM_FLAG_PHYSICAL_ADDRESSES_OMIT_TOTAL_RANGES = 0x10000000;

        [NativeTypeName("#define DEVICE_DSM_PHYSICAL_ADDRESS_HAS_MEMORY_ERROR ((LONGLONG)-1)")]
        public const long DEVICE_DSM_PHYSICAL_ADDRESS_HAS_MEMORY_ERROR = ((long)(-1));

        [NativeTypeName("#define DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_V1 1")]
        public const int DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_V1 = 1;

        [NativeTypeName("#define DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_VERSION_V1 DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_V1")]
        public const int DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT_VERSION_V1 = 1;

        [NativeTypeName("#define DEVICE_STORAGE_NO_ERRORS 0x1")]
        public const int DEVICE_STORAGE_NO_ERRORS = 0x1;

        [NativeTypeName("#define DEVICE_DSM_RANGE_ERROR_OUTPUT_V1 1")]
        public const int DEVICE_DSM_RANGE_ERROR_OUTPUT_V1 = 1;

        [NativeTypeName("#define DEVICE_DSM_RANGE_ERROR_INFO_VERSION_V1 DEVICE_DSM_RANGE_ERROR_OUTPUT_V1")]
        public const int DEVICE_DSM_RANGE_ERROR_INFO_VERSION_V1 = 1;

        [NativeTypeName("#define DEVICEDUMP_STRUCTURE_VERSION_V1 1")]
        public const int DEVICEDUMP_STRUCTURE_VERSION_V1 = 1;

        [NativeTypeName("#define DEVICEDUMP_MAX_IDSTRING 32")]
        public const int DEVICEDUMP_MAX_IDSTRING = 32;

        [NativeTypeName("#define DDUMP_FLAG_DATA_READ_FROM_DEVICE 0x0001")]
        public const int DDUMP_FLAG_DATA_READ_FROM_DEVICE = 0x0001;

        [NativeTypeName("#define FW_ISSUEID_NO_ISSUE 0x00000000")]
        public const int FW_ISSUEID_NO_ISSUE = 0x00000000;

        [NativeTypeName("#define FW_ISSUEID_UNKNOWN 0xFFFFFFFF")]
        public const uint FW_ISSUEID_UNKNOWN = 0xFFFFFFFF;

        [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_SMART 0x01")]
        public const int TC_PUBLIC_DEVICEDUMP_CONTENT_SMART = 0x01;

        [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG 0x02")]
        public const int TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG = 0x02;

        [NativeTypeName("#define TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG_MAX 16")]
        public const int TC_PUBLIC_DEVICEDUMP_CONTENT_GPLOG_MAX = 16;

        [NativeTypeName("#define TC_DEVICEDUMP_SUBSECTION_DESC_LENGTH 16")]
        public const int TC_DEVICEDUMP_SUBSECTION_DESC_LENGTH = 16;

        [NativeTypeName("#define TC_PUBLIC_DATA_TYPE_ATAGP \"ATAGPLogPages\"")]
        public static ReadOnlySpan<byte> TC_PUBLIC_DATA_TYPE_ATAGP => new byte[] { 0x41, 0x54, 0x41, 0x47, 0x50, 0x4C, 0x6F, 0x67, 0x50, 0x61, 0x67, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define TC_PUBLIC_DATA_TYPE_ATASMART \"ATASMARTPages\"")]
        public static ReadOnlySpan<byte> TC_PUBLIC_DATA_TYPE_ATASMART => new byte[] { 0x41, 0x54, 0x41, 0x53, 0x4D, 0x41, 0x52, 0x54, 0x50, 0x61, 0x67, 0x65, 0x73, 0x00 };

        [NativeTypeName("#define CDB_SIZE 16")]
        public const int CDB_SIZE = 16;

        [NativeTypeName("#define TELEMETRY_COMMAND_SIZE 16")]
        public const int TELEMETRY_COMMAND_SIZE = 16;

        [NativeTypeName("#define DEVICEDUMP_CAP_PRIVATE_SECTION 0x00000001")]
        public const int DEVICEDUMP_CAP_PRIVATE_SECTION = 0x00000001;

        [NativeTypeName("#define DEVICEDUMP_CAP_RESTRICTED_SECTION 0x00000002")]
        public const int DEVICEDUMP_CAP_RESTRICTED_SECTION = 0x00000002;

        [NativeTypeName("#define READ_COPY_NUMBER_KEY 0x52434e00")]
        public const int READ_COPY_NUMBER_KEY = 0x52434e00;

        [NativeTypeName("#define READ_COPY_NUMBER_BYPASS_CACHE_FLAG 0x00000100")]
        public const int READ_COPY_NUMBER_BYPASS_CACHE_FLAG = 0x00000100;

        [NativeTypeName("#define STORATTRIBUTE_NONE 0")]
        public const int STORATTRIBUTE_NONE = 0;

        [NativeTypeName("#define STORATTRIBUTE_MANAGEMENT_STATE 1")]
        public const int STORATTRIBUTE_MANAGEMENT_STATE = 1;

        [NativeTypeName("#define SCM_MAX_SYMLINK_LEN_IN_CHARS 256")]
        public const int SCM_MAX_SYMLINK_LEN_IN_CHARS = 256;

        [NativeTypeName("#define SCM_REGION_SPA_UNKNOWN MAXDWORD64")]
        public const ulong SCM_REGION_SPA_UNKNOWN = ((ulong)(~((ulong)(0))));

        [NativeTypeName("#define SCM_PD_FIRMWARE_REVISION_LENGTH_BYTES 32")]
        public const int SCM_PD_FIRMWARE_REVISION_LENGTH_BYTES = 32;

        [NativeTypeName("#define SCM_PD_MEMORY_SIZE_UNKNOWN MAXDWORD64")]
        public const ulong SCM_PD_MEMORY_SIZE_UNKNOWN = ((ulong)(~((ulong)(0))));

        [NativeTypeName("#define SCM_PD_PROPERTY_NAME_LENGTH_IN_CHARS 128")]
        public const int SCM_PD_PROPERTY_NAME_LENGTH_IN_CHARS = 128;

        [NativeTypeName("#define SCM_PD_MAX_OPERATIONAL_STATUS 16")]
        public const int SCM_PD_MAX_OPERATIONAL_STATUS = 16;

        [NativeTypeName("#define SCM_PD_FIRMWARE_LAST_DOWNLOAD 0x1")]
        public const int SCM_PD_FIRMWARE_LAST_DOWNLOAD = 0x1;

        [NativeTypeName("#define SMART_GET_VERSION CTL_CODE(IOCTL_DISK_BASE, 0x0020, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int SMART_GET_VERSION = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0020) << 2) | (0));

        [NativeTypeName("#define SMART_SEND_DRIVE_COMMAND CTL_CODE(IOCTL_DISK_BASE, 0x0021, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int SMART_SEND_DRIVE_COMMAND = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0021) << 2) | (0));

        [NativeTypeName("#define SMART_RCV_DRIVE_DATA CTL_CODE(IOCTL_DISK_BASE, 0x0022, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int SMART_RCV_DRIVE_DATA = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0022) << 2) | (0));

        [NativeTypeName("#define OBSOLETE_DISK_GET_WRITE_CACHE_STATE CTL_CODE(IOCTL_DISK_BASE, 0x0037, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int OBSOLETE_DISK_GET_WRITE_CACHE_STATE = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0037) << 2) | (0));

        [NativeTypeName("#define PARTITION_ENTRY_UNUSED 0x00")]
        public const int PARTITION_ENTRY_UNUSED = 0x00;

        [NativeTypeName("#define PARTITION_FAT_12 0x01")]
        public const int PARTITION_FAT_12 = 0x01;

        [NativeTypeName("#define PARTITION_XENIX_1 0x02")]
        public const int PARTITION_XENIX_1 = 0x02;

        [NativeTypeName("#define PARTITION_XENIX_2 0x03")]
        public const int PARTITION_XENIX_2 = 0x03;

        [NativeTypeName("#define PARTITION_FAT_16 0x04")]
        public const int PARTITION_FAT_16 = 0x04;

        [NativeTypeName("#define PARTITION_EXTENDED 0x05")]
        public const int PARTITION_EXTENDED = 0x05;

        [NativeTypeName("#define PARTITION_HUGE 0x06")]
        public const int PARTITION_HUGE = 0x06;

        [NativeTypeName("#define PARTITION_IFS 0x07")]
        public const int PARTITION_IFS = 0x07;

        [NativeTypeName("#define PARTITION_OS2BOOTMGR 0x0A")]
        public const int PARTITION_OS2BOOTMGR = 0x0A;

        [NativeTypeName("#define PARTITION_FAT32 0x0B")]
        public const int PARTITION_FAT32 = 0x0B;

        [NativeTypeName("#define PARTITION_FAT32_XINT13 0x0C")]
        public const int PARTITION_FAT32_XINT13 = 0x0C;

        [NativeTypeName("#define PARTITION_XINT13 0x0E")]
        public const int PARTITION_XINT13 = 0x0E;

        [NativeTypeName("#define PARTITION_XINT13_EXTENDED 0x0F")]
        public const int PARTITION_XINT13_EXTENDED = 0x0F;

        [NativeTypeName("#define PARTITION_MSFT_RECOVERY 0x27")]
        public const int PARTITION_MSFT_RECOVERY = 0x27;

        [NativeTypeName("#define PARTITION_MAIN_OS 0x28")]
        public const int PARTITION_MAIN_OS = 0x28;

        [NativeTypeName("#define PARTIITON_OS_DATA 0x29")]
        public const int PARTIITON_OS_DATA = 0x29;

        [NativeTypeName("#define PARTITION_PRE_INSTALLED 0x2a")]
        public const int PARTITION_PRE_INSTALLED = 0x2a;

        [NativeTypeName("#define PARTITION_BSP 0x2b")]
        public const int PARTITION_BSP = 0x2b;

        [NativeTypeName("#define PARTITION_DPP 0x2c")]
        public const int PARTITION_DPP = 0x2c;

        [NativeTypeName("#define PARTITION_WINDOWS_SYSTEM 0x2d")]
        public const int PARTITION_WINDOWS_SYSTEM = 0x2d;

        [NativeTypeName("#define PARTITION_PREP 0x41")]
        public const int PARTITION_PREP = 0x41;

        [NativeTypeName("#define PARTITION_LDM 0x42")]
        public const int PARTITION_LDM = 0x42;

        [NativeTypeName("#define PARTITION_DM 0x54")]
        public const int PARTITION_DM = 0x54;

        [NativeTypeName("#define PARTITION_EZDRIVE 0x55")]
        public const int PARTITION_EZDRIVE = 0x55;

        [NativeTypeName("#define PARTITION_UNIX 0x63")]
        public const int PARTITION_UNIX = 0x63;

        [NativeTypeName("#define PARTITION_SPACES_DATA 0xD7")]
        public const int PARTITION_SPACES_DATA = 0xD7;

        [NativeTypeName("#define PARTITION_SPACES 0xE7")]
        public const int PARTITION_SPACES = 0xE7;

        [NativeTypeName("#define PARTITION_GPT 0xEE")]
        public const int PARTITION_GPT = 0xEE;

        [NativeTypeName("#define PARTITION_SYSTEM 0xEF")]
        public const int PARTITION_SYSTEM = 0xEF;

        [NativeTypeName("#define VALID_NTFT 0xC0")]
        public const int VALID_NTFT = 0xC0;

        [NativeTypeName("#define PARTITION_NTFT 0x80")]
        public const int PARTITION_NTFT = 0x80;

        [NativeTypeName("#define GPT_ATTRIBUTE_PLATFORM_REQUIRED (0x0000000000000001)")]
        public const int GPT_ATTRIBUTE_PLATFORM_REQUIRED = (0x0000000000000001);

        [NativeTypeName("#define GPT_ATTRIBUTE_NO_BLOCK_IO_PROTOCOL (0x0000000000000002)")]
        public const int GPT_ATTRIBUTE_NO_BLOCK_IO_PROTOCOL = (0x0000000000000002);

        [NativeTypeName("#define GPT_ATTRIBUTE_LEGACY_BIOS_BOOTABLE (0x0000000000000004)")]
        public const int GPT_ATTRIBUTE_LEGACY_BIOS_BOOTABLE = (0x0000000000000004);

        [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_NO_DRIVE_LETTER (0x8000000000000000)")]
        public const ulong GPT_BASIC_DATA_ATTRIBUTE_NO_DRIVE_LETTER = (0x8000000000000000);

        [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_HIDDEN (0x4000000000000000)")]
        public const long GPT_BASIC_DATA_ATTRIBUTE_HIDDEN = (0x4000000000000000);

        [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_SHADOW_COPY (0x2000000000000000)")]
        public const long GPT_BASIC_DATA_ATTRIBUTE_SHADOW_COPY = (0x2000000000000000);

        [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_READ_ONLY (0x1000000000000000)")]
        public const long GPT_BASIC_DATA_ATTRIBUTE_READ_ONLY = (0x1000000000000000);

        [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_OFFLINE (0x0800000000000000)")]
        public const long GPT_BASIC_DATA_ATTRIBUTE_OFFLINE = (0x0800000000000000);

        [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_DAX (0x0400000000000000)")]
        public const long GPT_BASIC_DATA_ATTRIBUTE_DAX = (0x0400000000000000);

        [NativeTypeName("#define GPT_BASIC_DATA_ATTRIBUTE_SERVICE (0x0200000000000000)")]
        public const long GPT_BASIC_DATA_ATTRIBUTE_SERVICE = (0x0200000000000000);

        [NativeTypeName("#define GPT_SPACES_ATTRIBUTE_NO_METADATA (0x8000000000000000)")]
        public const ulong GPT_SPACES_ATTRIBUTE_NO_METADATA = (0x8000000000000000);

        [NativeTypeName("#define HIST_NO_OF_BUCKETS 24")]
        public const int HIST_NO_OF_BUCKETS = 24;

        [NativeTypeName("#define HISTOGRAM_BUCKET_SIZE sizeof(HISTOGRAM_BUCKET)")]
        public const uint HISTOGRAM_BUCKET_SIZE = 8;

        [NativeTypeName("#define DISK_HISTOGRAM_SIZE sizeof(DISK_HISTOGRAM)")]
        public const uint DISK_HISTOGRAM_SIZE = 72;

        [NativeTypeName("#define DISK_LOGGING_START 0")]
        public const int DISK_LOGGING_START = 0;

        [NativeTypeName("#define DISK_LOGGING_STOP 1")]
        public const int DISK_LOGGING_STOP = 1;

        [NativeTypeName("#define DISK_LOGGING_DUMP 2")]
        public const int DISK_LOGGING_DUMP = 2;

        [NativeTypeName("#define DISK_BINNING 3")]
        public const int DISK_BINNING = 3;

        [NativeTypeName("#define CAP_ATA_ID_CMD 1")]
        public const int CAP_ATA_ID_CMD = 1;

        [NativeTypeName("#define CAP_ATAPI_ID_CMD 2")]
        public const int CAP_ATAPI_ID_CMD = 2;

        [NativeTypeName("#define CAP_SMART_CMD 4")]
        public const int CAP_SMART_CMD = 4;

        [NativeTypeName("#define ATAPI_ID_CMD 0xA1")]
        public const int ATAPI_ID_CMD = 0xA1;

        [NativeTypeName("#define ID_CMD 0xEC")]
        public const int ID_CMD = 0xEC;

        [NativeTypeName("#define SMART_CMD 0xB0")]
        public const int SMART_CMD = 0xB0;

        [NativeTypeName("#define SMART_CYL_LOW 0x4F")]
        public const int SMART_CYL_LOW = 0x4F;

        [NativeTypeName("#define SMART_CYL_HI 0xC2")]
        public const int SMART_CYL_HI = 0xC2;

        [NativeTypeName("#define SMART_NO_ERROR 0")]
        public const int SMART_NO_ERROR = 0;

        [NativeTypeName("#define SMART_IDE_ERROR 1")]
        public const int SMART_IDE_ERROR = 1;

        [NativeTypeName("#define SMART_INVALID_FLAG 2")]
        public const int SMART_INVALID_FLAG = 2;

        [NativeTypeName("#define SMART_INVALID_COMMAND 3")]
        public const int SMART_INVALID_COMMAND = 3;

        [NativeTypeName("#define SMART_INVALID_BUFFER 4")]
        public const int SMART_INVALID_BUFFER = 4;

        [NativeTypeName("#define SMART_INVALID_DRIVE 5")]
        public const int SMART_INVALID_DRIVE = 5;

        [NativeTypeName("#define SMART_INVALID_IOCTL 6")]
        public const int SMART_INVALID_IOCTL = 6;

        [NativeTypeName("#define SMART_ERROR_NO_MEM 7")]
        public const int SMART_ERROR_NO_MEM = 7;

        [NativeTypeName("#define SMART_INVALID_REGISTER 8")]
        public const int SMART_INVALID_REGISTER = 8;

        [NativeTypeName("#define SMART_NOT_SUPPORTED 9")]
        public const int SMART_NOT_SUPPORTED = 9;

        [NativeTypeName("#define SMART_NO_IDE_DEVICE 10")]
        public const int SMART_NO_IDE_DEVICE = 10;

        [NativeTypeName("#define SMART_OFFLINE_ROUTINE_OFFLINE 0")]
        public const int SMART_OFFLINE_ROUTINE_OFFLINE = 0;

        [NativeTypeName("#define SMART_SHORT_SELFTEST_OFFLINE 1")]
        public const int SMART_SHORT_SELFTEST_OFFLINE = 1;

        [NativeTypeName("#define SMART_EXTENDED_SELFTEST_OFFLINE 2")]
        public const int SMART_EXTENDED_SELFTEST_OFFLINE = 2;

        [NativeTypeName("#define SMART_ABORT_OFFLINE_SELFTEST 127")]
        public const int SMART_ABORT_OFFLINE_SELFTEST = 127;

        [NativeTypeName("#define SMART_SHORT_SELFTEST_CAPTIVE 129")]
        public const int SMART_SHORT_SELFTEST_CAPTIVE = 129;

        [NativeTypeName("#define SMART_EXTENDED_SELFTEST_CAPTIVE 130")]
        public const int SMART_EXTENDED_SELFTEST_CAPTIVE = 130;

        [NativeTypeName("#define READ_ATTRIBUTE_BUFFER_SIZE 512")]
        public const int READ_ATTRIBUTE_BUFFER_SIZE = 512;

        [NativeTypeName("#define IDENTIFY_BUFFER_SIZE 512")]
        public const int IDENTIFY_BUFFER_SIZE = 512;

        [NativeTypeName("#define READ_THRESHOLD_BUFFER_SIZE 512")]
        public const int READ_THRESHOLD_BUFFER_SIZE = 512;

        [NativeTypeName("#define SMART_LOG_SECTOR_SIZE 512")]
        public const int SMART_LOG_SECTOR_SIZE = 512;

        [NativeTypeName("#define READ_ATTRIBUTES 0xD0")]
        public const int READ_ATTRIBUTES = 0xD0;

        [NativeTypeName("#define READ_THRESHOLDS 0xD1")]
        public const int READ_THRESHOLDS = 0xD1;

        [NativeTypeName("#define ENABLE_DISABLE_AUTOSAVE 0xD2")]
        public const int ENABLE_DISABLE_AUTOSAVE = 0xD2;

        [NativeTypeName("#define SAVE_ATTRIBUTE_VALUES 0xD3")]
        public const int SAVE_ATTRIBUTE_VALUES = 0xD3;

        [NativeTypeName("#define EXECUTE_OFFLINE_DIAGS 0xD4")]
        public const int EXECUTE_OFFLINE_DIAGS = 0xD4;

        [NativeTypeName("#define SMART_READ_LOG 0xD5")]
        public const int SMART_READ_LOG = 0xD5;

        [NativeTypeName("#define SMART_WRITE_LOG 0xd6")]
        public const int SMART_WRITE_LOG = 0xd6;

        [NativeTypeName("#define ENABLE_SMART 0xD8")]
        public const int ENABLE_SMART = 0xD8;

        [NativeTypeName("#define DISABLE_SMART 0xD9")]
        public const int DISABLE_SMART = 0xD9;

        [NativeTypeName("#define RETURN_SMART_STATUS 0xDA")]
        public const int RETURN_SMART_STATUS = 0xDA;

        [NativeTypeName("#define ENABLE_DISABLE_AUTO_OFFLINE 0xDB")]
        public const int ENABLE_DISABLE_AUTO_OFFLINE = 0xDB;

        [NativeTypeName("#define DISK_ATTRIBUTE_OFFLINE 0x0000000000000001")]
        public const int DISK_ATTRIBUTE_OFFLINE = 0x0000000000000001;

        [NativeTypeName("#define DISK_ATTRIBUTE_READ_ONLY 0x0000000000000002")]
        public const int DISK_ATTRIBUTE_READ_ONLY = 0x0000000000000002;

        [NativeTypeName("#define VENDOR_ID_LENGTH 8")]
        public const int VENDOR_ID_LENGTH = 8;

        [NativeTypeName("#define REVISION_LENGTH 4")]
        public const int REVISION_LENGTH = 4;

        [NativeTypeName("#define SERIAL_NUMBER_LENGTH 32")]
        public const int SERIAL_NUMBER_LENGTH = 32;

        [NativeTypeName("#define CHANGER_BAR_CODE_SCANNER_INSTALLED 0x00000001")]
        public const int CHANGER_BAR_CODE_SCANNER_INSTALLED = 0x00000001;

        [NativeTypeName("#define CHANGER_INIT_ELEM_STAT_WITH_RANGE 0x00000002")]
        public const int CHANGER_INIT_ELEM_STAT_WITH_RANGE = 0x00000002;

        [NativeTypeName("#define CHANGER_CLOSE_IEPORT 0x00000004")]
        public const int CHANGER_CLOSE_IEPORT = 0x00000004;

        [NativeTypeName("#define CHANGER_OPEN_IEPORT 0x00000008")]
        public const int CHANGER_OPEN_IEPORT = 0x00000008;

        [NativeTypeName("#define CHANGER_STATUS_NON_VOLATILE 0x00000010")]
        public const int CHANGER_STATUS_NON_VOLATILE = 0x00000010;

        [NativeTypeName("#define CHANGER_EXCHANGE_MEDIA 0x00000020")]
        public const int CHANGER_EXCHANGE_MEDIA = 0x00000020;

        [NativeTypeName("#define CHANGER_CLEANER_SLOT 0x00000040")]
        public const int CHANGER_CLEANER_SLOT = 0x00000040;

        [NativeTypeName("#define CHANGER_LOCK_UNLOCK 0x00000080")]
        public const int CHANGER_LOCK_UNLOCK = 0x00000080;

        [NativeTypeName("#define CHANGER_CARTRIDGE_MAGAZINE 0x00000100")]
        public const int CHANGER_CARTRIDGE_MAGAZINE = 0x00000100;

        [NativeTypeName("#define CHANGER_MEDIUM_FLIP 0x00000200")]
        public const int CHANGER_MEDIUM_FLIP = 0x00000200;

        [NativeTypeName("#define CHANGER_POSITION_TO_ELEMENT 0x00000400")]
        public const int CHANGER_POSITION_TO_ELEMENT = 0x00000400;

        [NativeTypeName("#define CHANGER_REPORT_IEPORT_STATE 0x00000800")]
        public const int CHANGER_REPORT_IEPORT_STATE = 0x00000800;

        [NativeTypeName("#define CHANGER_STORAGE_DRIVE 0x00001000")]
        public const int CHANGER_STORAGE_DRIVE = 0x00001000;

        [NativeTypeName("#define CHANGER_STORAGE_IEPORT 0x00002000")]
        public const int CHANGER_STORAGE_IEPORT = 0x00002000;

        [NativeTypeName("#define CHANGER_STORAGE_SLOT 0x00004000")]
        public const int CHANGER_STORAGE_SLOT = 0x00004000;

        [NativeTypeName("#define CHANGER_STORAGE_TRANSPORT 0x00008000")]
        public const int CHANGER_STORAGE_TRANSPORT = 0x00008000;

        [NativeTypeName("#define CHANGER_DRIVE_CLEANING_REQUIRED 0x00010000")]
        public const int CHANGER_DRIVE_CLEANING_REQUIRED = 0x00010000;

        [NativeTypeName("#define CHANGER_PREDISMOUNT_EJECT_REQUIRED 0x00020000")]
        public const int CHANGER_PREDISMOUNT_EJECT_REQUIRED = 0x00020000;

        [NativeTypeName("#define CHANGER_CLEANER_ACCESS_NOT_VALID 0x00040000")]
        public const int CHANGER_CLEANER_ACCESS_NOT_VALID = 0x00040000;

        [NativeTypeName("#define CHANGER_PREMOUNT_EJECT_REQUIRED 0x00080000")]
        public const int CHANGER_PREMOUNT_EJECT_REQUIRED = 0x00080000;

        [NativeTypeName("#define CHANGER_VOLUME_IDENTIFICATION 0x00100000")]
        public const int CHANGER_VOLUME_IDENTIFICATION = 0x00100000;

        [NativeTypeName("#define CHANGER_VOLUME_SEARCH 0x00200000")]
        public const int CHANGER_VOLUME_SEARCH = 0x00200000;

        [NativeTypeName("#define CHANGER_VOLUME_ASSERT 0x00400000")]
        public const int CHANGER_VOLUME_ASSERT = 0x00400000;

        [NativeTypeName("#define CHANGER_VOLUME_REPLACE 0x00800000")]
        public const int CHANGER_VOLUME_REPLACE = 0x00800000;

        [NativeTypeName("#define CHANGER_VOLUME_UNDEFINE 0x01000000")]
        public const int CHANGER_VOLUME_UNDEFINE = 0x01000000;

        [NativeTypeName("#define CHANGER_SERIAL_NUMBER_VALID 0x04000000")]
        public const int CHANGER_SERIAL_NUMBER_VALID = 0x04000000;

        [NativeTypeName("#define CHANGER_DEVICE_REINITIALIZE_CAPABLE 0x08000000")]
        public const int CHANGER_DEVICE_REINITIALIZE_CAPABLE = 0x08000000;

        [NativeTypeName("#define CHANGER_KEYPAD_ENABLE_DISABLE 0x10000000")]
        public const int CHANGER_KEYPAD_ENABLE_DISABLE = 0x10000000;

        [NativeTypeName("#define CHANGER_DRIVE_EMPTY_ON_DOOR_ACCESS 0x20000000")]
        public const int CHANGER_DRIVE_EMPTY_ON_DOOR_ACCESS = 0x20000000;

        [NativeTypeName("#define CHANGER_RESERVED_BIT 0x80000000")]
        public const uint CHANGER_RESERVED_BIT = 0x80000000;

        [NativeTypeName("#define CHANGER_PREDISMOUNT_ALIGN_TO_SLOT 0x80000001")]
        public const uint CHANGER_PREDISMOUNT_ALIGN_TO_SLOT = 0x80000001;

        [NativeTypeName("#define CHANGER_PREDISMOUNT_ALIGN_TO_DRIVE 0x80000002")]
        public const uint CHANGER_PREDISMOUNT_ALIGN_TO_DRIVE = 0x80000002;

        [NativeTypeName("#define CHANGER_CLEANER_AUTODISMOUNT 0x80000004")]
        public const uint CHANGER_CLEANER_AUTODISMOUNT = 0x80000004;

        [NativeTypeName("#define CHANGER_TRUE_EXCHANGE_CAPABLE 0x80000008")]
        public const uint CHANGER_TRUE_EXCHANGE_CAPABLE = 0x80000008;

        [NativeTypeName("#define CHANGER_SLOTS_USE_TRAYS 0x80000010")]
        public const uint CHANGER_SLOTS_USE_TRAYS = 0x80000010;

        [NativeTypeName("#define CHANGER_RTN_MEDIA_TO_ORIGINAL_ADDR 0x80000020")]
        public const uint CHANGER_RTN_MEDIA_TO_ORIGINAL_ADDR = 0x80000020;

        [NativeTypeName("#define CHANGER_CLEANER_OPS_NOT_SUPPORTED 0x80000040")]
        public const uint CHANGER_CLEANER_OPS_NOT_SUPPORTED = 0x80000040;

        [NativeTypeName("#define CHANGER_IEPORT_USER_CONTROL_OPEN 0x80000080")]
        public const uint CHANGER_IEPORT_USER_CONTROL_OPEN = 0x80000080;

        [NativeTypeName("#define CHANGER_IEPORT_USER_CONTROL_CLOSE 0x80000100")]
        public const uint CHANGER_IEPORT_USER_CONTROL_CLOSE = 0x80000100;

        [NativeTypeName("#define CHANGER_MOVE_EXTENDS_IEPORT 0x80000200")]
        public const uint CHANGER_MOVE_EXTENDS_IEPORT = 0x80000200;

        [NativeTypeName("#define CHANGER_MOVE_RETRACTS_IEPORT 0x80000400")]
        public const uint CHANGER_MOVE_RETRACTS_IEPORT = 0x80000400;

        [NativeTypeName("#define CHANGER_TO_TRANSPORT 0x01")]
        public const int CHANGER_TO_TRANSPORT = 0x01;

        [NativeTypeName("#define CHANGER_TO_SLOT 0x02")]
        public const int CHANGER_TO_SLOT = 0x02;

        [NativeTypeName("#define CHANGER_TO_IEPORT 0x04")]
        public const int CHANGER_TO_IEPORT = 0x04;

        [NativeTypeName("#define CHANGER_TO_DRIVE 0x08")]
        public const int CHANGER_TO_DRIVE = 0x08;

        [NativeTypeName("#define LOCK_UNLOCK_IEPORT 0x01")]
        public const int LOCK_UNLOCK_IEPORT = 0x01;

        [NativeTypeName("#define LOCK_UNLOCK_DOOR 0x02")]
        public const int LOCK_UNLOCK_DOOR = 0x02;

        [NativeTypeName("#define LOCK_UNLOCK_KEYPAD 0x04")]
        public const int LOCK_UNLOCK_KEYPAD = 0x04;

        [NativeTypeName("#define LOCK_ELEMENT 0")]
        public const int LOCK_ELEMENT = 0;

        [NativeTypeName("#define UNLOCK_ELEMENT 1")]
        public const int UNLOCK_ELEMENT = 1;

        [NativeTypeName("#define EXTEND_IEPORT 2")]
        public const int EXTEND_IEPORT = 2;

        [NativeTypeName("#define RETRACT_IEPORT 3")]
        public const int RETRACT_IEPORT = 3;

        [NativeTypeName("#define ELEMENT_STATUS_FULL 0x00000001")]
        public const int ELEMENT_STATUS_FULL = 0x00000001;

        [NativeTypeName("#define ELEMENT_STATUS_IMPEXP 0x00000002")]
        public const int ELEMENT_STATUS_IMPEXP = 0x00000002;

        [NativeTypeName("#define ELEMENT_STATUS_EXCEPT 0x00000004")]
        public const int ELEMENT_STATUS_EXCEPT = 0x00000004;

        [NativeTypeName("#define ELEMENT_STATUS_ACCESS 0x00000008")]
        public const int ELEMENT_STATUS_ACCESS = 0x00000008;

        [NativeTypeName("#define ELEMENT_STATUS_EXENAB 0x00000010")]
        public const int ELEMENT_STATUS_EXENAB = 0x00000010;

        [NativeTypeName("#define ELEMENT_STATUS_INENAB 0x00000020")]
        public const int ELEMENT_STATUS_INENAB = 0x00000020;

        [NativeTypeName("#define ELEMENT_STATUS_PRODUCT_DATA 0x00000040")]
        public const int ELEMENT_STATUS_PRODUCT_DATA = 0x00000040;

        [NativeTypeName("#define ELEMENT_STATUS_LUN_VALID 0x00001000")]
        public const int ELEMENT_STATUS_LUN_VALID = 0x00001000;

        [NativeTypeName("#define ELEMENT_STATUS_ID_VALID 0x00002000")]
        public const int ELEMENT_STATUS_ID_VALID = 0x00002000;

        [NativeTypeName("#define ELEMENT_STATUS_NOT_BUS 0x00008000")]
        public const int ELEMENT_STATUS_NOT_BUS = 0x00008000;

        [NativeTypeName("#define ELEMENT_STATUS_INVERT 0x00400000")]
        public const int ELEMENT_STATUS_INVERT = 0x00400000;

        [NativeTypeName("#define ELEMENT_STATUS_SVALID 0x00800000")]
        public const int ELEMENT_STATUS_SVALID = 0x00800000;

        [NativeTypeName("#define ELEMENT_STATUS_PVOLTAG 0x10000000")]
        public const int ELEMENT_STATUS_PVOLTAG = 0x10000000;

        [NativeTypeName("#define ELEMENT_STATUS_AVOLTAG 0x20000000")]
        public const int ELEMENT_STATUS_AVOLTAG = 0x20000000;

        [NativeTypeName("#define SEARCH_ALL 0x0")]
        public const int SEARCH_ALL = 0x0;

        [NativeTypeName("#define SEARCH_PRIMARY 0x1")]
        public const int SEARCH_PRIMARY = 0x1;

        [NativeTypeName("#define SEARCH_ALTERNATE 0x2")]
        public const int SEARCH_ALTERNATE = 0x2;

        [NativeTypeName("#define SEARCH_ALL_NO_SEQ 0x4")]
        public const int SEARCH_ALL_NO_SEQ = 0x4;

        [NativeTypeName("#define SEARCH_PRI_NO_SEQ 0x5")]
        public const int SEARCH_PRI_NO_SEQ = 0x5;

        [NativeTypeName("#define SEARCH_ALT_NO_SEQ 0x6")]
        public const int SEARCH_ALT_NO_SEQ = 0x6;

        [NativeTypeName("#define ASSERT_PRIMARY 0x8")]
        public const int ASSERT_PRIMARY = 0x8;

        [NativeTypeName("#define ASSERT_ALTERNATE 0x9")]
        public const int ASSERT_ALTERNATE = 0x9;

        [NativeTypeName("#define REPLACE_PRIMARY 0xA")]
        public const int REPLACE_PRIMARY = 0xA;

        [NativeTypeName("#define REPLACE_ALTERNATE 0xB")]
        public const int REPLACE_ALTERNATE = 0xB;

        [NativeTypeName("#define UNDEFINE_PRIMARY 0xC")]
        public const int UNDEFINE_PRIMARY = 0xC;

        [NativeTypeName("#define UNDEFINE_ALTERNATE 0xD")]
        public const int UNDEFINE_ALTERNATE = 0xD;

        [NativeTypeName("#define SERIAL_LSRMST_ESCAPE ((BYTE )0x00)")]
        public const byte SERIAL_LSRMST_ESCAPE = ((byte)(0x00));

        [NativeTypeName("#define SERIAL_LSRMST_LSR_DATA ((BYTE )0x01)")]
        public const byte SERIAL_LSRMST_LSR_DATA = ((byte)(0x01));

        [NativeTypeName("#define SERIAL_LSRMST_LSR_NODATA ((BYTE )0x02)")]
        public const byte SERIAL_LSRMST_LSR_NODATA = ((byte)(0x02));

        [NativeTypeName("#define SERIAL_LSRMST_MST ((BYTE )0x03)")]
        public const byte SERIAL_LSRMST_MST = ((byte)(0x03));

        [NativeTypeName("#define SERIAL_IOC_FCR_FIFO_ENABLE ((DWORD)0x00000001)")]
        public const uint SERIAL_IOC_FCR_FIFO_ENABLE = ((uint)(0x00000001));

        [NativeTypeName("#define SERIAL_IOC_FCR_RCVR_RESET ((DWORD)0x00000002)")]
        public const uint SERIAL_IOC_FCR_RCVR_RESET = ((uint)(0x00000002));

        [NativeTypeName("#define SERIAL_IOC_FCR_XMIT_RESET ((DWORD)0x00000004)")]
        public const uint SERIAL_IOC_FCR_XMIT_RESET = ((uint)(0x00000004));

        [NativeTypeName("#define SERIAL_IOC_FCR_DMA_MODE ((DWORD)0x00000008)")]
        public const uint SERIAL_IOC_FCR_DMA_MODE = ((uint)(0x00000008));

        [NativeTypeName("#define SERIAL_IOC_FCR_RES1 ((DWORD)0x00000010)")]
        public const uint SERIAL_IOC_FCR_RES1 = ((uint)(0x00000010));

        [NativeTypeName("#define SERIAL_IOC_FCR_RES2 ((DWORD)0x00000020)")]
        public const uint SERIAL_IOC_FCR_RES2 = ((uint)(0x00000020));

        [NativeTypeName("#define SERIAL_IOC_FCR_RCVR_TRIGGER_LSB ((DWORD)0x00000040)")]
        public const uint SERIAL_IOC_FCR_RCVR_TRIGGER_LSB = ((uint)(0x00000040));

        [NativeTypeName("#define SERIAL_IOC_FCR_RCVR_TRIGGER_MSB ((DWORD)0x00000080)")]
        public const uint SERIAL_IOC_FCR_RCVR_TRIGGER_MSB = ((uint)(0x00000080));

        [NativeTypeName("#define SERIAL_IOC_MCR_DTR ((DWORD)0x00000001)")]
        public const uint SERIAL_IOC_MCR_DTR = ((uint)(0x00000001));

        [NativeTypeName("#define SERIAL_IOC_MCR_RTS ((DWORD)0x00000002)")]
        public const uint SERIAL_IOC_MCR_RTS = ((uint)(0x00000002));

        [NativeTypeName("#define SERIAL_IOC_MCR_OUT1 ((DWORD)0x00000004)")]
        public const uint SERIAL_IOC_MCR_OUT1 = ((uint)(0x00000004));

        [NativeTypeName("#define SERIAL_IOC_MCR_OUT2 ((DWORD)0x00000008)")]
        public const uint SERIAL_IOC_MCR_OUT2 = ((uint)(0x00000008));

        [NativeTypeName("#define SERIAL_IOC_MCR_LOOP ((DWORD)0x00000010)")]
        public const uint SERIAL_IOC_MCR_LOOP = ((uint)(0x00000010));

        [NativeTypeName("#define GET_VOLUME_BITMAP_FLAG_MASK_METADATA 0x00000001")]
        public const int GET_VOLUME_BITMAP_FLAG_MASK_METADATA = 0x00000001;

        [NativeTypeName("#define FLAG_USN_TRACK_MODIFIED_RANGES_ENABLE 0x00000001")]
        public const int FLAG_USN_TRACK_MODIFIED_RANGES_ENABLE = 0x00000001;

        [NativeTypeName("#define USN_PAGE_SIZE (0x1000)")]
        public const int USN_PAGE_SIZE = (0x1000);

        [NativeTypeName("#define USN_REASON_DATA_OVERWRITE (0x00000001)")]
        public const int USN_REASON_DATA_OVERWRITE = (0x00000001);

        [NativeTypeName("#define USN_REASON_DATA_EXTEND (0x00000002)")]
        public const int USN_REASON_DATA_EXTEND = (0x00000002);

        [NativeTypeName("#define USN_REASON_DATA_TRUNCATION (0x00000004)")]
        public const int USN_REASON_DATA_TRUNCATION = (0x00000004);

        [NativeTypeName("#define USN_REASON_NAMED_DATA_OVERWRITE (0x00000010)")]
        public const int USN_REASON_NAMED_DATA_OVERWRITE = (0x00000010);

        [NativeTypeName("#define USN_REASON_NAMED_DATA_EXTEND (0x00000020)")]
        public const int USN_REASON_NAMED_DATA_EXTEND = (0x00000020);

        [NativeTypeName("#define USN_REASON_NAMED_DATA_TRUNCATION (0x00000040)")]
        public const int USN_REASON_NAMED_DATA_TRUNCATION = (0x00000040);

        [NativeTypeName("#define USN_REASON_FILE_CREATE (0x00000100)")]
        public const int USN_REASON_FILE_CREATE = (0x00000100);

        [NativeTypeName("#define USN_REASON_FILE_DELETE (0x00000200)")]
        public const int USN_REASON_FILE_DELETE = (0x00000200);

        [NativeTypeName("#define USN_REASON_EA_CHANGE (0x00000400)")]
        public const int USN_REASON_EA_CHANGE = (0x00000400);

        [NativeTypeName("#define USN_REASON_SECURITY_CHANGE (0x00000800)")]
        public const int USN_REASON_SECURITY_CHANGE = (0x00000800);

        [NativeTypeName("#define USN_REASON_RENAME_OLD_NAME (0x00001000)")]
        public const int USN_REASON_RENAME_OLD_NAME = (0x00001000);

        [NativeTypeName("#define USN_REASON_RENAME_NEW_NAME (0x00002000)")]
        public const int USN_REASON_RENAME_NEW_NAME = (0x00002000);

        [NativeTypeName("#define USN_REASON_INDEXABLE_CHANGE (0x00004000)")]
        public const int USN_REASON_INDEXABLE_CHANGE = (0x00004000);

        [NativeTypeName("#define USN_REASON_BASIC_INFO_CHANGE (0x00008000)")]
        public const int USN_REASON_BASIC_INFO_CHANGE = (0x00008000);

        [NativeTypeName("#define USN_REASON_HARD_LINK_CHANGE (0x00010000)")]
        public const int USN_REASON_HARD_LINK_CHANGE = (0x00010000);

        [NativeTypeName("#define USN_REASON_COMPRESSION_CHANGE (0x00020000)")]
        public const int USN_REASON_COMPRESSION_CHANGE = (0x00020000);

        [NativeTypeName("#define USN_REASON_ENCRYPTION_CHANGE (0x00040000)")]
        public const int USN_REASON_ENCRYPTION_CHANGE = (0x00040000);

        [NativeTypeName("#define USN_REASON_OBJECT_ID_CHANGE (0x00080000)")]
        public const int USN_REASON_OBJECT_ID_CHANGE = (0x00080000);

        [NativeTypeName("#define USN_REASON_REPARSE_POINT_CHANGE (0x00100000)")]
        public const int USN_REASON_REPARSE_POINT_CHANGE = (0x00100000);

        [NativeTypeName("#define USN_REASON_STREAM_CHANGE (0x00200000)")]
        public const int USN_REASON_STREAM_CHANGE = (0x00200000);

        [NativeTypeName("#define USN_REASON_TRANSACTED_CHANGE (0x00400000)")]
        public const int USN_REASON_TRANSACTED_CHANGE = (0x00400000);

        [NativeTypeName("#define USN_REASON_INTEGRITY_CHANGE (0x00800000)")]
        public const int USN_REASON_INTEGRITY_CHANGE = (0x00800000);

        [NativeTypeName("#define USN_REASON_DESIRED_STORAGE_CLASS_CHANGE (0x01000000)")]
        public const int USN_REASON_DESIRED_STORAGE_CLASS_CHANGE = (0x01000000);

        [NativeTypeName("#define USN_REASON_CLOSE (0x80000000)")]
        public const uint USN_REASON_CLOSE = (0x80000000);

        [NativeTypeName("#define USN_DELETE_FLAG_DELETE (0x00000001)")]
        public const int USN_DELETE_FLAG_DELETE = (0x00000001);

        [NativeTypeName("#define USN_DELETE_FLAG_NOTIFY (0x00000002)")]
        public const int USN_DELETE_FLAG_NOTIFY = (0x00000002);

        [NativeTypeName("#define USN_DELETE_VALID_FLAGS (0x00000003)")]
        public const int USN_DELETE_VALID_FLAGS = (0x00000003);

        [NativeTypeName("#define USN_SOURCE_DATA_MANAGEMENT (0x00000001)")]
        public const int USN_SOURCE_DATA_MANAGEMENT = (0x00000001);

        [NativeTypeName("#define USN_SOURCE_AUXILIARY_DATA (0x00000002)")]
        public const int USN_SOURCE_AUXILIARY_DATA = (0x00000002);

        [NativeTypeName("#define USN_SOURCE_REPLICATION_MANAGEMENT (0x00000004)")]
        public const int USN_SOURCE_REPLICATION_MANAGEMENT = (0x00000004);

        [NativeTypeName("#define USN_SOURCE_CLIENT_REPLICATION_MANAGEMENT (0x00000008)")]
        public const int USN_SOURCE_CLIENT_REPLICATION_MANAGEMENT = (0x00000008);

        [NativeTypeName("#define USN_SOURCE_VALID_FLAGS (USN_SOURCE_DATA_MANAGEMENT |               \\\r\n                                     USN_SOURCE_AUXILIARY_DATA |                \\\r\n                                     USN_SOURCE_REPLICATION_MANAGEMENT |        \\\r\n                                     USN_SOURCE_CLIENT_REPLICATION_MANAGEMENT)")]
        public const int USN_SOURCE_VALID_FLAGS = ((0x00000001) | (0x00000002) | (0x00000004) | (0x00000008));

        [NativeTypeName("#define MARK_HANDLE_PROTECT_CLUSTERS (0x00000001)")]
        public const int MARK_HANDLE_PROTECT_CLUSTERS = (0x00000001);

        [NativeTypeName("#define MARK_HANDLE_TXF_SYSTEM_LOG (0x00000004)")]
        public const int MARK_HANDLE_TXF_SYSTEM_LOG = (0x00000004);

        [NativeTypeName("#define MARK_HANDLE_NOT_TXF_SYSTEM_LOG (0x00000008)")]
        public const int MARK_HANDLE_NOT_TXF_SYSTEM_LOG = (0x00000008);

        [NativeTypeName("#define MARK_HANDLE_REALTIME (0x00000020)")]
        public const int MARK_HANDLE_REALTIME = (0x00000020);

        [NativeTypeName("#define MARK_HANDLE_NOT_REALTIME (0x00000040)")]
        public const int MARK_HANDLE_NOT_REALTIME = (0x00000040);

        [NativeTypeName("#define MARK_HANDLE_CLOUD_SYNC (0x00000800)")]
        public const int MARK_HANDLE_CLOUD_SYNC = (0x00000800);

        [NativeTypeName("#define MARK_HANDLE_READ_COPY (0x00000080)")]
        public const int MARK_HANDLE_READ_COPY = (0x00000080);

        [NativeTypeName("#define MARK_HANDLE_NOT_READ_COPY (0x00000100)")]
        public const int MARK_HANDLE_NOT_READ_COPY = (0x00000100);

        [NativeTypeName("#define MARK_HANDLE_FILTER_METADATA (0x00000200)")]
        public const int MARK_HANDLE_FILTER_METADATA = (0x00000200);

        [NativeTypeName("#define MARK_HANDLE_RETURN_PURGE_FAILURE (0x00000400)")]
        public const int MARK_HANDLE_RETURN_PURGE_FAILURE = (0x00000400);

        [NativeTypeName("#define MARK_HANDLE_DISABLE_FILE_METADATA_OPTIMIZATION (0x00001000)")]
        public const int MARK_HANDLE_DISABLE_FILE_METADATA_OPTIMIZATION = (0x00001000);

        [NativeTypeName("#define MARK_HANDLE_ENABLE_USN_SOURCE_ON_PAGING_IO (0x00002000)")]
        public const int MARK_HANDLE_ENABLE_USN_SOURCE_ON_PAGING_IO = (0x00002000);

        [NativeTypeName("#define MARK_HANDLE_SKIP_COHERENCY_SYNC_DISALLOW_WRITES (0x00004000)")]
        public const int MARK_HANDLE_SKIP_COHERENCY_SYNC_DISALLOW_WRITES = (0x00004000);

        [NativeTypeName("#define MARK_HANDLE_ENABLE_CPU_CACHE (0x10000000)")]
        public const int MARK_HANDLE_ENABLE_CPU_CACHE = (0x10000000);

        [NativeTypeName("#define VOLUME_IS_DIRTY (0x00000001)")]
        public const int VOLUME_IS_DIRTY = (0x00000001);

        [NativeTypeName("#define VOLUME_UPGRADE_SCHEDULED (0x00000002)")]
        public const int VOLUME_UPGRADE_SCHEDULED = (0x00000002);

        [NativeTypeName("#define VOLUME_SESSION_OPEN (0x00000004)")]
        public const int VOLUME_SESSION_OPEN = (0x00000004);

        [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_NTFS 1")]
        public const int FILESYSTEM_STATISTICS_TYPE_NTFS = 1;

        [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_FAT 2")]
        public const int FILESYSTEM_STATISTICS_TYPE_FAT = 2;

        [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_EXFAT 3")]
        public const int FILESYSTEM_STATISTICS_TYPE_EXFAT = 3;

        [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_REFS 4")]
        public const int FILESYSTEM_STATISTICS_TYPE_REFS = 4;

        [NativeTypeName("#define STREAM_SET_ENCRYPTION 0x00000003")]
        public const int STREAM_SET_ENCRYPTION = 0x00000003;

        [NativeTypeName("#define STREAM_CLEAR_ENCRYPTION 0x00000004")]
        public const int STREAM_CLEAR_ENCRYPTION = 0x00000004;

        [NativeTypeName("#define MAXIMUM_ENCRYPTION_VALUE 0x00000004")]
        public const int MAXIMUM_ENCRYPTION_VALUE = 0x00000004;

        [NativeTypeName("#define ENCRYPTION_FORMAT_DEFAULT (0x01)")]
        public const int ENCRYPTION_FORMAT_DEFAULT = (0x01);

        [NativeTypeName("#define ENCRYPTED_DATA_INFO_SPARSE_FILE 1")]
        public const int ENCRYPTED_DATA_INFO_SPARSE_FILE = 1;

        [NativeTypeName("#define COPYFILE_SIS_LINK 0x0001")]
        public const int COPYFILE_SIS_LINK = 0x0001;

        [NativeTypeName("#define COPYFILE_SIS_REPLACE 0x0002")]
        public const int COPYFILE_SIS_REPLACE = 0x0002;

        [NativeTypeName("#define COPYFILE_SIS_FLAGS 0x0003")]
        public const int COPYFILE_SIS_FLAGS = 0x0003;

        [NativeTypeName("#define SET_REPAIR_ENABLED (0x00000001)")]
        public const int SET_REPAIR_ENABLED = (0x00000001);

        [NativeTypeName("#define SET_REPAIR_WARN_ABOUT_DATA_LOSS (0x00000008)")]
        public const int SET_REPAIR_WARN_ABOUT_DATA_LOSS = (0x00000008);

        [NativeTypeName("#define SET_REPAIR_DISABLED_AND_BUGCHECK_ON_CORRUPT (0x00000010)")]
        public const int SET_REPAIR_DISABLED_AND_BUGCHECK_ON_CORRUPT = (0x00000010);

        [NativeTypeName("#define SET_REPAIR_VALID_MASK (0x00000019)")]
        public const int SET_REPAIR_VALID_MASK = (0x00000019);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_SHORT_NAME_CREATION_DISABLED (0x00000001)")]
        public const int PERSISTENT_VOLUME_STATE_SHORT_NAME_CREATION_DISABLED = (0x00000001);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_VOLUME_SCRUB_DISABLED (0x00000002)")]
        public const int PERSISTENT_VOLUME_STATE_VOLUME_SCRUB_DISABLED = (0x00000002);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_GLOBAL_METADATA_NO_SEEK_PENALTY (0x00000004)")]
        public const int PERSISTENT_VOLUME_STATE_GLOBAL_METADATA_NO_SEEK_PENALTY = (0x00000004);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_LOCAL_METADATA_NO_SEEK_PENALTY (0x00000008)")]
        public const int PERSISTENT_VOLUME_STATE_LOCAL_METADATA_NO_SEEK_PENALTY = (0x00000008);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_NO_HEAT_GATHERING (0x00000010)")]
        public const int PERSISTENT_VOLUME_STATE_NO_HEAT_GATHERING = (0x00000010);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_CONTAINS_BACKING_WIM (0x00000020)")]
        public const int PERSISTENT_VOLUME_STATE_CONTAINS_BACKING_WIM = (0x00000020);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_BACKED_BY_WIM (0x00000040)")]
        public const int PERSISTENT_VOLUME_STATE_BACKED_BY_WIM = (0x00000040);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_NO_WRITE_AUTO_TIERING (0x00000080)")]
        public const int PERSISTENT_VOLUME_STATE_NO_WRITE_AUTO_TIERING = (0x00000080);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_TXF_DISABLED (0x00000100)")]
        public const int PERSISTENT_VOLUME_STATE_TXF_DISABLED = (0x00000100);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_REALLOCATE_ALL_DATA_WRITES (0x00000200)")]
        public const int PERSISTENT_VOLUME_STATE_REALLOCATE_ALL_DATA_WRITES = (0x00000200);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_CHKDSK_RAN_ONCE (0x00000400)")]
        public const int PERSISTENT_VOLUME_STATE_CHKDSK_RAN_ONCE = (0x00000400);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_MODIFIED_BY_CHKDSK (0x00000800)")]
        public const int PERSISTENT_VOLUME_STATE_MODIFIED_BY_CHKDSK = (0x00000800);

        [NativeTypeName("#define PERSISTENT_VOLUME_STATE_DAX_FORMATTED (0x00001000)")]
        public const int PERSISTENT_VOLUME_STATE_DAX_FORMATTED = (0x00001000);

        [NativeTypeName("#define OPLOCK_LEVEL_CACHE_READ (0x00000001)")]
        public const int OPLOCK_LEVEL_CACHE_READ = (0x00000001);

        [NativeTypeName("#define OPLOCK_LEVEL_CACHE_HANDLE (0x00000002)")]
        public const int OPLOCK_LEVEL_CACHE_HANDLE = (0x00000002);

        [NativeTypeName("#define OPLOCK_LEVEL_CACHE_WRITE (0x00000004)")]
        public const int OPLOCK_LEVEL_CACHE_WRITE = (0x00000004);

        [NativeTypeName("#define REQUEST_OPLOCK_INPUT_FLAG_REQUEST (0x00000001)")]
        public const int REQUEST_OPLOCK_INPUT_FLAG_REQUEST = (0x00000001);

        [NativeTypeName("#define REQUEST_OPLOCK_INPUT_FLAG_ACK (0x00000002)")]
        public const int REQUEST_OPLOCK_INPUT_FLAG_ACK = (0x00000002);

        [NativeTypeName("#define REQUEST_OPLOCK_INPUT_FLAG_COMPLETE_ACK_ON_CLOSE (0x00000004)")]
        public const int REQUEST_OPLOCK_INPUT_FLAG_COMPLETE_ACK_ON_CLOSE = (0x00000004);

        [NativeTypeName("#define REQUEST_OPLOCK_CURRENT_VERSION 1")]
        public const int REQUEST_OPLOCK_CURRENT_VERSION = 1;

        [NativeTypeName("#define REQUEST_OPLOCK_OUTPUT_FLAG_ACK_REQUIRED (0x00000001)")]
        public const int REQUEST_OPLOCK_OUTPUT_FLAG_ACK_REQUIRED = (0x00000001);

        [NativeTypeName("#define REQUEST_OPLOCK_OUTPUT_FLAG_MODES_PROVIDED (0x00000002)")]
        public const int REQUEST_OPLOCK_OUTPUT_FLAG_MODES_PROVIDED = (0x00000002);

        [NativeTypeName("#define QUERY_DEPENDENT_VOLUME_REQUEST_FLAG_HOST_VOLUMES 0x1")]
        public const int QUERY_DEPENDENT_VOLUME_REQUEST_FLAG_HOST_VOLUMES = 0x1;

        [NativeTypeName("#define QUERY_DEPENDENT_VOLUME_REQUEST_FLAG_GUEST_VOLUMES 0x2")]
        public const int QUERY_DEPENDENT_VOLUME_REQUEST_FLAG_GUEST_VOLUMES = 0x2;

        [NativeTypeName("#define SD_GLOBAL_CHANGE_TYPE_MACHINE_SID 1")]
        public const int SD_GLOBAL_CHANGE_TYPE_MACHINE_SID = 1;

        [NativeTypeName("#define SD_GLOBAL_CHANGE_TYPE_QUERY_STATS (1 << 16)")]
        public const int SD_GLOBAL_CHANGE_TYPE_QUERY_STATS = (1 << 16);

        [NativeTypeName("#define SD_GLOBAL_CHANGE_TYPE_ENUM_SDS (2 << 16)")]
        public const int SD_GLOBAL_CHANGE_TYPE_ENUM_SDS = (2 << 16);

        [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_PAGE_FILE 0x00000001")]
        public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_PAGE_FILE = 0x00000001;

        [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_DENY_DEFRAG_SET 0x00000002")]
        public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_DENY_DEFRAG_SET = 0x00000002;

        [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_FS_SYSTEM_FILE 0x00000004")]
        public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_FS_SYSTEM_FILE = 0x00000004;

        [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_TXF_SYSTEM_FILE 0x00000008")]
        public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_FLAG_TXF_SYSTEM_FILE = 0x00000008;

        [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_MASK 0xff000000")]
        public const uint LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_MASK = 0xff000000;

        [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_DATA 0x01000000")]
        public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_DATA = 0x01000000;

        [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_INDEX 0x02000000")]
        public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_INDEX = 0x02000000;

        [NativeTypeName("#define LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_SYSTEM 0x03000000")]
        public const int LOOKUP_STREAM_FROM_CLUSTER_ENTRY_ATTRIBUTE_SYSTEM = 0x03000000;

        [NativeTypeName("#define CSV_MGMTLOCK_CHECK_VOLUME_REDIRECTED 0x00000001")]
        public const int CSV_MGMTLOCK_CHECK_VOLUME_REDIRECTED = 0x00000001;

        [NativeTypeName("#define CSV_NAMESPACE_INFO_V1 (sizeof(CSV_NAMESPACE_INFO))")]
        public const uint CSV_NAMESPACE_INFO_V1 = (24);

        [NativeTypeName("#define CSV_INVALID_DEVICE_NUMBER 0xFFFFFFFF")]
        public const uint CSV_INVALID_DEVICE_NUMBER = 0xFFFFFFFF;

        [NativeTypeName("#define CSV_QUERY_MDS_PATH_V2_VERSION_1 1")]
        public const int CSV_QUERY_MDS_PATH_V2_VERSION_1 = 1;

        [NativeTypeName("#define CSV_QUERY_MDS_PATH_FLAG_STORAGE_ON_THIS_NODE_IS_CONNECTED 0x1")]
        public const int CSV_QUERY_MDS_PATH_FLAG_STORAGE_ON_THIS_NODE_IS_CONNECTED = 0x1;

        [NativeTypeName("#define CSV_QUERY_MDS_PATH_FLAG_CSV_DIRECT_IO_ENABLED 0x2")]
        public const int CSV_QUERY_MDS_PATH_FLAG_CSV_DIRECT_IO_ENABLED = 0x2;

        [NativeTypeName("#define CSV_QUERY_MDS_PATH_FLAG_SMB_BYPASS_CSV_ENABLED 0x4")]
        public const int CSV_QUERY_MDS_PATH_FLAG_SMB_BYPASS_CSV_ENABLED = 0x4;

        [NativeTypeName("#define QUERY_FILE_LAYOUT_RESTART (0x00000001)")]
        public const int QUERY_FILE_LAYOUT_RESTART = (0x00000001);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_NAMES (0x00000002)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_NAMES = (0x00000002);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAMS (0x00000004)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAMS = (0x00000004);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_EXTENTS (0x00000008)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_EXTENTS = (0x00000008);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_EXTRA_INFO (0x00000010)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_EXTRA_INFO = (0x00000010);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAMS_WITH_NO_CLUSTERS_ALLOCATED (0x00000020)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAMS_WITH_NO_CLUSTERS_ALLOCATED = (0x00000020);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_FULL_PATH_IN_NAMES (0x00000040)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_FULL_PATH_IN_NAMES = (0x00000040);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION (0x00000080)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION = (0x00000080);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_DSC_ATTRIBUTE (0x00000100)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_DSC_ATTRIBUTE = (0x00000100);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_TXF_ATTRIBUTE (0x00000200)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_TXF_ATTRIBUTE = (0x00000200);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_EFS_ATTRIBUTE (0x00000400)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_EFS_ATTRIBUTE = (0x00000400);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_ONLY_FILES_WITH_SPECIFIC_ATTRIBUTES (0x00000800)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_ONLY_FILES_WITH_SPECIFIC_ATTRIBUTES = (0x00000800);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_FILES_WITH_DSC_ATTRIBUTE (0x00001000)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_FILES_WITH_DSC_ATTRIBUTE = (0x00001000);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_DATA_ATTRIBUTE (0x00002000)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_DATA_ATTRIBUTE = (0x00002000);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_REPARSE_ATTRIBUTE (0x00004000)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_REPARSE_ATTRIBUTE = (0x00004000);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_EA_ATTRIBUTE (0x00008000)")]
        public const int QUERY_FILE_LAYOUT_INCLUDE_STREAM_INFORMATION_FOR_EA_ATTRIBUTE = (0x00008000);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_SINGLE_INSTANCED (0x00000001)")]
        public const int QUERY_FILE_LAYOUT_SINGLE_INSTANCED = (0x00000001);

        [NativeTypeName("#define STREAM_LAYOUT_ENTRY_IMMOVABLE (0x00000001)")]
        public const int STREAM_LAYOUT_ENTRY_IMMOVABLE = (0x00000001);

        [NativeTypeName("#define STREAM_LAYOUT_ENTRY_PINNED (0x00000002)")]
        public const int STREAM_LAYOUT_ENTRY_PINNED = (0x00000002);

        [NativeTypeName("#define STREAM_LAYOUT_ENTRY_RESIDENT (0x00000004)")]
        public const int STREAM_LAYOUT_ENTRY_RESIDENT = (0x00000004);

        [NativeTypeName("#define STREAM_LAYOUT_ENTRY_NO_CLUSTERS_ALLOCATED (0x00000008)")]
        public const int STREAM_LAYOUT_ENTRY_NO_CLUSTERS_ALLOCATED = (0x00000008);

        [NativeTypeName("#define STREAM_LAYOUT_ENTRY_HAS_INFORMATION (0x00000010)")]
        public const int STREAM_LAYOUT_ENTRY_HAS_INFORMATION = (0x00000010);

        [NativeTypeName("#define STREAM_EXTENT_ENTRY_AS_RETRIEVAL_POINTERS (0x00000001)")]
        public const int STREAM_EXTENT_ENTRY_AS_RETRIEVAL_POINTERS = (0x00000001);

        [NativeTypeName("#define STREAM_EXTENT_ENTRY_ALL_EXTENTS (0x00000002)")]
        public const int STREAM_EXTENT_ENTRY_ALL_EXTENTS = (0x00000002);

        [NativeTypeName("#define CHECKSUM_TYPE_UNCHANGED (-1)")]
        public const int CHECKSUM_TYPE_UNCHANGED = (-1);

        [NativeTypeName("#define CHECKSUM_TYPE_NONE (0)")]
        public const int CHECKSUM_TYPE_NONE = (0);

        [NativeTypeName("#define CHECKSUM_TYPE_CRC32 (1)")]
        public const int CHECKSUM_TYPE_CRC32 = (1);

        [NativeTypeName("#define CHECKSUM_TYPE_CRC64 (2)")]
        public const int CHECKSUM_TYPE_CRC64 = (2);

        [NativeTypeName("#define CHECKSUM_TYPE_ECC (3)")]
        public const int CHECKSUM_TYPE_ECC = (3);

        [NativeTypeName("#define CHECKSUM_TYPE_FIRST_UNUSED_TYPE (4)")]
        public const int CHECKSUM_TYPE_FIRST_UNUSED_TYPE = (4);

        [NativeTypeName("#define OFFLOAD_READ_FLAG_ALL_ZERO_BEYOND_CURRENT_RANGE (1)")]
        public const int OFFLOAD_READ_FLAG_ALL_ZERO_BEYOND_CURRENT_RANGE = (1);

        [NativeTypeName("#define SET_PURGE_FAILURE_MODE_ENABLED 0x00000001")]
        public const int SET_PURGE_FAILURE_MODE_ENABLED = 0x00000001;

        [NativeTypeName("#define SET_PURGE_FAILURE_MODE_DISABLED 0x00000002")]
        public const int SET_PURGE_FAILURE_MODE_DISABLED = 0x00000002;

        [NativeTypeName("#define VALID_WRITE_USN_REASON_MASK (USN_REASON_DATA_OVERWRITE |        \\\r\n                                         USN_REASON_CLOSE)")]
        public const uint VALID_WRITE_USN_REASON_MASK = ((0x00000001) | (0x80000000));

        [NativeTypeName("#define QUERY_STORAGE_CLASSES_FLAGS_MEASURE_WRITE 0x80000000")]
        public const uint QUERY_STORAGE_CLASSES_FLAGS_MEASURE_WRITE = 0x80000000;

        [NativeTypeName("#define QUERY_STORAGE_CLASSES_FLAGS_MEASURE_READ 0x40000000")]
        public const int QUERY_STORAGE_CLASSES_FLAGS_MEASURE_READ = 0x40000000;

        [NativeTypeName("#define QUERY_STORAGE_CLASSES_FLAGS_NO_DEFRAG_VOLUME 0x20000000")]
        public const int QUERY_STORAGE_CLASSES_FLAGS_NO_DEFRAG_VOLUME = 0x20000000;

        [NativeTypeName("#define QUERY_FILE_LAYOUT_REPARSE_DATA_INVALID (0x0001)")]
        public const int QUERY_FILE_LAYOUT_REPARSE_DATA_INVALID = (0x0001);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_REPARSE_TAG_INVALID (0x0002)")]
        public const int QUERY_FILE_LAYOUT_REPARSE_TAG_INVALID = (0x0002);

        [NativeTypeName("#define DUPLICATE_EXTENTS_DATA_EX_SOURCE_ATOMIC 0x00000001")]
        public const int DUPLICATE_EXTENTS_DATA_EX_SOURCE_ATOMIC = 0x00000001;

        [NativeTypeName("#define DUPLICATE_EXTENTS_DATA_EX_ASYNC 0x00000002")]
        public const int DUPLICATE_EXTENTS_DATA_EX_ASYNC = 0x00000002;

        [NativeTypeName("#define ASYNC_DUPLICATE_EXTENTS_STATUS_V1 sizeof(ASYNC_DUPLICATE_EXTENTS_STATUS)")]
        public const uint ASYNC_DUPLICATE_EXTENTS_STATUS_V1 = 40;

        [NativeTypeName("#define REFS_SMR_VOLUME_INFO_OUTPUT_VERSION_V0 0")]
        public const int REFS_SMR_VOLUME_INFO_OUTPUT_VERSION_V0 = 0;

        [NativeTypeName("#define REFS_SMR_VOLUME_INFO_OUTPUT_VERSION_V1 1")]
        public const int REFS_SMR_VOLUME_INFO_OUTPUT_VERSION_V1 = 1;

        [NativeTypeName("#define REFS_SMR_VOLUME_GC_PARAMETERS_VERSION_V1 1")]
        public const int REFS_SMR_VOLUME_GC_PARAMETERS_VERSION_V1 = 1;

        [NativeTypeName("#define STREAMS_INVALID_ID (0)")]
        public const int STREAMS_INVALID_ID = (0);

        [NativeTypeName("#define STREAMS_MAX_ID (MAXWORD  )")]
        public const int STREAMS_MAX_ID = (0xffff);

        [NativeTypeName("#define STREAMS_ASSOCIATE_ID_CLEAR (0x1)")]
        public const int STREAMS_ASSOCIATE_ID_CLEAR = (0x1);

        [NativeTypeName("#define STREAMS_ASSOCIATE_ID_SET (0x2)")]
        public const int STREAMS_ASSOCIATE_ID_SET = (0x2);

        [NativeTypeName("#define DAX_ALLOC_ALIGNMENT_FLAG_MANDATORY (0x00000001)")]
        public const int DAX_ALLOC_ALIGNMENT_FLAG_MANDATORY = (0x00000001);

        [NativeTypeName("#define DAX_ALLOC_ALIGNMENT_FLAG_FALLBACK_SPECIFIED (0x00000002)")]
        public const int DAX_ALLOC_ALIGNMENT_FLAG_FALLBACK_SPECIFIED = (0x00000002);

        [NativeTypeName("#define WOF_CURRENT_VERSION (0x00000001)")]
        public const int WOF_CURRENT_VERSION = (0x00000001);

        [NativeTypeName("#define WOF_PROVIDER_WIM (0x00000001)")]
        public const int WOF_PROVIDER_WIM = (0x00000001);

        [NativeTypeName("#define WOF_PROVIDER_FILE (0x00000002)")]
        public const int WOF_PROVIDER_FILE = (0x00000002);

        [NativeTypeName("#define WOF_PROVIDER_CLOUD (0x00000003)")]
        public const int WOF_PROVIDER_CLOUD = (0x00000003);

        [NativeTypeName("#define WIM_PROVIDER_HASH_SIZE 20")]
        public const int WIM_PROVIDER_HASH_SIZE = 20;

        [NativeTypeName("#define WIM_PROVIDER_CURRENT_VERSION (0x00000001)")]
        public const int WIM_PROVIDER_CURRENT_VERSION = (0x00000001);

        [NativeTypeName("#define WIM_PROVIDER_EXTERNAL_FLAG_NOT_ACTIVE (0x00000001)")]
        public const int WIM_PROVIDER_EXTERNAL_FLAG_NOT_ACTIVE = (0x00000001);

        [NativeTypeName("#define WIM_PROVIDER_EXTERNAL_FLAG_SUSPENDED (0x00000002)")]
        public const int WIM_PROVIDER_EXTERNAL_FLAG_SUSPENDED = (0x00000002);

        [NativeTypeName("#define WIM_BOOT_OS_WIM (0x00000001)")]
        public const int WIM_BOOT_OS_WIM = (0x00000001);

        [NativeTypeName("#define WIM_BOOT_NOT_OS_WIM (0x00000000)")]
        public const int WIM_BOOT_NOT_OS_WIM = (0x00000000);

        [NativeTypeName("#define CONTAINER_VOLUME_STATE_HOSTING_CONTAINER (0x00000001)")]
        public const int CONTAINER_VOLUME_STATE_HOSTING_CONTAINER = (0x00000001);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_SCRATCH_ROOT (0x00000001)")]
        public const int CONTAINER_ROOT_INFO_FLAG_SCRATCH_ROOT = (0x00000001);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_LAYER_ROOT (0x00000002)")]
        public const int CONTAINER_ROOT_INFO_FLAG_LAYER_ROOT = (0x00000002);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_ROOT (0x00000004)")]
        public const int CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_ROOT = (0x00000004);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_TARGET_ROOT (0x00000008)")]
        public const int CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_TARGET_ROOT = (0x00000008);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_EXCEPTION_ROOT (0x00000010)")]
        public const int CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_EXCEPTION_ROOT = (0x00000010);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_BIND_ROOT (0x00000020)")]
        public const int CONTAINER_ROOT_INFO_FLAG_BIND_ROOT = (0x00000020);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_BIND_TARGET_ROOT (0x00000040)")]
        public const int CONTAINER_ROOT_INFO_FLAG_BIND_TARGET_ROOT = (0x00000040);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_BIND_EXCEPTION_ROOT (0x00000080)")]
        public const int CONTAINER_ROOT_INFO_FLAG_BIND_EXCEPTION_ROOT = (0x00000080);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_BIND_DO_NOT_MAP_NAME (0x00000100)")]
        public const int CONTAINER_ROOT_INFO_FLAG_BIND_DO_NOT_MAP_NAME = (0x00000100);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_UNION_LAYER_ROOT (0x00000200)")]
        public const int CONTAINER_ROOT_INFO_FLAG_UNION_LAYER_ROOT = (0x00000200);

        [NativeTypeName("#define CONTAINER_ROOT_INFO_VALID_FLAGS (0x000003ff)")]
        public const int CONTAINER_ROOT_INFO_VALID_FLAGS = (0x000003ff);

        [NativeTypeName("#define PROJFS_PROTOCOL_VERSION 3")]
        public const int PROJFS_PROTOCOL_VERSION = 3;

        [NativeTypeName("#define IRP_EXT_TRACK_OFFSET_HEADER_VALIDATION_VALUE 'TO'")]
        public const int IRP_EXT_TRACK_OFFSET_HEADER_VALIDATION_VALUE = 0x544F;

        [NativeTypeName("#define EFS_TRACKED_OFFSET_HEADER_FLAG 0x0001")]
        public const int EFS_TRACKED_OFFSET_HEADER_FLAG = 0x0001;

        [NativeTypeName("#define SPACES_TRACKED_OFFSET_HEADER_FLAG 0x0002")]
        public const int SPACES_TRACKED_OFFSET_HEADER_FLAG = 0x0002;
    }
}
