// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using static TerraFX.Interop.STORAGE_IDENTIFIER_TYPE;

namespace TerraFX.Interop
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

        [return: NativeTypeName("DWORD")]
        public static uint DeviceDsmNumberOfDataSetRanges([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input)
        {
            return Input->DataSetRangesLength / (uint)(sizeof(DEVICE_DATA_SET_RANGE));
        }

        [return: NativeTypeName("DWORD")]
        public static uint DeviceDsmGetInputLength([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint ParameterBlockLength, [NativeTypeName("DWORD")] uint NumberOfDataSetRanges)
        {
            uint Bytes = unchecked(28);

            if (ParameterBlockLength != 0)
            {
                Bytes = (((Bytes) + ((Definition->ParameterBlockAlignment) - 1)) / (Definition->ParameterBlockAlignment) * (Definition->ParameterBlockAlignment));
                Bytes += ParameterBlockLength;
            }

            if (NumberOfDataSetRanges != 0)
            {
                Bytes = (((Bytes) + ((8) - 1)) / (8) * (8));
                Bytes += (uint)(sizeof(DEVICE_DATA_SET_RANGE)) * NumberOfDataSetRanges;
            }

            return Bytes;
        }

        [return: NativeTypeName("DWORD")]
        public static uint DeviceDsmGetNumberOfDataSetRanges([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("DWORD")] uint InputLength, [NativeTypeName("DWORD")] uint ParameterBlockLength)
        {
            uint Bytes = unchecked(28);

            if (ParameterBlockLength != 0)
            {
                Bytes = (((Bytes) + ((Definition->ParameterBlockAlignment) - 1)) / (Definition->ParameterBlockAlignment) * (Definition->ParameterBlockAlignment));
                Bytes += ParameterBlockLength;
            }

            Bytes = (((Bytes) + ((8) - 1)) / (8) * (8));
            Bytes = InputLength - Bytes;
            return Bytes / (uint)(sizeof(DEVICE_DATA_SET_RANGE));
        }

        public static void DeviceDsmInitializeInput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input, [NativeTypeName("DWORD")] uint InputLength, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Parameters, [NativeTypeName("DWORD")] uint ParameterBlockLength)
        {
            uint Bytes = unchecked(28);

            Unsafe.InitBlockUnaligned((Input), 0, (InputLength));
            Input->Size = Bytes;
            Input->Action = Definition->Action;
            Input->Flags = Flags;
            if (ParameterBlockLength == 0)
            {
                goto Cleanup;
            }

            Bytes = (((Bytes) + ((Definition->ParameterBlockAlignment) - 1)) / (Definition->ParameterBlockAlignment) * (Definition->ParameterBlockAlignment));
            Input->ParameterBlockOffset = Bytes;
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
        public static byte DeviceDsmAddDataSetRange([NativeTypeName("PDEVICE_DSM_INPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES* Input, [NativeTypeName("DWORD")] uint InputLength, [NativeTypeName("LONGLONG")] long Offset, [NativeTypeName("DWORDLONG")] ulong Length)
        {
            uint Bytes = 0;
            uint Index = 0;
            DEVICE_DATA_SET_RANGE* Ranges = null;
            byte Return = 0;

            if ((Input->Flags & 0x00000001) != 0)
            {
                goto Cleanup;
            }

            if (Input->DataSetRangesLength == 0)
            {
                if (Input->ParameterBlockLength == 0)
                {
                    Bytes = (uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES));
                }
                else
                {
                    Bytes = Input->ParameterBlockOffset + Input->ParameterBlockLength;
                }

                Bytes = (((Bytes) + ((8) - 1)) / (8) * (8));
            }
            else
            {
                Bytes = Input->DataSetRangesOffset + Input->DataSetRangesLength;
            }

            if ((InputLength - Bytes) < sizeof(DEVICE_DATA_SET_RANGE))
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
            Input->DataSetRangesLength += (uint)(sizeof(DEVICE_DATA_SET_RANGE));
            Return = 1;
            Cleanup:
            return Return;
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
                Min = (uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES));
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
                Min = (uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES));
                Max = InputLength;
                if (Input->DataSetRangesOffset < Min || Input->DataSetRangesOffset > Max || (Input->DataSetRangesOffset % 8) != 0)
                {
                    goto Cleanup;
                }

                Min = (uint)(sizeof(DEVICE_DATA_SET_RANGE));
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

            Bytes = (uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT));
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

            Bytes = (uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT));
            Bytes = (((Bytes) + ((Definition->OutputBlockAlignment) - 1)) / (Definition->OutputBlockAlignment) * (Definition->OutputBlockAlignment));
            Bytes = OutputLength - Bytes;
            Cleanup:
            return Bytes;
        }

        public static void DeviceDsmInitializeOutput([NativeTypeName("PDEVICE_DSM_DEFINITION")] DEVICE_DSM_DEFINITION* Definition, [NativeTypeName("PDEVICE_DSM_OUTPUT")] DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT* Output, [NativeTypeName("DWORD")] uint OutputLength, [NativeTypeName("DWORD")] uint Flags)
        {
            uint Bytes = unchecked(36);

            Unsafe.InitBlockUnaligned((Output), 0, (OutputLength));
            Output->Size = Bytes;
            Output->Action = Definition->Action;
            Output->Flags = Flags;
            if (Definition->OutputBlockLength != 0)
            {
                Bytes = (((Bytes) + ((Definition->OutputBlockAlignment) - 1)) / (Definition->OutputBlockAlignment) * (Definition->OutputBlockAlignment));
                Output->OutputBlockOffset = Bytes;
                Output->OutputBlockLength = OutputLength - Bytes;
            }

            return;
        }

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
                Min = (uint)(sizeof(DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT));
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
        public static readonly Guid DiskClassGuid = GUID_DEVINTERFACE_DISK;

        [NativeTypeName("#define CdRomClassGuid GUID_DEVINTERFACE_CDROM")]
        public static readonly Guid CdRomClassGuid = GUID_DEVINTERFACE_CDROM;

        [NativeTypeName("#define PartitionClassGuid GUID_DEVINTERFACE_PARTITION")]
        public static readonly Guid PartitionClassGuid = GUID_DEVINTERFACE_PARTITION;

        [NativeTypeName("#define TapeClassGuid GUID_DEVINTERFACE_TAPE")]
        public static readonly Guid TapeClassGuid = GUID_DEVINTERFACE_TAPE;

        [NativeTypeName("#define WriteOnceDiskClassGuid GUID_DEVINTERFACE_WRITEONCEDISK")]
        public static readonly Guid WriteOnceDiskClassGuid = GUID_DEVINTERFACE_WRITEONCEDISK;

        [NativeTypeName("#define VolumeClassGuid GUID_DEVINTERFACE_VOLUME")]
        public static readonly Guid VolumeClassGuid = GUID_DEVINTERFACE_VOLUME;

        [NativeTypeName("#define MediumChangerClassGuid GUID_DEVINTERFACE_MEDIUMCHANGER")]
        public static readonly Guid MediumChangerClassGuid = GUID_DEVINTERFACE_MEDIUMCHANGER;

        [NativeTypeName("#define FloppyClassGuid GUID_DEVINTERFACE_FLOPPY")]
        public static readonly Guid FloppyClassGuid = GUID_DEVINTERFACE_FLOPPY;

        [NativeTypeName("#define CdChangerClassGuid GUID_DEVINTERFACE_CDCHANGER")]
        public static readonly Guid CdChangerClassGuid = GUID_DEVINTERFACE_CDCHANGER;

        [NativeTypeName("#define StoragePortClassGuid GUID_DEVINTERFACE_STORAGEPORT")]
        public static readonly Guid StoragePortClassGuid = GUID_DEVINTERFACE_STORAGEPORT;

        [NativeTypeName("#define HiddenVolumeClassGuid GUID_DEVINTERFACE_HIDDEN_VOLUME")]
        public static readonly Guid HiddenVolumeClassGuid = GUID_DEVINTERFACE_HIDDEN_VOLUME;

        [NativeTypeName("#define GUID_CLASS_COMPORT GUID_DEVINTERFACE_COMPORT")]
        public static readonly Guid GUID_CLASS_COMPORT = GUID_DEVINTERFACE_COMPORT;

        [NativeTypeName("#define GUID_SERENUM_BUS_ENUMERATOR GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR")]
        public static readonly Guid GUID_SERENUM_BUS_ENUMERATOR = GUID_DEVINTERFACE_SERENUM_BUS_ENUMERATOR;

        [NativeTypeName("#define FILE_DEVICE_BEEP 0x00000001")]
        public const int FILE_DEVICE_BEEP = 0x00000001;

        [NativeTypeName("#define FILE_DEVICE_CD_ROM 0x00000002")]
        public const int FILE_DEVICE_CD_ROM = 0x00000002;

        [NativeTypeName("#define FILE_DEVICE_CD_ROM_FILE_SYSTEM 0x00000003")]
        public const int FILE_DEVICE_CD_ROM_FILE_SYSTEM = 0x00000003;

        [NativeTypeName("#define FILE_DEVICE_CONTROLLER 0x00000004")]
        public const int FILE_DEVICE_CONTROLLER = 0x00000004;

        [NativeTypeName("#define FILE_DEVICE_DATALINK 0x00000005")]
        public const int FILE_DEVICE_DATALINK = 0x00000005;

        [NativeTypeName("#define FILE_DEVICE_DFS 0x00000006")]
        public const int FILE_DEVICE_DFS = 0x00000006;

        [NativeTypeName("#define FILE_DEVICE_DISK 0x00000007")]
        public const int FILE_DEVICE_DISK = 0x00000007;

        [NativeTypeName("#define FILE_DEVICE_DISK_FILE_SYSTEM 0x00000008")]
        public const int FILE_DEVICE_DISK_FILE_SYSTEM = 0x00000008;

        [NativeTypeName("#define FILE_DEVICE_FILE_SYSTEM 0x00000009")]
        public const int FILE_DEVICE_FILE_SYSTEM = 0x00000009;

        [NativeTypeName("#define FILE_DEVICE_INPORT_PORT 0x0000000a")]
        public const int FILE_DEVICE_INPORT_PORT = 0x0000000a;

        [NativeTypeName("#define FILE_DEVICE_KEYBOARD 0x0000000b")]
        public const int FILE_DEVICE_KEYBOARD = 0x0000000b;

        [NativeTypeName("#define FILE_DEVICE_MAILSLOT 0x0000000c")]
        public const int FILE_DEVICE_MAILSLOT = 0x0000000c;

        [NativeTypeName("#define FILE_DEVICE_MIDI_IN 0x0000000d")]
        public const int FILE_DEVICE_MIDI_IN = 0x0000000d;

        [NativeTypeName("#define FILE_DEVICE_MIDI_OUT 0x0000000e")]
        public const int FILE_DEVICE_MIDI_OUT = 0x0000000e;

        [NativeTypeName("#define FILE_DEVICE_MOUSE 0x0000000f")]
        public const int FILE_DEVICE_MOUSE = 0x0000000f;

        [NativeTypeName("#define FILE_DEVICE_MULTI_UNC_PROVIDER 0x00000010")]
        public const int FILE_DEVICE_MULTI_UNC_PROVIDER = 0x00000010;

        [NativeTypeName("#define FILE_DEVICE_NAMED_PIPE 0x00000011")]
        public const int FILE_DEVICE_NAMED_PIPE = 0x00000011;

        [NativeTypeName("#define FILE_DEVICE_NETWORK 0x00000012")]
        public const int FILE_DEVICE_NETWORK = 0x00000012;

        [NativeTypeName("#define FILE_DEVICE_NETWORK_BROWSER 0x00000013")]
        public const int FILE_DEVICE_NETWORK_BROWSER = 0x00000013;

        [NativeTypeName("#define FILE_DEVICE_NETWORK_FILE_SYSTEM 0x00000014")]
        public const int FILE_DEVICE_NETWORK_FILE_SYSTEM = 0x00000014;

        [NativeTypeName("#define FILE_DEVICE_NULL 0x00000015")]
        public const int FILE_DEVICE_NULL = 0x00000015;

        [NativeTypeName("#define FILE_DEVICE_PARALLEL_PORT 0x00000016")]
        public const int FILE_DEVICE_PARALLEL_PORT = 0x00000016;

        [NativeTypeName("#define FILE_DEVICE_PHYSICAL_NETCARD 0x00000017")]
        public const int FILE_DEVICE_PHYSICAL_NETCARD = 0x00000017;

        [NativeTypeName("#define FILE_DEVICE_PRINTER 0x00000018")]
        public const int FILE_DEVICE_PRINTER = 0x00000018;

        [NativeTypeName("#define FILE_DEVICE_SCANNER 0x00000019")]
        public const int FILE_DEVICE_SCANNER = 0x00000019;

        [NativeTypeName("#define FILE_DEVICE_SERIAL_MOUSE_PORT 0x0000001a")]
        public const int FILE_DEVICE_SERIAL_MOUSE_PORT = 0x0000001a;

        [NativeTypeName("#define FILE_DEVICE_SERIAL_PORT 0x0000001b")]
        public const int FILE_DEVICE_SERIAL_PORT = 0x0000001b;

        [NativeTypeName("#define FILE_DEVICE_SCREEN 0x0000001c")]
        public const int FILE_DEVICE_SCREEN = 0x0000001c;

        [NativeTypeName("#define FILE_DEVICE_SOUND 0x0000001d")]
        public const int FILE_DEVICE_SOUND = 0x0000001d;

        [NativeTypeName("#define FILE_DEVICE_STREAMS 0x0000001e")]
        public const int FILE_DEVICE_STREAMS = 0x0000001e;

        [NativeTypeName("#define FILE_DEVICE_TAPE 0x0000001f")]
        public const int FILE_DEVICE_TAPE = 0x0000001f;

        [NativeTypeName("#define FILE_DEVICE_TAPE_FILE_SYSTEM 0x00000020")]
        public const int FILE_DEVICE_TAPE_FILE_SYSTEM = 0x00000020;

        [NativeTypeName("#define FILE_DEVICE_TRANSPORT 0x00000021")]
        public const int FILE_DEVICE_TRANSPORT = 0x00000021;

        [NativeTypeName("#define FILE_DEVICE_UNKNOWN 0x00000022")]
        public const int FILE_DEVICE_UNKNOWN = 0x00000022;

        [NativeTypeName("#define FILE_DEVICE_VIDEO 0x00000023")]
        public const int FILE_DEVICE_VIDEO = 0x00000023;

        [NativeTypeName("#define FILE_DEVICE_VIRTUAL_DISK 0x00000024")]
        public const int FILE_DEVICE_VIRTUAL_DISK = 0x00000024;

        [NativeTypeName("#define FILE_DEVICE_WAVE_IN 0x00000025")]
        public const int FILE_DEVICE_WAVE_IN = 0x00000025;

        [NativeTypeName("#define FILE_DEVICE_WAVE_OUT 0x00000026")]
        public const int FILE_DEVICE_WAVE_OUT = 0x00000026;

        [NativeTypeName("#define FILE_DEVICE_8042_PORT 0x00000027")]
        public const int FILE_DEVICE_8042_PORT = 0x00000027;

        [NativeTypeName("#define FILE_DEVICE_NETWORK_REDIRECTOR 0x00000028")]
        public const int FILE_DEVICE_NETWORK_REDIRECTOR = 0x00000028;

        [NativeTypeName("#define FILE_DEVICE_BATTERY 0x00000029")]
        public const int FILE_DEVICE_BATTERY = 0x00000029;

        [NativeTypeName("#define FILE_DEVICE_BUS_EXTENDER 0x0000002a")]
        public const int FILE_DEVICE_BUS_EXTENDER = 0x0000002a;

        [NativeTypeName("#define FILE_DEVICE_MODEM 0x0000002b")]
        public const int FILE_DEVICE_MODEM = 0x0000002b;

        [NativeTypeName("#define FILE_DEVICE_VDM 0x0000002c")]
        public const int FILE_DEVICE_VDM = 0x0000002c;

        [NativeTypeName("#define FILE_DEVICE_MASS_STORAGE 0x0000002d")]
        public const int FILE_DEVICE_MASS_STORAGE = 0x0000002d;

        [NativeTypeName("#define FILE_DEVICE_SMB 0x0000002e")]
        public const int FILE_DEVICE_SMB = 0x0000002e;

        [NativeTypeName("#define FILE_DEVICE_KS 0x0000002f")]
        public const int FILE_DEVICE_KS = 0x0000002f;

        [NativeTypeName("#define FILE_DEVICE_CHANGER 0x00000030")]
        public const int FILE_DEVICE_CHANGER = 0x00000030;

        [NativeTypeName("#define FILE_DEVICE_SMARTCARD 0x00000031")]
        public const int FILE_DEVICE_SMARTCARD = 0x00000031;

        [NativeTypeName("#define FILE_DEVICE_ACPI 0x00000032")]
        public const int FILE_DEVICE_ACPI = 0x00000032;

        [NativeTypeName("#define FILE_DEVICE_DVD 0x00000033")]
        public const int FILE_DEVICE_DVD = 0x00000033;

        [NativeTypeName("#define FILE_DEVICE_FULLSCREEN_VIDEO 0x00000034")]
        public const int FILE_DEVICE_FULLSCREEN_VIDEO = 0x00000034;

        [NativeTypeName("#define FILE_DEVICE_DFS_FILE_SYSTEM 0x00000035")]
        public const int FILE_DEVICE_DFS_FILE_SYSTEM = 0x00000035;

        [NativeTypeName("#define FILE_DEVICE_DFS_VOLUME 0x00000036")]
        public const int FILE_DEVICE_DFS_VOLUME = 0x00000036;

        [NativeTypeName("#define FILE_DEVICE_SERENUM 0x00000037")]
        public const int FILE_DEVICE_SERENUM = 0x00000037;

        [NativeTypeName("#define FILE_DEVICE_TERMSRV 0x00000038")]
        public const int FILE_DEVICE_TERMSRV = 0x00000038;

        [NativeTypeName("#define FILE_DEVICE_KSEC 0x00000039")]
        public const int FILE_DEVICE_KSEC = 0x00000039;

        [NativeTypeName("#define FILE_DEVICE_FIPS 0x0000003A")]
        public const int FILE_DEVICE_FIPS = 0x0000003A;

        [NativeTypeName("#define FILE_DEVICE_INFINIBAND 0x0000003B")]
        public const int FILE_DEVICE_INFINIBAND = 0x0000003B;

        [NativeTypeName("#define FILE_DEVICE_VMBUS 0x0000003E")]
        public const int FILE_DEVICE_VMBUS = 0x0000003E;

        [NativeTypeName("#define FILE_DEVICE_CRYPT_PROVIDER 0x0000003F")]
        public const int FILE_DEVICE_CRYPT_PROVIDER = 0x0000003F;

        [NativeTypeName("#define FILE_DEVICE_WPD 0x00000040")]
        public const int FILE_DEVICE_WPD = 0x00000040;

        [NativeTypeName("#define FILE_DEVICE_BLUETOOTH 0x00000041")]
        public const int FILE_DEVICE_BLUETOOTH = 0x00000041;

        [NativeTypeName("#define FILE_DEVICE_MT_COMPOSITE 0x00000042")]
        public const int FILE_DEVICE_MT_COMPOSITE = 0x00000042;

        [NativeTypeName("#define FILE_DEVICE_MT_TRANSPORT 0x00000043")]
        public const int FILE_DEVICE_MT_TRANSPORT = 0x00000043;

        [NativeTypeName("#define FILE_DEVICE_BIOMETRIC 0x00000044")]
        public const int FILE_DEVICE_BIOMETRIC = 0x00000044;

        [NativeTypeName("#define FILE_DEVICE_PMI 0x00000045")]
        public const int FILE_DEVICE_PMI = 0x00000045;

        [NativeTypeName("#define FILE_DEVICE_EHSTOR 0x00000046")]
        public const int FILE_DEVICE_EHSTOR = 0x00000046;

        [NativeTypeName("#define FILE_DEVICE_DEVAPI 0x00000047")]
        public const int FILE_DEVICE_DEVAPI = 0x00000047;

        [NativeTypeName("#define FILE_DEVICE_GPIO 0x00000048")]
        public const int FILE_DEVICE_GPIO = 0x00000048;

        [NativeTypeName("#define FILE_DEVICE_USBEX 0x00000049")]
        public const int FILE_DEVICE_USBEX = 0x00000049;

        [NativeTypeName("#define FILE_DEVICE_CONSOLE 0x00000050")]
        public const int FILE_DEVICE_CONSOLE = 0x00000050;

        [NativeTypeName("#define FILE_DEVICE_NFP 0x00000051")]
        public const int FILE_DEVICE_NFP = 0x00000051;

        [NativeTypeName("#define FILE_DEVICE_SYSENV 0x00000052")]
        public const int FILE_DEVICE_SYSENV = 0x00000052;

        [NativeTypeName("#define FILE_DEVICE_VIRTUAL_BLOCK 0x00000053")]
        public const int FILE_DEVICE_VIRTUAL_BLOCK = 0x00000053;

        [NativeTypeName("#define FILE_DEVICE_POINT_OF_SERVICE 0x00000054")]
        public const int FILE_DEVICE_POINT_OF_SERVICE = 0x00000054;

        [NativeTypeName("#define FILE_DEVICE_STORAGE_REPLICATION 0x00000055")]
        public const int FILE_DEVICE_STORAGE_REPLICATION = 0x00000055;

        [NativeTypeName("#define FILE_DEVICE_TRUST_ENV 0x00000056")]
        public const int FILE_DEVICE_TRUST_ENV = 0x00000056;

        [NativeTypeName("#define FILE_DEVICE_UCM 0x00000057")]
        public const int FILE_DEVICE_UCM = 0x00000057;

        [NativeTypeName("#define FILE_DEVICE_UCMTCPCI 0x00000058")]
        public const int FILE_DEVICE_UCMTCPCI = 0x00000058;

        [NativeTypeName("#define FILE_DEVICE_PERSISTENT_MEMORY 0x00000059")]
        public const int FILE_DEVICE_PERSISTENT_MEMORY = 0x00000059;

        [NativeTypeName("#define FILE_DEVICE_NVDIMM 0x0000005a")]
        public const int FILE_DEVICE_NVDIMM = 0x0000005a;

        [NativeTypeName("#define FILE_DEVICE_HOLOGRAPHIC 0x0000005b")]
        public const int FILE_DEVICE_HOLOGRAPHIC = 0x0000005b;

        [NativeTypeName("#define FILE_DEVICE_SDFXHCI 0x0000005c")]
        public const int FILE_DEVICE_SDFXHCI = 0x0000005c;

        [NativeTypeName("#define FILE_DEVICE_UCMUCSI 0x0000005d")]
        public const int FILE_DEVICE_UCMUCSI = 0x0000005d;

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

        [NativeTypeName("#define FILE_ANY_ACCESS 0")]
        public const int FILE_ANY_ACCESS = 0;

        [NativeTypeName("#define FILE_SPECIAL_ACCESS (FILE_ANY_ACCESS)")]
        public const int FILE_SPECIAL_ACCESS = (0);

        [NativeTypeName("#define FILE_READ_ACCESS ( 0x0001 )")]
        public const int FILE_READ_ACCESS = (0x0001);

        [NativeTypeName("#define FILE_WRITE_ACCESS ( 0x0002 )")]
        public const int FILE_WRITE_ACCESS = (0x0002);

        [NativeTypeName("#define IOCTL_STORAGE_BASE FILE_DEVICE_MASS_STORAGE")]
        public const int IOCTL_STORAGE_BASE = 0x0000002d;

        [NativeTypeName("#define IOCTL_STORAGE_CHECK_VERIFY CTL_CODE(IOCTL_STORAGE_BASE, 0x0200, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_CHECK_VERIFY = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0200) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_CHECK_VERIFY2 CTL_CODE(IOCTL_STORAGE_BASE, 0x0200, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_CHECK_VERIFY2 = (((0x0000002d) << 16) | ((0) << 14) | ((0x0200) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_MEDIA_REMOVAL CTL_CODE(IOCTL_STORAGE_BASE, 0x0201, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_MEDIA_REMOVAL = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0201) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_EJECT_MEDIA CTL_CODE(IOCTL_STORAGE_BASE, 0x0202, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_EJECT_MEDIA = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0202) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_LOAD_MEDIA CTL_CODE(IOCTL_STORAGE_BASE, 0x0203, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_LOAD_MEDIA = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0203) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_LOAD_MEDIA2 CTL_CODE(IOCTL_STORAGE_BASE, 0x0203, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_LOAD_MEDIA2 = (((0x0000002d) << 16) | ((0) << 14) | ((0x0203) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_RESERVE CTL_CODE(IOCTL_STORAGE_BASE, 0x0204, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_RESERVE = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0204) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_RELEASE CTL_CODE(IOCTL_STORAGE_BASE, 0x0205, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_RELEASE = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0205) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_FIND_NEW_DEVICES CTL_CODE(IOCTL_STORAGE_BASE, 0x0206, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_FIND_NEW_DEVICES = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0206) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_EJECTION_CONTROL CTL_CODE(IOCTL_STORAGE_BASE, 0x0250, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_EJECTION_CONTROL = (((0x0000002d) << 16) | ((0) << 14) | ((0x0250) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_MCN_CONTROL CTL_CODE(IOCTL_STORAGE_BASE, 0x0251, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_MCN_CONTROL = (((0x0000002d) << 16) | ((0) << 14) | ((0x0251) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_MEDIA_TYPES CTL_CODE(IOCTL_STORAGE_BASE, 0x0300, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_MEDIA_TYPES = (((0x0000002d) << 16) | ((0) << 14) | ((0x0300) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_MEDIA_TYPES_EX CTL_CODE(IOCTL_STORAGE_BASE, 0x0301, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_MEDIA_TYPES_EX = (((0x0000002d) << 16) | ((0) << 14) | ((0x0301) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_MEDIA_SERIAL_NUMBER CTL_CODE(IOCTL_STORAGE_BASE, 0x0304, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_MEDIA_SERIAL_NUMBER = (((0x0000002d) << 16) | ((0) << 14) | ((0x0304) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_HOTPLUG_INFO CTL_CODE(IOCTL_STORAGE_BASE, 0x0305, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_HOTPLUG_INFO = (((0x0000002d) << 16) | ((0) << 14) | ((0x0305) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_SET_HOTPLUG_INFO CTL_CODE(IOCTL_STORAGE_BASE, 0x0306, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_SET_HOTPLUG_INFO = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0306) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_RESET_BUS CTL_CODE(IOCTL_STORAGE_BASE, 0x0400, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_RESET_BUS = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0400) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_RESET_DEVICE CTL_CODE(IOCTL_STORAGE_BASE, 0x0401, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_RESET_DEVICE = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0401) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_BREAK_RESERVATION CTL_CODE(IOCTL_STORAGE_BASE, 0x0405, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_BREAK_RESERVATION = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0405) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_PERSISTENT_RESERVE_IN CTL_CODE(IOCTL_STORAGE_BASE, 0x0406, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_PERSISTENT_RESERVE_IN = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0406) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_PERSISTENT_RESERVE_OUT CTL_CODE(IOCTL_STORAGE_BASE, 0x0407, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_PERSISTENT_RESERVE_OUT = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0407) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_DEVICE_NUMBER CTL_CODE(IOCTL_STORAGE_BASE, 0x0420, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_DEVICE_NUMBER = (((0x0000002d) << 16) | ((0) << 14) | ((0x0420) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_DEVICE_NUMBER_EX CTL_CODE(IOCTL_STORAGE_BASE, 0x0421, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_DEVICE_NUMBER_EX = (((0x0000002d) << 16) | ((0) << 14) | ((0x0421) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_PREDICT_FAILURE CTL_CODE(IOCTL_STORAGE_BASE, 0x0440, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_PREDICT_FAILURE = (((0x0000002d) << 16) | ((0) << 14) | ((0x0440) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_FAILURE_PREDICTION_CONFIG CTL_CODE(IOCTL_STORAGE_BASE, 0x0441, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_FAILURE_PREDICTION_CONFIG = (((0x0000002d) << 16) | ((0) << 14) | ((0x0441) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_COUNTERS CTL_CODE(IOCTL_STORAGE_BASE, 0x442, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_COUNTERS = (((0x0000002d) << 16) | ((0) << 14) | ((0x442) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_READ_CAPACITY CTL_CODE(IOCTL_STORAGE_BASE, 0x0450, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_READ_CAPACITY = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0450) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_DEVICE_TELEMETRY CTL_CODE(IOCTL_STORAGE_BASE, 0x0470, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_GET_DEVICE_TELEMETRY = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0470) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_DEVICE_TELEMETRY_NOTIFY CTL_CODE(IOCTL_STORAGE_BASE, 0x0471, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_DEVICE_TELEMETRY_NOTIFY = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0471) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_DEVICE_TELEMETRY_QUERY_CAPS CTL_CODE(IOCTL_STORAGE_BASE, 0x0472, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_DEVICE_TELEMETRY_QUERY_CAPS = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0472) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_DEVICE_TELEMETRY_RAW CTL_CODE(IOCTL_STORAGE_BASE, 0x0473, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_GET_DEVICE_TELEMETRY_RAW = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0473) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_SET_TEMPERATURE_THRESHOLD CTL_CODE(IOCTL_STORAGE_BASE, 0x0480, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_SET_TEMPERATURE_THRESHOLD = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0480) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_PROTOCOL_COMMAND CTL_CODE(IOCTL_STORAGE_BASE, 0x04F0, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_PROTOCOL_COMMAND = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x04F0) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_QUERY_PROPERTY CTL_CODE(IOCTL_STORAGE_BASE, 0x0500, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_QUERY_PROPERTY = (((0x0000002d) << 16) | ((0) << 14) | ((0x0500) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_MANAGE_DATA_SET_ATTRIBUTES CTL_CODE(IOCTL_STORAGE_BASE, 0x0501, METHOD_BUFFERED, FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_MANAGE_DATA_SET_ATTRIBUTES = (((0x0000002d) << 16) | (((0x0002)) << 14) | ((0x0501) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_LB_PROVISIONING_MAP_RESOURCES CTL_CODE(IOCTL_STORAGE_BASE, 0x0502, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_GET_LB_PROVISIONING_MAP_RESOURCES = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0502) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_SET_PROPERTY CTL_CODE(IOCTL_STORAGE_BASE, 0x0503, METHOD_BUFFERED, FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_SET_PROPERTY = (((0x0000002d) << 16) | (((0x0002)) << 14) | ((0x0503) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_REINITIALIZE_MEDIA CTL_CODE(IOCTL_STORAGE_BASE, 0x0590, METHOD_BUFFERED, FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_REINITIALIZE_MEDIA = (((0x0000002d) << 16) | (((0x0002)) << 14) | ((0x0590) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_BC_PROPERTIES CTL_CODE(IOCTL_STORAGE_BASE, 0x0600, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_STORAGE_GET_BC_PROPERTIES = (((0x0000002d) << 16) | (((0x0001)) << 14) | ((0x0600) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_ALLOCATE_BC_STREAM CTL_CODE(IOCTL_STORAGE_BASE, 0x0601, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_ALLOCATE_BC_STREAM = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0601) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_FREE_BC_STREAM CTL_CODE(IOCTL_STORAGE_BASE, 0x0602, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_FREE_BC_STREAM = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0602) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_CHECK_PRIORITY_HINT_SUPPORT CTL_CODE(IOCTL_STORAGE_BASE, 0x0620, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_CHECK_PRIORITY_HINT_SUPPORT = (((0x0000002d) << 16) | ((0) << 14) | ((0x0620) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_START_DATA_INTEGRITY_CHECK CTL_CODE(IOCTL_STORAGE_BASE, 0x0621, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_START_DATA_INTEGRITY_CHECK = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0621) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_STOP_DATA_INTEGRITY_CHECK CTL_CODE(IOCTL_STORAGE_BASE, 0x0622, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_STOP_DATA_INTEGRITY_CHECK = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0622) << 2) | (0));

        [NativeTypeName("#define OBSOLETE_IOCTL_STORAGE_RESET_BUS CTL_CODE(IOCTL_STORAGE_BASE, 0x0400, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int OBSOLETE_IOCTL_STORAGE_RESET_BUS = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0400) << 2) | (0));

        [NativeTypeName("#define OBSOLETE_IOCTL_STORAGE_RESET_DEVICE CTL_CODE(IOCTL_STORAGE_BASE, 0x0401, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int OBSOLETE_IOCTL_STORAGE_RESET_DEVICE = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0401) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_FIRMWARE_GET_INFO CTL_CODE(IOCTL_STORAGE_BASE, 0x0700, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_FIRMWARE_GET_INFO = (((0x0000002d) << 16) | ((0) << 14) | ((0x0700) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_FIRMWARE_DOWNLOAD CTL_CODE(IOCTL_STORAGE_BASE, 0x0701, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_FIRMWARE_DOWNLOAD = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0701) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_FIRMWARE_ACTIVATE CTL_CODE(IOCTL_STORAGE_BASE, 0x0702, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_FIRMWARE_ACTIVATE = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0702) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_ENABLE_IDLE_POWER CTL_CODE(IOCTL_STORAGE_BASE, 0x0720, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_ENABLE_IDLE_POWER = (((0x0000002d) << 16) | ((0) << 14) | ((0x0720) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_IDLE_POWERUP_REASON CTL_CODE(IOCTL_STORAGE_BASE, 0x0721, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_IDLE_POWERUP_REASON = (((0x0000002d) << 16) | ((0) << 14) | ((0x0721) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_POWER_ACTIVE CTL_CODE(IOCTL_STORAGE_BASE, 0x0722, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_POWER_ACTIVE = (((0x0000002d) << 16) | ((0) << 14) | ((0x0722) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_POWER_IDLE CTL_CODE(IOCTL_STORAGE_BASE, 0x0723, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_POWER_IDLE = (((0x0000002d) << 16) | ((0) << 14) | ((0x0723) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_EVENT_NOTIFICATION CTL_CODE(IOCTL_STORAGE_BASE, 0x0724, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_EVENT_NOTIFICATION = (((0x0000002d) << 16) | ((0) << 14) | ((0x0724) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_DEVICE_POWER_CAP CTL_CODE(IOCTL_STORAGE_BASE, 0x0725, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_DEVICE_POWER_CAP = (((0x0000002d) << 16) | ((0) << 14) | ((0x0725) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_RPMB_COMMAND CTL_CODE(IOCTL_STORAGE_BASE, 0x0726, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_RPMB_COMMAND = (((0x0000002d) << 16) | ((0) << 14) | ((0x0726) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_ATTRIBUTE_MANAGEMENT CTL_CODE(IOCTL_STORAGE_BASE, 0x0727, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_STORAGE_ATTRIBUTE_MANAGEMENT = (((0x0000002d) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0727) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_DIAGNOSTIC CTL_CODE(IOCTL_STORAGE_BASE, 0x0728, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_DIAGNOSTIC = (((0x0000002d) << 16) | ((0) << 14) | ((0x0728) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_PHYSICAL_ELEMENT_STATUS CTL_CODE(IOCTL_STORAGE_BASE, 0x0729, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_PHYSICAL_ELEMENT_STATUS = (((0x0000002d) << 16) | ((0) << 14) | ((0x0729) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_REMOVE_ELEMENT_AND_TRUNCATE CTL_CODE(IOCTL_STORAGE_BASE, 0x0730, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_REMOVE_ELEMENT_AND_TRUNCATE = (((0x0000002d) << 16) | ((0) << 14) | ((0x0730) << 2) | (0));

        [NativeTypeName("#define IOCTL_STORAGE_GET_DEVICE_INTERNAL_LOG CTL_CODE(IOCTL_STORAGE_BASE, 0x0731, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_STORAGE_GET_DEVICE_INTERNAL_LOG = (((0x0000002d) << 16) | ((0) << 14) | ((0x0731) << 2) | (0));

        [NativeTypeName("#define STORAGE_DEVICE_FLAGS_RANDOM_DEVICEGUID_REASON_CONFLICT 0x1")]
        public const int STORAGE_DEVICE_FLAGS_RANDOM_DEVICEGUID_REASON_CONFLICT = 0x1;

        [NativeTypeName("#define STORAGE_DEVICE_FLAGS_RANDOM_DEVICEGUID_REASON_NOHWID 0x2")]
        public const int STORAGE_DEVICE_FLAGS_RANDOM_DEVICEGUID_REASON_NOHWID = 0x2;

        [NativeTypeName("#define STORAGE_DEVICE_FLAGS_PAGE_83_DEVICEGUID 0x4")]
        public const int STORAGE_DEVICE_FLAGS_PAGE_83_DEVICEGUID = 0x4;

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

        [NativeTypeName("#define TAPE_RETURN_STATISTICS 0L")]
        public const int TAPE_RETURN_STATISTICS = 0;

        [NativeTypeName("#define TAPE_RETURN_ENV_INFO 1L")]
        public const int TAPE_RETURN_ENV_INFO = 1;

        [NativeTypeName("#define TAPE_RESET_STATISTICS 2L")]
        public const int TAPE_RESET_STATISTICS = 2;

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

        [NativeTypeName("#define STORAGE_FAILURE_PREDICTION_CONFIG_V1 1")]
        public const int STORAGE_FAILURE_PREDICTION_CONFIG_V1 = 1;

        [NativeTypeName("#define SRB_TYPE_SCSI_REQUEST_BLOCK 0")]
        public const int SRB_TYPE_SCSI_REQUEST_BLOCK = 0;

        [NativeTypeName("#define SRB_TYPE_STORAGE_REQUEST_BLOCK 1")]
        public const int SRB_TYPE_STORAGE_REQUEST_BLOCK = 1;

        [NativeTypeName("#define STORAGE_ADDRESS_TYPE_BTL8 0")]
        public const int STORAGE_ADDRESS_TYPE_BTL8 = 0;

        [NativeTypeName("#define StorageIdTypeNAA StorageIdTypeFCPHName")]
        public const STORAGE_IDENTIFIER_TYPE StorageIdTypeNAA = StorageIdTypeFCPHName;

        [NativeTypeName("#define STORAGE_RPMB_DESCRIPTOR_VERSION_1 1")]
        public const int STORAGE_RPMB_DESCRIPTOR_VERSION_1 = 1;

        [NativeTypeName("#define STORAGE_RPMB_MINIMUM_RELIABLE_WRITE_SIZE 512")]
        public const int STORAGE_RPMB_MINIMUM_RELIABLE_WRITE_SIZE = 512;

        [NativeTypeName("#define STORAGE_CRYPTO_CAPABILITY_VERSION_1 1")]
        public const int STORAGE_CRYPTO_CAPABILITY_VERSION_1 = 1;

        [NativeTypeName("#define STORAGE_CRYPTO_DESCRIPTOR_VERSION_1 1")]
        public const int STORAGE_CRYPTO_DESCRIPTOR_VERSION_1 = 1;

        [NativeTypeName("#define STORAGE_TIER_NAME_LENGTH (256)")]
        public const int STORAGE_TIER_NAME_LENGTH = (256);

        [NativeTypeName("#define STORAGE_TIER_DESCRIPTION_LENGTH (512)")]
        public const int STORAGE_TIER_DESCRIPTION_LENGTH = (512);

        [NativeTypeName("#define STORAGE_TIER_FLAG_NO_SEEK_PENALTY (0x00020000)")]
        public const int STORAGE_TIER_FLAG_NO_SEEK_PENALTY = (0x00020000);

        [NativeTypeName("#define STORAGE_TIER_FLAG_WRITE_BACK_CACHE (0x00200000)")]
        public const int STORAGE_TIER_FLAG_WRITE_BACK_CACHE = (0x00200000);

        [NativeTypeName("#define STORAGE_TIER_FLAG_READ_CACHE (0x00400000)")]
        public const int STORAGE_TIER_FLAG_READ_CACHE = (0x00400000);

        [NativeTypeName("#define STORAGE_TIER_FLAG_PARITY (0x00800000)")]
        public const int STORAGE_TIER_FLAG_PARITY = (0x00800000);

        [NativeTypeName("#define STORAGE_TIER_FLAG_SMR (0x01000000)")]
        public const int STORAGE_TIER_FLAG_SMR = (0x01000000);

        [NativeTypeName("#define STORAGE_TEMPERATURE_VALUE_NOT_REPORTED 0x8000")]
        public const int STORAGE_TEMPERATURE_VALUE_NOT_REPORTED = 0x8000;

        [NativeTypeName("#define STORAGE_TEMPERATURE_THRESHOLD_FLAG_ADAPTER_REQUEST 0x0001")]
        public const int STORAGE_TEMPERATURE_THRESHOLD_FLAG_ADAPTER_REQUEST = 0x0001;

        [NativeTypeName("#define STORAGE_COMPONENT_ROLE_CACHE 0x00000001")]
        public const int STORAGE_COMPONENT_ROLE_CACHE = 0x00000001;

        [NativeTypeName("#define STORAGE_COMPONENT_ROLE_TIERING 0x00000002")]
        public const int STORAGE_COMPONENT_ROLE_TIERING = 0x00000002;

        [NativeTypeName("#define STORAGE_COMPONENT_ROLE_DATA 0x00000004")]
        public const int STORAGE_COMPONENT_ROLE_DATA = 0x00000004;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_BYTE_ADDRESSABLE_IO 0x01")]
        public const int STORAGE_ATTRIBUTE_BYTE_ADDRESSABLE_IO = 0x01;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_BLOCK_IO 0x02")]
        public const int STORAGE_ATTRIBUTE_BLOCK_IO = 0x02;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_DYNAMIC_PERSISTENCE 0x04")]
        public const int STORAGE_ATTRIBUTE_DYNAMIC_PERSISTENCE = 0x04;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_VOLATILE 0x08")]
        public const int STORAGE_ATTRIBUTE_VOLATILE = 0x08;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_ASYNC_EVENT_NOTIFICATION 0x10")]
        public const int STORAGE_ATTRIBUTE_ASYNC_EVENT_NOTIFICATION = 0x10;

        [NativeTypeName("#define STORAGE_ATTRIBUTE_PERF_SIZE_INDEPENDENT 0x20")]
        public const int STORAGE_ATTRIBUTE_PERF_SIZE_INDEPENDENT = 0x20;

        [NativeTypeName("#define STORAGE_DEVICE_MAX_OPERATIONAL_STATUS 16")]
        public const int STORAGE_DEVICE_MAX_OPERATIONAL_STATUS = 16;

        [NativeTypeName("#define STORAGE_ADAPTER_SERIAL_NUMBER_V1_MAX_LENGTH (128)")]
        public const int STORAGE_ADAPTER_SERIAL_NUMBER_V1_MAX_LENGTH = (128);

        [NativeTypeName("#define STORAGE_ADAPTER_SERIAL_NUMBER_V1_VERSION (sizeof(STORAGE_ADAPTER_SERIAL_NUMBER))")]
        public const uint STORAGE_ADAPTER_SERIAL_NUMBER_V1_VERSION = unchecked(264);

        [NativeTypeName("#define STORAGE_ADAPTER_SERIAL_NUMBER_V1_SIZE (sizeof(STORAGE_ADAPTER_SERIAL_NUMBER))")]
        public const uint STORAGE_ADAPTER_SERIAL_NUMBER_V1_SIZE = unchecked(264);

        [NativeTypeName("#define STORAGE_DEVICE_NUMA_NODE_UNKNOWN MAXDWORD")]
        public const uint STORAGE_DEVICE_NUMA_NODE_UNKNOWN = 0xffffffff;

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

        [NativeTypeName("#define STORAGE_OFFLOAD_MAX_TOKEN_LENGTH 512")]
        public const int STORAGE_OFFLOAD_MAX_TOKEN_LENGTH = 512;

        [NativeTypeName("#define STORAGE_OFFLOAD_TOKEN_ID_LENGTH 0x1F8")]
        public const int STORAGE_OFFLOAD_TOKEN_ID_LENGTH = 0x1F8;

        [NativeTypeName("#define STORAGE_OFFLOAD_TOKEN_TYPE_ZERO_DATA 0xFFFF0001")]
        public const uint STORAGE_OFFLOAD_TOKEN_TYPE_ZERO_DATA = 0xFFFF0001;

        [NativeTypeName("#define STORAGE_OFFLOAD_READ_RANGE_TRUNCATED 0x00000001")]
        public const int STORAGE_OFFLOAD_READ_RANGE_TRUNCATED = 0x00000001;

        [NativeTypeName("#define STORAGE_OFFLOAD_WRITE_RANGE_TRUNCATED 0x0001")]
        public const int STORAGE_OFFLOAD_WRITE_RANGE_TRUNCATED = 0x0001;

        [NativeTypeName("#define STORAGE_OFFLOAD_TOKEN_INVALID 0x0002")]
        public const int STORAGE_OFFLOAD_TOKEN_INVALID = 0x0002;

        [NativeTypeName("#define DEVICE_DSM_FLAG_ALLOCATION_CONSOLIDATEABLE_ONLY 0x40000000")]
        public const int DEVICE_DSM_FLAG_ALLOCATION_CONSOLIDATEABLE_ONLY = 0x40000000;

        [NativeTypeName("#define DEVICE_DSM_PARAMETERS_V1 1")]
        public const int DEVICE_DSM_PARAMETERS_V1 = 1;

        [NativeTypeName("#define DEVICE_DATA_SET_LBP_STATE_PARAMETERS_VERSION_V1 DEVICE_DSM_PARAMETERS_V1")]
        public const int DEVICE_DATA_SET_LBP_STATE_PARAMETERS_VERSION_V1 = 1;

        [NativeTypeName("#define DEVICE_DSM_ALLOCATION_OUTPUT_V1 (sizeof(DEVICE_DSM_ALLOCATION_OUTPUT))")]
        public const uint DEVICE_DSM_ALLOCATION_OUTPUT_V1 = unchecked(32);

        [NativeTypeName("#define DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V1 DEVICE_DSM_ALLOCATION_OUTPUT_V1")]
        public const uint DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V1 = unchecked(32);

        [NativeTypeName("#define DEVICE_DSM_ALLOCATION_OUTPUT_V2 (sizeof(DEVICE_DSM_ALLOCATION_OUTPUT2))")]
        public const uint DEVICE_DSM_ALLOCATION_OUTPUT_V2 = unchecked(40);

        [NativeTypeName("#define DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V2 DEVICE_DSM_ALLOCATION_OUTPUT_V2")]
        public const uint DEVICE_DATA_SET_LB_PROVISIONING_STATE_VERSION_V2 = unchecked(40);

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

        [NativeTypeName("#define IOCTL_STORAGE_BC_VERSION 1")]
        public const int IOCTL_STORAGE_BC_VERSION = 1;

        [NativeTypeName("#define STORAGE_PRIORITY_HINT_SUPPORTED 0x0001")]
        public const int STORAGE_PRIORITY_HINT_SUPPORTED = 0x0001;

        [NativeTypeName("#define ERROR_HISTORY_DIRECTORY_ENTRY_DEFAULT_COUNT 8")]
        public const int ERROR_HISTORY_DIRECTORY_ENTRY_DEFAULT_COUNT = 8;

        [NativeTypeName("#define DEVICEDUMP_STRUCTURE_VERSION_V1 1")]
        public const int DEVICEDUMP_STRUCTURE_VERSION_V1 = 1;

        [NativeTypeName("#define DEVICEDUMP_MAX_IDSTRING 32")]
        public const int DEVICEDUMP_MAX_IDSTRING = 32;

        [NativeTypeName("#define MAX_FW_BUCKET_ID_LENGTH 132")]
        public const int MAX_FW_BUCKET_ID_LENGTH = 132;

        [NativeTypeName("#define STORAGE_CRASH_TELEMETRY_REGKEY L\"\\\\Registry\\\\Machine\\\\System\\\\CurrentControlSet\\\\Control\\\\CrashControl\\\\StorageTelemetry\"")]
        public const string STORAGE_CRASH_TELEMETRY_REGKEY = "\\Registry\\Machine\\System\\CurrentControlSet\\Control\\CrashControl\\StorageTelemetry";

        [NativeTypeName("#define STORAGE_DEVICE_TELEMETRY_REGKEY L\"\\\\Registry\\\\Machine\\\\System\\\\CurrentControlSet\\\\Control\\\\Storage\\\\StorageTelemetry\"")]
        public const string STORAGE_DEVICE_TELEMETRY_REGKEY = "\\Registry\\Machine\\System\\CurrentControlSet\\Control\\Storage\\StorageTelemetry";

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

        [NativeTypeName("#define STORAGE_IDLE_POWERUP_REASON_VERSION_V1 1")]
        public const int STORAGE_IDLE_POWERUP_REASON_VERSION_V1 = 1;

        [NativeTypeName("#define STORAGE_DEVICE_POWER_CAP_VERSION_V1 1")]
        public const int STORAGE_DEVICE_POWER_CAP_VERSION_V1 = 1;

        [NativeTypeName("#define STORAGE_EVENT_NOTIFICATION_VERSION_V1 1")]
        public const int STORAGE_EVENT_NOTIFICATION_VERSION_V1 = 1;

        [NativeTypeName("#define STORAGE_EVENT_MEDIA_STATUS 0x0000000000000001")]
        public const int STORAGE_EVENT_MEDIA_STATUS = 0x0000000000000001;

        [NativeTypeName("#define STORAGE_EVENT_DEVICE_STATUS 0x0000000000000002")]
        public const int STORAGE_EVENT_DEVICE_STATUS = 0x0000000000000002;

        [NativeTypeName("#define STORAGE_EVENT_DEVICE_OPERATION 0x0000000000000004")]
        public const int STORAGE_EVENT_DEVICE_OPERATION = 0x0000000000000004;

        [NativeTypeName("#define STORAGE_EVENT_ALL (STORAGE_EVENT_MEDIA_STATUS | STORAGE_EVENT_DEVICE_STATUS | STORAGE_EVENT_DEVICE_OPERATION)")]
        public const int STORAGE_EVENT_ALL = (0x0000000000000001 | 0x0000000000000002 | 0x0000000000000004);

        [NativeTypeName("#define READ_COPY_NUMBER_KEY 0x52434e00")]
        public const int READ_COPY_NUMBER_KEY = 0x52434e00;

        [NativeTypeName("#define READ_COPY_NUMBER_BYPASS_CACHE_FLAG 0x00000100")]
        public const int READ_COPY_NUMBER_BYPASS_CACHE_FLAG = 0x00000100;

        [NativeTypeName("#define STORAGE_COUNTERS_VERSION_V1 sizeof(STORAGE_COUNTERS)")]
        public const uint STORAGE_COUNTERS_VERSION_V1 = unchecked(32);

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REQUEST_FLAG_CONTROLLER 0x00000001")]
        public const int STORAGE_HW_FIRMWARE_REQUEST_FLAG_CONTROLLER = 0x00000001;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REQUEST_FLAG_LAST_SEGMENT 0x00000002")]
        public const int STORAGE_HW_FIRMWARE_REQUEST_FLAG_LAST_SEGMENT = 0x00000002;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REQUEST_FLAG_FIRST_SEGMENT 0x00000004")]
        public const int STORAGE_HW_FIRMWARE_REQUEST_FLAG_FIRST_SEGMENT = 0x00000004;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REQUEST_FLAG_SWITCH_TO_EXISTING_FIRMWARE 0x80000000")]
        public const uint STORAGE_HW_FIRMWARE_REQUEST_FLAG_SWITCH_TO_EXISTING_FIRMWARE = 0x80000000;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_INVALID_SLOT 0xFF")]
        public const int STORAGE_HW_FIRMWARE_INVALID_SLOT = 0xFF;

        [NativeTypeName("#define STORAGE_HW_FIRMWARE_REVISION_LENGTH 16")]
        public const int STORAGE_HW_FIRMWARE_REVISION_LENGTH = 16;

        [NativeTypeName("#define STORAGE_PROTOCOL_STRUCTURE_VERSION 0x1")]
        public const int STORAGE_PROTOCOL_STRUCTURE_VERSION = 0x1;

        [NativeTypeName("#define STORAGE_PROTOCOL_COMMAND_FLAG_ADAPTER_REQUEST 0x80000000")]
        public const uint STORAGE_PROTOCOL_COMMAND_FLAG_ADAPTER_REQUEST = 0x80000000;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_PENDING 0x0")]
        public const int STORAGE_PROTOCOL_STATUS_PENDING = 0x0;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_SUCCESS 0x1")]
        public const int STORAGE_PROTOCOL_STATUS_SUCCESS = 0x1;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_ERROR 0x2")]
        public const int STORAGE_PROTOCOL_STATUS_ERROR = 0x2;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_INVALID_REQUEST 0x3")]
        public const int STORAGE_PROTOCOL_STATUS_INVALID_REQUEST = 0x3;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_NO_DEVICE 0x4")]
        public const int STORAGE_PROTOCOL_STATUS_NO_DEVICE = 0x4;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_BUSY 0x5")]
        public const int STORAGE_PROTOCOL_STATUS_BUSY = 0x5;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_DATA_OVERRUN 0x6")]
        public const int STORAGE_PROTOCOL_STATUS_DATA_OVERRUN = 0x6;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_INSUFFICIENT_RESOURCES 0x7")]
        public const int STORAGE_PROTOCOL_STATUS_INSUFFICIENT_RESOURCES = 0x7;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_THROTTLED_REQUEST 0x8")]
        public const int STORAGE_PROTOCOL_STATUS_THROTTLED_REQUEST = 0x8;

        [NativeTypeName("#define STORAGE_PROTOCOL_STATUS_NOT_SUPPORTED 0xFF")]
        public const int STORAGE_PROTOCOL_STATUS_NOT_SUPPORTED = 0xFF;

        [NativeTypeName("#define STORAGE_PROTOCOL_COMMAND_LENGTH_NVME 0x40")]
        public const int STORAGE_PROTOCOL_COMMAND_LENGTH_NVME = 0x40;

        [NativeTypeName("#define STORAGE_PROTOCOL_SPECIFIC_NVME_ADMIN_COMMAND 0x01")]
        public const int STORAGE_PROTOCOL_SPECIFIC_NVME_ADMIN_COMMAND = 0x01;

        [NativeTypeName("#define STORAGE_PROTOCOL_SPECIFIC_NVME_NVM_COMMAND 0x02")]
        public const int STORAGE_PROTOCOL_SPECIFIC_NVME_NVM_COMMAND = 0x02;

        [NativeTypeName("#define STORATTRIBUTE_NONE 0")]
        public const int STORATTRIBUTE_NONE = 0;

        [NativeTypeName("#define STORATTRIBUTE_MANAGEMENT_STATE 1")]
        public const int STORATTRIBUTE_MANAGEMENT_STATE = 1;

        [NativeTypeName("#define IOCTL_SCMBUS_BASE FILE_DEVICE_PERSISTENT_MEMORY")]
        public const int IOCTL_SCMBUS_BASE = 0x00000059;

        [NativeTypeName("#define IOCTL_SCMBUS_DEVICE_FUNCTION_BASE 0x0")]
        public const int IOCTL_SCMBUS_DEVICE_FUNCTION_BASE = 0x0;

        [NativeTypeName("#define IOCTL_SCM_LOGICAL_DEVICE_FUNCTION_BASE 0x300")]
        public const int IOCTL_SCM_LOGICAL_DEVICE_FUNCTION_BASE = 0x300;

        [NativeTypeName("#define IOCTL_SCM_PHYSICAL_DEVICE_FUNCTION_BASE 0x600")]
        public const int IOCTL_SCM_PHYSICAL_DEVICE_FUNCTION_BASE = 0x600;

        [NativeTypeName("#define IOCTL_SCM_BUS_GET_LOGICAL_DEVICES CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x00), METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_SCM_BUS_GET_LOGICAL_DEVICES = (((0x00000059) << 16) | ((0) << 14) | (((0x0 + 0x00)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_BUS_GET_PHYSICAL_DEVICES CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x01), METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_SCM_BUS_GET_PHYSICAL_DEVICES = (((0x00000059) << 16) | ((0) << 14) | (((0x0 + 0x01)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_BUS_GET_REGIONS CTL_CODE(IOCTL_SCMBUS_BASE, SCMBUS_FUNCTION(0x02), METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_SCM_BUS_GET_REGIONS = (((0x00000059) << 16) | ((0) << 14) | (((0x0 + 0x02)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_LD_GET_INTERLEAVE_SET CTL_CODE(IOCTL_SCMBUS_BASE, SCM_LOGICAL_DEVICE_FUNCTION(0x00), METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_SCM_LD_GET_INTERLEAVE_SET = (((0x00000059) << 16) | ((0) << 14) | (((0x300 + 0x00)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_PD_QUERY_PROPERTY CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x00), METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_SCM_PD_QUERY_PROPERTY = (((0x00000059) << 16) | ((0) << 14) | (((0x600 + 0x00)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_PD_FIRMWARE_DOWNLOAD CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x01), METHOD_BUFFERED, FILE_WRITE_ACCESS)")]
        public const int IOCTL_SCM_PD_FIRMWARE_DOWNLOAD = (((0x00000059) << 16) | (((0x0002)) << 14) | (((0x600 + 0x01)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_PD_FIRMWARE_ACTIVATE CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x02), METHOD_BUFFERED, FILE_WRITE_ACCESS)")]
        public const int IOCTL_SCM_PD_FIRMWARE_ACTIVATE = (((0x00000059) << 16) | (((0x0002)) << 14) | (((0x600 + 0x02)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_PD_PASSTHROUGH CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x03), METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_SCM_PD_PASSTHROUGH = (((0x00000059) << 16) | (((0x0001) | (0x0002)) << 14) | (((0x600 + 0x03)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_PD_UPDATE_MANAGEMENT_STATUS CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x04), METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_SCM_PD_UPDATE_MANAGEMENT_STATUS = (((0x00000059) << 16) | ((0) << 14) | (((0x600 + 0x04)) << 2) | (0));

        [NativeTypeName("#define IOCTL_SCM_PD_REINITIALIZE_MEDIA CTL_CODE(IOCTL_SCMBUS_BASE, SCM_PHYSICAL_DEVICE_FUNCTION(0x05), METHOD_BUFFERED, FILE_WRITE_ACCESS)")]
        public const int IOCTL_SCM_PD_REINITIALIZE_MEDIA = (((0x00000059) << 16) | (((0x0002)) << 14) | (((0x600 + 0x05)) << 2) | (0));

        [NativeTypeName("#define SCM_MAX_SYMLINK_LEN_IN_CHARS 256")]
        public const int SCM_MAX_SYMLINK_LEN_IN_CHARS = 256;

        [NativeTypeName("#define SCM_REGION_SPA_UNKNOWN MAXDWORD64")]
        public const ulong SCM_REGION_SPA_UNKNOWN = ((ulong)(~((ulong)(0))));

        [NativeTypeName("#define MAX_INTERFACE_CODES 8")]
        public const int MAX_INTERFACE_CODES = 8;

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

        [NativeTypeName("#define IOCTL_DISK_BASE FILE_DEVICE_DISK")]
        public const int IOCTL_DISK_BASE = 0x00000007;

        [NativeTypeName("#define IOCTL_DISK_GET_DRIVE_GEOMETRY CTL_CODE(IOCTL_DISK_BASE, 0x0000, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_GET_DRIVE_GEOMETRY = (((0x00000007) << 16) | ((0) << 14) | ((0x0000) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GET_PARTITION_INFO CTL_CODE(IOCTL_DISK_BASE, 0x0001, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_GET_PARTITION_INFO = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0001) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_SET_PARTITION_INFO CTL_CODE(IOCTL_DISK_BASE, 0x0002, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_SET_PARTITION_INFO = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0002) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GET_DRIVE_LAYOUT CTL_CODE(IOCTL_DISK_BASE, 0x0003, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_GET_DRIVE_LAYOUT = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0003) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_SET_DRIVE_LAYOUT CTL_CODE(IOCTL_DISK_BASE, 0x0004, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_SET_DRIVE_LAYOUT = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0004) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_VERIFY CTL_CODE(IOCTL_DISK_BASE, 0x0005, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_VERIFY = (((0x00000007) << 16) | ((0) << 14) | ((0x0005) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_FORMAT_TRACKS CTL_CODE(IOCTL_DISK_BASE, 0x0006, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_FORMAT_TRACKS = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0006) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_REASSIGN_BLOCKS CTL_CODE(IOCTL_DISK_BASE, 0x0007, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_REASSIGN_BLOCKS = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0007) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_PERFORMANCE CTL_CODE(IOCTL_DISK_BASE, 0x0008, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_PERFORMANCE = (((0x00000007) << 16) | ((0) << 14) | ((0x0008) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_IS_WRITABLE CTL_CODE(IOCTL_DISK_BASE, 0x0009, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_IS_WRITABLE = (((0x00000007) << 16) | ((0) << 14) | ((0x0009) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_LOGGING CTL_CODE(IOCTL_DISK_BASE, 0x000a, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_LOGGING = (((0x00000007) << 16) | ((0) << 14) | ((0x000a) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_FORMAT_TRACKS_EX CTL_CODE(IOCTL_DISK_BASE, 0x000b, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_FORMAT_TRACKS_EX = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x000b) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_HISTOGRAM_STRUCTURE CTL_CODE(IOCTL_DISK_BASE, 0x000c, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_HISTOGRAM_STRUCTURE = (((0x00000007) << 16) | ((0) << 14) | ((0x000c) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_HISTOGRAM_DATA CTL_CODE(IOCTL_DISK_BASE, 0x000d, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_HISTOGRAM_DATA = (((0x00000007) << 16) | ((0) << 14) | ((0x000d) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_HISTOGRAM_RESET CTL_CODE(IOCTL_DISK_BASE, 0x000e, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_HISTOGRAM_RESET = (((0x00000007) << 16) | ((0) << 14) | ((0x000e) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_REQUEST_STRUCTURE CTL_CODE(IOCTL_DISK_BASE, 0x000f, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_REQUEST_STRUCTURE = (((0x00000007) << 16) | ((0) << 14) | ((0x000f) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_REQUEST_DATA CTL_CODE(IOCTL_DISK_BASE, 0x0010, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_REQUEST_DATA = (((0x00000007) << 16) | ((0) << 14) | ((0x0010) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_PERFORMANCE_OFF CTL_CODE(IOCTL_DISK_BASE, 0x0018, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_PERFORMANCE_OFF = (((0x00000007) << 16) | ((0) << 14) | ((0x0018) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_CONTROLLER_NUMBER CTL_CODE(IOCTL_DISK_BASE, 0x0011, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_CONTROLLER_NUMBER = (((0x00000007) << 16) | ((0) << 14) | ((0x0011) << 2) | (0));

        [NativeTypeName("#define SMART_GET_VERSION CTL_CODE(IOCTL_DISK_BASE, 0x0020, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int SMART_GET_VERSION = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0020) << 2) | (0));

        [NativeTypeName("#define SMART_SEND_DRIVE_COMMAND CTL_CODE(IOCTL_DISK_BASE, 0x0021, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int SMART_SEND_DRIVE_COMMAND = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0021) << 2) | (0));

        [NativeTypeName("#define SMART_RCV_DRIVE_DATA CTL_CODE(IOCTL_DISK_BASE, 0x0022, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int SMART_RCV_DRIVE_DATA = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0022) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GET_PARTITION_INFO_EX CTL_CODE(IOCTL_DISK_BASE, 0x0012, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_GET_PARTITION_INFO_EX = (((0x00000007) << 16) | ((0) << 14) | ((0x0012) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_SET_PARTITION_INFO_EX CTL_CODE(IOCTL_DISK_BASE, 0x0013, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_SET_PARTITION_INFO_EX = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0013) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GET_DRIVE_LAYOUT_EX CTL_CODE(IOCTL_DISK_BASE, 0x0014, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_GET_DRIVE_LAYOUT_EX = (((0x00000007) << 16) | ((0) << 14) | ((0x0014) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_SET_DRIVE_LAYOUT_EX CTL_CODE(IOCTL_DISK_BASE, 0x0015, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_SET_DRIVE_LAYOUT_EX = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0015) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_CREATE_DISK CTL_CODE(IOCTL_DISK_BASE, 0x0016, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_CREATE_DISK = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0016) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GET_LENGTH_INFO CTL_CODE(IOCTL_DISK_BASE, 0x0017, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_GET_LENGTH_INFO = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0017) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GET_DRIVE_GEOMETRY_EX CTL_CODE(IOCTL_DISK_BASE, 0x0028, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_GET_DRIVE_GEOMETRY_EX = (((0x00000007) << 16) | ((0) << 14) | ((0x0028) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_REASSIGN_BLOCKS_EX CTL_CODE(IOCTL_DISK_BASE, 0x0029, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_REASSIGN_BLOCKS_EX = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0029) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_UPDATE_DRIVE_SIZE CTL_CODE(IOCTL_DISK_BASE, 0x0032, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_UPDATE_DRIVE_SIZE = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0032) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GROW_PARTITION CTL_CODE(IOCTL_DISK_BASE, 0x0034, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_GROW_PARTITION = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0034) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GET_CACHE_INFORMATION CTL_CODE(IOCTL_DISK_BASE, 0x0035, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_GET_CACHE_INFORMATION = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0035) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_SET_CACHE_INFORMATION CTL_CODE(IOCTL_DISK_BASE, 0x0036, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_SET_CACHE_INFORMATION = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0036) << 2) | (0));

        [NativeTypeName("#define OBSOLETE_DISK_GET_WRITE_CACHE_STATE CTL_CODE(IOCTL_DISK_BASE, 0x0037, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int OBSOLETE_DISK_GET_WRITE_CACHE_STATE = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0037) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_DELETE_DRIVE_LAYOUT CTL_CODE(IOCTL_DISK_BASE, 0x0040, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_DELETE_DRIVE_LAYOUT = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0040) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_UPDATE_PROPERTIES CTL_CODE(IOCTL_DISK_BASE, 0x0050, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_UPDATE_PROPERTIES = (((0x00000007) << 16) | ((0) << 14) | ((0x0050) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_FORMAT_DRIVE CTL_CODE(IOCTL_DISK_BASE, 0x00f3, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_FORMAT_DRIVE = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x00f3) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_SENSE_DEVICE CTL_CODE(IOCTL_DISK_BASE, 0x00f8, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_SENSE_DEVICE = (((0x00000007) << 16) | ((0) << 14) | ((0x00f8) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_CHECK_VERIFY CTL_CODE(IOCTL_DISK_BASE, 0x0200, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_CHECK_VERIFY = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0200) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_MEDIA_REMOVAL CTL_CODE(IOCTL_DISK_BASE, 0x0201, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_MEDIA_REMOVAL = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0201) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_EJECT_MEDIA CTL_CODE(IOCTL_DISK_BASE, 0x0202, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_EJECT_MEDIA = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0202) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_LOAD_MEDIA CTL_CODE(IOCTL_DISK_BASE, 0x0203, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_LOAD_MEDIA = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0203) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_RESERVE CTL_CODE(IOCTL_DISK_BASE, 0x0204, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_RESERVE = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0204) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_RELEASE CTL_CODE(IOCTL_DISK_BASE, 0x0205, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_RELEASE = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0205) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_FIND_NEW_DEVICES CTL_CODE(IOCTL_DISK_BASE, 0x0206, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_DISK_FIND_NEW_DEVICES = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0206) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_GET_MEDIA_TYPES CTL_CODE(IOCTL_DISK_BASE, 0x0300, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_GET_MEDIA_TYPES = (((0x00000007) << 16) | ((0) << 14) | ((0x0300) << 2) | (0));

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
        public const uint HISTOGRAM_BUCKET_SIZE = unchecked(8);

        [NativeTypeName("#define DISK_HISTOGRAM_SIZE sizeof(DISK_HISTOGRAM)")]
        public const uint DISK_HISTOGRAM_SIZE = unchecked(72);

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

        [NativeTypeName("#define IOCTL_DISK_GET_DISK_ATTRIBUTES CTL_CODE(IOCTL_DISK_BASE, 0x003c, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_DISK_GET_DISK_ATTRIBUTES = (((0x00000007) << 16) | ((0) << 14) | ((0x003c) << 2) | (0));

        [NativeTypeName("#define IOCTL_DISK_SET_DISK_ATTRIBUTES CTL_CODE(IOCTL_DISK_BASE, 0x003d, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_SET_DISK_ATTRIBUTES = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x003d) << 2) | (0));

        [NativeTypeName("#define DISK_ATTRIBUTE_OFFLINE 0x0000000000000001")]
        public const int DISK_ATTRIBUTE_OFFLINE = 0x0000000000000001;

        [NativeTypeName("#define DISK_ATTRIBUTE_READ_ONLY 0x0000000000000002")]
        public const int DISK_ATTRIBUTE_READ_ONLY = 0x0000000000000002;

        [NativeTypeName("#define IOCTL_DISK_RESET_SNAPSHOT_INFO CTL_CODE(IOCTL_DISK_BASE, 0x0084, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_DISK_RESET_SNAPSHOT_INFO = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0084) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_BASE FILE_DEVICE_CHANGER")]
        public const int IOCTL_CHANGER_BASE = 0x00000030;

        [NativeTypeName("#define IOCTL_CHANGER_GET_PARAMETERS CTL_CODE(IOCTL_CHANGER_BASE, 0x0000, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_CHANGER_GET_PARAMETERS = (((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0000) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_GET_STATUS CTL_CODE(IOCTL_CHANGER_BASE, 0x0001, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_CHANGER_GET_STATUS = (((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0001) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_GET_PRODUCT_DATA CTL_CODE(IOCTL_CHANGER_BASE, 0x0002, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_CHANGER_GET_PRODUCT_DATA = (((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0002) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_SET_ACCESS CTL_CODE(IOCTL_CHANGER_BASE, 0x0004, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_CHANGER_SET_ACCESS = (((0x00000030) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0004) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_GET_ELEMENT_STATUS CTL_CODE(IOCTL_CHANGER_BASE, 0x0005, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_CHANGER_GET_ELEMENT_STATUS = (((0x00000030) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0005) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_INITIALIZE_ELEMENT_STATUS CTL_CODE(IOCTL_CHANGER_BASE, 0x0006, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_CHANGER_INITIALIZE_ELEMENT_STATUS = (((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0006) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_SET_POSITION CTL_CODE(IOCTL_CHANGER_BASE, 0x0007, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_CHANGER_SET_POSITION = (((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0007) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_EXCHANGE_MEDIUM CTL_CODE(IOCTL_CHANGER_BASE, 0x0008, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_CHANGER_EXCHANGE_MEDIUM = (((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0008) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_MOVE_MEDIUM CTL_CODE(IOCTL_CHANGER_BASE, 0x0009, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_CHANGER_MOVE_MEDIUM = (((0x00000030) << 16) | (((0x0001)) << 14) | ((0x0009) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_REINITIALIZE_TRANSPORT CTL_CODE(IOCTL_CHANGER_BASE, 0x000A, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int IOCTL_CHANGER_REINITIALIZE_TRANSPORT = (((0x00000030) << 16) | (((0x0001)) << 14) | ((0x000A) << 2) | (0));

        [NativeTypeName("#define IOCTL_CHANGER_QUERY_VOLUME_TAGS CTL_CODE(IOCTL_CHANGER_BASE, 0x000B, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_CHANGER_QUERY_VOLUME_TAGS = (((0x00000030) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x000B) << 2) | (0));

        [NativeTypeName("#define MAX_VOLUME_ID_SIZE 36")]
        public const int MAX_VOLUME_ID_SIZE = 36;

        [NativeTypeName("#define MAX_VOLUME_TEMPLATE_SIZE 40")]
        public const int MAX_VOLUME_TEMPLATE_SIZE = 40;

        [NativeTypeName("#define VENDOR_ID_LENGTH 8")]
        public const int VENDOR_ID_LENGTH = 8;

        [NativeTypeName("#define PRODUCT_ID_LENGTH 16")]
        public const int PRODUCT_ID_LENGTH = 16;

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

        [NativeTypeName("#define ERROR_LABEL_UNREADABLE 0x00000001")]
        public const int ERROR_LABEL_UNREADABLE = 0x00000001;

        [NativeTypeName("#define ERROR_LABEL_QUESTIONABLE 0x00000002")]
        public const int ERROR_LABEL_QUESTIONABLE = 0x00000002;

        [NativeTypeName("#define ERROR_SLOT_NOT_PRESENT 0x00000004")]
        public const int ERROR_SLOT_NOT_PRESENT = 0x00000004;

        [NativeTypeName("#define ERROR_DRIVE_NOT_INSTALLED 0x00000008")]
        public const int ERROR_DRIVE_NOT_INSTALLED = 0x00000008;

        [NativeTypeName("#define ERROR_TRAY_MALFUNCTION 0x00000010")]
        public const int ERROR_TRAY_MALFUNCTION = 0x00000010;

        [NativeTypeName("#define ERROR_INIT_STATUS_NEEDED 0x00000011")]
        public const int ERROR_INIT_STATUS_NEEDED = 0x00000011;

        [NativeTypeName("#define ERROR_UNHANDLED_ERROR 0xFFFFFFFF")]
        public const uint ERROR_UNHANDLED_ERROR = 0xFFFFFFFF;

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

        [NativeTypeName("#define IOCTL_SERIAL_LSRMST_INSERT CTL_CODE(FILE_DEVICE_SERIAL_PORT,31,METHOD_BUFFERED,FILE_ANY_ACCESS)")]
        public const int IOCTL_SERIAL_LSRMST_INSERT = (((0x0000001b) << 16) | ((0) << 14) | ((31) << 2) | (0));

        [NativeTypeName("#define IOCTL_SERENUM_EXPOSE_HARDWARE CTL_CODE(FILE_DEVICE_SERENUM,128,METHOD_BUFFERED,FILE_ANY_ACCESS)")]
        public const int IOCTL_SERENUM_EXPOSE_HARDWARE = (((0x00000037) << 16) | ((0) << 14) | ((128) << 2) | (0));

        [NativeTypeName("#define IOCTL_SERENUM_REMOVE_HARDWARE CTL_CODE(FILE_DEVICE_SERENUM,129,METHOD_BUFFERED,FILE_ANY_ACCESS)")]
        public const int IOCTL_SERENUM_REMOVE_HARDWARE = (((0x00000037) << 16) | ((0) << 14) | ((129) << 2) | (0));

        [NativeTypeName("#define IOCTL_SERENUM_PORT_DESC CTL_CODE(FILE_DEVICE_SERENUM,130,METHOD_BUFFERED,FILE_ANY_ACCESS)")]
        public const int IOCTL_SERENUM_PORT_DESC = (((0x00000037) << 16) | ((0) << 14) | ((130) << 2) | (0));

        [NativeTypeName("#define IOCTL_SERENUM_GET_PORT_NAME CTL_CODE(FILE_DEVICE_SERENUM,131,METHOD_BUFFERED,FILE_ANY_ACCESS)")]
        public const int IOCTL_SERENUM_GET_PORT_NAME = (((0x00000037) << 16) | ((0) << 14) | ((131) << 2) | (0));

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

        [NativeTypeName("#define FSCTL_REQUEST_OPLOCK_LEVEL_1 CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  0, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_REQUEST_OPLOCK_LEVEL_1 = (((0x00000009) << 16) | ((0) << 14) | ((0) << 2) | (0));

        [NativeTypeName("#define FSCTL_REQUEST_OPLOCK_LEVEL_2 CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  1, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_REQUEST_OPLOCK_LEVEL_2 = (((0x00000009) << 16) | ((0) << 14) | ((1) << 2) | (0));

        [NativeTypeName("#define FSCTL_REQUEST_BATCH_OPLOCK CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  2, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_REQUEST_BATCH_OPLOCK = (((0x00000009) << 16) | ((0) << 14) | ((2) << 2) | (0));

        [NativeTypeName("#define FSCTL_OPLOCK_BREAK_ACKNOWLEDGE CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  3, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_OPLOCK_BREAK_ACKNOWLEDGE = (((0x00000009) << 16) | ((0) << 14) | ((3) << 2) | (0));

        [NativeTypeName("#define FSCTL_OPBATCH_ACK_CLOSE_PENDING CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  4, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_OPBATCH_ACK_CLOSE_PENDING = (((0x00000009) << 16) | ((0) << 14) | ((4) << 2) | (0));

        [NativeTypeName("#define FSCTL_OPLOCK_BREAK_NOTIFY CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  5, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_OPLOCK_BREAK_NOTIFY = (((0x00000009) << 16) | ((0) << 14) | ((5) << 2) | (0));

        [NativeTypeName("#define FSCTL_LOCK_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  6, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_LOCK_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((6) << 2) | (0));

        [NativeTypeName("#define FSCTL_UNLOCK_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  7, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_UNLOCK_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((7) << 2) | (0));

        [NativeTypeName("#define FSCTL_DISMOUNT_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM,  8, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_DISMOUNT_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((8) << 2) | (0));

        [NativeTypeName("#define FSCTL_IS_VOLUME_MOUNTED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 10, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_IS_VOLUME_MOUNTED = (((0x00000009) << 16) | ((0) << 14) | ((10) << 2) | (0));

        [NativeTypeName("#define FSCTL_IS_PATHNAME_VALID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 11, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_IS_PATHNAME_VALID = (((0x00000009) << 16) | ((0) << 14) | ((11) << 2) | (0));

        [NativeTypeName("#define FSCTL_MARK_VOLUME_DIRTY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 12, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_MARK_VOLUME_DIRTY = (((0x00000009) << 16) | ((0) << 14) | ((12) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_RETRIEVAL_POINTERS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 14,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_RETRIEVAL_POINTERS = (((0x00000009) << 16) | ((0) << 14) | ((14) << 2) | (3));

        [NativeTypeName("#define FSCTL_GET_COMPRESSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 15, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_COMPRESSION = (((0x00000009) << 16) | ((0) << 14) | ((15) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_COMPRESSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 16, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA)")]
        public const int FSCTL_SET_COMPRESSION = (((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((16) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_BOOTLOADER_ACCESSED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 19,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_BOOTLOADER_ACCESSED = (((0x00000009) << 16) | ((0) << 14) | ((19) << 2) | (3));

        [NativeTypeName("#define FSCTL_MARK_AS_SYSTEM_HIVE FSCTL_SET_BOOTLOADER_ACCESSED")]
        public const int FSCTL_MARK_AS_SYSTEM_HIVE = (((0x00000009) << 16) | ((0) << 14) | ((19) << 2) | (3));

        [NativeTypeName("#define FSCTL_OPLOCK_BREAK_ACK_NO_2 CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 20, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_OPLOCK_BREAK_ACK_NO_2 = (((0x00000009) << 16) | ((0) << 14) | ((20) << 2) | (0));

        [NativeTypeName("#define FSCTL_INVALIDATE_VOLUMES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 21, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_INVALIDATE_VOLUMES = (((0x00000009) << 16) | ((0) << 14) | ((21) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_FAT_BPB CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 22, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_FAT_BPB = (((0x00000009) << 16) | ((0) << 14) | ((22) << 2) | (0));

        [NativeTypeName("#define FSCTL_REQUEST_FILTER_OPLOCK CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 23, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_REQUEST_FILTER_OPLOCK = (((0x00000009) << 16) | ((0) << 14) | ((23) << 2) | (0));

        [NativeTypeName("#define FSCTL_FILESYSTEM_GET_STATISTICS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 24, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_FILESYSTEM_GET_STATISTICS = (((0x00000009) << 16) | ((0) << 14) | ((24) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_NTFS_VOLUME_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 25, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_NTFS_VOLUME_DATA = (((0x00000009) << 16) | ((0) << 14) | ((25) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_NTFS_FILE_RECORD CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 26, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_NTFS_FILE_RECORD = (((0x00000009) << 16) | ((0) << 14) | ((26) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_VOLUME_BITMAP CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 27,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_VOLUME_BITMAP = (((0x00000009) << 16) | ((0) << 14) | ((27) << 2) | (3));

        [NativeTypeName("#define FSCTL_GET_RETRIEVAL_POINTERS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 28,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_RETRIEVAL_POINTERS = (((0x00000009) << 16) | ((0) << 14) | ((28) << 2) | (3));

        [NativeTypeName("#define FSCTL_MOVE_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 29, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_MOVE_FILE = (((0x00000009) << 16) | (((0)) << 14) | ((29) << 2) | (0));

        [NativeTypeName("#define FSCTL_IS_VOLUME_DIRTY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 30, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_IS_VOLUME_DIRTY = (((0x00000009) << 16) | ((0) << 14) | ((30) << 2) | (0));

        [NativeTypeName("#define FSCTL_ALLOW_EXTENDED_DASD_IO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 32, METHOD_NEITHER,  FILE_ANY_ACCESS)")]
        public const int FSCTL_ALLOW_EXTENDED_DASD_IO = (((0x00000009) << 16) | ((0) << 14) | ((32) << 2) | (3));

        [NativeTypeName("#define FSCTL_FIND_FILES_BY_SID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 35, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_FIND_FILES_BY_SID = (((0x00000009) << 16) | ((0) << 14) | ((35) << 2) | (3));

        [NativeTypeName("#define FSCTL_SET_OBJECT_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 38, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SET_OBJECT_ID = (((0x00000009) << 16) | (((0)) << 14) | ((38) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_OBJECT_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 39, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_OBJECT_ID = (((0x00000009) << 16) | ((0) << 14) | ((39) << 2) | (0));

        [NativeTypeName("#define FSCTL_DELETE_OBJECT_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 40, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_DELETE_OBJECT_ID = (((0x00000009) << 16) | (((0)) << 14) | ((40) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_REPARSE_POINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 41, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SET_REPARSE_POINT = (((0x00000009) << 16) | (((0)) << 14) | ((41) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_REPARSE_POINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 42, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_REPARSE_POINT = (((0x00000009) << 16) | ((0) << 14) | ((42) << 2) | (0));

        [NativeTypeName("#define FSCTL_DELETE_REPARSE_POINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 43, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_DELETE_REPARSE_POINT = (((0x00000009) << 16) | (((0)) << 14) | ((43) << 2) | (0));

        [NativeTypeName("#define FSCTL_ENUM_USN_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 44,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_ENUM_USN_DATA = (((0x00000009) << 16) | ((0) << 14) | ((44) << 2) | (3));

        [NativeTypeName("#define FSCTL_SECURITY_ID_CHECK CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 45,  METHOD_NEITHER, FILE_READ_DATA)")]
        public const int FSCTL_SECURITY_ID_CHECK = (((0x00000009) << 16) | (((0x0001)) << 14) | ((45) << 2) | (3));

        [NativeTypeName("#define FSCTL_READ_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 46,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_READ_USN_JOURNAL = (((0x00000009) << 16) | ((0) << 14) | ((46) << 2) | (3));

        [NativeTypeName("#define FSCTL_SET_OBJECT_ID_EXTENDED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 47, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SET_OBJECT_ID_EXTENDED = (((0x00000009) << 16) | (((0)) << 14) | ((47) << 2) | (0));

        [NativeTypeName("#define FSCTL_CREATE_OR_GET_OBJECT_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 48, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CREATE_OR_GET_OBJECT_ID = (((0x00000009) << 16) | ((0) << 14) | ((48) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_SPARSE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 49, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SET_SPARSE = (((0x00000009) << 16) | (((0)) << 14) | ((49) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_ZERO_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 50, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_SET_ZERO_DATA = (((0x00000009) << 16) | (((0x0002)) << 14) | ((50) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_ALLOCATED_RANGES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 51,  METHOD_NEITHER, FILE_READ_DATA)")]
        public const int FSCTL_QUERY_ALLOCATED_RANGES = (((0x00000009) << 16) | (((0x0001)) << 14) | ((51) << 2) | (3));

        [NativeTypeName("#define FSCTL_ENABLE_UPGRADE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 52, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_ENABLE_UPGRADE = (((0x00000009) << 16) | (((0x0002)) << 14) | ((52) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_ENCRYPTION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 53,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_ENCRYPTION = (((0x00000009) << 16) | ((0) << 14) | ((53) << 2) | (3));

        [NativeTypeName("#define FSCTL_ENCRYPTION_FSCTL_IO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 54,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_ENCRYPTION_FSCTL_IO = (((0x00000009) << 16) | ((0) << 14) | ((54) << 2) | (3));

        [NativeTypeName("#define FSCTL_WRITE_RAW_ENCRYPTED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 55,  METHOD_NEITHER, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_WRITE_RAW_ENCRYPTED = (((0x00000009) << 16) | (((0)) << 14) | ((55) << 2) | (3));

        [NativeTypeName("#define FSCTL_READ_RAW_ENCRYPTED CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 56,  METHOD_NEITHER, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_READ_RAW_ENCRYPTED = (((0x00000009) << 16) | (((0)) << 14) | ((56) << 2) | (3));

        [NativeTypeName("#define FSCTL_CREATE_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 57,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_CREATE_USN_JOURNAL = (((0x00000009) << 16) | ((0) << 14) | ((57) << 2) | (3));

        [NativeTypeName("#define FSCTL_READ_FILE_USN_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 58,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_READ_FILE_USN_DATA = (((0x00000009) << 16) | ((0) << 14) | ((58) << 2) | (3));

        [NativeTypeName("#define FSCTL_WRITE_USN_CLOSE_RECORD CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 59,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_WRITE_USN_CLOSE_RECORD = (((0x00000009) << 16) | ((0) << 14) | ((59) << 2) | (3));

        [NativeTypeName("#define FSCTL_EXTEND_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 60, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_EXTEND_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((60) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 61, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_USN_JOURNAL = (((0x00000009) << 16) | ((0) << 14) | ((61) << 2) | (0));

        [NativeTypeName("#define FSCTL_DELETE_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 62, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_DELETE_USN_JOURNAL = (((0x00000009) << 16) | ((0) << 14) | ((62) << 2) | (0));

        [NativeTypeName("#define FSCTL_MARK_HANDLE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 63, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_MARK_HANDLE = (((0x00000009) << 16) | ((0) << 14) | ((63) << 2) | (0));

        [NativeTypeName("#define FSCTL_SIS_COPYFILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 64, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SIS_COPYFILE = (((0x00000009) << 16) | ((0) << 14) | ((64) << 2) | (0));

        [NativeTypeName("#define FSCTL_SIS_LINK_FILES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 65, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA)")]
        public const int FSCTL_SIS_LINK_FILES = (((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((65) << 2) | (0));

        [NativeTypeName("#define FSCTL_RECALL_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 69, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_RECALL_FILE = (((0x00000009) << 16) | ((0) << 14) | ((69) << 2) | (3));

        [NativeTypeName("#define FSCTL_READ_FROM_PLEX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 71, METHOD_OUT_DIRECT, FILE_READ_DATA)")]
        public const int FSCTL_READ_FROM_PLEX = (((0x00000009) << 16) | (((0x0001)) << 14) | ((71) << 2) | (2));

        [NativeTypeName("#define FSCTL_FILE_PREFETCH CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 72, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_FILE_PREFETCH = (((0x00000009) << 16) | (((0)) << 14) | ((72) << 2) | (0));

        [NativeTypeName("#define FSCTL_MAKE_MEDIA_COMPATIBLE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 76, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_MAKE_MEDIA_COMPATIBLE = (((0x00000009) << 16) | (((0x0002)) << 14) | ((76) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_DEFECT_MANAGEMENT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 77, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_SET_DEFECT_MANAGEMENT = (((0x00000009) << 16) | (((0x0002)) << 14) | ((77) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_SPARING_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 78, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_SPARING_INFO = (((0x00000009) << 16) | ((0) << 14) | ((78) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_ON_DISK_VOLUME_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 79, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_ON_DISK_VOLUME_INFO = (((0x00000009) << 16) | ((0) << 14) | ((79) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_VOLUME_COMPRESSION_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 80, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SET_VOLUME_COMPRESSION_STATE = (((0x00000009) << 16) | (((0)) << 14) | ((80) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_MODIFY_RM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 81, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_MODIFY_RM = (((0x00000009) << 16) | (((0x0002)) << 14) | ((81) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_QUERY_RM_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 82, METHOD_BUFFERED, FILE_READ_DATA)")]
        public const int FSCTL_TXFS_QUERY_RM_INFORMATION = (((0x00000009) << 16) | (((0x0001)) << 14) | ((82) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_ROLLFORWARD_REDO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 84, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_ROLLFORWARD_REDO = (((0x00000009) << 16) | (((0x0002)) << 14) | ((84) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_ROLLFORWARD_UNDO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 85, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_ROLLFORWARD_UNDO = (((0x00000009) << 16) | (((0x0002)) << 14) | ((85) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_START_RM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 86, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_START_RM = (((0x00000009) << 16) | (((0x0002)) << 14) | ((86) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_SHUTDOWN_RM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 87, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_SHUTDOWN_RM = (((0x00000009) << 16) | (((0x0002)) << 14) | ((87) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_READ_BACKUP_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 88, METHOD_BUFFERED, FILE_READ_DATA)")]
        public const int FSCTL_TXFS_READ_BACKUP_INFORMATION = (((0x00000009) << 16) | (((0x0001)) << 14) | ((88) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_WRITE_BACKUP_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 89, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_WRITE_BACKUP_INFORMATION = (((0x00000009) << 16) | (((0x0002)) << 14) | ((89) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_CREATE_SECONDARY_RM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 90, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_CREATE_SECONDARY_RM = (((0x00000009) << 16) | (((0x0002)) << 14) | ((90) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_GET_METADATA_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 91, METHOD_BUFFERED, FILE_READ_DATA)")]
        public const int FSCTL_TXFS_GET_METADATA_INFO = (((0x00000009) << 16) | (((0x0001)) << 14) | ((91) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_GET_TRANSACTED_VERSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 92, METHOD_BUFFERED, FILE_READ_DATA)")]
        public const int FSCTL_TXFS_GET_TRANSACTED_VERSION = (((0x00000009) << 16) | (((0x0001)) << 14) | ((92) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_SAVEPOINT_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 94, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_SAVEPOINT_INFORMATION = (((0x00000009) << 16) | (((0x0002)) << 14) | ((94) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_CREATE_MINIVERSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 95, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_TXFS_CREATE_MINIVERSION = (((0x00000009) << 16) | (((0x0002)) << 14) | ((95) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_TRANSACTION_ACTIVE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 99, METHOD_BUFFERED, FILE_READ_DATA)")]
        public const int FSCTL_TXFS_TRANSACTION_ACTIVE = (((0x00000009) << 16) | (((0x0001)) << 14) | ((99) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_ZERO_ON_DEALLOCATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 101, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SET_ZERO_ON_DEALLOCATION = (((0x00000009) << 16) | (((0)) << 14) | ((101) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_REPAIR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 102, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_REPAIR = (((0x00000009) << 16) | ((0) << 14) | ((102) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_REPAIR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 103, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_REPAIR = (((0x00000009) << 16) | ((0) << 14) | ((103) << 2) | (0));

        [NativeTypeName("#define FSCTL_WAIT_FOR_REPAIR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 104, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_WAIT_FOR_REPAIR = (((0x00000009) << 16) | ((0) << 14) | ((104) << 2) | (0));

        [NativeTypeName("#define FSCTL_INITIATE_REPAIR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 106, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_INITIATE_REPAIR = (((0x00000009) << 16) | ((0) << 14) | ((106) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSC_INTERNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 107, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSC_INTERNAL = (((0x00000009) << 16) | ((0) << 14) | ((107) << 2) | (3));

        [NativeTypeName("#define FSCTL_SHRINK_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 108, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SHRINK_VOLUME = (((0x00000009) << 16) | (((0)) << 14) | ((108) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_SHORT_NAME_BEHAVIOR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 109, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_SHORT_NAME_BEHAVIOR = (((0x00000009) << 16) | ((0) << 14) | ((109) << 2) | (0));

        [NativeTypeName("#define FSCTL_DFSR_SET_GHOST_HANDLE_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 110, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_DFSR_SET_GHOST_HANDLE_STATE = (((0x00000009) << 16) | ((0) << 14) | ((110) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_LIST_TRANSACTION_LOCKED_FILES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 120, METHOD_BUFFERED, FILE_READ_DATA)")]
        public const int FSCTL_TXFS_LIST_TRANSACTION_LOCKED_FILES = (((0x00000009) << 16) | (((0x0001)) << 14) | ((120) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_LIST_TRANSACTIONS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 121, METHOD_BUFFERED, FILE_READ_DATA)")]
        public const int FSCTL_TXFS_LIST_TRANSACTIONS = (((0x00000009) << 16) | (((0x0001)) << 14) | ((121) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_PAGEFILE_ENCRYPTION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 122, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_PAGEFILE_ENCRYPTION = (((0x00000009) << 16) | ((0) << 14) | ((122) << 2) | (0));

        [NativeTypeName("#define FSCTL_RESET_VOLUME_ALLOCATION_HINTS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 123, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_RESET_VOLUME_ALLOCATION_HINTS = (((0x00000009) << 16) | ((0) << 14) | ((123) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_DEPENDENT_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 124, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_DEPENDENT_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((124) << 2) | (0));

        [NativeTypeName("#define FSCTL_SD_GLOBAL_CHANGE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 125, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SD_GLOBAL_CHANGE = (((0x00000009) << 16) | ((0) << 14) | ((125) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_READ_BACKUP_INFORMATION2 CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 126, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_TXFS_READ_BACKUP_INFORMATION2 = (((0x00000009) << 16) | ((0) << 14) | ((126) << 2) | (0));

        [NativeTypeName("#define FSCTL_LOOKUP_STREAM_FROM_CLUSTER CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 127, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_LOOKUP_STREAM_FROM_CLUSTER = (((0x00000009) << 16) | ((0) << 14) | ((127) << 2) | (0));

        [NativeTypeName("#define FSCTL_TXFS_WRITE_BACKUP_INFORMATION2 CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 128, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_TXFS_WRITE_BACKUP_INFORMATION2 = (((0x00000009) << 16) | ((0) << 14) | ((128) << 2) | (0));

        [NativeTypeName("#define FSCTL_FILE_TYPE_NOTIFICATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 129, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_FILE_TYPE_NOTIFICATION = (((0x00000009) << 16) | ((0) << 14) | ((129) << 2) | (0));

        [NativeTypeName("#define FSCTL_FILE_LEVEL_TRIM CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 130, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_FILE_LEVEL_TRIM = (((0x00000009) << 16) | (((0x0002)) << 14) | ((130) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_BOOT_AREA_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 140, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_BOOT_AREA_INFO = (((0x00000009) << 16) | ((0) << 14) | ((140) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_RETRIEVAL_POINTER_BASE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 141, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_RETRIEVAL_POINTER_BASE = (((0x00000009) << 16) | ((0) << 14) | ((141) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_PERSISTENT_VOLUME_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 142, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_PERSISTENT_VOLUME_STATE = (((0x00000009) << 16) | ((0) << 14) | ((142) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_PERSISTENT_VOLUME_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 143, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_PERSISTENT_VOLUME_STATE = (((0x00000009) << 16) | ((0) << 14) | ((143) << 2) | (0));

        [NativeTypeName("#define FSCTL_REQUEST_OPLOCK CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 144, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_REQUEST_OPLOCK = (((0x00000009) << 16) | ((0) << 14) | ((144) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 145, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_TUNNEL_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((145) << 2) | (0));

        [NativeTypeName("#define FSCTL_IS_CSV_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 146, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_IS_CSV_FILE = (((0x00000009) << 16) | ((0) << 14) | ((146) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_FILE_SYSTEM_RECOGNITION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 147, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_FILE_SYSTEM_RECOGNITION = (((0x00000009) << 16) | ((0) << 14) | ((147) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_GET_VOLUME_PATH_NAME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 148, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_GET_VOLUME_PATH_NAME = (((0x00000009) << 16) | ((0) << 14) | ((148) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_GET_VOLUME_NAME_FOR_VOLUME_MOUNT_POINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 149, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_GET_VOLUME_NAME_FOR_VOLUME_MOUNT_POINT = (((0x00000009) << 16) | ((0) << 14) | ((149) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_GET_VOLUME_PATH_NAMES_FOR_VOLUME_NAME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 150,  METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_GET_VOLUME_PATH_NAMES_FOR_VOLUME_NAME = (((0x00000009) << 16) | ((0) << 14) | ((150) << 2) | (0));

        [NativeTypeName("#define FSCTL_IS_FILE_ON_CSV_VOLUME CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 151,  METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_IS_FILE_ON_CSV_VOLUME = (((0x00000009) << 16) | ((0) << 14) | ((151) << 2) | (0));

        [NativeTypeName("#define FSCTL_CORRUPTION_HANDLING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 152, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CORRUPTION_HANDLING = (((0x00000009) << 16) | ((0) << 14) | ((152) << 2) | (0));

        [NativeTypeName("#define FSCTL_OFFLOAD_READ CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 153, METHOD_BUFFERED, FILE_READ_ACCESS)")]
        public const int FSCTL_OFFLOAD_READ = (((0x00000009) << 16) | (((0x0001)) << 14) | ((153) << 2) | (0));

        [NativeTypeName("#define FSCTL_OFFLOAD_WRITE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 154, METHOD_BUFFERED, FILE_WRITE_ACCESS)")]
        public const int FSCTL_OFFLOAD_WRITE = (((0x00000009) << 16) | (((0x0002)) << 14) | ((154) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_INTERNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 155,  METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_INTERNAL = (((0x00000009) << 16) | ((0) << 14) | ((155) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_PURGE_FAILURE_MODE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 156, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_PURGE_FAILURE_MODE = (((0x00000009) << 16) | ((0) << 14) | ((156) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_FILE_LAYOUT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 157, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_FILE_LAYOUT = (((0x00000009) << 16) | ((0) << 14) | ((157) << 2) | (3));

        [NativeTypeName("#define FSCTL_IS_VOLUME_OWNED_BYCSVFS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 158,  METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_IS_VOLUME_OWNED_BYCSVFS = (((0x00000009) << 16) | ((0) << 14) | ((158) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_INTEGRITY_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 159, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_INTEGRITY_INFORMATION = (((0x00000009) << 16) | ((0) << 14) | ((159) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_INTEGRITY_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 160, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA)")]
        public const int FSCTL_SET_INTEGRITY_INFORMATION = (((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((160) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_FILE_REGIONS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 161, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_FILE_REGIONS = (((0x00000009) << 16) | ((0) << 14) | ((161) << 2) | (0));

        [NativeTypeName("#define FSCTL_RKF_INTERNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 171, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_RKF_INTERNAL = (((0x00000009) << 16) | ((0) << 14) | ((171) << 2) | (3));

        [NativeTypeName("#define FSCTL_SCRUB_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 172, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SCRUB_DATA = (((0x00000009) << 16) | ((0) << 14) | ((172) << 2) | (0));

        [NativeTypeName("#define FSCTL_REPAIR_COPIES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 173, METHOD_BUFFERED, FILE_READ_DATA | FILE_WRITE_DATA)")]
        public const int FSCTL_REPAIR_COPIES = (((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((173) << 2) | (0));

        [NativeTypeName("#define FSCTL_DISABLE_LOCAL_BUFFERING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 174, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_DISABLE_LOCAL_BUFFERING = (((0x00000009) << 16) | ((0) << 14) | ((174) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_MGMT_LOCK CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 175, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_MGMT_LOCK = (((0x00000009) << 16) | ((0) << 14) | ((175) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_QUERY_DOWN_LEVEL_FILE_SYSTEM_CHARACTERISTICS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 176, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_QUERY_DOWN_LEVEL_FILE_SYSTEM_CHARACTERISTICS = (((0x00000009) << 16) | ((0) << 14) | ((176) << 2) | (0));

        [NativeTypeName("#define FSCTL_ADVANCE_FILE_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 177, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_ADVANCE_FILE_ID = (((0x00000009) << 16) | ((0) << 14) | ((177) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_SYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 178, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_SYNC_TUNNEL_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((178) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_QUERY_VETO_FILE_DIRECT_IO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 179, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_QUERY_VETO_FILE_DIRECT_IO = (((0x00000009) << 16) | ((0) << 14) | ((179) << 2) | (0));

        [NativeTypeName("#define FSCTL_WRITE_USN_REASON CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 180, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_WRITE_USN_REASON = (((0x00000009) << 16) | ((0) << 14) | ((180) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_CONTROL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 181, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_CONTROL = (((0x00000009) << 16) | ((0) << 14) | ((181) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_REFS_VOLUME_DATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 182, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_REFS_VOLUME_DATA = (((0x00000009) << 16) | ((0) << 14) | ((182) << 2) | (0));

        [NativeTypeName("#define FSCTL_CSV_H_BREAKING_SYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 185, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CSV_H_BREAKING_SYNC_TUNNEL_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((185) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_STORAGE_CLASSES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 187, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_STORAGE_CLASSES = (((0x00000009) << 16) | ((0) << 14) | ((187) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_REGION_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 188, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_REGION_INFO = (((0x00000009) << 16) | ((0) << 14) | ((188) << 2) | (0));

        [NativeTypeName("#define FSCTL_USN_TRACK_MODIFIED_RANGES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 189, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_USN_TRACK_MODIFIED_RANGES = (((0x00000009) << 16) | ((0) << 14) | ((189) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_SHARED_VIRTUAL_DISK_SUPPORT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 192, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_SHARED_VIRTUAL_DISK_SUPPORT = (((0x00000009) << 16) | ((0) << 14) | ((192) << 2) | (0));

        [NativeTypeName("#define FSCTL_SVHDX_SYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 193, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SVHDX_SYNC_TUNNEL_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((193) << 2) | (0));

        [NativeTypeName("#define FSCTL_SVHDX_SET_INITIATOR_INFORMATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 194, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SVHDX_SET_INITIATOR_INFORMATION = (((0x00000009) << 16) | ((0) << 14) | ((194) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_EXTERNAL_BACKING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 195, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SET_EXTERNAL_BACKING = (((0x00000009) << 16) | (((0)) << 14) | ((195) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_EXTERNAL_BACKING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 196, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_EXTERNAL_BACKING = (((0x00000009) << 16) | ((0) << 14) | ((196) << 2) | (0));

        [NativeTypeName("#define FSCTL_DELETE_EXTERNAL_BACKING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 197, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_DELETE_EXTERNAL_BACKING = (((0x00000009) << 16) | (((0)) << 14) | ((197) << 2) | (0));

        [NativeTypeName("#define FSCTL_ENUM_EXTERNAL_BACKING CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 198, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_ENUM_EXTERNAL_BACKING = (((0x00000009) << 16) | ((0) << 14) | ((198) << 2) | (0));

        [NativeTypeName("#define FSCTL_ENUM_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 199, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_ENUM_OVERLAY = (((0x00000009) << 16) | ((0) << 14) | ((199) << 2) | (3));

        [NativeTypeName("#define FSCTL_ADD_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 204, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_ADD_OVERLAY = (((0x00000009) << 16) | (((0x0002)) << 14) | ((204) << 2) | (0));

        [NativeTypeName("#define FSCTL_REMOVE_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 205, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_REMOVE_OVERLAY = (((0x00000009) << 16) | (((0x0002)) << 14) | ((205) << 2) | (0));

        [NativeTypeName("#define FSCTL_UPDATE_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 206, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_UPDATE_OVERLAY = (((0x00000009) << 16) | (((0x0002)) << 14) | ((206) << 2) | (0));

        [NativeTypeName("#define FSCTL_SHUFFLE_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 208, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int FSCTL_SHUFFLE_FILE = (((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((208) << 2) | (0));

        [NativeTypeName("#define FSCTL_DUPLICATE_EXTENTS_TO_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 209, METHOD_BUFFERED, FILE_WRITE_DATA )")]
        public const int FSCTL_DUPLICATE_EXTENTS_TO_FILE = (((0x00000009) << 16) | (((0x0002)) << 14) | ((209) << 2) | (0));

        [NativeTypeName("#define FSCTL_SPARSE_OVERALLOCATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 211, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SPARSE_OVERALLOCATE = (((0x00000009) << 16) | (((0)) << 14) | ((211) << 2) | (0));

        [NativeTypeName("#define FSCTL_STORAGE_QOS_CONTROL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 212, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_STORAGE_QOS_CONTROL = (((0x00000009) << 16) | ((0) << 14) | ((212) << 2) | (0));

        [NativeTypeName("#define FSCTL_INITIATE_FILE_METADATA_OPTIMIZATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 215, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_INITIATE_FILE_METADATA_OPTIMIZATION = (((0x00000009) << 16) | (((0)) << 14) | ((215) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_FILE_METADATA_OPTIMIZATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 216, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_QUERY_FILE_METADATA_OPTIMIZATION = (((0x00000009) << 16) | (((0)) << 14) | ((216) << 2) | (0));

        [NativeTypeName("#define FSCTL_SVHDX_ASYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 217, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SVHDX_ASYNC_TUNNEL_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((217) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_WOF_VERSION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 218, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_WOF_VERSION = (((0x00000009) << 16) | ((0) << 14) | ((218) << 2) | (0));

        [NativeTypeName("#define FSCTL_HCS_SYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 219, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_HCS_SYNC_TUNNEL_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((219) << 2) | (0));

        [NativeTypeName("#define FSCTL_HCS_ASYNC_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 220, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_HCS_ASYNC_TUNNEL_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((220) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_EXTENT_READ_CACHE_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 221, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_EXTENT_READ_CACHE_INFO = (((0x00000009) << 16) | ((0) << 14) | ((221) << 2) | (3));

        [NativeTypeName("#define FSCTL_QUERY_REFS_VOLUME_COUNTER_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 222, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_REFS_VOLUME_COUNTER_INFO = (((0x00000009) << 16) | ((0) << 14) | ((222) << 2) | (3));

        [NativeTypeName("#define FSCTL_CLEAN_VOLUME_METADATA CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 223, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_CLEAN_VOLUME_METADATA = (((0x00000009) << 16) | ((0) << 14) | ((223) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_INTEGRITY_INFORMATION_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 224, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_INTEGRITY_INFORMATION_EX = (((0x00000009) << 16) | ((0) << 14) | ((224) << 2) | (0));

        [NativeTypeName("#define FSCTL_SUSPEND_OVERLAY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 225, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SUSPEND_OVERLAY = (((0x00000009) << 16) | ((0) << 14) | ((225) << 2) | (0));

        [NativeTypeName("#define FSCTL_VIRTUAL_STORAGE_QUERY_PROPERTY CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 226, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_VIRTUAL_STORAGE_QUERY_PROPERTY = (((0x00000009) << 16) | ((0) << 14) | ((226) << 2) | (0));

        [NativeTypeName("#define FSCTL_FILESYSTEM_GET_STATISTICS_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 227, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_FILESYSTEM_GET_STATISTICS_EX = (((0x00000009) << 16) | ((0) << 14) | ((227) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_VOLUME_CONTAINER_STATE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 228, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_VOLUME_CONTAINER_STATE = (((0x00000009) << 16) | ((0) << 14) | ((228) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_LAYER_ROOT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 229, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_LAYER_ROOT = (((0x00000009) << 16) | ((0) << 14) | ((229) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_DIRECT_ACCESS_EXTENTS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 230, METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_DIRECT_ACCESS_EXTENTS = (((0x00000009) << 16) | ((0) << 14) | ((230) << 2) | (3));

        [NativeTypeName("#define FSCTL_NOTIFY_STORAGE_SPACE_ALLOCATION CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 231, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_NOTIFY_STORAGE_SPACE_ALLOCATION = (((0x00000009) << 16) | ((0) << 14) | ((231) << 2) | (0));

        [NativeTypeName("#define FSCTL_SSDI_STORAGE_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 232, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SSDI_STORAGE_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((232) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_DIRECT_IMAGE_ORIGINAL_BASE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 233, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_DIRECT_IMAGE_ORIGINAL_BASE = (((0x00000009) << 16) | ((0) << 14) | ((233) << 2) | (0));

        [NativeTypeName("#define FSCTL_READ_UNPRIVILEGED_USN_JOURNAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 234,  METHOD_NEITHER, FILE_ANY_ACCESS)")]
        public const int FSCTL_READ_UNPRIVILEGED_USN_JOURNAL = (((0x00000009) << 16) | ((0) << 14) | ((234) << 2) | (3));

        [NativeTypeName("#define FSCTL_GHOST_FILE_EXTENTS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 235, METHOD_BUFFERED, FILE_WRITE_ACCESS)")]
        public const int FSCTL_GHOST_FILE_EXTENTS = (((0x00000009) << 16) | (((0x0002)) << 14) | ((235) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_GHOSTED_FILE_EXTENTS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 236, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_GHOSTED_FILE_EXTENTS = (((0x00000009) << 16) | ((0) << 14) | ((236) << 2) | (0));

        [NativeTypeName("#define FSCTL_UNMAP_SPACE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 237, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_UNMAP_SPACE = (((0x00000009) << 16) | ((0) << 14) | ((237) << 2) | (0));

        [NativeTypeName("#define FSCTL_HCS_SYNC_NO_WRITE_TUNNEL_REQUEST CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 238, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_HCS_SYNC_NO_WRITE_TUNNEL_REQUEST = (((0x00000009) << 16) | ((0) << 14) | ((238) << 2) | (0));

        [NativeTypeName("#define FSCTL_STREAMS_QUERY_PARAMETERS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 241, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_STREAMS_QUERY_PARAMETERS = (((0x00000009) << 16) | ((0) << 14) | ((241) << 2) | (0));

        [NativeTypeName("#define FSCTL_STREAMS_ASSOCIATE_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 242, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_STREAMS_ASSOCIATE_ID = (((0x00000009) << 16) | ((0) << 14) | ((242) << 2) | (0));

        [NativeTypeName("#define FSCTL_STREAMS_QUERY_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 243, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_STREAMS_QUERY_ID = (((0x00000009) << 16) | ((0) << 14) | ((243) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_RETRIEVAL_POINTERS_AND_REFCOUNT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 244, METHOD_NEITHER,  FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_RETRIEVAL_POINTERS_AND_REFCOUNT = (((0x00000009) << 16) | ((0) << 14) | ((244) << 2) | (3));

        [NativeTypeName("#define FSCTL_QUERY_VOLUME_NUMA_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 245, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_VOLUME_NUMA_INFO = (((0x00000009) << 16) | ((0) << 14) | ((245) << 2) | (0));

        [NativeTypeName("#define FSCTL_REFS_DEALLOCATE_RANGES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 246, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_REFS_DEALLOCATE_RANGES = (((0x00000009) << 16) | ((0) << 14) | ((246) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_REFS_SMR_VOLUME_INFO CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 247, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_REFS_SMR_VOLUME_INFO = (((0x00000009) << 16) | ((0) << 14) | ((247) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_REFS_SMR_VOLUME_GC_PARAMETERS CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 248, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_REFS_SMR_VOLUME_GC_PARAMETERS = (((0x00000009) << 16) | ((0) << 14) | ((248) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_REFS_FILE_STRICTLY_SEQUENTIAL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 249, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_REFS_FILE_STRICTLY_SEQUENTIAL = (((0x00000009) << 16) | ((0) << 14) | ((249) << 2) | (0));

        [NativeTypeName("#define FSCTL_DUPLICATE_EXTENTS_TO_FILE_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 250, METHOD_BUFFERED, FILE_WRITE_DATA)")]
        public const int FSCTL_DUPLICATE_EXTENTS_TO_FILE_EX = (((0x00000009) << 16) | (((0x0002)) << 14) | ((250) << 2) | (0));

        [NativeTypeName("#define FSCTL_QUERY_BAD_RANGES CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 251, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_QUERY_BAD_RANGES = (((0x00000009) << 16) | ((0) << 14) | ((251) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_DAX_ALLOC_ALIGNMENT_HINT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 252, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SET_DAX_ALLOC_ALIGNMENT_HINT = (((0x00000009) << 16) | ((0) << 14) | ((252) << 2) | (0));

        [NativeTypeName("#define FSCTL_DELETE_CORRUPTED_REFS_CONTAINER CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 253, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_DELETE_CORRUPTED_REFS_CONTAINER = (((0x00000009) << 16) | ((0) << 14) | ((253) << 2) | (0));

        [NativeTypeName("#define FSCTL_SCRUB_UNDISCOVERABLE_ID CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 254, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_SCRUB_UNDISCOVERABLE_ID = (((0x00000009) << 16) | ((0) << 14) | ((254) << 2) | (0));

        [NativeTypeName("#define FSCTL_NOTIFY_DATA_CHANGE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 255, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_NOTIFY_DATA_CHANGE = (((0x00000009) << 16) | ((0) << 14) | ((255) << 2) | (0));

        [NativeTypeName("#define FSCTL_START_VIRTUALIZATION_INSTANCE_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 256, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_START_VIRTUALIZATION_INSTANCE_EX = (((0x00000009) << 16) | ((0) << 14) | ((256) << 2) | (0));

        [NativeTypeName("#define FSCTL_ENCRYPTION_KEY_CONTROL CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 257, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_ENCRYPTION_KEY_CONTROL = (((0x00000009) << 16) | ((0) << 14) | ((257) << 2) | (0));

        [NativeTypeName("#define FSCTL_VIRTUAL_STORAGE_SET_BEHAVIOR CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 258, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_VIRTUAL_STORAGE_SET_BEHAVIOR = (((0x00000009) << 16) | ((0) << 14) | ((258) << 2) | (0));

        [NativeTypeName("#define FSCTL_SET_REPARSE_POINT_EX CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 259, METHOD_BUFFERED, FILE_SPECIAL_ACCESS)")]
        public const int FSCTL_SET_REPARSE_POINT_EX = (((0x00000009) << 16) | (((0)) << 14) | ((259) << 2) | (0));

        [NativeTypeName("#define FSCTL_REARRANGE_FILE CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 264, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int FSCTL_REARRANGE_FILE = (((0x00000009) << 16) | (((0x0001) | (0x0002)) << 14) | ((264) << 2) | (0));

        [NativeTypeName("#define FSCTL_VIRTUAL_STORAGE_PASSTHROUGH CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 265, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int FSCTL_VIRTUAL_STORAGE_PASSTHROUGH = (((0x00000009) << 16) | ((0) << 14) | ((265) << 2) | (0));

        [NativeTypeName("#define FSCTL_GET_RETRIEVAL_POINTER_COUNT CTL_CODE(FILE_DEVICE_FILE_SYSTEM, 266, METHOD_NEITHER,  FILE_ANY_ACCESS)")]
        public const int FSCTL_GET_RETRIEVAL_POINTER_COUNT = (((0x00000009) << 16) | ((0) << 14) | ((266) << 2) | (3));

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

        [NativeTypeName("#define MARK_HANDLE_FILTER_METADATA (0x00000200)")]
        public const int MARK_HANDLE_FILTER_METADATA = (0x00000200);

        [NativeTypeName("#define MARK_HANDLE_CLOUD_SYNC (0x00000800)")]
        public const int MARK_HANDLE_CLOUD_SYNC = (0x00000800);

        [NativeTypeName("#define MARK_HANDLE_READ_COPY (0x00000080)")]
        public const int MARK_HANDLE_READ_COPY = (0x00000080);

        [NativeTypeName("#define MARK_HANDLE_NOT_READ_COPY (0x00000100)")]
        public const int MARK_HANDLE_NOT_READ_COPY = (0x00000100);

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

        [NativeTypeName("#define FILE_PREFETCH_TYPE_FOR_CREATE 0x1")]
        public const int FILE_PREFETCH_TYPE_FOR_CREATE = 0x1;

        [NativeTypeName("#define FILE_PREFETCH_TYPE_FOR_DIRENUM 0x2")]
        public const int FILE_PREFETCH_TYPE_FOR_DIRENUM = 0x2;

        [NativeTypeName("#define FILE_PREFETCH_TYPE_FOR_CREATE_EX 0x3")]
        public const int FILE_PREFETCH_TYPE_FOR_CREATE_EX = 0x3;

        [NativeTypeName("#define FILE_PREFETCH_TYPE_FOR_DIRENUM_EX 0x4")]
        public const int FILE_PREFETCH_TYPE_FOR_DIRENUM_EX = 0x4;

        [NativeTypeName("#define FILE_PREFETCH_TYPE_MAX 0x4")]
        public const int FILE_PREFETCH_TYPE_MAX = 0x4;

        [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_NTFS 1")]
        public const int FILESYSTEM_STATISTICS_TYPE_NTFS = 1;

        [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_FAT 2")]
        public const int FILESYSTEM_STATISTICS_TYPE_FAT = 2;

        [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_EXFAT 3")]
        public const int FILESYSTEM_STATISTICS_TYPE_EXFAT = 3;

        [NativeTypeName("#define FILESYSTEM_STATISTICS_TYPE_REFS 4")]
        public const int FILESYSTEM_STATISTICS_TYPE_REFS = 4;

        [NativeTypeName("#define FILE_ZERO_DATA_INFORMATION_FLAG_PRESERVE_CACHED_DATA (0x00000001)")]
        public const int FILE_ZERO_DATA_INFORMATION_FLAG_PRESERVE_CACHED_DATA = (0x00000001);

        [NativeTypeName("#define FILE_SET_ENCRYPTION 0x00000001")]
        public const int FILE_SET_ENCRYPTION = 0x00000001;

        [NativeTypeName("#define FILE_CLEAR_ENCRYPTION 0x00000002")]
        public const int FILE_CLEAR_ENCRYPTION = 0x00000002;

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

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_IN_USE (0x0000000000000001)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_IN_USE = (0x0000000000000001);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_REUSED (0x0000000000000002)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_REUSED = (0x0000000000000002);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_EXIST (0x0000000000000004)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_EXIST = (0x0000000000000004);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_BASE_RECORD (0x0000000000000008)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_BASE_RECORD = (0x0000000000000008);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_SYSTEM_FILE (0x0000000000000010)")]
        public const int FILE_INITIATE_REPAIR_HINT1_SYSTEM_FILE = (0x0000000000000010);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_NOT_IMPLEMENTED (0x0000000000000020)")]
        public const int FILE_INITIATE_REPAIR_HINT1_NOT_IMPLEMENTED = (0x0000000000000020);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_UNABLE_TO_REPAIR (0x0000000000000040)")]
        public const int FILE_INITIATE_REPAIR_HINT1_UNABLE_TO_REPAIR = (0x0000000000000040);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_REPAIR_DISABLED (0x0000000000000080)")]
        public const int FILE_INITIATE_REPAIR_HINT1_REPAIR_DISABLED = (0x0000000000000080);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_RECURSIVELY_CORRUPTED (0x0000000000000100)")]
        public const int FILE_INITIATE_REPAIR_HINT1_RECURSIVELY_CORRUPTED = (0x0000000000000100);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ORPHAN_GENERATED (0x0000000000000200)")]
        public const int FILE_INITIATE_REPAIR_HINT1_ORPHAN_GENERATED = (0x0000000000000200);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_REPAIRED (0x0000000000000400)")]
        public const int FILE_INITIATE_REPAIR_HINT1_REPAIRED = (0x0000000000000400);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_NOTHING_WRONG (0x0000000000000800)")]
        public const int FILE_INITIATE_REPAIR_HINT1_NOTHING_WRONG = (0x0000000000000800);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_NOT_FOUND (0x0000000000001000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_NOT_FOUND = (0x0000000000001000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_POTENTIAL_CROSSLINK (0x0000000000002000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_POTENTIAL_CROSSLINK = (0x0000000000002000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_STALE_INFORMATION (0x0000000000004000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_STALE_INFORMATION = (0x0000000000004000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_CLUSTERS_ALREADY_IN_USE (0x0000000000008000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_CLUSTERS_ALREADY_IN_USE = (0x0000000000008000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_LCN_NOT_EXIST (0x0000000000010000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_LCN_NOT_EXIST = (0x0000000000010000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_RUN_LENGTH (0x0000000000020000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_INVALID_RUN_LENGTH = (0x0000000000020000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_ORPHAN (0x0000000000040000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_NOT_ORPHAN = (0x0000000000040000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_IS_BASE_RECORD (0x0000000000080000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_FILE_RECORD_IS_BASE_RECORD = (0x0000000000080000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_ARRAY_LENGTH_COUNT (0x0000000000100000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_INVALID_ARRAY_LENGTH_COUNT = (0x0000000000100000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_SID_VALID (0x0000000000200000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_SID_VALID = (0x0000000000200000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_SID_MISMATCH (0x0000000000400000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_SID_MISMATCH = (0x0000000000400000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_PARENT (0x0000000000800000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_INVALID_PARENT = (0x0000000000800000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_IN_USE (0x0000000001000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_IN_USE = (0x0000000001000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_REUSED (0x0000000002000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_REUSED = (0x0000000002000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_EXIST (0x0000000004000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_EXIST = (0x0000000004000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_BASE_RECORD (0x0000000008000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_BASE_RECORD = (0x0000000008000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_INDEX (0x0000000010000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_PARENT_FILE_RECORD_NOT_INDEX = (0x0000000010000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_VALID_INDEX_ENTRY (0x0000000020000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_VALID_INDEX_ENTRY = (0x0000000020000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_OUT_OF_GENERIC_NAMES (0x0000000040000000)")]
        public const int FILE_INITIATE_REPAIR_HINT1_OUT_OF_GENERIC_NAMES = (0x0000000040000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_OUT_OF_RESOURCE (0x0000000080000000)")]
        public const uint FILE_INITIATE_REPAIR_HINT1_OUT_OF_RESOURCE = (0x0000000080000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_LCN (0x0000000100000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_INVALID_LCN = (0x0000000100000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_VCN (0x0000000200000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_INVALID_VCN = (0x0000000200000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_NAME_CONFLICT (0x0000000400000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_NAME_CONFLICT = (0x0000000400000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ORPHAN (0x0000000800000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_ORPHAN = (0x0000000800000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_TOO_SMALL (0x0000001000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_TOO_SMALL = (0x0000001000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_NON_RESIDENT (0x0000002000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_ATTRIBUTE_NON_RESIDENT = (0x0000002000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_DENY_DEFRAG (0x0000004000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_DENY_DEFRAG = (0x0000004000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_PREVIOUS_PARENT_STILL_VALID (0x0000008000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_PREVIOUS_PARENT_STILL_VALID = (0x0000008000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INDEX_ENTRY_MISMATCH (0x0000010000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_INDEX_ENTRY_MISMATCH = (0x0000010000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_INVALID_ORPHAN_RECOVERY_NAME (0x0000020000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_INVALID_ORPHAN_RECOVERY_NAME = (0x0000020000000000);

        [NativeTypeName("#define FILE_INITIATE_REPAIR_HINT1_MULTIPLE_FILE_NAME_ATTRIBUTES (0x0000040000000000)")]
        public const long FILE_INITIATE_REPAIR_HINT1_MULTIPLE_FILE_NAME_ATTRIBUTES = (0x0000040000000000);

        [NativeTypeName("#define TXFS_RM_FLAG_LOGGING_MODE 0x00000001")]
        public const int TXFS_RM_FLAG_LOGGING_MODE = 0x00000001;

        [NativeTypeName("#define TXFS_RM_FLAG_RENAME_RM 0x00000002")]
        public const int TXFS_RM_FLAG_RENAME_RM = 0x00000002;

        [NativeTypeName("#define TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MAX 0x00000004")]
        public const int TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MAX = 0x00000004;

        [NativeTypeName("#define TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MIN 0x00000008")]
        public const int TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MIN = 0x00000008;

        [NativeTypeName("#define TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS 0x00000010")]
        public const int TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS = 0x00000010;

        [NativeTypeName("#define TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT 0x00000020")]
        public const int TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT = 0x00000020;

        [NativeTypeName("#define TXFS_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE 0x00000040")]
        public const int TXFS_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE = 0x00000040;

        [NativeTypeName("#define TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX 0x00000080")]
        public const int TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX = 0x00000080;

        [NativeTypeName("#define TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN 0x00000100")]
        public const int TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN = 0x00000100;

        [NativeTypeName("#define TXFS_RM_FLAG_GROW_LOG 0x00000400")]
        public const int TXFS_RM_FLAG_GROW_LOG = 0x00000400;

        [NativeTypeName("#define TXFS_RM_FLAG_SHRINK_LOG 0x00000800")]
        public const int TXFS_RM_FLAG_SHRINK_LOG = 0x00000800;

        [NativeTypeName("#define TXFS_RM_FLAG_ENFORCE_MINIMUM_SIZE 0x00001000")]
        public const int TXFS_RM_FLAG_ENFORCE_MINIMUM_SIZE = 0x00001000;

        [NativeTypeName("#define TXFS_RM_FLAG_PRESERVE_CHANGES 0x00002000")]
        public const int TXFS_RM_FLAG_PRESERVE_CHANGES = 0x00002000;

        [NativeTypeName("#define TXFS_RM_FLAG_RESET_RM_AT_NEXT_START 0x00004000")]
        public const int TXFS_RM_FLAG_RESET_RM_AT_NEXT_START = 0x00004000;

        [NativeTypeName("#define TXFS_RM_FLAG_DO_NOT_RESET_RM_AT_NEXT_START 0x00008000")]
        public const int TXFS_RM_FLAG_DO_NOT_RESET_RM_AT_NEXT_START = 0x00008000;

        [NativeTypeName("#define TXFS_RM_FLAG_PREFER_CONSISTENCY 0x00010000")]
        public const int TXFS_RM_FLAG_PREFER_CONSISTENCY = 0x00010000;

        [NativeTypeName("#define TXFS_RM_FLAG_PREFER_AVAILABILITY 0x00020000")]
        public const int TXFS_RM_FLAG_PREFER_AVAILABILITY = 0x00020000;

        [NativeTypeName("#define TXFS_LOGGING_MODE_SIMPLE (0x0001)")]
        public const int TXFS_LOGGING_MODE_SIMPLE = (0x0001);

        [NativeTypeName("#define TXFS_LOGGING_MODE_FULL (0x0002)")]
        public const int TXFS_LOGGING_MODE_FULL = (0x0002);

        [NativeTypeName("#define TXFS_TRANSACTION_STATE_NONE 0x00")]
        public const int TXFS_TRANSACTION_STATE_NONE = 0x00;

        [NativeTypeName("#define TXFS_TRANSACTION_STATE_ACTIVE 0x01")]
        public const int TXFS_TRANSACTION_STATE_ACTIVE = 0x01;

        [NativeTypeName("#define TXFS_TRANSACTION_STATE_PREPARED 0x02")]
        public const int TXFS_TRANSACTION_STATE_PREPARED = 0x02;

        [NativeTypeName("#define TXFS_TRANSACTION_STATE_NOTACTIVE 0x03")]
        public const int TXFS_TRANSACTION_STATE_NOTACTIVE = 0x03;

        [NativeTypeName("#define TXFS_MODIFY_RM_VALID_FLAGS (TXFS_RM_FLAG_LOGGING_MODE                          |   \\\r\n                 TXFS_RM_FLAG_RENAME_RM                             |   \\\r\n                 TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MAX               |   \\\r\n                 TXFS_RM_FLAG_LOG_CONTAINER_COUNT_MIN               |   \\\r\n                 TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS   |   \\\r\n                 TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT          |   \\\r\n                 TXFS_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE            |   \\\r\n                 TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX            |   \\\r\n                 TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN            |   \\\r\n                 TXFS_RM_FLAG_SHRINK_LOG                            |   \\\r\n                 TXFS_RM_FLAG_GROW_LOG                              |   \\\r\n                 TXFS_RM_FLAG_ENFORCE_MINIMUM_SIZE                  |   \\\r\n                 TXFS_RM_FLAG_PRESERVE_CHANGES                      |   \\\r\n                 TXFS_RM_FLAG_RESET_RM_AT_NEXT_START                |   \\\r\n                 TXFS_RM_FLAG_DO_NOT_RESET_RM_AT_NEXT_START         |   \\\r\n                 TXFS_RM_FLAG_PREFER_CONSISTENCY                    |   \\\r\n                 TXFS_RM_FLAG_PREFER_AVAILABILITY)")]
        public const int TXFS_MODIFY_RM_VALID_FLAGS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100 | 0x00000800 | 0x00000400 | 0x00001000 | 0x00002000 | 0x00004000 | 0x00008000 | 0x00010000 | 0x00020000);

        [NativeTypeName("#define TXFS_RM_STATE_NOT_STARTED 0")]
        public const int TXFS_RM_STATE_NOT_STARTED = 0;

        [NativeTypeName("#define TXFS_RM_STATE_STARTING 1")]
        public const int TXFS_RM_STATE_STARTING = 1;

        [NativeTypeName("#define TXFS_RM_STATE_ACTIVE 2")]
        public const int TXFS_RM_STATE_ACTIVE = 2;

        [NativeTypeName("#define TXFS_RM_STATE_SHUTTING_DOWN 3")]
        public const int TXFS_RM_STATE_SHUTTING_DOWN = 3;

        [NativeTypeName("#define TXFS_QUERY_RM_INFORMATION_VALID_FLAGS (TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS   |   \\\r\n                 TXFS_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT          |   \\\r\n                 TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX            |   \\\r\n                 TXFS_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN            |   \\\r\n                 TXFS_RM_FLAG_RESET_RM_AT_NEXT_START                |   \\\r\n                 TXFS_RM_FLAG_DO_NOT_RESET_RM_AT_NEXT_START         |   \\\r\n                 TXFS_RM_FLAG_PREFER_CONSISTENCY                    |   \\\r\n                 TXFS_RM_FLAG_PREFER_AVAILABILITY)")]
        public const int TXFS_QUERY_RM_INFORMATION_VALID_FLAGS = (0x00000010 | 0x00000020 | 0x00000080 | 0x00000100 | 0x00004000 | 0x00008000 | 0x00010000 | 0x00020000);

        [NativeTypeName("#define TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_REDO_LSN 0x01")]
        public const int TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_REDO_LSN = 0x01;

        [NativeTypeName("#define TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_VIRTUAL_CLOCK 0x02")]
        public const int TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_VIRTUAL_CLOCK = 0x02;

        [NativeTypeName("#define TXFS_ROLLFORWARD_REDO_VALID_FLAGS (TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_REDO_LSN |         \\\r\n                 TXFS_ROLLFORWARD_REDO_FLAG_USE_LAST_VIRTUAL_CLOCK)")]
        public const int TXFS_ROLLFORWARD_REDO_VALID_FLAGS = (0x01 | 0x02);

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MAX 0x00000001")]
        public const int TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MAX = 0x00000001;

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MIN 0x00000002")]
        public const int TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MIN = 0x00000002;

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_CONTAINER_SIZE 0x00000004")]
        public const int TXFS_START_RM_FLAG_LOG_CONTAINER_SIZE = 0x00000004;

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS 0x00000008")]
        public const int TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS = 0x00000008;

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT 0x00000010")]
        public const int TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT = 0x00000010;

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE 0x00000020")]
        public const int TXFS_START_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE = 0x00000020;

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX 0x00000040")]
        public const int TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX = 0x00000040;

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN 0x00000080")]
        public const int TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MIN = 0x00000080;

        [NativeTypeName("#define TXFS_START_RM_FLAG_RECOVER_BEST_EFFORT 0x00000200")]
        public const int TXFS_START_RM_FLAG_RECOVER_BEST_EFFORT = 0x00000200;

        [NativeTypeName("#define TXFS_START_RM_FLAG_LOGGING_MODE 0x00000400")]
        public const int TXFS_START_RM_FLAG_LOGGING_MODE = 0x00000400;

        [NativeTypeName("#define TXFS_START_RM_FLAG_PRESERVE_CHANGES 0x00000800")]
        public const int TXFS_START_RM_FLAG_PRESERVE_CHANGES = 0x00000800;

        [NativeTypeName("#define TXFS_START_RM_FLAG_PREFER_CONSISTENCY 0x00001000")]
        public const int TXFS_START_RM_FLAG_PREFER_CONSISTENCY = 0x00001000;

        [NativeTypeName("#define TXFS_START_RM_FLAG_PREFER_AVAILABILITY 0x00002000")]
        public const int TXFS_START_RM_FLAG_PREFER_AVAILABILITY = 0x00002000;

        [NativeTypeName("#define TXFS_START_RM_VALID_FLAGS (TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MAX             |   \\\r\n                 TXFS_START_RM_FLAG_LOG_CONTAINER_COUNT_MIN             |   \\\r\n                 TXFS_START_RM_FLAG_LOG_CONTAINER_SIZE                  |   \\\r\n                 TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_NUM_CONTAINERS |   \\\r\n                 TXFS_START_RM_FLAG_LOG_GROWTH_INCREMENT_PERCENT        |   \\\r\n                 TXFS_START_RM_FLAG_LOG_AUTO_SHRINK_PERCENTAGE          |   \\\r\n                 TXFS_START_RM_FLAG_RECOVER_BEST_EFFORT                 |   \\\r\n                 TXFS_START_RM_FLAG_LOG_NO_CONTAINER_COUNT_MAX          |   \\\r\n                 TXFS_START_RM_FLAG_LOGGING_MODE                        |   \\\r\n                 TXFS_START_RM_FLAG_PRESERVE_CHANGES                    |   \\\r\n                 TXFS_START_RM_FLAG_PREFER_CONSISTENCY                  |   \\\r\n                 TXFS_START_RM_FLAG_PREFER_AVAILABILITY)")]
        public const int TXFS_START_RM_VALID_FLAGS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000200 | 0x00000040 | 0x00000400 | 0x00000800 | 0x00001000 | 0x00002000);

        [NativeTypeName("#define TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY_FLAG_CREATED 0x00000001")]
        public const int TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY_FLAG_CREATED = 0x00000001;

        [NativeTypeName("#define TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY_FLAG_DELETED 0x00000002")]
        public const int TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY_FLAG_DELETED = 0x00000002;

        [NativeTypeName("#define TXFS_TRANSACTED_VERSION_NONTRANSACTED 0xFFFFFFFE")]
        public const uint TXFS_TRANSACTED_VERSION_NONTRANSACTED = 0xFFFFFFFE;

        [NativeTypeName("#define TXFS_TRANSACTED_VERSION_UNCOMMITTED 0xFFFFFFFF")]
        public const uint TXFS_TRANSACTED_VERSION_UNCOMMITTED = 0xFFFFFFFF;

        [NativeTypeName("#define TXFS_SAVEPOINT_SET 0x00000001")]
        public const int TXFS_SAVEPOINT_SET = 0x00000001;

        [NativeTypeName("#define TXFS_SAVEPOINT_ROLLBACK 0x00000002")]
        public const int TXFS_SAVEPOINT_ROLLBACK = 0x00000002;

        [NativeTypeName("#define TXFS_SAVEPOINT_CLEAR 0x00000004")]
        public const int TXFS_SAVEPOINT_CLEAR = 0x00000004;

        [NativeTypeName("#define TXFS_SAVEPOINT_CLEAR_ALL 0x00000010")]
        public const int TXFS_SAVEPOINT_CLEAR_ALL = 0x00000010;

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

        [NativeTypeName("#define FILE_TYPE_NOTIFICATION_FLAG_USAGE_BEGIN 0x00000001")]
        public const int FILE_TYPE_NOTIFICATION_FLAG_USAGE_BEGIN = 0x00000001;

        [NativeTypeName("#define FILE_TYPE_NOTIFICATION_FLAG_USAGE_END 0x00000002")]
        public const int FILE_TYPE_NOTIFICATION_FLAG_USAGE_END = 0x00000002;

        [NativeTypeName("#define CSV_MGMTLOCK_CHECK_VOLUME_REDIRECTED 0x00000001")]
        public const int CSV_MGMTLOCK_CHECK_VOLUME_REDIRECTED = 0x00000001;

        [NativeTypeName("#define CSV_NAMESPACE_INFO_V1 (sizeof(CSV_NAMESPACE_INFO))")]
        public const uint CSV_NAMESPACE_INFO_V1 = unchecked(24);

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

        [NativeTypeName("#define FILE_LAYOUT_NAME_ENTRY_PRIMARY (0x00000001)")]
        public const int FILE_LAYOUT_NAME_ENTRY_PRIMARY = (0x00000001);

        [NativeTypeName("#define FILE_LAYOUT_NAME_ENTRY_DOS (0x00000002)")]
        public const int FILE_LAYOUT_NAME_ENTRY_DOS = (0x00000002);

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

        [NativeTypeName("#define FSCTL_INTEGRITY_FLAG_CHECKSUM_ENFORCEMENT_OFF (1)")]
        public const int FSCTL_INTEGRITY_FLAG_CHECKSUM_ENFORCEMENT_OFF = (1);

        [NativeTypeName("#define OFFLOAD_READ_FLAG_ALL_ZERO_BEYOND_CURRENT_RANGE (1)")]
        public const int OFFLOAD_READ_FLAG_ALL_ZERO_BEYOND_CURRENT_RANGE = (1);

        [NativeTypeName("#define SET_PURGE_FAILURE_MODE_ENABLED 0x00000001")]
        public const int SET_PURGE_FAILURE_MODE_ENABLED = 0x00000001;

        [NativeTypeName("#define SET_PURGE_FAILURE_MODE_DISABLED 0x00000002")]
        public const int SET_PURGE_FAILURE_MODE_DISABLED = 0x00000002;

        [NativeTypeName("#define FILE_REGION_USAGE_VALID_CACHED_DATA 0x00000001")]
        public const int FILE_REGION_USAGE_VALID_CACHED_DATA = 0x00000001;

        [NativeTypeName("#define FILE_REGION_USAGE_VALID_NONCACHED_DATA 0x00000002")]
        public const int FILE_REGION_USAGE_VALID_NONCACHED_DATA = 0x00000002;

        [NativeTypeName("#define FILE_REGION_USAGE_OTHER_PAGE_ALIGNMENT 0x00000004")]
        public const int FILE_REGION_USAGE_OTHER_PAGE_ALIGNMENT = 0x00000004;

        [NativeTypeName("#define FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT 0x00000008")]
        public const int FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT = 0x00000008;

        [NativeTypeName("#define FILE_REGION_USAGE_QUERY_ALIGNMENT (FILE_REGION_USAGE_LARGE_PAGE_ALIGNMENT)")]
        public const int FILE_REGION_USAGE_QUERY_ALIGNMENT = (0x00000008);

        [NativeTypeName("#define VALID_WRITE_USN_REASON_MASK (USN_REASON_DATA_OVERWRITE |        \\\r\n                                         USN_REASON_CLOSE)")]
        public const uint VALID_WRITE_USN_REASON_MASK = ((0x00000001) | (0x80000000));

        [NativeTypeName("#define FILE_STORAGE_TIER_NAME_LENGTH (256)")]
        public const int FILE_STORAGE_TIER_NAME_LENGTH = (256);

        [NativeTypeName("#define FILE_STORAGE_TIER_DESCRIPTION_LENGTH (512)")]
        public const int FILE_STORAGE_TIER_DESCRIPTION_LENGTH = (512);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_NO_SEEK_PENALTY (0x00020000)")]
        public const int FILE_STORAGE_TIER_FLAG_NO_SEEK_PENALTY = (0x00020000);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_WRITE_BACK_CACHE (0x00200000)")]
        public const int FILE_STORAGE_TIER_FLAG_WRITE_BACK_CACHE = (0x00200000);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_READ_CACHE (0x00400000)")]
        public const int FILE_STORAGE_TIER_FLAG_READ_CACHE = (0x00400000);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_PARITY (0x00800000)")]
        public const int FILE_STORAGE_TIER_FLAG_PARITY = (0x00800000);

        [NativeTypeName("#define FILE_STORAGE_TIER_FLAG_SMR (0x01000000)")]
        public const int FILE_STORAGE_TIER_FLAG_SMR = (0x01000000);

        [NativeTypeName("#define QUERY_STORAGE_CLASSES_FLAGS_MEASURE_WRITE 0x80000000")]
        public const uint QUERY_STORAGE_CLASSES_FLAGS_MEASURE_WRITE = 0x80000000;

        [NativeTypeName("#define QUERY_STORAGE_CLASSES_FLAGS_MEASURE_READ 0x40000000")]
        public const int QUERY_STORAGE_CLASSES_FLAGS_MEASURE_READ = 0x40000000;

        [NativeTypeName("#define QUERY_STORAGE_CLASSES_FLAGS_NO_DEFRAG_VOLUME 0x20000000")]
        public const int QUERY_STORAGE_CLASSES_FLAGS_NO_DEFRAG_VOLUME = 0x20000000;

        [NativeTypeName("#define FSCTL_QUERY_STORAGE_CLASSES_OUTPUT_VERSION sizeof(FSCTL_QUERY_STORAGE_CLASSES_OUTPUT)")]
        public const uint FSCTL_QUERY_STORAGE_CLASSES_OUTPUT_VERSION = unchecked(1088);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_REPARSE_DATA_INVALID (0x0001)")]
        public const int QUERY_FILE_LAYOUT_REPARSE_DATA_INVALID = (0x0001);

        [NativeTypeName("#define QUERY_FILE_LAYOUT_REPARSE_TAG_INVALID (0x0002)")]
        public const int QUERY_FILE_LAYOUT_REPARSE_TAG_INVALID = (0x0002);

        [NativeTypeName("#define FSCTL_QUERY_REGION_INFO_INPUT_VERSION sizeof(FSCTL_QUERY_REGION_INFO_INPUT)")]
        public const uint FSCTL_QUERY_REGION_INFO_INPUT_VERSION = unchecked(32);

        [NativeTypeName("#define FSCTL_QUERY_REGION_INFO_OUTPUT_VERSION sizeof(FSCTL_QUERY_REGION_INFO_OUTPUT)")]
        public const uint FSCTL_QUERY_REGION_INFO_OUTPUT_VERSION = unchecked(64);

        [NativeTypeName("#define DUPLICATE_EXTENTS_DATA_EX_SOURCE_ATOMIC 0x00000001")]
        public const int DUPLICATE_EXTENTS_DATA_EX_SOURCE_ATOMIC = 0x00000001;

        [NativeTypeName("#define DUPLICATE_EXTENTS_DATA_EX_ASYNC 0x00000002")]
        public const int DUPLICATE_EXTENTS_DATA_EX_ASYNC = 0x00000002;

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

        [NativeTypeName("#define FILE_PROVIDER_CURRENT_VERSION (0x00000001)")]
        public const int FILE_PROVIDER_CURRENT_VERSION = (0x00000001);

        [NativeTypeName("#define FILE_PROVIDER_SINGLE_FILE (0x00000001)")]
        public const int FILE_PROVIDER_SINGLE_FILE = (0x00000001);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_XPRESS4K (0x00000000)")]
        public const int FILE_PROVIDER_COMPRESSION_XPRESS4K = (0x00000000);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_LZX (0x00000001)")]
        public const int FILE_PROVIDER_COMPRESSION_LZX = (0x00000001);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_XPRESS8K (0x00000002)")]
        public const int FILE_PROVIDER_COMPRESSION_XPRESS8K = (0x00000002);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_XPRESS16K (0x00000003)")]
        public const int FILE_PROVIDER_COMPRESSION_XPRESS16K = (0x00000003);

        [NativeTypeName("#define FILE_PROVIDER_COMPRESSION_MAXIMUM (0x00000004)")]
        public const int FILE_PROVIDER_COMPRESSION_MAXIMUM = (0x00000004);

        [NativeTypeName("#define FILE_PROVIDER_FLAG_COMPRESS_ON_WRITE (0x00000001)")]
        public const int FILE_PROVIDER_FLAG_COMPRESS_ON_WRITE = (0x00000001);

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

        [NativeTypeName("#define CONTAINER_ROOT_INFO_VALID_FLAGS (0x000001ff)")]
        public const int CONTAINER_ROOT_INFO_VALID_FLAGS = (0x000001ff);

        [NativeTypeName("#define PROJFS_PROTOCOL_VERSION 3")]
        public const int PROJFS_PROTOCOL_VERSION = 3;

        [NativeTypeName("#define IOCTL_VOLUME_BASE 0x00000056")]
        public const int IOCTL_VOLUME_BASE = 0x00000056;

        [NativeTypeName("#define IOCTL_VOLUME_GET_VOLUME_DISK_EXTENTS CTL_CODE(IOCTL_VOLUME_BASE, 0, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_VOLUME_GET_VOLUME_DISK_EXTENTS = (((0x00000056) << 16) | ((0) << 14) | ((0) << 2) | (0));

        [NativeTypeName("#define IOCTL_VOLUME_ONLINE CTL_CODE(IOCTL_VOLUME_BASE, 2, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_VOLUME_ONLINE = (((0x00000056) << 16) | (((0x0001) | (0x0002)) << 14) | ((2) << 2) | (0));

        [NativeTypeName("#define IOCTL_VOLUME_OFFLINE CTL_CODE(IOCTL_VOLUME_BASE, 3, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
        public const int IOCTL_VOLUME_OFFLINE = (((0x00000056) << 16) | (((0x0001) | (0x0002)) << 14) | ((3) << 2) | (0));

        [NativeTypeName("#define IOCTL_VOLUME_IS_CLUSTERED CTL_CODE(IOCTL_VOLUME_BASE, 12, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_VOLUME_IS_CLUSTERED = (((0x00000056) << 16) | ((0) << 14) | ((12) << 2) | (0));

        [NativeTypeName("#define IOCTL_VOLUME_GET_GPT_ATTRIBUTES CTL_CODE(IOCTL_VOLUME_BASE, 14, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
        public const int IOCTL_VOLUME_GET_GPT_ATTRIBUTES = (((0x00000056) << 16) | ((0) << 14) | ((14) << 2) | (0));

        [NativeTypeName("#define IRP_EXT_TRACK_OFFSET_HEADER_VALIDATION_VALUE 'TO'")]
        public const int IRP_EXT_TRACK_OFFSET_HEADER_VALIDATION_VALUE = 0x544F;

        [NativeTypeName("#define EFS_TRACKED_OFFSET_HEADER_FLAG 0x0001")]
        public const int EFS_TRACKED_OFFSET_HEADER_FLAG = 0x0001;

        [NativeTypeName("#define SPACES_TRACKED_OFFSET_HEADER_FLAG 0x0002")]
        public const int SPACES_TRACKED_OFFSET_HEADER_FLAG = 0x0002;
    }
}
