// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C7B236CE-EE80-11D0-985F-006008059382")]
    [NativeTypeName("struct IQueryCodePage : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IQueryCodePage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IQueryCodePage*, Guid*, void**, int>)(lpVtbl[0]))((IQueryCodePage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IQueryCodePage*, uint>)(lpVtbl[1]))((IQueryCodePage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IQueryCodePage*, uint>)(lpVtbl[2]))((IQueryCodePage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetCodePage([NativeTypeName("UINT *")] uint* puiCodePage)
        {
            return ((delegate* unmanaged<IQueryCodePage*, uint*, int>)(lpVtbl[3]))((IQueryCodePage*)Unsafe.AsPointer(ref this), puiCodePage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetCodePage([NativeTypeName("UINT")] uint uiCodePage)
        {
            return ((delegate* unmanaged<IQueryCodePage*, uint, int>)(lpVtbl[4]))((IQueryCodePage*)Unsafe.AsPointer(ref this), uiCodePage);
        }
    }
}
