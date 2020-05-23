// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000e-0000-0000-C000-000000000046")]
    public unsafe partial struct IBindCtx
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IBindCtx* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IBindCtx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IBindCtx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterObjectBound(IBindCtx* pThis, [NativeTypeName("IUnknown *")] IUnknown* punk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RevokeObjectBound(IBindCtx* pThis, [NativeTypeName("IUnknown *")] IUnknown* punk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseBoundObjects(IBindCtx* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetBindOptions(IBindCtx* pThis, [NativeTypeName("BIND_OPTS *")] BIND_OPTS* pbindopts);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetBindOptions(IBindCtx* pThis, [NativeTypeName("BIND_OPTS *")] BIND_OPTS* pbindopts);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRunningObjectTable(IBindCtx* pThis, [NativeTypeName("IRunningObjectTable **")] IRunningObjectTable** pprot);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterObjectParam(IBindCtx* pThis, [NativeTypeName("LPOLESTR")] ushort* pszKey, [NativeTypeName("IUnknown *")] IUnknown* punk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetObjectParam(IBindCtx* pThis, [NativeTypeName("LPOLESTR")] ushort* pszKey, [NativeTypeName("IUnknown **")] IUnknown** ppunk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumObjectParam(IBindCtx* pThis, [NativeTypeName("IEnumString **")] IEnumString** ppenum);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RevokeObjectParam(IBindCtx* pThis, [NativeTypeName("LPOLESTR")] ushort* pszKey);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IBindCtx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterObjectBound([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterObjectBound>(lpVtbl->RegisterObjectBound)((IBindCtx*)Unsafe.AsPointer(ref this), punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int RevokeObjectBound([NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return Marshal.GetDelegateForFunctionPointer<_RevokeObjectBound>(lpVtbl->RevokeObjectBound)((IBindCtx*)Unsafe.AsPointer(ref this), punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseBoundObjects()
        {
            return Marshal.GetDelegateForFunctionPointer<_ReleaseBoundObjects>(lpVtbl->ReleaseBoundObjects)((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBindOptions([NativeTypeName("BIND_OPTS *")] BIND_OPTS* pbindopts)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetBindOptions>(lpVtbl->SetBindOptions)((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindOptions([NativeTypeName("BIND_OPTS *")] BIND_OPTS* pbindopts)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetBindOptions>(lpVtbl->GetBindOptions)((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRunningObjectTable([NativeTypeName("IRunningObjectTable **")] IRunningObjectTable** pprot)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRunningObjectTable>(lpVtbl->GetRunningObjectTable)((IBindCtx*)Unsafe.AsPointer(ref this), pprot);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterObjectParam>(lpVtbl->RegisterObjectParam)((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, punk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, [NativeTypeName("IUnknown **")] IUnknown** ppunk)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetObjectParam>(lpVtbl->GetObjectParam)((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, ppunk);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumObjectParam([NativeTypeName("IEnumString **")] IEnumString** ppenum)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumObjectParam>(lpVtbl->EnumObjectParam)((IBindCtx*)Unsafe.AsPointer(ref this), ppenum);
        }

        [return: NativeTypeName("HRESULT")]
        public int RevokeObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey)
        {
            return Marshal.GetDelegateForFunctionPointer<_RevokeObjectParam>(lpVtbl->RevokeObjectParam)((IBindCtx*)Unsafe.AsPointer(ref this), pszKey);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public IntPtr RegisterObjectBound;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public IntPtr RevokeObjectBound;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr ReleaseBoundObjects;

            [NativeTypeName("HRESULT (BIND_OPTS *) __attribute__((stdcall))")]
            public IntPtr SetBindOptions;

            [NativeTypeName("HRESULT (BIND_OPTS *) __attribute__((stdcall))")]
            public IntPtr GetBindOptions;

            [NativeTypeName("HRESULT (IRunningObjectTable **) __attribute__((stdcall))")]
            public IntPtr GetRunningObjectTable;

            [NativeTypeName("HRESULT (LPOLESTR, IUnknown *) __attribute__((stdcall))")]
            public IntPtr RegisterObjectParam;

            [NativeTypeName("HRESULT (LPOLESTR, IUnknown **) __attribute__((stdcall))")]
            public IntPtr GetObjectParam;

            [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
            public IntPtr EnumObjectParam;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr RevokeObjectParam;
        }
    }
}
