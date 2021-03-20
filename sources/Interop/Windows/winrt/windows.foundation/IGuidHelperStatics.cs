// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("59C7966B-AE52-5283-AD7F-A1B9E9678ADD")]
    [NativeTypeName("struct IGuidHelperStatics : IInspectable")]
    public unsafe partial struct IGuidHelperStatics
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, Guid*, void**, int>)(lpVtbl[0]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, uint>)(lpVtbl[1]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, uint>)(lpVtbl[2]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, IntPtr*, int>)(lpVtbl[4]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, TrustLevel*, int>)(lpVtbl[5]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateNewGuid([NativeTypeName("GUID *")] Guid* result)
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, Guid*, int>)(lpVtbl[6]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this), result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Empty([NativeTypeName("GUID *")] Guid* value)
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, Guid*, int>)(lpVtbl[7]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Equals([NativeTypeName("const GUID *")] Guid* target, [NativeTypeName("const GUID *")] Guid* value, [NativeTypeName("boolean *")] byte* result)
        {
            return ((delegate* unmanaged<IGuidHelperStatics*, Guid*, Guid*, byte*, int>)(lpVtbl[8]))((IGuidHelperStatics*)Unsafe.AsPointer(ref this), target, value, result);
        }
    }
}
