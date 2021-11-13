// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SHELLEXECUTEINFOA
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SHELLEXECUTEINFO32A));
                }
                else
                {
                    return (uint)(sizeof(SHELLEXECUTEINFO64A));
                }
            }
        }

        [FieldOffset(0)]
        public SHELLEXECUTEINFO32A _value32;

        [FieldOffset(0)]
        public SHELLEXECUTEINFO64A _value64;

        [NativeTypeName("DWORD")]
        public ref uint cbSize
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
                }
            }
        }

        [NativeTypeName("ULONG")]
        public ref uint fMask
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.fMask, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.fMask, 1));
                }
            }
        }

        public ref HWND hwnd
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hwnd, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hwnd, 1));
                }
            }
        }

        [NativeTypeName("LPCSTR")]
        public ref sbyte* lpVerb
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpVerb;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpVerb;
                }
            }
        }

        [NativeTypeName("LPCSTR")]
        public ref sbyte* lpFile
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpFile;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpFile;
                }
            }
        }

        [NativeTypeName("LPCSTR")]
        public ref sbyte* lpParameters
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpParameters;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpParameters;
                }
            }
        }

        [NativeTypeName("LPCSTR")]
        public ref sbyte* lpDirectory
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpDirectory;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpDirectory;
                }
            }
        }

        public ref int nShow
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.nShow, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.nShow, 1));
                }
            }
        }

        public ref HINSTANCE hInstApp
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hInstApp, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hInstApp, 1));
                }
            }
        }

        public ref void* lpIDList
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpIDList;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpIDList;
                }
            }
        }

        [NativeTypeName("LPCSTR")]
        public ref sbyte* lpClass
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpClass;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpClass;
                }
            }
        }

        public ref HKEY hkeyClass
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hkeyClass, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hkeyClass, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint dwHotKey
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.dwHotKey, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.dwHotKey, 1));
                }
            }
        }

        public ref HANDLE hProcess
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hProcess, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hProcess, 1));
                }
            }
        }

        public ref HANDLE hIcon
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref _value32.hIcon;
                }
                else
                {
                    return ref _value64.hIcon;
                }
            }
        }

        public ref HANDLE hMonitor
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref _value32.hMonitor;
                }
                else
                {
                    return ref _value64.hMonitor;
                }
            }
        }

    }
}
