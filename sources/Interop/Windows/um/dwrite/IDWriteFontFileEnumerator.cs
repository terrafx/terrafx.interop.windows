// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The font file enumerator interface encapsulates a collection of font files. The font system uses this interface to enumerate font files when building a font collection.</summary>
    [Guid("72755049-5FF7-435D-8348-4BE97CFA6C7C")]
    public unsafe struct IDWriteFontFileEnumerator
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteFontFileEnumerator* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteFontFileEnumerator* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteFontFileEnumerator* This
        );

        /// <summary>Advances to the next font file in the collection. When it is first created, the enumerator is positioned before the first element of the collection and the first call to MoveNext advances to the first file.</summary>
        /// <param name="hasCurrentFile">Receives the value TRUE if the enumerator advances to a file, or FALSE if the enumerator advanced past the last file in the collection.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _MoveNext(
            [In] IDWriteFontFileEnumerator* This,
            [Out, NativeTypeName("BOOL")] int* hasCurrentFile
        );

        /// <summary>Gets a reference to the current font file.</summary>
        /// <param name="fontFile">Pointer to the newly created font file object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetCurrentFontFile(
            [In] IDWriteFontFileEnumerator* This,
            [Out] IDWriteFontFile** fontFile
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveNext(
            [Out, NativeTypeName("BOOL")] int* hasCurrentFile
        )
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MoveNext>(lpVtbl->MoveNext)(
                    This,
                    hasCurrentFile
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentFontFile(
            [Out] IDWriteFontFile** fontFile
        )
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentFontFile>(lpVtbl->GetCurrentFontFile)(
                    This,
                    fontFile
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr MoveNext;

            public IntPtr GetCurrentFontFile;
        }
    }
}
