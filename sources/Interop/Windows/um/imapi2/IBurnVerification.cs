// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D2FFD834-958B-426D-8470-2A13879C6A91")]
    [NativeTypeName("struct IBurnVerification : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBurnVerification
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBurnVerification*, Guid*, void**, int>)(lpVtbl[0]))((IBurnVerification*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBurnVerification*, uint>)(lpVtbl[1]))((IBurnVerification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBurnVerification*, uint>)(lpVtbl[2]))((IBurnVerification*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT put_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL value)
        {
            return ((delegate* unmanaged<IBurnVerification*, IMAPI_BURN_VERIFICATION_LEVEL, int>)(lpVtbl[3]))((IBurnVerification*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT get_BurnVerificationLevel(IMAPI_BURN_VERIFICATION_LEVEL* value)
        {
            return ((delegate* unmanaged<IBurnVerification*, IMAPI_BURN_VERIFICATION_LEVEL*, int>)(lpVtbl[4]))((IBurnVerification*)Unsafe.AsPointer(ref this), value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBurnVerification*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBurnVerification*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBurnVerification*, uint> Release;

            [NativeTypeName("HRESULT (IMAPI_BURN_VERIFICATION_LEVEL) __attribute__((stdcall))")]
            public delegate* unmanaged<IBurnVerification*, IMAPI_BURN_VERIFICATION_LEVEL, int> put_BurnVerificationLevel;

            [NativeTypeName("HRESULT (IMAPI_BURN_VERIFICATION_LEVEL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IBurnVerification*, IMAPI_BURN_VERIFICATION_LEVEL*, int> get_BurnVerificationLevel;
        }
    }
}
