// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("D7BDB159-5683-4A46-BC9C-72DC720B858B")]
    public unsafe struct ID2D1Device4
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Device4* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Device4* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Device4* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1Device4* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1Device Delegates
        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDeviceContext(
            [In] ID2D1Device4* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext** deviceContext
        );

        /// <summary>Creates a D2D print control.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePrintControl(
            [In] ID2D1Device4* This,
            [In] IWICImagingFactory* wicFactory,
            [In] IPrintDocumentPackageTarget* documentTarget,
            [In, Optional] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties,
            [Out] ID2D1PrintControl** printControl
        );

        /// <summary>Sets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetMaximumTextureMemory(
            [In] ID2D1Device4* This,
            [In, NativeTypeName("UINT64")] ulong maximumInBytes
        );

        /// <summary>Gets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetMaximumTextureMemory(
            [In] ID2D1Device4* This
        );

        /// <summary>Clears all resources that are cached but not held in use by the application through an interface reference.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _ClearResources(
            [In] ID2D1Device4* This,
            [In, NativeTypeName("UINT32")] uint millisecondsSinceUse = 0
        );
        #endregion

        #region ID2D1Device1 Delegates
        /// <summary>Retrieves the rendering priority currently set on the device.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_RENDERING_PRIORITY _GetRenderingPriority(
            [In] ID2D1Device4* This
        );

        /// <summary>Sets the rendering priority of the device.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetRenderingPriority(
            [In] ID2D1Device4* This,
            [In] D2D1_RENDERING_PRIORITY renderingPriority
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDeviceContext1(
            [In] ID2D1Device4* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext1** deviceContext1
        );
        #endregion

        #region ID2D1Device2 Delegates
        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDeviceContext2(
            [In] ID2D1Device4* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext2** deviceContext2
        );

        /// <summary>Flush all device contexts that reference a given bitmap.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _FlushDeviceContexts(
            [In] ID2D1Device4* This,
            [In] ID2D1Bitmap* bitmap
        );

        /// <summary>Returns the DXGI device associated with this D2D device.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetDxgiDevice(
            [In] ID2D1Device4* This,
            [Out] IDXGIDevice** dxgiDevice
        );
        #endregion

        #region ID2D1Device3 Delegates
        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDeviceContext3(
            [In] ID2D1Device4* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext3** deviceContext3
        );
        #endregion

        #region Delegates
        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDeviceContext4(
            [In] ID2D1Device4* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext4** deviceContext4
        );

        /// <summary>Sets the maximum capacity of the color glyph cache. This cache is used to store color bitmap glyphs and SVG glyphs, enabling faster performance if the same glyphs are needed again. If the application still references a glyph using GetColorBitmapGlyphImage or GetSvgGlyphImage after it has been evicted, this glyph does not count toward the cache capacity.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetMaximumColorGlyphCacheMemory(
            [In] ID2D1Device4* This,
            [In, NativeTypeName("UINT64")] ulong maximumInBytes
        );

        /// <summary>Gets the maximum capacity of the color glyph cache.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetMaximumColorGlyphCacheMemory(
            [In] ID2D1Device4* This
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1Device Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext** deviceContext
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_CreateDeviceContext>(lpVtbl->CreateDeviceContext)(
                    This,
                    options,
                    deviceContext
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePrintControl(
            [In] IWICImagingFactory* wicFactory,
            [In] IPrintDocumentPackageTarget* documentTarget,
            [In, Optional] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties,
            [Out] ID2D1PrintControl** printControl
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_CreatePrintControl>(lpVtbl->CreatePrintControl)(
                    This,
                    wicFactory,
                    documentTarget,
                    printControlProperties,
                    printControl
                );
            }
        }

        public void SetMaximumTextureMemory(
            [In, NativeTypeName("UINT64")] ulong maximumInBytes
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                MarshalFunction<_SetMaximumTextureMemory>(lpVtbl->SetMaximumTextureMemory)(
                    This,
                    maximumInBytes
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_GetMaximumTextureMemory>(lpVtbl->GetMaximumTextureMemory)(
                    This
                );
            }
        }

        public void ClearResources(
            [In, NativeTypeName("UINT32")] uint millisecondsSinceUse = 0
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                MarshalFunction<_ClearResources>(lpVtbl->ClearResources)(
                    This,
                    millisecondsSinceUse
                );
            }
        }
        #endregion

        #region ID2D1Device1 Methods
        public D2D1_RENDERING_PRIORITY GetRenderingPriority()
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_GetRenderingPriority>(lpVtbl->GetRenderingPriority)(
                    This
                );
            }
        }

        public void SetRenderingPriority(
            [In] D2D1_RENDERING_PRIORITY renderingPriority
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                MarshalFunction<_SetRenderingPriority>(lpVtbl->SetRenderingPriority)(
                    This,
                    renderingPriority
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext1(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext1** deviceContext1
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_CreateDeviceContext1>(lpVtbl->CreateDeviceContext1)(
                    This,
                    options,
                    deviceContext1
                );
            }
        }
        #endregion

        #region ID2D1Device2 Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext2(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext2** deviceContext2
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_CreateDeviceContext2>(lpVtbl->CreateDeviceContext2)(
                    This,
                    options,
                    deviceContext2
                );
            }
        }

        public void FlushDeviceContexts(
            [In] ID2D1Bitmap* bitmap
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                MarshalFunction<_FlushDeviceContexts>(lpVtbl->FlushDeviceContexts)(
                    This,
                    bitmap
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDxgiDevice(
            [Out] IDXGIDevice** dxgiDevice
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_GetDxgiDevice>(lpVtbl->GetDxgiDevice)(
                    This,
                    dxgiDevice
                );
            }
        }
        #endregion

        #region ID2D1Device3 Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext3(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext3** deviceContext3
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_CreateDeviceContext3>(lpVtbl->CreateDeviceContext3)(
                    This,
                    options,
                    deviceContext3
                );
            }
        }
        #endregion

        #region Methods
        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext4(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext4** deviceContext4
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_CreateDeviceContext4>(lpVtbl->CreateDeviceContext4)(
                    This,
                    options,
                    deviceContext4
                );
            }
        }

        public void SetMaximumColorGlyphCacheMemory(
            [In, NativeTypeName("UINT64")] ulong maximumInBytes
        )
        {
            fixed (ID2D1Device4* This = &this)
            {
                MarshalFunction<_SetMaximumColorGlyphCacheMemory>(lpVtbl->SetMaximumColorGlyphCacheMemory)(
                    This,
                    maximumInBytes
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumColorGlyphCacheMemory()
        {
            fixed (ID2D1Device4* This = &this)
            {
                return MarshalFunction<_GetMaximumColorGlyphCacheMemory>(lpVtbl->GetMaximumColorGlyphCacheMemory)(
                    This
                );
            }
        }
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region ID2D1Device Fields
            public IntPtr CreateDeviceContext;

            public IntPtr CreatePrintControl;

            public IntPtr SetMaximumTextureMemory;

            public IntPtr GetMaximumTextureMemory;

            public IntPtr ClearResources;
            #endregion

            #region ID2D1Device1 Fields
            public IntPtr GetRenderingPriority;

            public IntPtr SetRenderingPriority;

            public IntPtr CreateDeviceContext1;
            #endregion

            #region ID2D1Device2 Fields
            public IntPtr CreateDeviceContext2;

            public IntPtr FlushDeviceContexts;

            public IntPtr GetDxgiDevice;
            #endregion

            #region ID2D1Device3 Fields
            public IntPtr CreateDeviceContext3;
            #endregion

            #region Fields
            public IntPtr CreateDeviceContext4;

            public IntPtr SetMaximumColorGlyphCacheMemory;

            public IntPtr GetMaximumColorGlyphCacheMemory;
            #endregion
        }
        #endregion
    }
}
