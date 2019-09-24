// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a producer of pixels that can fill an arbitrary 2D plane.</summary>
    [Guid("C9B664E5-74A1-4378-9AC2-EEFC37A3F4D8")]
    public unsafe struct ID2D1ImageSource
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1ImageSource* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1ImageSource* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1ImageSource* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(
            [In] ID2D1ImageSource* This,
            [Out] ID2D1Factory** factory
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OfferResources(
            [In] ID2D1ImageSource* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TryReclaimResources(
            [In] ID2D1ImageSource* This,
            [Out, NativeTypeName("BOOL")] int* resourcesDiscarded
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ImageSource* This = &this)
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
            fixed (ID2D1ImageSource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ImageSource* This = &this)
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
            fixed (ID2D1ImageSource* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources()
        {
            fixed (ID2D1ImageSource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OfferResources>(lpVtbl->OfferResources)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int TryReclaimResources(
            [Out, NativeTypeName("BOOL")] int* resourcesDiscarded
        )
        {
            fixed (ID2D1ImageSource* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_TryReclaimResources>(lpVtbl->TryReclaimResources)(
                    This,
                    resourcesDiscarded
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr OfferResources;

            public IntPtr TryReclaimResources;
        }
    }
}
