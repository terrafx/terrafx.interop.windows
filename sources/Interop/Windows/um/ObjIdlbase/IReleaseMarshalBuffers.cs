// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EB0CB9E8-7996-11D2-872E-0000F8080859")]
    public unsafe partial struct IReleaseMarshalBuffers
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IReleaseMarshalBuffers*, Guid*, void**, int>)(lpVtbl[0]))((IReleaseMarshalBuffers*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IReleaseMarshalBuffers*, uint>)(lpVtbl[1]))((IReleaseMarshalBuffers*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IReleaseMarshalBuffers*, uint>)(lpVtbl[2]))((IReleaseMarshalBuffers*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseMarshalBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("IUnknown *")] IUnknown* pChnl)
        {
            return ((delegate* stdcall<IReleaseMarshalBuffers*, RPCOLEMESSAGE*, uint, IUnknown*, int>)(lpVtbl[3]))((IReleaseMarshalBuffers*)Unsafe.AsPointer(ref this), pMsg, dwFlags, pChnl);
        }
    }
}
