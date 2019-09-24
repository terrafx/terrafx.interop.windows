// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Produces 2D pixel data that has been sourced from WIC.</summary>
    [Guid("77395441-1C8F-4555-8683-F50DAB0FE792")]
    public unsafe struct ID2D1ImageSourceFromWic
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1ImageSourceFromWic* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1ImageSourceFromWic* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1ImageSourceFromWic* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1ImageSourceFromWic* This, ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _OfferResources(ID2D1ImageSourceFromWic* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TryReclaimResources(ID2D1ImageSourceFromWic* This, [NativeTypeName("BOOL")] int* resourcesDiscarded);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnsureCached(ID2D1ImageSourceFromWic* This, [NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* rectangleToFill = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TrimCache(ID2D1ImageSourceFromWic* This, [NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* rectangleToPreserve = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetSource(ID2D1ImageSourceFromWic* This, IWICBitmapSource** wicBitmapSource);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int OfferResources()
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_OfferResources>(lpVtbl->OfferResources)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int TryReclaimResources([NativeTypeName("BOOL")] int* resourcesDiscarded)
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_TryReclaimResources>(lpVtbl->TryReclaimResources)(This, resourcesDiscarded);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int EnsureCached([NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* rectangleToFill = null)
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_EnsureCached>(lpVtbl->EnsureCached)(This, rectangleToFill);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int TrimCache([NativeTypeName("D2D1_RECT_U")] D2D_RECT_U* rectangleToPreserve = null)
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_TrimCache>(lpVtbl->TrimCache)(This, rectangleToPreserve);
            }
        }

        public void GetSource(IWICBitmapSource** wicBitmapSource)
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetSource>(lpVtbl->GetSource)(This, wicBitmapSource);
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

            public IntPtr EnsureCached;

            public IntPtr TrimCache;

            public IntPtr GetSource;
        }
    }
}
