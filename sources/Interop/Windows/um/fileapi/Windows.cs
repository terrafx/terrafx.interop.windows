// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int CompareFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime1, [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime2);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CreateDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, [NativeTypeName("HANDLE")] IntPtr hTemplateFile);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DefineDosDeviceW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpDeviceName, [NativeTypeName("LPCWSTR")] ushort* lpTargetPath);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int DeleteVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FileTimeToLocalFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLocalFileTime);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindClose([NativeTypeName("HANDLE")] IntPtr hFindFile);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindCloseChangeNotification([NativeTypeName("HANDLE")] IntPtr hChangeHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstChangeNotificationA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstChangeNotificationW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("BOOL")] int bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileExW([NativeTypeName("LPCWSTR")] ushort* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstVolumeW([NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextChangeNotification([NativeTypeName("HANDLE")] IntPtr hChangeHandle);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileA([NativeTypeName("HANDLE")] IntPtr hFindFile, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileW([NativeTypeName("HANDLE")] IntPtr hFindFile, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextVolumeW([NativeTypeName("HANDLE")] IntPtr hFindVolume, [NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindVolumeClose([NativeTypeName("HANDLE")] IntPtr hFindVolume);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FlushFileBuffers([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceExA([NativeTypeName("LPCSTR")] sbyte* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetDiskFreeSpaceExW([NativeTypeName("LPCWSTR")] ushort* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDiskSpaceInformationA([NativeTypeName("LPCSTR")] sbyte* rootPath, [NativeTypeName("DISK_SPACE_INFORMATION *")] DISK_SPACE_INFORMATION* diskSpaceInfo);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetDiskSpaceInformationW([NativeTypeName("LPCWSTR")] ushort* rootPath, [NativeTypeName("DISK_SPACE_INFORMATION *")] DISK_SPACE_INFORMATION* diskSpaceInfo);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDriveTypeA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetDriveTypeW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileAttributesExW([NativeTypeName("LPCWSTR")] ushort* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileInformationByHandle([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPBY_HANDLE_FILE_INFORMATION")] BY_HANDLE_FILE_INFORMATION* lpFileInformation);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileSize([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileSizeEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpFileSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFileType([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFinalPathNameByHandleA([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPSTR")] sbyte* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFinalPathNameByHandleW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPWSTR")] ushort* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetFileTime([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastAccessTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastWriteTime);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer, [NativeTypeName("LPWSTR *")] ushort** lpFilePart);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFullPathNameA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDrives();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLogicalDriveStringsW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetLongPathNameW([NativeTypeName("LPCWSTR")] ushort* lpszShortPath, [NativeTypeName("LPWSTR")] ushort* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetShortPathNameW([NativeTypeName("LPCWSTR")] ushort* lpszLongPath, [NativeTypeName("LPWSTR")] ushort* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTempFileNameW([NativeTypeName("LPCWSTR")] ushort* lpPathName, [NativeTypeName("LPCWSTR")] ushort* lpPrefixString, [NativeTypeName("UINT")] uint uUnique, [NativeTypeName("LPWSTR")] ushort* lpTempFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationByHandleW([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationW([NativeTypeName("LPCWSTR")] ushort* lpRootPathName, [NativeTypeName("LPWSTR")] ushort* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] ushort* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNameW([NativeTypeName("LPCWSTR")] ushort* lpszFileName, [NativeTypeName("LPWSTR")] ushort* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LocalFileTimeToFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpLocalFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int LockFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint QueryDosDeviceW([NativeTypeName("LPCWSTR")] ushort* lpDeviceName, [NativeTypeName("LPWSTR")] ushort* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int ReadFileScatter([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT []")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int RemoveDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetEndOfFile([NativeTypeName("HANDLE")] IntPtr hFile);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileAttributesW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileInformationByHandle([NativeTypeName("HANDLE")] IntPtr hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetFilePointer([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LONG")] int lDistanceToMove, [NativeTypeName("PLONG")] int* lpDistanceToMoveHigh, [NativeTypeName("DWORD")] uint dwMoveMethod);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFilePointerEx([NativeTypeName("HANDLE")] IntPtr hFile, LARGE_INTEGER liDistanceToMove, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpNewFilePointer, [NativeTypeName("DWORD")] uint dwMoveMethod);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileTime([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("const FILETIME *")] FILETIME* lpCreationTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastAccessTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastWriteTime);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileValidData([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LONGLONG")] long ValidDataLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnlockFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int UnlockFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFile([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFileEx([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WriteFileGather([NativeTypeName("HANDLE")] IntPtr hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT []")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTempPathW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] ushort* lpBuffer);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeNameForVolumeMountPointW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeMountPoint, [NativeTypeName("LPWSTR")] ushort* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumePathNamesForVolumeNameW([NativeTypeName("LPCWSTR")] ushort* lpszVolumeName, [NativeTypeName("LPWCH")] ushort* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateFile2([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("LPCREATEFILE2_EXTENDED_PARAMETERS")] CREATEFILE2_EXTENDED_PARAMETERS* pCreateExParams);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int SetFileIoOverlappedRange([NativeTypeName("HANDLE")] IntPtr FileHandle, [NativeTypeName("PUCHAR")] byte* OverlappedRangeStart, [NativeTypeName("ULONG")] uint Length);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetCompressedFileSizeW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstStreamW([NativeTypeName("LPCWSTR")] ushort* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextStreamW([NativeTypeName("HANDLE")] IntPtr hFindStream, [NativeTypeName("LPVOID")] void* lpFindStreamData);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int AreFileApisANSI();

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTempPathA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr FindFirstFileNameW([NativeTypeName("LPCWSTR")] ushort* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int FindNextFileNameW([NativeTypeName("HANDLE")] IntPtr hFindStream, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] ushort* LinkName);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetVolumeInformationA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPSTR")] sbyte* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPSTR")] sbyte* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("UINT")]
        public static extern uint GetTempFileNameA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPCSTR")] sbyte* lpPrefixString, [NativeTypeName("UINT")] uint uUnique, [NativeTypeName("LPSTR")] sbyte* lpTempFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void SetFileApisToOEM();

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void SetFileApisToANSI();

        [NativeTypeName("#define CREATE_NEW 1")]
        public const int CREATE_NEW = 1;

        [NativeTypeName("#define CREATE_ALWAYS 2")]
        public const int CREATE_ALWAYS = 2;

        [NativeTypeName("#define OPEN_EXISTING 3")]
        public const int OPEN_EXISTING = 3;

        [NativeTypeName("#define OPEN_ALWAYS 4")]
        public const int OPEN_ALWAYS = 4;

        [NativeTypeName("#define TRUNCATE_EXISTING 5")]
        public const int TRUNCATE_EXISTING = 5;

        [NativeTypeName("#define INVALID_FILE_SIZE ((DWORD)0xFFFFFFFF)")]
        public const uint INVALID_FILE_SIZE = ((uint)(0xFFFFFFFF));

        [NativeTypeName("#define INVALID_SET_FILE_POINTER ((DWORD)-1)")]
        public const uint INVALID_SET_FILE_POINTER = unchecked((uint)(-1));

        [NativeTypeName("#define INVALID_FILE_ATTRIBUTES ((DWORD)-1)")]
        public const uint INVALID_FILE_ATTRIBUTES = unchecked((uint)(-1));

        [NativeTypeName("#define CreateDirectory CreateDirectoryW")]
        public static readonly delegate*<ushort*, SECURITY_ATTRIBUTES*, int> CreateDirectory = &CreateDirectoryW;

        [NativeTypeName("#define CreateFile CreateFileW")]
        public static readonly delegate*<ushort*, uint, uint, SECURITY_ATTRIBUTES*, uint, uint, IntPtr, IntPtr> CreateFile = &CreateFileW;

        [NativeTypeName("#define DefineDosDevice DefineDosDeviceW")]
        public static readonly delegate*<uint, ushort*, ushort*, int> DefineDosDevice = &DefineDosDeviceW;

        [NativeTypeName("#define DeleteFile DeleteFileW")]
        public static readonly delegate*<ushort*, int> DeleteFile = &DeleteFileW;

        [NativeTypeName("#define DeleteVolumeMountPoint DeleteVolumeMountPointW")]
        public static readonly delegate*<ushort*, int> DeleteVolumeMountPoint = &DeleteVolumeMountPointW;

        [NativeTypeName("#define FindFirstChangeNotification FindFirstChangeNotificationW")]
        public static readonly delegate*<ushort*, int, uint, IntPtr> FindFirstChangeNotification = &FindFirstChangeNotificationW;

        [NativeTypeName("#define FindFirstFile FindFirstFileW")]
        public static readonly delegate*<ushort*, WIN32_FIND_DATAW*, IntPtr> FindFirstFile = &FindFirstFileW;

        [NativeTypeName("#define FindFirstFileEx FindFirstFileExW")]
        public static readonly delegate*<ushort*, FINDEX_INFO_LEVELS, void*, FINDEX_SEARCH_OPS, void*, uint, IntPtr> FindFirstFileEx = &FindFirstFileExW;

        [NativeTypeName("#define FindFirstVolume FindFirstVolumeW")]
        public static readonly delegate*<ushort*, uint, IntPtr> FindFirstVolume = &FindFirstVolumeW;

        [NativeTypeName("#define FindNextFile FindNextFileW")]
        public static readonly delegate*<IntPtr, WIN32_FIND_DATAW*, int> FindNextFile = &FindNextFileW;

        [NativeTypeName("#define FindNextVolume FindNextVolumeW")]
        public static readonly delegate*<IntPtr, ushort*, uint, int> FindNextVolume = &FindNextVolumeW;

        [NativeTypeName("#define GetDiskFreeSpace GetDiskFreeSpaceW")]
        public static readonly delegate*<ushort*, uint*, uint*, uint*, uint*, int> GetDiskFreeSpace = &GetDiskFreeSpaceW;

        [NativeTypeName("#define GetDiskFreeSpaceEx GetDiskFreeSpaceExW")]
        public static readonly delegate*<ushort*, ULARGE_INTEGER*, ULARGE_INTEGER*, ULARGE_INTEGER*, int> GetDiskFreeSpaceEx = &GetDiskFreeSpaceExW;

        [NativeTypeName("#define GetDiskSpaceInformation GetDiskSpaceInformationW")]
        public static readonly delegate*<ushort*, DISK_SPACE_INFORMATION*, int> GetDiskSpaceInformation = &GetDiskSpaceInformationW;

        [NativeTypeName("#define GetDriveType GetDriveTypeW")]
        public static readonly delegate*<ushort*, uint> GetDriveType = &GetDriveTypeW;

        [NativeTypeName("#define GetFileAttributes GetFileAttributesW")]
        public static readonly delegate*<ushort*, uint> GetFileAttributes = &GetFileAttributesW;

        [NativeTypeName("#define GetFileAttributesEx GetFileAttributesExW")]
        public static readonly delegate*<ushort*, GET_FILEEX_INFO_LEVELS, void*, int> GetFileAttributesEx = &GetFileAttributesExW;

        [NativeTypeName("#define GetFinalPathNameByHandle GetFinalPathNameByHandleW")]
        public static readonly delegate*<IntPtr, ushort*, uint, uint, uint> GetFinalPathNameByHandle = &GetFinalPathNameByHandleW;

        [NativeTypeName("#define GetFullPathName GetFullPathNameW")]
        public static readonly delegate*<ushort*, uint, ushort*, ushort**, uint> GetFullPathName = &GetFullPathNameW;

        [NativeTypeName("#define GetLogicalDriveStrings GetLogicalDriveStringsW")]
        public static readonly delegate*<uint, ushort*, uint> GetLogicalDriveStrings = &GetLogicalDriveStringsW;

        [NativeTypeName("#define GetLongPathName GetLongPathNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> GetLongPathName = &GetLongPathNameW;

        [NativeTypeName("#define GetShortPathName GetShortPathNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> GetShortPathName = &GetShortPathNameW;

        [NativeTypeName("#define GetTempFileName GetTempFileNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, ushort*, uint> GetTempFileName = &GetTempFileNameW;

        [NativeTypeName("#define GetVolumeInformation GetVolumeInformationW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint*, uint*, uint*, ushort*, uint, int> GetVolumeInformation = &GetVolumeInformationW;

        [NativeTypeName("#define GetVolumePathName GetVolumePathNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, int> GetVolumePathName = &GetVolumePathNameW;

        [NativeTypeName("#define QueryDosDevice QueryDosDeviceW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint> QueryDosDevice = &QueryDosDeviceW;

        [NativeTypeName("#define RemoveDirectory RemoveDirectoryW")]
        public static readonly delegate*<ushort*, int> RemoveDirectory = &RemoveDirectoryW;

        [NativeTypeName("#define SetFileAttributes SetFileAttributesW")]
        public static readonly delegate*<ushort*, uint, int> SetFileAttributes = &SetFileAttributesW;

        [NativeTypeName("#define GetTempPath GetTempPathW")]
        public static readonly delegate*<uint, ushort*, uint> GetTempPath = &GetTempPathW;

        [NativeTypeName("#define GetVolumeNameForVolumeMountPoint GetVolumeNameForVolumeMountPointW")]
        public static readonly delegate*<ushort*, ushort*, uint, int> GetVolumeNameForVolumeMountPoint = &GetVolumeNameForVolumeMountPointW;

        [NativeTypeName("#define GetVolumePathNamesForVolumeName GetVolumePathNamesForVolumeNameW")]
        public static readonly delegate*<ushort*, ushort*, uint, uint*, int> GetVolumePathNamesForVolumeName = &GetVolumePathNamesForVolumeNameW;

        [NativeTypeName("#define GetCompressedFileSize GetCompressedFileSizeW")]
        public static readonly delegate*<ushort*, uint*, uint> GetCompressedFileSize = &GetCompressedFileSizeW;
    }
}
