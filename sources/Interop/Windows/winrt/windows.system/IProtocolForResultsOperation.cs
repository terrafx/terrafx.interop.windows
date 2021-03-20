// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D581293A-6DE9-4D28-9378-F86782E182BB")]
    [NativeTypeName("struct IProtocolForResultsOperation : IInspectable")]
    public unsafe partial struct IProtocolForResultsOperation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IProtocolForResultsOperation*, Guid*, void**, int>)(lpVtbl[0]))((IProtocolForResultsOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IProtocolForResultsOperation*, uint>)(lpVtbl[1]))((IProtocolForResultsOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IProtocolForResultsOperation*, uint>)(lpVtbl[2]))((IProtocolForResultsOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IProtocolForResultsOperation*, uint*, Guid**, int>)(lpVtbl[3]))((IProtocolForResultsOperation*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IProtocolForResultsOperation*, IntPtr*, int>)(lpVtbl[4]))((IProtocolForResultsOperation*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IProtocolForResultsOperation*, TrustLevel*, int>)(lpVtbl[5]))((IProtocolForResultsOperation*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReportCompleted([NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")] IPropertySet* data)
        {
            return ((delegate* unmanaged<IProtocolForResultsOperation*, IPropertySet*, int>)(lpVtbl[6]))((IProtocolForResultsOperation*)Unsafe.AsPointer(ref this), data);
        }
    }
}
