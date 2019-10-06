// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The device defines a resource domain whose objects and device contexts can be used together.</summary>
    [Guid("47DD575D-AC05-4CDD-8049-9B02CD16F44C")]
    public unsafe partial struct ID2D1Device
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1Device* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1Device* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1Device* This);

        /// <summary>Retrieve the factory associated with this resource.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1Device* This, ID2D1Factory** factory);

        /// <summary>Creates a new device context with no initially assigned target.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateDeviceContext(ID2D1Device* This, D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext);

        /// <summary>Creates a D2D print control.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreatePrintControl(ID2D1Device* This, IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Optional] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl);

        /// <summary>Sets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetMaximumTextureMemory(ID2D1Device* This, [NativeTypeName("UINT64")] ulong maximumInBytes);

        /// <summary>Gets the maximum amount of texture memory to maintain before evicting caches.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT64")]
        public delegate ulong _GetMaximumTextureMemory(ID2D1Device* This);

        /// <summary>Clears all resources that are cached but not held in use by the application through an interface reference.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ClearResources(ID2D1Device* This, [NativeTypeName("UINT32")] uint millisecondsSinceUse = 0);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1Device* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1Device* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1Device* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public void GetFactory(ID2D1Factory** factory)
        {
            fixed (ID2D1Device* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)(This, factory);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext)
        {
            fixed (ID2D1Device* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateDeviceContext>(lpVtbl->CreateDeviceContext)(This, options, deviceContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [Optional] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl)
        {
            fixed (ID2D1Device* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreatePrintControl>(lpVtbl->CreatePrintControl)(This, wicFactory, documentTarget, printControlProperties, printControl);
            }
        }

        public void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            fixed (ID2D1Device* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetMaximumTextureMemory>(lpVtbl->SetMaximumTextureMemory)(This, maximumInBytes);
            }
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            fixed (ID2D1Device* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetMaximumTextureMemory>(lpVtbl->GetMaximumTextureMemory)(This);
            }
        }

        public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
        {
            fixed (ID2D1Device* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ClearResources>(lpVtbl->ClearResources)(This, millisecondsSinceUse);
            }
        }

        public partial struct Vtbl
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
        }
    }
}
