// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC4801A3-2BA9-11CF-A229-00AA003D7352")]
    [NativeTypeName("struct IObjectWithSite : IUnknown")]
    public unsafe partial struct IObjectWithSite
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectWithSite*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectWithSite*, uint>)(lpVtbl[1]))((IObjectWithSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectWithSite*, uint>)(lpVtbl[2]))((IObjectWithSite*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetSite([NativeTypeName("IUnknown *")] IUnknown* pUnkSite)
        {
            return ((delegate* unmanaged<IObjectWithSite*, IUnknown*, int>)(lpVtbl[3]))((IObjectWithSite*)Unsafe.AsPointer(ref this), pUnkSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSite([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvSite)
        {
            return ((delegate* unmanaged<IObjectWithSite*, Guid*, void**, int>)(lpVtbl[4]))((IObjectWithSite*)Unsafe.AsPointer(ref this), riid, ppvSite);
        }
    }
}
