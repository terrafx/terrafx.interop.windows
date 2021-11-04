// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B2DAAD8B-03D4-4DBF-95EB-32AB4B63D0AB")]
    [NativeTypeName("struct ID3DUserDefinedAnnotation : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3DUserDefinedAnnotation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, Guid*, void**, int>)(lpVtbl[0]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, uint>)(lpVtbl[1]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, uint>)(lpVtbl[2]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public int BeginEvent([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, ushort*, int>)(lpVtbl[3]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public int EndEvent()
        {
            return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, int>)(lpVtbl[4]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetMarker([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            ((delegate* unmanaged<ID3DUserDefinedAnnotation*, ushort*, void>)(lpVtbl[5]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public BOOL GetStatus()
        {
            return ((delegate* unmanaged<ID3DUserDefinedAnnotation*, int>)(lpVtbl[6]))((ID3DUserDefinedAnnotation*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DUserDefinedAnnotation*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DUserDefinedAnnotation*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DUserDefinedAnnotation*, uint> Release;

            [NativeTypeName("INT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DUserDefinedAnnotation*, ushort*, int> BeginEvent;

            [NativeTypeName("INT () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DUserDefinedAnnotation*, int> EndEvent;

            [NativeTypeName("void (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DUserDefinedAnnotation*, ushort*, void> SetMarker;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public delegate* unmanaged<ID3DUserDefinedAnnotation*, int> GetStatus;
        }
    }
}
