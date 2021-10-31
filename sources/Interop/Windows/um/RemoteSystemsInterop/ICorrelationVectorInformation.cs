// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RemoteSystemsInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83C78B3C-D88B-4950-AA6E-22B8D22AABD3")]
    [NativeTypeName("struct ICorrelationVectorInformation : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct ICorrelationVectorInformation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, Guid*, void**, int>)(lpVtbl[0]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, uint>)(lpVtbl[1]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, uint>)(lpVtbl[2]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, uint*, Guid**, int>)(lpVtbl[3]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, HSTRING*, int>)(lpVtbl[4]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, TrustLevel*, int>)(lpVtbl[5]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_LastCorrelationVectorForThread(HSTRING* cv)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, HSTRING*, int>)(lpVtbl[6]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), cv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_NextCorrelationVectorForThread(HSTRING* cv)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, HSTRING*, int>)(lpVtbl[7]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), cv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_NextCorrelationVectorForThread(HSTRING cv)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, HSTRING, int>)(lpVtbl[8]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), cv);
        }
    }
}
