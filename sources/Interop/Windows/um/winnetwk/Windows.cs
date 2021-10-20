// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetAddConnectionA([NativeTypeName("LPCSTR")] sbyte* lpRemoteName, [NativeTypeName("LPCSTR")] sbyte* lpPassword, [NativeTypeName("LPCSTR")] sbyte* lpLocalName);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetAddConnectionW([NativeTypeName("LPCWSTR")] ushort* lpRemoteName, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("LPCWSTR")] ushort* lpLocalName);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetAddConnection2A([NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPCSTR")] sbyte* lpPassword, [NativeTypeName("LPCSTR")] sbyte* lpUserName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetAddConnection2W([NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("LPCWSTR")] ushort* lpUserName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetAddConnection3A([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPCSTR")] sbyte* lpPassword, [NativeTypeName("LPCSTR")] sbyte* lpUserName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetAddConnection3W([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("LPCWSTR")] ushort* lpUserName, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetAddConnection4A([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE")] byte* lpUseOptions, [NativeTypeName("DWORD")] uint cbUseOptions);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetAddConnection4W([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE")] byte* lpUseOptions, [NativeTypeName("DWORD")] uint cbUseOptions);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetCancelConnectionA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("BOOL")] int fForce);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetCancelConnectionW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("BOOL")] int fForce);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetCancelConnection2A([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fForce);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetCancelConnection2W([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("BOOL")] int fForce);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetConnectionA([NativeTypeName("LPCSTR")] sbyte* lpLocalName, [NativeTypeName("LPSTR")] sbyte* lpRemoteName, [NativeTypeName("LPDWORD")] uint* lpnLength);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetConnectionW([NativeTypeName("LPCWSTR")] ushort* lpLocalName, [NativeTypeName("LPWSTR")] ushort* lpRemoteName, [NativeTypeName("LPDWORD")] uint* lpnLength);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetRestoreSingleConnectionW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCWSTR")] ushort* lpDevice, [NativeTypeName("BOOL")] int fUseUI);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetUseConnectionA([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPCSTR")] sbyte* lpPassword, [NativeTypeName("LPCSTR")] sbyte* lpUserId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* lpAccessName, [NativeTypeName("LPDWORD")] uint* lpBufferSize, [NativeTypeName("LPDWORD")] uint* lpResult);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetUseConnectionW([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("LPCWSTR")] ushort* lpUserId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* lpAccessName, [NativeTypeName("LPDWORD")] uint* lpBufferSize, [NativeTypeName("LPDWORD")] uint* lpResult);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetUseConnection4A([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE")] byte* lpUseOptions, [NativeTypeName("DWORD")] uint cbUseOptions, [NativeTypeName("LPSTR")] sbyte* lpAccessName, [NativeTypeName("LPDWORD")] uint* lpBufferSize, [NativeTypeName("LPDWORD")] uint* lpResult);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetUseConnection4W([NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE")] byte* lpUseOptions, [NativeTypeName("DWORD")] uint cbUseOptions, [NativeTypeName("LPWSTR")] ushort* lpAccessName, [NativeTypeName("LPDWORD")] uint* lpBufferSize, [NativeTypeName("LPDWORD")] uint* lpResult);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetConnectionDialog([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwType);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetDisconnectDialog([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint dwType);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetConnectionDialog1A([NativeTypeName("LPCONNECTDLGSTRUCTA")] CONNECTDLGSTRUCTA* lpConnDlgStruct);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetConnectionDialog1W([NativeTypeName("LPCONNECTDLGSTRUCTW")] CONNECTDLGSTRUCTW* lpConnDlgStruct);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetDisconnectDialog1A([NativeTypeName("LPDISCDLGSTRUCTA")] DISCDLGSTRUCTA* lpConnDlgStruct);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetDisconnectDialog1W([NativeTypeName("LPDISCDLGSTRUCTW")] DISCDLGSTRUCTW* lpConnDlgStruct);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetOpenEnumA([NativeTypeName("DWORD")] uint dwScope, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwUsage, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPHANDLE")] IntPtr* lphEnum);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetOpenEnumW([NativeTypeName("DWORD")] uint dwScope, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwUsage, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPHANDLE")] IntPtr* lphEnum);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetEnumResourceA([NativeTypeName("HANDLE")] IntPtr hEnum, [NativeTypeName("LPDWORD")] uint* lpcCount, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpBufferSize);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetEnumResourceW([NativeTypeName("HANDLE")] IntPtr hEnum, [NativeTypeName("LPDWORD")] uint* lpcCount, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpBufferSize);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetCloseEnum([NativeTypeName("HANDLE")] IntPtr hEnum);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetResourceParentA([NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpcbBuffer);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetResourceParentW([NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpcbBuffer);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetResourceInformationA([NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpcbBuffer, [NativeTypeName("LPSTR *")] sbyte** lplpSystem);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetResourceInformationW([NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpcbBuffer, [NativeTypeName("LPWSTR *")] ushort** lplpSystem);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetUniversalNameA([NativeTypeName("LPCSTR")] sbyte* lpLocalPath, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpBufferSize);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetUniversalNameW([NativeTypeName("LPCWSTR")] ushort* lpLocalPath, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpBufferSize);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetUserA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpUserName, [NativeTypeName("LPDWORD")] uint* lpnLength);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetUserW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPWSTR")] ushort* lpUserName, [NativeTypeName("LPDWORD")] uint* lpnLength);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetProviderNameA([NativeTypeName("DWORD")] uint dwNetType, [NativeTypeName("LPSTR")] sbyte* lpProviderName, [NativeTypeName("LPDWORD")] uint* lpBufferSize);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetProviderNameW([NativeTypeName("DWORD")] uint dwNetType, [NativeTypeName("LPWSTR")] ushort* lpProviderName, [NativeTypeName("LPDWORD")] uint* lpBufferSize);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetNetworkInformationA([NativeTypeName("LPCSTR")] sbyte* lpProvider, [NativeTypeName("LPNETINFOSTRUCT")] NETINFOSTRUCT* lpNetInfoStruct);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetNetworkInformationW([NativeTypeName("LPCWSTR")] ushort* lpProvider, [NativeTypeName("LPNETINFOSTRUCT")] NETINFOSTRUCT* lpNetInfoStruct);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetLastErrorA([NativeTypeName("LPDWORD")] uint* lpError, [NativeTypeName("LPSTR")] sbyte* lpErrorBuf, [NativeTypeName("DWORD")] uint nErrorBufSize, [NativeTypeName("LPSTR")] sbyte* lpNameBuf, [NativeTypeName("DWORD")] uint nNameBufSize);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint WNetGetLastErrorW([NativeTypeName("LPDWORD")] uint* lpError, [NativeTypeName("LPWSTR")] ushort* lpErrorBuf, [NativeTypeName("DWORD")] uint nErrorBufSize, [NativeTypeName("LPWSTR")] ushort* lpNameBuf, [NativeTypeName("DWORD")] uint nNameBufSize);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MultinetGetConnectionPerformanceA([NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPNETCONNECTINFOSTRUCT")] NETCONNECTINFOSTRUCT* lpNetConnectInfoStruct);

        [DllImport("mpr", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint MultinetGetConnectionPerformanceW([NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPNETCONNECTINFOSTRUCT")] NETCONNECTINFOSTRUCT* lpNetConnectInfoStruct);

        [NativeTypeName("#define RESOURCE_CONNECTED 0x00000001")]
        public const int RESOURCE_CONNECTED = 0x00000001;

        [NativeTypeName("#define RESOURCE_GLOBALNET 0x00000002")]
        public const int RESOURCE_GLOBALNET = 0x00000002;

        [NativeTypeName("#define RESOURCE_REMEMBERED 0x00000003")]
        public const int RESOURCE_REMEMBERED = 0x00000003;

        [NativeTypeName("#define RESOURCE_RECENT 0x00000004")]
        public const int RESOURCE_RECENT = 0x00000004;

        [NativeTypeName("#define RESOURCE_CONTEXT 0x00000005")]
        public const int RESOURCE_CONTEXT = 0x00000005;

        [NativeTypeName("#define RESOURCETYPE_ANY 0x00000000")]
        public const int RESOURCETYPE_ANY = 0x00000000;

        [NativeTypeName("#define RESOURCETYPE_DISK 0x00000001")]
        public const int RESOURCETYPE_DISK = 0x00000001;

        [NativeTypeName("#define RESOURCETYPE_PRINT 0x00000002")]
        public const int RESOURCETYPE_PRINT = 0x00000002;

        [NativeTypeName("#define RESOURCETYPE_RESERVED 0x00000008")]
        public const int RESOURCETYPE_RESERVED = 0x00000008;

        [NativeTypeName("#define RESOURCETYPE_UNKNOWN 0xFFFFFFFF")]
        public const uint RESOURCETYPE_UNKNOWN = 0xFFFFFFFF;

        [NativeTypeName("#define RESOURCEUSAGE_CONNECTABLE 0x00000001")]
        public const int RESOURCEUSAGE_CONNECTABLE = 0x00000001;

        [NativeTypeName("#define RESOURCEUSAGE_CONTAINER 0x00000002")]
        public const int RESOURCEUSAGE_CONTAINER = 0x00000002;

        [NativeTypeName("#define RESOURCEUSAGE_NOLOCALDEVICE 0x00000004")]
        public const int RESOURCEUSAGE_NOLOCALDEVICE = 0x00000004;

        [NativeTypeName("#define RESOURCEUSAGE_SIBLING 0x00000008")]
        public const int RESOURCEUSAGE_SIBLING = 0x00000008;

        [NativeTypeName("#define RESOURCEUSAGE_ATTACHED 0x00000010")]
        public const int RESOURCEUSAGE_ATTACHED = 0x00000010;

        [NativeTypeName("#define RESOURCEUSAGE_ALL (RESOURCEUSAGE_CONNECTABLE | RESOURCEUSAGE_CONTAINER | RESOURCEUSAGE_ATTACHED)")]
        public const int RESOURCEUSAGE_ALL = (0x00000001 | 0x00000002 | 0x00000010);

        [NativeTypeName("#define RESOURCEUSAGE_RESERVED 0x80000000")]
        public const uint RESOURCEUSAGE_RESERVED = 0x80000000;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_GENERIC 0x00000000")]
        public const int RESOURCEDISPLAYTYPE_GENERIC = 0x00000000;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_DOMAIN 0x00000001")]
        public const int RESOURCEDISPLAYTYPE_DOMAIN = 0x00000001;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_SERVER 0x00000002")]
        public const int RESOURCEDISPLAYTYPE_SERVER = 0x00000002;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_SHARE 0x00000003")]
        public const int RESOURCEDISPLAYTYPE_SHARE = 0x00000003;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_FILE 0x00000004")]
        public const int RESOURCEDISPLAYTYPE_FILE = 0x00000004;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_GROUP 0x00000005")]
        public const int RESOURCEDISPLAYTYPE_GROUP = 0x00000005;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_NETWORK 0x00000006")]
        public const int RESOURCEDISPLAYTYPE_NETWORK = 0x00000006;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_ROOT 0x00000007")]
        public const int RESOURCEDISPLAYTYPE_ROOT = 0x00000007;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_SHAREADMIN 0x00000008")]
        public const int RESOURCEDISPLAYTYPE_SHAREADMIN = 0x00000008;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_DIRECTORY 0x00000009")]
        public const int RESOURCEDISPLAYTYPE_DIRECTORY = 0x00000009;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_TREE 0x0000000A")]
        public const int RESOURCEDISPLAYTYPE_TREE = 0x0000000A;

        [NativeTypeName("#define RESOURCEDISPLAYTYPE_NDSCONTAINER 0x0000000B")]
        public const int RESOURCEDISPLAYTYPE_NDSCONTAINER = 0x0000000B;

        [NativeTypeName("#define NETPROPERTY_PERSISTENT 1")]
        public const int NETPROPERTY_PERSISTENT = 1;

        [NativeTypeName("#define CONNECT_UPDATE_PROFILE 0x00000001")]
        public const int CONNECT_UPDATE_PROFILE = 0x00000001;

        [NativeTypeName("#define CONNECT_UPDATE_RECENT 0x00000002")]
        public const int CONNECT_UPDATE_RECENT = 0x00000002;

        [NativeTypeName("#define CONNECT_TEMPORARY 0x00000004")]
        public const int CONNECT_TEMPORARY = 0x00000004;

        [NativeTypeName("#define CONNECT_INTERACTIVE 0x00000008")]
        public const int CONNECT_INTERACTIVE = 0x00000008;

        [NativeTypeName("#define CONNECT_PROMPT 0x00000010")]
        public const int CONNECT_PROMPT = 0x00000010;

        [NativeTypeName("#define CONNECT_NEED_DRIVE 0x00000020")]
        public const int CONNECT_NEED_DRIVE = 0x00000020;

        [NativeTypeName("#define CONNECT_REFCOUNT 0x00000040")]
        public const int CONNECT_REFCOUNT = 0x00000040;

        [NativeTypeName("#define CONNECT_REDIRECT 0x00000080")]
        public const int CONNECT_REDIRECT = 0x00000080;

        [NativeTypeName("#define CONNECT_LOCALDRIVE 0x00000100")]
        public const int CONNECT_LOCALDRIVE = 0x00000100;

        [NativeTypeName("#define CONNECT_CURRENT_MEDIA 0x00000200")]
        public const int CONNECT_CURRENT_MEDIA = 0x00000200;

        [NativeTypeName("#define CONNECT_DEFERRED 0x00000400")]
        public const int CONNECT_DEFERRED = 0x00000400;

        [NativeTypeName("#define CONNECT_RESERVED 0xFF000000")]
        public const uint CONNECT_RESERVED = 0xFF000000;

        [NativeTypeName("#define CONNECT_COMMANDLINE 0x00000800")]
        public const int CONNECT_COMMANDLINE = 0x00000800;

        [NativeTypeName("#define CONNECT_CMD_SAVECRED 0x00001000")]
        public const int CONNECT_CMD_SAVECRED = 0x00001000;

        [NativeTypeName("#define CONNECT_CRED_RESET 0x00002000")]
        public const int CONNECT_CRED_RESET = 0x00002000;

        [NativeTypeName("#define CONNECT_REQUIRE_INTEGRITY 0x00004000")]
        public const int CONNECT_REQUIRE_INTEGRITY = 0x00004000;

        [NativeTypeName("#define CONNECT_REQUIRE_PRIVACY 0x00008000")]
        public const int CONNECT_REQUIRE_PRIVACY = 0x00008000;

        [NativeTypeName("#define CONNECT_WRITE_THROUGH_SEMANTICS 0x00010000")]
        public const int CONNECT_WRITE_THROUGH_SEMANTICS = 0x00010000;

        [NativeTypeName("#define CONNECT_GLOBAL_MAPPING 0x00040000")]
        public const int CONNECT_GLOBAL_MAPPING = 0x00040000;

        [NativeTypeName("#define WNetAddConnection WNetAddConnectionW")]
        public static delegate*<ushort*, ushort*, ushort*, uint> WNetAddConnection => &WNetAddConnectionW;

        [NativeTypeName("#define WNetAddConnection2 WNetAddConnection2W")]
        public static delegate*<NETRESOURCEW*, ushort*, ushort*, uint, uint> WNetAddConnection2 => &WNetAddConnection2W;

        [NativeTypeName("#define WNetAddConnection3 WNetAddConnection3W")]
        public static delegate*<IntPtr, NETRESOURCEW*, ushort*, ushort*, uint, uint> WNetAddConnection3 => &WNetAddConnection3W;

        [NativeTypeName("#define WNetAddConnection4 WNetAddConnection4W")]
        public static delegate*<IntPtr, NETRESOURCEW*, void*, uint, uint, byte*, uint, uint> WNetAddConnection4 => &WNetAddConnection4W;

        [NativeTypeName("#define WNetCancelConnection WNetCancelConnectionW")]
        public static delegate*<ushort*, int, uint> WNetCancelConnection => &WNetCancelConnectionW;

        [NativeTypeName("#define WNetCancelConnection2 WNetCancelConnection2W")]
        public static delegate*<ushort*, uint, int, uint> WNetCancelConnection2 => &WNetCancelConnection2W;

        [NativeTypeName("#define WNetGetConnection WNetGetConnectionW")]
        public static delegate*<ushort*, ushort*, uint*, uint> WNetGetConnection => &WNetGetConnectionW;

        [NativeTypeName("#define WNetUseConnection WNetUseConnectionW")]
        public static delegate*<IntPtr, NETRESOURCEW*, ushort*, ushort*, uint, ushort*, uint*, uint*, uint> WNetUseConnection => &WNetUseConnectionW;

        [NativeTypeName("#define WNetUseConnection4 WNetUseConnection4W")]
        public static delegate*<IntPtr, NETRESOURCEW*, void*, uint, uint, byte*, uint, ushort*, uint*, uint*, uint> WNetUseConnection4 => &WNetUseConnection4W;

        [NativeTypeName("#define CONNDLG_RO_PATH 0x00000001")]
        public const int CONNDLG_RO_PATH = 0x00000001;

        [NativeTypeName("#define CONNDLG_CONN_POINT 0x00000002")]
        public const int CONNDLG_CONN_POINT = 0x00000002;

        [NativeTypeName("#define CONNDLG_USE_MRU 0x00000004")]
        public const int CONNDLG_USE_MRU = 0x00000004;

        [NativeTypeName("#define CONNDLG_HIDE_BOX 0x00000008")]
        public const int CONNDLG_HIDE_BOX = 0x00000008;

        [NativeTypeName("#define CONNDLG_PERSIST 0x00000010")]
        public const int CONNDLG_PERSIST = 0x00000010;

        [NativeTypeName("#define CONNDLG_NOT_PERSIST 0x00000020")]
        public const int CONNDLG_NOT_PERSIST = 0x00000020;

        [NativeTypeName("#define WNetConnectionDialog1 WNetConnectionDialog1W")]
        public static delegate*<CONNECTDLGSTRUCTW*, uint> WNetConnectionDialog1 => &WNetConnectionDialog1W;

        [NativeTypeName("#define DISC_UPDATE_PROFILE 0x00000001")]
        public const int DISC_UPDATE_PROFILE = 0x00000001;

        [NativeTypeName("#define DISC_NO_FORCE 0x00000040")]
        public const int DISC_NO_FORCE = 0x00000040;

        [NativeTypeName("#define WNetDisconnectDialog1 WNetDisconnectDialog1W")]
        public static delegate*<DISCDLGSTRUCTW*, uint> WNetDisconnectDialog1 => &WNetDisconnectDialog1W;

        [NativeTypeName("#define WNetOpenEnum WNetOpenEnumW")]
        public static delegate*<uint, uint, uint, NETRESOURCEW*, IntPtr*, uint> WNetOpenEnum => &WNetOpenEnumW;

        [NativeTypeName("#define WNetEnumResource WNetEnumResourceW")]
        public static delegate*<IntPtr, uint*, void*, uint*, uint> WNetEnumResource => &WNetEnumResourceW;

        [NativeTypeName("#define WNetGetResourceParent WNetGetResourceParentW")]
        public static delegate*<NETRESOURCEW*, void*, uint*, uint> WNetGetResourceParent => &WNetGetResourceParentW;

        [NativeTypeName("#define WNetGetResourceInformation WNetGetResourceInformationW")]
        public static delegate*<NETRESOURCEW*, void*, uint*, ushort**, uint> WNetGetResourceInformation => &WNetGetResourceInformationW;

        [NativeTypeName("#define UNIVERSAL_NAME_INFO_LEVEL 0x00000001")]
        public const int UNIVERSAL_NAME_INFO_LEVEL = 0x00000001;

        [NativeTypeName("#define REMOTE_NAME_INFO_LEVEL 0x00000002")]
        public const int REMOTE_NAME_INFO_LEVEL = 0x00000002;

        [NativeTypeName("#define WNetGetUniversalName WNetGetUniversalNameW")]
        public static delegate*<ushort*, uint, void*, uint*, uint> WNetGetUniversalName => &WNetGetUniversalNameW;

        [NativeTypeName("#define WNetGetUser WNetGetUserW")]
        public static delegate*<ushort*, ushort*, uint*, uint> WNetGetUser => &WNetGetUserW;

        [NativeTypeName("#define WNFMT_MULTILINE 0x01")]
        public const int WNFMT_MULTILINE = 0x01;

        [NativeTypeName("#define WNFMT_ABBREVIATED 0x02")]
        public const int WNFMT_ABBREVIATED = 0x02;

        [NativeTypeName("#define WNFMT_INENUM 0x10")]
        public const int WNFMT_INENUM = 0x10;

        [NativeTypeName("#define WNFMT_CONNECTION 0x20")]
        public const int WNFMT_CONNECTION = 0x20;

        [NativeTypeName("#define WNetGetProviderName WNetGetProviderNameW")]
        public static delegate*<uint, ushort*, uint*, uint> WNetGetProviderName => &WNetGetProviderNameW;

        [NativeTypeName("#define NETINFO_DLL16 0x00000001")]
        public const int NETINFO_DLL16 = 0x00000001;

        [NativeTypeName("#define NETINFO_DISKRED 0x00000004")]
        public const int NETINFO_DISKRED = 0x00000004;

        [NativeTypeName("#define NETINFO_PRINTERRED 0x00000008")]
        public const int NETINFO_PRINTERRED = 0x00000008;

        [NativeTypeName("#define WNetGetNetworkInformation WNetGetNetworkInformationW")]
        public static delegate*<ushort*, NETINFOSTRUCT*, uint> WNetGetNetworkInformation => &WNetGetNetworkInformationW;

        [NativeTypeName("#define WNetGetLastError WNetGetLastErrorW")]
        public static delegate*<uint*, ushort*, uint, ushort*, uint, uint> WNetGetLastError => &WNetGetLastErrorW;

        [NativeTypeName("#define WN_SUCCESS NO_ERROR")]
        public const int WN_SUCCESS = 0;

        [NativeTypeName("#define WN_NO_ERROR NO_ERROR")]
        public const int WN_NO_ERROR = 0;

        [NativeTypeName("#define WN_NOT_SUPPORTED ERROR_NOT_SUPPORTED")]
        public const int WN_NOT_SUPPORTED = 50;

        [NativeTypeName("#define WN_CANCEL ERROR_CANCELLED")]
        public const int WN_CANCEL = 1223;

        [NativeTypeName("#define WN_RETRY ERROR_RETRY")]
        public const int WN_RETRY = 1237;

        [NativeTypeName("#define WN_NET_ERROR ERROR_UNEXP_NET_ERR")]
        public const int WN_NET_ERROR = 59;

        [NativeTypeName("#define WN_MORE_DATA ERROR_MORE_DATA")]
        public const int WN_MORE_DATA = 234;

        [NativeTypeName("#define WN_BAD_POINTER ERROR_INVALID_ADDRESS")]
        public const int WN_BAD_POINTER = 487;

        [NativeTypeName("#define WN_BAD_VALUE ERROR_INVALID_PARAMETER")]
        public const int WN_BAD_VALUE = 87;

        [NativeTypeName("#define WN_BAD_USER ERROR_BAD_USERNAME")]
        public const int WN_BAD_USER = 2202;

        [NativeTypeName("#define WN_BAD_PASSWORD ERROR_INVALID_PASSWORD")]
        public const int WN_BAD_PASSWORD = 86;

        [NativeTypeName("#define WN_ACCESS_DENIED ERROR_ACCESS_DENIED")]
        public const int WN_ACCESS_DENIED = 5;

        [NativeTypeName("#define WN_FUNCTION_BUSY ERROR_BUSY")]
        public const int WN_FUNCTION_BUSY = 170;

        [NativeTypeName("#define WN_WINDOWS_ERROR ERROR_UNEXP_NET_ERR")]
        public const int WN_WINDOWS_ERROR = 59;

        [NativeTypeName("#define WN_OUT_OF_MEMORY ERROR_NOT_ENOUGH_MEMORY")]
        public const int WN_OUT_OF_MEMORY = 8;

        [NativeTypeName("#define WN_NO_NETWORK ERROR_NO_NETWORK")]
        public const int WN_NO_NETWORK = 1222;

        [NativeTypeName("#define WN_EXTENDED_ERROR ERROR_EXTENDED_ERROR")]
        public const int WN_EXTENDED_ERROR = 1208;

        [NativeTypeName("#define WN_BAD_LEVEL ERROR_INVALID_LEVEL")]
        public const int WN_BAD_LEVEL = 124;

        [NativeTypeName("#define WN_BAD_HANDLE ERROR_INVALID_HANDLE")]
        public const int WN_BAD_HANDLE = 6;

        [NativeTypeName("#define WN_NOT_INITIALIZING ERROR_ALREADY_INITIALIZED")]
        public const int WN_NOT_INITIALIZING = 1247;

        [NativeTypeName("#define WN_NO_MORE_DEVICES ERROR_NO_MORE_DEVICES")]
        public const int WN_NO_MORE_DEVICES = 1248;

        [NativeTypeName("#define WN_NOT_CONNECTED ERROR_NOT_CONNECTED")]
        public const int WN_NOT_CONNECTED = 2250;

        [NativeTypeName("#define WN_OPEN_FILES ERROR_OPEN_FILES")]
        public const int WN_OPEN_FILES = 2401;

        [NativeTypeName("#define WN_DEVICE_IN_USE ERROR_DEVICE_IN_USE")]
        public const int WN_DEVICE_IN_USE = 2404;

        [NativeTypeName("#define WN_BAD_NETNAME ERROR_BAD_NET_NAME")]
        public const int WN_BAD_NETNAME = 67;

        [NativeTypeName("#define WN_BAD_LOCALNAME ERROR_BAD_DEVICE")]
        public const int WN_BAD_LOCALNAME = 1200;

        [NativeTypeName("#define WN_ALREADY_CONNECTED ERROR_ALREADY_ASSIGNED")]
        public const int WN_ALREADY_CONNECTED = 85;

        [NativeTypeName("#define WN_DEVICE_ERROR ERROR_GEN_FAILURE")]
        public const int WN_DEVICE_ERROR = 31;

        [NativeTypeName("#define WN_CONNECTION_CLOSED ERROR_CONNECTION_UNAVAIL")]
        public const int WN_CONNECTION_CLOSED = 1201;

        [NativeTypeName("#define WN_NO_NET_OR_BAD_PATH ERROR_NO_NET_OR_BAD_PATH")]
        public const int WN_NO_NET_OR_BAD_PATH = 1203;

        [NativeTypeName("#define WN_BAD_PROVIDER ERROR_BAD_PROVIDER")]
        public const int WN_BAD_PROVIDER = 1204;

        [NativeTypeName("#define WN_CANNOT_OPEN_PROFILE ERROR_CANNOT_OPEN_PROFILE")]
        public const int WN_CANNOT_OPEN_PROFILE = 1205;

        [NativeTypeName("#define WN_BAD_PROFILE ERROR_BAD_PROFILE")]
        public const int WN_BAD_PROFILE = 1206;

        [NativeTypeName("#define WN_BAD_DEV_TYPE ERROR_BAD_DEV_TYPE")]
        public const int WN_BAD_DEV_TYPE = 66;

        [NativeTypeName("#define WN_DEVICE_ALREADY_REMEMBERED ERROR_DEVICE_ALREADY_REMEMBERED")]
        public const int WN_DEVICE_ALREADY_REMEMBERED = 1202;

        [NativeTypeName("#define WN_CONNECTED_OTHER_PASSWORD ERROR_CONNECTED_OTHER_PASSWORD")]
        public const int WN_CONNECTED_OTHER_PASSWORD = 2108;

        [NativeTypeName("#define WN_CONNECTED_OTHER_PASSWORD_DEFAULT ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT")]
        public const int WN_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109;

        [NativeTypeName("#define WN_NO_MORE_ENTRIES ERROR_NO_MORE_ITEMS")]
        public const int WN_NO_MORE_ENTRIES = 259;

        [NativeTypeName("#define WN_NOT_CONTAINER ERROR_NOT_CONTAINER")]
        public const int WN_NOT_CONTAINER = 1207;

        [NativeTypeName("#define WN_NOT_AUTHENTICATED ERROR_NOT_AUTHENTICATED")]
        public const int WN_NOT_AUTHENTICATED = 1244;

        [NativeTypeName("#define WN_NOT_LOGGED_ON ERROR_NOT_LOGGED_ON")]
        public const int WN_NOT_LOGGED_ON = 1245;

        [NativeTypeName("#define WN_NOT_VALIDATED ERROR_NO_LOGON_SERVERS")]
        public const int WN_NOT_VALIDATED = 1311;

        [NativeTypeName("#define WNCON_FORNETCARD 0x00000001")]
        public const int WNCON_FORNETCARD = 0x00000001;

        [NativeTypeName("#define WNCON_NOTROUTED 0x00000002")]
        public const int WNCON_NOTROUTED = 0x00000002;

        [NativeTypeName("#define WNCON_SLOWLINK 0x00000004")]
        public const int WNCON_SLOWLINK = 0x00000004;

        [NativeTypeName("#define WNCON_DYNAMIC 0x00000008")]
        public const int WNCON_DYNAMIC = 0x00000008;

        [NativeTypeName("#define MultinetGetConnectionPerformance MultinetGetConnectionPerformanceW")]
        public static delegate*<NETRESOURCEW*, NETCONNECTINFOSTRUCT*, uint> MultinetGetConnectionPerformance => &MultinetGetConnectionPerformanceW;
    }
}
