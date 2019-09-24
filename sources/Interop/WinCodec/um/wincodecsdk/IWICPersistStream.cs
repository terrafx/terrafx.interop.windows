// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00675040-6908-45F8-86A3-49C7DFD6D9AD")]
    public unsafe struct IWICPersistStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IWICPersistStream* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IWICPersistStream* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IWICPersistStream* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IWICPersistStream* This, [NativeTypeName("CLSID")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IWICPersistStream* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IWICPersistStream* This, IStream* pStm = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IWICPersistStream* This, [Optional] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSizeMax(IWICPersistStream* This, ULARGE_INTEGER* pcbSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _LoadEx(IWICPersistStream* This, [Optional] IStream* pIStream, [Optional, NativeTypeName("GUID")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SaveEx(IWICPersistStream* This, [Optional] IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, [NativeTypeName("BOOL")] int fClearDirty);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID")] Guid* pClassID)
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)(This, pClassID);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Load(IStream* pStm = null)
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)(This, pStm);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([Optional] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)(This, pStm, fClearDirty);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax(ULARGE_INTEGER* pcbSize)
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSizeMax>(lpVtbl->GetSizeMax)(This, pcbSize);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadEx([Optional] IStream* pIStream, [Optional, NativeTypeName("GUID")] Guid* pguidPreferredVendor, [NativeTypeName("DWORD")] uint dwPersistOptions)
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadEx>(lpVtbl->LoadEx)(This, pIStream, pguidPreferredVendor, dwPersistOptions);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveEx([Optional] IStream* pIStream, [NativeTypeName("DWORD")] uint dwPersistOptions, [NativeTypeName("BOOL")] int fClearDirty)
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SaveEx>(lpVtbl->SaveEx)(This, pIStream, dwPersistOptions, fClearDirty);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetClassID;

            public IntPtr IsDirty;

            public IntPtr Load;

            public IntPtr Save;

            public IntPtr GetSizeMax;

            public IntPtr LoadEx;

            public IntPtr SaveEx;
        }
    }
}
