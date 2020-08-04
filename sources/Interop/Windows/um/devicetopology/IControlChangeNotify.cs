// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A09513ED-C709-4D21-BD7B-5F34C47F3947")]
    public unsafe partial struct IControlChangeNotify
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IControlChangeNotify*, Guid*, void**, int>)(lpVtbl[0]))((IControlChangeNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IControlChangeNotify*, uint>)(lpVtbl[1]))((IControlChangeNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IControlChangeNotify*, uint>)(lpVtbl[2]))((IControlChangeNotify*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int OnNotify([NativeTypeName("DWORD")] uint dwSenderProcessId, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* stdcall<IControlChangeNotify*, uint, Guid*, int>)(lpVtbl[3]))((IControlChangeNotify*)Unsafe.AsPointer(ref this), dwSenderProcessId, pguidEventContext);
        }
    }
}
