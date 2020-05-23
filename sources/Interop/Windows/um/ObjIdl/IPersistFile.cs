// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000010B-0000-0000-C000-000000000046")]
    public unsafe partial struct IPersistFile
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IPersistFile* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IPersistFile* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IPersistFile* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClassID(IPersistFile* pThis, [NativeTypeName("CLSID *")] Guid* pClassID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsDirty(IPersistFile* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Load(IPersistFile* pThis, [NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("DWORD")] uint dwMode);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Save(IPersistFile* pThis, [NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("BOOL")] int fRemember);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SaveCompleted(IPersistFile* pThis, [NativeTypeName("LPCOLESTR")] ushort* pszFileName);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurFile(IPersistFile* pThis, [NativeTypeName("LPOLESTR *")] ushort** ppszFileName);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IPersistFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClassID>(lpVtbl->GetClassID)((IPersistFile*)Unsafe.AsPointer(ref this), pClassID);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsDirty>(lpVtbl->IsDirty)((IPersistFile*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("DWORD")] uint dwMode)
        {
            return Marshal.GetDelegateForFunctionPointer<_Load>(lpVtbl->Load)((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, dwMode);
        }

        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, [NativeTypeName("BOOL")] int fRemember)
        {
            return Marshal.GetDelegateForFunctionPointer<_Save>(lpVtbl->Save)((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName, fRemember);
        }

        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName)
        {
            return Marshal.GetDelegateForFunctionPointer<_SaveCompleted>(lpVtbl->SaveCompleted)((IPersistFile*)Unsafe.AsPointer(ref this), pszFileName);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCurFile>(lpVtbl->GetCurFile)((IPersistFile*)Unsafe.AsPointer(ref this), ppszFileName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public IntPtr GetClassID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr IsDirty;

            [NativeTypeName("HRESULT (LPCOLESTR, DWORD) __attribute__((stdcall))")]
            public IntPtr Load;

            [NativeTypeName("HRESULT (LPCOLESTR, BOOL) __attribute__((stdcall))")]
            public IntPtr Save;

            [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
            public IntPtr SaveCompleted;

            [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
            public IntPtr GetCurFile;
        }
    }
}
