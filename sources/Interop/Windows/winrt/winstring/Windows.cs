// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/winstring.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsCreateString([NativeTypeName("PCNZWCH")] ushort* sourceString, [NativeTypeName("UINT32")] uint length, [NativeTypeName("HSTRING *")] IntPtr* @string);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsCreateStringReference([NativeTypeName("PCWSTR")] ushort* sourceString, [NativeTypeName("UINT32")] uint length, HSTRING_HEADER* hstringHeader, [NativeTypeName("HSTRING *")] IntPtr* @string);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsDeleteString([NativeTypeName("HSTRING")] IntPtr @string);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsDuplicateString([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("UINT32")]
        public static extern uint WindowsGetStringLen([NativeTypeName("HSTRING")] IntPtr @string);

        [DllImport("combase", ExactSpelling = true)]
        [return: NativeTypeName("PCWSTR")]
        public static extern ushort* WindowsGetStringRawBuffer([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("UINT32 *")] uint* length);

        [DllImport("combase", ExactSpelling = true)]
        public static extern BOOL WindowsIsStringEmpty([NativeTypeName("HSTRING")] IntPtr @string);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsStringHasEmbeddedNull([NativeTypeName("HSTRING")] IntPtr @string, BOOL* hasEmbedNull);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsCompareStringOrdinal([NativeTypeName("HSTRING")] IntPtr string1, [NativeTypeName("HSTRING")] IntPtr string2, [NativeTypeName("INT32 *")] int* result);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsSubstring([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsSubstringWithSpecifiedLength([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint length, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsConcatString([NativeTypeName("HSTRING")] IntPtr string1, [NativeTypeName("HSTRING")] IntPtr string2, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsReplaceString([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("HSTRING")] IntPtr stringReplaced, [NativeTypeName("HSTRING")] IntPtr stringReplaceWith, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsTrimStringStart([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("HSTRING")] IntPtr trimString, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsTrimStringEnd([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("HSTRING")] IntPtr trimString, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsPreallocateStringBuffer([NativeTypeName("UINT32")] uint length, [NativeTypeName("WCHAR **")] ushort** charBuffer, [NativeTypeName("HSTRING_BUFFER *")] IntPtr* bufferHandle);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsPromoteStringBuffer([NativeTypeName("HSTRING_BUFFER")] IntPtr bufferHandle, [NativeTypeName("HSTRING *")] IntPtr* @string);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsDeleteStringBuffer([NativeTypeName("HSTRING_BUFFER")] IntPtr bufferHandle);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsInspectString([NativeTypeName("UINT_PTR")] nuint targetHString, [NativeTypeName("USHORT")] ushort machine, [NativeTypeName("PINSPECT_HSTRING_CALLBACK")] delegate* unmanaged<void*, nuint, uint, byte*, HRESULT> callback, void* context, [NativeTypeName("UINT32 *")] uint* length, [NativeTypeName("UINT_PTR *")] nuint* targetStringAddress);

        [DllImport("combase", ExactSpelling = true)]
        public static extern HRESULT WindowsInspectString2([NativeTypeName("UINT64")] ulong targetHString, [NativeTypeName("USHORT")] ushort machine, [NativeTypeName("PINSPECT_HSTRING_CALLBACK2")] delegate* unmanaged<void*, ulong, uint, byte*, HRESULT> callback, void* context, [NativeTypeName("UINT32 *")] uint* length, [NativeTypeName("UINT64 *")] ulong* targetStringAddress);
    }
}
