// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    // DEVICE_DSM_RANGE has 8-byte alignment in the Windows ABI.
    private const uint DEVICE_DSM_RANGE_ALIGNMENT = 8;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int CTL_CODE(int DeviceType, int Function, int Method, int Access) => (DeviceType << 16) | (Access << 14) | (Function << 2) | Method;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DEVICE_TYPE_FROM_CTL_CODE(uint ctrlCode) => (ctrlCode & 0xFFFF0000u) >> 16;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint METHOD_FROM_CTL_CODE(uint ctrlCode) => ctrlCode & 0x3u;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DEVICE_DSM_ROUND_UP(uint a, uint b) => unchecked(((a + (b - 1)) / b) * b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DEVICE_DSM_ROUND_DN(uint a, uint b) => (a / b) * b;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DeviceDsmNumberOfDataSetRanges([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input)
        => Input->DataSetRangesLength / (uint)sizeof(DEVICE_DATA_SET_RANGE);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DeviceDsmGetInputLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, uint ParameterBlockLength, uint NumberOfDataSetRanges)
    {
        uint Bytes = (uint)sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES);

        if (Definition->ParameterBlockLength != 0 && ParameterBlockLength != 0)
        {
            Bytes = DEVICE_DSM_ROUND_UP(Bytes, Definition->ParameterBlockAlignment);
            Bytes = unchecked(Bytes + ParameterBlockLength);
        }

        if (NumberOfDataSetRanges != 0)
        {
            Bytes = DEVICE_DSM_ROUND_UP(Bytes, DEVICE_DSM_RANGE_ALIGNMENT);
            Bytes = unchecked(Bytes + unchecked((uint)sizeof(DEVICE_DATA_SET_RANGE) * NumberOfDataSetRanges));
        }

        return Bytes;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint DeviceDsmGetNumberOfDataSetRanges([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, uint InputLength, uint ParameterBlockLength)
    {
        uint Bytes = (uint)sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES);

        if (Definition->ParameterBlockLength != 0 && ParameterBlockLength != 0)
        {
            Bytes = DEVICE_DSM_ROUND_UP(Bytes, Definition->ParameterBlockAlignment);
            Bytes = unchecked(Bytes + ParameterBlockLength);
        }

        Bytes = DEVICE_DSM_ROUND_UP(Bytes, DEVICE_DSM_RANGE_ALIGNMENT);
        Bytes = unchecked(InputLength - Bytes);

        return Bytes / (uint)sizeof(DEVICE_DATA_SET_RANGE);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte DeviceDsmAddDataSetRange([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input, uint InputLength, long Offset, ulong Length)
    {
        uint Bytes = 0;
        uint Index = 0;
        DEVICE_DATA_SET_RANGE* Ranges = null;
        byte Return = 0;

        if ((Input->Flags & 0x1u) != 0)
        {
            goto Cleanup;
        }

        if (Input->DataSetRangesLength == 0)
        {
            if (Input->ParameterBlockLength == 0)
            {
                Bytes = (uint)sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES);
            }
            else
            {
                Bytes = unchecked(Input->ParameterBlockOffset + Input->ParameterBlockLength);
            }

            Bytes = DEVICE_DSM_ROUND_UP(Bytes, DEVICE_DSM_RANGE_ALIGNMENT);
        }
        else
        {
            Bytes = unchecked(Input->DataSetRangesOffset + Input->DataSetRangesLength);
        }

        if (unchecked(InputLength - Bytes) < (uint)sizeof(DEVICE_DATA_SET_RANGE))
        {
            goto Cleanup;
        }

        if (Input->DataSetRangesOffset == 0)
        {
            Input->DataSetRangesOffset = Bytes;
        }

        Ranges = DeviceDsmDataSetRanges(Input);
        Index = DeviceDsmNumberOfDataSetRanges(Input);
        Ranges[Index].StartingOffset = Offset;
        Ranges[Index].LengthInBytes = Length;
        Input->DataSetRangesLength = unchecked(Input->DataSetRangesLength + (uint)sizeof(DEVICE_DATA_SET_RANGE));
        Return = 1;

    Cleanup:
        return Return;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("BOOLEAN")]
    public static byte IsDsmActionNonDestructive(uint Action) => (byte)(((Action & 0x80000000u) != 0) ? 1 : 0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsContainerPartition(uint PartitionType)
        => (PartitionType == (uint)PARTITION.PARTITION_EXTENDED) || (PartitionType == (uint)PARTITION.PARTITION_XINT13_EXTENDED);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsFTPartition(uint PartitionType)
    {
        uint PartitionTypeWithoutFlags = PartitionType & ~0xC0u;

        return ((PartitionType & (uint)PARTITION.PARTITION_NTFT) != 0)
            && ((PartitionTypeWithoutFlags == (uint)PARTITION.PARTITION_HUGE)
                || (PartitionTypeWithoutFlags == (uint)PARTITION.PARTITION_IFS)
                || (PartitionTypeWithoutFlags == (uint)PARTITION.PARTITION_FAT32)
                || (PartitionTypeWithoutFlags == (uint)PARTITION.PARTITION_FAT32_XINT13));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsRecognizedPartition(uint PartitionType)
        => (PartitionType == (uint)PARTITION.PARTITION_BSP)
        || (PartitionType == (uint)PARTITION.PARTITION_DPP)
        || (PartitionType == (uint)PARTITION.PARTITION_FAT_12)
        || (PartitionType == (uint)PARTITION.PARTITION_FAT_16)
        || (PartitionType == (uint)PARTITION.PARTITION_FAT32)
        || (PartitionType == (uint)PARTITION.PARTITION_FAT32_XINT13)
        || (PartitionType == (uint)PARTITION.PARTITION_HUGE)
        || (PartitionType == (uint)PARTITION.PARTITION_IFS)
        || (PartitionType == (uint)PARTITION.PARTITION_MAIN_OS)
        || (PartitionType == (uint)PARTITION.PARTITION_MSFT_RECOVERY)
        || (PartitionType == (uint)PARTIITON_OS_DATA)
        || (PartitionType == (uint)PARTITION.PARTITION_PRE_INSTALLED)
        || (PartitionType == (uint)PARTITION.PARTITION_SYSTEM)
        || (PartitionType == (uint)PARTITION.PARTITION_WINDOWS_SYSTEM)
        || (PartitionType == (uint)PARTITION.PARTITION_XINT13);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DISK_PARTITION_INFO* DiskGeometryGetPartition([NativeTypeName("PDISK_GEOMETRY_EX")] DISK_GEOMETRY_EX* Geometry)
        => (DISK_PARTITION_INFO*)&Geometry->Data;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static DISK_DETECTION_INFO* DiskGeometryGetDetect([NativeTypeName("PDISK_GEOMETRY_EX")] DISK_GEOMETRY_EX* Geometry)
    {
        DISK_PARTITION_INFO* Partition = DiskGeometryGetPartition(Geometry);
        return (DISK_DETECTION_INFO*)((byte*)Partition + Partition->SizeOfPartitionInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [SupportedOSPlatform("windows6.2")]
    public static void* GET_REPAIR_TOPOLOGY_ID([NativeTypeName("PDEVICE_DATA_SET_REPAIR_PARAMETERS")] DEVICE_DATA_SET_REPAIR_PARAMETERS* R)
    {
        uint Bytes = (uint)((byte*)&R->RepairCopies - (byte*)R);
        Bytes = unchecked(Bytes + (uint)sizeof(uint) * R->NumberOfRepairCopies);
        Bytes = unchecked((Bytes + 7) & ~7u);
        return (byte*)R + Bytes;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [SupportedOSPlatform("windows6.2")]
    [return: NativeTypeName("BYTE")]
    public static byte MAKE_ZERO_TOKEN([NativeTypeName("PSTORAGE_OFFLOAD_TOKEN")] STORAGE_OFFLOAD_TOKEN* T)
    {
        T->TokenType[0] = 0xFF;
        T->TokenType[1] = 0xFF;
        T->TokenType[2] = 0x00;
        T->TokenType[3] = 0x01;
        T->TokenIdLength[0] = 0x01;
        return T->TokenIdLength[1] = 0xF8;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [SupportedOSPlatform("windows6.2")]
    public static bool IS_ZERO_TOKEN([NativeTypeName("PSTORAGE_OFFLOAD_TOKEN")] STORAGE_OFFLOAD_TOKEN* T)
        => (T->TokenType[0] == 0xFF)
        && (T->TokenType[1] == 0xFF)
        && (T->TokenType[2] == 0x00)
        && (T->TokenType[3] == 0x01)
        && (T->TokenIdLength[0] == 0x01)
        && (T->TokenIdLength[1] == 0xF8);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsKeyReadCopyNumber(uint key)
        => (key & 0xFFFFFE00u) == (uint)READ.READ_COPY_NUMBER_KEY;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint IsKeyReadCopyNumberBypassCache(uint key)
        => key & (uint)READ.READ_COPY_NUMBER_BYPASS_CACHE_FLAG;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint SetReadCopyNumberBypassCacheToKey(ref uint key)
    {
        key |= (uint)READ.READ_COPY_NUMBER_BYPASS_CACHE_FLAG;
        return key;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint ReadCopyNumberToKey(byte copyNumber)
        => (uint)READ.READ_COPY_NUMBER_KEY | (byte)copyNumber;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte ReadCopyNumberFromKey(uint key)
        => (byte)(key & 0xFFu);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int SCMBUS_FUNCTION(int function)
        => unchecked(IOCTL.IOCTL_SCMBUS_DEVICE_FUNCTION_BASE + function);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int SCM_LOGICAL_DEVICE_FUNCTION(int function)
        => unchecked(IOCTL.IOCTL_SCM_LOGICAL_DEVICE_FUNCTION_BASE + function);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int SCM_PHYSICAL_DEVICE_FUNCTION(int function)
        => unchecked(IOCTL.IOCTL_SCM_PHYSICAL_DEVICE_FUNCTION_BASE + function);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool SupportsDeviceSharing(STORAGE_BUS_TYPE BusType)
        => (BusType == STORAGE_BUS_TYPE.BusTypeScsi)
        || (BusType == STORAGE_BUS_TYPE.BusTypeFibre)
        || (BusType == STORAGE_BUS_TYPE.BusTypeiScsi)
        || (BusType == STORAGE_BUS_TYPE.BusTypeSas)
        || (BusType == STORAGE_BUS_TYPE.BusTypeSpaces);

    [NativeTypeName("#define NO_SRBTYPE_ADAPTER_DESCRIPTOR_SIZE UFIELD_OFFSET(STORAGE_ADAPTER_DESCRIPTOR, SrbType)")]
    public static uint NO_SRBTYPE_ADAPTER_DESCRIPTOR_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out STORAGE_ADAPTER_DESCRIPTOR tmp);
            return unchecked((uint)(&tmp.SrbType) - (uint)(&tmp));
        }
    }

    [NativeTypeName("#define STORAGE_MINIPORT_DESCRIPTOR_V1_SIZE RTL_SIZEOF_THROUGH_FIELD(STORAGE_MINIPORT_DESCRIPTOR, IoTimeoutValue)")]
    public static uint STORAGE_MINIPORT_DESCRIPTOR_V1_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out STORAGE_MINIPORT_DESCRIPTOR tmp);
            return unchecked(((uint)(&tmp.IoTimeoutValue) - (uint)(&tmp)) + (uint)sizeof(ushort));
        }
    }

    [NativeTypeName("#define DEVICE_LB_PROVISIONING_DESCRIPTOR_V1_SIZE RTL_SIZEOF_THROUGH_FIELD(DEVICE_LB_PROVISIONING_DESCRIPTOR, UnmapGranularityAlignment)")]
    [SupportedOSPlatform("windows6.2")]
    public static uint DEVICE_LB_PROVISIONING_DESCRIPTOR_V1_SIZE
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out DEVICE_LB_PROVISIONING_DESCRIPTOR tmp);
            return unchecked(((uint)(&tmp.UnmapGranularityAlignment) - (uint)(&tmp)) + (uint)sizeof(ulong));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool REFS_VOLUME_DATA_BUFFER_CONTAINS_DRIVER_VERSION([NativeTypeName("PREFS_VOLUME_DATA_BUFFER")] REFS_VOLUME_DATA_BUFFER* VolumeDataBuffer)
    {
        Unsafe.SkipInit(out REFS_VOLUME_DATA_BUFFER tmp);
        uint RequiredLength = unchecked(((uint)(&tmp.DriverMinorVersion) - (uint)(&tmp)) + (uint)sizeof(uint));
        return VolumeDataBuffer->ByteCount >= RequiredLength;
    }
}
