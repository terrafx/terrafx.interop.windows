// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0A53EB6C-1908-4742-8CFF-2CEE2E93F94C")]
    [NativeTypeName("struct ICoCreatedLocally : IUnknown")]
    public unsafe partial struct ICoCreatedLocally
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICoCreatedLocally*, Guid*, void**, int>)(lpVtbl[0]))((ICoCreatedLocally*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICoCreatedLocally*, uint>)(lpVtbl[1]))((ICoCreatedLocally*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICoCreatedLocally*, uint>)(lpVtbl[2]))((ICoCreatedLocally*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LocalInit(IUnknown* punkLocalObject, [NativeTypeName("const IID &")] Guid* riidParam, IUnknown* punkParam, VARIANT varParam)
        {
            return ((delegate* unmanaged<ICoCreatedLocally*, IUnknown*, Guid*, IUnknown*, VARIANT, int>)(lpVtbl[3]))((ICoCreatedLocally*)Unsafe.AsPointer(ref this), punkLocalObject, riidParam, punkParam, varParam);
        }
    }
}
