// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("390E3878-FD55-4E18-819D-4682081C0CFD")]
    public unsafe partial struct IEnterpriseDropTarget
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IEnterpriseDropTarget* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IEnterpriseDropTarget* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IEnterpriseDropTarget* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDropSourceEnterpriseId(IEnterpriseDropTarget* pThis, [NativeTypeName("LPCWSTR")] ushort* identity);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsEvaluatingEdpPolicy(IEnterpriseDropTarget* pThis, [NativeTypeName("BOOL *")] int* value);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDropSourceEnterpriseId([NativeTypeName("LPCWSTR")] ushort* identity)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDropSourceEnterpriseId>(lpVtbl->SetDropSourceEnterpriseId)((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), identity);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsEvaluatingEdpPolicy([NativeTypeName("BOOL *")] int* value)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsEvaluatingEdpPolicy>(lpVtbl->IsEvaluatingEdpPolicy)((IEnterpriseDropTarget*)Unsafe.AsPointer(ref this), value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public IntPtr SetDropSourceEnterpriseId;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public IntPtr IsEvaluatingEdpPolicy;
        }
    }
}
