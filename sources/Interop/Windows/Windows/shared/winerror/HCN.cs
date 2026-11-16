// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HCN
{
    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_NETWORK_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_NETWORK_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0001L)")]
    public const int HCN_E_NETWORK_NOT_FOUND = unchecked((int)(0x803B0001));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ENDPOINT_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_ENDPOINT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0002L)")]
    public const int HCN_E_ENDPOINT_NOT_FOUND = unchecked((int)(0x803B0002));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_LAYER_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_LAYER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0003L)")]
    public const int HCN_E_LAYER_NOT_FOUND = unchecked((int)(0x803B0003));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_SWITCH_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_SWITCH_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0004L)")]
    public const int HCN_E_SWITCH_NOT_FOUND = unchecked((int)(0x803B0004));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_SUBNET_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_SUBNET_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0005L)")]
    public const int HCN_E_SUBNET_NOT_FOUND = unchecked((int)(0x803B0005));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ADAPTER_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0006L)")]
    public const int HCN_E_ADAPTER_NOT_FOUND = unchecked((int)(0x803B0006));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_PORT_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_PORT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0007L)")]
    public const int HCN_E_PORT_NOT_FOUND = unchecked((int)(0x803B0007));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_POLICY_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_POLICY_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0008L)")]
    public const int HCN_E_POLICY_NOT_FOUND = unchecked((int)(0x803B0008));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_VFP_PORTSETTING_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_VFP_PORTSETTING_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0009L)")]
    public const int HCN_E_VFP_PORTSETTING_NOT_FOUND = unchecked((int)(0x803B0009));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_NETWORK"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_NETWORK _HRESULT_TYPEDEF_(0x803B000AL)")]
    public const int HCN_E_INVALID_NETWORK = unchecked((int)(0x803B000A));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_NETWORK_TYPE"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_NETWORK_TYPE _HRESULT_TYPEDEF_(0x803B000BL)")]
    public const int HCN_E_INVALID_NETWORK_TYPE = unchecked((int)(0x803B000B));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_ENDPOINT"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_ENDPOINT _HRESULT_TYPEDEF_(0x803B000CL)")]
    public const int HCN_E_INVALID_ENDPOINT = unchecked((int)(0x803B000C));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_POLICY"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_POLICY _HRESULT_TYPEDEF_(0x803B000DL)")]
    public const int HCN_E_INVALID_POLICY = unchecked((int)(0x803B000D));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_POLICY_TYPE"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_POLICY_TYPE _HRESULT_TYPEDEF_(0x803B000EL)")]
    public const int HCN_E_INVALID_POLICY_TYPE = unchecked((int)(0x803B000E));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_REMOTE_ENDPOINT_OPERATION"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_REMOTE_ENDPOINT_OPERATION _HRESULT_TYPEDEF_(0x803B000FL)")]
    public const int HCN_E_INVALID_REMOTE_ENDPOINT_OPERATION = unchecked((int)(0x803B000F));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_NETWORK_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define HCN_E_NETWORK_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0010L)")]
    public const int HCN_E_NETWORK_ALREADY_EXISTS = unchecked((int)(0x803B0010));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_LAYER_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define HCN_E_LAYER_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0011L)")]
    public const int HCN_E_LAYER_ALREADY_EXISTS = unchecked((int)(0x803B0011));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_POLICY_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define HCN_E_POLICY_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0012L)")]
    public const int HCN_E_POLICY_ALREADY_EXISTS = unchecked((int)(0x803B0012));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_PORT_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define HCN_E_PORT_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B0013L)")]
    public const int HCN_E_PORT_ALREADY_EXISTS = unchecked((int)(0x803B0013));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ENDPOINT_ALREADY_ATTACHED"]/*' />
    [NativeTypeName("#define HCN_E_ENDPOINT_ALREADY_ATTACHED _HRESULT_TYPEDEF_(0x803B0014L)")]
    public const int HCN_E_ENDPOINT_ALREADY_ATTACHED = unchecked((int)(0x803B0014));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_REQUEST_UNSUPPORTED"]/*' />
    [NativeTypeName("#define HCN_E_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x803B0015L)")]
    public const int HCN_E_REQUEST_UNSUPPORTED = unchecked((int)(0x803B0015));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_MAPPING_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define HCN_E_MAPPING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803B0016L)")]
    public const int HCN_E_MAPPING_NOT_SUPPORTED = unchecked((int)(0x803B0016));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_DEGRADED_OPERATION"]/*' />
    [NativeTypeName("#define HCN_E_DEGRADED_OPERATION _HRESULT_TYPEDEF_(0x803B0017L)")]
    public const int HCN_E_DEGRADED_OPERATION = unchecked((int)(0x803B0017));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_SHARED_SWITCH_MODIFICATION"]/*' />
    [NativeTypeName("#define HCN_E_SHARED_SWITCH_MODIFICATION _HRESULT_TYPEDEF_(0x803B0018L)")]
    public const int HCN_E_SHARED_SWITCH_MODIFICATION = unchecked((int)(0x803B0018));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_GUID_CONVERSION_FAILURE"]/*' />
    [NativeTypeName("#define HCN_E_GUID_CONVERSION_FAILURE _HRESULT_TYPEDEF_(0x803B0019L)")]
    public const int HCN_E_GUID_CONVERSION_FAILURE = unchecked((int)(0x803B0019));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_REGKEY_FAILURE"]/*' />
    [NativeTypeName("#define HCN_E_REGKEY_FAILURE _HRESULT_TYPEDEF_(0x803B001AL)")]
    public const int HCN_E_REGKEY_FAILURE = unchecked((int)(0x803B001A));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_JSON"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_JSON _HRESULT_TYPEDEF_(0x803B001BL)")]
    public const int HCN_E_INVALID_JSON = unchecked((int)(0x803B001B));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_JSON_REFERENCE"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_JSON_REFERENCE _HRESULT_TYPEDEF_(0x803B001CL)")]
    public const int HCN_E_INVALID_JSON_REFERENCE = unchecked((int)(0x803B001C));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ENDPOINT_SHARING_DISABLED"]/*' />
    [NativeTypeName("#define HCN_E_ENDPOINT_SHARING_DISABLED _HRESULT_TYPEDEF_(0x803B001DL)")]
    public const int HCN_E_ENDPOINT_SHARING_DISABLED = unchecked((int)(0x803B001D));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_IP"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_IP _HRESULT_TYPEDEF_(0x803B001EL)")]
    public const int HCN_E_INVALID_IP = unchecked((int)(0x803B001E));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_SWITCH_EXTENSION_NOT_FOUND"]/*' />
    [NativeTypeName("#define HCN_E_SWITCH_EXTENSION_NOT_FOUND _HRESULT_TYPEDEF_(0x803B001FL)")]
    public const int HCN_E_SWITCH_EXTENSION_NOT_FOUND = unchecked((int)(0x803B001F));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_MANAGER_STOPPED"]/*' />
    [NativeTypeName("#define HCN_E_MANAGER_STOPPED _HRESULT_TYPEDEF_(0x803B0020L)")]
    public const int HCN_E_MANAGER_STOPPED = unchecked((int)(0x803B0020));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ICS_DISABLED"]/*' />
    [NativeTypeName("#define HCN_E_ICS_DISABLED _HRESULT_TYPEDEF_(0x803B002AL)")]
    public const int HCN_E_ICS_DISABLED = unchecked((int)(0x803B002A));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ENDPOINT_NAMESPACE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define HCN_E_ENDPOINT_NAMESPACE_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x803B002BL)")]
    public const int HCN_E_ENDPOINT_NAMESPACE_ALREADY_EXISTS = unchecked((int)(0x803B002B));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ENTITY_HAS_REFERENCES"]/*' />
    [NativeTypeName("#define HCN_E_ENTITY_HAS_REFERENCES _HRESULT_TYPEDEF_(0x803B002CL)")]
    public const int HCN_E_ENTITY_HAS_REFERENCES = unchecked((int)(0x803B002C));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_INTERNAL_PORT"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_INTERNAL_PORT _HRESULT_TYPEDEF_(0x803B002DL)")]
    public const int HCN_E_INVALID_INTERNAL_PORT = unchecked((int)(0x803B002D));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_NAMESPACE_ATTACH_FAILED"]/*' />
    [NativeTypeName("#define HCN_E_NAMESPACE_ATTACH_FAILED _HRESULT_TYPEDEF_(0x803B002EL)")]
    public const int HCN_E_NAMESPACE_ATTACH_FAILED = unchecked((int)(0x803B002E));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ADDR_INVALID_OR_RESERVED"]/*' />
    [NativeTypeName("#define HCN_E_ADDR_INVALID_OR_RESERVED _HRESULT_TYPEDEF_(0x803B002FL)")]
    public const int HCN_E_ADDR_INVALID_OR_RESERVED = unchecked((int)(0x803B002F));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_PREFIX"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_PREFIX _HRESULT_TYPEDEF_(0x803B0030L)")]
    public const int HCN_E_INVALID_PREFIX = unchecked((int)(0x803B0030));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_OBJECT_USED_AFTER_UNLOAD"]/*' />
    [NativeTypeName("#define HCN_E_OBJECT_USED_AFTER_UNLOAD _HRESULT_TYPEDEF_(0x803B0031L)")]
    public const int HCN_E_OBJECT_USED_AFTER_UNLOAD = unchecked((int)(0x803B0031));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_SUBNET"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_SUBNET _HRESULT_TYPEDEF_(0x803B0032L)")]
    public const int HCN_E_INVALID_SUBNET = unchecked((int)(0x803B0032));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_INVALID_IP_SUBNET"]/*' />
    [NativeTypeName("#define HCN_E_INVALID_IP_SUBNET _HRESULT_TYPEDEF_(0x803B0033L)")]
    public const int HCN_E_INVALID_IP_SUBNET = unchecked((int)(0x803B0033));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ENDPOINT_NOT_ATTACHED"]/*' />
    [NativeTypeName("#define HCN_E_ENDPOINT_NOT_ATTACHED _HRESULT_TYPEDEF_(0x803B0034L)")]
    public const int HCN_E_ENDPOINT_NOT_ATTACHED = unchecked((int)(0x803B0034));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_ENDPOINT_NOT_LOCAL"]/*' />
    [NativeTypeName("#define HCN_E_ENDPOINT_NOT_LOCAL _HRESULT_TYPEDEF_(0x803B0035L)")]
    public const int HCN_E_ENDPOINT_NOT_LOCAL = unchecked((int)(0x803B0035));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_INTERFACEPARAMETERS_ALREADY_APPLIED"]/*' />
    [NativeTypeName("#define HCN_INTERFACEPARAMETERS_ALREADY_APPLIED _HRESULT_TYPEDEF_(0x803B0036L)")]
    public const int HCN_INTERFACEPARAMETERS_ALREADY_APPLIED = unchecked((int)(0x803B0036));

    /// <include file='HCN.xml' path='doc/member[@name="HCN.HCN_E_VFP_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define HCN_E_VFP_NOT_ALLOWED _HRESULT_TYPEDEF_(0x803B0037L)")]
    public const int HCN_E_VFP_NOT_ALLOWED = unchecked((int)(0x803B0037));
}
