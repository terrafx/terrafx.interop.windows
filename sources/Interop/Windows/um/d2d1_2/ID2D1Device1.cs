// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Represents a resource domain whose objects and device contexts can be used together.</summary>
    [Guid("D21768E1-23A4-4823-A14B-7C3EBA85D658")]
    public unsafe struct ID2D1Device1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1Device1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1Device1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1Device1* This
        );

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1Device1* This,
            [Out] ID2D1Factory** factory
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDeviceContext(
            [In] ID2D1Device1* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext** deviceContext
        );

        /// <summary>Creates a D2D print control.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreatePrintControl(
            [In] ID2D1Device1* This,
            [In] IWICImagingFactory* wicFactory,
            [In] IPrintDocumentPackageTarget* documentTarget,
            [In, Optional] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties,
            [Out] ID2D1PrintControl** printControl
        );

        /// <summary>Sets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetMaximumTextureMemory(
            [In] ID2D1Device1* This,
            [In, NativeTypeName("UINT64")] ulong maximumInBytes
        );

        /// <summary>Gets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public /* static */ delegate ulong _GetMaximumTextureMemory(
            [In] ID2D1Device1* This
        );

        /// <summary>Clears all resources that are cached but not held in use by the application through an interface reference.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _ClearResources(
            [In] ID2D1Device1* This,
            [In, NativeTypeName("UINT32")] uint millisecondsSinceUse = 0
        );

        /// <summary>Retrieves the rendering priority currently set on the device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate D2D1_RENDERING_PRIORITY _GetRenderingPriority(
            [In] ID2D1Device1* This
        );

        /// <summary>Sets the rendering priority of the device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public /* static */ delegate void _SetRenderingPriority(
            [In] ID2D1Device1* This,
            [In] D2D1_RENDERING_PRIORITY renderingPriority
        );

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _CreateDeviceContext1(
            [In] ID2D1Device1* This,
            [In] D2D1_DEVICE_CONTEXT_OPTIONS options,
            [Out] ID2D1DeviceContext1** deviceContext1
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearResources>(lpVtbl->ClearResources)(
                    This,
                    millisecondsSinceUse
                );
            }
        }

        public D2D1_RENDERING_PRIORITY GetRenderingPriority()
        {
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
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
            fixed (ID2D1Device1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext1>(lpVtbl->CreateDeviceContext1)(
                    This,
                    options,
                    deviceContext1
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
        }
    }
}
