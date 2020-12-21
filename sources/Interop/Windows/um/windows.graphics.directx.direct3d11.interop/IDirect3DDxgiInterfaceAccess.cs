// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9B3D012-3DF2-4EE3-B8D1-8695F457D3C1")]
    [NativeTypeName("struct IDirect3DDxgiInterfaceAccess : IUnknown")]
    public unsafe partial struct IDirect3DDxgiInterfaceAccess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DDxgiInterfaceAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, uint>)(lpVtbl[1]))((IDirect3DDxgiInterfaceAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, uint>)(lpVtbl[2]))((IDirect3DDxgiInterfaceAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetInterface([NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** p)
        {
            return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess*, Guid*, void**, int>)(lpVtbl[3]))((IDirect3DDxgiInterfaceAccess*)Unsafe.AsPointer(ref this), iid, p);
        }
    }
}
