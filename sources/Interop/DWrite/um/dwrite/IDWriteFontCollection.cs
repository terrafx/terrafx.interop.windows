// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteFontCollection encapsulates a collection of fonts.</summary>
    [Guid("A84CEE02-3EEA-4EEE-A827-87C1A02A0FCC")]
    public unsafe struct IDWriteFontCollection
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontCollection* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontCollection* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontCollection* This);

        /// <summary>Gets the number of font families in the collection.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetFontFamilyCount(IDWriteFontCollection* This);

        /// <summary>Creates a font family object given a zero-based font family index.</summary>
        /// <param name="index">Zero-based index of the font family.</param>
        /// <param name="fontFamily">Receives a pointer the newly created font family object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFamily(IDWriteFontCollection* This, [NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily);

        /// <summary>Finds the font family with the specified family name.</summary>
        /// <param name="familyName">Name of the font family. The name is not case-sensitive but must otherwise exactly match a family name in the collection.</param>
        /// <param name="index">Receives the zero-based index of the matching font family if the family name was found or UINT_MAX otherwise.</param>
        /// <param name="exists">Receives TRUE if the family name exists or FALSE otherwise.</param>
        /// <returns>Standard HRESULT error code. If the specified family name does not exist, the return value is S_OK, but *index is UINT_MAX and *exists is FALSE.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _FindFamilyName(IDWriteFontCollection* This, [NativeTypeName("WCHAR[]")] ushort* familyName, [NativeTypeName("UINT32")] uint* index, [NativeTypeName("BOOL")] int* exists);

        /// <summary>Gets the font object that corresponds to the same physical font as the specified font face object. The specified physical font must belong to the font collection.</summary>
        /// <param name="fontFace">Font face object that specifies the physical font.</param>
        /// <param name="font">Receives a pointer to the newly created font object if successful or NULL otherwise.</param>
        /// <returns>Standard HRESULT error code. If the specified physical font is not part of the font collection the return value is DWRITE_E_NOFONT.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFontFromFontFace(IDWriteFontCollection* This, IDWriteFontFace* fontFace, IDWriteFont** font);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            fixed (IDWriteFontCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamilyCount>(lpVtbl->GetFontFamilyCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, IDWriteFontFamily** fontFamily)
        {
            fixed (IDWriteFontCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFamily>(lpVtbl->GetFontFamily)(This, index, fontFamily);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFamilyName([NativeTypeName("WCHAR[]")] ushort* familyName, [NativeTypeName("UINT32")] uint* index, [NativeTypeName("BOOL")] int* exists)
        {
            fixed (IDWriteFontCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_FindFamilyName>(lpVtbl->FindFamilyName)(This, familyName, index, exists);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            fixed (IDWriteFontCollection* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFontFromFontFace>(lpVtbl->GetFontFromFontFace)(This, fontFace, font);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFontFamilyCount;

            public IntPtr GetFontFamily;

            public IntPtr FindFamilyName;

            public IntPtr GetFontFromFontFace;
        }
    }
}
