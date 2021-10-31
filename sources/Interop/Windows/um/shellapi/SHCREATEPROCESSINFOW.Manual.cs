// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SHCREATEPROCESSINFOW
    {
        public static uint SizeOf
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SHCREATEPROCESSINFO32W));
                }
                else
                {
                    return (uint)(sizeof(SHCREATEPROCESSINFO64W));
                }
            }
        }

        [FieldOffset(0)]
        public SHCREATEPROCESSINFO32W _value32;

        [FieldOffset(0)]
        public SHCREATEPROCESSINFO64W _value64;

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

        [NativeTypeName("LPCWSTR")]
        public ref ushort* pszFile
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszFile;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszFile;
                }
            }
        }

        [NativeTypeName("LPCWSTR")]
        public ref ushort* pszParameters
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszParameters;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszParameters;
                }
            }
        }

        [NativeTypeName("LPCWSTR")]
        public ref ushort* pszCurrentDirectory
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszCurrentDirectory;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszCurrentDirectory;
                }
            }
        }

        public ref HANDLE hUserToken
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.hUserToken, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.hUserToken, 1));
                }
            }
        }

        [NativeTypeName("LPSECURITY_ATTRIBUTES")]
        public ref SECURITY_ATTRIBUTES* lpProcessAttributes
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpProcessAttributes;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpProcessAttributes;
                }
            }
        }

        [NativeTypeName("LPSECURITY_ATTRIBUTES")]
        public ref SECURITY_ATTRIBUTES* lpThreadAttributes
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpThreadAttributes;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpThreadAttributes;
                }
            }
        }

        public ref BOOL bInheritHandles
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.bInheritHandles, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.bInheritHandles, 1));
                }
            }
        }

        [NativeTypeName("DWORD")]
        public ref uint dwCreationFlags
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.dwCreationFlags, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.dwCreationFlags, 1));
                }
            }
        }

        [NativeTypeName("LPSTARTUPINFOW")]
        public ref STARTUPINFOW* lpStartupInfo
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpStartupInfo;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpStartupInfo;
                }
            }
        }

        [NativeTypeName("LPPROCESS_INFORMATION")]
        public ref PROCESS_INFORMATION* lpProcessInformation
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).lpProcessInformation;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).lpProcessInformation;
                }
            }
        }
    }
}
