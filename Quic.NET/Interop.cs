using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Net.Quic
{
    internal static partial class Interop
    {

        internal static unsafe class Crypt32
        {
            internal static bool CertVerifyCertificateChainPolicy(global::System.IntPtr pszPolicyOID,
                global::Microsoft.Win32.SafeHandles.SafeX509ChainHandle pChainContext, ref CERT_CHAIN_POLICY_PARA pPolicyPara, ref CERT_CHAIN_POLICY_STATUS pPolicyStatus)
            {
                System.IntPtr __pChainContext_gen_native = default;
                bool __retVal;
                int __retVal_gen_native = default;
                int __lastError;
                //
                // Setup
                //
                bool pChainContext__addRefd = false;
                try
                {
                    //
                    // Marshal
                    //
                    pChainContext.DangerousAddRef(ref pChainContext__addRefd);
                    __pChainContext_gen_native = pChainContext.DangerousGetHandle();
                    fixed (CERT_CHAIN_POLICY_PARA* __pPolicyPara_gen_native = &pPolicyPara)
                    fixed (CERT_CHAIN_POLICY_STATUS* __pPolicyStatus_gen_native = &pPolicyStatus)
                    {
                        {
                            System.Runtime.InteropServices.Marshal.SetLastSystemError(0);
                            __retVal_gen_native = __PInvoke__(pszPolicyOID, __pChainContext_gen_native, __pPolicyPara_gen_native, __pPolicyStatus_gen_native);
                            __lastError = System.Runtime.InteropServices.Marshal.GetLastSystemError();
                        }
                    }

                    //
                    // Unmarshal
                    //
                    __retVal = __retVal_gen_native != 0;
                }
                finally
                {
                    //
                    // Cleanup
                    //
                    if (pChainContext__addRefd)
                        pChainContext.DangerousRelease();
                }

                System.Runtime.InteropServices.Marshal.SetLastPInvokeError(__lastError);
                return __retVal;
                //
                // Local P/Invoke
                //
                [System.Runtime.InteropServices.DllImportAttribute("crypt32.dll", EntryPoint = "CertVerifyCertificateChainPolicy", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
                extern static unsafe int __PInvoke__(global::System.IntPtr pszPolicyOID, System.IntPtr pChainContext, CERT_CHAIN_POLICY_PARA* pPolicyPara, CERT_CHAIN_POLICY_STATUS* pPolicyStatus);
            }

            internal static partial class AuthType
            {
                internal const uint AUTHTYPE_CLIENT = 1;
                internal const uint AUTHTYPE_SERVER = 2;
            }

            internal static partial class CertChainPolicyIgnoreFlags
            {
                internal const uint CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG = 0x00000001;
                internal const uint CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG = 0x00000002;
                internal const uint CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG = 0x00000004;
                internal const uint CERT_CHAIN_POLICY_IGNORE_INVALID_BASIC_CONSTRAINTS_FLAG = 0x00000008;
                internal const uint CERT_CHAIN_POLICY_ALLOW_UNKNOWN_CA_FLAG = 0x00000010;
                internal const uint CERT_CHAIN_POLICY_IGNORE_WRONG_USAGE_FLAG = 0x00000020;
                internal const uint CERT_CHAIN_POLICY_IGNORE_INVALID_NAME_FLAG = 0x00000040;
                internal const uint CERT_CHAIN_POLICY_IGNORE_INVALID_POLICY_FLAG = 0x00000080;
                internal const uint CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG = 0x00000100;
                internal const uint CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG = 0x00000200;
                internal const uint CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG = 0x00000400;
                internal const uint CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG = 0x00000800;

                internal const uint CERT_CHAIN_POLICY_IGNORE_ALL =
                    CERT_CHAIN_POLICY_IGNORE_NOT_TIME_VALID_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_CTL_NOT_TIME_VALID_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_NOT_TIME_NESTED_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_INVALID_BASIC_CONSTRAINTS_FLAG |
                    CERT_CHAIN_POLICY_ALLOW_UNKNOWN_CA_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_WRONG_USAGE_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_INVALID_NAME_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_INVALID_POLICY_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_END_REV_UNKNOWN_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_CTL_SIGNER_REV_UNKNOWN_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_CA_REV_UNKNOWN_FLAG |
                    CERT_CHAIN_POLICY_IGNORE_ROOT_REV_UNKNOWN_FLAG;
            }

            internal static partial class CertChainPolicy
            {
                internal const int CERT_CHAIN_POLICY_BASE = 1;
                internal const int CERT_CHAIN_POLICY_AUTHENTICODE = 2;
                internal const int CERT_CHAIN_POLICY_AUTHENTICODE_TS = 3;
                internal const int CERT_CHAIN_POLICY_SSL = 4;
                internal const int CERT_CHAIN_POLICY_BASIC_CONSTRAINTS = 5;
                internal const int CERT_CHAIN_POLICY_NT_AUTH = 6;
                internal const int CERT_CHAIN_POLICY_MICROSOFT_ROOT = 7;
                internal const int CERT_CHAIN_POLICY_EV = 8;
            }

            internal static partial class CertChainPolicyErrors
            {
                // Base Policy errors (CERT_CHAIN_POLICY_BASE).
                internal const uint TRUST_E_CERT_SIGNATURE = 0x80096004;
                internal const uint CRYPT_E_REVOKED = 0x80092010;
                internal const uint CERT_E_UNTRUSTEDROOT = 0x800B0109;
                internal const uint CERT_E_UNTRUSTEDTESTROOT = 0x800B010D;
                internal const uint CERT_E_CHAINING = 0x800B010A;
                internal const uint CERT_E_WRONG_USAGE = 0x800B0110;
                internal const uint CERT_E_EXPIRE = 0x800B0101;
                internal const uint CERT_E_INVALID_NAME = 0x800B0114;
                internal const uint CERT_E_INVALID_POLICY = 0x800B0113;

                // Basic Constraints Policy errors (CERT_CHAIN_POLICY_BASIC_CONSTRAINTS).
                internal const uint TRUST_E_BASIC_CONSTRAINTS = 0x80096019;

                // Authenticode Policy errors (CERT_CHAIN_POLICY_AUTHENTICODE and CERT_CHAIN_POLICY_AUTHENTICODE_TS).
                internal const uint CERT_E_CRITICAL = 0x800B0105;
                internal const uint CERT_E_VALIDITYPERIODNESTING = 0x800B0102;
                internal const uint CRYPT_E_NO_REVOCATION_CHECK = 0x80092012;
                internal const uint CRYPT_E_REVOCATION_OFFLINE = 0x80092013;
                internal const uint CERT_E_PURPOSE = 0x800B0106;
                internal const uint CERT_E_REVOKED = 0x800B010C;
                internal const uint CERT_E_REVOCATION_FAILURE = 0x800B010E;

                // SSL Policy errors (CERT_CHAIN_POLICY_SSL).
                internal const uint CERT_E_CN_NO_MATCH = 0x800B010F;
                internal const uint CERT_E_ROLE = 0x800B0103;
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal unsafe struct SSL_EXTRA_CERT_CHAIN_POLICY_PARA
            {
                internal uint cbSize;
                internal uint dwAuthType;
                internal uint fdwChecks;
                internal ushort* pwszServerName;
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal unsafe struct CERT_CHAIN_POLICY_PARA
            {
                public uint cbSize;
                public uint dwFlags;
                public SSL_EXTRA_CERT_CHAIN_POLICY_PARA* pvExtraPolicyPara;
            }

            [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
            internal unsafe struct CERT_CHAIN_POLICY_STATUS
            {
                public uint cbSize;
                public uint dwError;
                public int lChainIndex;
                public int lElementIndex;
                public void* pvExtraPolicyStatus;
            }
        }
    }
}
