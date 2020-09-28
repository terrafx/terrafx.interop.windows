// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RemoteSystemsInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("83C78B3C-D88B-4950-AA6E-22B8D22AABD3")]
    [NativeTypeName("struct ICorrelationVectorInformation : IInspectable")]
    public unsafe partial struct ICorrelationVectorInformation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, Guid*, void**, int>)(lpVtbl[0]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, uint>)(lpVtbl[1]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, uint>)(lpVtbl[2]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, uint*, Guid**, int>)(lpVtbl[3]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, IntPtr*, int>)(lpVtbl[4]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, TrustLevel*, int>)(lpVtbl[5]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_LastCorrelationVectorForThread([NativeTypeName("HSTRING *")] IntPtr* cv)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, IntPtr*, int>)(lpVtbl[6]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), cv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NextCorrelationVectorForThread([NativeTypeName("HSTRING *")] IntPtr* cv)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, IntPtr*, int>)(lpVtbl[7]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), cv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_NextCorrelationVectorForThread([NativeTypeName("HSTRING")] IntPtr cv)
        {
            return ((delegate* unmanaged<ICorrelationVectorInformation*, IntPtr, int>)(lpVtbl[8]))((ICorrelationVectorInformation*)Unsafe.AsPointer(ref this), cv);
        }
    }
}
