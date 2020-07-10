// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/winstring.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("ComBase", EntryPoint = "WindowsCreateString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsCreateString([NativeTypeName("PCNZWCH")] ushort* sourceString, [NativeTypeName("UINT32")] uint length, [NativeTypeName("HSTRING *")] IntPtr* @string);

        [DllImport("ComBase", EntryPoint = "WindowsCreateStringReference", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsCreateStringReference([NativeTypeName("PCWSTR")] ushort* sourceString, [NativeTypeName("UINT32")] uint length, [NativeTypeName("HSTRING_HEADER *")] HSTRING_HEADER* hstringHeader, [NativeTypeName("HSTRING *")] IntPtr* @string);

        [DllImport("ComBase", EntryPoint = "WindowsDeleteString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsDeleteString([NativeTypeName("HSTRING")] IntPtr @string);

        [DllImport("ComBase", EntryPoint = "WindowsDuplicateString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsDuplicateString([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("ComBase", EntryPoint = "WindowsGetStringLen", ExactSpelling = true)]
        [return: NativeTypeName("UINT32")]
        public static extern uint WindowsGetStringLen([NativeTypeName("HSTRING")] IntPtr @string);

        [DllImport("ComBase", EntryPoint = "WindowsGetStringRawBuffer", ExactSpelling = true)]
        [return: NativeTypeName("PCWSTR")]
        public static extern ushort* WindowsGetStringRawBuffer([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("UINT32 *")] uint* length);

        [DllImport("ComBase", EntryPoint = "WindowsIsStringEmpty", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WindowsIsStringEmpty([NativeTypeName("HSTRING")] IntPtr @string);

        [DllImport("ComBase", EntryPoint = "WindowsStringHasEmbeddedNull", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsStringHasEmbeddedNull([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("BOOL *")] int* hasEmbedNull);

        [DllImport("ComBase", EntryPoint = "WindowsCompareStringOrdinal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsCompareStringOrdinal([NativeTypeName("HSTRING")] IntPtr string1, [NativeTypeName("HSTRING")] IntPtr string2, [NativeTypeName("INT32 *")] int* result);

        [DllImport("ComBase", EntryPoint = "WindowsSubstring", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsSubstring([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("ComBase", EntryPoint = "WindowsSubstringWithSpecifiedLength", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsSubstringWithSpecifiedLength([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("UINT32")] uint startIndex, [NativeTypeName("UINT32")] uint length, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("ComBase", EntryPoint = "WindowsConcatString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsConcatString([NativeTypeName("HSTRING")] IntPtr string1, [NativeTypeName("HSTRING")] IntPtr string2, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("ComBase", EntryPoint = "WindowsReplaceString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsReplaceString([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("HSTRING")] IntPtr stringReplaced, [NativeTypeName("HSTRING")] IntPtr stringReplaceWith, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("ComBase", EntryPoint = "WindowsTrimStringStart", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsTrimStringStart([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("HSTRING")] IntPtr trimString, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("ComBase", EntryPoint = "WindowsTrimStringEnd", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsTrimStringEnd([NativeTypeName("HSTRING")] IntPtr @string, [NativeTypeName("HSTRING")] IntPtr trimString, [NativeTypeName("HSTRING *")] IntPtr* newString);

        [DllImport("ComBase", EntryPoint = "WindowsPreallocateStringBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsPreallocateStringBuffer([NativeTypeName("UINT32")] uint length, [NativeTypeName("WCHAR **")] ushort** charBuffer, [NativeTypeName("HSTRING_BUFFER *")] IntPtr* bufferHandle);

        [DllImport("ComBase", EntryPoint = "WindowsPromoteStringBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsPromoteStringBuffer([NativeTypeName("HSTRING_BUFFER")] IntPtr bufferHandle, [NativeTypeName("HSTRING *")] IntPtr* @string);

        [DllImport("ComBase", EntryPoint = "WindowsDeleteStringBuffer", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsDeleteStringBuffer([NativeTypeName("HSTRING_BUFFER")] IntPtr bufferHandle);

        [DllImport("ComBase", EntryPoint = "WindowsInspectString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsInspectString([NativeTypeName("UINT_PTR")] nuint targetHString, [NativeTypeName("USHORT")] ushort machine, [NativeTypeName("PINSPECT_HSTRING_CALLBACK")] delegate* stdcall<void*, nuint, uint, byte*, int> callback, [NativeTypeName("void *")] void* context, [NativeTypeName("UINT32 *")] uint* length, [NativeTypeName("UINT_PTR *")] nuint* targetStringAddress);

        [DllImport("ComBase", EntryPoint = "WindowsInspectString2", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int WindowsInspectString2([NativeTypeName("UINT64")] ulong targetHString, [NativeTypeName("USHORT")] ushort machine, [NativeTypeName("PINSPECT_HSTRING_CALLBACK2")] delegate* stdcall<void*, ulong, uint, byte*, int> callback, [NativeTypeName("void *")] void* context, [NativeTypeName("UINT32 *")] uint* length, [NativeTypeName("UINT64 *")] ulong* targetStringAddress);
    }
}
