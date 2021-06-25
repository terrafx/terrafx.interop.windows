// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeFactory : IUnknown")]
    public unsafe partial struct ITypeFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITypeFactory*, Guid*, void**, int>)(lpVtbl[0]))((ITypeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITypeFactory*, uint>)(lpVtbl[1]))((ITypeFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITypeFactory*, uint>)(lpVtbl[2]))((ITypeFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFromTypeInfo(ITypeInfo* pTypeInfo, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppv)
        {
            return ((delegate* unmanaged<ITypeFactory*, ITypeInfo*, Guid*, IUnknown**, int>)(lpVtbl[3]))((ITypeFactory*)Unsafe.AsPointer(ref this), pTypeInfo, riid, ppv);
        }
    }
}
