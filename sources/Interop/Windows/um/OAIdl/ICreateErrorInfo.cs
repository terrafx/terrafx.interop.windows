// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F03340-547D-101B-8E65-08002B2BD119")]
    public unsafe partial struct ICreateErrorInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ICreateErrorInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ICreateErrorInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ICreateErrorInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetGUID(ICreateErrorInfo* pThis, [NativeTypeName("const GUID &")] Guid* rguid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetSource(ICreateErrorInfo* pThis, [NativeTypeName("LPOLESTR")] ushort* szSource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetDescription(ICreateErrorInfo* pThis, [NativeTypeName("LPOLESTR")] ushort* szDescription);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHelpFile(ICreateErrorInfo* pThis, [NativeTypeName("LPOLESTR")] ushort* szHelpFile);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHelpContext(ICreateErrorInfo* pThis, [NativeTypeName("DWORD")] uint dwHelpContext);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ICreateErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetGUID>(lpVtbl->SetGUID)((ICreateErrorInfo*)Unsafe.AsPointer(ref this), rguid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("LPOLESTR")] ushort* szSource)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetSource>(lpVtbl->SetSource)((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDescription([NativeTypeName("LPOLESTR")] ushort* szDescription)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetDescription>(lpVtbl->SetDescription)((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpFile([NativeTypeName("LPOLESTR")] ushort* szHelpFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHelpFile>(lpVtbl->SetHelpFile)((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHelpContext>(lpVtbl->SetHelpContext)((ICreateErrorInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public IntPtr SetGUID;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetSource;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetDescription;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public IntPtr SetHelpFile;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr SetHelpContext;
        }
    }
}
