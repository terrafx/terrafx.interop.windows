// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PRODUCT
{
    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_UNDEFINED"]/*' />
    [NativeTypeName("#define PRODUCT_UNDEFINED 0x00000000")]
    public const int PRODUCT_UNDEFINED = 0x00000000;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ULTIMATE"]/*' />
    [NativeTypeName("#define PRODUCT_ULTIMATE 0x00000001")]
    public const int PRODUCT_ULTIMATE = 0x00000001;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOME_BASIC"]/*' />
    [NativeTypeName("#define PRODUCT_HOME_BASIC 0x00000002")]
    public const int PRODUCT_HOME_BASIC = 0x00000002;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOME_PREMIUM"]/*' />
    [NativeTypeName("#define PRODUCT_HOME_PREMIUM 0x00000003")]
    public const int PRODUCT_HOME_PREMIUM = 0x00000003;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE 0x00000004")]
    public const int PRODUCT_ENTERPRISE = 0x00000004;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOME_BASIC_N"]/*' />
    [NativeTypeName("#define PRODUCT_HOME_BASIC_N 0x00000005")]
    public const int PRODUCT_HOME_BASIC_N = 0x00000005;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_BUSINESS"]/*' />
    [NativeTypeName("#define PRODUCT_BUSINESS 0x00000006")]
    public const int PRODUCT_BUSINESS = 0x00000006;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_SERVER 0x00000007")]
    public const int PRODUCT_STANDARD_SERVER = 0x00000007;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_SERVER 0x00000008")]
    public const int PRODUCT_DATACENTER_SERVER = 0x00000008;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SMALLBUSINESS_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER 0x00000009")]
    public const int PRODUCT_SMALLBUSINESS_SERVER = 0x00000009;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER 0x0000000A")]
    public const int PRODUCT_ENTERPRISE_SERVER = 0x0000000A;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STARTER"]/*' />
    [NativeTypeName("#define PRODUCT_STARTER 0x0000000B")]
    public const int PRODUCT_STARTER = 0x0000000B;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_CORE 0x0000000C")]
    public const int PRODUCT_DATACENTER_SERVER_CORE = 0x0000000C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_SERVER_CORE 0x0000000D")]
    public const int PRODUCT_STANDARD_SERVER_CORE = 0x0000000D;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_CORE 0x0000000E")]
    public const int PRODUCT_ENTERPRISE_SERVER_CORE = 0x0000000E;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_SERVER_IA64"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_IA64 0x0000000F")]
    public const int PRODUCT_ENTERPRISE_SERVER_IA64 = 0x0000000F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_BUSINESS_N"]/*' />
    [NativeTypeName("#define PRODUCT_BUSINESS_N 0x00000010")]
    public const int PRODUCT_BUSINESS_N = 0x00000010;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_WEB_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_WEB_SERVER 0x00000011")]
    public const int PRODUCT_WEB_SERVER = 0x00000011;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLUSTER_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_CLUSTER_SERVER 0x00000012")]
    public const int PRODUCT_CLUSTER_SERVER = 0x00000012;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOME_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_HOME_SERVER 0x00000013")]
    public const int PRODUCT_HOME_SERVER = 0x00000013;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_EXPRESS_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_EXPRESS_SERVER 0x00000014")]
    public const int PRODUCT_STORAGE_EXPRESS_SERVER = 0x00000014;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_STANDARD_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_SERVER 0x00000015")]
    public const int PRODUCT_STORAGE_STANDARD_SERVER = 0x00000015;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_WORKGROUP_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_SERVER 0x00000016")]
    public const int PRODUCT_STORAGE_WORKGROUP_SERVER = 0x00000016;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_ENTERPRISE_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_ENTERPRISE_SERVER 0x00000017")]
    public const int PRODUCT_STORAGE_ENTERPRISE_SERVER = 0x00000017;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SERVER_FOR_SMALLBUSINESS"]/*' />
    [NativeTypeName("#define PRODUCT_SERVER_FOR_SMALLBUSINESS 0x00000018")]
    public const int PRODUCT_SERVER_FOR_SMALLBUSINESS = 0x00000018;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SMALLBUSINESS_SERVER_PREMIUM"]/*' />
    [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER_PREMIUM 0x00000019")]
    public const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 0x00000019;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOME_PREMIUM_N"]/*' />
    [NativeTypeName("#define PRODUCT_HOME_PREMIUM_N 0x0000001A")]
    public const int PRODUCT_HOME_PREMIUM_N = 0x0000001A;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_N"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_N 0x0000001B")]
    public const int PRODUCT_ENTERPRISE_N = 0x0000001B;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ULTIMATE_N"]/*' />
    [NativeTypeName("#define PRODUCT_ULTIMATE_N 0x0000001C")]
    public const int PRODUCT_ULTIMATE_N = 0x0000001C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_WEB_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_WEB_SERVER_CORE 0x0000001D")]
    public const int PRODUCT_WEB_SERVER_CORE = 0x0000001D;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT"]/*' />
    [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT 0x0000001E")]
    public const int PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 0x0000001E;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY"]/*' />
    [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY 0x0000001F")]
    public const int PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 0x0000001F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING"]/*' />
    [NativeTypeName("#define PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING 0x00000020")]
    public const int PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 0x00000020;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SERVER_FOUNDATION"]/*' />
    [NativeTypeName("#define PRODUCT_SERVER_FOUNDATION 0x00000021")]
    public const int PRODUCT_SERVER_FOUNDATION = 0x00000021;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOME_PREMIUM_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_HOME_PREMIUM_SERVER 0x00000022")]
    public const int PRODUCT_HOME_PREMIUM_SERVER = 0x00000022;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SERVER_FOR_SMALLBUSINESS_V"]/*' />
    [NativeTypeName("#define PRODUCT_SERVER_FOR_SMALLBUSINESS_V 0x00000023")]
    public const int PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 0x00000023;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_SERVER_V"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_SERVER_V 0x00000024")]
    public const int PRODUCT_STANDARD_SERVER_V = 0x00000024;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_SERVER_V"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_V 0x00000025")]
    public const int PRODUCT_DATACENTER_SERVER_V = 0x00000025;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_SERVER_V"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_V 0x00000026")]
    public const int PRODUCT_ENTERPRISE_SERVER_V = 0x00000026;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_SERVER_CORE_V"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_CORE_V 0x00000027")]
    public const int PRODUCT_DATACENTER_SERVER_CORE_V = 0x00000027;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_SERVER_CORE_V"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_SERVER_CORE_V 0x00000028")]
    public const int PRODUCT_STANDARD_SERVER_CORE_V = 0x00000028;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_SERVER_CORE_V"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_SERVER_CORE_V 0x00000029")]
    public const int PRODUCT_ENTERPRISE_SERVER_CORE_V = 0x00000029;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HYPERV"]/*' />
    [NativeTypeName("#define PRODUCT_HYPERV 0x0000002A")]
    public const int PRODUCT_HYPERV = 0x0000002A;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_EXPRESS_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_EXPRESS_SERVER_CORE 0x0000002B")]
    public const int PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 0x0000002B;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_STANDARD_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_SERVER_CORE 0x0000002C")]
    public const int PRODUCT_STORAGE_STANDARD_SERVER_CORE = 0x0000002C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_WORKGROUP_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_SERVER_CORE 0x0000002D")]
    public const int PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 0x0000002D;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE 0x0000002E")]
    public const int PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 0x0000002E;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STARTER_N"]/*' />
    [NativeTypeName("#define PRODUCT_STARTER_N 0x0000002F")]
    public const int PRODUCT_STARTER_N = 0x0000002F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL 0x00000030")]
    public const int PRODUCT_PROFESSIONAL = 0x00000030;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL_N"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL_N 0x00000031")]
    public const int PRODUCT_PROFESSIONAL_N = 0x00000031;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SB_SOLUTION_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_SB_SOLUTION_SERVER 0x00000032")]
    public const int PRODUCT_SB_SOLUTION_SERVER = 0x00000032;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SERVER_FOR_SB_SOLUTIONS"]/*' />
    [NativeTypeName("#define PRODUCT_SERVER_FOR_SB_SOLUTIONS 0x00000033")]
    public const int PRODUCT_SERVER_FOR_SB_SOLUTIONS = 0x00000033;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_SERVER_SOLUTIONS"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_SERVER_SOLUTIONS 0x00000034")]
    public const int PRODUCT_STANDARD_SERVER_SOLUTIONS = 0x00000034;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE 0x00000035")]
    public const int PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 0x00000035;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SB_SOLUTION_SERVER_EM"]/*' />
    [NativeTypeName("#define PRODUCT_SB_SOLUTION_SERVER_EM 0x00000036")]
    public const int PRODUCT_SB_SOLUTION_SERVER_EM = 0x00000036;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM"]/*' />
    [NativeTypeName("#define PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM 0x00000037")]
    public const int PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 0x00000037;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SOLUTION_EMBEDDEDSERVER"]/*' />
    [NativeTypeName("#define PRODUCT_SOLUTION_EMBEDDEDSERVER 0x00000038")]
    public const int PRODUCT_SOLUTION_EMBEDDEDSERVER = 0x00000038;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE 0x00000039")]
    public const int PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 0x00000039;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL_EMBEDDED"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL_EMBEDDED 0x0000003A")]
    public const int PRODUCT_PROFESSIONAL_EMBEDDED = 0x0000003A;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT"]/*' />
    [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT 0x0000003B")]
    public const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 0x0000003B;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL"]/*' />
    [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL 0x0000003C")]
    public const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 0x0000003C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC"]/*' />
    [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC 0x0000003D")]
    public const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 0x0000003D;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC"]/*' />
    [NativeTypeName("#define PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC 0x0000003E")]
    public const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 0x0000003E;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE 0x0000003F")]
    public const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 0x0000003F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLUSTER_SERVER_V"]/*' />
    [NativeTypeName("#define PRODUCT_CLUSTER_SERVER_V 0x00000040")]
    public const int PRODUCT_CLUSTER_SERVER_V = 0x00000040;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED 0x00000041")]
    public const int PRODUCT_EMBEDDED = 0x00000041;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STARTER_E"]/*' />
    [NativeTypeName("#define PRODUCT_STARTER_E 0x00000042")]
    public const int PRODUCT_STARTER_E = 0x00000042;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOME_BASIC_E"]/*' />
    [NativeTypeName("#define PRODUCT_HOME_BASIC_E 0x00000043")]
    public const int PRODUCT_HOME_BASIC_E = 0x00000043;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOME_PREMIUM_E"]/*' />
    [NativeTypeName("#define PRODUCT_HOME_PREMIUM_E 0x00000044")]
    public const int PRODUCT_HOME_PREMIUM_E = 0x00000044;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL_E"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL_E 0x00000045")]
    public const int PRODUCT_PROFESSIONAL_E = 0x00000045;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_E"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_E 0x00000046")]
    public const int PRODUCT_ENTERPRISE_E = 0x00000046;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ULTIMATE_E"]/*' />
    [NativeTypeName("#define PRODUCT_ULTIMATE_E 0x00000047")]
    public const int PRODUCT_ULTIMATE_E = 0x00000047;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_EVALUATION"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_EVALUATION 0x00000048")]
    public const int PRODUCT_ENTERPRISE_EVALUATION = 0x00000048;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_MULTIPOINT_STANDARD_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_MULTIPOINT_STANDARD_SERVER 0x0000004C")]
    public const int PRODUCT_MULTIPOINT_STANDARD_SERVER = 0x0000004C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_MULTIPOINT_PREMIUM_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_MULTIPOINT_PREMIUM_SERVER 0x0000004D")]
    public const int PRODUCT_MULTIPOINT_PREMIUM_SERVER = 0x0000004D;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_EVALUATION_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_EVALUATION_SERVER 0x0000004F")]
    public const int PRODUCT_STANDARD_EVALUATION_SERVER = 0x0000004F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_EVALUATION_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_EVALUATION_SERVER 0x00000050")]
    public const int PRODUCT_DATACENTER_EVALUATION_SERVER = 0x00000050;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_N_EVALUATION"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_N_EVALUATION 0x00000054")]
    public const int PRODUCT_ENTERPRISE_N_EVALUATION = 0x00000054;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_AUTOMOTIVE"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_AUTOMOTIVE 0x00000055")]
    public const int PRODUCT_EMBEDDED_AUTOMOTIVE = 0x00000055;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_INDUSTRY_A"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_A 0x00000056")]
    public const int PRODUCT_EMBEDDED_INDUSTRY_A = 0x00000056;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_THINPC"]/*' />
    [NativeTypeName("#define PRODUCT_THINPC 0x00000057")]
    public const int PRODUCT_THINPC = 0x00000057;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_A"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_A 0x00000058")]
    public const int PRODUCT_EMBEDDED_A = 0x00000058;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_INDUSTRY"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY 0x00000059")]
    public const int PRODUCT_EMBEDDED_INDUSTRY = 0x00000059;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_E"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_E 0x0000005A")]
    public const int PRODUCT_EMBEDDED_E = 0x0000005A;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_INDUSTRY_E"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_E 0x0000005B")]
    public const int PRODUCT_EMBEDDED_INDUSTRY_E = 0x0000005B;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_INDUSTRY_A_E"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_A_E 0x0000005C")]
    public const int PRODUCT_EMBEDDED_INDUSTRY_A_E = 0x0000005C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER 0x0000005F")]
    public const int PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 0x0000005F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER 0x00000060")]
    public const int PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 0x00000060;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE_ARM"]/*' />
    [NativeTypeName("#define PRODUCT_CORE_ARM 0x00000061")]
    public const int PRODUCT_CORE_ARM = 0x00000061;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE_N"]/*' />
    [NativeTypeName("#define PRODUCT_CORE_N 0x00000062")]
    public const int PRODUCT_CORE_N = 0x00000062;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE_COUNTRYSPECIFIC"]/*' />
    [NativeTypeName("#define PRODUCT_CORE_COUNTRYSPECIFIC 0x00000063")]
    public const int PRODUCT_CORE_COUNTRYSPECIFIC = 0x00000063;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE_SINGLELANGUAGE"]/*' />
    [NativeTypeName("#define PRODUCT_CORE_SINGLELANGUAGE 0x00000064")]
    public const int PRODUCT_CORE_SINGLELANGUAGE = 0x00000064;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_CORE 0x00000065")]
    public const int PRODUCT_CORE = 0x00000065;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL_WMC"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL_WMC 0x00000067")]
    public const int PRODUCT_PROFESSIONAL_WMC = 0x00000067;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_INDUSTRY_EVAL"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_EVAL 0x00000069")]
    public const int PRODUCT_EMBEDDED_INDUSTRY_EVAL = 0x00000069;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_INDUSTRY_E_EVAL"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_INDUSTRY_E_EVAL 0x0000006A")]
    public const int PRODUCT_EMBEDDED_INDUSTRY_E_EVAL = 0x0000006A;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_EVAL"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_EVAL 0x0000006B")]
    public const int PRODUCT_EMBEDDED_EVAL = 0x0000006B;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EMBEDDED_E_EVAL"]/*' />
    [NativeTypeName("#define PRODUCT_EMBEDDED_E_EVAL 0x0000006C")]
    public const int PRODUCT_EMBEDDED_E_EVAL = 0x0000006C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_NANO_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_NANO_SERVER 0x0000006D")]
    public const int PRODUCT_NANO_SERVER = 0x0000006D;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLOUD_STORAGE_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_CLOUD_STORAGE_SERVER 0x0000006E")]
    public const int PRODUCT_CLOUD_STORAGE_SERVER = 0x0000006E;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE_CONNECTED"]/*' />
    [NativeTypeName("#define PRODUCT_CORE_CONNECTED 0x0000006F")]
    public const int PRODUCT_CORE_CONNECTED = 0x0000006F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL_STUDENT"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL_STUDENT 0x00000070")]
    public const int PRODUCT_PROFESSIONAL_STUDENT = 0x00000070;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE_CONNECTED_N"]/*' />
    [NativeTypeName("#define PRODUCT_CORE_CONNECTED_N 0x00000071")]
    public const int PRODUCT_CORE_CONNECTED_N = 0x00000071;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL_STUDENT_N"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL_STUDENT_N 0x00000072")]
    public const int PRODUCT_PROFESSIONAL_STUDENT_N = 0x00000072;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE_CONNECTED_SINGLELANGUAGE"]/*' />
    [NativeTypeName("#define PRODUCT_CORE_CONNECTED_SINGLELANGUAGE 0x00000073")]
    public const int PRODUCT_CORE_CONNECTED_SINGLELANGUAGE = 0x00000073;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC"]/*' />
    [NativeTypeName("#define PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC 0x00000074")]
    public const int PRODUCT_CORE_CONNECTED_COUNTRYSPECIFIC = 0x00000074;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CONNECTED_CAR"]/*' />
    [NativeTypeName("#define PRODUCT_CONNECTED_CAR 0x00000075")]
    public const int PRODUCT_CONNECTED_CAR = 0x00000075;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_INDUSTRY_HANDHELD"]/*' />
    [NativeTypeName("#define PRODUCT_INDUSTRY_HANDHELD 0x00000076")]
    public const int PRODUCT_INDUSTRY_HANDHELD = 0x00000076;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PPI_PRO"]/*' />
    [NativeTypeName("#define PRODUCT_PPI_PRO 0x00000077")]
    public const int PRODUCT_PPI_PRO = 0x00000077;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ARM64_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_ARM64_SERVER 0x00000078")]
    public const int PRODUCT_ARM64_SERVER = 0x00000078;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EDUCATION"]/*' />
    [NativeTypeName("#define PRODUCT_EDUCATION 0x00000079")]
    public const int PRODUCT_EDUCATION = 0x00000079;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_EDUCATION_N"]/*' />
    [NativeTypeName("#define PRODUCT_EDUCATION_N 0x0000007A")]
    public const int PRODUCT_EDUCATION_N = 0x0000007A;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_IOTUAP"]/*' />
    [NativeTypeName("#define PRODUCT_IOTUAP 0x0000007B")]
    public const int PRODUCT_IOTUAP = 0x0000007B;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER 0x0000007C")]
    public const int PRODUCT_CLOUD_HOST_INFRASTRUCTURE_SERVER = 0x0000007C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_S"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_S 0x0000007D")]
    public const int PRODUCT_ENTERPRISE_S = 0x0000007D;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_S_N"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_S_N 0x0000007E")]
    public const int PRODUCT_ENTERPRISE_S_N = 0x0000007E;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL_S"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL_S 0x0000007F")]
    public const int PRODUCT_PROFESSIONAL_S = 0x0000007F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PROFESSIONAL_S_N"]/*' />
    [NativeTypeName("#define PRODUCT_PROFESSIONAL_S_N 0x00000080")]
    public const int PRODUCT_PROFESSIONAL_S_N = 0x00000080;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_S_EVALUATION"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_S_EVALUATION 0x00000081")]
    public const int PRODUCT_ENTERPRISE_S_EVALUATION = 0x00000081;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_S_N_EVALUATION"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_S_N_EVALUATION 0x00000082")]
    public const int PRODUCT_ENTERPRISE_S_N_EVALUATION = 0x00000082;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOLOGRAPHIC"]/*' />
    [NativeTypeName("#define PRODUCT_HOLOGRAPHIC 0x00000087")]
    public const int PRODUCT_HOLOGRAPHIC = 0x00000087;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HOLOGRAPHIC_BUSINESS"]/*' />
    [NativeTypeName("#define PRODUCT_HOLOGRAPHIC_BUSINESS 0x00000088")]
    public const int PRODUCT_HOLOGRAPHIC_BUSINESS = 0x00000088;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PRO_SINGLE_LANGUAGE"]/*' />
    [NativeTypeName("#define PRODUCT_PRO_SINGLE_LANGUAGE 0x0000008A")]
    public const int PRODUCT_PRO_SINGLE_LANGUAGE = 0x0000008A;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PRO_CHINA"]/*' />
    [NativeTypeName("#define PRODUCT_PRO_CHINA 0x0000008B")]
    public const int PRODUCT_PRO_CHINA = 0x0000008B;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_SUBSCRIPTION"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_SUBSCRIPTION 0x0000008C")]
    public const int PRODUCT_ENTERPRISE_SUBSCRIPTION = 0x0000008C;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISE_SUBSCRIPTION_N"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISE_SUBSCRIPTION_N 0x0000008D")]
    public const int PRODUCT_ENTERPRISE_SUBSCRIPTION_N = 0x0000008D;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_NANO_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_NANO_SERVER 0x0000008F")]
    public const int PRODUCT_DATACENTER_NANO_SERVER = 0x0000008F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_NANO_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_NANO_SERVER 0x00000090")]
    public const int PRODUCT_STANDARD_NANO_SERVER = 0x00000090;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_A_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_A_SERVER_CORE 0x00000091")]
    public const int PRODUCT_DATACENTER_A_SERVER_CORE = 0x00000091;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_A_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_A_SERVER_CORE 0x00000092")]
    public const int PRODUCT_STANDARD_A_SERVER_CORE = 0x00000092;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_WS_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_WS_SERVER_CORE 0x00000093")]
    public const int PRODUCT_DATACENTER_WS_SERVER_CORE = 0x00000093;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_WS_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_WS_SERVER_CORE 0x00000094")]
    public const int PRODUCT_STANDARD_WS_SERVER_CORE = 0x00000094;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_UTILITY_VM"]/*' />
    [NativeTypeName("#define PRODUCT_UTILITY_VM 0x00000095")]
    public const int PRODUCT_UTILITY_VM = 0x00000095;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_EVALUATION_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_EVALUATION_SERVER_CORE 0x0000009F")]
    public const int PRODUCT_DATACENTER_EVALUATION_SERVER_CORE = 0x0000009F;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_STANDARD_EVALUATION_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_STANDARD_EVALUATION_SERVER_CORE 0x000000A0")]
    public const int PRODUCT_STANDARD_EVALUATION_SERVER_CORE = 0x000000A0;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PRO_WORKSTATION"]/*' />
    [NativeTypeName("#define PRODUCT_PRO_WORKSTATION 0x000000A1")]
    public const int PRODUCT_PRO_WORKSTATION = 0x000000A1;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PRO_WORKSTATION_N"]/*' />
    [NativeTypeName("#define PRODUCT_PRO_WORKSTATION_N 0x000000A2")]
    public const int PRODUCT_PRO_WORKSTATION_N = 0x000000A2;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PRO_FOR_EDUCATION"]/*' />
    [NativeTypeName("#define PRODUCT_PRO_FOR_EDUCATION 0x000000A4")]
    public const int PRODUCT_PRO_FOR_EDUCATION = 0x000000A4;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_PRO_FOR_EDUCATION_N"]/*' />
    [NativeTypeName("#define PRODUCT_PRO_FOR_EDUCATION_N 0x000000A5")]
    public const int PRODUCT_PRO_FOR_EDUCATION_N = 0x000000A5;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_AZURE_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_AZURE_SERVER_CORE 0x000000A8")]
    public const int PRODUCT_AZURE_SERVER_CORE = 0x000000A8;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_AZURE_NANO_SERVER"]/*' />
    [NativeTypeName("#define PRODUCT_AZURE_NANO_SERVER 0x000000A9")]
    public const int PRODUCT_AZURE_NANO_SERVER = 0x000000A9;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISEG"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISEG 0x000000AB")]
    public const int PRODUCT_ENTERPRISEG = 0x000000AB;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ENTERPRISEGN"]/*' />
    [NativeTypeName("#define PRODUCT_ENTERPRISEGN 0x000000AC")]
    public const int PRODUCT_ENTERPRISEGN = 0x000000AC;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_SERVERRDSH"]/*' />
    [NativeTypeName("#define PRODUCT_SERVERRDSH 0x000000AF")]
    public const int PRODUCT_SERVERRDSH = 0x000000AF;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLOUD"]/*' />
    [NativeTypeName("#define PRODUCT_CLOUD 0x000000B2")]
    public const int PRODUCT_CLOUD = 0x000000B2;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLOUDN"]/*' />
    [NativeTypeName("#define PRODUCT_CLOUDN 0x000000B3")]
    public const int PRODUCT_CLOUDN = 0x000000B3;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_HUBOS"]/*' />
    [NativeTypeName("#define PRODUCT_HUBOS 0x000000B4")]
    public const int PRODUCT_HUBOS = 0x000000B4;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_ONECOREUPDATEOS"]/*' />
    [NativeTypeName("#define PRODUCT_ONECOREUPDATEOS 0x000000B6")]
    public const int PRODUCT_ONECOREUPDATEOS = 0x000000B6;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLOUDE"]/*' />
    [NativeTypeName("#define PRODUCT_CLOUDE 0x000000B7")]
    public const int PRODUCT_CLOUDE = 0x000000B7;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_IOTOS"]/*' />
    [NativeTypeName("#define PRODUCT_IOTOS 0x000000B9")]
    public const int PRODUCT_IOTOS = 0x000000B9;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLOUDEN"]/*' />
    [NativeTypeName("#define PRODUCT_CLOUDEN 0x000000BA")]
    public const int PRODUCT_CLOUDEN = 0x000000BA;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_IOTEDGEOS"]/*' />
    [NativeTypeName("#define PRODUCT_IOTEDGEOS 0x000000BB")]
    public const int PRODUCT_IOTEDGEOS = 0x000000BB;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_IOTENTERPRISE"]/*' />
    [NativeTypeName("#define PRODUCT_IOTENTERPRISE 0x000000BC")]
    public const int PRODUCT_IOTENTERPRISE = 0x000000BC;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_LITE"]/*' />
    [NativeTypeName("#define PRODUCT_LITE 0x000000BD")]
    public const int PRODUCT_LITE = 0x000000BD;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_IOTENTERPRISES"]/*' />
    [NativeTypeName("#define PRODUCT_IOTENTERPRISES 0x000000BF")]
    public const int PRODUCT_IOTENTERPRISES = 0x000000BF;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_XBOX_SYSTEMOS"]/*' />
    [NativeTypeName("#define PRODUCT_XBOX_SYSTEMOS 0x000000C0")]
    public const int PRODUCT_XBOX_SYSTEMOS = 0x000000C0;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_XBOX_GAMEOS"]/*' />
    [NativeTypeName("#define PRODUCT_XBOX_GAMEOS 0x000000C2")]
    public const int PRODUCT_XBOX_GAMEOS = 0x000000C2;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_XBOX_ERAOS"]/*' />
    [NativeTypeName("#define PRODUCT_XBOX_ERAOS 0x000000C3")]
    public const int PRODUCT_XBOX_ERAOS = 0x000000C3;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_XBOX_DURANGOHOSTOS"]/*' />
    [NativeTypeName("#define PRODUCT_XBOX_DURANGOHOSTOS 0x000000C4")]
    public const int PRODUCT_XBOX_DURANGOHOSTOS = 0x000000C4;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_XBOX_SCARLETTHOSTOS"]/*' />
    [NativeTypeName("#define PRODUCT_XBOX_SCARLETTHOSTOS 0x000000C5")]
    public const int PRODUCT_XBOX_SCARLETTHOSTOS = 0x000000C5;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_XBOX_KEYSTONE"]/*' />
    [NativeTypeName("#define PRODUCT_XBOX_KEYSTONE 0x000000C6")]
    public const int PRODUCT_XBOX_KEYSTONE = 0x000000C6;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_AZURE_SERVER_CLOUDHOST"]/*' />
    [NativeTypeName("#define PRODUCT_AZURE_SERVER_CLOUDHOST 0x000000C7")]
    public const int PRODUCT_AZURE_SERVER_CLOUDHOST = 0x000000C7;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_AZURE_SERVER_CLOUDMOS"]/*' />
    [NativeTypeName("#define PRODUCT_AZURE_SERVER_CLOUDMOS 0x000000C8")]
    public const int PRODUCT_AZURE_SERVER_CLOUDMOS = 0x000000C8;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLOUDEDITIONN"]/*' />
    [NativeTypeName("#define PRODUCT_CLOUDEDITIONN 0x000000CA")]
    public const int PRODUCT_CLOUDEDITIONN = 0x000000CA;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_CLOUDEDITION"]/*' />
    [NativeTypeName("#define PRODUCT_CLOUDEDITION 0x000000CB")]
    public const int PRODUCT_CLOUDEDITION = 0x000000CB;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_VALIDATION"]/*' />
    [NativeTypeName("#define PRODUCT_VALIDATION 0x000000CC")]
    public const int PRODUCT_VALIDATION = 0x000000CC;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_IOTENTERPRISESK"]/*' />
    [NativeTypeName("#define PRODUCT_IOTENTERPRISESK 0x000000CD")]
    public const int PRODUCT_IOTENTERPRISESK = 0x000000CD;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_IOTENTERPRISEK"]/*' />
    [NativeTypeName("#define PRODUCT_IOTENTERPRISEK 0x000000CE")]
    public const int PRODUCT_IOTENTERPRISEK = 0x000000CE;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_IOTENTERPRISESEVAL"]/*' />
    [NativeTypeName("#define PRODUCT_IOTENTERPRISESEVAL 0x000000CF")]
    public const int PRODUCT_IOTENTERPRISESEVAL = 0x000000CF;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_AZURE_SERVER_AGENTBRIDGE"]/*' />
    [NativeTypeName("#define PRODUCT_AZURE_SERVER_AGENTBRIDGE 0x000000D0")]
    public const int PRODUCT_AZURE_SERVER_AGENTBRIDGE = 0x000000D0;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_AZURE_SERVER_NANOHOST"]/*' />
    [NativeTypeName("#define PRODUCT_AZURE_SERVER_NANOHOST 0x000000D1")]
    public const int PRODUCT_AZURE_SERVER_NANOHOST = 0x000000D1;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_WNC"]/*' />
    [NativeTypeName("#define PRODUCT_WNC 0x000000D2")]
    public const int PRODUCT_WNC = 0x000000D2;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_AZURESTACKHCI_SERVER_CORE"]/*' />
    [NativeTypeName("#define PRODUCT_AZURESTACKHCI_SERVER_CORE 0x00000196")]
    public const int PRODUCT_AZURESTACKHCI_SERVER_CORE = 0x00000196;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_SERVER_AZURE_EDITION"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_AZURE_EDITION 0x00000197")]
    public const int PRODUCT_DATACENTER_SERVER_AZURE_EDITION = 0x00000197;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_SERVER_CORE_AZURE_EDITION"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_SERVER_CORE_AZURE_EDITION 0x00000198")]
    public const int PRODUCT_DATACENTER_SERVER_CORE_AZURE_EDITION = 0x00000198;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_DATACENTER_WS_SERVER_CORE_AZURE_EDITION"]/*' />
    [NativeTypeName("#define PRODUCT_DATACENTER_WS_SERVER_CORE_AZURE_EDITION 0x00000199")]
    public const int PRODUCT_DATACENTER_WS_SERVER_CORE_AZURE_EDITION = 0x00000199;

    /// <include file='PRODUCT.xml' path='doc/member[@name="PRODUCT.PRODUCT_UNLICENSED"]/*' />
    [NativeTypeName("#define PRODUCT_UNLICENSED 0xABCDABCD")]
    public const uint PRODUCT_UNLICENSED = 0xABCDABCD;
}
