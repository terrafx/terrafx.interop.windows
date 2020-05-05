// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Kernel32
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CompareFileTime", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CompareFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime1, [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime2);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFileA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFileW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DefineDosDeviceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DefineDosDeviceW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpDeviceName, [NativeTypeName("LPCWSTR")] ushort* lpTargetPath);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DeleteVolumeMountPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FileTimeToLocalFileTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileTimeToLocalFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLocalFileTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindClose", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindClose([NativeTypeName("HANDLE")] IntPtr hFindFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindCloseChangeNotification", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindCloseChangeNotification([NativeTypeName("HANDLE")] IntPtr hChangeHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstChangeNotificationA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstChangeNotificationA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstChangeNotificationW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstChangeNotificationW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstFileA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstFileW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstFileExA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstFileExW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileExW([NativeTypeName("LPCWSTR")] ushort* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstVolumeW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeW([NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindNextChangeNotification", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextChangeNotification([NativeTypeName("HANDLE")] IntPtr hChangeHandle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindNextFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileA([NativeTypeName("HANDLE")] IntPtr hFindFile, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindNextFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileW([NativeTypeName("HANDLE")] IntPtr hFindFile, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindNextVolumeW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeW([NativeTypeName("HANDLE")] IntPtr hFindVolume, [NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindVolumeClose", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindVolumeClose([NativeTypeName("HANDLE")] IntPtr hFindVolume);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FlushFileBuffers", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushFileBuffers([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDiskFreeSpaceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDiskFreeSpaceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDiskFreeSpaceExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceExA([NativeTypeName("LPCSTR")] sbyte* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDiskFreeSpaceExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceExW([NativeTypeName("LPCWSTR")] ushort* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDiskSpaceInformationA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDiskSpaceInformationA([NativeTypeName("LPCSTR")] sbyte* rootPath, [NativeTypeName("DISK_SPACE_INFORMATION *")] DISK_SPACE_INFORMATION* diskSpaceInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDiskSpaceInformationW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDiskSpaceInformationW([NativeTypeName("LPCWSTR")] ushort* rootPath, [NativeTypeName("DISK_SPACE_INFORMATION *")] DISK_SPACE_INFORMATION* diskSpaceInfo);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDriveTypeA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDriveTypeA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetDriveTypeW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDriveTypeW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileAttributesA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileAttributesW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileAttributesExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileAttributesExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesExW([NativeTypeName("LPCWSTR")] ushort* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileInformationByHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileInformationByHandle([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPBY_HANDLE_FILE_INFORMATION")] BY_HANDLE_FILE_INFORMATION* lpFileInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileSize", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileSize([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileSizeEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileSizeEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpFileSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileType", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileType([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFinalPathNameByHandleA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFinalPathNameByHandleA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSTR")] sbyte* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFinalPathNameByHandleW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFinalPathNameByHandleW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPWSTR")] ushort* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFileTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileTime([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastAccessTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastWriteTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFullPathNameW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetFullPathNameA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLogicalDrives", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDrives();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLogicalDriveStringsW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDriveStringsW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLongPathNameA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetLongPathNameW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameW([NativeTypeName("LPCWSTR")] ushort* lpszShortPath, [NativeTypeName("LPWSTR")] ushort* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetShortPathNameW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetShortPathNameW([NativeTypeName("LPCWSTR")] ushort* lpszLongPath, [NativeTypeName("LPWSTR")] ushort* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTempFileNameW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTempFileNameW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("LPCWSTR")] ushort* lpPrefixString, [NativeTypeName("UINT")] uint uUnique, [NativeTypeName("LPWSTR")] ushort* lpTempFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVolumeInformationByHandleW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationByHandleW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVolumeInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVolumePathNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNameW([NativeTypeName("LPCWSTR")] ushort* lpszFileName, [NativeTypeName("LPWSTR")] ushort* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LocalFileTimeToFileTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LocalFileTimeToFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpLocalFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LockFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "LockFileEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "QueryDosDeviceW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryDosDeviceW([NativeTypeName("LPCWSTR")] ushort* lpDeviceName, [NativeTypeName("LPWSTR")] ushort* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ReadFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ReadFileEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] IntPtr* lpCompletionRoutine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ReadFileScatter", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFileScatter([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT []")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RemoveDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetEndOfFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEndOfFile([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFileAttributesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFileAttributesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFileInformationByHandle", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileInformationByHandle([NativeTypeName("HANDLE")] IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFilePointer", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetFilePointer([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LONG")] int lDistanceToMove, [NativeTypeName("PLONG")] int* lpDistanceToMoveHigh, [NativeTypeName("DWORD")] uint dwMoveMethod);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFilePointerEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFilePointerEx([NativeTypeName("HANDLE")] IntPtr hFile, LARGE_INTEGER liDistanceToMove, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpNewFilePointer, [NativeTypeName("DWORD")] uint dwMoveMethod);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFileTime", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileTime([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("const FILETIME *")] FILETIME* lpCreationTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastAccessTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastWriteTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFileValidData", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileValidData([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LONGLONG")] long ValidDataLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnlockFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnlockFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "UnlockFileEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnlockFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WriteFile", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WriteFileEx", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] IntPtr* lpCompletionRoutine);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "WriteFileGather", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFileGather([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT []")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTempPathW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTempPathW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVolumeNameForVolumeMountPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeNameForVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVolumePathNamesForVolumeNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNamesForVolumeNameW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeName, [NativeTypeName("LPWCH")] ushort* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateFile2", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFile2([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("LPCREATEFILE2_EXTENDED_PARAMETERS")] CREATEFILE2_EXTENDED_PARAMETERS* pCreateExParams);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFileIoOverlappedRange", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileIoOverlappedRange([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("PUCHAR")] byte* OverlappedRangeStart, [NativeTypeName("ULONG")] uint Length);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCompressedFileSizeA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetCompressedFileSizeW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstStreamW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstStreamW([NativeTypeName("LPCWSTR")] ushort* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindNextStreamW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextStreamW([NativeTypeName("HANDLE")] IntPtr hFindStream, [NativeTypeName("LPVOID")] void* lpFindStreamData);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "AreFileApisANSI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreFileApisANSI();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTempPathA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTempPathA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindFirstFileNameW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileNameW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FindNextFileNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileNameW([NativeTypeName("HANDLE")] IntPtr hFindStream, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetVolumeInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPSTR")] sbyte* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPSTR")] sbyte* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetTempFileNameA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTempFileNameA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPCSTR")] sbyte* lpPrefixString, [NativeTypeName("UINT")] uint uUnique, [NativeTypeName("LPSTR")] sbyte* lpTempFileName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFileApisToOEM", ExactSpelling = true)]
        public static extern void SetFileApisToOEM();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "SetFileApisToANSI", ExactSpelling = true)]
        public static extern void SetFileApisToANSI();
    }
}
