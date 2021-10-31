// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msports.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SerialDisplayAdvancedSettings([NativeTypeName("HWND")] IntPtr ParentHwnd, [NativeTypeName("HDEVINFO")] IntPtr DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBOpen([NativeTypeName("PHCOMDB")] IntPtr* PHComDB);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBClose([NativeTypeName("HCOMDB")] IntPtr HComDB);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBGetCurrentPortUsage([NativeTypeName("HCOMDB")] IntPtr HComDB, [NativeTypeName("PBYTE")] byte* Buffer, [NativeTypeName("DWORD")] uint BufferSize, [NativeTypeName("ULONG")] uint ReportType, [NativeTypeName("LPDWORD")] uint* MaxPortsReported);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBClaimNextFreePort([NativeTypeName("HCOMDB")] IntPtr HComDB, [NativeTypeName("LPDWORD")] uint* ComNumber);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBClaimPort([NativeTypeName("HCOMDB")] IntPtr HComDB, [NativeTypeName("DWORD")] uint ComNumber, [NativeTypeName("BOOL")] int ForceClaim, [NativeTypeName("PBOOL")] int* Forced);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBReleasePort([NativeTypeName("HCOMDB")] IntPtr HComDB, [NativeTypeName("DWORD")] uint ComNumber);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBResizeDatabase([NativeTypeName("HCOMDB")] IntPtr HComDB, [NativeTypeName("DWORD")] uint NewSize);

        [NativeTypeName("#define HCOMDB_INVALID_HANDLE_VALUE ((HCOMDB) INVALID_HANDLE_VALUE)")]
        public static IntPtr HCOMDB_INVALID_HANDLE_VALUE => ((nint)((nint)((nint)(-1))));

        [NativeTypeName("#define COMDB_MIN_PORTS_ARBITRATED 256")]
        public const int COMDB_MIN_PORTS_ARBITRATED = 256;

        [NativeTypeName("#define COMDB_MAX_PORTS_ARBITRATED 4096")]
        public const int COMDB_MAX_PORTS_ARBITRATED = 4096;

        [NativeTypeName("#define CDB_REPORT_BITS 0x0")]
        public const int CDB_REPORT_BITS = 0x0;

        [NativeTypeName("#define CDB_REPORT_BYTES 0x1")]
        public const int CDB_REPORT_BYTES = 0x1;
    }
}
