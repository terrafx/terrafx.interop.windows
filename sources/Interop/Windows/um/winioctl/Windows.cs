// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

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
            uint Bytes = 28;

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
            uint Bytes = 28;

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
            uint Bytes = 28;

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

            if ((InputLength - Bytes) < (uint)(sizeof(DEVICE_DATA_SET_RANGE)))
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
            uint Bytes = 36;

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
    }
}
