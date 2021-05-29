// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B283-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IProvideClassInfo : IUnknown")]
    public unsafe partial struct IProvideClassInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IProvideClassInfo*, Guid*, void**, int>)(lpVtbl[0]))((IProvideClassInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProvideClassInfo*, uint>)(lpVtbl[1]))((IProvideClassInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProvideClassInfo*, uint>)(lpVtbl[2]))((IProvideClassInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassInfo(ITypeInfo** ppTI)
        {
            return ((delegate* unmanaged<IProvideClassInfo*, ITypeInfo**, int>)(lpVtbl[3]))((IProvideClassInfo*)Unsafe.AsPointer(ref this), ppTI);
        }
    }
}
