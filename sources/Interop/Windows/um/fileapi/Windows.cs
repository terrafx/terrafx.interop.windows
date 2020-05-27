// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", EntryPoint = "CompareFileTime", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CompareFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime1, [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime2);

        [DllImport("kernel32", EntryPoint = "CreateDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "CreateDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", EntryPoint = "CreateFileA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile);

        [DllImport("kernel32", EntryPoint = "CreateFileW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile);

        [DllImport("kernel32", EntryPoint = "DefineDosDeviceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DefineDosDeviceW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpDeviceName, [NativeTypeName("LPCWSTR")] ushort* lpTargetPath);

        [DllImport("kernel32", EntryPoint = "DeleteFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "DeleteFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "DeleteVolumeMountPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint);

        [DllImport("kernel32", EntryPoint = "FileTimeToLocalFileTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileTimeToLocalFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLocalFileTime);

        [DllImport("kernel32", EntryPoint = "FindClose", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindClose([NativeTypeName("HANDLE")] IntPtr hFindFile);

        [DllImport("kernel32", EntryPoint = "FindCloseChangeNotification", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindCloseChangeNotification([NativeTypeName("HANDLE")] IntPtr hChangeHandle);

        [DllImport("kernel32", EntryPoint = "FindFirstChangeNotificationA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstChangeNotificationA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

        [DllImport("kernel32", EntryPoint = "FindFirstChangeNotificationW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstChangeNotificationW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

        [DllImport("kernel32", EntryPoint = "FindFirstFileA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

        [DllImport("kernel32", EntryPoint = "FindFirstFileW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

        [DllImport("kernel32", EntryPoint = "FindFirstFileExA", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

        [DllImport("kernel32", EntryPoint = "FindFirstFileExW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileExW([NativeTypeName("LPCWSTR")] ushort* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

        [DllImport("kernel32", EntryPoint = "FindFirstVolumeW", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeW([NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "FindNextChangeNotification", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextChangeNotification([NativeTypeName("HANDLE")] IntPtr hChangeHandle);

        [DllImport("kernel32", EntryPoint = "FindNextFileA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileA([NativeTypeName("HANDLE")] IntPtr hFindFile, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

        [DllImport("kernel32", EntryPoint = "FindNextFileW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileW([NativeTypeName("HANDLE")] IntPtr hFindFile, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

        [DllImport("kernel32", EntryPoint = "FindNextVolumeW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeW([NativeTypeName("HANDLE")] IntPtr hFindVolume, [NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "FindVolumeClose", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindVolumeClose([NativeTypeName("HANDLE")] IntPtr hFindVolume);

        [DllImport("kernel32", EntryPoint = "FlushFileBuffers", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushFileBuffers([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", EntryPoint = "GetDiskFreeSpaceA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

        [DllImport("kernel32", EntryPoint = "GetDiskFreeSpaceW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

        [DllImport("kernel32", EntryPoint = "GetDiskFreeSpaceExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceExA([NativeTypeName("LPCSTR")] sbyte* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

        [DllImport("kernel32", EntryPoint = "GetDiskFreeSpaceExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceExW([NativeTypeName("LPCWSTR")] ushort* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

        [DllImport("kernel32", EntryPoint = "GetDiskSpaceInformationA", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDiskSpaceInformationA([NativeTypeName("LPCSTR")] sbyte* rootPath, [NativeTypeName("DISK_SPACE_INFORMATION *")] DISK_SPACE_INFORMATION* diskSpaceInfo);

        [DllImport("kernel32", EntryPoint = "GetDiskSpaceInformationW", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDiskSpaceInformationW([NativeTypeName("LPCWSTR")] ushort* rootPath, [NativeTypeName("DISK_SPACE_INFORMATION *")] DISK_SPACE_INFORMATION* diskSpaceInfo);

        [DllImport("kernel32", EntryPoint = "GetDriveTypeA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDriveTypeA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName);

        [DllImport("kernel32", EntryPoint = "GetDriveTypeW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDriveTypeW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName);

        [DllImport("kernel32", EntryPoint = "GetFileAttributesA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetFileAttributesW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", EntryPoint = "GetFileAttributesExA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

        [DllImport("kernel32", EntryPoint = "GetFileAttributesExW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesExW([NativeTypeName("LPCWSTR")] ushort* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

        [DllImport("kernel32", EntryPoint = "GetFileInformationByHandle", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileInformationByHandle([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPBY_HANDLE_FILE_INFORMATION")] BY_HANDLE_FILE_INFORMATION* lpFileInformation);

        [DllImport("kernel32", EntryPoint = "GetFileSize", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileSize([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport("kernel32", EntryPoint = "GetFileSizeEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileSizeEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpFileSize);

        [DllImport("kernel32", EntryPoint = "GetFileType", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileType([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", EntryPoint = "GetFinalPathNameByHandleA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFinalPathNameByHandleA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSTR")] sbyte* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "GetFinalPathNameByHandleW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFinalPathNameByHandleW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPWSTR")] ushort* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "GetFileTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileTime([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastAccessTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastWriteTime);

        [DllImport("kernel32", EntryPoint = "GetFullPathNameW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart);

        [DllImport("kernel32", EntryPoint = "GetFullPathNameA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart);

        [DllImport("kernel32", EntryPoint = "GetLogicalDrives", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDrives();

        [DllImport("kernel32", EntryPoint = "GetLogicalDriveStringsW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDriveStringsW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", EntryPoint = "GetLongPathNameA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport("kernel32", EntryPoint = "GetLongPathNameW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameW([NativeTypeName("LPCWSTR")] ushort* lpszShortPath, [NativeTypeName("LPWSTR")] ushort* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport("kernel32", EntryPoint = "GetShortPathNameW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetShortPathNameW([NativeTypeName("LPCWSTR")] ushort* lpszLongPath, [NativeTypeName("LPWSTR")] ushort* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport("kernel32", EntryPoint = "GetTempFileNameW", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTempFileNameW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("LPCWSTR")] ushort* lpPrefixString, [NativeTypeName("UINT")] uint uUnique, [NativeTypeName("LPWSTR")] ushort* lpTempFileName);

        [DllImport("kernel32", EntryPoint = "GetVolumeInformationByHandleW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationByHandleW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport("kernel32", EntryPoint = "GetVolumeInformationW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport("kernel32", EntryPoint = "GetVolumePathNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNameW([NativeTypeName("LPCWSTR")] ushort* lpszFileName, [NativeTypeName("LPWSTR")] ushort* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "LocalFileTimeToFileTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LocalFileTimeToFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpLocalFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

        [DllImport("kernel32", EntryPoint = "LockFile", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh);

        [DllImport("kernel32", EntryPoint = "LockFileEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", EntryPoint = "QueryDosDeviceW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryDosDeviceW([NativeTypeName("LPCWSTR")] ushort* lpDeviceName, [NativeTypeName("LPWSTR")] ushort* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

        [DllImport("kernel32", EntryPoint = "ReadFile", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", EntryPoint = "ReadFileEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] IntPtr lpCompletionRoutine);

        [DllImport("kernel32", EntryPoint = "ReadFileScatter", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFileScatter([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT []")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", EntryPoint = "RemoveDirectoryA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

        [DllImport("kernel32", EntryPoint = "RemoveDirectoryW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

        [DllImport("kernel32", EntryPoint = "SetEndOfFile", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEndOfFile([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", EntryPoint = "SetFileAttributesA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

        [DllImport("kernel32", EntryPoint = "SetFileAttributesW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

        [DllImport("kernel32", EntryPoint = "SetFileInformationByHandle", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileInformationByHandle([NativeTypeName("HANDLE")] IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

        [DllImport("kernel32", EntryPoint = "SetFilePointer", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetFilePointer([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LONG")] int lDistanceToMove, [NativeTypeName("PLONG")] int* lpDistanceToMoveHigh, [NativeTypeName("DWORD")] uint dwMoveMethod);

        [DllImport("kernel32", EntryPoint = "SetFilePointerEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFilePointerEx([NativeTypeName("HANDLE")] IntPtr hFile, LARGE_INTEGER liDistanceToMove, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpNewFilePointer, [NativeTypeName("DWORD")] uint dwMoveMethod);

        [DllImport("kernel32", EntryPoint = "SetFileTime", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileTime([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("const FILETIME *")] FILETIME* lpCreationTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastAccessTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastWriteTime);

        [DllImport("kernel32", EntryPoint = "SetFileValidData", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileValidData([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LONGLONG")] long ValidDataLength);

        [DllImport("kernel32", EntryPoint = "UnlockFile", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnlockFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh);

        [DllImport("kernel32", EntryPoint = "UnlockFileEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnlockFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", EntryPoint = "WriteFile", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", EntryPoint = "WriteFileEx", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] IntPtr lpCompletionRoutine);

        [DllImport("kernel32", EntryPoint = "WriteFileGather", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFileGather([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT []")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", EntryPoint = "GetTempPathW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTempPathW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", EntryPoint = "GetVolumeNameForVolumeMountPointW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeNameForVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", EntryPoint = "GetVolumePathNamesForVolumeNameW", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNamesForVolumeNameW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeName, [NativeTypeName("LPWCH")] ushort* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

        [DllImport("kernel32", EntryPoint = "CreateFile2", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFile2([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("LPCREATEFILE2_EXTENDED_PARAMETERS")] CREATEFILE2_EXTENDED_PARAMETERS* pCreateExParams);

        [DllImport("kernel32", EntryPoint = "SetFileIoOverlappedRange", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileIoOverlappedRange([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("PUCHAR")] byte* OverlappedRangeStart, [NativeTypeName("ULONG")] uint Length);

        [DllImport("kernel32", EntryPoint = "GetCompressedFileSizeA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport("kernel32", EntryPoint = "GetCompressedFileSizeW", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport("kernel32", EntryPoint = "FindFirstStreamW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstStreamW([NativeTypeName("LPCWSTR")] ushort* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", EntryPoint = "FindNextStreamW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextStreamW([NativeTypeName("HANDLE")] IntPtr hFindStream, [NativeTypeName("LPVOID")] void* lpFindStreamData);

        [DllImport("kernel32", EntryPoint = "AreFileApisANSI", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreFileApisANSI();

        [DllImport("kernel32", EntryPoint = "GetTempPathA", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTempPathA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        [DllImport("kernel32", EntryPoint = "FindFirstFileNameW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileNameW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName);

        [DllImport("kernel32", EntryPoint = "FindNextFileNameW", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileNameW([NativeTypeName("HANDLE")] IntPtr hFindStream, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName);

        [DllImport("kernel32", EntryPoint = "GetVolumeInformationA", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPSTR")] sbyte* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPSTR")] sbyte* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport("kernel32", EntryPoint = "GetTempFileNameA", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTempFileNameA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPCSTR")] sbyte* lpPrefixString, [NativeTypeName("UINT")] uint uUnique, [NativeTypeName("LPSTR")] sbyte* lpTempFileName);

        [DllImport("kernel32", EntryPoint = "SetFileApisToOEM", ExactSpelling = true)]
        public static extern void SetFileApisToOEM();

        [DllImport("kernel32", EntryPoint = "SetFileApisToANSI", ExactSpelling = true)]
        public static extern void SetFileApisToANSI();
    }
}
