// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\objidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000109-0000-0000-C000-000000000046")]
    public unsafe partial struct IPersistStream
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPersistStream* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPersistStream* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPersistStream* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IPersistStream* This, [NativeTypeName("CLSID")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IPersistStream* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IPersistStream* This, IStream* pStm = null);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IPersistStream* This, [Optional] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSizeMax(IPersistStream* This, ULARGE_INTEGER* pcbSize);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID")] Guid* pClassID)
        {
            fixed (IPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)(This, pClassID);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            fixed (IPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Load(IStream* pStm = null)
        {
            fixed (IPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)(This, pStm);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([Optional] IStream* pStm, [NativeTypeName("BOOL")] int fClearDirty)
        {
            fixed (IPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)(This, pStm, fClearDirty);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax(ULARGE_INTEGER* pcbSize)
        {
            fixed (IPersistStream* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSizeMax>(lpVtbl->GetSizeMax)(This, pcbSize);
            }
        }

        public partial struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetClassID;

            public IntPtr IsDirty;

            public IntPtr Load;

            public IntPtr Save;

            public IntPtr GetSizeMax;
        }
    }
}
