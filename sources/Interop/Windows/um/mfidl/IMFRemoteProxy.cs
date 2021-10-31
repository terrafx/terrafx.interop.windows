// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("994E23AD-1CC2-493C-B9FA-46F1CB040FA4")]
    [NativeTypeName("struct IMFRemoteProxy : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFRemoteProxy
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFRemoteProxy*, Guid*, void**, int>)(lpVtbl[0]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFRemoteProxy*, uint>)(lpVtbl[1]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFRemoteProxy*, uint>)(lpVtbl[2]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetRemoteObject([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IMFRemoteProxy*, Guid*, void**, int>)(lpVtbl[3]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRemoteHost([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IMFRemoteProxy*, Guid*, void**, int>)(lpVtbl[4]))((IMFRemoteProxy*)Unsafe.AsPointer(ref this), riid, ppv);
        }
    }
}
