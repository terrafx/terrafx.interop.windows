// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetInfInformationA([NativeTypeName("LPCVOID")] void* InfSpec, [NativeTypeName("DWORD")] uint SearchControl, [NativeTypeName("PSP_INF_INFORMATION")] void* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetInfInformationW([NativeTypeName("LPCVOID")] void* InfSpec, [NativeTypeName("DWORD")] uint SearchControl, [NativeTypeName("PSP_INF_INFORMATION")] void* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryInfFileInformationA([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryInfFileInformationW([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryInfOriginalFileInformationA([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PSP_ORIGINAL_FILE_INFO_A")] void* OriginalFileInfo);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryInfOriginalFileInformationW([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PSP_ORIGINAL_FILE_INFO_W")] void* OriginalFileInfo);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryInfVersionInformationA([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryInfVersionInformationW([NativeTypeName("PSP_INF_INFORMATION")] void* InfInformation, uint InfIndex, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupGetInfDriverStoreLocationA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PCSTR")] sbyte* LocaleName, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupGetInfDriverStoreLocationW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PCWSTR")] ushort* LocaleName, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupGetInfPublishedNameA([NativeTypeName("PCSTR")] sbyte* DriverStoreLocation, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupGetInfPublishedNameW([NativeTypeName("PCWSTR")] ushort* DriverStoreLocation, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetInfFileListA([NativeTypeName("PCSTR")] sbyte* DirectoryPath, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetInfFileListW([NativeTypeName("PCWSTR")] ushort* DirectoryPath, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HINF SetupOpenInfFileW([NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* InfClass, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HINF SetupOpenInfFileA([NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* InfClass, [NativeTypeName("DWORD")] uint InfStyle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HINF SetupOpenMasterInf();

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupOpenAppendInfFileW([NativeTypeName("PCWSTR")] ushort* FileName, HINF InfHandle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupOpenAppendInfFileA([NativeTypeName("PCSTR")] sbyte* FileName, HINF InfHandle, [NativeTypeName("PUINT")] uint* ErrorLine);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void SetupCloseInfFile(HINF InfHandle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupFindFirstLineA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PINFCONTEXT")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupFindFirstLineW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PINFCONTEXT")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupFindNextLine([NativeTypeName("PINFCONTEXT")] void* ContextIn, [NativeTypeName("PINFCONTEXT")] void* ContextOut);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupFindNextMatchLineA([NativeTypeName("PINFCONTEXT")] void* ContextIn, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PINFCONTEXT")] void* ContextOut);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupFindNextMatchLineW([NativeTypeName("PINFCONTEXT")] void* ContextIn, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PINFCONTEXT")] void* ContextOut);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetLineByIndexA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PINFCONTEXT")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetLineByIndexW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("DWORD")] uint Index, [NativeTypeName("PINFCONTEXT")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetupGetLineCountA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SetupGetLineCountW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetLineTextA([NativeTypeName("PINFCONTEXT")] void* Context, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PCSTR")] sbyte* Key, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetLineTextW([NativeTypeName("PINFCONTEXT")] void* Context, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PCWSTR")] ushort* Key, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFieldCount([NativeTypeName("PINFCONTEXT")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetStringFieldA([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetStringFieldW([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetIntField([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PINT")] int* IntegerValue);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetMultiSzFieldA([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetMultiSzFieldW([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetBinaryField([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("DWORD")] uint FieldIndex, [NativeTypeName("PBYTE")] byte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("LPDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFileCompressionInfoA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PSTR *")] sbyte** ActualSourceFileName, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupGetFileCompressionInfoW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PWSTR *")] ushort** ActualSourceFileName, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetFileCompressionInfoExA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PSTR")] sbyte* ActualSourceFileNameBuffer, [NativeTypeName("DWORD")] uint ActualSourceFileNameBufferLen, [NativeTypeName("PDWORD")] uint* RequiredBufferLen, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetFileCompressionInfoExW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PWSTR")] ushort* ActualSourceFileNameBuffer, [NativeTypeName("DWORD")] uint ActualSourceFileNameBufferLen, [NativeTypeName("PDWORD")] uint* RequiredBufferLen, [NativeTypeName("PDWORD")] uint* SourceFileSize, [NativeTypeName("PDWORD")] uint* TargetFileSize, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupDecompressOrCopyFileA([NativeTypeName("PCSTR")] sbyte* SourceFileName, [NativeTypeName("PCSTR")] sbyte* TargetFileName, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetupDecompressOrCopyFileW([NativeTypeName("PCWSTR")] ushort* SourceFileName, [NativeTypeName("PCWSTR")] ushort* TargetFileName, [NativeTypeName("PUINT")] uint* CompressionType);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetSourceFileLocationA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PUINT")] uint* SourceId, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetSourceFileLocationW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PUINT")] uint* SourceId, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetSourceFileSizeA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* FileName, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PDWORD")] uint* FileSize, uint RoundingFactor);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetSourceFileSizeW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* FileName, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PDWORD")] uint* FileSize, uint RoundingFactor);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetTargetPathA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetTargetPathW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR *")] sbyte** SourceList, uint SourceCount);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR *")] ushort** SourceList, uint SourceCount);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupCancelTemporarySourceList();

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAddToSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* Source);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAddToSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* Source);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveFromSourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* Source);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveFromSourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* Source);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQuerySourceListA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR **")] sbyte*** List, [NativeTypeName("PUINT")] uint* Count);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQuerySourceListW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR **")] ushort*** List, [NativeTypeName("PUINT")] uint* Count);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupFreeSourceListA([NativeTypeName("PCSTR **")] sbyte*** List, uint Count);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupFreeSourceListW([NativeTypeName("PCWSTR **")] ushort*** List, uint Count);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupPromptForDiskA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* DiskName, [NativeTypeName("PCSTR")] sbyte* PathToSource, [NativeTypeName("PCSTR")] sbyte* FileSought, [NativeTypeName("PCSTR")] sbyte* TagFile, [NativeTypeName("DWORD")] uint DiskPromptStyle, [NativeTypeName("PSTR")] sbyte* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupPromptForDiskW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* DiskName, [NativeTypeName("PCWSTR")] ushort* PathToSource, [NativeTypeName("PCWSTR")] ushort* FileSought, [NativeTypeName("PCWSTR")] ushort* TagFile, [NativeTypeName("DWORD")] uint DiskPromptStyle, [NativeTypeName("PWSTR")] ushort* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupCopyErrorA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* DiskName, [NativeTypeName("PCSTR")] sbyte* PathToSource, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetPathFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style, [NativeTypeName("PSTR")] sbyte* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupCopyErrorW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* DiskName, [NativeTypeName("PCWSTR")] ushort* PathToSource, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetPathFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style, [NativeTypeName("PWSTR")] ushort* PathBuffer, [NativeTypeName("DWORD")] uint PathBufferSize, [NativeTypeName("PDWORD")] uint* PathRequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupRenameErrorA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupRenameErrorW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupDeleteErrorA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* File, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupDeleteErrorW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* File, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupBackupErrorA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* DialogTitle, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* TargetFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupBackupErrorW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* DialogTitle, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* TargetFile, uint Win32ErrorCode, [NativeTypeName("DWORD")] uint Style);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetDirectoryIdA(HINF InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCSTR")] sbyte* Directory);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetDirectoryIdW(HINF InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCWSTR")] ushort* Directory);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetDirectoryIdExA(HINF InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCSTR")] sbyte* Directory, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetDirectoryIdExW(HINF InfHandle, [NativeTypeName("DWORD")] uint Id, [NativeTypeName("PCWSTR")] ushort* Directory, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetSourceInfoA(HINF InfHandle, uint SourceId, uint InfoDesired, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetSourceInfoW(HINF InfHandle, uint SourceId, uint InfoDesired, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallFileA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* SourcePathRoot, [NativeTypeName("PCSTR")] sbyte* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallFileW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* SourcePathRoot, [NativeTypeName("PCWSTR")] ushort* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallFileExA(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCSTR")] sbyte* SourceFile, [NativeTypeName("PCSTR")] sbyte* SourcePathRoot, [NativeTypeName("PCSTR")] sbyte* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PBOOL")] BOOL* FileWasInUse);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallFileExW(HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* InfContext, [NativeTypeName("PCWSTR")] ushort* SourceFile, [NativeTypeName("PCWSTR")] ushort* SourcePathRoot, [NativeTypeName("PCWSTR")] ushort* DestinationName, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CopyMsgHandler, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PBOOL")] BOOL* FileWasInUse);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HSPFILEQ SetupOpenFileQueue();

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupCloseFileQueue(HSPFILEQ QueueHandle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetFileQueueAlternatePlatformA(HSPFILEQ QueueHandle, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PCSTR")] sbyte* AlternateDefaultCatalogFile);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetFileQueueAlternatePlatformW(HSPFILEQ QueueHandle, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PCWSTR")] ushort* AlternateDefaultCatalogFile);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetPlatformPathOverrideA([NativeTypeName("PCSTR")] sbyte* Override);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetPlatformPathOverrideW([NativeTypeName("PCWSTR")] ushort* Override);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueCopyA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("PCSTR")] sbyte* SourcePath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* SourceDescription, [NativeTypeName("PCSTR")] sbyte* SourceTagfile, [NativeTypeName("PCSTR")] sbyte* TargetDirectory, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueCopyW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("PCWSTR")] ushort* SourcePath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* SourceDescription, [NativeTypeName("PCWSTR")] ushort* SourceTagfile, [NativeTypeName("PCWSTR")] ushort* TargetDirectory, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueCopyIndirectA([NativeTypeName("PSP_FILE_COPY_PARAMS_A")] void* CopyParams);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueCopyIndirectW([NativeTypeName("PSP_FILE_COPY_PARAMS_W")] void* CopyParams);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueDefaultCopyA(HSPFILEQ QueueHandle, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueDefaultCopyW(HSPFILEQ QueueHandle, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueCopySectionA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueCopySectionW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section, [NativeTypeName("DWORD")] uint CopyStyle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueDeleteA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* PathPart1, [NativeTypeName("PCSTR")] sbyte* PathPart2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueDeleteW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* PathPart1, [NativeTypeName("PCWSTR")] ushort* PathPart2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueDeleteSectionA(HSPFILEQ QueueHandle, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueDeleteSectionW(HSPFILEQ QueueHandle, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueRenameA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* SourcePath, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetPath, [NativeTypeName("PCSTR")] sbyte* TargetFilename);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueRenameW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* SourcePath, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetPath, [NativeTypeName("PCWSTR")] ushort* TargetFilename);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueRenameSectionA(HSPFILEQ QueueHandle, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* Section);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueueRenameSectionW(HSPFILEQ QueueHandle, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* Section);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupCommitFileQueueA(HWND Owner, HSPFILEQ QueueHandle, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupCommitFileQueueW(HWND Owner, HSPFILEQ QueueHandle, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupScanFileQueueA(HSPFILEQ FileQueue, [NativeTypeName("DWORD")] uint Flags, HWND Window, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CallbackRoutine, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PDWORD")] uint* Result);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupScanFileQueueW(HSPFILEQ FileQueue, [NativeTypeName("DWORD")] uint Flags, HWND Window, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> CallbackRoutine, [NativeTypeName("PVOID")] void* CallbackContext, [NativeTypeName("PDWORD")] uint* Result);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetFileQueueCount(HSPFILEQ FileQueue, uint SubQueueFileOp, [NativeTypeName("PUINT")] uint* NumOperations);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupGetFileQueueFlags(HSPFILEQ FileQueue, [NativeTypeName("PDWORD")] uint* Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupSetFileQueueFlags(HSPFILEQ FileQueue, [NativeTypeName("DWORD")] uint FlagMask, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupCopyOEMInfA([NativeTypeName("PCSTR")] sbyte* SourceInfFileName, [NativeTypeName("PCSTR")] sbyte* OEMSourceMediaLocation, [NativeTypeName("DWORD")] uint OEMSourceMediaType, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PSTR")] sbyte* DestinationInfFileName, [NativeTypeName("DWORD")] uint DestinationInfFileNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** DestinationInfFileNameComponent);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupCopyOEMInfW([NativeTypeName("PCWSTR")] ushort* SourceInfFileName, [NativeTypeName("PCWSTR")] ushort* OEMSourceMediaLocation, [NativeTypeName("DWORD")] uint OEMSourceMediaType, [NativeTypeName("DWORD")] uint CopyStyle, [NativeTypeName("PWSTR")] ushort* DestinationInfFileName, [NativeTypeName("DWORD")] uint DestinationInfFileNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** DestinationInfFileNameComponent);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupUninstallOEMInfA([NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupUninstallOEMInfW([NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupUninstallNewlyCopiedInfs(HSPFILEQ FileQueue, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HDSKSPC SetupCreateDiskSpaceListA([NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HDSKSPC SetupCreateDiskSpaceListW([NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HDSKSPC SetupDuplicateDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HDSKSPC SetupDuplicateDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("DWORD")] uint Reserved2, uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupDestroyDiskSpaceList(HDSKSPC DiskSpace);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryDrivesInDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("PSTR")] sbyte* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryDrivesInDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("PWSTR")] ushort* ReturnBuffer, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQuerySpaceRequiredOnDriveA(HDSKSPC DiskSpace, [NativeTypeName("PCSTR")] sbyte* DriveSpec, [NativeTypeName("LONGLONG *")] long* SpaceRequired, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQuerySpaceRequiredOnDriveW(HDSKSPC DiskSpace, [NativeTypeName("PCWSTR")] ushort* DriveSpec, [NativeTypeName("LONGLONG *")] long* SpaceRequired, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAdjustDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("LPCSTR")] sbyte* DriveRoot, [NativeTypeName("LONGLONG")] long Amount, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAdjustDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("LPCWSTR")] ushort* DriveRoot, [NativeTypeName("LONGLONG")] long Amount, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAddToDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("PCSTR")] sbyte* TargetFilespec, [NativeTypeName("LONGLONG")] long FileSize, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAddToDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("PCWSTR")] ushort* TargetFilespec, [NativeTypeName("LONGLONG")] long FileSize, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAddSectionToDiskSpaceListA(HDSKSPC DiskSpace, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAddSectionToDiskSpaceListW(HDSKSPC DiskSpace, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAddInstallSectionToDiskSpaceListA(HDSKSPC DiskSpace, HINF InfHandle, HINF LayoutInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupAddInstallSectionToDiskSpaceListW(HDSKSPC DiskSpace, HINF InfHandle, HINF LayoutInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveFromDiskSpaceListA(HDSKSPC DiskSpace, [NativeTypeName("PCSTR")] sbyte* TargetFilespec, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveFromDiskSpaceListW(HDSKSPC DiskSpace, [NativeTypeName("PCWSTR")] ushort* TargetFilespec, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveSectionFromDiskSpaceListA(HDSKSPC DiskSpace, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveSectionFromDiskSpaceListW(HDSKSPC DiskSpace, HINF InfHandle, HINF ListInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, uint Operation, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveInstallSectionFromDiskSpaceListA(HDSKSPC DiskSpace, HINF InfHandle, HINF LayoutInfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveInstallSectionFromDiskSpaceListW(HDSKSPC DiskSpace, HINF InfHandle, HINF LayoutInfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PVOID")] void* Reserved1, uint Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupIterateCabinetA([NativeTypeName("PCSTR")] sbyte* CabinetFile, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupIterateCabinetW([NativeTypeName("PCWSTR")] ushort* CabinetFile, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern int SetupPromptReboot(HSPFILEQ FileQueue, HWND Owner, BOOL ScanOnly);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* SetupInitDefaultQueueCallback(HWND OwnerWindow);

        [DllImport("setupapi", ExactSpelling = true)]
        [return: NativeTypeName("PVOID")]
        public static extern void* SetupInitDefaultQueueCallbackEx(HWND OwnerWindow, HWND AlternateProgressWindow, uint ProgressMessage, [NativeTypeName("DWORD")] uint Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern void SetupTermDefaultQueueCallback([NativeTypeName("PVOID")] void* Context);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupDefaultQueueCallbackA([NativeTypeName("PVOID")] void* Context, uint Notification, [NativeTypeName("UINT_PTR")] nuint Param1, [NativeTypeName("UINT_PTR")] nuint Param2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern uint SetupDefaultQueueCallbackW([NativeTypeName("PVOID")] void* Context, uint Notification, [NativeTypeName("UINT_PTR")] nuint Param1, [NativeTypeName("UINT_PTR")] nuint Param2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallFromInfSectionA(HWND Owner, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, uint Flags, HKEY RelativeKeyRoot, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, uint CopyFlags, [NativeTypeName("PSP_FILE_CALLBACK_A")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallFromInfSectionW(HWND Owner, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, uint Flags, HKEY RelativeKeyRoot, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, uint CopyFlags, [NativeTypeName("PSP_FILE_CALLBACK_W")] delegate* unmanaged<void*, uint, nuint, nuint, uint> MsgHandler, [NativeTypeName("PVOID")] void* Context, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallFilesFromInfSectionA(HINF InfHandle, HINF LayoutInfHandle, HSPFILEQ FileQueue, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("PCSTR")] sbyte* SourceRootPath, uint CopyFlags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallFilesFromInfSectionW(HINF InfHandle, HINF LayoutInfHandle, HSPFILEQ FileQueue, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("PCWSTR")] ushort* SourceRootPath, uint CopyFlags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallServicesFromInfSectionA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallServicesFromInfSectionW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallServicesFromInfSectionExA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupInstallServicesFromInfSectionExW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void InstallHinfSectionA(HWND Window, HINSTANCE ModuleHandle, [NativeTypeName("PCSTR")] sbyte* CommandLine, int ShowCommand);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern void InstallHinfSectionW(HWND Window, HINSTANCE ModuleHandle, [NativeTypeName("PCWSTR")] ushort* CommandLine, int ShowCommand);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HSPFILELOG SetupInitializeFileLogA([NativeTypeName("PCSTR")] sbyte* LogFileName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HSPFILELOG SetupInitializeFileLogW([NativeTypeName("PCWSTR")] ushort* LogFileName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupTerminateFileLog(HSPFILELOG FileLogHandle);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupLogFileA(HSPFILELOG FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* SourceFilename, [NativeTypeName("PCSTR")] sbyte* TargetFilename, [NativeTypeName("DWORD")] uint Checksum, [NativeTypeName("PCSTR")] sbyte* DiskTagfile, [NativeTypeName("PCSTR")] sbyte* DiskDescription, [NativeTypeName("PCSTR")] sbyte* OtherInfo, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupLogFileW(HSPFILELOG FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* SourceFilename, [NativeTypeName("PCWSTR")] ushort* TargetFilename, [NativeTypeName("DWORD")] uint Checksum, [NativeTypeName("PCWSTR")] ushort* DiskTagfile, [NativeTypeName("PCWSTR")] ushort* DiskDescription, [NativeTypeName("PCWSTR")] ushort* OtherInfo, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveFileLogEntryA(HSPFILELOG FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* TargetFilename);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupRemoveFileLogEntryW(HSPFILELOG FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* TargetFilename);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryFileLogA(HSPFILELOG FileLogHandle, [NativeTypeName("PCSTR")] sbyte* LogSectionName, [NativeTypeName("PCSTR")] sbyte* TargetFilename, SetupFileLogInfo DesiredInfo, [NativeTypeName("PSTR")] sbyte* DataOut, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupQueryFileLogW(HSPFILELOG FileLogHandle, [NativeTypeName("PCWSTR")] ushort* LogSectionName, [NativeTypeName("PCWSTR")] ushort* TargetFilename, SetupFileLogInfo DesiredInfo, [NativeTypeName("PWSTR")] ushort* DataOut, [NativeTypeName("DWORD")] uint ReturnBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupOpenLog(BOOL Erase);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupLogErrorA([NativeTypeName("LPCSTR")] sbyte* MessageString, [NativeTypeName("DWORD")] uint Severity);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupLogErrorW([NativeTypeName("LPCWSTR")] ushort* MessageString, [NativeTypeName("DWORD")] uint Severity);

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
        public static extern void SetupWriteTextLogInfLine([NativeTypeName("SP_LOG_TOKEN")] ulong LogToken, [NativeTypeName("DWORD")] uint Flags, HINF InfHandle, [NativeTypeName("PINFCONTEXT")] void* Context);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupGetBackupInformationA(HSPFILEQ QueueHandle, [NativeTypeName("PSP_BACKUP_QUEUE_PARAMS_A")] void* BackupParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupGetBackupInformationW(HSPFILEQ QueueHandle, [NativeTypeName("PSP_BACKUP_QUEUE_PARAMS_W")] void* BackupParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupPrepareQueueForRestoreA(HSPFILEQ QueueHandle, [NativeTypeName("PCSTR")] sbyte* BackupPath, [NativeTypeName("DWORD")] uint RestoreFlags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupPrepareQueueForRestoreW(HSPFILEQ QueueHandle, [NativeTypeName("PCWSTR")] ushort* BackupPath, [NativeTypeName("DWORD")] uint RestoreFlags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupSetNonInteractiveMode(BOOL NonInteractiveFlag);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupGetNonInteractiveMode();

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern HDEVINFO SetupDiCreateDeviceInfoList([NativeTypeName("const GUID *")] Guid* ClassGuid, HWND hwndParent);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HDEVINFO SetupDiCreateDeviceInfoListExA([NativeTypeName("const GUID *")] Guid* ClassGuid, HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HDEVINFO SetupDiCreateDeviceInfoListExW([NativeTypeName("const GUID *")] Guid* ClassGuid, HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInfoListClass(HDEVINFO DeviceInfoSet, [NativeTypeName("LPGUID")] Guid* ClassGuid);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInfoListDetailA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_LIST_DETAIL_DATA_A")] void* DeviceInfoSetDetailData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInfoListDetailW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_LIST_DETAIL_DATA_W")] void* DeviceInfoSetDetailData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiCreateDeviceInfoA(HDEVINFO DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DeviceName, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* DeviceDescription, HWND hwndParent, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiCreateDeviceInfoW(HDEVINFO DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DeviceName, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* DeviceDescription, HWND hwndParent, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiOpenDeviceInfoA(HDEVINFO DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DeviceInstanceId, HWND hwndParent, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiOpenDeviceInfoW(HDEVINFO DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DeviceInstanceId, HWND hwndParent, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInstanceIdA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSTR")] sbyte* DeviceInstanceId, [NativeTypeName("DWORD")] uint DeviceInstanceIdSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInstanceIdW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PWSTR")] ushort* DeviceInstanceId, [NativeTypeName("DWORD")] uint DeviceInstanceIdSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiDeleteDeviceInfo(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiEnumDeviceInfo(HDEVINFO DeviceInfoSet, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiDestroyDeviceInfoList(HDEVINFO DeviceInfoSet);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiEnumDeviceInterfaces(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiCreateDeviceInterfaceA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PCSTR")] sbyte* ReferenceString, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiCreateDeviceInterfaceW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PCWSTR")] ushort* ReferenceString, [NativeTypeName("DWORD")] uint CreationFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiOpenDeviceInterfaceA(HDEVINFO DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* DevicePath, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiOpenDeviceInterfaceW(HDEVINFO DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* DevicePath, [NativeTypeName("DWORD")] uint OpenFlags, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInterfaceAlias(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("const GUID *")] Guid* AliasInterfaceClassGuid, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* AliasDeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiDeleteDeviceInterfaceData(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiRemoveDeviceInterface(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInterfaceDetailA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("PSP_DEVICE_INTERFACE_DETAIL_DATA_A")] void* DeviceInterfaceDetailData, [NativeTypeName("DWORD")] uint DeviceInterfaceDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInterfaceDetailW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("PSP_DEVICE_INTERFACE_DETAIL_DATA_W")] void* DeviceInterfaceDetailData, [NativeTypeName("DWORD")] uint DeviceInterfaceDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiInstallDeviceInterfaces(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDeviceInterfaceDefault(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiRegisterDeviceInfo(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PSP_DETSIG_CMPPROC")] delegate* unmanaged<HDEVINFO, void*, void*, void*, uint> CompareProc, [NativeTypeName("PVOID")] void* CompareContext, [NativeTypeName("PSP_DEVINFO_DATA")] void* DupDeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupDiBuildDriverInfoList(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiCancelDriverInfoSearch(HDEVINFO DeviceInfoSet);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiEnumDriverInfoA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiEnumDriverInfoW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType, [NativeTypeName("DWORD")] uint MemberIndex, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetSelectedDriverA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetSelectedDriverW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetSelectedDriverA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetSelectedDriverW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDriverInfoDetailA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData, [NativeTypeName("PSP_DRVINFO_DETAIL_DATA_A")] void* DriverInfoDetailData, [NativeTypeName("DWORD")] uint DriverInfoDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDriverInfoDetailW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData, [NativeTypeName("PSP_DRVINFO_DETAIL_DATA_W")] void* DriverInfoDetailData, [NativeTypeName("DWORD")] uint DriverInfoDetailDataSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiDestroyDriverInfoList(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint DriverType);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HDEVINFO SetupDiGetClassDevsA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* Enumerator, HWND hwndParent, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HDEVINFO SetupDiGetClassDevsW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* Enumerator, HWND hwndParent, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HDEVINFO SetupDiGetClassDevsExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCSTR")] sbyte* Enumerator, HWND hwndParent, [NativeTypeName("DWORD")] uint Flags, HDEVINFO DeviceInfoSet, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HDEVINFO SetupDiGetClassDevsExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PCWSTR")] ushort* Enumerator, HWND hwndParent, [NativeTypeName("DWORD")] uint Flags, HDEVINFO DeviceInfoSet, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetINFClassA([NativeTypeName("PCSTR")] sbyte* InfName, [NativeTypeName("LPGUID")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetINFClassW([NativeTypeName("PCWSTR")] ushort* InfName, [NativeTypeName("LPGUID")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiBuildClassInfoList([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiBuildClassInfoListExA([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiBuildClassInfoListExW([NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassDescriptionA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassDescriptionW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassDescriptionExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassDescriptionExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassDescription, [NativeTypeName("DWORD")] uint ClassDescriptionSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiCallClassInstaller([NativeTypeName("DI_FUNCTION")] uint InstallFunction, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSelectDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSelectBestCompatDrv(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupDiInstallDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiInstallDriverFiles(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiRegisterCoDeviceInstallers(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiRemoveDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiUnremoveDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiRestartDevices(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiChangeState(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiInstallClassA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, HSPFILEQ FileQueue);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiInstallClassW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, HSPFILEQ FileQueue);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiInstallClassExA(HWND hwndParent, [NativeTypeName("PCSTR")] sbyte* InfFileName, [NativeTypeName("DWORD")] uint Flags, HSPFILEQ FileQueue, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiInstallClassExW(HWND hwndParent, [NativeTypeName("PCWSTR")] ushort* InfFileName, [NativeTypeName("DWORD")] uint Flags, HSPFILEQ FileQueue, [NativeTypeName("const GUID *")] Guid* InterfaceClassGuid, [NativeTypeName("PVOID")] void* Reserved1, [NativeTypeName("PVOID")] void* Reserved2);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiOpenClassRegKey([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiOpenClassRegKeyExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiOpenClassRegKeyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiCreateDeviceInterfaceRegKeyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiCreateDeviceInterfaceRegKeyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiOpenDeviceInterfaceRegKey(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiDeleteDeviceInterfaceRegKey(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("DWORD")] uint Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiCreateDevRegKeyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiCreateDevRegKeyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HKEY SetupDiOpenDevRegKey(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType, [NativeTypeName("REGSAM")] uint samDesired);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiDeleteDevRegKey(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Scope, [NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("DWORD")] uint KeyType);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetHwProfileList([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetHwProfileListExA([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetHwProfileListExW([NativeTypeName("PDWORD")] uint* HwProfileList, [NativeTypeName("DWORD")] uint HwProfileListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PDWORD")] uint* CurrentlyActiveIndex, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDevicePropertyKeys(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDevicePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDevicePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInterfacePropertyKeys(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInterfacePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDeviceInterfacePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVICE_INTERFACE_DATA")] void* DeviceInterfaceData, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassPropertyKeys([NativeTypeName("const GUID *")] Guid* ClassGuid, DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassPropertyKeysExW([NativeTypeName("const GUID *")] Guid* ClassGuid, DEVPROPKEY* PropertyKeyArray, [NativeTypeName("DWORD")] uint PropertyKeyCount, [NativeTypeName("PDWORD")] uint* RequiredPropertyKeyCount, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassPropertyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE *")] uint* PropertyType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetClassPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetClassPropertyExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("const DEVPROPKEY *")] DEVPROPKEY* PropertyKey, [NativeTypeName("DEVPROPTYPE")] uint PropertyType, [NativeTypeName("const PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceRegistryPropertyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceRegistryPropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassRegistryPropertyA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassRegistryPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDeviceRegistryPropertyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDeviceRegistryPropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetClassRegistryPropertyA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetClassRegistryPropertyW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("DWORD")] uint Property, [NativeTypeName("const BYTE *")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_A")] void* DeviceInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDeviceInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_W")] void* DeviceInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] void* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] void* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDeviceInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_A")] void* DeviceInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDeviceInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DEVINSTALL_PARAMS_W")] void* DeviceInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetClassInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] void* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetClassInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_CLASSINSTALL_HEADER")] void* ClassInstallParams, [NativeTypeName("DWORD")] uint ClassInstallParamsSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDriverInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] void* DriverInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetDriverInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] void* DriverInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDriverInstallParamsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_A")] void* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] void* DriverInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetDriverInstallParamsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_DRVINFO_DATA_W")] void* DriverInfoData, [NativeTypeName("PSP_DRVINSTALL_PARAMS")] void* DriverInstallParams);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiLoadClassIcon([NativeTypeName("const GUID *")] Guid* ClassGuid, HICON* LargeIcon, [NativeTypeName("PINT")] int* MiniIconIndex);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiLoadDeviceIcon(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, uint cxIcon, uint cyIcon, [NativeTypeName("DWORD")] uint Flags, HICON* hIcon);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern int SetupDiDrawMiniIcon(HDC hdc, RECT rc, int MiniIconIndex, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassBitmapIndex([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PINT")] int* MiniIconIndex);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassImageList([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassImageListExA([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassImageListExW([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassImageIndex([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData, [NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PINT")] int* ImageIndex);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiDestroyClassImageList([NativeTypeName("PSP_CLASSIMAGELIST_DATA")] void* ClassImageListData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassDevPropertySheetsA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("LPPROPSHEETHEADERA")] PROPSHEETHEADERA_V2* PropertySheetHeader, [NativeTypeName("DWORD")] uint PropertySheetHeaderPageListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint PropertySheetType);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetClassDevPropertySheetsW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("LPPROPSHEETHEADERW")] PROPSHEETHEADERW_V2* PropertySheetHeader, [NativeTypeName("DWORD")] uint PropertySheetHeaderPageListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("DWORD")] uint PropertySheetType);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiAskForOEMDisk(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSelectOEMDrv(HWND hwndParent, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiClassNameFromGuidA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiClassNameFromGuidW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiClassNameFromGuidExA([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PSTR")] sbyte* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiClassNameFromGuidExW([NativeTypeName("const GUID *")] Guid* ClassGuid, [NativeTypeName("PWSTR")] ushort* ClassName, [NativeTypeName("DWORD")] uint ClassNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiClassGuidsFromNameA([NativeTypeName("PCSTR")] sbyte* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiClassGuidsFromNameW([NativeTypeName("PCWSTR")] ushort* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiClassGuidsFromNameExA([NativeTypeName("PCSTR")] sbyte* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiClassGuidsFromNameExW([NativeTypeName("PCWSTR")] ushort* ClassName, [NativeTypeName("LPGUID")] Guid* ClassGuidList, [NativeTypeName("DWORD")] uint ClassGuidListSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetHwProfileFriendlyNameA([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PSTR")] sbyte* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetHwProfileFriendlyNameW([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PWSTR")] ushort* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetHwProfileFriendlyNameExA([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PSTR")] sbyte* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCSTR")] sbyte* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetHwProfileFriendlyNameExW([NativeTypeName("DWORD")] uint HwProfile, [NativeTypeName("PWSTR")] ushort* FriendlyName, [NativeTypeName("DWORD")] uint FriendlyNameSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PCWSTR")] ushort* MachineName, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern HPROPSHEETPAGE SetupDiGetWizardPage(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PSP_INSTALLWIZARD_DATA")] void* InstallWizardData, [NativeTypeName("DWORD")] uint PageType, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetSelectedDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiSetSelectedDevice(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetActualModelsSectionA([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetActualModelsSectionW([NativeTypeName("PINFCONTEXT")] void* Context, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetActualSectionToInstallA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** Extension);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetActualSectionToInstallW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** Extension);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetActualSectionToInstallExA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* InfSectionName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PSTR")] sbyte* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PSTR *")] sbyte** Extension, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetActualSectionToInstallExW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* InfSectionName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AlternatePlatformInfo, [NativeTypeName("PWSTR")] ushort* InfSectionWithExt, [NativeTypeName("DWORD")] uint InfSectionWithExtSize, [NativeTypeName("PDWORD")] uint* RequiredSize, [NativeTypeName("PWSTR *")] ushort** Extension, [NativeTypeName("PVOID")] void* Reserved);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupEnumInfSectionsA(HINF InfHandle, uint Index, [NativeTypeName("PSTR")] sbyte* Buffer, uint Size, uint* SizeNeeded);

        [DllImport("setupapi", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetupEnumInfSectionsW(HINF InfHandle, uint Index, [NativeTypeName("PWSTR")] ushort* Buffer, uint Size, uint* SizeNeeded);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupVerifyInfFileA([NativeTypeName("PCSTR")] sbyte* InfName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AltPlatformInfo, [NativeTypeName("PSP_INF_SIGNER_INFO_A")] void* InfSignerInfo);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupVerifyInfFileW([NativeTypeName("PCWSTR")] ushort* InfName, [NativeTypeName("PSP_ALTPLATFORM_INFO")] void* AltPlatformInfo, [NativeTypeName("PSP_INF_SIGNER_INFO_W")] void* InfSignerInfo);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetCustomDevicePropertyA(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PCSTR")] sbyte* CustomPropertyName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupDiGetCustomDevicePropertyW(HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData, [NativeTypeName("PCWSTR")] ushort* CustomPropertyName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PDWORD")] uint* PropertyRegDataType, [NativeTypeName("PBYTE")] byte* PropertyBuffer, [NativeTypeName("DWORD")] uint PropertyBufferSize, [NativeTypeName("PDWORD")] uint* RequiredSize);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupConfigureWmiFromInfSectionA(HINF InfHandle, [NativeTypeName("PCSTR")] sbyte* SectionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("setupapi", ExactSpelling = true)]
        public static extern BOOL SetupConfigureWmiFromInfSectionW(HINF InfHandle, [NativeTypeName("PCWSTR")] ushort* SectionName, [NativeTypeName("DWORD")] uint Flags);

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
        public static delegate*<void*, uint, void*, uint, uint*, BOOL> SetupGetInfInformation => &SetupGetInfInformationW;

        [NativeTypeName("#define SetupQueryInfFileInformation SetupQueryInfFileInformationW")]
        public static delegate*<void*, uint, ushort*, uint, uint*, BOOL> SetupQueryInfFileInformation => &SetupQueryInfFileInformationW;

        [NativeTypeName("#define SetupQueryInfOriginalFileInformation SetupQueryInfOriginalFileInformationW")]
        public static delegate*<void*, uint, void*, void*, BOOL> SetupQueryInfOriginalFileInformation => &SetupQueryInfOriginalFileInformationW;

        [NativeTypeName("#define SetupQueryInfVersionInformation SetupQueryInfVersionInformationW")]
        public static delegate*<void*, uint, ushort*, ushort*, uint, uint*, BOOL> SetupQueryInfVersionInformation => &SetupQueryInfVersionInformationW;

        [NativeTypeName("#define SetupGetInfDriverStoreLocation SetupGetInfDriverStoreLocationW")]
        public static delegate*<ushort*, void*, ushort*, ushort*, uint, uint*, BOOL> SetupGetInfDriverStoreLocation => &SetupGetInfDriverStoreLocationW;

        [NativeTypeName("#define SetupGetInfPublishedName SetupGetInfPublishedNameW")]
        public static delegate*<ushort*, ushort*, uint, uint*, BOOL> SetupGetInfPublishedName => &SetupGetInfPublishedNameW;

        [NativeTypeName("#define SetupGetInfFileList SetupGetInfFileListW")]
        public static delegate*<ushort*, uint, ushort*, uint, uint*, BOOL> SetupGetInfFileList => &SetupGetInfFileListW;

        [NativeTypeName("#define SetupOpenInfFile SetupOpenInfFileW")]
        public static delegate*<ushort*, ushort*, uint, uint*, HINF> SetupOpenInfFile => &SetupOpenInfFileW;

        [NativeTypeName("#define SetupOpenAppendInfFile SetupOpenAppendInfFileW")]
        public static delegate*<ushort*, HINF, uint*, BOOL> SetupOpenAppendInfFile => &SetupOpenAppendInfFileW;

        [NativeTypeName("#define SetupFindFirstLine SetupFindFirstLineW")]
        public static delegate*<HINF, ushort*, ushort*, void*, BOOL> SetupFindFirstLine => &SetupFindFirstLineW;

        [NativeTypeName("#define SetupFindNextMatchLine SetupFindNextMatchLineW")]
        public static delegate*<void*, ushort*, void*, BOOL> SetupFindNextMatchLine => &SetupFindNextMatchLineW;

        [NativeTypeName("#define SetupGetLineByIndex SetupGetLineByIndexW")]
        public static delegate*<HINF, ushort*, uint, void*, BOOL> SetupGetLineByIndex => &SetupGetLineByIndexW;

        [NativeTypeName("#define SetupGetLineCount SetupGetLineCountW")]
        public static delegate*<HINF, ushort*, int> SetupGetLineCount => &SetupGetLineCountW;

        [NativeTypeName("#define SetupGetLineText SetupGetLineTextW")]
        public static delegate*<void*, HINF, ushort*, ushort*, ushort*, uint, uint*, BOOL> SetupGetLineText => &SetupGetLineTextW;

        [NativeTypeName("#define SetupGetStringField SetupGetStringFieldW")]
        public static delegate*<void*, uint, ushort*, uint, uint*, BOOL> SetupGetStringField => &SetupGetStringFieldW;

        [NativeTypeName("#define SetupGetMultiSzField SetupGetMultiSzFieldW")]
        public static delegate*<void*, uint, ushort*, uint, uint*, BOOL> SetupGetMultiSzField => &SetupGetMultiSzFieldW;

        [NativeTypeName("#define SetupGetFileCompressionInfo SetupGetFileCompressionInfoW")]
        public static delegate*<ushort*, ushort**, uint*, uint*, uint*, uint> SetupGetFileCompressionInfo => &SetupGetFileCompressionInfoW;

        [NativeTypeName("#define SetupGetFileCompressionInfoEx SetupGetFileCompressionInfoExW")]
        public static delegate*<ushort*, ushort*, uint, uint*, uint*, uint*, uint*, BOOL> SetupGetFileCompressionInfoEx => &SetupGetFileCompressionInfoExW;

        [NativeTypeName("#define FILE_COMPRESSION_NONE 0")]
        public const int FILE_COMPRESSION_NONE = 0;

        [NativeTypeName("#define FILE_COMPRESSION_WINLZA 1")]
        public const int FILE_COMPRESSION_WINLZA = 1;

        [NativeTypeName("#define FILE_COMPRESSION_MSZIP 2")]
        public const int FILE_COMPRESSION_MSZIP = 2;

        [NativeTypeName("#define FILE_COMPRESSION_NTCAB 3")]
        public const int FILE_COMPRESSION_NTCAB = 3;

        [NativeTypeName("#define SetupDecompressOrCopyFile SetupDecompressOrCopyFileW")]
        public static delegate*<ushort*, ushort*, uint*, uint> SetupDecompressOrCopyFile => &SetupDecompressOrCopyFileW;

        [NativeTypeName("#define SetupGetSourceFileLocation SetupGetSourceFileLocationW")]
        public static delegate*<HINF, void*, ushort*, uint*, ushort*, uint, uint*, BOOL> SetupGetSourceFileLocation => &SetupGetSourceFileLocationW;

        [NativeTypeName("#define SetupGetSourceFileSize SetupGetSourceFileSizeW")]
        public static delegate*<HINF, void*, ushort*, ushort*, uint*, uint, BOOL> SetupGetSourceFileSize => &SetupGetSourceFileSizeW;

        [NativeTypeName("#define SetupGetTargetPath SetupGetTargetPathW")]
        public static delegate*<HINF, void*, ushort*, ushort*, uint, uint*, BOOL> SetupGetTargetPath => &SetupGetTargetPathW;

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
        public static delegate*<uint, ushort**, uint, BOOL> SetupSetSourceList => &SetupSetSourceListW;

        [NativeTypeName("#define SetupAddToSourceList SetupAddToSourceListW")]
        public static delegate*<uint, ushort*, BOOL> SetupAddToSourceList => &SetupAddToSourceListW;

        [NativeTypeName("#define SetupRemoveFromSourceList SetupRemoveFromSourceListW")]
        public static delegate*<uint, ushort*, BOOL> SetupRemoveFromSourceList => &SetupRemoveFromSourceListW;

        [NativeTypeName("#define SetupQuerySourceList SetupQuerySourceListW")]
        public static delegate*<uint, ushort***, uint*, BOOL> SetupQuerySourceList => &SetupQuerySourceListW;

        [NativeTypeName("#define SetupFreeSourceList SetupFreeSourceListW")]
        public static delegate*<ushort***, uint, BOOL> SetupFreeSourceList => &SetupFreeSourceListW;

        [NativeTypeName("#define SetupPromptForDisk SetupPromptForDiskW")]
        public static delegate*<HWND, ushort*, ushort*, ushort*, ushort*, ushort*, uint, ushort*, uint, uint*, uint> SetupPromptForDisk => &SetupPromptForDiskW;

        [NativeTypeName("#define SetupCopyError SetupCopyErrorW")]
        public static delegate*<HWND, ushort*, ushort*, ushort*, ushort*, ushort*, uint, uint, ushort*, uint, uint*, uint> SetupCopyError => &SetupCopyErrorW;

        [NativeTypeName("#define SetupRenameError SetupRenameErrorW")]
        public static delegate*<HWND, ushort*, ushort*, ushort*, uint, uint, uint> SetupRenameError => &SetupRenameErrorW;

        [NativeTypeName("#define SetupDeleteError SetupDeleteErrorW")]
        public static delegate*<HWND, ushort*, ushort*, uint, uint, uint> SetupDeleteError => &SetupDeleteErrorW;

        [NativeTypeName("#define SetupBackupError SetupBackupErrorW")]
        public static delegate*<HWND, ushort*, ushort*, ushort*, uint, uint, uint> SetupBackupError => &SetupBackupErrorW;

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
        public static delegate*<HINF, uint, ushort*, BOOL> SetupSetDirectoryId => &SetupSetDirectoryIdW;

        [NativeTypeName("#define SetupSetDirectoryIdEx SetupSetDirectoryIdExW")]
        public static delegate*<HINF, uint, ushort*, uint, uint, void*, BOOL> SetupSetDirectoryIdEx => &SetupSetDirectoryIdExW;

        [NativeTypeName("#define SETDIRID_NOT_FULL_PATH 0x00000001")]
        public const int SETDIRID_NOT_FULL_PATH = 0x00000001;

        [NativeTypeName("#define SetupGetSourceInfo SetupGetSourceInfoW")]
        public static delegate*<HINF, uint, uint, ushort*, uint, uint*, BOOL> SetupGetSourceInfo => &SetupGetSourceInfoW;

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
        public static delegate*<HINF, void*, ushort*, ushort*, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, BOOL> SetupInstallFile => &SetupInstallFileW;

        [NativeTypeName("#define SetupInstallFileEx SetupInstallFileExW")]
        public static delegate*<HINF, void*, ushort*, ushort*, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, BOOL*, BOOL> SetupInstallFileEx => &SetupInstallFileExW;

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
        public static delegate*<HSPFILEQ, void*, ushort*, BOOL> SetupSetFileQueueAlternatePlatform => &SetupSetFileQueueAlternatePlatformW;

        [NativeTypeName("#define SetupSetPlatformPathOverride SetupSetPlatformPathOverrideW")]
        public static delegate*<ushort*, BOOL> SetupSetPlatformPathOverride => &SetupSetPlatformPathOverrideW;

        [NativeTypeName("#define SetupQueueCopy SetupQueueCopyW")]
        public static delegate*<HSPFILEQ, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, uint, BOOL> SetupQueueCopy => &SetupQueueCopyW;

        [NativeTypeName("#define SetupQueueCopyIndirect SetupQueueCopyIndirectW")]
        public static delegate*<void*, BOOL> SetupQueueCopyIndirect => &SetupQueueCopyIndirectW;

        [NativeTypeName("#define SetupQueueDefaultCopy SetupQueueDefaultCopyW")]
        public static delegate*<HSPFILEQ, HINF, ushort*, ushort*, ushort*, uint, BOOL> SetupQueueDefaultCopy => &SetupQueueDefaultCopyW;

        [NativeTypeName("#define SetupQueueCopySection SetupQueueCopySectionW")]
        public static delegate*<HSPFILEQ, ushort*, HINF, HINF, ushort*, uint, BOOL> SetupQueueCopySection => &SetupQueueCopySectionW;

        [NativeTypeName("#define SetupQueueDelete SetupQueueDeleteW")]
        public static delegate*<HSPFILEQ, ushort*, ushort*, BOOL> SetupQueueDelete => &SetupQueueDeleteW;

        [NativeTypeName("#define SetupQueueDeleteSection SetupQueueDeleteSectionW")]
        public static delegate*<HSPFILEQ, HINF, HINF, ushort*, BOOL> SetupQueueDeleteSection => &SetupQueueDeleteSectionW;

        [NativeTypeName("#define SetupQueueRename SetupQueueRenameW")]
        public static delegate*<HSPFILEQ, ushort*, ushort*, ushort*, ushort*, BOOL> SetupQueueRename => &SetupQueueRenameW;

        [NativeTypeName("#define SetupQueueRenameSection SetupQueueRenameSectionW")]
        public static delegate*<HSPFILEQ, HINF, HINF, ushort*, BOOL> SetupQueueRenameSection => &SetupQueueRenameSectionW;

        [NativeTypeName("#define SetupCommitFileQueue SetupCommitFileQueueW")]
        public static delegate*<HWND, HSPFILEQ, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, BOOL> SetupCommitFileQueue => &SetupCommitFileQueueW;

        [NativeTypeName("#define SetupScanFileQueue SetupScanFileQueueW")]
        public static delegate*<HSPFILEQ, uint, HWND, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, uint*, BOOL> SetupScanFileQueue => &SetupScanFileQueueW;

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
        public static delegate*<ushort*, ushort*, uint, uint, ushort*, uint, uint*, ushort**, BOOL> SetupCopyOEMInf => &SetupCopyOEMInfW;

        [NativeTypeName("#define SUOI_FORCEDELETE 0x00000001")]
        public const int SUOI_FORCEDELETE = 0x00000001;

        [NativeTypeName("#define SUOI_INTERNAL1 0x00000002")]
        public const int SUOI_INTERNAL1 = 0x00000002;

        [NativeTypeName("#define SetupUninstallOEMInf SetupUninstallOEMInfW")]
        public static delegate*<ushort*, uint, void*, BOOL> SetupUninstallOEMInf => &SetupUninstallOEMInfW;

        [NativeTypeName("#define SetupCreateDiskSpaceList SetupCreateDiskSpaceListW")]
        public static delegate*<void*, uint, uint, HDSKSPC> SetupCreateDiskSpaceList => &SetupCreateDiskSpaceListW;

        [NativeTypeName("#define SPDSL_IGNORE_DISK 0x00000001")]
        public const int SPDSL_IGNORE_DISK = 0x00000001;

        [NativeTypeName("#define SPDSL_DISALLOW_NEGATIVE_ADJUST 0x00000002")]
        public const int SPDSL_DISALLOW_NEGATIVE_ADJUST = 0x00000002;

        [NativeTypeName("#define SetupDuplicateDiskSpaceList SetupDuplicateDiskSpaceListW")]
        public static delegate*<HDSKSPC, void*, uint, uint, HDSKSPC> SetupDuplicateDiskSpaceList => &SetupDuplicateDiskSpaceListW;

        [NativeTypeName("#define SetupQueryDrivesInDiskSpaceList SetupQueryDrivesInDiskSpaceListW")]
        public static delegate*<HDSKSPC, ushort*, uint, uint*, BOOL> SetupQueryDrivesInDiskSpaceList => &SetupQueryDrivesInDiskSpaceListW;

        [NativeTypeName("#define SetupQuerySpaceRequiredOnDrive SetupQuerySpaceRequiredOnDriveW")]
        public static delegate*<HDSKSPC, ushort*, long*, void*, uint, BOOL> SetupQuerySpaceRequiredOnDrive => &SetupQuerySpaceRequiredOnDriveW;

        [NativeTypeName("#define SetupAdjustDiskSpaceList SetupAdjustDiskSpaceListW")]
        public static delegate*<HDSKSPC, ushort*, long, void*, uint, BOOL> SetupAdjustDiskSpaceList => &SetupAdjustDiskSpaceListW;

        [NativeTypeName("#define SetupAddToDiskSpaceList SetupAddToDiskSpaceListW")]
        public static delegate*<HDSKSPC, ushort*, long, uint, void*, uint, BOOL> SetupAddToDiskSpaceList => &SetupAddToDiskSpaceListW;

        [NativeTypeName("#define SetupAddSectionToDiskSpaceList SetupAddSectionToDiskSpaceListW")]
        public static delegate*<HDSKSPC, HINF, HINF, ushort*, uint, void*, uint, BOOL> SetupAddSectionToDiskSpaceList => &SetupAddSectionToDiskSpaceListW;

        [NativeTypeName("#define SetupAddInstallSectionToDiskSpaceList SetupAddInstallSectionToDiskSpaceListW")]
        public static delegate*<HDSKSPC, HINF, HINF, ushort*, void*, uint, BOOL> SetupAddInstallSectionToDiskSpaceList => &SetupAddInstallSectionToDiskSpaceListW;

        [NativeTypeName("#define SetupRemoveFromDiskSpaceList SetupRemoveFromDiskSpaceListW")]
        public static delegate*<HDSKSPC, ushort*, uint, void*, uint, BOOL> SetupRemoveFromDiskSpaceList => &SetupRemoveFromDiskSpaceListW;

        [NativeTypeName("#define SetupRemoveSectionFromDiskSpaceList SetupRemoveSectionFromDiskSpaceListW")]
        public static delegate*<HDSKSPC, HINF, HINF, ushort*, uint, void*, uint, BOOL> SetupRemoveSectionFromDiskSpaceList => &SetupRemoveSectionFromDiskSpaceListW;

        [NativeTypeName("#define SetupRemoveInstallSectionFromDiskSpaceList SetupRemoveInstallSectionFromDiskSpaceListW")]
        public static delegate*<HDSKSPC, HINF, HINF, ushort*, void*, uint, BOOL> SetupRemoveInstallSectionFromDiskSpaceList => &SetupRemoveInstallSectionFromDiskSpaceListW;

        [NativeTypeName("#define SetupIterateCabinet SetupIterateCabinetW")]
        public static delegate*<ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, BOOL> SetupIterateCabinet => &SetupIterateCabinetW;

        [NativeTypeName("#define SPFILEQ_FILE_IN_USE 0x00000001")]
        public const int SPFILEQ_FILE_IN_USE = 0x00000001;

        [NativeTypeName("#define SPFILEQ_REBOOT_RECOMMENDED 0x00000002")]
        public const int SPFILEQ_REBOOT_RECOMMENDED = 0x00000002;

        [NativeTypeName("#define SPFILEQ_REBOOT_IN_PROGRESS 0x00000004")]
        public const int SPFILEQ_REBOOT_IN_PROGRESS = 0x00000004;

        [NativeTypeName("#define SetupDefaultQueueCallback SetupDefaultQueueCallbackW")]
        public static delegate*<void*, uint, nuint, nuint, uint> SetupDefaultQueueCallback => &SetupDefaultQueueCallbackW;

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
        public static delegate*<HWND, HINF, ushort*, uint, HKEY, ushort*, uint, delegate* unmanaged<void*, uint, nuint, nuint, uint>, void*, HDEVINFO, void*, BOOL> SetupInstallFromInfSection => &SetupInstallFromInfSectionW;

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
        public static delegate*<HINF, HINF, HSPFILEQ, ushort*, ushort*, uint, BOOL> SetupInstallFilesFromInfSection => &SetupInstallFilesFromInfSectionW;

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

        [NativeTypeName("#define SPSVCINST_UNIQUE_NAME (0x00010000)")]
        public const int SPSVCINST_UNIQUE_NAME = (0x00010000);

        [NativeTypeName("#define SetupInstallServicesFromInfSection SetupInstallServicesFromInfSectionW")]
        public static delegate*<HINF, ushort*, uint, BOOL> SetupInstallServicesFromInfSection => &SetupInstallServicesFromInfSectionW;

        [NativeTypeName("#define SetupInstallServicesFromInfSectionEx SetupInstallServicesFromInfSectionExW")]
        public static delegate*<HINF, ushort*, uint, HDEVINFO, void*, void*, void*, BOOL> SetupInstallServicesFromInfSectionEx => &SetupInstallServicesFromInfSectionExW;

        [NativeTypeName("#define InstallHinfSection InstallHinfSectionW")]
        public static delegate*<HWND, HINSTANCE, ushort*, int, void> InstallHinfSection => &InstallHinfSectionW;

        [NativeTypeName("#define SetupInitializeFileLog SetupInitializeFileLogW")]
        public static delegate*<ushort*, uint, HSPFILELOG> SetupInitializeFileLog => &SetupInitializeFileLogW;

        [NativeTypeName("#define SPFILELOG_SYSTEMLOG 0x00000001")]
        public const int SPFILELOG_SYSTEMLOG = 0x00000001;

        [NativeTypeName("#define SPFILELOG_FORCENEW 0x00000002")]
        public const int SPFILELOG_FORCENEW = 0x00000002;

        [NativeTypeName("#define SPFILELOG_QUERYONLY 0x00000004")]
        public const int SPFILELOG_QUERYONLY = 0x00000004;

        [NativeTypeName("#define SetupLogFile SetupLogFileW")]
        public static delegate*<HSPFILELOG, ushort*, ushort*, ushort*, uint, ushort*, ushort*, ushort*, uint, BOOL> SetupLogFile => &SetupLogFileW;

        [NativeTypeName("#define SPFILELOG_OEMFILE 0x00000001")]
        public const int SPFILELOG_OEMFILE = 0x00000001;

        [NativeTypeName("#define SetupRemoveFileLogEntry SetupRemoveFileLogEntryW")]
        public static delegate*<HSPFILELOG, ushort*, ushort*, BOOL> SetupRemoveFileLogEntry => &SetupRemoveFileLogEntryW;

        [NativeTypeName("#define SetupQueryFileLog SetupQueryFileLogW")]
        public static delegate*<HSPFILELOG, ushort*, ushort*, SetupFileLogInfo, ushort*, uint, uint*, BOOL> SetupQueryFileLog => &SetupQueryFileLogW;

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
        public static delegate*<ushort*, uint, BOOL> SetupLogError => &SetupLogErrorW;

        [NativeTypeName("#define SetupGetBackupInformation SetupGetBackupInformationW")]
        public static delegate*<HSPFILEQ, void*, BOOL> SetupGetBackupInformation => &SetupGetBackupInformationW;

        [NativeTypeName("#define SetupPrepareQueueForRestore SetupPrepareQueueForRestoreW")]
        public static delegate*<HSPFILEQ, ushort*, uint, BOOL> SetupPrepareQueueForRestore => &SetupPrepareQueueForRestoreW;

        [NativeTypeName("#define SetupDiCreateDeviceInfoListEx SetupDiCreateDeviceInfoListExW")]
        public static delegate*<Guid*, HWND, ushort*, void*, HDEVINFO> SetupDiCreateDeviceInfoListEx => &SetupDiCreateDeviceInfoListExW;

        [NativeTypeName("#define SetupDiGetDeviceInfoListDetail SetupDiGetDeviceInfoListDetailW")]
        public static delegate*<HDEVINFO, void*, BOOL> SetupDiGetDeviceInfoListDetail => &SetupDiGetDeviceInfoListDetailW;

        [NativeTypeName("#define DICD_GENERATE_ID 0x00000001")]
        public const int DICD_GENERATE_ID = 0x00000001;

        [NativeTypeName("#define DICD_INHERIT_CLASSDRVS 0x00000002")]
        public const int DICD_INHERIT_CLASSDRVS = 0x00000002;

        [NativeTypeName("#define SetupDiCreateDeviceInfo SetupDiCreateDeviceInfoW")]
        public static delegate*<HDEVINFO, ushort*, Guid*, ushort*, HWND, uint, void*, BOOL> SetupDiCreateDeviceInfo => &SetupDiCreateDeviceInfoW;

        [NativeTypeName("#define DIOD_INHERIT_CLASSDRVS 0x00000002")]
        public const int DIOD_INHERIT_CLASSDRVS = 0x00000002;

        [NativeTypeName("#define DIOD_CANCEL_REMOVE 0x00000004")]
        public const int DIOD_CANCEL_REMOVE = 0x00000004;

        [NativeTypeName("#define SetupDiOpenDeviceInfo SetupDiOpenDeviceInfoW")]
        public static delegate*<HDEVINFO, ushort*, HWND, uint, void*, BOOL> SetupDiOpenDeviceInfo => &SetupDiOpenDeviceInfoW;

        [NativeTypeName("#define SetupDiGetDeviceInstanceId SetupDiGetDeviceInstanceIdW")]
        public static delegate*<HDEVINFO, void*, ushort*, uint, uint*, BOOL> SetupDiGetDeviceInstanceId => &SetupDiGetDeviceInstanceIdW;

        [NativeTypeName("#define SetupDiEnumInterfaceDevice SetupDiEnumDeviceInterfaces")]
        public static delegate*<HDEVINFO, void*, Guid*, uint, void*, BOOL> SetupDiEnumInterfaceDevice => &SetupDiEnumDeviceInterfaces;

        [NativeTypeName("#define SetupDiCreateDeviceInterface SetupDiCreateDeviceInterfaceW")]
        public static delegate*<HDEVINFO, void*, Guid*, ushort*, uint, void*, BOOL> SetupDiCreateDeviceInterface => &SetupDiCreateDeviceInterfaceW;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceW SetupDiCreateDeviceInterfaceW")]
        public static delegate*<HDEVINFO, void*, Guid*, ushort*, uint, void*, BOOL> SetupDiCreateInterfaceDeviceW => &SetupDiCreateDeviceInterfaceW;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceA SetupDiCreateDeviceInterfaceA")]
        public static delegate*<HDEVINFO, void*, Guid*, sbyte*, uint, void*, BOOL> SetupDiCreateInterfaceDeviceA => &SetupDiCreateDeviceInterfaceA;

        [NativeTypeName("#define SetupDiCreateInterfaceDevice SetupDiCreateDeviceInterfaceW")]
        public static delegate*<HDEVINFO, void*, Guid*, ushort*, uint, void*, BOOL> SetupDiCreateInterfaceDevice => &SetupDiCreateDeviceInterfaceW;

        [NativeTypeName("#define DIODI_NO_ADD 0x00000001")]
        public const int DIODI_NO_ADD = 0x00000001;

        [NativeTypeName("#define SetupDiOpenDeviceInterface SetupDiOpenDeviceInterfaceW")]
        public static delegate*<HDEVINFO, ushort*, uint, void*, BOOL> SetupDiOpenDeviceInterface => &SetupDiOpenDeviceInterfaceW;

        [NativeTypeName("#define SetupDiOpenInterfaceDeviceW SetupDiOpenDeviceInterfaceW")]
        public static delegate*<HDEVINFO, ushort*, uint, void*, BOOL> SetupDiOpenInterfaceDeviceW => &SetupDiOpenDeviceInterfaceW;

        [NativeTypeName("#define SetupDiOpenInterfaceDeviceA SetupDiOpenDeviceInterfaceA")]
        public static delegate*<HDEVINFO, sbyte*, uint, void*, BOOL> SetupDiOpenInterfaceDeviceA => &SetupDiOpenDeviceInterfaceA;

        [NativeTypeName("#define SetupDiOpenInterfaceDevice SetupDiOpenDeviceInterfaceW")]
        public static delegate*<HDEVINFO, ushort*, uint, void*, BOOL> SetupDiOpenInterfaceDevice => &SetupDiOpenDeviceInterfaceW;

        [NativeTypeName("#define SetupDiGetInterfaceDeviceAlias SetupDiGetDeviceInterfaceAlias")]
        public static delegate*<HDEVINFO, void*, Guid*, void*, BOOL> SetupDiGetInterfaceDeviceAlias => &SetupDiGetDeviceInterfaceAlias;

        [NativeTypeName("#define SetupDiDeleteInterfaceDeviceData SetupDiDeleteDeviceInterfaceData")]
        public static delegate*<HDEVINFO, void*, BOOL> SetupDiDeleteInterfaceDeviceData => &SetupDiDeleteDeviceInterfaceData;

        [NativeTypeName("#define SetupDiRemoveInterfaceDevice SetupDiRemoveDeviceInterface")]
        public static delegate*<HDEVINFO, void*, BOOL> SetupDiRemoveInterfaceDevice => &SetupDiRemoveDeviceInterface;

        [NativeTypeName("#define SetupDiGetDeviceInterfaceDetail SetupDiGetDeviceInterfaceDetailW")]
        public static delegate*<HDEVINFO, void*, void*, uint, uint*, void*, BOOL> SetupDiGetDeviceInterfaceDetail => &SetupDiGetDeviceInterfaceDetailW;

        [NativeTypeName("#define SetupDiGetInterfaceDeviceDetailW SetupDiGetDeviceInterfaceDetailW")]
        public static delegate*<HDEVINFO, void*, void*, uint, uint*, void*, BOOL> SetupDiGetInterfaceDeviceDetailW => &SetupDiGetDeviceInterfaceDetailW;

        [NativeTypeName("#define SetupDiGetInterfaceDeviceDetailA SetupDiGetDeviceInterfaceDetailA")]
        public static delegate*<HDEVINFO, void*, void*, uint, uint*, void*, BOOL> SetupDiGetInterfaceDeviceDetailA => &SetupDiGetDeviceInterfaceDetailA;

        [NativeTypeName("#define SetupDiGetInterfaceDeviceDetail SetupDiGetDeviceInterfaceDetailW")]
        public static delegate*<HDEVINFO, void*, void*, uint, uint*, void*, BOOL> SetupDiGetInterfaceDeviceDetail => &SetupDiGetDeviceInterfaceDetailW;

        [NativeTypeName("#define SetupDiInstallInterfaceDevices SetupDiInstallDeviceInterfaces")]
        public static delegate*<HDEVINFO, void*, BOOL> SetupDiInstallInterfaceDevices => &SetupDiInstallDeviceInterfaces;

        [NativeTypeName("#define SPRDI_FIND_DUPS 0x00000001")]
        public const int SPRDI_FIND_DUPS = 0x00000001;

        [NativeTypeName("#define SPDIT_NODRIVER 0x00000000")]
        public const int SPDIT_NODRIVER = 0x00000000;

        [NativeTypeName("#define SPDIT_CLASSDRIVER 0x00000001")]
        public const int SPDIT_CLASSDRIVER = 0x00000001;

        [NativeTypeName("#define SPDIT_COMPATDRIVER 0x00000002")]
        public const int SPDIT_COMPATDRIVER = 0x00000002;

        [NativeTypeName("#define SetupDiEnumDriverInfo SetupDiEnumDriverInfoW")]
        public static delegate*<HDEVINFO, void*, uint, uint, void*, BOOL> SetupDiEnumDriverInfo => &SetupDiEnumDriverInfoW;

        [NativeTypeName("#define SetupDiGetSelectedDriver SetupDiGetSelectedDriverW")]
        public static delegate*<HDEVINFO, void*, void*, BOOL> SetupDiGetSelectedDriver => &SetupDiGetSelectedDriverW;

        [NativeTypeName("#define SetupDiSetSelectedDriver SetupDiSetSelectedDriverW")]
        public static delegate*<HDEVINFO, void*, void*, BOOL> SetupDiSetSelectedDriver => &SetupDiSetSelectedDriverW;

        [NativeTypeName("#define SetupDiGetDriverInfoDetail SetupDiGetDriverInfoDetailW")]
        public static delegate*<HDEVINFO, void*, void*, void*, uint, uint*, BOOL> SetupDiGetDriverInfoDetail => &SetupDiGetDriverInfoDetailW;

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
        public static delegate*<Guid*, ushort*, HWND, uint, HDEVINFO> SetupDiGetClassDevs => &SetupDiGetClassDevsW;

        [NativeTypeName("#define SetupDiGetClassDevsEx SetupDiGetClassDevsExW")]
        public static delegate*<Guid*, ushort*, HWND, uint, HDEVINFO, ushort*, void*, HDEVINFO> SetupDiGetClassDevsEx => &SetupDiGetClassDevsExW;

        [NativeTypeName("#define SetupDiGetINFClass SetupDiGetINFClassW")]
        public static delegate*<ushort*, Guid*, ushort*, uint, uint*, BOOL> SetupDiGetINFClass => &SetupDiGetINFClassW;

        [NativeTypeName("#define DIBCI_NOINSTALLCLASS 0x00000001")]
        public const int DIBCI_NOINSTALLCLASS = 0x00000001;

        [NativeTypeName("#define DIBCI_NODISPLAYCLASS 0x00000002")]
        public const int DIBCI_NODISPLAYCLASS = 0x00000002;

        [NativeTypeName("#define SetupDiBuildClassInfoListEx SetupDiBuildClassInfoListExW")]
        public static delegate*<uint, Guid*, uint, uint*, ushort*, void*, BOOL> SetupDiBuildClassInfoListEx => &SetupDiBuildClassInfoListExW;

        [NativeTypeName("#define SetupDiGetClassDescription SetupDiGetClassDescriptionW")]
        public static delegate*<Guid*, ushort*, uint, uint*, BOOL> SetupDiGetClassDescription => &SetupDiGetClassDescriptionW;

        [NativeTypeName("#define SetupDiGetClassDescriptionEx SetupDiGetClassDescriptionExW")]
        public static delegate*<Guid*, ushort*, uint, uint*, ushort*, void*, BOOL> SetupDiGetClassDescriptionEx => &SetupDiGetClassDescriptionExW;

        [NativeTypeName("#define SetupDiInstallClass SetupDiInstallClassW")]
        public static delegate*<HWND, ushort*, uint, HSPFILEQ, BOOL> SetupDiInstallClass => &SetupDiInstallClassW;

        [NativeTypeName("#define SetupDiInstallClassEx SetupDiInstallClassExW")]
        public static delegate*<HWND, ushort*, uint, HSPFILEQ, Guid*, void*, void*, BOOL> SetupDiInstallClassEx => &SetupDiInstallClassExW;

        [NativeTypeName("#define DIOCR_INSTALLER 0x00000001")]
        public const int DIOCR_INSTALLER = 0x00000001;

        [NativeTypeName("#define DIOCR_INTERFACE 0x00000002")]
        public const int DIOCR_INTERFACE = 0x00000002;

        [NativeTypeName("#define SetupDiOpenClassRegKeyEx SetupDiOpenClassRegKeyExW")]
        public static delegate*<Guid*, uint, uint, ushort*, void*, HKEY> SetupDiOpenClassRegKeyEx => &SetupDiOpenClassRegKeyExW;

        [NativeTypeName("#define SetupDiCreateDeviceInterfaceRegKey SetupDiCreateDeviceInterfaceRegKeyW")]
        public static delegate*<HDEVINFO, void*, uint, uint, HINF, ushort*, HKEY> SetupDiCreateDeviceInterfaceRegKey => &SetupDiCreateDeviceInterfaceRegKeyW;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKeyW SetupDiCreateDeviceInterfaceRegKeyW")]
        public static delegate*<HDEVINFO, void*, uint, uint, HINF, ushort*, HKEY> SetupDiCreateInterfaceDeviceRegKeyW => &SetupDiCreateDeviceInterfaceRegKeyW;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKeyA SetupDiCreateDeviceInterfaceRegKeyA")]
        public static delegate*<HDEVINFO, void*, uint, uint, HINF, sbyte*, HKEY> SetupDiCreateInterfaceDeviceRegKeyA => &SetupDiCreateDeviceInterfaceRegKeyA;

        [NativeTypeName("#define SetupDiCreateInterfaceDeviceRegKey SetupDiCreateDeviceInterfaceRegKeyW")]
        public static delegate*<HDEVINFO, void*, uint, uint, HINF, ushort*, HKEY> SetupDiCreateInterfaceDeviceRegKey => &SetupDiCreateDeviceInterfaceRegKeyW;

        [NativeTypeName("#define SetupDiOpenInterfaceDeviceRegKey SetupDiOpenDeviceInterfaceRegKey")]
        public static delegate*<HDEVINFO, void*, uint, uint, HKEY> SetupDiOpenInterfaceDeviceRegKey => &SetupDiOpenDeviceInterfaceRegKey;

        [NativeTypeName("#define SetupDiDeleteInterfaceDeviceRegKey SetupDiDeleteDeviceInterfaceRegKey")]
        public static delegate*<HDEVINFO, void*, uint, BOOL> SetupDiDeleteInterfaceDeviceRegKey => &SetupDiDeleteDeviceInterfaceRegKey;

        [NativeTypeName("#define DIREG_DEV 0x00000001")]
        public const int DIREG_DEV = 0x00000001;

        [NativeTypeName("#define DIREG_DRV 0x00000002")]
        public const int DIREG_DRV = 0x00000002;

        [NativeTypeName("#define DIREG_BOTH 0x00000004")]
        public const int DIREG_BOTH = 0x00000004;

        [NativeTypeName("#define SetupDiCreateDevRegKey SetupDiCreateDevRegKeyW")]
        public static delegate*<HDEVINFO, void*, uint, uint, uint, HINF, ushort*, HKEY> SetupDiCreateDevRegKey => &SetupDiCreateDevRegKeyW;

        [NativeTypeName("#define SetupDiGetHwProfileListEx SetupDiGetHwProfileListExW")]
        public static delegate*<uint*, uint, uint*, uint*, ushort*, void*, BOOL> SetupDiGetHwProfileListEx => &SetupDiGetHwProfileListExW;

        [NativeTypeName("#define SetupDiGetDeviceProperty SetupDiGetDevicePropertyW")]
        public static delegate*<HDEVINFO, void*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, BOOL> SetupDiGetDeviceProperty => &SetupDiGetDevicePropertyW;

        [NativeTypeName("#define SetupDiSetDeviceProperty SetupDiSetDevicePropertyW")]
        public static delegate*<HDEVINFO, void*, DEVPROPKEY*, uint, byte*, uint, uint, BOOL> SetupDiSetDeviceProperty => &SetupDiSetDevicePropertyW;

        [NativeTypeName("#define SetupDiGetDeviceInterfaceProperty SetupDiGetDeviceInterfacePropertyW")]
        public static delegate*<HDEVINFO, void*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, BOOL> SetupDiGetDeviceInterfaceProperty => &SetupDiGetDeviceInterfacePropertyW;

        [NativeTypeName("#define SetupDiSetDeviceInterfaceProperty SetupDiSetDeviceInterfacePropertyW")]
        public static delegate*<HDEVINFO, void*, DEVPROPKEY*, uint, byte*, uint, uint, BOOL> SetupDiSetDeviceInterfaceProperty => &SetupDiSetDeviceInterfacePropertyW;

        [NativeTypeName("#define DICLASSPROP_INSTALLER 0x00000001")]
        public const int DICLASSPROP_INSTALLER = 0x00000001;

        [NativeTypeName("#define DICLASSPROP_INTERFACE 0x00000002")]
        public const int DICLASSPROP_INTERFACE = 0x00000002;

        [NativeTypeName("#define SetupDiGetClassPropertyKeysEx SetupDiGetClassPropertyKeysExW")]
        public static delegate*<Guid*, DEVPROPKEY*, uint, uint*, uint, ushort*, void*, BOOL> SetupDiGetClassPropertyKeysEx => &SetupDiGetClassPropertyKeysExW;

        [NativeTypeName("#define SetupDiGetClassProperty SetupDiGetClassPropertyW")]
        public static delegate*<Guid*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, BOOL> SetupDiGetClassProperty => &SetupDiGetClassPropertyW;

        [NativeTypeName("#define SetupDiGetClassPropertyEx SetupDiGetClassPropertyExW")]
        public static delegate*<Guid*, DEVPROPKEY*, uint*, byte*, uint, uint*, uint, ushort*, void*, BOOL> SetupDiGetClassPropertyEx => &SetupDiGetClassPropertyExW;

        [NativeTypeName("#define SetupDiSetClassProperty SetupDiSetClassPropertyW")]
        public static delegate*<Guid*, DEVPROPKEY*, uint, byte*, uint, uint, BOOL> SetupDiSetClassProperty => &SetupDiSetClassPropertyW;

        [NativeTypeName("#define SetupDiSetClassPropertyEx SetupDiSetClassPropertyExW")]
        public static delegate*<Guid*, DEVPROPKEY*, uint, byte*, uint, uint, ushort*, void*, BOOL> SetupDiSetClassPropertyEx => &SetupDiSetClassPropertyExW;

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
        public static delegate*<HDEVINFO, void*, uint, uint*, byte*, uint, uint*, BOOL> SetupDiGetDeviceRegistryProperty => &SetupDiGetDeviceRegistryPropertyW;

        [NativeTypeName("#define SetupDiGetClassRegistryProperty SetupDiGetClassRegistryPropertyW")]
        public static delegate*<Guid*, uint, uint*, byte*, uint, uint*, ushort*, void*, BOOL> SetupDiGetClassRegistryProperty => &SetupDiGetClassRegistryPropertyW;

        [NativeTypeName("#define SetupDiSetDeviceRegistryProperty SetupDiSetDeviceRegistryPropertyW")]
        public static delegate*<HDEVINFO, void*, uint, byte*, uint, BOOL> SetupDiSetDeviceRegistryProperty => &SetupDiSetDeviceRegistryPropertyW;

        [NativeTypeName("#define SetupDiSetClassRegistryProperty SetupDiSetClassRegistryPropertyW")]
        public static delegate*<Guid*, uint, byte*, uint, ushort*, void*, BOOL> SetupDiSetClassRegistryProperty => &SetupDiSetClassRegistryPropertyW;

        [NativeTypeName("#define SetupDiGetDeviceInstallParams SetupDiGetDeviceInstallParamsW")]
        public static delegate*<HDEVINFO, void*, void*, BOOL> SetupDiGetDeviceInstallParams => &SetupDiGetDeviceInstallParamsW;

        [NativeTypeName("#define SetupDiGetClassInstallParams SetupDiGetClassInstallParamsW")]
        public static delegate*<HDEVINFO, void*, void*, uint, uint*, BOOL> SetupDiGetClassInstallParams => &SetupDiGetClassInstallParamsW;

        [NativeTypeName("#define SetupDiSetDeviceInstallParams SetupDiSetDeviceInstallParamsW")]
        public static delegate*<HDEVINFO, void*, void*, BOOL> SetupDiSetDeviceInstallParams => &SetupDiSetDeviceInstallParamsW;

        [NativeTypeName("#define SetupDiSetClassInstallParams SetupDiSetClassInstallParamsW")]
        public static delegate*<HDEVINFO, void*, void*, uint, BOOL> SetupDiSetClassInstallParams => &SetupDiSetClassInstallParamsW;

        [NativeTypeName("#define SetupDiGetDriverInstallParams SetupDiGetDriverInstallParamsW")]
        public static delegate*<HDEVINFO, void*, void*, void*, BOOL> SetupDiGetDriverInstallParams => &SetupDiGetDriverInstallParamsW;

        [NativeTypeName("#define SetupDiSetDriverInstallParams SetupDiSetDriverInstallParamsW")]
        public static delegate*<HDEVINFO, void*, void*, void*, BOOL> SetupDiSetDriverInstallParams => &SetupDiSetDriverInstallParamsW;

        [NativeTypeName("#define DMI_MASK 0x00000001")]
        public const int DMI_MASK = 0x00000001;

        [NativeTypeName("#define DMI_BKCOLOR 0x00000002")]
        public const int DMI_BKCOLOR = 0x00000002;

        [NativeTypeName("#define DMI_USERECT 0x00000004")]
        public const int DMI_USERECT = 0x00000004;

        [NativeTypeName("#define SetupDiGetClassImageListEx SetupDiGetClassImageListExW")]
        public static delegate*<void*, ushort*, void*, BOOL> SetupDiGetClassImageListEx => &SetupDiGetClassImageListExW;

        [NativeTypeName("#define DIGCDP_FLAG_BASIC 0x00000001")]
        public const int DIGCDP_FLAG_BASIC = 0x00000001;

        [NativeTypeName("#define DIGCDP_FLAG_ADVANCED 0x00000002")]
        public const int DIGCDP_FLAG_ADVANCED = 0x00000002;

        [NativeTypeName("#define DIGCDP_FLAG_REMOTE_BASIC 0x00000003")]
        public const int DIGCDP_FLAG_REMOTE_BASIC = 0x00000003;

        [NativeTypeName("#define DIGCDP_FLAG_REMOTE_ADVANCED 0x00000004")]
        public const int DIGCDP_FLAG_REMOTE_ADVANCED = 0x00000004;

        [NativeTypeName("#define SetupDiGetClassDevPropertySheets SetupDiGetClassDevPropertySheetsW")]
        public static delegate*<HDEVINFO, void*, PROPSHEETHEADERW_V2*, uint, uint*, uint, BOOL> SetupDiGetClassDevPropertySheets => &SetupDiGetClassDevPropertySheetsW;

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
        public static delegate*<Guid*, ushort*, uint, uint*, BOOL> SetupDiClassNameFromGuid => &SetupDiClassNameFromGuidW;

        [NativeTypeName("#define SetupDiClassNameFromGuidEx SetupDiClassNameFromGuidExW")]
        public static delegate*<Guid*, ushort*, uint, uint*, ushort*, void*, BOOL> SetupDiClassNameFromGuidEx => &SetupDiClassNameFromGuidExW;

        [NativeTypeName("#define SetupDiClassGuidsFromName SetupDiClassGuidsFromNameW")]
        public static delegate*<ushort*, Guid*, uint, uint*, BOOL> SetupDiClassGuidsFromName => &SetupDiClassGuidsFromNameW;

        [NativeTypeName("#define SetupDiClassGuidsFromNameEx SetupDiClassGuidsFromNameExW")]
        public static delegate*<ushort*, Guid*, uint, uint*, ushort*, void*, BOOL> SetupDiClassGuidsFromNameEx => &SetupDiClassGuidsFromNameExW;

        [NativeTypeName("#define SetupDiGetHwProfileFriendlyName SetupDiGetHwProfileFriendlyNameW")]
        public static delegate*<uint, ushort*, uint, uint*, BOOL> SetupDiGetHwProfileFriendlyName => &SetupDiGetHwProfileFriendlyNameW;

        [NativeTypeName("#define SetupDiGetHwProfileFriendlyNameEx SetupDiGetHwProfileFriendlyNameExW")]
        public static delegate*<uint, ushort*, uint, uint*, ushort*, void*, BOOL> SetupDiGetHwProfileFriendlyNameEx => &SetupDiGetHwProfileFriendlyNameExW;

        [NativeTypeName("#define SPWPT_SELECTDEVICE 0x00000001")]
        public const int SPWPT_SELECTDEVICE = 0x00000001;

        [NativeTypeName("#define SPWP_USE_DEVINFO_DATA 0x00000001")]
        public const int SPWP_USE_DEVINFO_DATA = 0x00000001;

        [NativeTypeName("#define SetupDiGetActualModelsSection SetupDiGetActualModelsSectionW")]
        public static delegate*<void*, void*, ushort*, uint, uint*, void*, BOOL> SetupDiGetActualModelsSection => &SetupDiGetActualModelsSectionW;

        [NativeTypeName("#define SetupDiGetActualSectionToInstall SetupDiGetActualSectionToInstallW")]
        public static delegate*<HINF, ushort*, ushort*, uint, uint*, ushort**, BOOL> SetupDiGetActualSectionToInstall => &SetupDiGetActualSectionToInstallW;

        [NativeTypeName("#define SetupDiGetActualSectionToInstallEx SetupDiGetActualSectionToInstallExW")]
        public static delegate*<HINF, ushort*, void*, ushort*, uint, uint*, ushort**, void*, BOOL> SetupDiGetActualSectionToInstallEx => &SetupDiGetActualSectionToInstallExW;

        [NativeTypeName("#define SetupEnumInfSections SetupEnumInfSectionsW")]
        public static delegate*<HINF, uint, ushort*, uint, uint*, BOOL> SetupEnumInfSections => &SetupEnumInfSectionsW;

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
        public static delegate*<ushort*, void*, void*, BOOL> SetupVerifyInfFile => &SetupVerifyInfFileW;

        [NativeTypeName("#define DICUSTOMDEVPROP_MERGE_MULTISZ 0x00000001")]
        public const int DICUSTOMDEVPROP_MERGE_MULTISZ = 0x00000001;

        [NativeTypeName("#define SetupDiGetCustomDeviceProperty SetupDiGetCustomDevicePropertyW")]
        public static delegate*<HDEVINFO, void*, ushort*, uint, uint*, byte*, uint, uint*, BOOL> SetupDiGetCustomDeviceProperty => &SetupDiGetCustomDevicePropertyW;

        [NativeTypeName("#define SCWMI_CLOBBER_SECURITY 0x00000001")]
        public const int SCWMI_CLOBBER_SECURITY = 0x00000001;

        [NativeTypeName("#define SetupConfigureWmiFromInfSection SetupConfigureWmiFromInfSectionW")]
        public static delegate*<HINF, ushort*, uint, BOOL> SetupConfigureWmiFromInfSection => &SetupConfigureWmiFromInfSectionW;
    }
}
