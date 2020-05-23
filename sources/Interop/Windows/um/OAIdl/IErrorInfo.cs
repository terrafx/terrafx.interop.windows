// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1CF2B120-547D-101B-8E65-08002B2BD119")]
    public unsafe partial struct IErrorInfo
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IErrorInfo* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IErrorInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IErrorInfo* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGUID(IErrorInfo* pThis, [NativeTypeName("GUID *")] Guid* pGUID);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSource(IErrorInfo* pThis, [NativeTypeName("BSTR *")] ushort** pBstrSource);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDescription(IErrorInfo* pThis, [NativeTypeName("BSTR *")] ushort** pBstrDescription);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHelpFile(IErrorInfo* pThis, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetHelpContext(IErrorInfo* pThis, [NativeTypeName("DWORD *")] uint* pdwHelpContext);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("GUID *")] Guid* pGUID)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGUID>(lpVtbl->GetGUID)((IErrorInfo*)Unsafe.AsPointer(ref this), pGUID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSource([NativeTypeName("BSTR *")] ushort** pBstrSource)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSource>(lpVtbl->GetSource)((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pBstrDescription)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDescription>(lpVtbl->GetDescription)((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpFile([NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHelpFile>(lpVtbl->GetHelpFile)((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpContext([NativeTypeName("DWORD *")] uint* pdwHelpContext)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetHelpContext>(lpVtbl->GetHelpContext)((IErrorInfo*)Unsafe.AsPointer(ref this), pdwHelpContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public IntPtr GetGUID;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetSource;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetDescription;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public IntPtr GetHelpFile;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public IntPtr GetHelpContext;
        }
    }
}
