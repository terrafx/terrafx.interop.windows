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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ICreateErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ICreateErrorInfo*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetGUID([NativeTypeName("const GUID &")] Guid* rguid)
        {
            return lpVtbl->SetGUID((ICreateErrorInfo*)Unsafe.AsPointer(ref this), rguid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSource([NativeTypeName("LPOLESTR")] ushort* szSource)
        {
            return lpVtbl->SetSource((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szSource);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDescription([NativeTypeName("LPOLESTR")] ushort* szDescription)
        {
            return lpVtbl->SetDescription((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szDescription);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpFile([NativeTypeName("LPOLESTR")] ushort* szHelpFile)
        {
            return lpVtbl->SetHelpFile((ICreateErrorInfo*)Unsafe.AsPointer(ref this), szHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
        {
            return lpVtbl->SetHelpContext((ICreateErrorInfo*)Unsafe.AsPointer(ref this), dwHelpContext);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateErrorInfo*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateErrorInfo*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ICreateErrorInfo*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateErrorInfo*, Guid*, int> SetGUID;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateErrorInfo*, ushort*, int> SetSource;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateErrorInfo*, ushort*, int> SetDescription;

            [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateErrorInfo*, ushort*, int> SetHelpFile;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<ICreateErrorInfo*, uint, int> SetHelpContext;
        }
    }
}
