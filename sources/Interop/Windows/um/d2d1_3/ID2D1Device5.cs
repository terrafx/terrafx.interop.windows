// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D55BA0A4-6405-4694-AEF5-08EE1A4358B4")]
    public unsafe struct ID2D1Device5
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1Device5* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1Device5* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1Device5* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(
            [In] ID2D1Device5* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext(
            [In] ID2D1Device5* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext** deviceContext
        );

        /// <summary>Creates a D2D print control.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePrintControl(
            [In] ID2D1Device5* This,
            [In] IWICImagingFactory* wicFactory,
            [In] IPrintDocumentPackageTarget* documentTarget,
            [In, Optional] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties,
            [Out] ID2D1PrintControl** printControl
        );

        /// <summary>Sets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMaximumTextureMemory(
            [In] ID2D1Device5* This,
            [In, NativeTypeName("UINT64")] ulong maximumInBytes
        );

        /// <summary>Gets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetMaximumTextureMemory(
            [In] ID2D1Device5* This
        );

        /// <summary>Clears all resources that are cached but not held in use by the application through an interface reference.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearResources(
            [In] ID2D1Device5* This,
            [In, NativeTypeName("UINT32")] uint millisecondsSinceUse = 0
        );

        /// <summary>Retrieves the rendering priority currently set on the device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_RENDERING_PRIORITY _GetRenderingPriority(
            [In] ID2D1Device5* This
        );

        /// <summary>Sets the rendering priority of the device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetRenderingPriority(
            [In] ID2D1Device5* This,
            [In] D2D1_RENDERING_PRIORITY renderingPriority
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext1(
            [In] ID2D1Device5* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext1** deviceContext1
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext2(
            [In] ID2D1Device5* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext2** deviceContext2
        );

        /// <summary>Flush all device contexts that reference a given bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FlushDeviceContexts(
            [In] ID2D1Device5* This,
            [In] ID2D1Bitmap* bitmap
        );

        /// <summary>Returns the DXGI device associated with this D2D device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDxgiDevice(
            [In] ID2D1Device5* This,
            [Out] IDXGIDevice** dxgiDevice
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext3(
            [In] ID2D1Device5* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext3** deviceContext3
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext4(
            [In] ID2D1Device5* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext4** deviceContext4
        );

        /// <summary>Sets the maximum capacity of the color glyph cache. This cache is used to store color bitmap glyphs and SVG glyphs, enabling faster performance if the same glyphs are needed again. If the application still references a glyph using GetColorBitmapGlyphImage or GetSvgGlyphImage after it has been evicted, this glyph does not count toward the cache capacity.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMaximumColorGlyphCacheMemory(
            [In] ID2D1Device5* This,
            [In, NativeTypeName("UINT64")] ulong maximumInBytes
        );

        /// <summary>Gets the maximum capacity of the color glyph cache.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetMaximumColorGlyphCacheMemory(
            [In] ID2D1Device5* This
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext5(
            [In] ID2D1Device5* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext5** deviceContext5
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Device5* This = &this)
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
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Device5* This = &this)
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
            fixed (ID2D1Device5* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext** deviceContext
        )
        {
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext>(lpVtbl->CreateDeviceContext)(
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
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePrintControl>(lpVtbl->CreatePrintControl)(
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
            fixed (ID2D1Device5* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMaximumTextureMemory>(lpVtbl->SetMaximumTextureMemory)(
                    This,
                    maximumInBytes
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumTextureMemory>(lpVtbl->GetMaximumTextureMemory)(
                    This
                );
            }
        }

        public void ClearResources(
            [In, NativeTypeName("UINT32")] uint millisecondsSinceUse = 0
        )
        {
            fixed (ID2D1Device5* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearResources>(lpVtbl->ClearResources)(
                    This,
                    millisecondsSinceUse
                );
            }
        }

        public D2D1_RENDERING_PRIORITY GetRenderingPriority()
        {
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRenderingPriority>(lpVtbl->GetRenderingPriority)(
                    This
                );
            }
        }

        public void SetRenderingPriority(
            [In] D2D1_RENDERING_PRIORITY renderingPriority
        )
        {
            fixed (ID2D1Device5* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetRenderingPriority>(lpVtbl->SetRenderingPriority)(
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
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext1>(lpVtbl->CreateDeviceContext1)(
                    This,
                    options,
                    deviceContext1
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext2(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext2** deviceContext2
        )
        {
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext2>(lpVtbl->CreateDeviceContext2)(
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
            fixed (ID2D1Device5* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FlushDeviceContexts>(lpVtbl->FlushDeviceContexts)(
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
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDxgiDevice>(lpVtbl->GetDxgiDevice)(
                    This,
                    dxgiDevice
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext3(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext3** deviceContext3
        )
        {
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext3>(lpVtbl->CreateDeviceContext3)(
                    This,
                    options,
                    deviceContext3
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext4(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext4** deviceContext4
        )
        {
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext4>(lpVtbl->CreateDeviceContext4)(
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
            fixed (ID2D1Device5* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMaximumColorGlyphCacheMemory>(lpVtbl->SetMaximumColorGlyphCacheMemory)(
                    This,
                    maximumInBytes
                );
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumColorGlyphCacheMemory()
        {
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumColorGlyphCacheMemory>(lpVtbl->GetMaximumColorGlyphCacheMemory)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext5(
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext5** deviceContext5
        )
        {
            fixed (ID2D1Device5* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext5>(lpVtbl->CreateDeviceContext5)(
                    This,
                    options,
                    deviceContext5
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetFactory;

            public IntPtr CreateDeviceContext;

            public IntPtr CreatePrintControl;

            public IntPtr SetMaximumTextureMemory;

            public IntPtr GetMaximumTextureMemory;

            public IntPtr ClearResources;

            public IntPtr GetRenderingPriority;

            public IntPtr SetRenderingPriority;

            public IntPtr CreateDeviceContext1;

            public IntPtr CreateDeviceContext2;

            public IntPtr FlushDeviceContexts;

            public IntPtr GetDxgiDevice;

            public IntPtr CreateDeviceContext3;

            public IntPtr CreateDeviceContext4;

            public IntPtr SetMaximumColorGlyphCacheMemory;

            public IntPtr GetMaximumColorGlyphCacheMemory;

            public IntPtr CreateDeviceContext5;
        }
    }
}
