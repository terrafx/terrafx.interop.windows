// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    // <summary>Represents a collection of strings indexed by locale name.</summary>
    [Guid("08256209-099A-4B34-B86D-C22B110E7771")]
    public unsafe partial struct IDWriteLocalizedStrings
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteLocalizedStrings* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteLocalizedStrings* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteLocalizedStrings* This);

        /// <summary>Gets the number of language/string pairs.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetCount(IDWriteLocalizedStrings* This);

        /// <summary>Gets the index of the item with the specified locale name.</summary>
        /// <param name="localeName">Locale name to look for.</param>
        /// <param name="index">Receives the zero-based index of the locale name/string pair.</param>
        /// <param name="exists">Receives TRUE if the locale name exists or FALSE if not.</param>
        /// <returns>Standard HRESULT error code. If the specified locale name does not exist, the return value is S_OK, but *index is UINT_MAX and *exists is FALSE.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindLocaleName(IDWriteLocalizedStrings* This, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint* index, [NativeTypeName("BOOL")] int* exists);

        /// <summary>Gets the length in characters (not including the null terminator) of the locale name with the specified index.</summary>
        /// <param name="index">Zero-based index of the locale name.</param>
        /// <param name="length">Receives the length in characters, not including the null terminator.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleNameLength(IDWriteLocalizedStrings* This, [NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32")] uint* length);

        /// <summary>Copies the locale name with the specified index to the specified array.</summary>
        /// <param name="index">Zero-based index of the locale name.</param>
        /// <param name="localeName">Character array that receives the locale name.</param>
        /// <param name="size">Size of the array in characters. The size must include space for the terminating null character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetLocaleName(IDWriteLocalizedStrings* This, [NativeTypeName("UINT32")] uint index, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint size);

        /// <summary>Gets the length in characters (not including the null terminator) of the string with the specified index.</summary>
        /// <param name="index">Zero-based index of the string.</param>
        /// <param name="length">Receives the length in characters, not including the null terminator.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetStringLength(IDWriteLocalizedStrings* This, [NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32")] uint* length);

        /// <summary>Copies the string with the specified index to the specified array.</summary>
        /// <param name="index">Zero-based index of the string.</param>
        /// <param name="stringBuffer">Character array that receives the string.</param>
        /// <param name="size">Size of the array in characters. The size must include space for the terminating null character.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetString(IDWriteLocalizedStrings* This, [NativeTypeName("UINT32")] uint index, [NativeTypeName("WCHAR[]")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint size);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetCount()
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCount>(lpVtbl->GetCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindLocaleName([NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint* index, [NativeTypeName("BOOL")] int* exists)
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindLocaleName>(lpVtbl->FindLocaleName)(This, localeName, index, exists);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32")] uint* length)
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleNameLength>(lpVtbl->GetLocaleNameLength)(This, index, length);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint index, [NativeTypeName("WCHAR[]")] ushort* localeName, [NativeTypeName("UINT32")] uint size)
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetLocaleName>(lpVtbl->GetLocaleName)(This, index, localeName, size);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStringLength([NativeTypeName("UINT32")] uint index, [NativeTypeName("UINT32")] uint* length)
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetStringLength>(lpVtbl->GetStringLength)(This, index, length);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT32")] uint index, [NativeTypeName("WCHAR[]")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint size)
        {
            fixed (IDWriteLocalizedStrings* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetString>(lpVtbl->GetString)(This, index, stringBuffer, size);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetCount;

            public IntPtr FindLocaleName;

            public IntPtr GetLocaleNameLength;

            public IntPtr GetLocaleName;

            public IntPtr GetStringLength;

            public IntPtr GetString;
        }
    }
}
