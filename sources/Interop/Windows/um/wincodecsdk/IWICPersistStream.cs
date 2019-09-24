// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("00675040-6908-45F8-86A3-49C7DFD6D9AD")]
    public unsafe struct IWICPersistStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICPersistStream* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICPersistStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICPersistStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetClassID(
            [In] IWICPersistStream* This,
            [Out, NativeTypeName("CLSID")] Guid* pClassID
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _IsDirty(
            [In] IWICPersistStream* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Load(
            [In] IWICPersistStream* This,
            [In] IStream* pStm = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _Save(
            [In] IWICPersistStream* This,
            [In, Optional] IStream* pStm,
            [In, NativeTypeName("BOOL")] int fClearDirty
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _GetSizeMax(
            [In] IWICPersistStream* This,
            [Out] ULARGE_INTEGER* pcbSize
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _LoadEx(
            [In] IWICPersistStream* This,
            [In, Optional] IStream* pIStream,
            [In, Optional, NativeTypeName("GUID")] Guid* pguidPreferredVendor,
            [In, NativeTypeName("DWORD")] uint dwPersistOptions
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _SaveEx(
            [In] IWICPersistStream* This,
            [In, Optional] IStream* pIStream,
            [In, NativeTypeName("DWORD")] uint dwPersistOptions,
            [In, NativeTypeName("BOOL")] int fClearDirty
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICPersistStream* This = &this)
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
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID(
            [Out, NativeTypeName("CLSID")] Guid* pClassID
        )
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)(
                    This,
                    pClassID
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Load(
            [In] IStream* pStm = null
        )
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)(
                    This,
                    pStm
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Save(
            [In, Optional] IStream* pStm,
            [In, NativeTypeName("BOOL")] int fClearDirty
        )
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)(
                    This,
                    pStm,
                    fClearDirty
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax(
            [Out] ULARGE_INTEGER* pcbSize
        )
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSizeMax>(lpVtbl->GetSizeMax)(
                    This,
                    pcbSize
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int LoadEx(
            [In, Optional] IStream* pIStream,
            [In, Optional, NativeTypeName("GUID")] Guid* pguidPreferredVendor,
            [In, NativeTypeName("DWORD")] uint dwPersistOptions
        )
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_LoadEx>(lpVtbl->LoadEx)(
                    This,
                    pIStream,
                    pguidPreferredVendor,
                    dwPersistOptions
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveEx(
            [In, Optional] IStream* pIStream,
            [In, NativeTypeName("DWORD")] uint dwPersistOptions,
            [In, NativeTypeName("BOOL")] int fClearDirty
        )
        {
            fixed (IWICPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SaveEx>(lpVtbl->SaveEx)(
                    This,
                    pIStream,
                    dwPersistOptions,
                    fClearDirty
                );
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
