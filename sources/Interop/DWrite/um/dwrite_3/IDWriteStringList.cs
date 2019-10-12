// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a collection of strings indexed by number. An IDWriteStringList is otherwise identical to IDWriteLocalizedStrings except for the semantics, where localized strings are indexed on language (each language has one string property) whereas a string list may contain multiple strings of the same language, such as a string list of family names from a font set. You can QueryInterface from an IDWriteLocalizedStrings to an IDWriteStringList.</summary>
    [Guid("CFEE3140-1157-47CA-8B85-31BFCF3F2D0E")]
    public unsafe partial struct IDWriteStringList
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteStringList* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteStringList* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteStringList* This);

        /// <summary>Gets the number of strings.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetCount(IDWriteStringList* This);

        /// <summary>Gets the length in characters (not including the null terminator) of the locale name with the specified index.</summary>
        /// <param name="listIndex">Zero-based index of the locale name.</param>
        /// <param name="length">Receives the length in characters, not including the null terminator.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleNameLength(IDWriteStringList* This, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32")] uint* length);

        /// <summary>Copies the locale name with the specified index to the specified array.</summary>
        /// <param name="listIndex">Zero-based index of the locale name.</param>
        /// <param name="localeName">Character array that receives the locale name.</param>
        /// <param name="size">Size of the array in characters. The size must include space for the terminating null character.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteStringList* This, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint size);

        /// <summary>Gets the length in characters (not including the null terminator) of the string with the specified index.</summary>
        /// <param name="listIndex">Zero-based index of the string.</param>
        /// <param name="length">Receives the length in characters, not including the null terminator.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStringLength(IDWriteStringList* This, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32")] uint* length);

        /// <summary>Copies the string with the specified index to the specified array.</summary>
        /// <param name="listIndex">Zero-based index of the string.</param>
        /// <param name="stringBuffer">Character array that receives the string.</param>
        /// <param name="stringBufferSize">Size of the array in characters. The size must include space for the terminating null character.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetString(IDWriteStringList* This, [NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR[]")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteStringList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteStringList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteStringList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCount()
        {
            fixed (IDWriteStringList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32")] uint* length)
        {
            fixed (IDWriteStringList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)(This, listIndex, length);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint size)
        {
            fixed (IDWriteStringList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)(This, listIndex, localeName, size);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32")] uint* length)
        {
            fixed (IDWriteStringList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStringLength>(lpVtbl->GetStringLength)(This, listIndex, length);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR[]")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize)
        {
            fixed (IDWriteStringList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetString>(lpVtbl->GetString)(This, listIndex, stringBuffer, stringBufferSize);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetCount;

            public IntPtr GetLocaleNameLength;

            public IntPtr GetLocaleName;

            public IntPtr GetStringLength;

            public IntPtr GetString;
        }
    }
}
