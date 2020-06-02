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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("GUID *")] Guid* pGUID)
        {
            return lpVtbl->GetGUID((IErrorInfo*)Unsafe.AsPointer(ref this), pGUID);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSource([NativeTypeName("BSTR *")] ushort** pBstrSource)
        {
            return lpVtbl->GetSource((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pBstrDescription)
        {
            return lpVtbl->GetDescription((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpFile([NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return lpVtbl->GetHelpFile((IErrorInfo*)Unsafe.AsPointer(ref this), pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHelpContext([NativeTypeName("DWORD *")] uint* pdwHelpContext)
        {
            return lpVtbl->GetHelpContext((IErrorInfo*)Unsafe.AsPointer(ref this), pdwHelpContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IErrorInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IErrorInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IErrorInfo*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IErrorInfo*, Guid*, int> GetGUID;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IErrorInfo*, ushort**, int> GetSource;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IErrorInfo*, ushort**, int> GetDescription;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IErrorInfo*, ushort**, int> GetHelpFile;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IErrorInfo*, uint*, int> GetHelpContext;
        }
    }
}
