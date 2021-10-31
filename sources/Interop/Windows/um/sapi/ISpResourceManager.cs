// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("93384E18-5014-43D5-ADBB-A78E055926BD")]
    [NativeTypeName("struct ISpResourceManager : IServiceProvider")]
    [NativeInheritance("IServiceProvider")]
    public unsafe partial struct ISpResourceManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpResourceManager*, Guid*, void**, int>)(lpVtbl[0]))((ISpResourceManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpResourceManager*, uint>)(lpVtbl[1]))((ISpResourceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpResourceManager*, uint>)(lpVtbl[2]))((ISpResourceManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int QueryService([NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpResourceManager*, Guid*, Guid*, void**, int>)(lpVtbl[3]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidService, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetObject([NativeTypeName("const GUID &")] Guid* guidServiceId, IUnknown* pUnkObject)
        {
            return ((delegate* unmanaged<ISpResourceManager*, Guid*, IUnknown*, int>)(lpVtbl[4]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidServiceId, pUnkObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetObject([NativeTypeName("const GUID &")] Guid* guidServiceId, [NativeTypeName("const IID &")] Guid* ObjectCLSID, [NativeTypeName("const IID &")] Guid* ObjectIID, BOOL fReleaseWhenLastExternalRefReleased, void** ppObject)
        {
            return ((delegate* unmanaged<ISpResourceManager*, Guid*, Guid*, Guid*, BOOL, void**, int>)(lpVtbl[5]))((ISpResourceManager*)Unsafe.AsPointer(ref this), guidServiceId, ObjectCLSID, ObjectIID, fReleaseWhenLastExternalRefReleased, ppObject);
        }
    }
}
