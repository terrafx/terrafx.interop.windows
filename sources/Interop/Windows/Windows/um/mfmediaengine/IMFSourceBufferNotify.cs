// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    [Guid("87E47623-2CEB-45D6-9B88-D8520C4DCBBC")]
    [NativeTypeName("struct IMFSourceBufferNotify : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSourceBufferNotify : IMFSourceBufferNotify.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceBufferNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceBufferNotify*, uint>)(lpVtbl[1]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceBufferNotify*, uint>)(lpVtbl[2]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void OnUpdateStart()
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, void>)(lpVtbl[3]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void OnAbort()
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, void>)(lpVtbl[4]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void OnError(HRESULT hr)
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, HRESULT, void>)(lpVtbl[5]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void OnUpdate()
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, void>)(lpVtbl[6]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void OnUpdateEnd()
        {
            ((delegate* unmanaged<IMFSourceBufferNotify*, void>)(lpVtbl[7]))((IMFSourceBufferNotify*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            void OnUpdateStart();

            [VtblIndex(4)]
            void OnAbort();

            [VtblIndex(5)]
            void OnError(HRESULT hr);

            [VtblIndex(6)]
            void OnUpdate();

            [VtblIndex(7)]
            void OnUpdateEnd();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferNotify*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferNotify*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferNotify*, uint> Release;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferNotify*, void> OnUpdateStart;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferNotify*, void> OnAbort;

            [NativeTypeName("void (HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferNotify*, HRESULT, void> OnError;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferNotify*, void> OnUpdate;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceBufferNotify*, void> OnUpdateEnd;
        }
    }
}
