// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("259684DC-37C3-11D2-9603-00C04F8EE628")]
    [NativeTypeName("struct ISpNotifySink : IUnknown")]
    public unsafe partial struct ISpNotifySink
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpNotifySink*, Guid*, void**, int>)(lpVtbl[0]))((ISpNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpNotifySink*, uint>)(lpVtbl[1]))((ISpNotifySink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpNotifySink*, uint>)(lpVtbl[2]))((ISpNotifySink*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Notify()
        {
            return ((delegate* stdcall<ISpNotifySink*, int>)(lpVtbl[3]))((ISpNotifySink*)Unsafe.AsPointer(ref this));
        }
    }
}
