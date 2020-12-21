// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E7174CFA-1C9E-48B1-8866-626226BFC258")]
    [NativeTypeName("struct IMFDXGIBuffer : IUnknown")]
    public unsafe partial struct IMFDXGIBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDXGIBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IMFDXGIBuffer*, uint>)(lpVtbl[1]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IMFDXGIBuffer*, uint>)(lpVtbl[2]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResource([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDXGIBuffer*, Guid*, void**, int>)(lpVtbl[3]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSubresourceIndex([NativeTypeName("UINT *")] uint* puSubresource)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDXGIBuffer*, uint*, int>)(lpVtbl[4]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), puSubresource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnknown([NativeTypeName("const IID &")] Guid* guid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDXGIBuffer*, Guid*, Guid*, void**, int>)(lpVtbl[5]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), guid, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnknown([NativeTypeName("const IID &")] Guid* guid, [NativeTypeName("IUnknown *")] IUnknown* pUnkData)
        {
            return ((delegate* unmanaged[Stdcall]<IMFDXGIBuffer*, Guid*, IUnknown*, int>)(lpVtbl[6]))((IMFDXGIBuffer*)Unsafe.AsPointer(ref this), guid, pUnkData);
        }
    }
}
