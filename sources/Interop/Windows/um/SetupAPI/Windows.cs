// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfInformationA([NativeTypeName("LPCVOID")] void* InfSpec, [NativeTypeName("DWORD")] uint SearchControl, [NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfInformationW([NativeTypeName("LPCVOID")] void* InfSpec, [NativeTypeName("DWORD")] uint SearchControl, [NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfFileInformationA([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfFileInformationW([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfOriginalFileInformationA([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PSP_ORIGINAL_FILE_INFO_A")] SP_ORIGINAL_FILE_INFO_A* OriginalFileInfo);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfOriginalFileInformationW([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PSP_ORIGINAL_FILE_INFO_W")] SP_ORIGINAL_FILE_INFO_W* OriginalFileInfo);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfVersionInformationA([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryInfVersionInformationW([NativeTypeName("PSP_INF_INFORMATION")] SP_INF_INFORMATION* InfInformation, [NativeTypeName("UINT")] uint InfIndex, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfDriverStoreLocationA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PCSTR")] sbyte* LocaleName, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfDriverStoreLocationW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PCWSTR")] ushort* LocaleName, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfPublishedNameA([NativeTypeName("PCSTR")] sbyte* DriverStoreLocation, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfPublishedNameW([NativeTypeName("PCWSTR")] ushort* DriverStoreLocation, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfFileListA([NativeTypeName("PCSTR")] sbyte* DirectoryPath, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetInfFileListW([NativeTypeName("PCWSTR")] ushort* DirectoryPath, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HINF")]
        public static extern void* SetupOpenInfFileW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* InfClass, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HINF")]
        public static extern void* SetupOpenInfFileA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* InfClass, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HINF")]
        public static extern void* SetupOpenMasterInf();

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupOpenAppendInfFileW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupOpenAppendInfFileA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void SetupCloseInfFile([NativeTypeName("HINF")] void* InfHandle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindFirstLineA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindFirstLineW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindNextLine([NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextIn, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextOut);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindNextMatchLineA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextIn, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextOut);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFindNextMatchLineW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextIn, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* ContextOut);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetLineByIndexA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetLineByIndexW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetupGetLineCountA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetupGetLineCountW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetLineTextA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetLineTextW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFieldCount([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetStringFieldA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetStringFieldW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetIntField([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PINT")] int* IntegerValue);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetMultiSzFieldA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetMultiSzFieldW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetBinaryField([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PBYTE")] byte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFileCompressionInfoA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PSTR *")] sbyte** ActualSourceFileName, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFileCompressionInfoW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PWSTR *")] ushort** ActualSourceFileName, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetFileCompressionInfoExA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PSTR")] sbyte* ActualSourceFileNameBuffer, [NativeTypeName("DWORD")] uint ActualSourceFileNameBufferLen, [NativeTypeName("PDWORD")] uint* RequiredBufferLen, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetFileCompressionInfoExW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PWSTR")] ushort* ActualSourceFileNameBuffer, [NativeTypeName("DWORD")] uint ActualSourceFileNameBufferLen, [NativeTypeName("PDWORD")] uint* RequiredBufferLen, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupDecompressOrCopyFileA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PCSTR")] sbyte* TargetFileName, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupDecompressOrCopyFileW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PCWSTR")] ushort* TargetFileName, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceFileLocationA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PUINT")] uint* SourceId, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceFileLocationW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PUINT")] uint* SourceId, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceFileSizeA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PDWORD")] uint* FileSize, [NativeTypeName("UINT")] uint RoundingFactor);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceFileSizeW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PDWORD")] uint* FileSize, [NativeTypeName("UINT")] uint RoundingFactor);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetTargetPathA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetTargetPathW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR *")] sbyte** SourceList, [NativeTypeName("UINT")] uint SourceCount);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR *")] ushort** SourceList, [NativeTypeName("UINT")] uint SourceCount);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCancelTemporarySourceList();

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddToSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* Source);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddToSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* Source);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFromSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* Source);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFromSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* Source);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQuerySourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR **")] sbyte*** List, [NativeTypeName("PUINT")] uint* Count);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQuerySourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR **")] ushort*** List, [NativeTypeName("PUINT")] uint* Count);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFreeSourceListA([NativeTypeName("PCSTR **")] sbyte*** List, [NativeTypeName("UINT")] uint Count);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupFreeSourceListW([NativeTypeName("PCWSTR **")] ushort*** List, [NativeTypeName("UINT")] uint Count);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupPromptForDiskA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* DiskName, [NativeTypeName("PCSTR")] sbyte* PathToSource, [NativeTypeName("PCSTR")] sbyte* FileSought, [NativeTypeName("PCSTR")] sbyte* TagFile, [NativeTypeName("DWORD")] uint DiskPromptStyle, [NativeTypeName("PSTR")] sbyte* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupPromptForDiskW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* DiskName, [NativeTypeName("PCWSTR")] ushort* PathToSource, [NativeTypeName("PCWSTR")] ushort* FileSought, [NativeTypeName("PCWSTR")] ushort* TagFile, [NativeTypeName("DWORD")] uint DiskPromptStyle, [NativeTypeName("PWSTR")] ushort* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupCopyErrorA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* DiskName, [NativeTypeName("PCSTR")] sbyte* PathToSource, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetPathFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style, [NativeTypeName("PSTR")] sbyte* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupCopyErrorW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* DiskName, [NativeTypeName("PCWSTR")] ushort* PathToSource, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetPathFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style, [NativeTypeName("PWSTR")] ushort* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupRenameErrorA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupRenameErrorW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupDeleteErrorA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* File, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupDeleteErrorW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* File, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupBackupErrorA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupBackupErrorW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetFile, [NativeTypeName("UINT")] uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetDirectoryIdA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCSTR")] sbyte* Directory);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetDirectoryIdW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCWSTR")] ushort* Directory);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetDirectoryIdExA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCSTR")] sbyte* Directory, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetDirectoryIdExW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCWSTR")] ushort* Directory, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceInfoA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("UINT")] uint SourceId, [NativeTypeName("UINT")] uint InfoDesired, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetSourceInfoW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("UINT")] uint SourceId, [NativeTypeName("UINT")] uint InfoDesired, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFileA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* SourcePathRoot, [NativeTypeName("PCSTR")] sbyte* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFileW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* SourcePathRoot, [NativeTypeName("PCWSTR")] ushort* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFileExA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* SourcePathRoot, [NativeTypeName("PCSTR")] sbyte* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PBOOL")] int* FileWasInUse);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFileExW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* InfContext, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* SourcePathRoot, [NativeTypeName("PCWSTR")] ushort* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PBOOL")] int* FileWasInUse);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HSPFILEQ")]
        public static extern void* SetupOpenFileQueue();

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCloseFileQueue([NativeTypeName("HSPFILEQ")] void* QueueHandle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetFileQueueAlternatePlatformA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PCSTR")] sbyte* AlternateDefaultCatalogFile);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetFileQueueAlternatePlatformW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PCWSTR")] ushort* AlternateDefaultCatalogFile);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetPlatformPathOverrideA([NativeTypeName("PCSTR")] sbyte* Override);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetPlatformPathOverrideW([NativeTypeName("PCWSTR")] ushort* Override);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopyA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("PCSTR")] sbyte* SourcePath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* SourceDescription, [NativeTypeName("PCSTR")] sbyte* SourceTagfile, [NativeTypeName("PCSTR")] sbyte* TargetDirectory, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopyW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("PCWSTR")] ushort* SourcePath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* SourceDescription, [NativeTypeName("PCWSTR")] ushort* SourceTagfile, [NativeTypeName("PCWSTR")] ushort* TargetDirectory, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopyIndirectA([NativeTypeName("PSP_FILE_COPY_PARAMS_A")] SP_FILE_COPY_PARAMS_A* CopyParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopyIndirectW([NativeTypeName("PSP_FILE_COPY_PARAMS_W")] SP_FILE_COPY_PARAMS_W* CopyParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDefaultCopyA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDefaultCopyW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopySectionA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueCopySectionW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDeleteA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* PathPart1, [NativeTypeName("PCSTR")] sbyte* PathPart2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDeleteW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* PathPart1, [NativeTypeName("PCWSTR")] ushort* PathPart2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDeleteSectionA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueDeleteSectionW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueRenameA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourcePath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetPath, [NativeTypeName("PCSTR")] sbyte* TargetFilename);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueRenameW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourcePath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetPath, [NativeTypeName("PCWSTR")] ushort* TargetFilename);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueRenameSectionA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueueRenameSectionW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCommitFileQueueA([NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCommitFileQueueW([NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupScanFileQueueA([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HWND")] IntPtr Window, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CallbackRoutine, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PDWORD")] uint* Result);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupScanFileQueueW([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HWND")] IntPtr Window, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CallbackRoutine, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PDWORD")] uint* Result);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetFileQueueCount([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("UINT")] uint SubQueueFileOp, [NativeTypeName("PUINT")] uint* NumOperations);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetFileQueueFlags([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("PDWORD")] uint* Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetFileQueueFlags([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("DWORD")] uint FlagMask, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCopyOEMInfA([NativeTypeName("PCSTR")] sbyte* SourceInfFileName, [NativeTypeName("PCSTR")] sbyte* OEMSourceMediaLocation, [NativeTypeName("DWORD")] uint OEMSourceMediaType, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSTR")] sbyte* DestinationInfFileName, [NativeTypeName("DWORD")] uint DestinationInfFileNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** DestinationInfFileNameComponent);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupCopyOEMInfW([NativeTypeName("PCWSTR")] ushort* SourceInfFileName, [NativeTypeName("PCWSTR")] ushort* OEMSourceMediaLocation, [NativeTypeName("DWORD")] uint OEMSourceMediaType, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PWSTR")] ushort* DestinationInfFileName, [NativeTypeName("DWORD")] uint DestinationInfFileNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** DestinationInfFileNameComponent);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupUninstallOEMInfA([NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupUninstallOEMInfW([NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupUninstallNewlyCopiedInfs([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDSKSPC")]
        public static extern void* SetupCreateDiskSpaceListA([NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, [NativeTypeName("UINT")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDSKSPC")]
        public static extern void* SetupCreateDiskSpaceListW([NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, [NativeTypeName("UINT")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDSKSPC")]
        public static extern void* SetupDuplicateDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, [NativeTypeName("UINT")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDSKSPC")]
        public static extern void* SetupDuplicateDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, [NativeTypeName("UINT")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDestroyDiskSpaceList([NativeTypeName("HDSKSPC")] void* DiskSpace);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryDrivesInDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryDrivesInDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQuerySpaceRequiredOnDriveA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCSTR")] sbyte* DriveSpec, [NativeTypeName("LONGLONG *")] long* SpaceRequired, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQuerySpaceRequiredOnDriveW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCWSTR")] ushort* DriveSpec, [NativeTypeName("LONGLONG *")] long* SpaceRequired, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAdjustDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("LPCSTR")] sbyte* DriveRoot, [NativeTypeName("LONGLONG")] long Amount, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAdjustDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("LPCWSTR")] ushort* DriveRoot, [NativeTypeName("LONGLONG")] long Amount, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddToDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCSTR")] sbyte* TargetFilespec, [NativeTypeName("LONGLONG")] long FileSize, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddToDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCWSTR")] ushort* TargetFilespec, [NativeTypeName("LONGLONG")] long FileSize, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddSectionToDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddSectionToDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddInstallSectionToDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupAddInstallSectionToDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFromDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCSTR")] sbyte* TargetFilespec, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFromDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("PCWSTR")] ushort* TargetFilespec, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveSectionFromDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveSectionFromDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* ListInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("UINT")] uint Operation, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveInstallSectionFromDiskSpaceListA([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveInstallSectionFromDiskSpaceListW([NativeTypeName("HDSKSPC")] void* DiskSpace, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("UINT")] uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupIterateCabinetA([NativeTypeName("PCSTR")] sbyte* CabinetFile, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupIterateCabinetW([NativeTypeName("PCWSTR")] ushort* CabinetFile, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("INT")]
        public static extern int SetupPromptReboot([NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("BOOL")] int ScanOnly);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* SetupInitDefaultQueueCallback([NativeTypeName("HWND")] IntPtr OwnerWindow);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* SetupInitDefaultQueueCallbackEx([NativeTypeName("HWND")] IntPtr OwnerWindow, [NativeTypeName("HWND")] IntPtr AlternateProgressWindow, [NativeTypeName("UINT")] uint ProgressMessage, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern void SetupTermDefaultQueueCallback([NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupDefaultQueueCallbackA([NativeTypeName("PVOID")] void* Context, [NativeTypeName("UINT")] uint Notification, [NativeTypeName("UINT_PTR")] nuint Param1, [NativeTypeName("UINT_PTR")] nuint Param2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint SetupDefaultQueueCallbackW([NativeTypeName("PVOID")] void* Context, [NativeTypeName("UINT")] uint Notification, [NativeTypeName("UINT_PTR")] nuint Param1, [NativeTypeName("UINT_PTR")] nuint Param2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFromInfSectionA([NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("HKEY")] IntPtr RelativeKeyRoot, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("UINT")] uint CopyFlags, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFromInfSectionW([NativeTypeName("HWND")] IntPtr Owner, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("UINT")] uint Flags, [NativeTypeName("HKEY")] IntPtr RelativeKeyRoot, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("UINT")] uint CopyFlags, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFilesFromInfSectionA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("UINT")] uint CopyFlags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallFilesFromInfSectionW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("HINF")] void* LayoutInfHandle, [NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("UINT")] uint CopyFlags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallServicesFromInfSectionA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallServicesFromInfSectionW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallServicesFromInfSectionExA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupInstallServicesFromInfSectionExW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void InstallHinfSectionA([NativeTypeName("HWND")] IntPtr Window, [NativeTypeName("HINSTANCE")] IntPtr ModuleHandle, [NativeTypeName("PCSTR")] sbyte* CommandLine, [NativeTypeName("INT")] int ShowCommand);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void InstallHinfSectionW([NativeTypeName("HWND")] IntPtr Window, [NativeTypeName("HINSTANCE")] IntPtr ModuleHandle, [NativeTypeName("PCWSTR")] ushort* CommandLine, [NativeTypeName("INT")] int ShowCommand);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HSPFILELOG")]
        public static extern void* SetupInitializeFileLogA([NativeTypeName("PCSTR")] sbyte* LogFileName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HSPFILELOG")]
        public static extern void* SetupInitializeFileLogW([NativeTypeName("PCWSTR")] ushort* LogFileName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupTerminateFileLog([NativeTypeName("HSPFILELOG")] void* FileLogHandle);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupLogFileA([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint Checksum, [NativeTypeName("PCSTR")] sbyte* DiskTagfile, [NativeTypeName("PCSTR")] sbyte* DiskDescription, [NativeTypeName("PCSTR")] sbyte* OtherInfo, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupLogFileW([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint Checksum, [NativeTypeName("PCWSTR")] ushort* DiskTagfile, [NativeTypeName("PCWSTR")] ushort* DiskDescription, [NativeTypeName("PCWSTR")] ushort* OtherInfo, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFileLogEntryA([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* TargetFilename);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupRemoveFileLogEntryW([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* TargetFilename);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryFileLogA([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* TargetFilename, SetupFileLogInfo DesiredInfo, [NativeTypeName("PSTR")] sbyte* DataOut, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupQueryFileLogW([NativeTypeName("HSPFILELOG")] void* FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* TargetFilename, SetupFileLogInfo DesiredInfo, [NativeTypeName("PWSTR")] ushort* DataOut, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupOpenLog([NativeTypeName("BOOL")] int Erase);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupLogErrorA([NativeTypeName("LPCSTR")] sbyte* MessageString, [NativeTypeName("DWORD")] uint Severity);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupLogErrorW([NativeTypeName("LPCWSTR")] ushort* MessageString, [NativeTypeName("DWORD")] uint Severity);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void SetupCloseLog();

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("SP_LOG_TOKEN")]
        public static extern ulong SetupGetThreadLogToken();

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void SetupSetThreadLogToken([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void SetupWriteTextLog([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Category, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* MessageStr);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void SetupWriteTextLogError([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Category, [NativeTypeName("DWORD")] uint LogFlags, [NativeTypeName("DWORD")] uint Error, [NativeTypeName("PCSTR")] sbyte* MessageStr);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void SetupWriteTextLogInfLine([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetBackupInformationA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_BACKUP_QUEUE_PARAMS_A")] SP_BACKUP_QUEUE_PARAMS_V2_A* BackupParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetBackupInformationW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PSP_BACKUP_QUEUE_PARAMS_W")] SP_BACKUP_QUEUE_PARAMS_V2_W* BackupParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupPrepareQueueForRestoreA([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCSTR")] sbyte* BackupPath, [NativeTypeName("DWORD")] uint RestoreFlags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupPrepareQueueForRestoreW([NativeTypeName("HSPFILEQ")] void* QueueHandle, [NativeTypeName("PCWSTR")] ushort* BackupPath, [NativeTypeName("DWORD")] uint RestoreFlags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupSetNonInteractiveMode([NativeTypeName("BOOL")] int NonInteractiveFlag);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupGetNonInteractiveMode();

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiCreateDeviceInfoList([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("HWND")] IntPtr hwndParent);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiCreateDeviceInfoListExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiCreateDeviceInfoListExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInfoListClass([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("LPGUID")] Guid* ClassGuid);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInfoListDetailA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_LIST_DETAIL_DATA_A")] SP_DEVINFO_LIST_DETAIL_DATA_A* DeviceInfoSetDetailData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInfoListDetailW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_LIST_DETAIL_DATA_W")] SP_DEVINFO_LIST_DETAIL_DATA_W* DeviceInfoSetDetailData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCreateDeviceInfoA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DeviceName, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* DeviceDescription, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCreateDeviceInfoW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DeviceName, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* DeviceDescription, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiOpenDeviceInfoA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DeviceInstanceId, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiOpenDeviceInfoW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DeviceInstanceId, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInstanceIdA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSTR")] sbyte* DeviceInstanceId, [NativeTypeName("DWORD")] uint DeviceInstanceIdSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInstanceIdW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PWSTR")] ushort* DeviceInstanceId, [NativeTypeName("DWORD")] uint DeviceInstanceIdSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDeleteDeviceInfo([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiEnumDeviceInfo([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDestroyDeviceInfoList([NativeTypeName("HDEVINFO")] void* DeviceInfoSet);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiEnumDeviceInterfaces([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCreateDeviceInterfaceA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PCSTR")] sbyte* ReferenceString, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCreateDeviceInterfaceW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PCWSTR")] ushort* ReferenceString, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiOpenDeviceInterfaceA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DevicePath, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiOpenDeviceInterfaceW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DevicePath, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfaceAlias([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("const GUID *")] Guid* AliasInterfaceClassGuid, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* AliasDeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDeleteDeviceInterfaceData([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRemoveDeviceInterface([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfaceDetailA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("PSP_DEVICE_INTERFACE_DETAIL_DATA_A")] SP_DEVICE_INTERFACE_DETAIL_DATA_A* DeviceInterfaceDetailData, [NativeTypeName("DWORD")] uint DeviceInterfaceDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfaceDetailW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("PSP_DEVICE_INTERFACE_DETAIL_DATA_W")] SP_DEVICE_INTERFACE_DETAIL_DATA_W* DeviceInterfaceDetailData, [NativeTypeName("DWORD")] uint DeviceInterfaceDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallDeviceInterfaces([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceInterfaceDefault([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRegisterDeviceInfo([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PSP_DETSIG_CMPPROC")] delegate* unmanaged<void*, SP_DEVINFO_DATA*, SP_DEVINFO_DATA*, void*, uint> CompareProc, [NativeTypeName("PVOID")] void* CompareContext, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DupDeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiBuildDriverInfoList([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCancelDriverInfoSearch([NativeTypeName("HDEVINFO")] void* DeviceInfoSet);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiEnumDriverInfoA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiEnumDriverInfoW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetSelectedDriverA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetSelectedDriverW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetSelectedDriverA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetSelectedDriverW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDriverInfoDetailA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData, [NativeTypeName("PSP_DRVINFO_DETAIL_DATA_A")] SP_DRVINFO_DETAIL_DATA_A* DriverInfoDetailData, [NativeTypeName("DWORD")] uint DriverInfoDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDriverInfoDetailW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData, [NativeTypeName("PSP_DRVINFO_DETAIL_DATA_W")] SP_DRVINFO_DETAIL_DATA_W* DriverInfoDetailData, [NativeTypeName("DWORD")] uint DriverInfoDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDestroyDriverInfoList([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiGetClassDevsA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* Enumerator, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiGetClassDevsW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* Enumerator, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiGetClassDevsExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* Enumerator, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HDEVINFO")]
        public static extern void* SetupDiGetClassDevsExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* Enumerator, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetINFClassA([NativeTypeName("PCSTR")] sbyte* InfName, [NativeTypeName("LPGUID")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetINFClassW([NativeTypeName("PCWSTR")] ushort* InfName, [NativeTypeName("LPGUID")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiBuildClassInfoList([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiBuildClassInfoListExA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiBuildClassInfoListExW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDescriptionA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDescriptionW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDescriptionExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDescriptionExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiCallClassInstaller([NativeTypeName("DI_FUNCTION")] uint InstallFunction, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSelectDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSelectBestCompatDrv([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallDriverFiles([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRegisterCoDeviceInstallers([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRemoveDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiUnremoveDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiRestartDevices([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiChangeState([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallClassA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HSPFILEQ")] void* FileQueue);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallClassW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HSPFILEQ")] void* FileQueue);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallClassExA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiInstallClassExW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HSPFILEQ")] void* FileQueue, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenClassRegKey([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenClassRegKeyExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenClassRegKeyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiCreateDeviceInterfaceRegKeyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiCreateDeviceInterfaceRegKeyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenDeviceInterfaceRegKey([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDeleteDeviceInterfaceRegKey([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiCreateDevRegKeyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiCreateDevRegKeyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, [NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HKEY")]
        public static extern IntPtr SetupDiOpenDevRegKey([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDeleteDevRegKey([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileList([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileListExA([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileListExW([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDevicePropertyKeys([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DEVPROPKEY *")] DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDevicePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDevicePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfacePropertyKeys([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("DEVPROPKEY *")] DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInterfacePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceInterfacePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassPropertyKeys([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DEVPROPKEY *")] DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassPropertyKeysExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DEVPROPKEY *")] DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassPropertyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassPropertyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceRegistryPropertyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceRegistryPropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassRegistryPropertyA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassRegistryPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceRegistryPropertyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceRegistryPropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassRegistryPropertyA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassRegistryPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_A")] SP_DEVINSTALL_PARAMS_A* DeviceInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDeviceInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_W")] SP_DEVINSTALL_PARAMS_W* DeviceInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] SP_CLASSINSTALL_HEADER* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] SP_CLASSINSTALL_HEADER* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_A")] SP_DEVINSTALL_PARAMS_A* DeviceInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDeviceInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_W")] SP_DEVINSTALL_PARAMS_W* DeviceInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] SP_CLASSINSTALL_HEADER* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetClassInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] SP_CLASSINSTALL_HEADER* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDriverInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] SP_DRVINSTALL_PARAMS* DriverInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetDriverInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] SP_DRVINSTALL_PARAMS* DriverInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDriverInstallParamsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] SP_DRVINFO_DATA_V2_A* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] SP_DRVINSTALL_PARAMS* DriverInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetDriverInstallParamsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] SP_DRVINFO_DATA_V2_W* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] SP_DRVINSTALL_PARAMS* DriverInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiLoadClassIcon([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("HICON *")] IntPtr* LargeIcon, [NativeTypeName("PINT")] int* MiniIconIndex);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiLoadDeviceIcon([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("UINT")] uint cxIcon, [NativeTypeName("UINT")] uint cyIcon, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("HICON *")] IntPtr* hIcon);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("INT")]
        public static extern int SetupDiDrawMiniIcon([NativeTypeName("HDC")] IntPtr hdc, RECT rc, [NativeTypeName("INT")] int MiniIconIndex, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassBitmapIndex([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PINT")] int* MiniIconIndex);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassImageList([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassImageListExA([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassImageListExW([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassImageIndex([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PINT")] int* ImageIndex);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiDestroyClassImageList([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] SP_CLASSIMAGELIST_DATA* ClassImageListData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDevPropertySheetsA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("LPPROPSHEETHEADERA")] PROPSHEETHEADERA_V2* PropertySheetHeader, [NativeTypeName("DWORD")] uint PropertySheetHeaderPageListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint PropertySheetType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetClassDevPropertySheetsW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("LPPROPSHEETHEADERW")] PROPSHEETHEADERW_V2* PropertySheetHeader, [NativeTypeName("DWORD")] uint PropertySheetHeaderPageListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint PropertySheetType);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiAskForOEMDisk([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSelectOEMDrv([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassNameFromGuidA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassNameFromGuidW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassNameFromGuidExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassNameFromGuidExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassGuidsFromNameA([NativeTypeName("PCSTR")] sbyte* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassGuidsFromNameW([NativeTypeName("PCWSTR")] ushort* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassGuidsFromNameExA([NativeTypeName("PCSTR")] sbyte* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiClassGuidsFromNameExW([NativeTypeName("PCWSTR")] ushort* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileFriendlyNameA([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PSTR")] sbyte* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileFriendlyNameW([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PWSTR")] ushort* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileFriendlyNameExA([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PSTR")] sbyte* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetHwProfileFriendlyNameExW([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PWSTR")] ushort* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("HPROPSHEETPAGE")]
        public static extern IntPtr SetupDiGetWizardPage([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PSP_INSTALLWIZARD_DATA")] SP_INSTALLWIZARD_DATA* InstallWizardData, [NativeTypeName("DWORD")] uint PageType, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetSelectedDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiSetSelectedDevice([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualModelsSectionA([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualModelsSectionW([NativeTypeName("PINFCONTEXT")] INFCONTEXT* Context, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualSectionToInstallA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** Extension);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualSectionToInstallW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** Extension);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualSectionToInstallExA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** Extension, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetActualSectionToInstallExW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AlternatePlatformInfo, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** Extension, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupEnumInfSectionsA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("UINT")] uint Index, [NativeTypeName("PSTR")] sbyte* Buffer, [NativeTypeName("UINT")] uint Size, [NativeTypeName("UINT *")] uint* SizeNeeded);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupEnumInfSectionsW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("UINT")] uint Index, [NativeTypeName("PWSTR")] ushort* Buffer, [NativeTypeName("UINT")] uint Size, [NativeTypeName("UINT *")] uint* SizeNeeded);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupVerifyInfFileA([NativeTypeName("PCSTR")] sbyte* InfName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AltPlatformInfo, [NativeTypeName("PSP_INF_SIGNER_INFO_A")] SP_INF_SIGNER_INFO_V2_A* InfSignerInfo);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupVerifyInfFileW([NativeTypeName("PCWSTR")] ushort* InfName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] SP_ALTPLATFORM_INFO_V2* AltPlatformInfo, [NativeTypeName("PSP_INF_SIGNER_INFO_W")] SP_INF_SIGNER_INFO_V2_W* InfSignerInfo);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetCustomDevicePropertyA([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PCSTR")] sbyte* CustomPropertyName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupDiGetCustomDevicePropertyW([NativeTypeName("HDEVINFO")] void* DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] SP_DEVINFO_DATA* DeviceInfoData, [NativeTypeName("PCWSTR")] ushort* CustomPropertyName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupConfigureWmiFromInfSectionA([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetupConfigureWmiFromInfSectionW([NativeTypeName("HINF")] void* InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [NativeTypeName("#define _SETUPAPI_VER _WIN32_WINNT")]
        public const int _SETUPAPI_VER = 0x0A00;

        [NativeTypeName("#define LINE_LEN 256")]
        public const int LINE_LEN = 256;

        [NativeTypeName("#define MAX_INF_STRING_LENGTH 4096")]
        public const int MAX_INF_STRING_LENGTH = 4096;

        [NativeTypeName("#define MAX_INF_SECTION_NAME_LENGTH 255")]
        public const int MAX_INF_SECTION_NAME_LENGTH = 255;

        [NativeTypeName("#define MAX_TITLE_LEN 60")]
        public const int MAX_TITLE_LEN = 60;

        [NativeTypeName("#define MAX_INSTRUCTION_LEN 256")]
        public const int MAX_INSTRUCTION_LEN = 256;

        [NativeTypeName("#define MAX_LABEL_LEN 30")]
        public const int MAX_LABEL_LEN = 30;

        [NativeTypeName("#define MAX_SERVICE_NAME_LEN 256")]
        public const int MAX_SERVICE_NAME_LEN = 256;

        [NativeTypeName("#define MAX_SUBTITLE_LEN 256")]
        public const int MAX_SUBTITLE_LEN = 256;

        [NativeTypeName("#define SP_MAX_MACHINENAME_LENGTH (MAX_PATH + 3)")]
        public const int SP_MAX_MACHINENAME_LENGTH = (260 + 3);

        [NativeTypeName("#define SP_ALTPLATFORM_FLAGS_VERSION_RANGE (0x0001)")]
        public const int SP_ALTPLATFORM_FLAGS_VERSION_RANGE = (0x0001);

        [NativeTypeName("#define SP_ALTPLATFORM_FLAGS_SUITE_MASK (0x0002)")]
        public const int SP_ALTPLATFORM_FLAGS_SUITE_MASK = (0x0002);

        [NativeTypeName("#define INF_STYLE_NONE 0x00000000")]
        public const int INF_STYLE_NONE = 0x00000000;

        [NativeTypeName("#define INF_STYLE_OLDNT 0x00000001")]
        public const int INF_STYLE_OLDNT = 0x00000001;

        [NativeTypeName("#define INF_STYLE_WIN4 0x00000002")]
        public const int INF_STYLE_WIN4 = 0x00000002;

        [NativeTypeName("#define INF_STYLE_CACHE_ENABLE 0x00000010")]
        public const int INF_STYLE_CACHE_ENABLE = 0x00000010;

        [NativeTypeName("#define INF_STYLE_CACHE_DISABLE 0x00000020")]
        public const int INF_STYLE_CACHE_DISABLE = 0x00000020;

        [NativeTypeName("#define INF_STYLE_CACHE_IGNORE 0x00000040")]
        public const int INF_STYLE_CACHE_IGNORE = 0x00000040;

        [NativeTypeName("#define DIRID_ABSOLUTE -1")]
        public const int DIRID_ABSOLUTE = -1;

        [NativeTypeName("#define DIRID_ABSOLUTE_16BIT 0xffff")]
        public const int DIRID_ABSOLUTE_16BIT = 0xffff;

        [NativeTypeName("#define DIRID_NULL 0")]
        public const int DIRID_NULL = 0;

        [NativeTypeName("#define DIRID_SRCPATH 1")]
        public const int DIRID_SRCPATH = 1;

        [NativeTypeName("#define DIRID_WINDOWS 10")]
        public const int DIRID_WINDOWS = 10;

        [NativeTypeName("#define DIRID_SYSTEM 11")]
        public const int DIRID_SYSTEM = 11;

        [NativeTypeName("#define DIRID_DRIVERS 12")]
        public const int DIRID_DRIVERS = 12;

        [NativeTypeName("#define DIRID_IOSUBSYS DIRID_DRIVERS")]
        public const int DIRID_IOSUBSYS = 12;

        [NativeTypeName("#define DIRID_DRIVER_STORE 13")]
        public const int DIRID_DRIVER_STORE = 13;

        [NativeTypeName("#define DIRID_INF 17")]
        public const int DIRID_INF = 17;

        [NativeTypeName("#define DIRID_HELP 18")]
        public const int DIRID_HELP = 18;

        [NativeTypeName("#define DIRID_FONTS 20")]
        public const int DIRID_FONTS = 20;

        [NativeTypeName("#define DIRID_VIEWERS 21")]
        public const int DIRID_VIEWERS = 21;

        [NativeTypeName("#define DIRID_COLOR 23")]
        public const int DIRID_COLOR = 23;

        [NativeTypeName("#define DIRID_APPS 24")]
        public const int DIRID_APPS = 24;

        [NativeTypeName("#define DIRID_SHARED 25")]
        public const int DIRID_SHARED = 25;

        [NativeTypeName("#define DIRID_BOOT 30")]
        public const int DIRID_BOOT = 30;

        [NativeTypeName("#define DIRID_SYSTEM16 50")]
        public const int DIRID_SYSTEM16 = 50;

        [NativeTypeName("#define DIRID_SPOOL 51")]
        public const int DIRID_SPOOL = 51;

        [NativeTypeName("#define DIRID_SPOOLDRIVERS 52")]
        public const int DIRID_SPOOLDRIVERS = 52;

        [NativeTypeName("#define DIRID_USERPROFILE 53")]
        public const int DIRID_USERPROFILE = 53;

        [NativeTypeName("#define DIRID_LOADER 54")]
        public const int DIRID_LOADER = 54;

        [NativeTypeName("#define DIRID_PRINTPROCESSOR 55")]
        public const int DIRID_PRINTPROCESSOR = 55;

        [NativeTypeName("#define DIRID_DEFAULT DIRID_SYSTEM")]
        public const int DIRID_DEFAULT = 11;

        [NativeTypeName("#define DIRID_COMMON_STARTMENU 16406")]
        public const int DIRID_COMMON_STARTMENU = 16406;

        [NativeTypeName("#define DIRID_COMMON_PROGRAMS 16407")]
        public const int DIRID_COMMON_PROGRAMS = 16407;

        [NativeTypeName("#define DIRID_COMMON_STARTUP 16408")]
        public const int DIRID_COMMON_STARTUP = 16408;

        [NativeTypeName("#define DIRID_COMMON_DESKTOPDIRECTORY 16409")]
        public const int DIRID_COMMON_DESKTOPDIRECTORY = 16409;

        [NativeTypeName("#define DIRID_COMMON_FAVORITES 16415")]
        public const int DIRID_COMMON_FAVORITES = 16415;

        [NativeTypeName("#define DIRID_COMMON_APPDATA 16419")]
        public const int DIRID_COMMON_APPDATA = 16419;

        [NativeTypeName("#define DIRID_PROGRAM_FILES 16422")]
        public const int DIRID_PROGRAM_FILES = 16422;

        [NativeTypeName("#define DIRID_SYSTEM_X86 16425")]
        public const int DIRID_SYSTEM_X86 = 16425;

        [NativeTypeName("#define DIRID_PROGRAM_FILES_X86 16426")]
        public const int DIRID_PROGRAM_FILES_X86 = 16426;

        [NativeTypeName("#define DIRID_PROGRAM_FILES_COMMON 16427")]
        public const int DIRID_PROGRAM_FILES_COMMON = 16427;

        [NativeTypeName("#define DIRID_PROGRAM_FILES_COMMONX86 16428")]
        public const int DIRID_PROGRAM_FILES_COMMONX86 = 16428;

        [NativeTypeName("#define DIRID_COMMON_TEMPLATES 16429")]
        public const int DIRID_COMMON_TEMPLATES = 16429;

        [NativeTypeName("#define DIRID_COMMON_DOCUMENTS 16430")]
        public const int DIRID_COMMON_DOCUMENTS = 16430;

        [NativeTypeName("#define DIRID_USER 0x8000")]
        public const int DIRID_USER = 0x8000;

        [NativeTypeName("#define SPFILENOTIFY_STARTQUEUE 0x00000001")]
        public const int SPFILENOTIFY_STARTQUEUE = 0x00000001;

        [NativeTypeName("#define SPFILENOTIFY_ENDQUEUE 0x00000002")]
        public const int SPFILENOTIFY_ENDQUEUE = 0x00000002;

        [NativeTypeName("#define SPFILENOTIFY_STARTSUBQUEUE 0x00000003")]
        public const int SPFILENOTIFY_STARTSUBQUEUE = 0x00000003;

        [NativeTypeName("#define SPFILENOTIFY_ENDSUBQUEUE 0x00000004")]
        public const int SPFILENOTIFY_ENDSUBQUEUE = 0x00000004;

        [NativeTypeName("#define SPFILENOTIFY_STARTDELETE 0x00000005")]
        public const int SPFILENOTIFY_STARTDELETE = 0x00000005;

        [NativeTypeName("#define SPFILENOTIFY_ENDDELETE 0x00000006")]
        public const int SPFILENOTIFY_ENDDELETE = 0x00000006;

        [NativeTypeName("#define SPFILENOTIFY_DELETEERROR 0x00000007")]
        public const int SPFILENOTIFY_DELETEERROR = 0x00000007;

        [NativeTypeName("#define SPFILENOTIFY_STARTRENAME 0x00000008")]
        public const int SPFILENOTIFY_STARTRENAME = 0x00000008;

        [NativeTypeName("#define SPFILENOTIFY_ENDRENAME 0x00000009")]
        public const int SPFILENOTIFY_ENDRENAME = 0x00000009;

        [NativeTypeName("#define SPFILENOTIFY_RENAMEERROR 0x0000000a")]
        public const int SPFILENOTIFY_RENAMEERROR = 0x0000000a;

        [NativeTypeName("#define SPFILENOTIFY_STARTCOPY 0x0000000b")]
        public const int SPFILENOTIFY_STARTCOPY = 0x0000000b;

        [NativeTypeName("#define SPFILENOTIFY_ENDCOPY 0x0000000c")]
        public const int SPFILENOTIFY_ENDCOPY = 0x0000000c;

        [NativeTypeName("#define SPFILENOTIFY_COPYERROR 0x0000000d")]
        public const int SPFILENOTIFY_COPYERROR = 0x0000000d;

        [NativeTypeName("#define SPFILENOTIFY_NEEDMEDIA 0x0000000e")]
        public const int SPFILENOTIFY_NEEDMEDIA = 0x0000000e;

        [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN 0x0000000f")]
        public const int SPFILENOTIFY_QUEUESCAN = 0x0000000f;

        [NativeTypeName("#define SPFILENOTIFY_CABINETINFO 0x00000010")]
        public const int SPFILENOTIFY_CABINETINFO = 0x00000010;

        [NativeTypeName("#define SPFILENOTIFY_FILEINCABINET 0x00000011")]
        public const int SPFILENOTIFY_FILEINCABINET = 0x00000011;

        [NativeTypeName("#define SPFILENOTIFY_NEEDNEWCABINET 0x00000012")]
        public const int SPFILENOTIFY_NEEDNEWCABINET = 0x00000012;

        [NativeTypeName("#define SPFILENOTIFY_FILEEXTRACTED 0x00000013")]
        public const int SPFILENOTIFY_FILEEXTRACTED = 0x00000013;

        [NativeTypeName("#define SPFILENOTIFY_FILEOPDELAYED 0x00000014")]
        public const int SPFILENOTIFY_FILEOPDELAYED = 0x00000014;

        [NativeTypeName("#define SPFILENOTIFY_STARTBACKUP 0x00000015")]
        public const int SPFILENOTIFY_STARTBACKUP = 0x00000015;

        [NativeTypeName("#define SPFILENOTIFY_BACKUPERROR 0x00000016")]
        public const int SPFILENOTIFY_BACKUPERROR = 0x00000016;

        [NativeTypeName("#define SPFILENOTIFY_ENDBACKUP 0x00000017")]
        public const int SPFILENOTIFY_ENDBACKUP = 0x00000017;

        [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN_EX 0x00000018")]
        public const int SPFILENOTIFY_QUEUESCAN_EX = 0x00000018;

        [NativeTypeName("#define SPFILENOTIFY_STARTREGISTRATION 0x00000019")]
        public const int SPFILENOTIFY_STARTREGISTRATION = 0x00000019;

        [NativeTypeName("#define SPFILENOTIFY_ENDREGISTRATION 0x00000020")]
        public const int SPFILENOTIFY_ENDREGISTRATION = 0x00000020;

        [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN_SIGNERINFO 0x00000040")]
        public const int SPFILENOTIFY_QUEUESCAN_SIGNERINFO = 0x00000040;

        [NativeTypeName("#define SPFILENOTIFY_LANGMISMATCH 0x00010000")]
        public const int SPFILENOTIFY_LANGMISMATCH = 0x00010000;

        [NativeTypeName("#define SPFILENOTIFY_TARGETEXISTS 0x00020000")]
        public const int SPFILENOTIFY_TARGETEXISTS = 0x00020000;

        [NativeTypeName("#define SPFILENOTIFY_TARGETNEWER 0x00040000")]
        public const int SPFILENOTIFY_TARGETNEWER = 0x00040000;

        [NativeTypeName("#define FILEOP_COPY 0")]
        public const int FILEOP_COPY = 0;

        [NativeTypeName("#define FILEOP_RENAME 1")]
        public const int FILEOP_RENAME = 1;

        [NativeTypeName("#define FILEOP_DELETE 2")]
        public const int FILEOP_DELETE = 2;

        [NativeTypeName("#define FILEOP_BACKUP 3")]
        public const int FILEOP_BACKUP = 3;

        [NativeTypeName("#define FILEOP_ABORT 0")]
        public const int FILEOP_ABORT = 0;

        [NativeTypeName("#define FILEOP_DOIT 1")]
        public const int FILEOP_DOIT = 1;

        [NativeTypeName("#define FILEOP_SKIP 2")]
        public const int FILEOP_SKIP = 2;

        [NativeTypeName("#define FILEOP_RETRY FILEOP_DOIT")]
        public const int FILEOP_RETRY = 1;

        [NativeTypeName("#define FILEOP_NEWPATH 4")]
        public const int FILEOP_NEWPATH = 4;

        [NativeTypeName("#define COPYFLG_WARN_IF_SKIP 0x00000001")]
        public const int COPYFLG_WARN_IF_SKIP = 0x00000001;

        [NativeTypeName("#define COPYFLG_NOSKIP 0x00000002")]
        public const int COPYFLG_NOSKIP = 0x00000002;

        [NativeTypeName("#define COPYFLG_NOVERSIONCHECK 0x00000004")]
        public const int COPYFLG_NOVERSIONCHECK = 0x00000004;

        [NativeTypeName("#define COPYFLG_FORCE_FILE_IN_USE 0x00000008")]
        public const int COPYFLG_FORCE_FILE_IN_USE = 0x00000008;

        [NativeTypeName("#define COPYFLG_NO_OVERWRITE 0x00000010")]
        public const int COPYFLG_NO_OVERWRITE = 0x00000010;

        [NativeTypeName("#define COPYFLG_NO_VERSION_DIALOG 0x00000020")]
        public const int COPYFLG_NO_VERSION_DIALOG = 0x00000020;

        [NativeTypeName("#define COPYFLG_OVERWRITE_OLDER_ONLY 0x00000040")]
        public const int COPYFLG_OVERWRITE_OLDER_ONLY = 0x00000040;

        [NativeTypeName("#define COPYFLG_PROTECTED_WINDOWS_DRIVER_FILE 0x00000100")]
        public const int COPYFLG_PROTECTED_WINDOWS_DRIVER_FILE = 0x00000100;

        [NativeTypeName("#define COPYFLG_REPLACEONLY 0x00000400")]
        public const int COPYFLG_REPLACEONLY = 0x00000400;

        [NativeTypeName("#define COPYFLG_NODECOMP 0x00000800")]
        public const int COPYFLG_NODECOMP = 0x00000800;

        [NativeTypeName("#define COPYFLG_REPLACE_BOOT_FILE 0x00001000")]
        public const int COPYFLG_REPLACE_BOOT_FILE = 0x00001000;

        [NativeTypeName("#define COPYFLG_NOPRUNE 0x00002000")]
        public const int COPYFLG_NOPRUNE = 0x00002000;

        [NativeTypeName("#define COPYFLG_IN_USE_TRY_RENAME 0x00004000")]
        public const int COPYFLG_IN_USE_TRY_RENAME = 0x00004000;

        [NativeTypeName("#define DELFLG_IN_USE 0x00000001")]
        public const int DELFLG_IN_USE = 0x00000001;

        [NativeTypeName("#define DELFLG_IN_USE1 0x00010000")]
        public const int DELFLG_IN_USE1 = 0x00010000;

        [NativeTypeName("#define SPREG_SUCCESS 0x00000000")]
        public const int SPREG_SUCCESS = 0x00000000;

        [NativeTypeName("#define SPREG_LOADLIBRARY 0x00000001")]
        public const int SPREG_LOADLIBRARY = 0x00000001;

        [NativeTypeName("#define SPREG_GETPROCADDR 0x00000002")]
        public const int SPREG_GETPROCADDR = 0x00000002;

        [NativeTypeName("#define SPREG_REGSVR 0x00000003")]
        public const int SPREG_REGSVR = 0x00000003;

        [NativeTypeName("#define SPREG_DLLINSTALL 0x00000004")]
        public const int SPREG_DLLINSTALL = 0x00000004;

        [NativeTypeName("#define SPREG_TIMEOUT 0x00000005")]
        public const int SPREG_TIMEOUT = 0x00000005;

        [NativeTypeName("#define SPREG_UNKNOWN 0xFFFFFFFF")]
        public const uint SPREG_UNKNOWN = 0xFFFFFFFF;

        [NativeTypeName("#define SPINT_ACTIVE 0x00000001")]
        public const int SPINT_ACTIVE = 0x00000001;

        [NativeTypeName("#define SPINT_DEFAULT 0x00000002")]
        public const int SPINT_DEFAULT = 0x00000002;

        [NativeTypeName("#define SPINT_REMOVED 0x00000004")]
        public const int SPINT_REMOVED = 0x00000004;

        [NativeTypeName("#define SPID_ACTIVE SPINT_ACTIVE")]
        public const int SPID_ACTIVE = 0x00000001;

        [NativeTypeName("#define SPID_DEFAULT SPINT_DEFAULT")]
        public const int SPID_DEFAULT = 0x00000002;

        [NativeTypeName("#define SPID_REMOVED SPINT_REMOVED")]
        public const int SPID_REMOVED = 0x00000004;

        [NativeTypeName("#define DIF_SELECTDEVICE 0x00000001")]
        public const int DIF_SELECTDEVICE = 0x00000001;

        [NativeTypeName("#define DIF_INSTALLDEVICE 0x00000002")]
        public const int DIF_INSTALLDEVICE = 0x00000002;

        [NativeTypeName("#define DIF_ASSIGNRESOURCES 0x00000003")]
        public const int DIF_ASSIGNRESOURCES = 0x00000003;

        [NativeTypeName("#define DIF_PROPERTIES 0x00000004")]
        public const int DIF_PROPERTIES = 0x00000004;

        [NativeTypeName("#define DIF_REMOVE 0x00000005")]
        public const int DIF_REMOVE = 0x00000005;

        [NativeTypeName("#define DIF_FIRSTTIMESETUP 0x00000006")]
        public const int DIF_FIRSTTIMESETUP = 0x00000006;

        [NativeTypeName("#define DIF_FOUNDDEVICE 0x00000007")]
        public const int DIF_FOUNDDEVICE = 0x00000007;

        [NativeTypeName("#define DIF_SELECTCLASSDRIVERS 0x00000008")]
        public const int DIF_SELECTCLASSDRIVERS = 0x00000008;

        [NativeTypeName("#define DIF_VALIDATECLASSDRIVERS 0x00000009")]
        public const int DIF_VALIDATECLASSDRIVERS = 0x00000009;

        [NativeTypeName("#define DIF_INSTALLCLASSDRIVERS 0x0000000A")]
        public const int DIF_INSTALLCLASSDRIVERS = 0x0000000A;

        [NativeTypeName("#define DIF_CALCDISKSPACE 0x0000000B")]
        public const int DIF_CALCDISKSPACE = 0x0000000B;

        [NativeTypeName("#define DIF_DESTROYPRIVATEDATA 0x0000000C")]
        public const int DIF_DESTROYPRIVATEDATA = 0x0000000C;

        [NativeTypeName("#define DIF_VALIDATEDRIVER 0x0000000D")]
        public const int DIF_VALIDATEDRIVER = 0x0000000D;

        [NativeTypeName("#define DIF_DETECT 0x0000000F")]
        public const int DIF_DETECT = 0x0000000F;

        [NativeTypeName("#define DIF_INSTALLWIZARD 0x00000010")]
        public const int DIF_INSTALLWIZARD = 0x00000010;

        [NativeTypeName("#define DIF_DESTROYWIZARDDATA 0x00000011")]
        public const int DIF_DESTROYWIZARDDATA = 0x00000011;

        [NativeTypeName("#define DIF_PROPERTYCHANGE 0x00000012")]
        public const int DIF_PROPERTYCHANGE = 0x00000012;

        [NativeTypeName("#define DIF_ENABLECLASS 0x00000013")]
        public const int DIF_ENABLECLASS = 0x00000013;

        [NativeTypeName("#define DIF_DETECTVERIFY 0x00000014")]
        public const int DIF_DETECTVERIFY = 0x00000014;

        [NativeTypeName("#define DIF_INSTALLDEVICEFILES 0x00000015")]
        public const int DIF_INSTALLDEVICEFILES = 0x00000015;

        [NativeTypeName("#define DIF_UNREMOVE 0x00000016")]
        public const int DIF_UNREMOVE = 0x00000016;

        [NativeTypeName("#define DIF_SELECTBESTCOMPATDRV 0x00000017")]
        public const int DIF_SELECTBESTCOMPATDRV = 0x00000017;

        [NativeTypeName("#define DIF_ALLOW_INSTALL 0x00000018")]
        public const int DIF_ALLOW_INSTALL = 0x00000018;

        [NativeTypeName("#define DIF_REGISTERDEVICE 0x00000019")]
        public const int DIF_REGISTERDEVICE = 0x00000019;

        [NativeTypeName("#define DIF_NEWDEVICEWIZARD_PRESELECT 0x0000001A")]
        public const int DIF_NEWDEVICEWIZARD_PRESELECT = 0x0000001A;

        [NativeTypeName("#define DIF_NEWDEVICEWIZARD_SELECT 0x0000001B")]
        public const int DIF_NEWDEVICEWIZARD_SELECT = 0x0000001B;

        [NativeTypeName("#define DIF_NEWDEVICEWIZARD_PREANALYZE 0x0000001C")]
        public const int DIF_NEWDEVICEWIZARD_PREANALYZE = 0x0000001C;

        [NativeTypeName("#define DIF_NEWDEVICEWIZARD_POSTANALYZE 0x0000001D")]
        public const int DIF_NEWDEVICEWIZARD_POSTANALYZE = 0x0000001D;

        [NativeTypeName("#define DIF_NEWDEVICEWIZARD_FINISHINSTALL 0x0000001E")]
        public const int DIF_NEWDEVICEWIZARD_FINISHINSTALL = 0x0000001E;

        [NativeTypeName("#define DIF_UNUSED1 0x0000001F")]
        public const int DIF_UNUSED1 = 0x0000001F;

        [NativeTypeName("#define DIF_INSTALLINTERFACES 0x00000020")]
        public const int DIF_INSTALLINTERFACES = 0x00000020;

        [NativeTypeName("#define DIF_DETECTCANCEL 0x00000021")]
        public const int DIF_DETECTCANCEL = 0x00000021;

        [NativeTypeName("#define DIF_REGISTER_COINSTALLERS 0x00000022")]
        public const int DIF_REGISTER_COINSTALLERS = 0x00000022;

        [NativeTypeName("#define DIF_ADDPROPERTYPAGE_ADVANCED 0x00000023")]
        public const int DIF_ADDPROPERTYPAGE_ADVANCED = 0x00000023;

        [NativeTypeName("#define DIF_ADDPROPERTYPAGE_BASIC 0x00000024")]
        public const int DIF_ADDPROPERTYPAGE_BASIC = 0x00000024;

        [NativeTypeName("#define DIF_RESERVED1 0x00000025")]
        public const int DIF_RESERVED1 = 0x00000025;

        [NativeTypeName("#define DIF_TROUBLESHOOTER 0x00000026")]
        public const int DIF_TROUBLESHOOTER = 0x00000026;

        [NativeTypeName("#define DIF_POWERMESSAGEWAKE 0x00000027")]
        public const int DIF_POWERMESSAGEWAKE = 0x00000027;

        [NativeTypeName("#define DIF_ADDREMOTEPROPERTYPAGE_ADVANCED 0x00000028")]
        public const int DIF_ADDREMOTEPROPERTYPAGE_ADVANCED = 0x00000028;

        [NativeTypeName("#define DIF_UPDATEDRIVER_UI 0x00000029")]
        public const int DIF_UPDATEDRIVER_UI = 0x00000029;

        [NativeTypeName("#define DIF_FINISHINSTALL_ACTION 0x0000002A")]
        public const int DIF_FINISHINSTALL_ACTION = 0x0000002A;

        [NativeTypeName("#define DIF_RESERVED2 0x00000030")]
        public const int DIF_RESERVED2 = 0x00000030;

        [NativeTypeName("#define DIF_MOVEDEVICE 0x0000000E")]
        public const int DIF_MOVEDEVICE = 0x0000000E;

        [NativeTypeName("#define DI_SHOWOEM 0x00000001L")]
        public const int DI_SHOWOEM = 0x00000001;

        [NativeTypeName("#define DI_SHOWCOMPAT 0x00000002L")]
        public const int DI_SHOWCOMPAT = 0x00000002;

        [NativeTypeName("#define DI_SHOWCLASS 0x00000004L")]
        public const int DI_SHOWCLASS = 0x00000004;

        [NativeTypeName("#define DI_SHOWALL 0x00000007L")]
        public const int DI_SHOWALL = 0x00000007;

        [NativeTypeName("#define DI_NOVCP 0x00000008L")]
        public const int DI_NOVCP = 0x00000008;

        [NativeTypeName("#define DI_DIDCOMPAT 0x00000010L")]
        public const int DI_DIDCOMPAT = 0x00000010;

        [NativeTypeName("#define DI_DIDCLASS 0x00000020L")]
        public const int DI_DIDCLASS = 0x00000020;

        [NativeTypeName("#define DI_AUTOASSIGNRES 0x00000040L")]
        public const int DI_AUTOASSIGNRES = 0x00000040;

        [NativeTypeName("#define DI_NEEDRESTART 0x00000080L")]
        public const int DI_NEEDRESTART = 0x00000080;

        [NativeTypeName("#define DI_NEEDREBOOT 0x00000100L")]
        public const int DI_NEEDREBOOT = 0x00000100;

        [NativeTypeName("#define DI_NOBROWSE 0x00000200L")]
        public const int DI_NOBROWSE = 0x00000200;

        [NativeTypeName("#define DI_MULTMFGS 0x00000400L")]
        public const int DI_MULTMFGS = 0x00000400;

        [NativeTypeName("#define DI_DISABLED 0x00000800L")]
        public const int DI_DISABLED = 0x00000800;

        [NativeTypeName("#define DI_GENERALPAGE_ADDED 0x00001000L")]
        public const int DI_GENERALPAGE_ADDED = 0x00001000;

        [NativeTypeName("#define DI_RESOURCEPAGE_ADDED 0x00002000L")]
        public const int DI_RESOURCEPAGE_ADDED = 0x00002000;

        [NativeTypeName("#define DI_PROPERTIES_CHANGE 0x00004000L")]
        public const int DI_PROPERTIES_CHANGE = 0x00004000;

        [NativeTypeName("#define DI_INF_IS_SORTED 0x00008000L")]
        public const int DI_INF_IS_SORTED = 0x00008000;

        [NativeTypeName("#define DI_ENUMSINGLEINF 0x00010000L")]
        public const int DI_ENUMSINGLEINF = 0x00010000;

        [NativeTypeName("#define DI_DONOTCALLCONFIGMG 0x00020000L")]
        public const int DI_DONOTCALLCONFIGMG = 0x00020000;

        [NativeTypeName("#define DI_INSTALLDISABLED 0x00040000L")]
        public const int DI_INSTALLDISABLED = 0x00040000;

        [NativeTypeName("#define DI_COMPAT_FROM_CLASS 0x00080000L")]
        public const int DI_COMPAT_FROM_CLASS = 0x00080000;

        [NativeTypeName("#define DI_CLASSINSTALLPARAMS 0x00100000L")]
        public const int DI_CLASSINSTALLPARAMS = 0x00100000;

        [NativeTypeName("#define DI_NODI_DEFAULTACTION 0x00200000L")]
        public const int DI_NODI_DEFAULTACTION = 0x00200000;

        [NativeTypeName("#define DI_QUIETINSTALL 0x00800000L")]
        public const int DI_QUIETINSTALL = 0x00800000;

        [NativeTypeName("#define DI_NOFILECOPY 0x01000000L")]
        public const int DI_NOFILECOPY = 0x01000000;

        [NativeTypeName("#define DI_FORCECOPY 0x02000000L")]
        public const int DI_FORCECOPY = 0x02000000;

        [NativeTypeName("#define DI_DRIVERPAGE_ADDED 0x04000000L")]
        public const int DI_DRIVERPAGE_ADDED = 0x04000000;

        [NativeTypeName("#define DI_USECI_SELECTSTRINGS 0x08000000L")]
        public const int DI_USECI_SELECTSTRINGS = 0x08000000;

        [NativeTypeName("#define DI_OVERRIDE_INFFLAGS 0x10000000L")]
        public const int DI_OVERRIDE_INFFLAGS = 0x10000000;

        [NativeTypeName("#define DI_PROPS_NOCHANGEUSAGE 0x20000000L")]
        public const int DI_PROPS_NOCHANGEUSAGE = 0x20000000;

        [NativeTypeName("#define DI_NOSELECTICONS 0x40000000L")]
        public const int DI_NOSELECTICONS = 0x40000000;

        [NativeTypeName("#define DI_NOWRITE_IDS 0x80000000L")]
        public const uint DI_NOWRITE_IDS = 0x80000000;

        [NativeTypeName("#define DI_FLAGSEX_RESERVED2 0x00000001L")]
        public const int DI_FLAGSEX_RESERVED2 = 0x00000001;

        [NativeTypeName("#define DI_FLAGSEX_RESERVED3 0x00000002L")]
        public const int DI_FLAGSEX_RESERVED3 = 0x00000002;

        [NativeTypeName("#define DI_FLAGSEX_CI_FAILED 0x00000004L")]
        public const int DI_FLAGSEX_CI_FAILED = 0x00000004;

        [NativeTypeName("#define DI_FLAGSEX_FINISHINSTALL_ACTION 0x00000008L")]
        public const int DI_FLAGSEX_FINISHINSTALL_ACTION = 0x00000008;

        [NativeTypeName("#define DI_FLAGSEX_DIDINFOLIST 0x00000010L")]
        public const int DI_FLAGSEX_DIDINFOLIST = 0x00000010;

        [NativeTypeName("#define DI_FLAGSEX_DIDCOMPATINFO 0x00000020L")]
        public const int DI_FLAGSEX_DIDCOMPATINFO = 0x00000020;

        [NativeTypeName("#define DI_FLAGSEX_FILTERCLASSES 0x00000040L")]
        public const int DI_FLAGSEX_FILTERCLASSES = 0x00000040;

        [NativeTypeName("#define DI_FLAGSEX_SETFAILEDINSTALL 0x00000080L")]
        public const int DI_FLAGSEX_SETFAILEDINSTALL = 0x00000080;

        [NativeTypeName("#define DI_FLAGSEX_DEVICECHANGE 0x00000100L")]
        public const int DI_FLAGSEX_DEVICECHANGE = 0x00000100;

        [NativeTypeName("#define DI_FLAGSEX_ALWAYSWRITEIDS 0x00000200L")]
        public const int DI_FLAGSEX_ALWAYSWRITEIDS = 0x00000200;

        [NativeTypeName("#define DI_FLAGSEX_PROPCHANGE_PENDING 0x00000400L")]
        public const int DI_FLAGSEX_PROPCHANGE_PENDING = 0x00000400;

        [NativeTypeName("#define DI_FLAGSEX_ALLOWEXCLUDEDDRVS 0x00000800L")]
        public const int DI_FLAGSEX_ALLOWEXCLUDEDDRVS = 0x00000800;

        [NativeTypeName("#define DI_FLAGSEX_NOUIONQUERYREMOVE 0x00001000L")]
        public const int DI_FLAGSEX_NOUIONQUERYREMOVE = 0x00001000;

        [NativeTypeName("#define DI_FLAGSEX_USECLASSFORCOMPAT 0x00002000L")]
        public const int DI_FLAGSEX_USECLASSFORCOMPAT = 0x00002000;

        [NativeTypeName("#define DI_FLAGSEX_RESERVED4 0x00004000L")]
        public const int DI_FLAGSEX_RESERVED4 = 0x00004000;

        [NativeTypeName("#define DI_FLAGSEX_NO_DRVREG_MODIFY 0x00008000L")]
        public const int DI_FLAGSEX_NO_DRVREG_MODIFY = 0x00008000;

        [NativeTypeName("#define DI_FLAGSEX_IN_SYSTEM_SETUP 0x00010000L")]
        public const int DI_FLAGSEX_IN_SYSTEM_SETUP = 0x00010000;

        [NativeTypeName("#define DI_FLAGSEX_INET_DRIVER 0x00020000L")]
        public const int DI_FLAGSEX_INET_DRIVER = 0x00020000;

        [NativeTypeName("#define DI_FLAGSEX_APPENDDRIVERLIST 0x00040000L")]
        public const int DI_FLAGSEX_APPENDDRIVERLIST = 0x00040000;

        [NativeTypeName("#define DI_FLAGSEX_PREINSTALLBACKUP 0x00080000L")]
        public const int DI_FLAGSEX_PREINSTALLBACKUP = 0x00080000;

        [NativeTypeName("#define DI_FLAGSEX_BACKUPONREPLACE 0x00100000L")]
        public const int DI_FLAGSEX_BACKUPONREPLACE = 0x00100000;

        [NativeTypeName("#define DI_FLAGSEX_DRIVERLIST_FROM_URL 0x00200000L")]
        public const int DI_FLAGSEX_DRIVERLIST_FROM_URL = 0x00200000;

        [NativeTypeName("#define DI_FLAGSEX_RESERVED1 0x00400000L")]
        public const int DI_FLAGSEX_RESERVED1 = 0x00400000;

        [NativeTypeName("#define DI_FLAGSEX_EXCLUDE_OLD_INET_DRIVERS 0x00800000L")]
        public const int DI_FLAGSEX_EXCLUDE_OLD_INET_DRIVERS = 0x00800000;

        [NativeTypeName("#define DI_FLAGSEX_POWERPAGE_ADDED 0x01000000L")]
        public const int DI_FLAGSEX_POWERPAGE_ADDED = 0x01000000;

        [NativeTypeName("#define DI_FLAGSEX_FILTERSIMILARDRIVERS 0x02000000L")]
        public const int DI_FLAGSEX_FILTERSIMILARDRIVERS = 0x02000000;

        [NativeTypeName("#define DI_FLAGSEX_INSTALLEDDRIVER 0x04000000L")]
        public const int DI_FLAGSEX_INSTALLEDDRIVER = 0x04000000;

        [NativeTypeName("#define DI_FLAGSEX_NO_CLASSLIST_NODE_MERGE 0x08000000L")]
        public const int DI_FLAGSEX_NO_CLASSLIST_NODE_MERGE = 0x08000000;

        [NativeTypeName("#define DI_FLAGSEX_ALTPLATFORM_DRVSEARCH 0x10000000L")]
        public const int DI_FLAGSEX_ALTPLATFORM_DRVSEARCH = 0x10000000;

        [NativeTypeName("#define DI_FLAGSEX_RESTART_DEVICE_ONLY 0x20000000L")]
        public const int DI_FLAGSEX_RESTART_DEVICE_ONLY = 0x20000000;

        [NativeTypeName("#define DI_FLAGSEX_RECURSIVESEARCH 0x40000000L")]
        public const int DI_FLAGSEX_RECURSIVESEARCH = 0x40000000;

        [NativeTypeName("#define DI_FLAGSEX_SEARCH_PUBLISHED_INFS 0x80000000L")]
        public const uint DI_FLAGSEX_SEARCH_PUBLISHED_INFS = 0x80000000;

        [NativeTypeName("#define ENABLECLASS_QUERY 0")]
        public const int ENABLECLASS_QUERY = 0;

        [NativeTypeName("#define ENABLECLASS_SUCCESS 1")]
        public const int ENABLECLASS_SUCCESS = 1;

        [NativeTypeName("#define ENABLECLASS_FAILURE 2")]
        public const int ENABLECLASS_FAILURE = 2;

        [NativeTypeName("#define DICS_ENABLE 0x00000001")]
        public const int DICS_ENABLE = 0x00000001;

        [NativeTypeName("#define DICS_DISABLE 0x00000002")]
        public const int DICS_DISABLE = 0x00000002;

        [NativeTypeName("#define DICS_PROPCHANGE 0x00000003")]
        public const int DICS_PROPCHANGE = 0x00000003;

        [NativeTypeName("#define DICS_START 0x00000004")]
        public const int DICS_START = 0x00000004;

        [NativeTypeName("#define DICS_STOP 0x00000005")]
        public const int DICS_STOP = 0x00000005;

        [NativeTypeName("#define DICS_FLAG_GLOBAL 0x00000001")]
        public const int DICS_FLAG_GLOBAL = 0x00000001;

        [NativeTypeName("#define DICS_FLAG_CONFIGSPECIFIC 0x00000002")]
        public const int DICS_FLAG_CONFIGSPECIFIC = 0x00000002;

        [NativeTypeName("#define DICS_FLAG_CONFIGGENERAL 0x00000004")]
        public const int DICS_FLAG_CONFIGGENERAL = 0x00000004;

        [NativeTypeName("#define DI_REMOVEDEVICE_GLOBAL 0x00000001")]
        public const int DI_REMOVEDEVICE_GLOBAL = 0x00000001;

        [NativeTypeName("#define DI_REMOVEDEVICE_CONFIGSPECIFIC 0x00000002")]
        public const int DI_REMOVEDEVICE_CONFIGSPECIFIC = 0x00000002;

        [NativeTypeName("#define DI_UNREMOVEDEVICE_CONFIGSPECIFIC 0x00000002")]
        public const int DI_UNREMOVEDEVICE_CONFIGSPECIFIC = 0x00000002;

        [NativeTypeName("#define MAX_INSTALLWIZARD_DYNAPAGES 20")]
        public const int MAX_INSTALLWIZARD_DYNAPAGES = 20;

        [NativeTypeName("#define NDW_INSTALLFLAG_DIDFACTDEFS 0x00000001")]
        public const int NDW_INSTALLFLAG_DIDFACTDEFS = 0x00000001;

        [NativeTypeName("#define NDW_INSTALLFLAG_HARDWAREALLREADYIN 0x00000002")]
        public const int NDW_INSTALLFLAG_HARDWAREALLREADYIN = 0x00000002;

        [NativeTypeName("#define NDW_INSTALLFLAG_NEEDRESTART DI_NEEDRESTART")]
        public const int NDW_INSTALLFLAG_NEEDRESTART = 0x00000080;

        [NativeTypeName("#define NDW_INSTALLFLAG_NEEDREBOOT DI_NEEDREBOOT")]
        public const int NDW_INSTALLFLAG_NEEDREBOOT = 0x00000100;

        [NativeTypeName("#define NDW_INSTALLFLAG_NEEDSHUTDOWN 0x00000200")]
        public const int NDW_INSTALLFLAG_NEEDSHUTDOWN = 0x00000200;

        [NativeTypeName("#define NDW_INSTALLFLAG_EXPRESSINTRO 0x00000400")]
        public const int NDW_INSTALLFLAG_EXPRESSINTRO = 0x00000400;

        [NativeTypeName("#define NDW_INSTALLFLAG_SKIPISDEVINSTALLED 0x00000800")]
        public const int NDW_INSTALLFLAG_SKIPISDEVINSTALLED = 0x00000800;

        [NativeTypeName("#define NDW_INSTALLFLAG_NODETECTEDDEVS 0x00001000")]
        public const int NDW_INSTALLFLAG_NODETECTEDDEVS = 0x00001000;

        [NativeTypeName("#define NDW_INSTALLFLAG_INSTALLSPECIFIC 0x00002000")]
        public const int NDW_INSTALLFLAG_INSTALLSPECIFIC = 0x00002000;

        [NativeTypeName("#define NDW_INSTALLFLAG_SKIPCLASSLIST 0x00004000")]
        public const int NDW_INSTALLFLAG_SKIPCLASSLIST = 0x00004000;

        [NativeTypeName("#define NDW_INSTALLFLAG_CI_PICKED_OEM 0x00008000")]
        public const int NDW_INSTALLFLAG_CI_PICKED_OEM = 0x00008000;

        [NativeTypeName("#define NDW_INSTALLFLAG_PCMCIAMODE 0x00010000")]
        public const int NDW_INSTALLFLAG_PCMCIAMODE = 0x00010000;

        [NativeTypeName("#define NDW_INSTALLFLAG_PCMCIADEVICE 0x00020000")]
        public const int NDW_INSTALLFLAG_PCMCIADEVICE = 0x00020000;

        [NativeTypeName("#define NDW_INSTALLFLAG_USERCANCEL 0x00040000")]
        public const int NDW_INSTALLFLAG_USERCANCEL = 0x00040000;

        [NativeTypeName("#define NDW_INSTALLFLAG_KNOWNCLASS 0x00080000")]
        public const int NDW_INSTALLFLAG_KNOWNCLASS = 0x00080000;

        [NativeTypeName("#define DYNAWIZ_FLAG_PAGESADDED 0x00000001")]
        public const int DYNAWIZ_FLAG_PAGESADDED = 0x00000001;

        [NativeTypeName("#define DYNAWIZ_FLAG_ANALYZE_HANDLECONFLICT 0x00000008")]
        public const int DYNAWIZ_FLAG_ANALYZE_HANDLECONFLICT = 0x00000008;

        [NativeTypeName("#define DYNAWIZ_FLAG_INSTALLDET_NEXT 0x00000002")]
        public const int DYNAWIZ_FLAG_INSTALLDET_NEXT = 0x00000002;

        [NativeTypeName("#define DYNAWIZ_FLAG_INSTALLDET_PREV 0x00000004")]
        public const int DYNAWIZ_FLAG_INSTALLDET_PREV = 0x00000004;

        [NativeTypeName("#define MIN_IDD_DYNAWIZ_RESOURCE_ID 10000")]
        public const int MIN_IDD_DYNAWIZ_RESOURCE_ID = 10000;

        [NativeTypeName("#define MAX_IDD_DYNAWIZ_RESOURCE_ID 11000")]
        public const int MAX_IDD_DYNAWIZ_RESOURCE_ID = 11000;

        [NativeTypeName("#define IDD_DYNAWIZ_FIRSTPAGE 10000")]
        public const int IDD_DYNAWIZ_FIRSTPAGE = 10000;

        [NativeTypeName("#define IDD_DYNAWIZ_SELECT_PREVPAGE 10001")]
        public const int IDD_DYNAWIZ_SELECT_PREVPAGE = 10001;

        [NativeTypeName("#define IDD_DYNAWIZ_SELECT_NEXTPAGE 10002")]
        public const int IDD_DYNAWIZ_SELECT_NEXTPAGE = 10002;

        [NativeTypeName("#define IDD_DYNAWIZ_ANALYZE_PREVPAGE 10003")]
        public const int IDD_DYNAWIZ_ANALYZE_PREVPAGE = 10003;

        [NativeTypeName("#define IDD_DYNAWIZ_ANALYZE_NEXTPAGE 10004")]
        public const int IDD_DYNAWIZ_ANALYZE_NEXTPAGE = 10004;

        [NativeTypeName("#define IDD_DYNAWIZ_SELECTDEV_PAGE 10009")]
        public const int IDD_DYNAWIZ_SELECTDEV_PAGE = 10009;

        [NativeTypeName("#define IDD_DYNAWIZ_ANALYZEDEV_PAGE 10010")]
        public const int IDD_DYNAWIZ_ANALYZEDEV_PAGE = 10010;

        [NativeTypeName("#define IDD_DYNAWIZ_INSTALLDETECTEDDEVS_PAGE 10011")]
        public const int IDD_DYNAWIZ_INSTALLDETECTEDDEVS_PAGE = 10011;

        [NativeTypeName("#define IDD_DYNAWIZ_SELECTCLASS_PAGE 10012")]
        public const int IDD_DYNAWIZ_SELECTCLASS_PAGE = 10012;

        [NativeTypeName("#define IDD_DYNAWIZ_INSTALLDETECTED_PREVPAGE 10006")]
        public const int IDD_DYNAWIZ_INSTALLDETECTED_PREVPAGE = 10006;

        [NativeTypeName("#define IDD_DYNAWIZ_INSTALLDETECTED_NEXTPAGE 10007")]
        public const int IDD_DYNAWIZ_INSTALLDETECTED_NEXTPAGE = 10007;

        [NativeTypeName("#define IDD_DYNAWIZ_INSTALLDETECTED_NODEVS 10008")]
        public const int IDD_DYNAWIZ_INSTALLDETECTED_NODEVS = 10008;

        [NativeTypeName("#define DNF_DUPDESC 0x00000001")]
        public const int DNF_DUPDESC = 0x00000001;

        [NativeTypeName("#define DNF_OLDDRIVER 0x00000002")]
        public const int DNF_OLDDRIVER = 0x00000002;

        [NativeTypeName("#define DNF_EXCLUDEFROMLIST 0x00000004")]
        public const int DNF_EXCLUDEFROMLIST = 0x00000004;

        [NativeTypeName("#define DNF_NODRIVER 0x00000008")]
        public const int DNF_NODRIVER = 0x00000008;

        [NativeTypeName("#define DNF_LEGACYINF 0x00000010")]
        public const int DNF_LEGACYINF = 0x00000010;

        [NativeTypeName("#define DNF_CLASS_DRIVER 0x00000020")]
        public const int DNF_CLASS_DRIVER = 0x00000020;

        [NativeTypeName("#define DNF_COMPATIBLE_DRIVER 0x00000040")]
        public const int DNF_COMPATIBLE_DRIVER = 0x00000040;

        [NativeTypeName("#define DNF_INET_DRIVER 0x00000080")]
        public const int DNF_INET_DRIVER = 0x00000080;

        [NativeTypeName("#define DNF_UNUSED1 0x00000100")]
        public const int DNF_UNUSED1 = 0x00000100;

        [NativeTypeName("#define DNF_UNUSED2 0x00000200")]
        public const int DNF_UNUSED2 = 0x00000200;

        [NativeTypeName("#define DNF_OLD_INET_DRIVER 0x00000400")]
        public const int DNF_OLD_INET_DRIVER = 0x00000400;

        [NativeTypeName("#define DNF_BAD_DRIVER 0x00000800")]
        public const int DNF_BAD_DRIVER = 0x00000800;

        [NativeTypeName("#define DNF_DUPPROVIDER 0x00001000")]
        public const int DNF_DUPPROVIDER = 0x00001000;

        [NativeTypeName("#define DNF_INF_IS_SIGNED 0x00002000")]
        public const int DNF_INF_IS_SIGNED = 0x00002000;

        [NativeTypeName("#define DNF_OEM_F6_INF 0x00004000")]
        public const int DNF_OEM_F6_INF = 0x00004000;

        [NativeTypeName("#define DNF_DUPDRIVERVER 0x00008000")]
        public const int DNF_DUPDRIVERVER = 0x00008000;

        [NativeTypeName("#define DNF_BASIC_DRIVER 0x00010000")]
        public const int DNF_BASIC_DRIVER = 0x00010000;

        [NativeTypeName("#define DNF_AUTHENTICODE_SIGNED 0x00020000")]
        public const int DNF_AUTHENTICODE_SIGNED = 0x00020000;

        [NativeTypeName("#define DNF_INSTALLEDDRIVER 0x00040000")]
        public const int DNF_INSTALLEDDRIVER = 0x00040000;

        [NativeTypeName("#define DNF_ALWAYSEXCLUDEFROMLIST 0x00080000")]
        public const int DNF_ALWAYSEXCLUDEFROMLIST = 0x00080000;

        [NativeTypeName("#define DNF_INBOX_DRIVER 0x00100000")]
        public const int DNF_INBOX_DRIVER = 0x00100000;

        [NativeTypeName("#define DNF_REQUESTADDITIONALSOFTWARE 0x00200000")]
        public const int DNF_REQUESTADDITIONALSOFTWARE = 0x00200000;

        [NativeTypeName("#define DNF_UNUSED_22 0x00400000")]
        public const int DNF_UNUSED_22 = 0x00400000;

        [NativeTypeName("#define DNF_UNUSED_23 0x00800000")]
        public const int DNF_UNUSED_23 = 0x00800000;

        [NativeTypeName("#define DNF_UNUSED_24 0x01000000")]
        public const int DNF_UNUSED_24 = 0x01000000;

        [NativeTypeName("#define DNF_UNUSED_25 0x02000000")]
        public const int DNF_UNUSED_25 = 0x02000000;

        [NativeTypeName("#define DNF_UNUSED_26 0x04000000")]
        public const int DNF_UNUSED_26 = 0x04000000;

        [NativeTypeName("#define DNF_UNUSED_27 0x08000000")]
        public const int DNF_UNUSED_27 = 0x08000000;

        [NativeTypeName("#define DNF_UNUSED_28 0x10000000")]
        public const int DNF_UNUSED_28 = 0x10000000;

        [NativeTypeName("#define DNF_UNUSED_29 0x20000000")]
        public const int DNF_UNUSED_29 = 0x20000000;

        [NativeTypeName("#define DNF_UNUSED_30 0x40000000")]
        public const int DNF_UNUSED_30 = 0x40000000;

        [NativeTypeName("#define DNF_UNUSED_31 0x80000000")]
        public const uint DNF_UNUSED_31 = 0x80000000;

        [NativeTypeName("#define DRIVER_HARDWAREID_RANK 0x00000FFF")]
        public const int DRIVER_HARDWAREID_RANK = 0x00000FFF;

        [NativeTypeName("#define DRIVER_HARDWAREID_MASK 0x80000FFF")]
        public const uint DRIVER_HARDWAREID_MASK = 0x80000FFF;

        [NativeTypeName("#define DRIVER_UNTRUSTED_RANK 0x80000000")]
        public const uint DRIVER_UNTRUSTED_RANK = 0x80000000;

        [NativeTypeName("#define DRIVER_W9X_SUSPECT_RANK 0xC0000000")]
        public const uint DRIVER_W9X_SUSPECT_RANK = 0xC0000000;

        [NativeTypeName("#define SPPSR_SELECT_DEVICE_RESOURCES 1")]
        public const int SPPSR_SELECT_DEVICE_RESOURCES = 1;

        [NativeTypeName("#define SPPSR_ENUM_BASIC_DEVICE_PROPERTIES 2")]
        public const int SPPSR_ENUM_BASIC_DEVICE_PROPERTIES = 2;

        [NativeTypeName("#define SPPSR_ENUM_ADV_DEVICE_PROPERTIES 3")]
        public const int SPPSR_ENUM_ADV_DEVICE_PROPERTIES = 3;

        [NativeTypeName("#define ERROR_EXPECTED_SECTION_NAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0)")]
        public const uint ERROR_EXPECTED_SECTION_NAME = (0x20000000 | 0xC0000000 | 0);

        [NativeTypeName("#define ERROR_BAD_SECTION_NAME_LINE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|1)")]
        public const uint ERROR_BAD_SECTION_NAME_LINE = (0x20000000 | 0xC0000000 | 1);

        [NativeTypeName("#define ERROR_SECTION_NAME_TOO_LONG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|2)")]
        public const uint ERROR_SECTION_NAME_TOO_LONG = (0x20000000 | 0xC0000000 | 2);

        [NativeTypeName("#define ERROR_GENERAL_SYNTAX (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|3)")]
        public const uint ERROR_GENERAL_SYNTAX = (0x20000000 | 0xC0000000 | 3);

        [NativeTypeName("#define ERROR_WRONG_INF_STYLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x100)")]
        public const uint ERROR_WRONG_INF_STYLE = (0x20000000 | 0xC0000000 | 0x100);

        [NativeTypeName("#define ERROR_SECTION_NOT_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x101)")]
        public const uint ERROR_SECTION_NOT_FOUND = (0x20000000 | 0xC0000000 | 0x101);

        [NativeTypeName("#define ERROR_LINE_NOT_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x102)")]
        public const uint ERROR_LINE_NOT_FOUND = (0x20000000 | 0xC0000000 | 0x102);

        [NativeTypeName("#define ERROR_NO_BACKUP (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x103)")]
        public const uint ERROR_NO_BACKUP = (0x20000000 | 0xC0000000 | 0x103);

        [NativeTypeName("#define ERROR_NO_ASSOCIATED_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x200)")]
        public const uint ERROR_NO_ASSOCIATED_CLASS = (0x20000000 | 0xC0000000 | 0x200);

        [NativeTypeName("#define ERROR_CLASS_MISMATCH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x201)")]
        public const uint ERROR_CLASS_MISMATCH = (0x20000000 | 0xC0000000 | 0x201);

        [NativeTypeName("#define ERROR_DUPLICATE_FOUND (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x202)")]
        public const uint ERROR_DUPLICATE_FOUND = (0x20000000 | 0xC0000000 | 0x202);

        [NativeTypeName("#define ERROR_NO_DRIVER_SELECTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x203)")]
        public const uint ERROR_NO_DRIVER_SELECTED = (0x20000000 | 0xC0000000 | 0x203);

        [NativeTypeName("#define ERROR_KEY_DOES_NOT_EXIST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x204)")]
        public const uint ERROR_KEY_DOES_NOT_EXIST = (0x20000000 | 0xC0000000 | 0x204);

        [NativeTypeName("#define ERROR_INVALID_DEVINST_NAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x205)")]
        public const uint ERROR_INVALID_DEVINST_NAME = (0x20000000 | 0xC0000000 | 0x205);

        [NativeTypeName("#define ERROR_INVALID_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x206)")]
        public const uint ERROR_INVALID_CLASS = (0x20000000 | 0xC0000000 | 0x206);

        [NativeTypeName("#define ERROR_DEVINST_ALREADY_EXISTS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x207)")]
        public const uint ERROR_DEVINST_ALREADY_EXISTS = (0x20000000 | 0xC0000000 | 0x207);

        [NativeTypeName("#define ERROR_DEVINFO_NOT_REGISTERED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x208)")]
        public const uint ERROR_DEVINFO_NOT_REGISTERED = (0x20000000 | 0xC0000000 | 0x208);

        [NativeTypeName("#define ERROR_INVALID_REG_PROPERTY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x209)")]
        public const uint ERROR_INVALID_REG_PROPERTY = (0x20000000 | 0xC0000000 | 0x209);

        [NativeTypeName("#define ERROR_NO_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20A)")]
        public const uint ERROR_NO_INF = (0x20000000 | 0xC0000000 | 0x20A);

        [NativeTypeName("#define ERROR_NO_SUCH_DEVINST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20B)")]
        public const uint ERROR_NO_SUCH_DEVINST = (0x20000000 | 0xC0000000 | 0x20B);

        [NativeTypeName("#define ERROR_CANT_LOAD_CLASS_ICON (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20C)")]
        public const uint ERROR_CANT_LOAD_CLASS_ICON = (0x20000000 | 0xC0000000 | 0x20C);

        [NativeTypeName("#define ERROR_INVALID_CLASS_INSTALLER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20D)")]
        public const uint ERROR_INVALID_CLASS_INSTALLER = (0x20000000 | 0xC0000000 | 0x20D);

        [NativeTypeName("#define ERROR_DI_DO_DEFAULT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20E)")]
        public const uint ERROR_DI_DO_DEFAULT = (0x20000000 | 0xC0000000 | 0x20E);

        [NativeTypeName("#define ERROR_DI_NOFILECOPY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x20F)")]
        public const uint ERROR_DI_NOFILECOPY = (0x20000000 | 0xC0000000 | 0x20F);

        [NativeTypeName("#define ERROR_INVALID_HWPROFILE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x210)")]
        public const uint ERROR_INVALID_HWPROFILE = (0x20000000 | 0xC0000000 | 0x210);

        [NativeTypeName("#define ERROR_NO_DEVICE_SELECTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x211)")]
        public const uint ERROR_NO_DEVICE_SELECTED = (0x20000000 | 0xC0000000 | 0x211);

        [NativeTypeName("#define ERROR_DEVINFO_LIST_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x212)")]
        public const uint ERROR_DEVINFO_LIST_LOCKED = (0x20000000 | 0xC0000000 | 0x212);

        [NativeTypeName("#define ERROR_DEVINFO_DATA_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x213)")]
        public const uint ERROR_DEVINFO_DATA_LOCKED = (0x20000000 | 0xC0000000 | 0x213);

        [NativeTypeName("#define ERROR_DI_BAD_PATH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x214)")]
        public const uint ERROR_DI_BAD_PATH = (0x20000000 | 0xC0000000 | 0x214);

        [NativeTypeName("#define ERROR_NO_CLASSINSTALL_PARAMS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x215)")]
        public const uint ERROR_NO_CLASSINSTALL_PARAMS = (0x20000000 | 0xC0000000 | 0x215);

        [NativeTypeName("#define ERROR_FILEQUEUE_LOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x216)")]
        public const uint ERROR_FILEQUEUE_LOCKED = (0x20000000 | 0xC0000000 | 0x216);

        [NativeTypeName("#define ERROR_BAD_SERVICE_INSTALLSECT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x217)")]
        public const uint ERROR_BAD_SERVICE_INSTALLSECT = (0x20000000 | 0xC0000000 | 0x217);

        [NativeTypeName("#define ERROR_NO_CLASS_DRIVER_LIST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x218)")]
        public const uint ERROR_NO_CLASS_DRIVER_LIST = (0x20000000 | 0xC0000000 | 0x218);

        [NativeTypeName("#define ERROR_NO_ASSOCIATED_SERVICE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x219)")]
        public const uint ERROR_NO_ASSOCIATED_SERVICE = (0x20000000 | 0xC0000000 | 0x219);

        [NativeTypeName("#define ERROR_NO_DEFAULT_DEVICE_INTERFACE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21A)")]
        public const uint ERROR_NO_DEFAULT_DEVICE_INTERFACE = (0x20000000 | 0xC0000000 | 0x21A);

        [NativeTypeName("#define ERROR_DEVICE_INTERFACE_ACTIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21B)")]
        public const uint ERROR_DEVICE_INTERFACE_ACTIVE = (0x20000000 | 0xC0000000 | 0x21B);

        [NativeTypeName("#define ERROR_DEVICE_INTERFACE_REMOVED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21C)")]
        public const uint ERROR_DEVICE_INTERFACE_REMOVED = (0x20000000 | 0xC0000000 | 0x21C);

        [NativeTypeName("#define ERROR_BAD_INTERFACE_INSTALLSECT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21D)")]
        public const uint ERROR_BAD_INTERFACE_INSTALLSECT = (0x20000000 | 0xC0000000 | 0x21D);

        [NativeTypeName("#define ERROR_NO_SUCH_INTERFACE_CLASS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21E)")]
        public const uint ERROR_NO_SUCH_INTERFACE_CLASS = (0x20000000 | 0xC0000000 | 0x21E);

        [NativeTypeName("#define ERROR_INVALID_REFERENCE_STRING (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x21F)")]
        public const uint ERROR_INVALID_REFERENCE_STRING = (0x20000000 | 0xC0000000 | 0x21F);

        [NativeTypeName("#define ERROR_INVALID_MACHINENAME (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x220)")]
        public const uint ERROR_INVALID_MACHINENAME = (0x20000000 | 0xC0000000 | 0x220);

        [NativeTypeName("#define ERROR_REMOTE_COMM_FAILURE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x221)")]
        public const uint ERROR_REMOTE_COMM_FAILURE = (0x20000000 | 0xC0000000 | 0x221);

        [NativeTypeName("#define ERROR_MACHINE_UNAVAILABLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x222)")]
        public const uint ERROR_MACHINE_UNAVAILABLE = (0x20000000 | 0xC0000000 | 0x222);

        [NativeTypeName("#define ERROR_NO_CONFIGMGR_SERVICES (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x223)")]
        public const uint ERROR_NO_CONFIGMGR_SERVICES = (0x20000000 | 0xC0000000 | 0x223);

        [NativeTypeName("#define ERROR_INVALID_PROPPAGE_PROVIDER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x224)")]
        public const uint ERROR_INVALID_PROPPAGE_PROVIDER = (0x20000000 | 0xC0000000 | 0x224);

        [NativeTypeName("#define ERROR_NO_SUCH_DEVICE_INTERFACE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x225)")]
        public const uint ERROR_NO_SUCH_DEVICE_INTERFACE = (0x20000000 | 0xC0000000 | 0x225);

        [NativeTypeName("#define ERROR_DI_POSTPROCESSING_REQUIRED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x226)")]
        public const uint ERROR_DI_POSTPROCESSING_REQUIRED = (0x20000000 | 0xC0000000 | 0x226);

        [NativeTypeName("#define ERROR_INVALID_COINSTALLER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x227)")]
        public const uint ERROR_INVALID_COINSTALLER = (0x20000000 | 0xC0000000 | 0x227);

        [NativeTypeName("#define ERROR_NO_COMPAT_DRIVERS (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x228)")]
        public const uint ERROR_NO_COMPAT_DRIVERS = (0x20000000 | 0xC0000000 | 0x228);

        [NativeTypeName("#define ERROR_NO_DEVICE_ICON (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x229)")]
        public const uint ERROR_NO_DEVICE_ICON = (0x20000000 | 0xC0000000 | 0x229);

        [NativeTypeName("#define ERROR_INVALID_INF_LOGCONFIG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22A)")]
        public const uint ERROR_INVALID_INF_LOGCONFIG = (0x20000000 | 0xC0000000 | 0x22A);

        [NativeTypeName("#define ERROR_DI_DONT_INSTALL (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22B)")]
        public const uint ERROR_DI_DONT_INSTALL = (0x20000000 | 0xC0000000 | 0x22B);

        [NativeTypeName("#define ERROR_INVALID_FILTER_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22C)")]
        public const uint ERROR_INVALID_FILTER_DRIVER = (0x20000000 | 0xC0000000 | 0x22C);

        [NativeTypeName("#define ERROR_NON_WINDOWS_NT_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22D)")]
        public const uint ERROR_NON_WINDOWS_NT_DRIVER = (0x20000000 | 0xC0000000 | 0x22D);

        [NativeTypeName("#define ERROR_NON_WINDOWS_DRIVER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22E)")]
        public const uint ERROR_NON_WINDOWS_DRIVER = (0x20000000 | 0xC0000000 | 0x22E);

        [NativeTypeName("#define ERROR_NO_CATALOG_FOR_OEM_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x22F)")]
        public const uint ERROR_NO_CATALOG_FOR_OEM_INF = (0x20000000 | 0xC0000000 | 0x22F);

        [NativeTypeName("#define ERROR_DEVINSTALL_QUEUE_NONNATIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x230)")]
        public const uint ERROR_DEVINSTALL_QUEUE_NONNATIVE = (0x20000000 | 0xC0000000 | 0x230);

        [NativeTypeName("#define ERROR_NOT_DISABLEABLE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x231)")]
        public const uint ERROR_NOT_DISABLEABLE = (0x20000000 | 0xC0000000 | 0x231);

        [NativeTypeName("#define ERROR_CANT_REMOVE_DEVINST (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x232)")]
        public const uint ERROR_CANT_REMOVE_DEVINST = (0x20000000 | 0xC0000000 | 0x232);

        [NativeTypeName("#define ERROR_INVALID_TARGET (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x233)")]
        public const uint ERROR_INVALID_TARGET = (0x20000000 | 0xC0000000 | 0x233);

        [NativeTypeName("#define ERROR_DRIVER_NONNATIVE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x234)")]
        public const uint ERROR_DRIVER_NONNATIVE = (0x20000000 | 0xC0000000 | 0x234);

        [NativeTypeName("#define ERROR_IN_WOW64 (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x235)")]
        public const uint ERROR_IN_WOW64 = (0x20000000 | 0xC0000000 | 0x235);

        [NativeTypeName("#define ERROR_SET_SYSTEM_RESTORE_POINT (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x236)")]
        public const uint ERROR_SET_SYSTEM_RESTORE_POINT = (0x20000000 | 0xC0000000 | 0x236);

        [NativeTypeName("#define ERROR_SCE_DISABLED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x238)")]
        public const uint ERROR_SCE_DISABLED = (0x20000000 | 0xC0000000 | 0x238);

        [NativeTypeName("#define ERROR_UNKNOWN_EXCEPTION (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x239)")]
        public const uint ERROR_UNKNOWN_EXCEPTION = (0x20000000 | 0xC0000000 | 0x239);

        [NativeTypeName("#define ERROR_PNP_REGISTRY_ERROR (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23A)")]
        public const uint ERROR_PNP_REGISTRY_ERROR = (0x20000000 | 0xC0000000 | 0x23A);

        [NativeTypeName("#define ERROR_REMOTE_REQUEST_UNSUPPORTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23B)")]
        public const uint ERROR_REMOTE_REQUEST_UNSUPPORTED = (0x20000000 | 0xC0000000 | 0x23B);

        [NativeTypeName("#define ERROR_NOT_AN_INSTALLED_OEM_INF (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23C)")]
        public const uint ERROR_NOT_AN_INSTALLED_OEM_INF = (0x20000000 | 0xC0000000 | 0x23C);

        [NativeTypeName("#define ERROR_INF_IN_USE_BY_DEVICES (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23D)")]
        public const uint ERROR_INF_IN_USE_BY_DEVICES = (0x20000000 | 0xC0000000 | 0x23D);

        [NativeTypeName("#define ERROR_DI_FUNCTION_OBSOLETE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23E)")]
        public const uint ERROR_DI_FUNCTION_OBSOLETE = (0x20000000 | 0xC0000000 | 0x23E);

        [NativeTypeName("#define ERROR_NO_AUTHENTICODE_CATALOG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x23F)")]
        public const uint ERROR_NO_AUTHENTICODE_CATALOG = (0x20000000 | 0xC0000000 | 0x23F);

        [NativeTypeName("#define ERROR_AUTHENTICODE_DISALLOWED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x240)")]
        public const uint ERROR_AUTHENTICODE_DISALLOWED = (0x20000000 | 0xC0000000 | 0x240);

        [NativeTypeName("#define ERROR_AUTHENTICODE_TRUSTED_PUBLISHER (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x241)")]
        public const uint ERROR_AUTHENTICODE_TRUSTED_PUBLISHER = (0x20000000 | 0xC0000000 | 0x241);

        [NativeTypeName("#define ERROR_AUTHENTICODE_TRUST_NOT_ESTABLISHED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x242)")]
        public const uint ERROR_AUTHENTICODE_TRUST_NOT_ESTABLISHED = (0x20000000 | 0xC0000000 | 0x242);

        [NativeTypeName("#define ERROR_AUTHENTICODE_PUBLISHER_NOT_TRUSTED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x243)")]
        public const uint ERROR_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = (0x20000000 | 0xC0000000 | 0x243);

        [NativeTypeName("#define ERROR_SIGNATURE_OSATTRIBUTE_MISMATCH (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x244)")]
        public const uint ERROR_SIGNATURE_OSATTRIBUTE_MISMATCH = (0x20000000 | 0xC0000000 | 0x244);

        [NativeTypeName("#define ERROR_ONLY_VALIDATE_VIA_AUTHENTICODE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x245)")]
        public const uint ERROR_ONLY_VALIDATE_VIA_AUTHENTICODE = (0x20000000 | 0xC0000000 | 0x245);

        [NativeTypeName("#define ERROR_DEVICE_INSTALLER_NOT_READY (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x246)")]
        public const uint ERROR_DEVICE_INSTALLER_NOT_READY = (0x20000000 | 0xC0000000 | 0x246);

        [NativeTypeName("#define ERROR_DRIVER_STORE_ADD_FAILED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x247)")]
        public const uint ERROR_DRIVER_STORE_ADD_FAILED = (0x20000000 | 0xC0000000 | 0x247);

        [NativeTypeName("#define ERROR_DEVICE_INSTALL_BLOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x248)")]
        public const uint ERROR_DEVICE_INSTALL_BLOCKED = (0x20000000 | 0xC0000000 | 0x248);

        [NativeTypeName("#define ERROR_DRIVER_INSTALL_BLOCKED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x249)")]
        public const uint ERROR_DRIVER_INSTALL_BLOCKED = (0x20000000 | 0xC0000000 | 0x249);

        [NativeTypeName("#define ERROR_WRONG_INF_TYPE (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24A)")]
        public const uint ERROR_WRONG_INF_TYPE = (0x20000000 | 0xC0000000 | 0x24A);

        [NativeTypeName("#define ERROR_FILE_HASH_NOT_IN_CATALOG (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24B)")]
        public const uint ERROR_FILE_HASH_NOT_IN_CATALOG = (0x20000000 | 0xC0000000 | 0x24B);

        [NativeTypeName("#define ERROR_DRIVER_STORE_DELETE_FAILED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x24C)")]
        public const uint ERROR_DRIVER_STORE_DELETE_FAILED = (0x20000000 | 0xC0000000 | 0x24C);

        [NativeTypeName("#define ERROR_UNRECOVERABLE_STACK_OVERFLOW (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x300)")]
        public const uint ERROR_UNRECOVERABLE_STACK_OVERFLOW = (0x20000000 | 0xC0000000 | 0x300);

        [NativeTypeName("#define EXCEPTION_SPAPI_UNRECOVERABLE_STACK_OVERFLOW ERROR_UNRECOVERABLE_STACK_OVERFLOW")]
        public const uint EXCEPTION_SPAPI_UNRECOVERABLE_STACK_OVERFLOW = (0x20000000 | 0xC0000000 | 0x300);

        [NativeTypeName("#define ERROR_NO_DEFAULT_INTERFACE_DEVICE ERROR_NO_DEFAULT_DEVICE_INTERFACE")]
        public const uint ERROR_NO_DEFAULT_INTERFACE_DEVICE = (0x20000000 | 0xC0000000 | 0x21A);

        [NativeTypeName("#define ERROR_INTERFACE_DEVICE_ACTIVE ERROR_DEVICE_INTERFACE_ACTIVE")]
        public const uint ERROR_INTERFACE_DEVICE_ACTIVE = (0x20000000 | 0xC0000000 | 0x21B);

        [NativeTypeName("#define ERROR_INTERFACE_DEVICE_REMOVED ERROR_DEVICE_INTERFACE_REMOVED")]
        public const uint ERROR_INTERFACE_DEVICE_REMOVED = (0x20000000 | 0xC0000000 | 0x21C);

        [NativeTypeName("#define ERROR_NO_SUCH_INTERFACE_DEVICE ERROR_NO_SUCH_DEVICE_INTERFACE")]
        public const uint ERROR_NO_SUCH_INTERFACE_DEVICE = (0x20000000 | 0xC0000000 | 0x225);

        [NativeTypeName("#define ERROR_NOT_INSTALLED (APPLICATION_ERROR_MASK|ERROR_SEVERITY_ERROR|0x1000)")]
        public const uint ERROR_NOT_INSTALLED = (0x20000000 | 0xC0000000 | 0x1000);

        [NativeTypeName("#define INFINFO_INF_SPEC_IS_HINF 1")]
        public const int INFINFO_INF_SPEC_IS_HINF = 1;

        [NativeTypeName("#define INFINFO_INF_NAME_IS_ABSOLUTE 2")]
        public const int INFINFO_INF_NAME_IS_ABSOLUTE = 2;

        [NativeTypeName("#define INFINFO_DEFAULT_SEARCH 3")]
        public const int INFINFO_DEFAULT_SEARCH = 3;

        [NativeTypeName("#define INFINFO_REVERSE_DEFAULT_SEARCH 4")]
        public const int INFINFO_REVERSE_DEFAULT_SEARCH = 4;

        [NativeTypeName("#define INFINFO_INF_PATH_LIST_SEARCH 5")]
        public const int INFINFO_INF_PATH_LIST_SEARCH = 5;

        [NativeTypeName("#define SetupGetInfInformation SetupGetInfInformationW")]
        public static readonly delegate*<void*, uint, SP_INF_INFORMATION*, uint, uint*, int> SetupGetInfInformation = &SetupGetInfInformationW;

        [NativeTypeName("#define SetupQueryInfFileInformation SetupQueryInfFileInformationW")]
        public static readonly delegate*<SP_INF_INFORMATION*, uint, ushort*, uint, uint*, int> SetupQueryInfFileInformation = &SetupQueryInfFileInformationW;

        [NativeTypeName("#define SetupQueryInfOriginalFileInformation SetupQueryInfOriginalFileInformationW")]
        public static readonly delegate*<SP_INF_INFORMATION*, uint, SP_ALTPLATFORM_INFO_V2*, SP_ORIGINAL_FILE_INFO_W*, int> SetupQueryInfOriginalFileInformation = &SetupQueryInfOriginalFileInformationW;

        [NativeTypeName("#define SetupQueryInfVersionInformation SetupQueryInfVersionInformationW")]
        public static readonly delegate*<SP_INF_INFORMATION*, uint, ushort*, ushort*, uint, uint*, int> SetupQueryInfVersionInformation = &SetupQueryInfVersionInformationW;

        [NativeTypeName("#define SetupGetInfDriverStoreLocation SetupGetInfDriverStoreLocationW")]
        public static readonly delegate*<ushort*, SP_ALTPLATFORM_INFO_V2*, ushort*, ushort*, uint, uint*, int> SetupGetInfDriverStoreLocation = &SetupGetInfDriverStoreLocationW;

        [NativeTypeName("#define SetupGetInfPublishedName SetupGetInfPublishedNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint*, int> SetupGetInfPublishedName = &SetupGetInfPublishedNameW;

        [NativeTypeName("#define SetupGetInfFileList SetupGetInfFileListW")]
        public static readonly delegate*<ushort*, uint, ushort*, uint, uint*, int> SetupGetInfFileList = &SetupGetInfFileListW;

        [NativeTypeName("#define SetupOpenInfFile SetupOpenInfFileW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint*, void*> SetupOpenInfFile = &SetupOpenInfFileW;

        [NativeTypeName("#define SetupOpenAppendInfFile SetupOpenAppendInfFileW")]
        public static readonly delegate*<ushort*, void*, uint*, int> SetupOpenAppendInfFile = &SetupOpenAppendInfFileW;

        [NativeTypeName("#define SetupFindFirstLine SetupFindFirstLineW")]
        public static readonly delegate*<void*, ushort*, ushort*, INFCONTEXT*, int> SetupFindFirstLine = &SetupFindFirstLineW;

        [NativeTypeName("#define SetupFindNextMatchLine SetupFindNextMatchLineW")]
        public static readonly delegate*<INFCONTEXT*, ushort*, INFCONTEXT*, int> SetupFindNextMatchLine = &SetupFindNextMatchLineW;

        [NativeTypeName("#define SetupGetLineByIndex SetupGetLineByIndexW")]
        public static readonly delegate*<void*, ushort*, uint, INFCONTEXT*, int> SetupGetLineByIndex = &SetupGetLineByIndexW;

        [NativeTypeName("#define SetupGetLineCount SetupGetLineCountW")]
        public static readonly delegate*<void*, ushort*, int> SetupGetLineCount = &SetupGetLineCountW;

        [NativeTypeName("#define SetupGetLineText SetupGetLineTextW")]
        public static readonly delegate*<INFCONTEXT*, void*, ushort*, ushort*, ushort*, uint, uint*, int> SetupGetLineText = &SetupGetLineTextW;

        [NativeTypeName("#define SetupGetStringField SetupGetStringFieldW")]
        public static readonly delegate*<INFCONTEXT*, uint, ushort*, uint, uint*, int> SetupGetStringField = &SetupGetStringFieldW;

        [NativeTypeName("#define SetupGetMultiSzField SetupGetMultiSzFieldW")]
        public static readonly delegate*<INFCONTEXT*, uint, ushort*, uint, uint*, int> SetupGetMultiSzField = &SetupGetMultiSzFieldW;

        [NativeTypeName("#define SetupGetFileCompressionInfo SetupGetFileCompressionInfoW")]
        public static readonly delegate*<ushort*, ushort**, uint*, uint*, uint*, uint> SetupGetFileCompressionInfo = &SetupGetFileCompressionInfoW;

        [NativeTypeName("#define SetupGetFileCompressionInfoEx SetupGetFileCompressionInfoExW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint*, uint*, uint*, uint*, int> SetupGetFileCompressionInfoEx = &SetupGetFileCompressionInfoExW;

        [NativeTypeName("#define FILE_COMPRESSION_NONE 0")]
        public const int FILE_COMPRESSION_NONE = 0;

        [NativeTypeName("#define FILE_COMPRESSION_WINLZA 1")]
        public const int FILE_COMPRESSION_WINLZA = 1;

        [NativeTypeName("#define FILE_COMPRESSION_MSZIP 2")]
        public const int FILE_COMPRESSION_MSZIP = 2;

        [NativeTypeName("#define FILE_COMPRESSION_NTCAB 3")]
        public const int FILE_COMPRESSION_NTCAB = 3;

        [NativeTypeName("#define SetupDecompressOrCopyFile SetupDecompressOrCopyFileW")]
        public static readonly delegate*<ushort*, ushort*, uint*, uint> SetupDecompressOrCopyFile = &SetupDecompressOrCopyFileW;

        [NativeTypeName("#define SetupGetSourceFileLocation SetupGetSourceFileLocationW")]
        public static readonly delegate*<void*, INFCONTEXT*, ushort*, uint*, ushort*, uint, uint*, int> SetupGetSourceFileLocation = &SetupGetSourceFileLocationW;

        [NativeTypeName("#define SetupGetSourceFileSize SetupGetSourceFileSizeW")]
        public static readonly delegate*<void*, INFCONTEXT*, ushort*, ushort*, uint*, uint, int> SetupGetSourceFileSize = &SetupGetSourceFileSizeW;

        [NativeTypeName("#define SetupGetTargetPath SetupGetTargetPathW")]
        public static readonly delegate*<void*, INFCONTEXT*, ushort*, ushort*, uint, uint*, int> SetupGetTargetPath = &SetupGetTargetPathW;

        [NativeTypeName("#define SRCLIST_TEMPORARY 0x00000001")]
        public const int SRCLIST_TEMPORARY = 0x00000001;

        [NativeTypeName("#define SRCLIST_NOBROWSE 0x00000002")]
        public const int SRCLIST_NOBROWSE = 0x00000002;

        [NativeTypeName("#define SRCLIST_SYSTEM 0x00000010")]
        public const int SRCLIST_SYSTEM = 0x00000010;

        [NativeTypeName("#define SRCLIST_USER 0x00000020")]
        public const int SRCLIST_USER = 0x00000020;

        [NativeTypeName("#define SRCLIST_SYSIFADMIN 0x00000040")]
        public const int SRCLIST_SYSIFADMIN = 0x00000040;

        [NativeTypeName("#define SRCLIST_SUBDIRS 0x00000100")]
        public const int SRCLIST_SUBDIRS = 0x00000100;

        [NativeTypeName("#define SRCLIST_APPEND 0x00000200")]
        public const int SRCLIST_APPEND = 0x00000200;

        [NativeTypeName("#define SRCLIST_NOSTRIPPLATFORM 0x00000400")]
        public const int SRCLIST_NOSTRIPPLATFORM = 0x00000400;

        [NativeTypeName("#define SetupSetSourceList SetupSetSourceListW")]
        public static readonly delegate*<uint, ushort**, uint, int> SetupSetSourceList = &SetupSetSourceListW;

        [NativeTypeName("#define SetupAddToSourceList SetupAddToSourceListW")]
        public static readonly delegate*<uint, ushort*, int> SetupAddToSourceList = &SetupAddToSourceListW;

        [NativeTypeName("#define SetupRemoveFromSourceList SetupRemoveFromSourceListW")]
        public static readonly delegate*<uint, ushort*, int> SetupRemoveFromSourceList = &SetupRemoveFromSourceListW;

        [NativeTypeName("#define SetupQuerySourceList SetupQuerySourceListW")]
        public static readonly delegate*<uint, ushort***, uint*, int> SetupQuerySourceList = &SetupQuerySourceListW;

        [NativeTypeName("#define SetupFreeSourceList SetupFreeSourceListW")]
        public static readonly delegate*<ushort***, uint, int> SetupFreeSourceList = &SetupFreeSourceListW;

        [NativeTypeName("#define SetupPromptForDisk SetupPromptForDiskW")]
        public static readonly delegate*<IntPtr, ushort*, ushort*, ushort*, ushort*, ushort*, uint, ushort*, uint, uint*, uint> SetupPromptForDisk = &SetupPromptForDiskW;

        [NativeTypeName("#define SetupCopyError SetupCopyErrorW")]
        public static readonly delegate*<IntPtr, ushort*, ushort*, ushort*, ushort*, ushort*, uint, uint, ushort*, uint, uint*, uint> SetupCopyError = &SetupCopyErrorW;

        [NativeTypeName("#define SetupRenameError SetupRenameErrorW")]
        public static readonly delegate*<IntPtr, ushort*, ushort*, ushort*, uint, uint, uint> SetupRenameError = &SetupRenameErrorW;

        [NativeTypeName("#define SetupDeleteError SetupDeleteErrorW")]
        public static readonly delegate*<IntPtr, ushort*, ushort*, uint, uint, uint> SetupDeleteError = &SetupDeleteErrorW;

        [NativeTypeName("#define SetupBackupError SetupBackupErrorW")]
        public static readonly delegate*<IntPtr, ushort*, ushort*, ushort*, uint, uint, uint> SetupBackupError = &SetupBackupErrorW;

        [NativeTypeName("#define IDF_NOBROWSE 0x00000001")]
        public const int IDF_NOBROWSE = 0x00000001;

        [NativeTypeName("#define IDF_NOSKIP 0x00000002")]
        public const int IDF_NOSKIP = 0x00000002;

        [NativeTypeName("#define IDF_NODETAILS 0x00000004")]
        public const int IDF_NODETAILS = 0x00000004;

        [NativeTypeName("#define IDF_NOCOMPRESSED 0x00000008")]
        public const int IDF_NOCOMPRESSED = 0x00000008;

        [NativeTypeName("#define IDF_CHECKFIRST 0x00000100")]
        public const int IDF_CHECKFIRST = 0x00000100;

        [NativeTypeName("#define IDF_NOBEEP 0x00000200")]
        public const int IDF_NOBEEP = 0x00000200;

        [NativeTypeName("#define IDF_NOFOREGROUND 0x00000400")]
        public const int IDF_NOFOREGROUND = 0x00000400;

        [NativeTypeName("#define IDF_WARNIFSKIP 0x00000800")]
        public const int IDF_WARNIFSKIP = 0x00000800;

        [NativeTypeName("#define IDF_NOREMOVABLEMEDIAPROMPT 0x00001000")]
        public const int IDF_NOREMOVABLEMEDIAPROMPT = 0x00001000;

        [NativeTypeName("#define IDF_USEDISKNAMEASPROMPT 0x00002000")]
        public const int IDF_USEDISKNAMEASPROMPT = 0x00002000;

        [NativeTypeName("#define IDF_OEMDISK 0x80000000")]
        public const uint IDF_OEMDISK = 0x80000000;

        [NativeTypeName("#define DPROMPT_SUCCESS 0")]
        public const int DPROMPT_SUCCESS = 0;

        [NativeTypeName("#define DPROMPT_CANCEL 1")]
        public const int DPROMPT_CANCEL = 1;

        [NativeTypeName("#define DPROMPT_SKIPFILE 2")]
        public const int DPROMPT_SKIPFILE = 2;

        [NativeTypeName("#define DPROMPT_BUFFERTOOSMALL 3")]
        public const int DPROMPT_BUFFERTOOSMALL = 3;

        [NativeTypeName("#define DPROMPT_OUTOFMEMORY 4")]
        public const int DPROMPT_OUTOFMEMORY = 4;

        [NativeTypeName("#define SetupSetDirectoryId SetupSetDirectoryIdW")]
        public static readonly delegate*<void*, uint, ushort*, int> SetupSetDirectoryId = &SetupSetDirectoryIdW;

        [NativeTypeName("#define SetupSetDirectoryIdEx SetupSetDirectoryIdExW")]
        public static readonly delegate*<void*, uint, ushort*, uint, uint, void*, int> SetupSetDirectoryIdEx = &SetupSetDirectoryIdExW;

        [NativeTypeName("#define SETDIRID_NOT_FULL_PATH 0x00000001")]
        public const int SETDIRID_NOT_FULL_PATH = 0x00000001;

        [NativeTypeName("#define SetupGetSourceInfo SetupGetSourceInfoW")]
        public static readonly delegate*<void*, uint, uint, ushort*, uint, uint*, int> SetupGetSourceInfo = &SetupGetSourceInfoW;

        [NativeTypeName("#define SRCINFO_PATH 1")]
        public const int SRCINFO_PATH = 1;

        [NativeTypeName("#define SRCINFO_TAGFILE 2")]
        public const int SRCINFO_TAGFILE = 2;

        [NativeTypeName("#define SRCINFO_DESCRIPTION 3")]
        public const int SRCINFO_DESCRIPTION = 3;

        [NativeTypeName("#define SRCINFO_FLAGS 4")]
        public const int SRCINFO_FLAGS = 4;

        [NativeTypeName("#define SRCINFO_TAGFILE2 5")]
        public const int SRCINFO_TAGFILE2 = 5;

        [NativeTypeName("#define SRC_FLAGS_CABFILE (0x0010)")]
        public const int SRC_FLAGS_CABFILE = (0x0010);

        [NativeTypeName("#define SetupInstallFile SetupInstallFileW")]
        public static readonly delegate*<void*, INFCONTEXT*, ushort*, ushort*, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, int> SetupInstallFile = &SetupInstallFileW;

        [NativeTypeName("#define SetupInstallFileEx SetupInstallFileExW")]
        public static readonly delegate*<void*, INFCONTEXT*, ushort*, ushort*, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, int*, int> SetupInstallFileEx = &SetupInstallFileExW;

        [NativeTypeName("#define SP_COPY_DELETESOURCE 0x0000001")]
        public const int SP_COPY_DELETESOURCE = 0x0000001;

        [NativeTypeName("#define SP_COPY_REPLACEONLY 0x0000002")]
        public const int SP_COPY_REPLACEONLY = 0x0000002;

        [NativeTypeName("#define SP_COPY_NEWER 0x0000004")]
        public const int SP_COPY_NEWER = 0x0000004;

        [NativeTypeName("#define SP_COPY_NEWER_OR_SAME SP_COPY_NEWER")]
        public const int SP_COPY_NEWER_OR_SAME = 0x0000004;

        [NativeTypeName("#define SP_COPY_NOOVERWRITE 0x0000008")]
        public const int SP_COPY_NOOVERWRITE = 0x0000008;

        [NativeTypeName("#define SP_COPY_NODECOMP 0x0000010")]
        public const int SP_COPY_NODECOMP = 0x0000010;

        [NativeTypeName("#define SP_COPY_LANGUAGEAWARE 0x0000020")]
        public const int SP_COPY_LANGUAGEAWARE = 0x0000020;

        [NativeTypeName("#define SP_COPY_SOURCE_ABSOLUTE 0x0000040")]
        public const int SP_COPY_SOURCE_ABSOLUTE = 0x0000040;

        [NativeTypeName("#define SP_COPY_SOURCEPATH_ABSOLUTE 0x0000080")]
        public const int SP_COPY_SOURCEPATH_ABSOLUTE = 0x0000080;

        [NativeTypeName("#define SP_COPY_IN_USE_NEEDS_REBOOT 0x0000100")]
        public const int SP_COPY_IN_USE_NEEDS_REBOOT = 0x0000100;

        [NativeTypeName("#define SP_COPY_FORCE_IN_USE 0x0000200")]
        public const int SP_COPY_FORCE_IN_USE = 0x0000200;

        [NativeTypeName("#define SP_COPY_NOSKIP 0x0000400")]
        public const int SP_COPY_NOSKIP = 0x0000400;

        [NativeTypeName("#define SP_FLAG_CABINETCONTINUATION 0x0000800")]
        public const int SP_FLAG_CABINETCONTINUATION = 0x0000800;

        [NativeTypeName("#define SP_COPY_FORCE_NOOVERWRITE 0x0001000")]
        public const int SP_COPY_FORCE_NOOVERWRITE = 0x0001000;

        [NativeTypeName("#define SP_COPY_FORCE_NEWER 0x0002000")]
        public const int SP_COPY_FORCE_NEWER = 0x0002000;

        [NativeTypeName("#define SP_COPY_WARNIFSKIP 0x0004000")]
        public const int SP_COPY_WARNIFSKIP = 0x0004000;

        [NativeTypeName("#define SP_COPY_NOBROWSE 0x0008000")]
        public const int SP_COPY_NOBROWSE = 0x0008000;

        [NativeTypeName("#define SP_COPY_NEWER_ONLY 0x0010000")]
        public const int SP_COPY_NEWER_ONLY = 0x0010000;

        [NativeTypeName("#define SP_COPY_RESERVED 0x0020000")]
        public const int SP_COPY_RESERVED = 0x0020000;

        [NativeTypeName("#define SP_COPY_OEMINF_CATALOG_ONLY 0x0040000")]
        public const int SP_COPY_OEMINF_CATALOG_ONLY = 0x0040000;

        [NativeTypeName("#define SP_COPY_REPLACE_BOOT_FILE 0x0080000")]
        public const int SP_COPY_REPLACE_BOOT_FILE = 0x0080000;

        [NativeTypeName("#define SP_COPY_NOPRUNE 0x0100000")]
        public const int SP_COPY_NOPRUNE = 0x0100000;

        [NativeTypeName("#define SP_COPY_OEM_F6_INF 0x0200000")]
        public const int SP_COPY_OEM_F6_INF = 0x0200000;

        [NativeTypeName("#define SP_COPY_ALREADYDECOMP 0x0400000")]
        public const int SP_COPY_ALREADYDECOMP = 0x0400000;

        [NativeTypeName("#define SP_COPY_WINDOWS_SIGNED 0x1000000")]
        public const int SP_COPY_WINDOWS_SIGNED = 0x1000000;

        [NativeTypeName("#define SP_COPY_PNPLOCKED 0x2000000")]
        public const int SP_COPY_PNPLOCKED = 0x2000000;

        [NativeTypeName("#define SP_COPY_IN_USE_TRY_RENAME 0x4000000")]
        public const int SP_COPY_IN_USE_TRY_RENAME = 0x4000000;

        [NativeTypeName("#define SP_COPY_INBOX_INF 0x8000000")]
        public const int SP_COPY_INBOX_INF = 0x8000000;

        [NativeTypeName("#define SP_COPY_HARDLINK 0x10000000")]
        public const int SP_COPY_HARDLINK = 0x10000000;

        [NativeTypeName("#define SP_BACKUP_BACKUPPASS 0x00000001")]
        public const int SP_BACKUP_BACKUPPASS = 0x00000001;

        [NativeTypeName("#define SP_BACKUP_DEMANDPASS 0x00000002")]
        public const int SP_BACKUP_DEMANDPASS = 0x00000002;

        [NativeTypeName("#define SP_BACKUP_SPECIAL 0x00000004")]
        public const int SP_BACKUP_SPECIAL = 0x00000004;

        [NativeTypeName("#define SP_BACKUP_BOOTFILE 0x00000008")]
        public const int SP_BACKUP_BOOTFILE = 0x00000008;

        [NativeTypeName("#define SetupSetFileQueueAlternatePlatform SetupSetFileQueueAlternatePlatformW")]
        public static readonly delegate*<void*, SP_ALTPLATFORM_INFO_V2*, ushort*, int> SetupSetFileQueueAlternatePlatform = &SetupSetFileQueueAlternatePlatformW;

        [NativeTypeName("#define SetupSetPlatformPathOverride SetupSetPlatformPathOverrideW")]
        public static readonly delegate*<ushort*, int> SetupSetPlatformPathOverride = &SetupSetPlatformPathOverrideW;

        [NativeTypeName("#define SetupQueueCopy SetupQueueCopyW")]
        public static readonly delegate*<void*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, uint, int> SetupQueueCopy = &SetupQueueCopyW;

        [NativeTypeName("#define SetupQueueCopyIndirect SetupQueueCopyIndirectW")]
        public static readonly delegate*<SP_FILE_COPY_PARAMS_W*, int> SetupQueueCopyIndirect = &SetupQueueCopyIndirectW;

        [NativeTypeName("#define SetupQueueDefaultCopy SetupQueueDefaultCopyW")]
        public static readonly delegate*<void*, void*, ushort*, ushort*, ushort*, uint, int> SetupQueueDefaultCopy = &SetupQueueDefaultCopyW;

        [NativeTypeName("#define SetupQueueCopySection SetupQueueCopySectionW")]
        public static readonly delegate*<void*, ushort*, void*, void*, ushort*, uint, int> SetupQueueCopySection = &SetupQueueCopySectionW;

        [NativeTypeName("#define SetupQueueDelete SetupQueueDeleteW")]
        public static readonly delegate*<void*, ushort*, ushort*, int> SetupQueueDelete = &SetupQueueDeleteW;

        [NativeTypeName("#define SetupQueueDeleteSection SetupQueueDeleteSectionW")]
        public static readonly delegate*<void*, void*, void*, ushort*, int> SetupQueueDeleteSection = &SetupQueueDeleteSectionW;

        [NativeTypeName("#define SetupQueueRename SetupQueueRenameW")]
        public static readonly delegate*<void*, ushort*, ushort*, ushort*, ushort*, int> SetupQueueRename = &SetupQueueRenameW;

        [NativeTypeName("#define SetupQueueRenameSection SetupQueueRenameSectionW")]
        public static readonly delegate*<void*, void*, void*, ushort*, int> SetupQueueRenameSection = &SetupQueueRenameSectionW;

        [NativeTypeName("#define SetupCommitFileQueue SetupCommitFileQueueW")]
        public static readonly delegate*<IntPtr, void*, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, int> SetupCommitFileQueue = &SetupCommitFileQueueW;

        [NativeTypeName("#define SetupScanFileQueue SetupScanFileQueueW")]
        public static readonly delegate*<void*, uint, IntPtr, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, uint*, int> SetupScanFileQueue = &SetupScanFileQueueW;

        [NativeTypeName("#define SPQ_SCAN_FILE_PRESENCE 0x00000001")]
        public const int SPQ_SCAN_FILE_PRESENCE = 0x00000001;

        [NativeTypeName("#define SPQ_SCAN_FILE_VALIDITY 0x00000002")]
        public const int SPQ_SCAN_FILE_VALIDITY = 0x00000002;

        [NativeTypeName("#define SPQ_SCAN_USE_CALLBACK 0x00000004")]
        public const int SPQ_SCAN_USE_CALLBACK = 0x00000004;

        [NativeTypeName("#define SPQ_SCAN_USE_CALLBACKEX 0x00000008")]
        public const int SPQ_SCAN_USE_CALLBACKEX = 0x00000008;

        [NativeTypeName("#define SPQ_SCAN_INFORM_USER 0x00000010")]
        public const int SPQ_SCAN_INFORM_USER = 0x00000010;

        [NativeTypeName("#define SPQ_SCAN_PRUNE_COPY_QUEUE 0x00000020")]
        public const int SPQ_SCAN_PRUNE_COPY_QUEUE = 0x00000020;

        [NativeTypeName("#define SPQ_SCAN_USE_CALLBACK_SIGNERINFO 0x00000040")]
        public const int SPQ_SCAN_USE_CALLBACK_SIGNERINFO = 0x00000040;

        [NativeTypeName("#define SPQ_SCAN_PRUNE_DELREN 0x00000080")]
        public const int SPQ_SCAN_PRUNE_DELREN = 0x00000080;

        [NativeTypeName("#define SPQ_SCAN_FILE_PRESENCE_WITHOUT_SOURCE 0x00000100")]
        public const int SPQ_SCAN_FILE_PRESENCE_WITHOUT_SOURCE = 0x00000100;

        [NativeTypeName("#define SPQ_SCAN_FILE_COMPARISON 0x00000200")]
        public const int SPQ_SCAN_FILE_COMPARISON = 0x00000200;

        [NativeTypeName("#define SPQ_SCAN_ACTIVATE_DRP 0x00000400")]
        public const int SPQ_SCAN_ACTIVATE_DRP = 0x00000400;

        [NativeTypeName("#define SPQ_DELAYED_COPY 0x00000001")]
        public const int SPQ_DELAYED_COPY = 0x00000001;

        [NativeTypeName("#define SPQ_FLAG_BACKUP_AWARE 0x00000001")]
        public const int SPQ_FLAG_BACKUP_AWARE = 0x00000001;

        [NativeTypeName("#define SPQ_FLAG_ABORT_IF_UNSIGNED 0x00000002")]
        public const int SPQ_FLAG_ABORT_IF_UNSIGNED = 0x00000002;

        [NativeTypeName("#define SPQ_FLAG_FILES_MODIFIED 0x00000004")]
        public const int SPQ_FLAG_FILES_MODIFIED = 0x00000004;

        [NativeTypeName("#define SPQ_FLAG_DO_SHUFFLEMOVE 0x00000008")]
        public const int SPQ_FLAG_DO_SHUFFLEMOVE = 0x00000008;

        [NativeTypeName("#define SPQ_FLAG_VALID 0x0000000F")]
        public const int SPQ_FLAG_VALID = 0x0000000F;

        [NativeTypeName("#define SPOST_NONE 0")]
        public const int SPOST_NONE = 0;

        [NativeTypeName("#define SPOST_PATH 1")]
        public const int SPOST_PATH = 1;

        [NativeTypeName("#define SPOST_URL 2")]
        public const int SPOST_URL = 2;

        [NativeTypeName("#define SPOST_MAX 3")]
        public const int SPOST_MAX = 3;

        [NativeTypeName("#define SetupCopyOEMInf SetupCopyOEMInfW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint, ushort*, uint, uint*, ushort**, int> SetupCopyOEMInf = &SetupCopyOEMInfW;

        [NativeTypeName("#define SUOI_FORCEDELETE 0x00000001")]
        public const int SUOI_FORCEDELETE = 0x00000001;

        [NativeTypeName("#define SUOI_INTERNAL1 0x00000002")]
        public const int SUOI_INTERNAL1 = 0x00000002;

        [NativeTypeName("#define SetupUninstallOEMInf SetupUninstallOEMInfW")]
        public static readonly delegate*<ushort*, uint, void*, int> SetupUninstallOEMInf = &SetupUninstallOEMInfW;

        [NativeTypeName("#define SetupCreateDiskSpaceList SetupCreateDiskSpaceListW")]
        public static readonly delegate*<void*, uint, uint, void*> SetupCreateDiskSpaceList = &SetupCreateDiskSpaceListW;

        [NativeTypeName("#define SPDSL_IGNORE_DISK 0x00000001")]
        public const int SPDSL_IGNORE_DISK = 0x00000001;

        [NativeTypeName("#define SPDSL_DISALLOW_NEGATIVE_ADJUST 0x00000002")]
        public const int SPDSL_DISALLOW_NEGATIVE_ADJUST = 0x00000002;

        [NativeTypeName("#define SetupDuplicateDiskSpaceList SetupDuplicateDiskSpaceListW")]
        public static readonly delegate*<void*, void*, uint, uint, void*> SetupDuplicateDiskSpaceList = &SetupDuplicateDiskSpaceListW;

        [NativeTypeName("#define SetupQueryDrivesInDiskSpaceList SetupQueryDrivesInDiskSpaceListW")]
        public static readonly delegate*<void*, ushort*, uint, uint*, int> SetupQueryDrivesInDiskSpaceList = &SetupQueryDrivesInDiskSpaceListW;

        [NativeTypeName("#define SetupQuerySpaceRequiredOnDrive SetupQuerySpaceRequiredOnDriveW")]
        public static readonly delegate*<void*, ushort*, long*, void*, uint, int> SetupQuerySpaceRequiredOnDrive = &SetupQuerySpaceRequiredOnDriveW;

        [NativeTypeName("#define SetupAdjustDiskSpaceList SetupAdjustDiskSpaceListW")]
        public static readonly delegate*<void*, ushort*, long, void*, uint, int> SetupAdjustDiskSpaceList = &SetupAdjustDiskSpaceListW;

        [NativeTypeName("#define SetupAddToDiskSpaceList SetupAddToDiskSpaceListW")]
        public static readonly delegate*<void*, ushort*, long, uint, void*, uint, int> SetupAddToDiskSpaceList = &SetupAddToDiskSpaceListW;

        [NativeTypeName("#define SetupAddSectionToDiskSpaceList SetupAddSectionToDiskSpaceListW")]
        public static readonly delegate*<void*, void*, void*, ushort*, uint, void*, uint, int> SetupAddSectionToDiskSpaceList = &SetupAddSectionToDiskSpaceListW;

        [NativeTypeName("#define SetupAddInstallSectionToDiskSpaceList SetupAddInstallSectionToDiskSpaceListW")]
        public static readonly delegate*<void*, void*, void*, ushort*, void*, uint, int> SetupAddInstallSectionToDiskSpaceList = &SetupAddInstallSectionToDiskSpaceListW;

        [NativeTypeName("#define SetupRemoveFromDiskSpaceList SetupRemoveFromDiskSpaceListW")]
        public static readonly delegate*<void*, ushort*, uint, void*, uint, int> SetupRemoveFromDiskSpaceList = &SetupRemoveFromDiskSpaceListW;

        [NativeTypeName("#define SetupRemoveSectionFromDiskSpaceList SetupRemoveSectionFromDiskSpaceListW")]
        public static readonly delegate*<void*, void*, void*, ushort*, uint, void*, uint, int> SetupRemoveSectionFromDiskSpaceList = &SetupRemoveSectionFromDiskSpaceListW;

        [NativeTypeName("#define SetupRemoveInstallSectionFromDiskSpaceList SetupRemoveInstallSectionFromDiskSpaceListW")]
        public static readonly delegate*<void*, void*, void*, ushort*, void*, uint, int> SetupRemoveInstallSectionFromDiskSpaceList = &SetupRemoveInstallSectionFromDiskSpaceListW;

        [NativeTypeName("#define SetupIterateCabinet SetupIterateCabinetW")]
        public static readonly delegate*<ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, int> SetupIterateCabinet = &SetupIterateCabinetW;

        [NativeTypeName("#define SPFILEQ_FILE_IN_USE 0x00000001")]
        public const int SPFILEQ_FILE_IN_USE = 0x00000001;

        [NativeTypeName("#define SPFILEQ_REBOOT_RECOMMENDED 0x00000002")]
        public const int SPFILEQ_REBOOT_RECOMMENDED = 0x00000002;

        [NativeTypeName("#define SPFILEQ_REBOOT_IN_PROGRESS 0x00000004")]
        public const int SPFILEQ_REBOOT_IN_PROGRESS = 0x00000004;

        [NativeTypeName("#define SetupDefaultQueueCallback SetupDefaultQueueCallbackW")]
        public static readonly delegate*<void*, uint, nuint, nuint, uint> SetupDefaultQueueCallback = &SetupDefaultQueueCallbackW;

        [NativeTypeName("#define FLG_ADDREG_DELREG_BIT ( 0x00008000 )")]
        public const int FLG_ADDREG_DELREG_BIT = (0x00008000);

        [NativeTypeName("#define FLG_ADDREG_BINVALUETYPE ( 0x00000001 )")]
        public const int FLG_ADDREG_BINVALUETYPE = (0x00000001);

        [NativeTypeName("#define FLG_ADDREG_NOCLOBBER ( 0x00000002 )")]
        public const int FLG_ADDREG_NOCLOBBER = (0x00000002);

        [NativeTypeName("#define FLG_ADDREG_DELVAL ( 0x00000004 )")]
        public const int FLG_ADDREG_DELVAL = (0x00000004);

        [NativeTypeName("#define FLG_ADDREG_APPEND ( 0x00000008 )")]
        public const int FLG_ADDREG_APPEND = (0x00000008);

        [NativeTypeName("#define FLG_ADDREG_KEYONLY ( 0x00000010 )")]
        public const int FLG_ADDREG_KEYONLY = (0x00000010);

        [NativeTypeName("#define FLG_ADDREG_OVERWRITEONLY ( 0x00000020 )")]
        public const int FLG_ADDREG_OVERWRITEONLY = (0x00000020);

        [NativeTypeName("#define FLG_ADDREG_64BITKEY ( 0x00001000 )")]
        public const int FLG_ADDREG_64BITKEY = (0x00001000);

        [NativeTypeName("#define FLG_ADDREG_KEYONLY_COMMON ( 0x00002000 )")]
        public const int FLG_ADDREG_KEYONLY_COMMON = (0x00002000);

        [NativeTypeName("#define FLG_ADDREG_32BITKEY ( 0x00004000 )")]
        public const int FLG_ADDREG_32BITKEY = (0x00004000);

        [NativeTypeName("#define FLG_ADDREG_TYPE_MASK ( 0xFFFF0000 | FLG_ADDREG_BINVALUETYPE )")]
        public const uint FLG_ADDREG_TYPE_MASK = (0xFFFF0000 | (0x00000001));

        [NativeTypeName("#define FLG_ADDREG_TYPE_SZ ( 0x00000000                           )")]
        public const int FLG_ADDREG_TYPE_SZ = (0x00000000);

        [NativeTypeName("#define FLG_ADDREG_TYPE_MULTI_SZ ( 0x00010000                           )")]
        public const int FLG_ADDREG_TYPE_MULTI_SZ = (0x00010000);

        [NativeTypeName("#define FLG_ADDREG_TYPE_EXPAND_SZ ( 0x00020000                           )")]
        public const int FLG_ADDREG_TYPE_EXPAND_SZ = (0x00020000);

        [NativeTypeName("#define FLG_ADDREG_TYPE_BINARY ( 0x00000000 | FLG_ADDREG_BINVALUETYPE )")]
        public const int FLG_ADDREG_TYPE_BINARY = (0x00000000 | (0x00000001));

        [NativeTypeName("#define FLG_ADDREG_TYPE_DWORD ( 0x00010000 | FLG_ADDREG_BINVALUETYPE )")]
        public const int FLG_ADDREG_TYPE_DWORD = (0x00010000 | (0x00000001));

        [NativeTypeName("#define FLG_ADDREG_TYPE_NONE ( 0x00020000 | FLG_ADDREG_BINVALUETYPE )")]
        public const int FLG_ADDREG_TYPE_NONE = (0x00020000 | (0x00000001));

        [NativeTypeName("#define FLG_ADDREG_TYPE_QWORD ( 0x000B0000 | FLG_ADDREG_BINVALUETYPE )")]
        public const int FLG_ADDREG_TYPE_QWORD = (0x000B0000 | (0x00000001));

        [NativeTypeName("#define FLG_DELREG_VALUE (0x00000000)")]
        public const int FLG_DELREG_VALUE = (0x00000000);

        [NativeTypeName("#define FLG_DELREG_TYPE_MASK FLG_ADDREG_TYPE_MASK")]
        public const uint FLG_DELREG_TYPE_MASK = (0xFFFF0000 | (0x00000001));

        [NativeTypeName("#define FLG_DELREG_TYPE_SZ FLG_ADDREG_TYPE_SZ")]
        public const int FLG_DELREG_TYPE_SZ = (0x00000000);

        [NativeTypeName("#define FLG_DELREG_TYPE_MULTI_SZ FLG_ADDREG_TYPE_MULTI_SZ")]
        public const int FLG_DELREG_TYPE_MULTI_SZ = (0x00010000);

        [NativeTypeName("#define FLG_DELREG_TYPE_EXPAND_SZ FLG_ADDREG_TYPE_EXPAND_SZ")]
        public const int FLG_DELREG_TYPE_EXPAND_SZ = (0x00020000);

        [NativeTypeName("#define FLG_DELREG_TYPE_BINARY FLG_ADDREG_TYPE_BINARY")]
        public const int FLG_DELREG_TYPE_BINARY = (0x00000000 | (0x00000001));

        [NativeTypeName("#define FLG_DELREG_TYPE_DWORD FLG_ADDREG_TYPE_DWORD")]
        public const int FLG_DELREG_TYPE_DWORD = (0x00010000 | (0x00000001));

        [NativeTypeName("#define FLG_DELREG_TYPE_NONE FLG_ADDREG_TYPE_NONE")]
        public const int FLG_DELREG_TYPE_NONE = (0x00020000 | (0x00000001));

        [NativeTypeName("#define FLG_DELREG_64BITKEY FLG_ADDREG_64BITKEY")]
        public const int FLG_DELREG_64BITKEY = (0x00001000);

        [NativeTypeName("#define FLG_DELREG_KEYONLY_COMMON FLG_ADDREG_KEYONLY_COMMON")]
        public const int FLG_DELREG_KEYONLY_COMMON = (0x00002000);

        [NativeTypeName("#define FLG_DELREG_32BITKEY FLG_ADDREG_32BITKEY")]
        public const int FLG_DELREG_32BITKEY = (0x00004000);

        [NativeTypeName("#define FLG_DELREG_OPERATION_MASK (0x000000FE)")]
        public const int FLG_DELREG_OPERATION_MASK = (0x000000FE);

        [NativeTypeName("#define FLG_DELREG_MULTI_SZ_DELSTRING ( FLG_DELREG_TYPE_MULTI_SZ | FLG_ADDREG_DELREG_BIT | 0x00000002 )")]
        public const int FLG_DELREG_MULTI_SZ_DELSTRING = ((0x00010000) | (0x00008000) | 0x00000002);

        [NativeTypeName("#define FLG_DELREG_TYPE_QWORD FLG_ADDREG_TYPE_QWORD")]
        public const int FLG_DELREG_TYPE_QWORD = (0x000B0000 | (0x00000001));

        [NativeTypeName("#define FLG_BITREG_CLEARBITS ( 0x00000000 )")]
        public const int FLG_BITREG_CLEARBITS = (0x00000000);

        [NativeTypeName("#define FLG_BITREG_SETBITS ( 0x00000001 )")]
        public const int FLG_BITREG_SETBITS = (0x00000001);

        [NativeTypeName("#define FLG_BITREG_64BITKEY ( 0x00001000 )")]
        public const int FLG_BITREG_64BITKEY = (0x00001000);

        [NativeTypeName("#define FLG_BITREG_32BITKEY ( 0x00004000 )")]
        public const int FLG_BITREG_32BITKEY = (0x00004000);

        [NativeTypeName("#define FLG_INI2REG_64BITKEY ( 0x00001000 )")]
        public const int FLG_INI2REG_64BITKEY = (0x00001000);

        [NativeTypeName("#define FLG_INI2REG_32BITKEY ( 0x00004000 )")]
        public const int FLG_INI2REG_32BITKEY = (0x00004000);

        [NativeTypeName("#define FLG_REGSVR_DLLREGISTER ( 0x00000001 )")]
        public const int FLG_REGSVR_DLLREGISTER = (0x00000001);

        [NativeTypeName("#define FLG_REGSVR_DLLINSTALL ( 0x00000002 )")]
        public const int FLG_REGSVR_DLLINSTALL = (0x00000002);

        [NativeTypeName("#define FLG_PROFITEM_CURRENTUSER ( 0x00000001 )")]
        public const int FLG_PROFITEM_CURRENTUSER = (0x00000001);

        [NativeTypeName("#define FLG_PROFITEM_DELETE ( 0x00000002 )")]
        public const int FLG_PROFITEM_DELETE = (0x00000002);

        [NativeTypeName("#define FLG_PROFITEM_GROUP ( 0x00000004 )")]
        public const int FLG_PROFITEM_GROUP = (0x00000004);

        [NativeTypeName("#define FLG_PROFITEM_CSIDL ( 0x00000008 )")]
        public const int FLG_PROFITEM_CSIDL = (0x00000008);

        [NativeTypeName("#define FLG_ADDPROPERTY_NOCLOBBER ( 0x00000001 )")]
        public const int FLG_ADDPROPERTY_NOCLOBBER = (0x00000001);

        [NativeTypeName("#define FLG_ADDPROPERTY_OVERWRITEONLY ( 0x00000002 )")]
        public const int FLG_ADDPROPERTY_OVERWRITEONLY = (0x00000002);

        [NativeTypeName("#define FLG_ADDPROPERTY_APPEND ( 0x00000004 )")]
        public const int FLG_ADDPROPERTY_APPEND = (0x00000004);

        [NativeTypeName("#define FLG_ADDPROPERTY_OR ( 0x00000008 )")]
        public const int FLG_ADDPROPERTY_OR = (0x00000008);

        [NativeTypeName("#define FLG_ADDPROPERTY_AND ( 0x00000010 )")]
        public const int FLG_ADDPROPERTY_AND = (0x00000010);

        [NativeTypeName("#define FLG_DELPROPERTY_MULTI_SZ_DELSTRING ( 0x00000001 )")]
        public const int FLG_DELPROPERTY_MULTI_SZ_DELSTRING = (0x00000001);

        [NativeTypeName("#define SetupInstallFromInfSection SetupInstallFromInfSectionW")]
        public static readonly delegate*<IntPtr, void*, ushort*, uint, IntPtr, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, void*, SP_DEVINFO_DATA*, int> SetupInstallFromInfSection = &SetupInstallFromInfSectionW;

        [NativeTypeName("#define SPINST_LOGCONFIG 0x00000001")]
        public const int SPINST_LOGCONFIG = 0x00000001;

        [NativeTypeName("#define SPINST_INIFILES 0x00000002")]
        public const int SPINST_INIFILES = 0x00000002;

        [NativeTypeName("#define SPINST_REGISTRY 0x00000004")]
        public const int SPINST_REGISTRY = 0x00000004;

        [NativeTypeName("#define SPINST_INI2REG 0x00000008")]
        public const int SPINST_INI2REG = 0x00000008;

        [NativeTypeName("#define SPINST_FILES 0x00000010")]
        public const int SPINST_FILES = 0x00000010;

        [NativeTypeName("#define SPINST_BITREG 0x00000020")]
        public const int SPINST_BITREG = 0x00000020;

        [NativeTypeName("#define SPINST_REGSVR 0x00000040")]
        public const int SPINST_REGSVR = 0x00000040;

        [NativeTypeName("#define SPINST_UNREGSVR 0x00000080")]
        public const int SPINST_UNREGSVR = 0x00000080;

        [NativeTypeName("#define SPINST_PROFILEITEMS 0x00000100")]
        public const int SPINST_PROFILEITEMS = 0x00000100;

        [NativeTypeName("#define SPINST_COPYINF 0x00000200")]
        public const int SPINST_COPYINF = 0x00000200;

        [NativeTypeName("#define SPINST_PROPERTIES 0x00000400")]
        public const int SPINST_PROPERTIES = 0x00000400;

        [NativeTypeName("#define SPINST_ALL 0x000007ff")]
        public const int SPINST_ALL = 0x000007ff;

        [NativeTypeName("#define SPINST_SINGLESECTION 0x00010000")]
        public const int SPINST_SINGLESECTION = 0x00010000;

        [NativeTypeName("#define SPINST_LOGCONFIG_IS_FORCED 0x00020000")]
        public const int SPINST_LOGCONFIG_IS_FORCED = 0x00020000;

        [NativeTypeName("#define SPINST_LOGCONFIGS_ARE_OVERRIDES 0x00040000")]
        public const int SPINST_LOGCONFIGS_ARE_OVERRIDES = 0x00040000;

        [NativeTypeName("#define SPINST_REGISTERCALLBACKAWARE 0x00080000")]
        public const int SPINST_REGISTERCALLBACKAWARE = 0x00080000;

        [NativeTypeName("#define SPINST_DEVICEINSTALL 0x00100000")]
        public const int SPINST_DEVICEINSTALL = 0x00100000;

        [NativeTypeName("#define SetupInstallFilesFromInfSection SetupInstallFilesFromInfSectionW")]
        public static readonly delegate*<void*, void*, void*, ushort*, ushort*, uint, int> SetupInstallFilesFromInfSection = &SetupInstallFilesFromInfSectionW;

        [NativeTypeName("#define SPSVCINST_TAGTOFRONT (0x00000001)")]
        public const int SPSVCINST_TAGTOFRONT = (0x00000001);

        [NativeTypeName("#define SPSVCINST_ASSOCSERVICE (0x00000002)")]
        public const int SPSVCINST_ASSOCSERVICE = (0x00000002);

        [NativeTypeName("#define SPSVCINST_DELETEEVENTLOGENTRY (0x00000004)")]
        public const int SPSVCINST_DELETEEVENTLOGENTRY = (0x00000004);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_DISPLAYNAME (0x00000008)")]
        public const int SPSVCINST_NOCLOBBER_DISPLAYNAME = (0x00000008);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_STARTTYPE (0x00000010)")]
        public const int SPSVCINST_NOCLOBBER_STARTTYPE = (0x00000010);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_ERRORCONTROL (0x00000020)")]
        public const int SPSVCINST_NOCLOBBER_ERRORCONTROL = (0x00000020);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_LOADORDERGROUP (0x00000040)")]
        public const int SPSVCINST_NOCLOBBER_LOADORDERGROUP = (0x00000040);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_DEPENDENCIES (0x00000080)")]
        public const int SPSVCINST_NOCLOBBER_DEPENDENCIES = (0x00000080);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_DESCRIPTION (0x00000100)")]
        public const int SPSVCINST_NOCLOBBER_DESCRIPTION = (0x00000100);

        [NativeTypeName("#define SPSVCINST_STOPSERVICE (0x00000200)")]
        public const int SPSVCINST_STOPSERVICE = (0x00000200);

        [NativeTypeName("#define SPSVCINST_CLOBBER_SECURITY (0x00000400)")]
        public const int SPSVCINST_CLOBBER_SECURITY = (0x00000400);

        [NativeTypeName("#define SPSVCINST_STARTSERVICE (0x00000800)")]
        public const int SPSVCINST_STARTSERVICE = (0x00000800);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_REQUIREDPRIVILEGES (0x00001000)")]
        public const int SPSVCINST_NOCLOBBER_REQUIREDPRIVILEGES = (0x00001000);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_TRIGGERS (0x00002000)")]
        public const int SPSVCINST_NOCLOBBER_TRIGGERS = (0x00002000);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_SERVICESIDTYPE (0x00004000)")]
        public const int SPSVCINST_NOCLOBBER_SERVICESIDTYPE = (0x00004000);

        [NativeTypeName("#define SPSVCINST_NOCLOBBER_DELAYEDAUTOSTART (0x00008000)")]
        public const int SPSVCINST_NOCLOBBER_DELAYEDAUTOSTART = (0x00008000);

        [NativeTypeName("#define SetupInstallServicesFromInfSection SetupInstallServicesFromInfSectionW")]
        public static readonly delegate*<void*, ushort*, uint, int> SetupInstallServicesFromInfSection = &SetupInstallServicesFromInfSectionW;

        [NativeTypeName("#define SetupInstallServicesFromInfSectionEx SetupInstallServicesFromInfSectionExW")]
        public static readonly delegate*<void*, ushort*, uint, void*, SP_DEVINFO_DATA*, void*, void*, int> SetupInstallServicesFromInfSectionEx = &SetupInstallServicesFromInfSectionExW;

        [NativeTypeName("#define InstallHinfSection InstallHinfSectionW")]
        public static readonly delegate*<IntPtr, IntPtr, ushort*, int, void> InstallHinfSection = &InstallHinfSectionW;

        [NativeTypeName("#define SetupInitializeFileLog SetupInitializeFileLogW")]
        public static readonly delegate*<ushort*, uint, void*> SetupInitializeFileLog = &SetupInitializeFileLogW;

        [NativeTypeName("#define SPFILELOG_SYSTEMLOG 0x00000001")]
        public const int SPFILELOG_SYSTEMLOG = 0x00000001;

        [NativeTypeName("#define SPFILELOG_FORCENEW 0x00000002")]
        public const int SPFILELOG_FORCENEW = 0x00000002;

        [NativeTypeName("#define SPFILELOG_QUERYONLY 0x00000004")]
        public const int SPFILELOG_QUERYONLY = 0x00000004;

        [NativeTypeName("#define SetupLogFile SetupLogFileW")]
        public static readonly delegate*<void*, ushort*, ushort*, ushort*, uint, ushort*, ushort*, ushort*, uint, int> SetupLogFile = &SetupLogFileW;

        [NativeTypeName("#define SPFILELOG_OEMFILE 0x00000001")]
        public const int SPFILELOG_OEMFILE = 0x00000001;

        [NativeTypeName("#define SetupRemoveFileLogEntry SetupRemoveFileLogEntryW")]
        public static readonly delegate*<void*, ushort*, ushort*, int> SetupRemoveFileLogEntry = &SetupRemoveFileLogEntryW;

        [NativeTypeName("#define SetupQueryFileLog SetupQueryFileLogW")]
        public static readonly delegate*<void*, ushort*, ushort*, SetupFileLogInfo, ushort*, uint, uint*, int> SetupQueryFileLog = &SetupQueryFileLogW;

        [NativeTypeName("#define LogSevInformation 0x00000000")]
        public const int LogSevInformation = 0x00000000;

        [NativeTypeName("#define LogSevWarning 0x00000001")]
        public const int LogSevWarning = 0x00000001;

        [NativeTypeName("#define LogSevError 0x00000002")]
        public const int LogSevError = 0x00000002;

        [NativeTypeName("#define LogSevFatalError 0x00000003")]
        public const int LogSevFatalError = 0x00000003;

        [NativeTypeName("#define LogSevMaximum 0x00000004")]
        public const int LogSevMaximum = 0x00000004;

        [NativeTypeName("#define SetupLogError SetupLogErrorW")]
        public static readonly delegate*<ushort*, uint, int> SetupLogError = &SetupLogErrorW;

        [NativeTypeName("#define SetupGetBackupInformation SetupGetBackupInformationW")]
        public static readonly delegate*<void*, SP_BACKUP_QUEUE_PARAMS_V2_W*, int> SetupGetBackupInformation = &SetupGetBackupInformationW;

        [NativeTypeName("#define SetupPrepareQueueForRestore SetupPrepareQueueForRestoreW")]
        public static readonly delegate*<void*, ushort*, uint, int> SetupPrepareQueueForRestore = &SetupPrepareQueueForRestoreW;

        [NativeTypeName("#define SetupDiCreateDeviceInfoListEx SetupDiCreateDeviceInfoListExW")]
        public static readonly delegate*<Guid*, IntPtr, ushort*, void*, void*> SetupDiCreateDeviceInfoListEx = &SetupDiCreateDeviceInfoListExW;

        [NativeTypeName("#define SetupDiGetDeviceInfoListDetail SetupDiGetDeviceInfoListDetailW")]
        public static readonly delegate*<void*, SP_DEVINFO_LIST_DETAIL_DATA_W*, int> SetupDiGetDeviceInfoListDetail = &SetupDiGetDeviceInfoListDetailW;

        [NativeTypeName("#define DICD_GENERATE_ID 0x00000001")]
        public const int DICD_GENERATE_ID = 0x00000001;

        [NativeTypeName("#define DICD_INHERIT_CLASSDRVS 0x00000002")]
        public const int DICD_INHERIT_CLASSDRVS = 0x00000002;

        [NativeTypeName("#define SetupDiCreateDeviceInfo SetupDiCreateDeviceInfoW")]
        public static readonly delegate*<void*, ushort*, Guid*, ushort*, IntPtr, uint, SP_DEVINFO_DATA*, int> SetupDiCreateDeviceInfo = &SetupDiCreateDeviceInfoW;

        [NativeTypeName("#define DIOD_INHERIT_CLASSDRVS 0x00000002")]
        public const int DIOD_INHERIT_CLASSDRVS = 0x00000002;

        [NativeTypeName("#define DIOD_CANCEL_REMOVE 0x00000004")]
        public const int DIOD_CANCEL_REMOVE = 0x00000004;

        [NativeTypeName("#define SetupDiOpenDeviceInfo SetupDiOpenDeviceInfoW")]
        public static readonly delegate*<void*, ushort*, IntPtr, uint, SP_DEVINFO_DATA*, int> SetupDiOpenDeviceInfo = &SetupDiOpenDeviceInfoW;

        [NativeTypeName("#define SetupDiGetDeviceInstanceId SetupDiGetDeviceInstanceIdW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, ushort*, uint, uint*, int> SetupDiGetDeviceInstanceId = &SetupDiGetDeviceInstanceIdW;

        [NativeTypeName("#define SetupDiEnumInterfaceDevice SetupDiEnumDeviceInterfaces")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, Guid*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiEnumInterfaceDevice = &SetupDiEnumDeviceInterfaces;

        [NativeTypeName("#define SetupDiCreateDeviceInterface SetupDiCreateDeviceInterfaceW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, Guid*, ushort*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiCreateDeviceInterface = &SetupDiCreateDeviceInterfaceW;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceW SetupDiCreateDeviceInterfaceW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, Guid*, ushort*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiCreateInterfaceDeviceW = &SetupDiCreateDeviceInterfaceW;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceA SetupDiCreateDeviceInterfaceA")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, Guid*, sbyte*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiCreateInterfaceDeviceA = &SetupDiCreateDeviceInterfaceA;

        [NativeTypeName("#define SetupDiCreateInterfaceDevice SetupDiCreateDeviceInterfaceW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, Guid*, ushort*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiCreateInterfaceDevice = &SetupDiCreateDeviceInterfaceW;

        [NativeTypeName("#define DIODI_NO_ADD 0x00000001")]
        public const int DIODI_NO_ADD = 0x00000001;

        [NativeTypeName("#define SetupDiOpenDeviceInterface SetupDiOpenDeviceInterfaceW")]
        public static readonly delegate*<void*, ushort*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiOpenDeviceInterface = &SetupDiOpenDeviceInterfaceW;

        [NativeTypeName("#define SetupDiOpenInterfaceDeviceW SetupDiOpenDeviceInterfaceW")]
        public static readonly delegate*<void*, ushort*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiOpenInterfaceDeviceW = &SetupDiOpenDeviceInterfaceW;

        [NativeTypeName("#define SetupDiOpenInterfaceDeviceA SetupDiOpenDeviceInterfaceA")]
        public static readonly delegate*<void*, sbyte*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiOpenInterfaceDeviceA = &SetupDiOpenDeviceInterfaceA;

        [NativeTypeName("#define SetupDiOpenInterfaceDevice SetupDiOpenDeviceInterfaceW")]
        public static readonly delegate*<void*, ushort*, uint, SP_DEVICE_INTERFACE_DATA*, int> SetupDiOpenInterfaceDevice = &SetupDiOpenDeviceInterfaceW;

        [NativeTypeName("#define SetupDiGetInterfaceDeviceAlias SetupDiGetDeviceInterfaceAlias")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, Guid*, SP_DEVICE_INTERFACE_DATA*, int> SetupDiGetInterfaceDeviceAlias = &SetupDiGetDeviceInterfaceAlias;

        [NativeTypeName("#define SetupDiDeleteInterfaceDeviceData SetupDiDeleteDeviceInterfaceData")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, int> SetupDiDeleteInterfaceDeviceData = &SetupDiDeleteDeviceInterfaceData;

        [NativeTypeName("#define SetupDiRemoveInterfaceDevice SetupDiRemoveDeviceInterface")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, int> SetupDiRemoveInterfaceDevice = &SetupDiRemoveDeviceInterface;

        [NativeTypeName("#define SetupDiGetDeviceInterfaceDetail SetupDiGetDeviceInterfaceDetailW")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, SP_DEVICE_INTERFACE_DETAIL_DATA_W*, uint, uint*, SP_DEVINFO_DATA*, int> SetupDiGetDeviceInterfaceDetail = &SetupDiGetDeviceInterfaceDetailW;

        [NativeTypeName("#define SetupDiGetInterfaceDeviceDetailW SetupDiGetDeviceInterfaceDetailW")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, SP_DEVICE_INTERFACE_DETAIL_DATA_W*, uint, uint*, SP_DEVINFO_DATA*, int> SetupDiGetInterfaceDeviceDetailW = &SetupDiGetDeviceInterfaceDetailW;

        [NativeTypeName("#define SetupDiGetInterfaceDeviceDetailA SetupDiGetDeviceInterfaceDetailA")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, SP_DEVICE_INTERFACE_DETAIL_DATA_A*, uint, uint*, SP_DEVINFO_DATA*, int> SetupDiGetInterfaceDeviceDetailA = &SetupDiGetDeviceInterfaceDetailA;

        [NativeTypeName("#define SetupDiGetInterfaceDeviceDetail SetupDiGetDeviceInterfaceDetailW")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, SP_DEVICE_INTERFACE_DETAIL_DATA_W*, uint, uint*, SP_DEVINFO_DATA*, int> SetupDiGetInterfaceDeviceDetail = &SetupDiGetDeviceInterfaceDetailW;

        [NativeTypeName("#define SetupDiInstallInterfaceDevices SetupDiInstallDeviceInterfaces")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, int> SetupDiInstallInterfaceDevices = &SetupDiInstallDeviceInterfaces;

        [NativeTypeName("#define SPRDI_FIND_DUPS 0x00000001")]
        public const int SPRDI_FIND_DUPS = 0x00000001;

        [NativeTypeName("#define SPDIT_NODRIVER 0x00000000")]
        public const int SPDIT_NODRIVER = 0x00000000;

        [NativeTypeName("#define SPDIT_CLASSDRIVER 0x00000001")]
        public const int SPDIT_CLASSDRIVER = 0x00000001;

        [NativeTypeName("#define SPDIT_COMPATDRIVER 0x00000002")]
        public const int SPDIT_COMPATDRIVER = 0x00000002;

        [NativeTypeName("#define SetupDiEnumDriverInfo SetupDiEnumDriverInfoW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, uint, uint, SP_DRVINFO_DATA_V2_W*, int> SetupDiEnumDriverInfo = &SetupDiEnumDriverInfoW;

        [NativeTypeName("#define SetupDiGetSelectedDriver SetupDiGetSelectedDriverW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_DRVINFO_DATA_V2_W*, int> SetupDiGetSelectedDriver = &SetupDiGetSelectedDriverW;

        [NativeTypeName("#define SetupDiSetSelectedDriver SetupDiSetSelectedDriverW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_DRVINFO_DATA_V2_W*, int> SetupDiSetSelectedDriver = &SetupDiSetSelectedDriverW;

        [NativeTypeName("#define SetupDiGetDriverInfoDetail SetupDiGetDriverInfoDetailW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_DRVINFO_DATA_V2_W*, SP_DRVINFO_DETAIL_DATA_W*, uint, uint*, int> SetupDiGetDriverInfoDetail = &SetupDiGetDriverInfoDetailW;

        [NativeTypeName("#define DIGCF_DEFAULT 0x00000001")]
        public const int DIGCF_DEFAULT = 0x00000001;

        [NativeTypeName("#define DIGCF_PRESENT 0x00000002")]
        public const int DIGCF_PRESENT = 0x00000002;

        [NativeTypeName("#define DIGCF_ALLCLASSES 0x00000004")]
        public const int DIGCF_ALLCLASSES = 0x00000004;

        [NativeTypeName("#define DIGCF_PROFILE 0x00000008")]
        public const int DIGCF_PROFILE = 0x00000008;

        [NativeTypeName("#define DIGCF_DEVICEINTERFACE 0x00000010")]
        public const int DIGCF_DEVICEINTERFACE = 0x00000010;

        [NativeTypeName("#define DIGCF_INTERFACEDEVICE DIGCF_DEVICEINTERFACE")]
        public const int DIGCF_INTERFACEDEVICE = 0x00000010;

        [NativeTypeName("#define SetupDiGetClassDevs SetupDiGetClassDevsW")]
        public static readonly delegate*<Guid*, ushort*, IntPtr, uint, void*> SetupDiGetClassDevs = &SetupDiGetClassDevsW;

        [NativeTypeName("#define SetupDiGetClassDevsEx SetupDiGetClassDevsExW")]
        public static readonly delegate*<Guid*, ushort*, IntPtr, uint, void*, ushort*, void*, void*> SetupDiGetClassDevsEx = &SetupDiGetClassDevsExW;

        [NativeTypeName("#define SetupDiGetINFClass SetupDiGetINFClassW")]
        public static readonly delegate*<ushort*, Guid*, ushort*, uint, uint*, int> SetupDiGetINFClass = &SetupDiGetINFClassW;

        [NativeTypeName("#define DIBCI_NOINSTALLCLASS 0x00000001")]
        public const int DIBCI_NOINSTALLCLASS = 0x00000001;

        [NativeTypeName("#define DIBCI_NODISPLAYCLASS 0x00000002")]
        public const int DIBCI_NODISPLAYCLASS = 0x00000002;

        [NativeTypeName("#define SetupDiBuildClassInfoListEx SetupDiBuildClassInfoListExW")]
        public static readonly delegate*<uint, Guid*, uint, uint*, ushort*, void*, int> SetupDiBuildClassInfoListEx = &SetupDiBuildClassInfoListExW;

        [NativeTypeName("#define SetupDiGetClassDescription SetupDiGetClassDescriptionW")]
        public static readonly delegate*<Guid*, ushort*, uint, uint*, int> SetupDiGetClassDescription = &SetupDiGetClassDescriptionW;

        [NativeTypeName("#define SetupDiGetClassDescriptionEx SetupDiGetClassDescriptionExW")]
        public static readonly delegate*<Guid*, ushort*, uint, uint*, ushort*, void*, int> SetupDiGetClassDescriptionEx = &SetupDiGetClassDescriptionExW;

        [NativeTypeName("#define SetupDiInstallClass SetupDiInstallClassW")]
        public static readonly delegate*<IntPtr, ushort*, uint, void*, int> SetupDiInstallClass = &SetupDiInstallClassW;

        [NativeTypeName("#define SetupDiInstallClassEx SetupDiInstallClassExW")]
        public static readonly delegate*<IntPtr, ushort*, uint, void*, Guid*, void*, void*, int> SetupDiInstallClassEx = &SetupDiInstallClassExW;

        [NativeTypeName("#define DIOCR_INSTALLER 0x00000001")]
        public const int DIOCR_INSTALLER = 0x00000001;

        [NativeTypeName("#define DIOCR_INTERFACE 0x00000002")]
        public const int DIOCR_INTERFACE = 0x00000002;

        [NativeTypeName("#define SetupDiOpenClassRegKeyEx SetupDiOpenClassRegKeyExW")]
        public static readonly delegate*<Guid*, uint, uint, ushort*, void*, IntPtr> SetupDiOpenClassRegKeyEx = &SetupDiOpenClassRegKeyExW;

        [NativeTypeName("#define SetupDiCreateDeviceInterfaceRegKey SetupDiCreateDeviceInterfaceRegKeyW")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, uint, uint, void*, ushort*, IntPtr> SetupDiCreateDeviceInterfaceRegKey = &SetupDiCreateDeviceInterfaceRegKeyW;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKeyW SetupDiCreateDeviceInterfaceRegKeyW")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, uint, uint, void*, ushort*, IntPtr> SetupDiCreateInterfaceDeviceRegKeyW = &SetupDiCreateDeviceInterfaceRegKeyW;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKeyA SetupDiCreateDeviceInterfaceRegKeyA")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, uint, uint, void*, sbyte*, IntPtr> SetupDiCreateInterfaceDeviceRegKeyA = &SetupDiCreateDeviceInterfaceRegKeyA;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKey SetupDiCreateDeviceInterfaceRegKeyW")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, uint, uint, void*, ushort*, IntPtr> SetupDiCreateInterfaceDeviceRegKey = &SetupDiCreateDeviceInterfaceRegKeyW;

        [NativeTypeName("#define SetupDiOpenInterfaceDeviceRegKey SetupDiOpenDeviceInterfaceRegKey")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, uint, uint, IntPtr> SetupDiOpenInterfaceDeviceRegKey = &SetupDiOpenDeviceInterfaceRegKey;

        [NativeTypeName("#define SetupDiDeleteInterfaceDeviceRegKey SetupDiDeleteDeviceInterfaceRegKey")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, uint, int> SetupDiDeleteInterfaceDeviceRegKey = &SetupDiDeleteDeviceInterfaceRegKey;

        [NativeTypeName("#define DIREG_DEV 0x00000001")]
        public const int DIREG_DEV = 0x00000001;

        [NativeTypeName("#define DIREG_DRV 0x00000002")]
        public const int DIREG_DRV = 0x00000002;

        [NativeTypeName("#define DIREG_BOTH 0x00000004")]
        public const int DIREG_BOTH = 0x00000004;

        [NativeTypeName("#define SetupDiCreateDevRegKey SetupDiCreateDevRegKeyW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, uint, uint, uint, void*, ushort*, IntPtr> SetupDiCreateDevRegKey = &SetupDiCreateDevRegKeyW;

        [NativeTypeName("#define SetupDiGetHwProfileListEx SetupDiGetHwProfileListExW")]
        public static readonly delegate*<uint*, uint, uint*, uint*, ushort*, void*, int> SetupDiGetHwProfileListEx = &SetupDiGetHwProfileListExW;

        [NativeTypeName("#define SetupDiGetDeviceProperty SetupDiGetDevicePropertyW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, int> SetupDiGetDeviceProperty = &SetupDiGetDevicePropertyW;

        [NativeTypeName("#define SetupDiSetDeviceProperty SetupDiSetDevicePropertyW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, DEVPROPKEY*, uint, byte*, uint, uint, int> SetupDiSetDeviceProperty = &SetupDiSetDevicePropertyW;

        [NativeTypeName("#define SetupDiGetDeviceInterfaceProperty SetupDiGetDeviceInterfacePropertyW")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, int> SetupDiGetDeviceInterfaceProperty = &SetupDiGetDeviceInterfacePropertyW;

        [NativeTypeName("#define SetupDiSetDeviceInterfaceProperty SetupDiSetDeviceInterfacePropertyW")]
        public static readonly delegate*<void*, SP_DEVICE_INTERFACE_DATA*, DEVPROPKEY*, uint, byte*, uint, uint, int> SetupDiSetDeviceInterfaceProperty = &SetupDiSetDeviceInterfacePropertyW;

        [NativeTypeName("#define DICLASSPROP_INSTALLER 0x00000001")]
        public const int DICLASSPROP_INSTALLER = 0x00000001;

        [NativeTypeName("#define DICLASSPROP_INTERFACE 0x00000002")]
        public const int DICLASSPROP_INTERFACE = 0x00000002;

        [NativeTypeName("#define SetupDiGetClassPropertyKeysEx SetupDiGetClassPropertyKeysExW")]
        public static readonly delegate*<Guid*, DEVPROPKEY*, uint, uint*, uint, ushort*, void*, int> SetupDiGetClassPropertyKeysEx = &SetupDiGetClassPropertyKeysExW;

        [NativeTypeName("#define SetupDiGetClassProperty SetupDiGetClassPropertyW")]
        public static readonly delegate*<Guid*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, int> SetupDiGetClassProperty = &SetupDiGetClassPropertyW;

        [NativeTypeName("#define SetupDiGetClassPropertyEx SetupDiGetClassPropertyExW")]
        public static readonly delegate*<Guid*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, ushort*, void*, int> SetupDiGetClassPropertyEx = &SetupDiGetClassPropertyExW;

        [NativeTypeName("#define SetupDiSetClassProperty SetupDiSetClassPropertyW")]
        public static readonly delegate*<Guid*, DEVPROPKEY*, uint, byte*, uint, uint, int> SetupDiSetClassProperty = &SetupDiSetClassPropertyW;

        [NativeTypeName("#define SetupDiSetClassPropertyEx SetupDiSetClassPropertyExW")]
        public static readonly delegate*<Guid*, DEVPROPKEY*, uint, byte*, uint, uint, ushort*, void*, int> SetupDiSetClassPropertyEx = &SetupDiSetClassPropertyExW;

        [NativeTypeName("#define SPDRP_DEVICEDESC (0x00000000)")]
        public const int SPDRP_DEVICEDESC = (0x00000000);

        [NativeTypeName("#define SPDRP_HARDWAREID (0x00000001)")]
        public const int SPDRP_HARDWAREID = (0x00000001);

        [NativeTypeName("#define SPDRP_COMPATIBLEIDS (0x00000002)")]
        public const int SPDRP_COMPATIBLEIDS = (0x00000002);

        [NativeTypeName("#define SPDRP_UNUSED0 (0x00000003)")]
        public const int SPDRP_UNUSED0 = (0x00000003);

        [NativeTypeName("#define SPDRP_SERVICE (0x00000004)")]
        public const int SPDRP_SERVICE = (0x00000004);

        [NativeTypeName("#define SPDRP_UNUSED1 (0x00000005)")]
        public const int SPDRP_UNUSED1 = (0x00000005);

        [NativeTypeName("#define SPDRP_UNUSED2 (0x00000006)")]
        public const int SPDRP_UNUSED2 = (0x00000006);

        [NativeTypeName("#define SPDRP_CLASS (0x00000007)")]
        public const int SPDRP_CLASS = (0x00000007);

        [NativeTypeName("#define SPDRP_CLASSGUID (0x00000008)")]
        public const int SPDRP_CLASSGUID = (0x00000008);

        [NativeTypeName("#define SPDRP_DRIVER (0x00000009)")]
        public const int SPDRP_DRIVER = (0x00000009);

        [NativeTypeName("#define SPDRP_CONFIGFLAGS (0x0000000A)")]
        public const int SPDRP_CONFIGFLAGS = (0x0000000A);

        [NativeTypeName("#define SPDRP_MFG (0x0000000B)")]
        public const int SPDRP_MFG = (0x0000000B);

        [NativeTypeName("#define SPDRP_FRIENDLYNAME (0x0000000C)")]
        public const int SPDRP_FRIENDLYNAME = (0x0000000C);

        [NativeTypeName("#define SPDRP_LOCATION_INFORMATION (0x0000000D)")]
        public const int SPDRP_LOCATION_INFORMATION = (0x0000000D);

        [NativeTypeName("#define SPDRP_PHYSICAL_DEVICE_OBJECT_NAME (0x0000000E)")]
        public const int SPDRP_PHYSICAL_DEVICE_OBJECT_NAME = (0x0000000E);

        [NativeTypeName("#define SPDRP_CAPABILITIES (0x0000000F)")]
        public const int SPDRP_CAPABILITIES = (0x0000000F);

        [NativeTypeName("#define SPDRP_UI_NUMBER (0x00000010)")]
        public const int SPDRP_UI_NUMBER = (0x00000010);

        [NativeTypeName("#define SPDRP_UPPERFILTERS (0x00000011)")]
        public const int SPDRP_UPPERFILTERS = (0x00000011);

        [NativeTypeName("#define SPDRP_LOWERFILTERS (0x00000012)")]
        public const int SPDRP_LOWERFILTERS = (0x00000012);

        [NativeTypeName("#define SPDRP_BUSTYPEGUID (0x00000013)")]
        public const int SPDRP_BUSTYPEGUID = (0x00000013);

        [NativeTypeName("#define SPDRP_LEGACYBUSTYPE (0x00000014)")]
        public const int SPDRP_LEGACYBUSTYPE = (0x00000014);

        [NativeTypeName("#define SPDRP_BUSNUMBER (0x00000015)")]
        public const int SPDRP_BUSNUMBER = (0x00000015);

        [NativeTypeName("#define SPDRP_ENUMERATOR_NAME (0x00000016)")]
        public const int SPDRP_ENUMERATOR_NAME = (0x00000016);

        [NativeTypeName("#define SPDRP_SECURITY (0x00000017)")]
        public const int SPDRP_SECURITY = (0x00000017);

        [NativeTypeName("#define SPDRP_SECURITY_SDS (0x00000018)")]
        public const int SPDRP_SECURITY_SDS = (0x00000018);

        [NativeTypeName("#define SPDRP_DEVTYPE (0x00000019)")]
        public const int SPDRP_DEVTYPE = (0x00000019);

        [NativeTypeName("#define SPDRP_EXCLUSIVE (0x0000001A)")]
        public const int SPDRP_EXCLUSIVE = (0x0000001A);

        [NativeTypeName("#define SPDRP_CHARACTERISTICS (0x0000001B)")]
        public const int SPDRP_CHARACTERISTICS = (0x0000001B);

        [NativeTypeName("#define SPDRP_ADDRESS (0x0000001C)")]
        public const int SPDRP_ADDRESS = (0x0000001C);

        [NativeTypeName("#define SPDRP_UI_NUMBER_DESC_FORMAT (0X0000001D)")]
        public const int SPDRP_UI_NUMBER_DESC_FORMAT = (0X0000001D);

        [NativeTypeName("#define SPDRP_DEVICE_POWER_DATA (0x0000001E)")]
        public const int SPDRP_DEVICE_POWER_DATA = (0x0000001E);

        [NativeTypeName("#define SPDRP_REMOVAL_POLICY (0x0000001F)")]
        public const int SPDRP_REMOVAL_POLICY = (0x0000001F);

        [NativeTypeName("#define SPDRP_REMOVAL_POLICY_HW_DEFAULT (0x00000020)")]
        public const int SPDRP_REMOVAL_POLICY_HW_DEFAULT = (0x00000020);

        [NativeTypeName("#define SPDRP_REMOVAL_POLICY_OVERRIDE (0x00000021)")]
        public const int SPDRP_REMOVAL_POLICY_OVERRIDE = (0x00000021);

        [NativeTypeName("#define SPDRP_INSTALL_STATE (0x00000022)")]
        public const int SPDRP_INSTALL_STATE = (0x00000022);

        [NativeTypeName("#define SPDRP_LOCATION_PATHS (0x00000023)")]
        public const int SPDRP_LOCATION_PATHS = (0x00000023);

        [NativeTypeName("#define SPDRP_BASE_CONTAINERID (0x00000024)")]
        public const int SPDRP_BASE_CONTAINERID = (0x00000024);

        [NativeTypeName("#define SPDRP_MAXIMUM_PROPERTY (0x00000025)")]
        public const int SPDRP_MAXIMUM_PROPERTY = (0x00000025);

        [NativeTypeName("#define SPCRP_UPPERFILTERS (0x00000011)")]
        public const int SPCRP_UPPERFILTERS = (0x00000011);

        [NativeTypeName("#define SPCRP_LOWERFILTERS (0x00000012)")]
        public const int SPCRP_LOWERFILTERS = (0x00000012);

        [NativeTypeName("#define SPCRP_SECURITY (0x00000017)")]
        public const int SPCRP_SECURITY = (0x00000017);

        [NativeTypeName("#define SPCRP_SECURITY_SDS (0x00000018)")]
        public const int SPCRP_SECURITY_SDS = (0x00000018);

        [NativeTypeName("#define SPCRP_DEVTYPE (0x00000019)")]
        public const int SPCRP_DEVTYPE = (0x00000019);

        [NativeTypeName("#define SPCRP_EXCLUSIVE (0x0000001A)")]
        public const int SPCRP_EXCLUSIVE = (0x0000001A);

        [NativeTypeName("#define SPCRP_CHARACTERISTICS (0x0000001B)")]
        public const int SPCRP_CHARACTERISTICS = (0x0000001B);

        [NativeTypeName("#define SPCRP_MAXIMUM_PROPERTY (0x0000001C)")]
        public const int SPCRP_MAXIMUM_PROPERTY = (0x0000001C);

        [NativeTypeName("#define SetupDiGetDeviceRegistryProperty SetupDiGetDeviceRegistryPropertyW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, uint, uint*, byte*, uint, uint*, int> SetupDiGetDeviceRegistryProperty = &SetupDiGetDeviceRegistryPropertyW;

        [NativeTypeName("#define SetupDiGetClassRegistryProperty SetupDiGetClassRegistryPropertyW")]
        public static readonly delegate*<Guid*, uint, uint*, byte*, uint, uint*, ushort*, void*, int> SetupDiGetClassRegistryProperty = &SetupDiGetClassRegistryPropertyW;

        [NativeTypeName("#define SetupDiSetDeviceRegistryProperty SetupDiSetDeviceRegistryPropertyW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, uint, byte*, uint, int> SetupDiSetDeviceRegistryProperty = &SetupDiSetDeviceRegistryPropertyW;

        [NativeTypeName("#define SetupDiSetClassRegistryProperty SetupDiSetClassRegistryPropertyW")]
        public static readonly delegate*<Guid*, uint, byte*, uint, ushort*, void*, int> SetupDiSetClassRegistryProperty = &SetupDiSetClassRegistryPropertyW;

        [NativeTypeName("#define SetupDiGetDeviceInstallParams SetupDiGetDeviceInstallParamsW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_DEVINSTALL_PARAMS_W*, int> SetupDiGetDeviceInstallParams = &SetupDiGetDeviceInstallParamsW;

        [NativeTypeName("#define SetupDiGetClassInstallParams SetupDiGetClassInstallParamsW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_CLASSINSTALL_HEADER*, uint, uint*, int> SetupDiGetClassInstallParams = &SetupDiGetClassInstallParamsW;

        [NativeTypeName("#define SetupDiSetDeviceInstallParams SetupDiSetDeviceInstallParamsW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_DEVINSTALL_PARAMS_W*, int> SetupDiSetDeviceInstallParams = &SetupDiSetDeviceInstallParamsW;

        [NativeTypeName("#define SetupDiSetClassInstallParams SetupDiSetClassInstallParamsW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_CLASSINSTALL_HEADER*, uint, int> SetupDiSetClassInstallParams = &SetupDiSetClassInstallParamsW;

        [NativeTypeName("#define SetupDiGetDriverInstallParams SetupDiGetDriverInstallParamsW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_DRVINFO_DATA_V2_W*, SP_DRVINSTALL_PARAMS*, int> SetupDiGetDriverInstallParams = &SetupDiGetDriverInstallParamsW;

        [NativeTypeName("#define SetupDiSetDriverInstallParams SetupDiSetDriverInstallParamsW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, SP_DRVINFO_DATA_V2_W*, SP_DRVINSTALL_PARAMS*, int> SetupDiSetDriverInstallParams = &SetupDiSetDriverInstallParamsW;

        [NativeTypeName("#define DMI_MASK 0x00000001")]
        public const int DMI_MASK = 0x00000001;

        [NativeTypeName("#define DMI_BKCOLOR 0x00000002")]
        public const int DMI_BKCOLOR = 0x00000002;

        [NativeTypeName("#define DMI_USERECT 0x00000004")]
        public const int DMI_USERECT = 0x00000004;

        [NativeTypeName("#define SetupDiGetClassImageListEx SetupDiGetClassImageListExW")]
        public static readonly delegate*<SP_CLASSIMAGELIST_DATA*, ushort*, void*, int> SetupDiGetClassImageListEx = &SetupDiGetClassImageListExW;

        [NativeTypeName("#define DIGCDP_FLAG_BASIC 0x00000001")]
        public const int DIGCDP_FLAG_BASIC = 0x00000001;

        [NativeTypeName("#define DIGCDP_FLAG_ADVANCED 0x00000002")]
        public const int DIGCDP_FLAG_ADVANCED = 0x00000002;

        [NativeTypeName("#define DIGCDP_FLAG_REMOTE_BASIC 0x00000003")]
        public const int DIGCDP_FLAG_REMOTE_BASIC = 0x00000003;

        [NativeTypeName("#define DIGCDP_FLAG_REMOTE_ADVANCED 0x00000004")]
        public const int DIGCDP_FLAG_REMOTE_ADVANCED = 0x00000004;

        [NativeTypeName("#define SetupDiGetClassDevPropertySheets SetupDiGetClassDevPropertySheetsW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, PROPSHEETHEADERW_V2*, uint, uint*, uint, int> SetupDiGetClassDevPropertySheets = &SetupDiGetClassDevPropertySheetsW;

        [NativeTypeName("#define IDI_RESOURCEFIRST 159")]
        public const int IDI_RESOURCEFIRST = 159;

        [NativeTypeName("#define IDI_RESOURCE 159")]
        public const int IDI_RESOURCE = 159;

        [NativeTypeName("#define IDI_RESOURCELAST 161")]
        public const int IDI_RESOURCELAST = 161;

        [NativeTypeName("#define IDI_RESOURCEOVERLAYFIRST 161")]
        public const int IDI_RESOURCEOVERLAYFIRST = 161;

        [NativeTypeName("#define IDI_RESOURCEOVERLAYLAST 161")]
        public const int IDI_RESOURCEOVERLAYLAST = 161;

        [NativeTypeName("#define IDI_CONFLICT 161")]
        public const int IDI_CONFLICT = 161;

        [NativeTypeName("#define IDI_CLASSICON_OVERLAYFIRST 500")]
        public const int IDI_CLASSICON_OVERLAYFIRST = 500;

        [NativeTypeName("#define IDI_CLASSICON_OVERLAYLAST 502")]
        public const int IDI_CLASSICON_OVERLAYLAST = 502;

        [NativeTypeName("#define IDI_PROBLEM_OVL 500")]
        public const int IDI_PROBLEM_OVL = 500;

        [NativeTypeName("#define IDI_DISABLED_OVL 501")]
        public const int IDI_DISABLED_OVL = 501;

        [NativeTypeName("#define IDI_FORCED_OVL 502")]
        public const int IDI_FORCED_OVL = 502;

        [NativeTypeName("#define SetupDiClassNameFromGuid SetupDiClassNameFromGuidW")]
        public static readonly delegate*<Guid*, ushort*, uint, uint*, int> SetupDiClassNameFromGuid = &SetupDiClassNameFromGuidW;

        [NativeTypeName("#define SetupDiClassNameFromGuidEx SetupDiClassNameFromGuidExW")]
        public static readonly delegate*<Guid*, ushort*, uint, uint*, ushort*, void*, int> SetupDiClassNameFromGuidEx = &SetupDiClassNameFromGuidExW;

        [NativeTypeName("#define SetupDiClassGuidsFromName SetupDiClassGuidsFromNameW")]
        public static readonly delegate*<ushort*, Guid*, uint, uint*, int> SetupDiClassGuidsFromName = &SetupDiClassGuidsFromNameW;

        [NativeTypeName("#define SetupDiClassGuidsFromNameEx SetupDiClassGuidsFromNameExW")]
        public static readonly delegate*<ushort*, Guid*, uint, uint*, ushort*, void*, int> SetupDiClassGuidsFromNameEx = &SetupDiClassGuidsFromNameExW;

        [NativeTypeName("#define SetupDiGetHwProfileFriendlyName SetupDiGetHwProfileFriendlyNameW")]
        public static readonly delegate*<uint, ushort*, uint, uint*, int> SetupDiGetHwProfileFriendlyName = &SetupDiGetHwProfileFriendlyNameW;

        [NativeTypeName("#define SetupDiGetHwProfileFriendlyNameEx SetupDiGetHwProfileFriendlyNameExW")]
        public static readonly delegate*<uint, ushort*, uint, uint*, ushort*, void*, int> SetupDiGetHwProfileFriendlyNameEx = &SetupDiGetHwProfileFriendlyNameExW;

        [NativeTypeName("#define SPWPT_SELECTDEVICE 0x00000001")]
        public const int SPWPT_SELECTDEVICE = 0x00000001;

        [NativeTypeName("#define SPWP_USE_DEVINFO_DATA 0x00000001")]
        public const int SPWP_USE_DEVINFO_DATA = 0x00000001;

        [NativeTypeName("#define SetupDiGetActualModelsSection SetupDiGetActualModelsSectionW")]
        public static readonly delegate*<INFCONTEXT*, SP_ALTPLATFORM_INFO_V2*, ushort*, uint, uint*, void*, int> SetupDiGetActualModelsSection = &SetupDiGetActualModelsSectionW;

        [NativeTypeName("#define SetupDiGetActualSectionToInstall SetupDiGetActualSectionToInstallW")]
        public static readonly delegate*<void*, ushort*, ushort*, uint, uint*, ushort**, int> SetupDiGetActualSectionToInstall = &SetupDiGetActualSectionToInstallW;

        [NativeTypeName("#define SetupDiGetActualSectionToInstallEx SetupDiGetActualSectionToInstallExW")]
        public static readonly delegate*<void*, ushort*, SP_ALTPLATFORM_INFO_V2*, ushort*, uint, uint*, ushort**, void*, int> SetupDiGetActualSectionToInstallEx = &SetupDiGetActualSectionToInstallExW;

        [NativeTypeName("#define SetupEnumInfSections SetupEnumInfSectionsW")]
        public static readonly delegate*<void*, uint, ushort*, uint, uint*, int> SetupEnumInfSections = &SetupEnumInfSectionsW;

        [NativeTypeName("#define SIGNERSCORE_UNKNOWN 0xFF000000")]
        public const uint SIGNERSCORE_UNKNOWN = 0xFF000000;

        [NativeTypeName("#define SIGNERSCORE_W9X_SUSPECT 0xC0000000")]
        public const uint SIGNERSCORE_W9X_SUSPECT = 0xC0000000;

        [NativeTypeName("#define SIGNERSCORE_UNSIGNED 0x80000000")]
        public const uint SIGNERSCORE_UNSIGNED = 0x80000000;

        [NativeTypeName("#define SIGNERSCORE_AUTHENTICODE 0x0F000000")]
        public const int SIGNERSCORE_AUTHENTICODE = 0x0F000000;

        [NativeTypeName("#define SIGNERSCORE_WHQL 0x0D000005")]
        public const int SIGNERSCORE_WHQL = 0x0D000005;

        [NativeTypeName("#define SIGNERSCORE_UNCLASSIFIED 0x0D000004")]
        public const int SIGNERSCORE_UNCLASSIFIED = 0x0D000004;

        [NativeTypeName("#define SIGNERSCORE_INBOX 0x0D000003")]
        public const int SIGNERSCORE_INBOX = 0x0D000003;

        [NativeTypeName("#define SIGNERSCORE_LOGO_STANDARD 0x0D000002")]
        public const int SIGNERSCORE_LOGO_STANDARD = 0x0D000002;

        [NativeTypeName("#define SIGNERSCORE_LOGO_PREMIUM 0x0D000001")]
        public const int SIGNERSCORE_LOGO_PREMIUM = 0x0D000001;

        [NativeTypeName("#define SIGNERSCORE_MASK 0xFF000000")]
        public const uint SIGNERSCORE_MASK = 0xFF000000;

        [NativeTypeName("#define SIGNERSCORE_SIGNED_MASK 0xF0000000")]
        public const uint SIGNERSCORE_SIGNED_MASK = 0xF0000000;

        [NativeTypeName("#define SetupVerifyInfFile SetupVerifyInfFileW")]
        public static readonly delegate*<ushort*, SP_ALTPLATFORM_INFO_V2*, SP_INF_SIGNER_INFO_V2_W*, int> SetupVerifyInfFile = &SetupVerifyInfFileW;

        [NativeTypeName("#define DICUSTOMDEVPROP_MERGE_MULTISZ 0x00000001")]
        public const int DICUSTOMDEVPROP_MERGE_MULTISZ = 0x00000001;

        [NativeTypeName("#define SetupDiGetCustomDeviceProperty SetupDiGetCustomDevicePropertyW")]
        public static readonly delegate*<void*, SP_DEVINFO_DATA*, ushort*, uint, uint*, byte*, uint, uint*, int> SetupDiGetCustomDeviceProperty = &SetupDiGetCustomDevicePropertyW;

        [NativeTypeName("#define SCWMI_CLOBBER_SECURITY 0x00000001")]
        public const int SCWMI_CLOBBER_SECURITY = 0x00000001;

        [NativeTypeName("#define SetupConfigureWmiFromInfSection SetupConfigureWmiFromInfSectionW")]
        public static readonly delegate*<void*, ushort*, uint, int> SetupConfigureWmiFromInfSection = &SetupConfigureWmiFromInfSectionW;
    }
}
