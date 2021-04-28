// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/compressapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateCompressor([NativeTypeName("DWORD")] uint Algorithm, [NativeTypeName("PCOMPRESS_ALLOCATION_ROUTINES")] COMPRESS_ALLOCATION_ROUTINES* AllocationRoutines, [NativeTypeName("PCOMPRESSOR_HANDLE")] IntPtr* CompressorHandle);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetCompressorInformation([NativeTypeName("COMPRESSOR_HANDLE")] IntPtr CompressorHandle, COMPRESS_INFORMATION_CLASS CompressInformationClass, [NativeTypeName("LPCVOID")] void* CompressInformation, [NativeTypeName("SIZE_T")] nuint CompressInformationSize);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryCompressorInformation([NativeTypeName("COMPRESSOR_HANDLE")] IntPtr CompressorHandle, COMPRESS_INFORMATION_CLASS CompressInformationClass, [NativeTypeName("PVOID")] void* CompressInformation, [NativeTypeName("SIZE_T")] nuint CompressInformationSize);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Compress([NativeTypeName("COMPRESSOR_HANDLE")] IntPtr CompressorHandle, [NativeTypeName("LPCVOID")] void* UncompressedData, [NativeTypeName("SIZE_T")] nuint UncompressedDataSize, [NativeTypeName("PVOID")] void* CompressedBuffer, [NativeTypeName("SIZE_T")] nuint CompressedBufferSize, [NativeTypeName("PSIZE_T")] nuint* CompressedDataSize);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ResetCompressor([NativeTypeName("COMPRESSOR_HANDLE")] IntPtr CompressorHandle);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseCompressor([NativeTypeName("COMPRESSOR_HANDLE")] IntPtr CompressorHandle);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDecompressor([NativeTypeName("DWORD")] uint Algorithm, [NativeTypeName("PCOMPRESS_ALLOCATION_ROUTINES")] COMPRESS_ALLOCATION_ROUTINES* AllocationRoutines, [NativeTypeName("PDECOMPRESSOR_HANDLE")] IntPtr* DecompressorHandle);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetDecompressorInformation([NativeTypeName("DECOMPRESSOR_HANDLE")] IntPtr DecompressorHandle, COMPRESS_INFORMATION_CLASS CompressInformationClass, [NativeTypeName("LPCVOID")] void* CompressInformation, [NativeTypeName("SIZE_T")] nuint CompressInformationSize);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int QueryDecompressorInformation([NativeTypeName("DECOMPRESSOR_HANDLE")] IntPtr DecompressorHandle, COMPRESS_INFORMATION_CLASS CompressInformationClass, [NativeTypeName("PVOID")] void* CompressInformation, [NativeTypeName("SIZE_T")] nuint CompressInformationSize);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int Decompress([NativeTypeName("DECOMPRESSOR_HANDLE")] IntPtr DecompressorHandle, [NativeTypeName("LPCVOID")] void* CompressedData, [NativeTypeName("SIZE_T")] nuint CompressedDataSize, [NativeTypeName("PVOID")] void* UncompressedBuffer, [NativeTypeName("SIZE_T")] nuint UncompressedBufferSize, [NativeTypeName("PSIZE_T")] nuint* UncompressedDataSize);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ResetDecompressor([NativeTypeName("DECOMPRESSOR_HANDLE")] IntPtr DecompressorHandle);

        [DllImport("cabinet", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CloseDecompressor([NativeTypeName("DECOMPRESSOR_HANDLE")] IntPtr DecompressorHandle);

        [NativeTypeName("#define COMPRESS_ALGORITHM_INVALID 0")]
        public const int COMPRESS_ALGORITHM_INVALID = 0;

        [NativeTypeName("#define COMPRESS_ALGORITHM_NULL 1")]
        public const int COMPRESS_ALGORITHM_NULL = 1;

        [NativeTypeName("#define COMPRESS_ALGORITHM_MSZIP 2")]
        public const int COMPRESS_ALGORITHM_MSZIP = 2;

        [NativeTypeName("#define COMPRESS_ALGORITHM_XPRESS 3")]
        public const int COMPRESS_ALGORITHM_XPRESS = 3;

        [NativeTypeName("#define COMPRESS_ALGORITHM_XPRESS_HUFF 4")]
        public const int COMPRESS_ALGORITHM_XPRESS_HUFF = 4;

        [NativeTypeName("#define COMPRESS_ALGORITHM_LZMS 5")]
        public const int COMPRESS_ALGORITHM_LZMS = 5;

        [NativeTypeName("#define COMPRESS_ALGORITHM_MAX 6")]
        public const int COMPRESS_ALGORITHM_MAX = 6;

        [NativeTypeName("#define COMPRESS_RAW (1 << 29)")]
        public const int COMPRESS_RAW = (1 << 29);
    }
}
