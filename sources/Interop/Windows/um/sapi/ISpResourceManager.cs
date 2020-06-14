// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("93384E18-5014-43D5-ADBB-A78E055926BD")]
    public unsafe partial struct ISpResourceManager
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpResourceManager*, Guid*, void**, int>)(lpVtbl[0]))((ISpResourceManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpResourceManager*, uint>)(lpVtbl[1]))((ISpResourceManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpResourceManager*, uint>)(lpVtbl[2]))((ISpResourceManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int QueryService([NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpResourceManager*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidService, riid, ppvObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetObject([NativeTypeName("const GUID &")] Guid* guidServiceId, [NativeTypeName("IUnknown *")] IUnknown* pUnkObject)
        {
            return ((delegate* stdcall<ISpResourceManager*, Guid*, IUnknown*, int>)(lpVtbl[4]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidServiceId, pUnkObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetObjectA([NativeTypeName("const GUID &")] Guid* guidServiceId, [NativeTypeName("const IID &")] Guid* ObjectCLSID, [NativeTypeName("const IID &")] Guid* ObjectIID, [NativeTypeName("BOOL")] int fReleaseWhenLastExternalRefReleased, [NativeTypeName("void **")] void** ppObject)
        {
            return ((delegate* stdcall<ISpResourceManager*, Guid*, Guid*, Guid*, int, void**, int>)(lpVtbl[5]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidServiceId, ObjectCLSID, ObjectIID, fReleaseWhenLastExternalRefReleased, ppObject);
        }
    }
}
