// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Represents a color context that can be used with an ID2D1Bitmap1 object.</summary>
    [Guid("1C4820BB-5771-4518-A581-2FE4DD0EC657")]
    public unsafe struct ID2D1ColorContext
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1ColorContext* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1ColorContext* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1ColorContext* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1ColorContext* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Retrieves the color space of the color context.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_COLOR_SPACE _GetColorSpace(
            [In] ID2D1ColorContext* This
        );

        /// <summary>Retrieves the size of the color profile, in bytes.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT32")]
        public /* static */ delegate uint _GetProfileSize(
            [In] ID2D1ColorContext* This
        );

        /// <summary>Retrieves the color profile bytes.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetProfile(
            [In] ID2D1ColorContext* This,
            [Out, NativeTypeName("BYTE[]")] byte* profile,
            [In, NativeTypeName("UINT32")] uint profileSize
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ColorContext* This = &this)
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
            fixed (ID2D1ColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1ColorContext* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        public D2D1_COLOR_SPACE GetColorSpace()
        {
            fixed (ID2D1ColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorSpace>(lpVtbl->GetColorSpace)(
                    This
                );
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetProfileSize()
        {
            fixed (ID2D1ColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetProfileSize>(lpVtbl->GetProfileSize)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfile(
            [Out, NativeTypeName("BYTE[]")] byte* profile,
            [In, NativeTypeName("UINT32")] uint profileSize
        )
        {
            fixed (ID2D1ColorContext* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetProfile>(lpVtbl->GetProfile)(
                    This,
                    profile,
                    profileSize
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr GetColorSpace;

            public IntPtr GetProfileSize;

            public IntPtr GetProfile;
        }
    }
}
