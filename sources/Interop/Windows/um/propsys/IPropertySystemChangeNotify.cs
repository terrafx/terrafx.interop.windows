// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FA955FD9-38BE-4879-A6CE-824CF52D609F")]
    [NativeTypeName("struct IPropertySystemChangeNotify : IUnknown")]
    public unsafe partial struct IPropertySystemChangeNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertySystemChangeNotify*, Guid*, void**, int>)(lpVtbl[0]))((IPropertySystemChangeNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertySystemChangeNotify*, uint>)(lpVtbl[1]))((IPropertySystemChangeNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertySystemChangeNotify*, uint>)(lpVtbl[2]))((IPropertySystemChangeNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SchemaRefreshed()
        {
            return ((delegate* unmanaged<IPropertySystemChangeNotify*, int>)(lpVtbl[3]))((IPropertySystemChangeNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
