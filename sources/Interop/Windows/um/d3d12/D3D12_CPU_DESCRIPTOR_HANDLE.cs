// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct D3D12_CPU_DESCRIPTOR_HANDLE
    {
        #region Default Instances
        public static readonly D3D12_CPU_DESCRIPTOR_HANDLE DEFAULT = new D3D12_CPU_DESCRIPTOR_HANDLE() { ptr = UIntPtr.Zero };
        #endregion

        #region Fields
        [NativeTypeName("SIZE_T")]
        public UIntPtr ptr;
        #endregion

        #region Constructors
        public D3D12_CPU_DESCRIPTOR_HANDLE(D3D12_CPU_DESCRIPTOR_HANDLE* other, int offsetScaledByIncrementSize)
        {
            fixed (D3D12_CPU_DESCRIPTOR_HANDLE* pThis = &this)
            {
                InitOffsetted(pThis, other, offsetScaledByIncrementSize);
            }
        }

        public D3D12_CPU_DESCRIPTOR_HANDLE(D3D12_CPU_DESCRIPTOR_HANDLE* other, int offsetInDescriptors, uint descriptorIncrementSize)
        {
            fixed (D3D12_CPU_DESCRIPTOR_HANDLE* pThis = &this)
            {
                InitOffsetted(pThis, other, offsetInDescriptors, descriptorIncrementSize);
            }
        }
        #endregion

        #region Operators
        public static bool operator ==(D3D12_CPU_DESCRIPTOR_HANDLE l, D3D12_CPU_DESCRIPTOR_HANDLE r)
        {
            return l.ptr == r.ptr;
        }

        public static bool operator !=(D3D12_CPU_DESCRIPTOR_HANDLE l, D3D12_CPU_DESCRIPTOR_HANDLE r)
        {
            return l.ptr != r.ptr;
        }
        #endregion

        #region Methods
        public D3D12_CPU_DESCRIPTOR_HANDLE Offset(int offsetInDescriptors, uint descriptorIncrementSize)
        {
            if (UIntPtr.Size == 4)
            {
                ptr = (UIntPtr)((uint)ptr + (uint)(offsetInDescriptors * descriptorIncrementSize));
            }
            else
            {
                ptr = (UIntPtr)((ulong)ptr + (ulong)(offsetInDescriptors * descriptorIncrementSize));
            }
            return this;
        }

        public D3D12_CPU_DESCRIPTOR_HANDLE Offset(int offsetScaledByIncrementSize) 
        { 
            ptr += offsetScaledByIncrementSize;
            return this;
        }

        public void InitOffsetted(D3D12_CPU_DESCRIPTOR_HANDLE* @base, int offsetScaledByIncrementSize)
        {
            fixed (D3D12_CPU_DESCRIPTOR_HANDLE* pThis = &this)
            {
                InitOffsetted(pThis, @base, offsetScaledByIncrementSize);
            }
        }

        public void InitOffsetted(D3D12_CPU_DESCRIPTOR_HANDLE* @base, int offsetInDescriptors, uint descriptorIncrementSize)
        {
            fixed (D3D12_CPU_DESCRIPTOR_HANDLE* pThis = &this)
            {
                InitOffsetted(pThis, @base, offsetInDescriptors, descriptorIncrementSize);
            }
        }

        public static void InitOffsetted(D3D12_CPU_DESCRIPTOR_HANDLE* handle, D3D12_CPU_DESCRIPTOR_HANDLE* @base, int offsetScaledByIncrementSize)
        {
            handle->ptr = @base->ptr + offsetScaledByIncrementSize;
        }

        public static void InitOffsetted(D3D12_CPU_DESCRIPTOR_HANDLE* handle, D3D12_CPU_DESCRIPTOR_HANDLE* @base, int offsetInDescriptors, uint descriptorIncrementSize)
        {
            if (UIntPtr.Size == 4)
            {
                handle->ptr = (UIntPtr)((uint)@base->ptr + (uint)(offsetInDescriptors * descriptorIncrementSize));
            }
            else
            {
                handle->ptr = (UIntPtr)((ulong)@base->ptr + (ulong)(offsetInDescriptors * descriptorIncrementSize));
            }
        }
        #endregion

        #region System.Object
        public override bool Equals(object obj)
        {
            return (obj is D3D12_CPU_DESCRIPTOR_HANDLE other) && (this == other);
        }

        public override int GetHashCode()
        {
            return ptr.GetHashCode();
        }
        #endregion
    }
}
