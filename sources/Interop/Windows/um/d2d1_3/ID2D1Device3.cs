// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("852F2087-802C-4037-AB60-FF2E7EE6FC01")]
    public unsafe struct ID2D1Device3
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Device3* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Device3* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Device3* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1Device3* This, ID2D1Factory** factory);

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext(ID2D1Device3* This, D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext);

        /// <summary>Creates a D2D print control.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePrintControl(ID2D1Device3* This, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Optional] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl);

        /// <summary>Sets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMaximumTextureMemory(ID2D1Device3* This, [NativeTypeName("UINT64")] ulong maximumInBytes);

        /// <summary>Gets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetMaximumTextureMemory(ID2D1Device3* This);

        /// <summary>Clears all resources that are cached but not held in use by the application through an interface reference.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearResources(ID2D1Device3* This, [NativeTypeName("UINT32")] uint millisecondsSinceUse = 0);

        /// <summary>Retrieves the rendering priority currently set on the device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_RENDERING_PRIORITY _GetRenderingPriority(ID2D1Device3* This);

        /// <summary>Sets the rendering priority of the device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetRenderingPriority(ID2D1Device3* This, D2D1_RENDERING_PRIORITY renderingPriority);

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext1(ID2D1Device3* This, D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext1** deviceContext1);

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext2(ID2D1Device3* This, D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext2** deviceContext2);

        /// <summary>Flush all device contexts that reference a given bitmap.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _FlushDeviceContexts(ID2D1Device3* This, ID2D1Bitmap* bitmap);

        /// <summary>Returns the DXGI device associated with this D2D device.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDxgiDevice(ID2D1Device3* This, IDXGIDevice** dxgiDevice);

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext3(ID2D1Device3* This, D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext3** deviceContext3);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1Device3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext)
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext>(lpVtbl->CreateDeviceContext)(This, options, deviceContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Optional] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl)
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePrintControl>(lpVtbl->CreatePrintControl)(This, wicFactory, documentTarget, printControlProperties, printControl);
            }
        }

        public void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            fixed (ID2D1Device3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMaximumTextureMemory>(lpVtbl->SetMaximumTextureMemory)(This, maximumInBytes);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumTextureMemory>(lpVtbl->GetMaximumTextureMemory)(This);
            }
        }

        public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
        {
            fixed (ID2D1Device3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearResources>(lpVtbl->ClearResources)(This, millisecondsSinceUse);
            }
        }

        public D2D1_RENDERING_PRIORITY GetRenderingPriority()
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRenderingPriority>(lpVtbl->GetRenderingPriority)(This);
            }
        }

        public void SetRenderingPriority(D2D1_RENDERING_PRIORITY renderingPriority)
        {
            fixed (ID2D1Device3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetRenderingPriority>(lpVtbl->SetRenderingPriority)(This, renderingPriority);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext1(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext1** deviceContext1)
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext1>(lpVtbl->CreateDeviceContext1)(This, options, deviceContext1);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext2(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext2** deviceContext2)
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext2>(lpVtbl->CreateDeviceContext2)(This, options, deviceContext2);
            }
        }

        public void FlushDeviceContexts(ID2D1Bitmap* bitmap)
        {
            fixed (ID2D1Device3* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_FlushDeviceContexts>(lpVtbl->FlushDeviceContexts)(This, bitmap);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDxgiDevice(IDXGIDevice** dxgiDevice)
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDxgiDevice>(lpVtbl->GetDxgiDevice)(This, dxgiDevice);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext3(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext3** deviceContext3)
        {
            fixed (ID2D1Device3* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext3>(lpVtbl->CreateDeviceContext3)(This, options, deviceContext3);
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
        }
    }
}
