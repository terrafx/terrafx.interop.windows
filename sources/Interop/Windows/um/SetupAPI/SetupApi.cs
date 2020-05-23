// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class SetupApi
    {
        private const string LibraryPath = "setupapi";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetInfInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfInformationA([NativeTypeName("LPCVOID")] void* InfSpec, [NativeTypeName("DWORD")] uint SearchControl, [NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetInfInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfInformationW([NativeTypeName("LPCVOID")] void* InfSpec, [NativeTypeName("DWORD")] uint SearchControl, [NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryInfFileInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfFileInformationA([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryInfFileInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfFileInformationW([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryInfOriginalFileInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfOriginalFileInformationA([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PSP_ORIGINAL_FILE_INFO_A")] SP_ORIGINAL_FILE_INFO_A* OriginalFileInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryInfOriginalFileInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfOriginalFileInformationW([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PSP_ORIGINAL_FILE_INFO_W")] SP_ORIGINAL_FILE_INFO_W* OriginalFileInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryInfVersionInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfVersionInformationA([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryInfVersionInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfVersionInformationW([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetInfDriverStoreLocationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfDriverStoreLocationA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PCSTR")] sbyte* LocaleName, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetInfDriverStoreLocationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfDriverStoreLocationW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PCWSTR")] ushort* LocaleName, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetInfPublishedNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfPublishedNameA([NativeTypeName("PCSTR")] sbyte* DriverStoreLocation, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetInfPublishedNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfPublishedNameW([NativeTypeName("PCWSTR")] ushort* DriverStoreLocation, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetInfFileListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfFileListA([NativeTypeName("PCSTR")] sbyte* DirectoryPath, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetInfFileListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfFileListW([NativeTypeName("PCWSTR")] ushort* DirectoryPath, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupOpenInfFileW", ExactSpelling = true)]
        [return: NativeTypeName("HINF")]
        public static extern void* SetupOpenInfFileW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* InfClass, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupOpenInfFileA", ExactSpelling = true)]
        [return: NativeTypeName("HINF")]
        public static extern void* SetupOpenInfFileA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* InfClass, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupOpenMasterInf", ExactSpelling = true)]
        [return: NativeTypeName("HINF")]
        public static extern void* SetupOpenMasterInf();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupOpenAppendInfFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupOpenAppendInfFileW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupOpenAppendInfFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupOpenAppendInfFileA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCloseInfFile", ExactSpelling = true)]
        public static extern void SetupCloseInfFile([NativeTypeName("HINF")] void* InfHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupFindFirstLineA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindFirstLineA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupFindFirstLineW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindFirstLineW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupFindNextLine", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindNextLine([NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextIn, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextOut);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupFindNextMatchLineA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindNextMatchLineA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextIn, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextOut);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupFindNextMatchLineW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindNextMatchLineW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextIn, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextOut);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetLineByIndexA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetLineByIndexA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetLineByIndexW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetLineByIndexW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetLineCountA", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetupGetLineCountA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetLineCountW", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetupGetLineCountW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetLineTextA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetLineTextA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetLineTextW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetLineTextW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetFieldCount", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFieldCount([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetStringFieldA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetStringFieldA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetStringFieldW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetStringFieldW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetIntField", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetIntField([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PINT")] int* IntegerValue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetMultiSzFieldA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetMultiSzFieldA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetMultiSzFieldW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetMultiSzFieldW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetBinaryField", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetBinaryField([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PBYTE")] byte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetFileCompressionInfoA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFileCompressionInfoA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PSTR *")] sbyte** ActualSourceFileName, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetFileCompressionInfoW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFileCompressionInfoW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PWSTR *")] ushort** ActualSourceFileName, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetFileCompressionInfoExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetFileCompressionInfoExA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PSTR")] sbyte* ActualSourceFileNameBuffer, [NativeTypeName("DWORD")] uint ActualSourceFileNameBufferLen, [NativeTypeName("PDWORD")] uint* RequiredBufferLen, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetFileCompressionInfoExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetFileCompressionInfoExW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PWSTR")] ushort* ActualSourceFileNameBuffer, [NativeTypeName("DWORD")] uint ActualSourceFileNameBufferLen, [NativeTypeName("PDWORD")] uint* RequiredBufferLen, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDecompressOrCopyFileA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupDecompressOrCopyFileA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PCSTR")] sbyte* TargetFileName, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDecompressOrCopyFileW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupDecompressOrCopyFileW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PCWSTR")] ushort* TargetFileName, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetSourceFileLocationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceFileLocationA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PUINT")] uint* SourceId, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetSourceFileLocationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceFileLocationW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PUINT")] uint* SourceId, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetSourceFileSizeA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceFileSizeA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PDWORD")] uint* FileSize, [NativeTypeName("UINT")] uint RoundingFactor);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetSourceFileSizeW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceFileSizeW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PDWORD")] uint* FileSize, [NativeTypeName("UINT")] uint RoundingFactor);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetTargetPathA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetTargetPathA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetTargetPathW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetTargetPathW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetSourceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR *")] sbyte** SourceList, [NativeTypeName("UINT")] uint SourceCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetSourceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR *")] ushort** SourceList, [NativeTypeName("UINT")] uint SourceCount);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCancelTemporarySourceList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCancelTemporarySourceList();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAddToSourceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddToSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* Source);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAddToSourceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddToSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* Source);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveFromSourceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFromSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* Source);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveFromSourceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFromSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* Source);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQuerySourceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQuerySourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR **")] sbyte*** List, [NativeTypeName("PUINT")] uint* Count);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQuerySourceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQuerySourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR **")] ushort*** List, [NativeTypeName("PUINT")] uint* Count);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupFreeSourceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFreeSourceListA([NativeTypeName("PCSTR **")] sbyte*** List, [NativeTypeName("UINT")] uint Count);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupFreeSourceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFreeSourceListW([NativeTypeName("PCWSTR **")] ushort*** List, [NativeTypeName("UINT")] uint Count);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupPromptForDiskA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupPromptForDiskA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* DiskName, [NativeTypeName("PCSTR")] sbyte* PathToSource, [NativeTypeName("PCSTR")] sbyte* FileSought, [NativeTypeName("PCSTR")] sbyte* TagFile, [NativeTypeName("DWORD")] uint DiskPromptStyle, [NativeTypeName("PSTR")] sbyte* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupPromptForDiskW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupPromptForDiskW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* DiskName, [NativeTypeName("PCWSTR")] ushort* PathToSource, [NativeTypeName("PCWSTR")] ushort* FileSought, [NativeTypeName("PCWSTR")] ushort* TagFile, [NativeTypeName("DWORD")] uint DiskPromptStyle, [NativeTypeName("PWSTR")] ushort* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCopyErrorA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupCopyErrorA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* DiskName, [NativeTypeName("PCSTR")] sbyte* PathToSource, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetPathFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style, [NativeTypeName("PSTR")] sbyte* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCopyErrorW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupCopyErrorW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* DiskName, [NativeTypeName("PCWSTR")] ushort* PathToSource, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetPathFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style, [NativeTypeName("PWSTR")] ushort* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRenameErrorA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupRenameErrorA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRenameErrorW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupRenameErrorW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDeleteErrorA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupDeleteErrorA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* File, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDeleteErrorW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupDeleteErrorW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* File, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupBackupErrorA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupBackupErrorA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupBackupErrorW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupBackupErrorW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetDirectoryIdA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetDirectoryIdA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCSTR")] sbyte* Directory);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetDirectoryIdW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetDirectoryIdW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCWSTR")] ushort* Directory);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetDirectoryIdExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetDirectoryIdExA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCSTR")] sbyte* Directory, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetDirectoryIdExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetDirectoryIdExW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCWSTR")] ushort* Directory, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetSourceInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceInfoA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("UINT")] uint SourceId, [NativeTypeName("UINT")] uint InfoDesired, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetSourceInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceInfoW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("UINT")] uint SourceId, [NativeTypeName("UINT")] uint InfoDesired, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFileA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* SourcePathRoot, [NativeTypeName("PCSTR")] sbyte* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_A")] IntPtr CopyMsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFileW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* SourcePathRoot, [NativeTypeName("PCWSTR")] ushort* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_W")] IntPtr CopyMsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallFileExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFileExA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* SourcePathRoot, [NativeTypeName("PCSTR")] sbyte* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_A")] IntPtr CopyMsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PBOOL")] int* FileWasInUse);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallFileExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFileExW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* SourcePathRoot, [NativeTypeName("PCWSTR")] ushort* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_W")] IntPtr CopyMsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PBOOL")] int* FileWasInUse);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupOpenFileQueue", ExactSpelling = true)]
        [return: NativeTypeName("HSPFILEQ")]
        public static extern void* SetupOpenFileQueue();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCloseFileQueue", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCloseFileQueue([NativeTypeName("HSPFILEQ")] void* QueueHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetFileQueueAlternatePlatformA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetFileQueueAlternatePlatformA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PCSTR")] sbyte* AlternateDefaultCatalogFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetFileQueueAlternatePlatformW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetFileQueueAlternatePlatformW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PCWSTR")] ushort* AlternateDefaultCatalogFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetPlatformPathOverrideA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetPlatformPathOverrideA([NativeTypeName("PCSTR")] sbyte* Override);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetPlatformPathOverrideW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetPlatformPathOverrideW([NativeTypeName("PCWSTR")] ushort* Override);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueCopyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopyA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("PCSTR")] sbyte* SourcePath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* SourceDescription, [NativeTypeName("PCSTR")] sbyte* SourceTagfile, [NativeTypeName("PCSTR")] sbyte* TargetDirectory, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueCopyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopyW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("PCWSTR")] ushort* SourcePath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* SourceDescription, [NativeTypeName("PCWSTR")] ushort* SourceTagfile, [NativeTypeName("PCWSTR")] ushort* TargetDirectory, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueCopyIndirectA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopyIndirectA([NativeTypeName("PSP_FILE_COPY_PARAMS_A")] SP_FILE_COPY_PARAMS_A* CopyParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueCopyIndirectW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopyIndirectW([NativeTypeName("PSP_FILE_COPY_PARAMS_W")] SP_FILE_COPY_PARAMS_W* CopyParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueDefaultCopyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDefaultCopyA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueDefaultCopyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDefaultCopyW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueCopySectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopySectionA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueCopySectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopySectionW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueDeleteA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDeleteA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* PathPart1, [NativeTypeName("PCSTR")] sbyte* PathPart2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueDeleteW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDeleteW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* PathPart1, [NativeTypeName("PCWSTR")] ushort* PathPart2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueDeleteSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDeleteSectionA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueDeleteSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDeleteSectionW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueRenameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueRenameA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourcePath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetPath, [NativeTypeName("PCSTR")] sbyte* TargetFilename);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueRenameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueRenameW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourcePath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetPath, [NativeTypeName("PCWSTR")] ushort* TargetFilename);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueRenameSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueRenameSectionA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueueRenameSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueRenameSectionW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCommitFileQueueA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCommitFileQueueA([NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_FILE_CALLBACK_A")] IntPtr MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCommitFileQueueW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCommitFileQueueW([NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_FILE_CALLBACK_W")] IntPtr MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupScanFileQueueA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupScanFileQueueA([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HWND")] IntPtr Window, [NativeTypeName("PSP_FILE_CALLBACK_A")] IntPtr CallbackRoutine, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PDWORD")] uint* Result);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupScanFileQueueW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupScanFileQueueW([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HWND")] IntPtr Window, [NativeTypeName("PSP_FILE_CALLBACK_W")] IntPtr CallbackRoutine, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PDWORD")] uint* Result);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetFileQueueCount", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetFileQueueCount([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("UINT")] uint SubQueueFileOp, [NativeTypeName("PUINT")] uint* NumOperations);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetFileQueueFlags", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetFileQueueFlags([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("PDWORD")] uint* Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetFileQueueFlags", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetFileQueueFlags([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("DWORD")] uint FlagMask, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCopyOEMInfA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCopyOEMInfA([NativeTypeName("PCSTR")] sbyte* SourceInfFileName, [NativeTypeName("PCSTR")] sbyte* OEMSourceMediaLocation, [NativeTypeName("DWORD")] uint OEMSourceMediaType, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSTR")] sbyte* DestinationInfFileName, [NativeTypeName("DWORD")] uint DestinationInfFileNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** DestinationInfFileNameComponent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCopyOEMInfW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCopyOEMInfW([NativeTypeName("PCWSTR")] ushort* SourceInfFileName, [NativeTypeName("PCWSTR")] ushort* OEMSourceMediaLocation, [NativeTypeName("DWORD")] uint OEMSourceMediaType, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PWSTR")] ushort* DestinationInfFileName, [NativeTypeName("DWORD")] uint DestinationInfFileNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** DestinationInfFileNameComponent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupUninstallOEMInfA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupUninstallOEMInfA([NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupUninstallOEMInfW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupUninstallOEMInfW([NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupUninstallNewlyCopiedInfs", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupUninstallNewlyCopiedInfs([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCreateDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("HDSKSPC")]
        public static extern void* SetupCreateDiskSpaceListA([NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, [NativeTypeName("UINT")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCreateDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("HDSKSPC")]
        public static extern void* SetupCreateDiskSpaceListW([NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, [NativeTypeName("UINT")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDuplicateDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("HDSKSPC")]
        public static extern void* SetupDuplicateDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, [NativeTypeName("UINT")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDuplicateDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("HDSKSPC")]
        public static extern void* SetupDuplicateDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, [NativeTypeName("UINT")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDestroyDiskSpaceList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDestroyDiskSpaceList([NativeTypeName("HDSKSPC")] void* DiskSpace);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryDrivesInDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryDrivesInDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryDrivesInDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryDrivesInDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQuerySpaceRequiredOnDriveA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQuerySpaceRequiredOnDriveA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCSTR")] sbyte* DriveSpec, [NativeTypeName("LONGLONG *")] long* SpaceRequired, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQuerySpaceRequiredOnDriveW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQuerySpaceRequiredOnDriveW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCWSTR")] ushort* DriveSpec, [NativeTypeName("LONGLONG *")] long* SpaceRequired, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAdjustDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAdjustDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("LPCSTR")] sbyte* DriveRoot, [NativeTypeName("LONGLONG")] long Amount, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAdjustDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAdjustDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("LPCWSTR")] ushort* DriveRoot, [NativeTypeName("LONGLONG")] long Amount, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAddToDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddToDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCSTR")] sbyte* TargetFilespec, [NativeTypeName("LONGLONG")] long FileSize, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAddToDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddToDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCWSTR")] ushort* TargetFilespec, [NativeTypeName("LONGLONG")] long FileSize, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAddSectionToDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddSectionToDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAddSectionToDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddSectionToDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAddInstallSectionToDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddInstallSectionToDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupAddInstallSectionToDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddInstallSectionToDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveFromDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFromDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCSTR")] sbyte* TargetFilespec, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveFromDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFromDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCWSTR")] ushort* TargetFilespec, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveSectionFromDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveSectionFromDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveSectionFromDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveSectionFromDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveInstallSectionFromDiskSpaceListA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveInstallSectionFromDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveInstallSectionFromDiskSpaceListW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveInstallSectionFromDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupIterateCabinetA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupIterateCabinetA([NativeTypeName("PCSTR")] sbyte* CabinetFile, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("PSP_FILE_CALLBACK_A")] IntPtr MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupIterateCabinetW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupIterateCabinetW([NativeTypeName("PCWSTR")] ushort* CabinetFile, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("PSP_FILE_CALLBACK_W")] IntPtr MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupPromptReboot", ExactSpelling = true)]
        [return: NativeTypeName("INT")]
        public static extern int SetupPromptReboot([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("BOOL")] int ScanOnly);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInitDefaultQueueCallback", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* SetupInitDefaultQueueCallback([NativeTypeName("HWND")] IntPtr OwnerWindow);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInitDefaultQueueCallbackEx", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* SetupInitDefaultQueueCallbackEx([NativeTypeName("HWND")] IntPtr OwnerWindow, [NativeTypeName("HWND")] IntPtr AlternateProgressWindow, [NativeTypeName("UINT")] uint ProgressMessage, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupTermDefaultQueueCallback", ExactSpelling = true)]
        public static extern void SetupTermDefaultQueueCallback([NativeTypeName("PVOID")] void* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDefaultQueueCallbackA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupDefaultQueueCallbackA([NativeTypeName("PVOID")] void* Context, [NativeTypeName("UINT")] uint Notification, [NativeTypeName("UINT_PTR")] uint Param1, [NativeTypeName("UINT_PTR")] uint Param2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDefaultQueueCallbackW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupDefaultQueueCallbackW([NativeTypeName("PVOID")] void* Context, [NativeTypeName("UINT")] uint Notification, [NativeTypeName("UINT_PTR")] uint Param1, [NativeTypeName("UINT_PTR")] uint Param2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallFromInfSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFromInfSectionA([NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("HKEY")] IntPtr RelativeKeyRoot, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("UINT")] uint CopyFlags, [NativeTypeName("PSP_FILE_CALLBACK_A")] IntPtr MsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallFromInfSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFromInfSectionW([NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("HKEY")] IntPtr RelativeKeyRoot, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("UINT")] uint CopyFlags, [NativeTypeName("PSP_FILE_CALLBACK_W")] IntPtr MsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallFilesFromInfSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFilesFromInfSectionA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("UINT")] uint CopyFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallFilesFromInfSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFilesFromInfSectionW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("UINT")] uint CopyFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallServicesFromInfSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallServicesFromInfSectionA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallServicesFromInfSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallServicesFromInfSectionW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallServicesFromInfSectionExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallServicesFromInfSectionExA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInstallServicesFromInfSectionExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallServicesFromInfSectionExW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InstallHinfSectionA", ExactSpelling = true)]
        public static extern void InstallHinfSectionA([NativeTypeName("HWND")] IntPtr Window, [NativeTypeName("HINSTANCE")] IntPtr ModuleHandle, [NativeTypeName("PCSTR")] sbyte* CommandLine, [NativeTypeName("INT")] int ShowCommand);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "InstallHinfSectionW", ExactSpelling = true)]
        public static extern void InstallHinfSectionW([NativeTypeName("HWND")] IntPtr Window, [NativeTypeName("HINSTANCE")] IntPtr ModuleHandle, [NativeTypeName("PCWSTR")] ushort* CommandLine, [NativeTypeName("INT")] int ShowCommand);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInitializeFileLogA", ExactSpelling = true)]
        [return: NativeTypeName("HSPFILELOG")]
        public static extern void* SetupInitializeFileLogA([NativeTypeName("PCSTR")] sbyte* LogFileName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupInitializeFileLogW", ExactSpelling = true)]
        [return: NativeTypeName("HSPFILELOG")]
        public static extern void* SetupInitializeFileLogW([NativeTypeName("PCWSTR")] ushort* LogFileName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupTerminateFileLog", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupTerminateFileLog([NativeTypeName("HSPFILELOG")] void* FileLogHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupLogFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupLogFileA([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint Checksum, [NativeTypeName("PCSTR")] sbyte* DiskTagfile, [NativeTypeName("PCSTR")] sbyte* DiskDescription, [NativeTypeName("PCSTR")] sbyte* OtherInfo, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupLogFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupLogFileW([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint Checksum, [NativeTypeName("PCWSTR")] ushort* DiskTagfile, [NativeTypeName("PCWSTR")] ushort* DiskDescription, [NativeTypeName("PCWSTR")] ushort* OtherInfo, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveFileLogEntryA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFileLogEntryA([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* TargetFilename);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupRemoveFileLogEntryW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFileLogEntryW([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* TargetFilename);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryFileLogA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryFileLogA([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* TargetFilename, SetupFileLogInfo DesiredInfo, [NativeTypeName("PSTR")] sbyte* DataOut, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupQueryFileLogW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryFileLogW([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* TargetFilename, SetupFileLogInfo DesiredInfo, [NativeTypeName("PWSTR")] ushort* DataOut, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupOpenLog", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupOpenLog([NativeTypeName("BOOL")] int Erase);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupLogErrorA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupLogErrorA([NativeTypeName("LPCSTR")] sbyte* MessageString, [NativeTypeName("DWORD")] uint Severity);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupLogErrorW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupLogErrorW([NativeTypeName("LPCWSTR")] ushort* MessageString, [NativeTypeName("DWORD")] uint Severity);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupCloseLog", ExactSpelling = true)]
        public static extern void SetupCloseLog();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetThreadLogToken", ExactSpelling = true)]
        [return: NativeTypeName("SP_LOG_TOKEN")]
        public static extern ulong SetupGetThreadLogToken();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetThreadLogToken", ExactSpelling = true)]
        public static extern void SetupSetThreadLogToken([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupWriteTextLog", ExactSpelling = true)]
        public static extern void SetupWriteTextLog([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Category, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* MessageStr);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupWriteTextLogError", ExactSpelling = true)]
        public static extern void SetupWriteTextLogError([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Category, [NativeTypeName("DWORD")] uint LogFlags, [NativeTypeName("DWORD")] uint Error, [NativeTypeName("PCSTR")] sbyte* MessageStr);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupWriteTextLogInfLine", ExactSpelling = true)]
        public static extern void SetupWriteTextLogInfLine([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetBackupInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetBackupInformationA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_BACKUP_QUEUE_PARAMS_A")] SP_BACKUP_QUEUE_PARAMS_V2_A* BackupParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetBackupInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetBackupInformationW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_BACKUP_QUEUE_PARAMS_W")] SP_BACKUP_QUEUE_PARAMS_V2_W* BackupParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupPrepareQueueForRestoreA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupPrepareQueueForRestoreA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* BackupPath, [NativeTypeName("DWORD")] uint RestoreFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupPrepareQueueForRestoreW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupPrepareQueueForRestoreW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* BackupPath, [NativeTypeName("DWORD")] uint RestoreFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupSetNonInteractiveMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetNonInteractiveMode([NativeTypeName("BOOL")] int NonInteractiveFlag);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupGetNonInteractiveMode", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetNonInteractiveMode();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInfoList", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiCreateDeviceInfoList([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("HWND")] IntPtr hwndParent);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInfoListExA", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiCreateDeviceInfoListExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInfoListExW", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiCreateDeviceInfoListExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInfoListClass", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInfoListClass([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("LPGUID")] Guid* ClassGuid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInfoListDetailA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInfoListDetailA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_LIST_DETAIL_DATA_A")] SP_DEVINFO_LIST_DETAIL_DATA_A* DeviceInfoSetDetailData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInfoListDetailW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInfoListDetailW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_LIST_DETAIL_DATA_W")] SP_DEVINFO_LIST_DETAIL_DATA_W* DeviceInfoSetDetailData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCreateDeviceInfoA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DeviceName, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* DeviceDescription, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCreateDeviceInfoW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DeviceName, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* DeviceDescription, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenDeviceInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiOpenDeviceInfoA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DeviceInstanceId, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenDeviceInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiOpenDeviceInfoW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DeviceInstanceId, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInstanceIdA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInstanceIdA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSTR")] sbyte* DeviceInstanceId, [NativeTypeName("DWORD")] uint DeviceInstanceIdSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInstanceIdW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInstanceIdW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PWSTR")] ushort* DeviceInstanceId, [NativeTypeName("DWORD")] uint DeviceInstanceIdSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiDeleteDeviceInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDeleteDeviceInfo([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiEnumDeviceInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiEnumDeviceInfo([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiDestroyDeviceInfoList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDestroyDeviceInfoList([NativeTypeName("HDEVINFO")] void* DeviceInfoSet);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiEnumDeviceInterfaces", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiEnumDeviceInterfaces([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInterfaceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCreateDeviceInterfaceA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PCSTR")] sbyte* ReferenceString, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInterfaceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCreateDeviceInterfaceW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PCWSTR")] ushort* ReferenceString, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenDeviceInterfaceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiOpenDeviceInterfaceA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DevicePath, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenDeviceInterfaceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiOpenDeviceInterfaceW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DevicePath, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInterfaceAlias", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfaceAlias([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("const GUID *")] Guid* AliasInterfaceClassGuid, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* AliasDeviceInterfaceData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiDeleteDeviceInterfaceData", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDeleteDeviceInterfaceData([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiRemoveDeviceInterface", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRemoveDeviceInterface([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInterfaceDetailA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfaceDetailA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("PSP_DEVICE_INTERFACE_DETAIL_DATA_A")] SP_DEVICE_INTERFACE_DETAIL_DATA_A* DeviceInterfaceDetailData, [NativeTypeName("DWORD")] uint DeviceInterfaceDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInterfaceDetailW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfaceDetailW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("PSP_DEVICE_INTERFACE_DETAIL_DATA_W")] SP_DEVICE_INTERFACE_DETAIL_DATA_W* DeviceInterfaceDetailData, [NativeTypeName("DWORD")] uint DeviceInterfaceDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiInstallDeviceInterfaces", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallDeviceInterfaces([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDeviceInterfaceDefault", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceInterfaceDefault([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiRegisterDeviceInfo", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRegisterDeviceInfo([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PSP_DETSIG_CMPPROC")] IntPtr CompareProc, [NativeTypeName("PVOID")] void* CompareContext, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DupDeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiBuildDriverInfoList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiBuildDriverInfoList([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCancelDriverInfoSearch", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCancelDriverInfoSearch([NativeTypeName("HDEVINFO")] void* DeviceInfoSet);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiEnumDriverInfoA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiEnumDriverInfoA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiEnumDriverInfoW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiEnumDriverInfoW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetSelectedDriverA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetSelectedDriverA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetSelectedDriverW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetSelectedDriverW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetSelectedDriverA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetSelectedDriverA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetSelectedDriverW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetSelectedDriverW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDriverInfoDetailA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDriverInfoDetailA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData, [NativeTypeName("PSP_DRVINFO_DETAIL_DATA_A")] SP_DRVINFO_DETAIL_DATA_A* DriverInfoDetailData, [NativeTypeName("DWORD")] uint DriverInfoDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDriverInfoDetailW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDriverInfoDetailW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData, [NativeTypeName("PSP_DRVINFO_DETAIL_DATA_W")] SP_DRVINFO_DETAIL_DATA_W* DriverInfoDetailData, [NativeTypeName("DWORD")] uint DriverInfoDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiDestroyDriverInfoList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDestroyDriverInfoList([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDevsA", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiGetClassDevsA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* Enumerator, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDevsW", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiGetClassDevsW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* Enumerator, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDevsExA", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiGetClassDevsExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* Enumerator, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDevsExW", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiGetClassDevsExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* Enumerator, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetINFClassA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetINFClassA([NativeTypeName("PCSTR")] sbyte* InfName, [NativeTypeName("LPGUID")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetINFClassW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetINFClassW([NativeTypeName("PCWSTR")] ushort* InfName, [NativeTypeName("LPGUID")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiBuildClassInfoList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiBuildClassInfoList([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiBuildClassInfoListExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiBuildClassInfoListExA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiBuildClassInfoListExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiBuildClassInfoListExW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDescriptionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDescriptionA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDescriptionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDescriptionW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDescriptionExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDescriptionExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDescriptionExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDescriptionExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCallClassInstaller", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCallClassInstaller([NativeTypeName("DI_FUNCTION")] uint InstallFunction, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSelectDevice", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSelectDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSelectBestCompatDrv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSelectBestCompatDrv([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiInstallDevice", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiInstallDriverFiles", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallDriverFiles([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiRegisterCoDeviceInstallers", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRegisterCoDeviceInstallers([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiRemoveDevice", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRemoveDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiUnremoveDevice", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiUnremoveDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiRestartDevices", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRestartDevices([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiChangeState", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiChangeState([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiInstallClassA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallClassA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HSPFILEQ")] void* FileQueue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiInstallClassW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallClassW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HSPFILEQ")] void* FileQueue);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiInstallClassExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallClassExA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiInstallClassExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallClassExW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenClassRegKey", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenClassRegKey([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenClassRegKeyExA", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenClassRegKeyExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenClassRegKeyExW", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenClassRegKeyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInterfaceRegKeyA", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiCreateDeviceInterfaceRegKeyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDeviceInterfaceRegKeyW", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiCreateDeviceInterfaceRegKeyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenDeviceInterfaceRegKey", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenDeviceInterfaceRegKey([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiDeleteDeviceInterfaceRegKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDeleteDeviceInterfaceRegKey([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDevRegKeyA", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiCreateDevRegKeyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiCreateDevRegKeyW", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiCreateDevRegKeyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiOpenDevRegKey", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenDevRegKey([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiDeleteDevRegKey", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDeleteDevRegKey([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetHwProfileList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileList([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetHwProfileListExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileListExA([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetHwProfileListExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileListExW([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDevicePropertyKeys", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDevicePropertyKeys([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DEVPROPKEY *")] DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDevicePropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDevicePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDevicePropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDevicePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInterfacePropertyKeys", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfacePropertyKeys([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DEVPROPKEY *")] DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInterfacePropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfacePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDeviceInterfacePropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceInterfacePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassPropertyKeys", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassPropertyKeys([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DEVPROPKEY *")] DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassPropertyKeysExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassPropertyKeysExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DEVPROPKEY *")] DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassPropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassPropertyExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassPropertyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetClassPropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetClassPropertyExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassPropertyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceRegistryPropertyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceRegistryPropertyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceRegistryPropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceRegistryPropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassRegistryPropertyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassRegistryPropertyA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassRegistryPropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassRegistryPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDeviceRegistryPropertyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceRegistryPropertyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDeviceRegistryPropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceRegistryPropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetClassRegistryPropertyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassRegistryPropertyA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetClassRegistryPropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassRegistryPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInstallParamsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_A")] SP_DEVINSTALL_PARAMS_A* DeviceInstallParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDeviceInstallParamsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_W")] SP_DEVINSTALL_PARAMS_W* DeviceInstallParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassInstallParamsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] SP_CLASSINSTALL_HEADER* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassInstallParamsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] SP_CLASSINSTALL_HEADER* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDeviceInstallParamsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_A")] SP_DEVINSTALL_PARAMS_A* DeviceInstallParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDeviceInstallParamsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_W")] SP_DEVINSTALL_PARAMS_W* DeviceInstallParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetClassInstallParamsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] SP_CLASSINSTALL_HEADER* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetClassInstallParamsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] SP_CLASSINSTALL_HEADER* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDriverInstallParamsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDriverInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] SP_DRVINSTALL_PARAMS* DriverInstallParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetDriverInstallParamsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDriverInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] SP_DRVINSTALL_PARAMS* DriverInstallParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDriverInstallParamsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDriverInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] SP_DRVINSTALL_PARAMS* DriverInstallParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetDriverInstallParamsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDriverInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] SP_DRVINSTALL_PARAMS* DriverInstallParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiLoadClassIcon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiLoadClassIcon([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("HICON *")] IntPtr** LargeIcon, [NativeTypeName("PINT")] int* MiniIconIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiLoadDeviceIcon", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiLoadDeviceIcon([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("UINT")] uint cxIcon, [NativeTypeName("UINT")] uint cyIcon, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HICON *")] IntPtr** hIcon);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiDrawMiniIcon", ExactSpelling = true)]
        [return: NativeTypeName("INT")]
        public static extern int SetupDiDrawMiniIcon([NativeTypeName("HDC")] IntPtr hdc, RECT rc, [NativeTypeName("INT")] int MiniIconIndex, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassBitmapIndex", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassBitmapIndex([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PINT")] int* MiniIconIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassImageList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassImageList([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassImageListExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassImageListExA([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassImageListExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassImageListExW([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassImageIndex", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassImageIndex([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PINT")] int* ImageIndex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiDestroyClassImageList", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDestroyClassImageList([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDevPropertySheetsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDevPropertySheetsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("LPPROPSHEETHEADERA")] PROPSHEETHEADERA_V2* PropertySheetHeader, [NativeTypeName("DWORD")] uint PropertySheetHeaderPageListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint PropertySheetType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetClassDevPropertySheetsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDevPropertySheetsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("LPPROPSHEETHEADERW")] PROPSHEETHEADERW_V2* PropertySheetHeader, [NativeTypeName("DWORD")] uint PropertySheetHeaderPageListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint PropertySheetType);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiAskForOEMDisk", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiAskForOEMDisk([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSelectOEMDrv", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSelectOEMDrv([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiClassNameFromGuidA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassNameFromGuidA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiClassNameFromGuidW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassNameFromGuidW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiClassNameFromGuidExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassNameFromGuidExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiClassNameFromGuidExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassNameFromGuidExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiClassGuidsFromNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassGuidsFromNameA([NativeTypeName("PCSTR")] sbyte* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiClassGuidsFromNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassGuidsFromNameW([NativeTypeName("PCWSTR")] ushort* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiClassGuidsFromNameExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassGuidsFromNameExA([NativeTypeName("PCSTR")] sbyte* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiClassGuidsFromNameExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassGuidsFromNameExW([NativeTypeName("PCWSTR")] ushort* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetHwProfileFriendlyNameA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileFriendlyNameA([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PSTR")] sbyte* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetHwProfileFriendlyNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileFriendlyNameW([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PWSTR")] ushort* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetHwProfileFriendlyNameExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileFriendlyNameExA([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PSTR")] sbyte* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetHwProfileFriendlyNameExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileFriendlyNameExW([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PWSTR")] ushort* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetWizardPage", ExactSpelling = true)]
        [return: NativeTypeName("HPROPSHEETPAGE")]
        public static extern IntPtr SetupDiGetWizardPage([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_INSTALLWIZARD_DATA")] SP_INSTALLWIZARD_DATA* InstallWizardData, [NativeTypeName("DWORD")] uint PageType, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetSelectedDevice", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetSelectedDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiSetSelectedDevice", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetSelectedDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetActualModelsSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualModelsSectionA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetActualModelsSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualModelsSectionW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetActualSectionToInstallA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualSectionToInstallA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** Extension);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetActualSectionToInstallW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualSectionToInstallW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** Extension);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetActualSectionToInstallExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualSectionToInstallExA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** Extension, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetActualSectionToInstallExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualSectionToInstallExW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** Extension, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupEnumInfSectionsA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupEnumInfSectionsA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("UINT")] uint Index, [NativeTypeName("PSTR")] sbyte* Buffer, [NativeTypeName("UINT")] uint Size, [NativeTypeName("UINT *")] uint* SizeNeeded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupEnumInfSectionsW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupEnumInfSectionsW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("UINT")] uint Index, [NativeTypeName("PWSTR")] ushort* Buffer, [NativeTypeName("UINT")] uint Size, [NativeTypeName("UINT *")] uint* SizeNeeded);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupVerifyInfFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupVerifyInfFileA([NativeTypeName("PCSTR")] sbyte* InfName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AltPlatformInfo, [NativeTypeName("PSP_INF_SIGNER_INFO_A")] SP_INF_SIGNER_INFO_V2_A* InfSignerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupVerifyInfFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupVerifyInfFileW([NativeTypeName("PCWSTR")] ushort* InfName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AltPlatformInfo, [NativeTypeName("PSP_INF_SIGNER_INFO_W")] SP_INF_SIGNER_INFO_V2_W* InfSignerInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetCustomDevicePropertyA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetCustomDevicePropertyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PCSTR")] sbyte* CustomPropertyName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupDiGetCustomDevicePropertyW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetCustomDevicePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PCWSTR")] ushort* CustomPropertyName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupConfigureWmiFromInfSectionA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupConfigureWmiFromInfSectionA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetupConfigureWmiFromInfSectionW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupConfigureWmiFromInfSectionW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags);
    }
}
