// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("url", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TranslateURLA([NativeTypeName("PCSTR")] sbyte* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PSTR *")] sbyte** ppszTranslatedURL);

        [DllImport("url", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int TranslateURLW([NativeTypeName("PCWSTR")] ushort* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("__unaligned PWSTR *")] ushort** ppszTranslatedURL);

        [DllImport("url", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLAssociationDialogA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCSTR")] sbyte* pcszFile, [NativeTypeName("PCSTR")] sbyte* pcszURL, [NativeTypeName("PSTR")] sbyte* pszAppBuf, [NativeTypeName("UINT")] uint ucAppBufLen);

        [DllImport("url", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int URLAssociationDialogW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCWSTR")] ushort* pcszFile, [NativeTypeName("PCWSTR")] ushort* pcszURL, [NativeTypeName("PWSTR")] ushort* pszAppBuf, [NativeTypeName("UINT")] uint ucAppBufLen);

        [DllImport("url", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MIMEAssociationDialogA([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCSTR")] sbyte* pcszFile, [NativeTypeName("PCSTR")] sbyte* pcszMIMEContentType, [NativeTypeName("PSTR")] sbyte* pszAppBuf, [NativeTypeName("UINT")] uint ucAppBufLen);

        [DllImport("url", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int MIMEAssociationDialogW([NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("DWORD")] uint dwInFlags, [NativeTypeName("PCWSTR")] ushort* pcszFile, [NativeTypeName("PCWSTR")] ushort* pcszMIMEContentType, [NativeTypeName("PWSTR")] ushort* pszAppBuf, [NativeTypeName("UINT")] uint ucAppBufLen);

        [DllImport("url", ExactSpelling = true)]
        public static extern BOOL InetIsOffline([NativeTypeName("DWORD")] uint dwFlags);

        [NativeTypeName("#define E_FLAGS MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x1000)")]
        public const int E_FLAGS = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x1000))));

        [NativeTypeName("#define IS_E_EXEC_FAILED MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x2002)")]
        public const int IS_E_EXEC_FAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x2002))));

        [NativeTypeName("#define URL_E_INVALID_SYNTAX MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x1001)")]
        public const int URL_E_INVALID_SYNTAX = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x1001))));

        [NativeTypeName("#define URL_E_UNREGISTERED_PROTOCOL MAKE_SCODE(SEVERITY_ERROR, FACILITY_ITF, 0x1002)")]
        public const int URL_E_UNREGISTERED_PROTOCOL = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x1002))));

        [NativeTypeName("#define TranslateURL TranslateURLW")]
        public static delegate*<ushort*, uint, ushort**, int> TranslateURL => &TranslateURLW;

        [NativeTypeName("#define URLAssociationDialog URLAssociationDialogW")]
        public static delegate*<IntPtr, uint, ushort*, ushort*, ushort*, uint, int> URLAssociationDialog => &URLAssociationDialogW;

        [NativeTypeName("#define MIMEAssociationDialog MIMEAssociationDialogW")]
        public static delegate*<IntPtr, uint, ushort*, ushort*, ushort*, uint, int> MIMEAssociationDialog => &MIMEAssociationDialogW;

        public static ref readonly Guid IID_IUniformResourceLocatorA
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x3B, 0xF2, 0xFB,
                    0xF0, 0xE3,
                    0x1B, 0x10,
                    0x84,
                    0x88,
                    0x00,
                    0xAA,
                    0x00,
                    0x3E,
                    0x56,
                    0xF8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IUniformResourceLocatorW
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x0D, 0xBB, 0xCA,
                    0x57, 0xDA,
                    0xCF, 0x11,
                    0x99,
                    0x74,
                    0x00,
                    0x20,
                    0xAF,
                    0xD7,
                    0x97,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
