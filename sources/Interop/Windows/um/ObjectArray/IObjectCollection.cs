// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjectArray.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5632B1A4-E38A-400A-928A-D4CD63230295")]
    [NativeTypeName("struct IObjectCollection : IObjectArray")]
    [NativeInheritance("IObjectArray")]
    public unsafe partial struct IObjectCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectCollection*, Guid*, void**, int>)(lpVtbl[0]))((IObjectCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectCollection*, uint>)(lpVtbl[1]))((IObjectCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectCollection*, uint>)(lpVtbl[2]))((IObjectCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount([NativeTypeName("UINT *")] uint* pcObjects)
        {
            return ((delegate* unmanaged<IObjectCollection*, uint*, int>)(lpVtbl[3]))((IObjectCollection*)Unsafe.AsPointer(ref this), pcObjects);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAt([NativeTypeName("UINT")] uint uiIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IObjectCollection*, uint, Guid*, void**, int>)(lpVtbl[4]))((IObjectCollection*)Unsafe.AsPointer(ref this), uiIndex, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddObject(IUnknown* punk)
        {
            return ((delegate* unmanaged<IObjectCollection*, IUnknown*, int>)(lpVtbl[5]))((IObjectCollection*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AddFromArray(IObjectArray* poaSource)
        {
            return ((delegate* unmanaged<IObjectCollection*, IObjectArray*, int>)(lpVtbl[6]))((IObjectCollection*)Unsafe.AsPointer(ref this), poaSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT RemoveObjectAt([NativeTypeName("UINT")] uint uiIndex)
        {
            return ((delegate* unmanaged<IObjectCollection*, uint, int>)(lpVtbl[7]))((IObjectCollection*)Unsafe.AsPointer(ref this), uiIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Clear()
        {
            return ((delegate* unmanaged<IObjectCollection*, int>)(lpVtbl[8]))((IObjectCollection*)Unsafe.AsPointer(ref this));
        }
    }
}
