// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3127CA40-446E-11CE-8135-00AA004BB851")]
    public unsafe partial struct IErrorLog
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IErrorLog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IErrorLog*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IErrorLog*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddError([NativeTypeName("LPCOLESTR")] ushort* pszPropName, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo)
        {
            return lpVtbl->AddError((IErrorLog*)Unsafe.AsPointer(ref this), pszPropName, pExcepInfo);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IErrorLog*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IErrorLog*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IErrorLog*, uint> Release;

            [NativeTypeName("HRESULT (LPCOLESTR, EXCEPINFO *) __attribute__((stdcall))")]
            public delegate* stdcall<IErrorLog*, ushort*, EXCEPINFO*, int> AddError;
        }
    }
}
