// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B28B-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct ISpecifyPropertyPages : IUnknown")]
    public unsafe partial struct ISpecifyPropertyPages
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpecifyPropertyPages*, Guid*, void**, int>)(lpVtbl[0]))((ISpecifyPropertyPages*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpecifyPropertyPages*, uint>)(lpVtbl[1]))((ISpecifyPropertyPages*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpecifyPropertyPages*, uint>)(lpVtbl[2]))((ISpecifyPropertyPages*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPages(CAUUID* pPages)
        {
            return ((delegate* unmanaged<ISpecifyPropertyPages*, CAUUID*, int>)(lpVtbl[3]))((ISpecifyPropertyPages*)Unsafe.AsPointer(ref this), pPages);
        }
    }
}
