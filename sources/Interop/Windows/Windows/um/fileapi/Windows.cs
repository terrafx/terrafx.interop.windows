// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CompareFileTime"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int CompareFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime1, [NativeTypeName("const FILETIME *")] FILETIME* lpFileTime2);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDirectoryA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateDirectoryW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL CreateDirectoryW([NativeTypeName("LPCWSTR")] char* lpPathName, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, HANDLE hTemplateFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFileW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE CreateFileW([NativeTypeName("LPCWSTR")] char* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("DWORD")] uint dwFlagsAndAttributes, HANDLE hTemplateFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DefineDosDeviceW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DefineDosDeviceW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] char* lpDeviceName, [NativeTypeName("LPCWSTR")] char* lpTargetPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteFileA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteFileW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteFileW([NativeTypeName("LPCWSTR")] char* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DeleteVolumeMountPointW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DeleteVolumeMountPointW([NativeTypeName("LPCWSTR")] char* lpszVolumeMountPoint);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FileTimeToLocalFileTime"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FileTimeToLocalFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLocalFileTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindClose"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindClose(HANDLE hFindFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindCloseChangeNotification"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindCloseChangeNotification(HANDLE hChangeHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstChangeNotificationA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstChangeNotificationA([NativeTypeName("LPCSTR")] sbyte* lpPathName, BOOL bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstChangeNotificationW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstChangeNotificationW([NativeTypeName("LPCWSTR")] char* lpPathName, BOOL bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFileA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFileW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileW([NativeTypeName("LPCWSTR")] char* lpFileName, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFileExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFileExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileExW([NativeTypeName("LPCWSTR")] char* lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, [NativeTypeName("LPVOID")] void* lpSearchFilter, [NativeTypeName("DWORD")] uint dwAdditionalFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstVolumeW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstVolumeW([NativeTypeName("LPWSTR")] char* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextChangeNotification"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextChangeNotification(HANDLE hChangeHandle);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextFileA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextFileA(HANDLE hFindFile, [NativeTypeName("LPWIN32_FIND_DATAA")] WIN32_FIND_DATAA* lpFindFileData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextFileW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextFileW(HANDLE hFindFile, [NativeTypeName("LPWIN32_FIND_DATAW")] WIN32_FIND_DATAW* lpFindFileData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextVolumeW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextVolumeW(HANDLE hFindVolume, [NativeTypeName("LPWSTR")] char* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindVolumeClose"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindVolumeClose(HANDLE hFindVolume);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FlushFileBuffers"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FlushFileBuffers(HANDLE hFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDiskFreeSpaceA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDiskFreeSpaceA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDiskFreeSpaceW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDiskFreeSpaceW([NativeTypeName("LPCWSTR")] char* lpRootPathName, [NativeTypeName("LPDWORD")] uint* lpSectorsPerCluster, [NativeTypeName("LPDWORD")] uint* lpBytesPerSector, [NativeTypeName("LPDWORD")] uint* lpNumberOfFreeClusters, [NativeTypeName("LPDWORD")] uint* lpTotalNumberOfClusters);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDiskFreeSpaceExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDiskFreeSpaceExA([NativeTypeName("LPCSTR")] sbyte* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDiskFreeSpaceExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetDiskFreeSpaceExW([NativeTypeName("LPCWSTR")] char* lpDirectoryName, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpFreeBytesAvailableToCaller, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfBytes, [NativeTypeName("PULARGE_INTEGER")] ULARGE_INTEGER* lpTotalNumberOfFreeBytes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDiskSpaceInformationA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT GetDiskSpaceInformationA([NativeTypeName("LPCSTR")] sbyte* rootPath, DISK_SPACE_INFORMATION* diskSpaceInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDiskSpaceInformationW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static extern HRESULT GetDiskSpaceInformationW([NativeTypeName("LPCWSTR")] char* rootPath, DISK_SPACE_INFORMATION* diskSpaceInfo);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDriveTypeA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetDriveTypeA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDriveTypeW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern uint GetDriveTypeW([NativeTypeName("LPCWSTR")] char* lpRootPathName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileAttributesA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileAttributesW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFileAttributesW([NativeTypeName("LPCWSTR")] char* lpFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileAttributesExA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileAttributesExA([NativeTypeName("LPCSTR")] sbyte* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileAttributesExW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileAttributesExW([NativeTypeName("LPCWSTR")] char* lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, [NativeTypeName("LPVOID")] void* lpFileInformation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileInformationByHandle"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileInformationByHandle(HANDLE hFile, [NativeTypeName("LPBY_HANDLE_FILE_INFORMATION")] BY_HANDLE_FILE_INFORMATION* lpFileInformation);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileSize"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFileSize(HANDLE hFile, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileSizeEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileSizeEx(HANDLE hFile, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpFileSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileType"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFileType(HANDLE hFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFinalPathNameByHandleA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFinalPathNameByHandleA(HANDLE hFile, [NativeTypeName("LPSTR")] sbyte* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFinalPathNameByHandleW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFinalPathNameByHandleW(HANDLE hFile, [NativeTypeName("LPWSTR")] char* lpszFilePath, [NativeTypeName("DWORD")] uint cchFilePath, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFileTime"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetFileTime(HANDLE hFile, [NativeTypeName("LPFILETIME")] FILETIME* lpCreationTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastAccessTime, [NativeTypeName("LPFILETIME")] FILETIME* lpLastWriteTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFullPathNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFullPathNameW([NativeTypeName("LPCWSTR")] char* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] char* lpBuffer, [NativeTypeName("LPWSTR *")] char** lpFilePart);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetFullPathNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFullPathNameA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer, [NativeTypeName("LPSTR *")] sbyte** lpFilePart);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLogicalDrives"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLogicalDrives();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLogicalDriveStringsW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLogicalDriveStringsW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] char* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLongPathNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLongPathNameA([NativeTypeName("LPCSTR")] sbyte* lpszShortPath, [NativeTypeName("LPSTR")] sbyte* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetLongPathNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetLongPathNameW([NativeTypeName("LPCWSTR")] char* lpszShortPath, [NativeTypeName("LPWSTR")] char* lpszLongPath, [NativeTypeName("DWORD")] uint cchBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AreShortNamesEnabled"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AreShortNamesEnabled(HANDLE Handle, BOOL* Enabled);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetShortPathNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetShortPathNameW([NativeTypeName("LPCWSTR")] char* lpszLongPath, [NativeTypeName("LPWSTR")] char* lpszShortPath, [NativeTypeName("DWORD")] uint cchBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTempFileNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetTempFileNameW([NativeTypeName("LPCWSTR")] char* lpPathName, [NativeTypeName("LPCWSTR")] char* lpPrefixString, uint uUnique, [NativeTypeName("LPWSTR")] char* lpTempFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumeInformationByHandleW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeInformationByHandleW(HANDLE hFile, [NativeTypeName("LPWSTR")] char* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] char* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumeInformationW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeInformationW([NativeTypeName("LPCWSTR")] char* lpRootPathName, [NativeTypeName("LPWSTR")] char* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPWSTR")] char* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumePathNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumePathNameW([NativeTypeName("LPCWSTR")] char* lpszFileName, [NativeTypeName("LPWSTR")] char* lpszVolumePathName, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LocalFileTimeToFileTime"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LocalFileTimeToFileTime([NativeTypeName("const FILETIME *")] FILETIME* lpLocalFileTime, [NativeTypeName("LPFILETIME")] FILETIME* lpFileTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LockFile"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LockFile(HANDLE hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.LockFileEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL LockFileEx(HANDLE hFile, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToLockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.QueryDosDeviceW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint QueryDosDeviceW([NativeTypeName("LPCWSTR")] char* lpDeviceName, [NativeTypeName("LPWSTR")] char* lpTargetPath, [NativeTypeName("DWORD")] uint ucchMax);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadFile"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadFile(HANDLE hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadFileEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadFileEx(HANDLE hFile, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadFileScatter"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL ReadFileScatter(HANDLE hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT[]")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToRead, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveDirectoryA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveDirectoryW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDirectoryW([NativeTypeName("LPCWSTR")] char* lpPathName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetEndOfFile"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetEndOfFile(HANDLE hFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileAttributesA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileAttributesA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileAttributesW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileAttributesW([NativeTypeName("LPCWSTR")] char* lpFileName, [NativeTypeName("DWORD")] uint dwFileAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileInformationByHandle"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileInformationByHandle(HANDLE hFile, FILE_INFO_BY_HANDLE_CLASS FileInformationClass, [NativeTypeName("LPVOID")] void* lpFileInformation, [NativeTypeName("DWORD")] uint dwBufferSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFilePointer"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetFilePointer(HANDLE hFile, [NativeTypeName("LONG")] int lDistanceToMove, [NativeTypeName("PLONG")] int* lpDistanceToMoveHigh, [NativeTypeName("DWORD")] uint dwMoveMethod);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFilePointerEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFilePointerEx(HANDLE hFile, LARGE_INTEGER liDistanceToMove, [NativeTypeName("PLARGE_INTEGER")] LARGE_INTEGER* lpNewFilePointer, [NativeTypeName("DWORD")] uint dwMoveMethod);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileTime"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileTime(HANDLE hFile, [NativeTypeName("const FILETIME *")] FILETIME* lpCreationTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastAccessTime, [NativeTypeName("const FILETIME *")] FILETIME* lpLastWriteTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileValidData"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileValidData(HANDLE hFile, [NativeTypeName("LONGLONG")] long ValidDataLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnlockFile"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnlockFile(HANDLE hFile, [NativeTypeName("DWORD")] uint dwFileOffsetLow, [NativeTypeName("DWORD")] uint dwFileOffsetHigh, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnlockFileEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL UnlockFileEx(HANDLE hFile, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockLow, [NativeTypeName("DWORD")] uint nNumberOfBytesToUnlockHigh, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteFile"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteFile(HANDLE hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpNumberOfBytesWritten, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteFileEx"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteFileEx(HANDLE hFile, [NativeTypeName("LPCVOID")] void* lpBuffer, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> lpCompletionRoutine);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteFileGather"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WriteFileGather(HANDLE hFile, [NativeTypeName("FILE_SEGMENT_ELEMENT[]")] FILE_SEGMENT_ELEMENT* aSegmentArray, [NativeTypeName("DWORD")] uint nNumberOfBytesToWrite, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* lpOverlapped);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTempPathW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTempPathW([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPWSTR")] char* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumeNameForVolumeMountPointW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeNameForVolumeMountPointW([NativeTypeName("LPCWSTR")] char* lpszVolumeMountPoint, [NativeTypeName("LPWSTR")] char* lpszVolumeName, [NativeTypeName("DWORD")] uint cchBufferLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumePathNamesForVolumeNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumePathNamesForVolumeNameW([NativeTypeName("LPCWSTR")] char* lpszVolumeName, [NativeTypeName("LPWCH")] char* lpszVolumePathNames, [NativeTypeName("DWORD")] uint cchBufferLength, [NativeTypeName("PDWORD")] uint* lpcchReturnLength);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateFile2"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows6.2")]
    public static extern HANDLE CreateFile2([NativeTypeName("LPCWSTR")] char* lpFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("DWORD")] uint dwCreationDisposition, [NativeTypeName("LPCREATEFILE2_EXTENDED_PARAMETERS")] CREATEFILE2_EXTENDED_PARAMETERS* pCreateExParams);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileIoOverlappedRange"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetFileIoOverlappedRange(HANDLE FileHandle, [NativeTypeName("PUCHAR")] byte* OverlappedRangeStart, [NativeTypeName("ULONG")] uint Length);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCompressedFileSizeA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCompressedFileSizeA([NativeTypeName("LPCSTR")] sbyte* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCompressedFileSizeW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCompressedFileSizeW([NativeTypeName("LPCWSTR")] char* lpFileName, [NativeTypeName("LPDWORD")] uint* lpFileSizeHigh);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstStreamW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstStreamW([NativeTypeName("LPCWSTR")] char* lpFileName, STREAM_INFO_LEVELS InfoLevel, [NativeTypeName("LPVOID")] void* lpFindStreamData, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextStreamW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextStreamW(HANDLE hFindStream, [NativeTypeName("LPVOID")] void* lpFindStreamData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AreFileApisANSI"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL AreFileApisANSI();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTempPathA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetTempPathA([NativeTypeName("DWORD")] uint nBufferLength, [NativeTypeName("LPSTR")] sbyte* lpBuffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindFirstFileNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HANDLE FindFirstFileNameW([NativeTypeName("LPCWSTR")] char* lpFileName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] char* LinkName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindNextFileNameW"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FindNextFileNameW(HANDLE hFindStream, [NativeTypeName("LPDWORD")] uint* StringLength, [NativeTypeName("PWSTR")] char* LinkName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetVolumeInformationA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetVolumeInformationA([NativeTypeName("LPCSTR")] sbyte* lpRootPathName, [NativeTypeName("LPSTR")] sbyte* lpVolumeNameBuffer, [NativeTypeName("DWORD")] uint nVolumeNameSize, [NativeTypeName("LPDWORD")] uint* lpVolumeSerialNumber, [NativeTypeName("LPDWORD")] uint* lpMaximumComponentLength, [NativeTypeName("LPDWORD")] uint* lpFileSystemFlags, [NativeTypeName("LPSTR")] sbyte* lpFileSystemNameBuffer, [NativeTypeName("DWORD")] uint nFileSystemNameSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTempFileNameA"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern uint GetTempFileNameA([NativeTypeName("LPCSTR")] sbyte* lpPathName, [NativeTypeName("LPCSTR")] sbyte* lpPrefixString, uint uUnique, [NativeTypeName("LPSTR")] sbyte* lpTempFileName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileApisToOEM"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SetFileApisToOEM();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetFileApisToANSI"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void SetFileApisToANSI();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTempPath2W"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint GetTempPath2W([NativeTypeName("DWORD")] uint BufferLength, [NativeTypeName("LPWSTR")] char* Buffer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetTempPath2A"]/*' />
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint GetTempPath2A([NativeTypeName("DWORD")] uint BufferLength, [NativeTypeName("LPSTR")] sbyte* Buffer);

    [NativeTypeName("#define TRUNCATE_EXISTING 5")]
    public const int TRUNCATE_EXISTING = 5;

    [NativeTypeName("#define INVALID_FILE_SIZE ((DWORD)0xFFFFFFFF)")]
    public const uint INVALID_FILE_SIZE = ((uint)(0xFFFFFFFF));

    [NativeTypeName("#define INVALID_SET_FILE_POINTER ((DWORD)-1)")]
    public const uint INVALID_SET_FILE_POINTER = unchecked((uint)(-1));

    [NativeTypeName("#define INVALID_FILE_ATTRIBUTES ((DWORD)-1)")]
    public const uint INVALID_FILE_ATTRIBUTES = unchecked((uint)(-1));

    [NativeTypeName("#define CreateDirectory CreateDirectoryW")]
    public static delegate*<char*, SECURITY_ATTRIBUTES*, BOOL> CreateDirectory => &CreateDirectoryW;

    [NativeTypeName("#define CreateFile CreateFileW")]
    public static delegate*<char*, uint, uint, SECURITY_ATTRIBUTES*, uint, uint, HANDLE, HANDLE> CreateFile => &CreateFileW;

    [NativeTypeName("#define DefineDosDevice DefineDosDeviceW")]
    public static delegate*<uint, char*, char*, BOOL> DefineDosDevice => &DefineDosDeviceW;

    [NativeTypeName("#define DeleteFile DeleteFileW")]
    public static delegate*<char*, BOOL> DeleteFile => &DeleteFileW;

    [NativeTypeName("#define DeleteVolumeMountPoint DeleteVolumeMountPointW")]
    public static delegate*<char*, BOOL> DeleteVolumeMountPoint => &DeleteVolumeMountPointW;

    [NativeTypeName("#define FindFirstChangeNotification FindFirstChangeNotificationW")]
    public static delegate*<char*, BOOL, uint, HANDLE> FindFirstChangeNotification => &FindFirstChangeNotificationW;

    [NativeTypeName("#define FindFirstFile FindFirstFileW")]
    public static delegate*<char*, WIN32_FIND_DATAW*, HANDLE> FindFirstFile => &FindFirstFileW;

    [NativeTypeName("#define FindFirstFileEx FindFirstFileExW")]
    public static delegate*<char*, FINDEX_INFO_LEVELS, void*, FINDEX_SEARCH_OPS, void*, uint, HANDLE> FindFirstFileEx => &FindFirstFileExW;

    [NativeTypeName("#define FindFirstVolume FindFirstVolumeW")]
    public static delegate*<char*, uint, HANDLE> FindFirstVolume => &FindFirstVolumeW;

    [NativeTypeName("#define FindNextFile FindNextFileW")]
    public static delegate*<HANDLE, WIN32_FIND_DATAW*, BOOL> FindNextFile => &FindNextFileW;

    [NativeTypeName("#define FindNextVolume FindNextVolumeW")]
    public static delegate*<HANDLE, char*, uint, BOOL> FindNextVolume => &FindNextVolumeW;

    [NativeTypeName("#define GetDiskFreeSpace GetDiskFreeSpaceW")]
    public static delegate*<char*, uint*, uint*, uint*, uint*, BOOL> GetDiskFreeSpace => &GetDiskFreeSpaceW;

    [NativeTypeName("#define GetDiskFreeSpaceEx GetDiskFreeSpaceExW")]
    public static delegate*<char*, ULARGE_INTEGER*, ULARGE_INTEGER*, ULARGE_INTEGER*, BOOL> GetDiskFreeSpaceEx => &GetDiskFreeSpaceExW;

    [NativeTypeName("#define GetDiskSpaceInformation GetDiskSpaceInformationW")]
    [SupportedOSPlatform("windows10.0.17763.0")]
    public static delegate*<char*, DISK_SPACE_INFORMATION*, HRESULT> GetDiskSpaceInformation => &GetDiskSpaceInformationW;

    [NativeTypeName("#define GetDriveType GetDriveTypeW")]
    public static delegate*<char*, uint> GetDriveType => &GetDriveTypeW;

    [NativeTypeName("#define GetFileAttributes GetFileAttributesW")]
    public static delegate*<char*, uint> GetFileAttributes => &GetFileAttributesW;

    [NativeTypeName("#define GetFileAttributesEx GetFileAttributesExW")]
    public static delegate*<char*, GET_FILEEX_INFO_LEVELS, void*, BOOL> GetFileAttributesEx => &GetFileAttributesExW;

    [NativeTypeName("#define GetFinalPathNameByHandle GetFinalPathNameByHandleW")]
    public static delegate*<HANDLE, char*, uint, uint, uint> GetFinalPathNameByHandle => &GetFinalPathNameByHandleW;

    [NativeTypeName("#define GetFullPathName GetFullPathNameW")]
    public static delegate*<char*, uint, char*, char**, uint> GetFullPathName => &GetFullPathNameW;

    [NativeTypeName("#define GetLogicalDriveStrings GetLogicalDriveStringsW")]
    public static delegate*<uint, char*, uint> GetLogicalDriveStrings => &GetLogicalDriveStringsW;

    [NativeTypeName("#define GetLongPathName GetLongPathNameW")]
    public static delegate*<char*, char*, uint, uint> GetLongPathName => &GetLongPathNameW;

    [NativeTypeName("#define GetShortPathName GetShortPathNameW")]
    public static delegate*<char*, char*, uint, uint> GetShortPathName => &GetShortPathNameW;

    [NativeTypeName("#define GetTempFileName GetTempFileNameW")]
    public static delegate*<char*, char*, uint, char*, uint> GetTempFileName => &GetTempFileNameW;

    [NativeTypeName("#define GetVolumeInformation GetVolumeInformationW")]
    public static delegate*<char*, char*, uint, uint*, uint*, uint*, char*, uint, BOOL> GetVolumeInformation => &GetVolumeInformationW;

    [NativeTypeName("#define GetVolumePathName GetVolumePathNameW")]
    public static delegate*<char*, char*, uint, BOOL> GetVolumePathName => &GetVolumePathNameW;

    [NativeTypeName("#define QueryDosDevice QueryDosDeviceW")]
    public static delegate*<char*, char*, uint, uint> QueryDosDevice => &QueryDosDeviceW;

    [NativeTypeName("#define RemoveDirectory RemoveDirectoryW")]
    public static delegate*<char*, BOOL> RemoveDirectory => &RemoveDirectoryW;

    [NativeTypeName("#define SetFileAttributes SetFileAttributesW")]
    public static delegate*<char*, uint, BOOL> SetFileAttributes => &SetFileAttributesW;

    [NativeTypeName("#define GetTempPath GetTempPathW")]
    public static delegate*<uint, char*, uint> GetTempPath => &GetTempPathW;

    [NativeTypeName("#define GetVolumeNameForVolumeMountPoint GetVolumeNameForVolumeMountPointW")]
    public static delegate*<char*, char*, uint, BOOL> GetVolumeNameForVolumeMountPoint => &GetVolumeNameForVolumeMountPointW;

    [NativeTypeName("#define GetVolumePathNamesForVolumeName GetVolumePathNamesForVolumeNameW")]
    public static delegate*<char*, char*, uint, uint*, BOOL> GetVolumePathNamesForVolumeName => &GetVolumePathNamesForVolumeNameW;

    [NativeTypeName("#define GetCompressedFileSize GetCompressedFileSizeW")]
    public static delegate*<char*, uint*, uint> GetCompressedFileSize => &GetCompressedFileSizeW;

    [NativeTypeName("#define GetTempPath2 GetTempPath2W")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static delegate*<uint, char*, uint> GetTempPath2 => &GetTempPath2W;
}
