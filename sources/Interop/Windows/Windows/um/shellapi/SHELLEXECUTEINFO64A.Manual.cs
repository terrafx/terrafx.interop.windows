// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SHELLEXECUTEINFO64A
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("ULONG")]
        public uint fMask;

        public HWND hwnd;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpVerb;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpFile;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpParameters;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpDirectory;

        public int nShow;

        public HINSTANCE hInstApp;

        public void* lpIDList;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpClass;

        public HKEY hkeyClass;

        [NativeTypeName("DWORD")]
        public uint dwHotKey;

        [NativeTypeName("_SHELLEXECUTEINFOA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/shellapi.h:460:5)")]
        public _Anonymous_e__Union Anonymous;

        public HANDLE hProcess;

        public ref HANDLE hIcon
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hIcon, 1));
            }
        }

        public ref HANDLE hMonitor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hMonitor, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public HANDLE hIcon;

            [FieldOffset(0)]
            public HANDLE hMonitor;
        }
    }
}
