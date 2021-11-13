// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.media.core.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("20BE1E2E-930F-4746-9335-3C332F255093")]
    [NativeTypeName("struct IAudioFrameNative : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IAudioFrameNative : IAudioFrameNative.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioFrameNative*, Guid*, void**, int>)(lpVtbl[0]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioFrameNative*, uint>)(lpVtbl[1]))((IAudioFrameNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioFrameNative*, uint>)(lpVtbl[2]))((IAudioFrameNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IAudioFrameNative*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IAudioFrameNative*, HSTRING*, int>)(lpVtbl[4]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IAudioFrameNative*, TrustLevel*, int>)(lpVtbl[5]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetData([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<IAudioFrameNative*, Guid*, void**, int>)(lpVtbl[6]))((IAudioFrameNative*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public interface Interface : IInspectable.Interface
        {
            [VtblIndex(6)]
            HRESULT GetData([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioFrameNative*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioFrameNative*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioFrameNative*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioFrameNative*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioFrameNative*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioFrameNative*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAudioFrameNative*, Guid*, void**, int> GetData;
        }
    }
}
